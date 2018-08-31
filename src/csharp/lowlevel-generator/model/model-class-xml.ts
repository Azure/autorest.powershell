import { items, values } from '#common/dictionary';
import { EOL } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { IsDeclaration } from '#csharp/code-dom/expression';
import { Method, PartialMethod } from '#csharp/code-dom/method';
import { Parameter } from '#csharp/code-dom/parameter';
import { ParameterModifier } from '#csharp/code-dom/parameter-modifier';
import { TerminalCase } from '#csharp/code-dom/statements/case';
import { If, Not } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { Statements } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Ternery } from '#csharp/code-dom/ternery';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';

import { KnownMediaType } from '#common/media-types';
import { ModelClass } from '#csharp/lowlevel-generator/model/model-class';
import { EnhancedTypeDeclaration } from '#csharp/schema/extended-type-declaration';
import { HeaderProperty, HeaderPropertyType } from '#remodeler/tweak-model';
import { ModelProperty } from './property';
import { pushTempVar, popTempVar } from '#csharp/schema/primitive';
import { System, dotnet } from '#csharp/code-dom/dotnet';

export class XmlSerializableClass extends Class {
  private btj!: Method;
  private atj!: Method;
  private bfj!: Method;
  private afj!: Method;

  constructor(protected modelClass: ModelClass, objectInitializer?: Partial<XmlSerializableClass>) {
    super(modelClass.namespace, modelClass.name);
    this.apply(objectInitializer);
    this.partial = true;

    this.addPartialMethods();

    // set up the declaration for the toXml method.
    const container = new Parameter('container', System.Xml.Linq.XElement, { description: `The <see cref="${System.Xml.Linq.XElement}"/> container to serialize this object into. If the caller passes in <c>null</c>, a new instance will be created and returned to the caller.` });
    const mode = new Parameter('serializationMode', ClientRuntime.SerializationMode, { description: `Allows the caller to choose the depth of the serialization. See <see cref="${ClientRuntime.SerializationMode}"/c>.` });

    const toXmlMethod = this.addMethod(new Method('ToXml', System.Xml.Linq.XElement, {
      parameters: [container, mode],
    }));

    // setup the declaration for the xml deserializer constructor
    const xmlParameter = new Parameter('xml', System.Xml.Linq.XElement, { description: `A ${System.Xml.Linq.XElement} instance to deserialize from.` });
    const deserializerConstructor = this.addMethod(new Constructor(this, {
      parameters: [xmlParameter], access: Access.Internal,
      description: `Deserializes a ${System.Xml.Linq.XElement} into a new instance of <see cref="${this.name}" />.`
    }));

    const serializeStatements = new Statements();
    const deserializeStatements = new Statements();

    for (const each of values(modelClass.backingFields)) {
      serializeStatements.add(`${each.field.value}?.ToXml(result, ${mode.use});`);
      deserializeStatements.add(`${each.field.value} = new ${each.className}(xml);`);
    }
    pushTempVar();
    for (const { value: property } of items(modelClass.schema.properties)) {
      const prop = modelClass.$<ModelProperty>(property.details.csharp.name);
      const serializeStatement = (<EnhancedTypeDeclaration>prop.type).serializeToContainerMember(KnownMediaType.Xml, prop, container, prop.serializedName);

      if (property.details.csharp[HeaderProperty] === HeaderPropertyType.Header) {
        // it's a header only property. Don't serialize unless the mode has SerializationMode.IncludeHeaders enabled
        serializeStatements.add(If(`${mode.use}.HasFlag(${ClientRuntime.SerializationMode.IncludeHeaders})`, serializeStatement));
      } else {
        if (property.schema.readOnly) {
          serializeStatements.add(If(`${mode.use}.HasFlag(${ClientRuntime.SerializationMode.IncludeReadOnly})`, serializeStatement));
        } else {
          serializeStatements.add(serializeStatement);
        }
      }
      deserializeStatements.add(prop.assignPrivate((<EnhancedTypeDeclaration>prop.type).deserializeFromContainerMember(KnownMediaType.Xml, xmlParameter, prop.serializedName, prop)));
    }
    popTempVar();
    const $this = this;

    // generate the implementation for toXml
    toXmlMethod.add(function* () {
      yield `${container} = ${container} ?? new ${System.Xml.Linq.XElement.declaration}(nameof(${$this.modelClass.name}));`;
      yield EOL;

      yield `bool returnNow = false;`;
      yield `${$this.btj.name}(ref ${container}, ref returnNow);`;

      yield If(`returnNow`, `return ${container};`);

      // get serialization statements
      yield serializeStatements;

      yield `${$this.atj.name}(ref ${container});`;
      yield Return(container);
    });

    // and let's fill in the deserializer constructor statements now.
    deserializerConstructor.add(function* () {
      yield `bool returnNow = false;`;
      yield `${$this.bfj.name}(xml, ref returnNow);`;
      yield If(`returnNow`, `return;`);

      yield deserializeStatements;
      yield `${$this.afj.name}(xml);`;
    });
  }

  public get definition(): string {
    const $this = this.modelClass;
    // gotta write this just before we write out the class, since we had to wait until everyone had reported to their parents.
    const d = this.modelClass.discriminators;
    const isp = this.modelClass.isPolymorphic;
    // create the FromXml method
    const node = new Parameter('node', System.Xml.Linq.XElement, { description: `A ${System.Xml.Linq.XElement} instance to deserialize from.` });
    const fromXml = this.addMethod(new Method('FromXml', this.modelClass.modelInterface, { parameters: [node], static: Modifier.Static }));
    fromXml.add(function* () {

      const xml = IsDeclaration(node, System.Xml.Linq.XElement, 'xml');

      if (isp) {
        yield If(Not(xml.check), Return(dotnet.Null));
        yield '// Polymorphic type -- select the appropriate constructor using the discriminator';
        /** go thru the list of polymorphic values for the discriminator, and call the target class's constructor for that */

        if ($this.schema.discriminator) {
          yield Switch(`xml.StringProperty("${$this.schema.discriminator.propertyName}")`, function* () {
            for (const { key, value } of items(d)) {
              yield TerminalCase(`"${key}"`, function* () {
                yield Return(value.new(xml));
              });
            }
          });
        }
        yield Return($this.new(xml));
      } else {
        // just tell it to create the instance (providing that it's a XElement)
        yield Return(Ternery(xml.check, $this.new(xml), dotnet.Null));
      }
    });

    return super.definition;
  }

  public get fileName(): string {
    return `${super.fileName}.xml`;
  }

  protected addPartialMethods() {
    // add partial methods for future customization
    this.btj = this.addMethod(new PartialMethod('BeforeToXml', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', System.Xml.Linq.XElement, { modifier: ParameterModifier.Ref, description: 'The XElement  that the serialization result will be placed in.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the serialization should be processed, or if the method should return instantly.' }),
      ],
    }));

    this.atj = this.addMethod(new PartialMethod('AfterToXml', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', System.Xml.Linq.XElement, { modifier: ParameterModifier.Ref, description: 'The XElement that the serialization result will be placed in.' }),
      ],
    }));

    this.bfj = this.addMethod(new PartialMethod('BeforeFromXml', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('xml', System.Xml.Linq.XElement, { description: 'The XmlNode that should be deserialized into this object.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the deserialization should be processed, or if the method should return instantly.' }),
      ],
    }));

    this.afj = this.addMethod(new PartialMethod('AfterFromXml', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('xml', System.Xml.Linq.XElement, { description: 'The XmlNode that should be deserialized into this object.' }),
      ],
    }));
  }

}
