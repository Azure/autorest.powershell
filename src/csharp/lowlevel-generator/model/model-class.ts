
import { any, items, keys, values } from '#common/dictionary';
import { camelCase, deconstruct, EOL, fixLeadingNumber, fixPropertyName, indent, pascalCase } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { Is, IsDeclaration, LiteralExpression } from '#csharp/code-dom/expression';
import { InitializedField } from '#csharp/code-dom/field';
import { Method, PartialMethod } from '#csharp/code-dom/method';
import * as dotnet from '#csharp/code-dom/mscorlib';
import { Namespace } from '#csharp/code-dom/namespace';
import { Parameter } from '#csharp/code-dom/parameter';
import { ParameterModifier } from '#csharp/code-dom/parameter-modifier';
import { Case, TerminalCase } from '#csharp/code-dom/statements/case';
import { ForEach } from '#csharp/code-dom/statements/for';
import { If, Not } from '#csharp/code-dom/statements/if';
import { Return } from '#csharp/code-dom/statements/return';
import { OneOrMoreStatements, Statements } from '#csharp/code-dom/statements/statement';
import { Switch } from '#csharp/code-dom/statements/switch';
import { Ternery } from '#csharp/code-dom/ternery';
import { ClientRuntime } from '#csharp/lowlevel-generator/clientruntime';

import { HeaderProperty, HeaderPropertyType } from '#remodeler/tweak-model';
import { forEachLeadingCommentRange } from 'typescript';
import { State } from '../generator';
import { ModelInterface } from './interface';
import { ModelProperty } from './property';
import { ProxyProperty } from './proxy-property';
import { Schema } from '#csharp/lowlevel-generator/code-model';
import { Serialization, Validation } from '#csharp/schema/extended-type-declaration';
import { ObjectFeatures } from '#csharp/schema/object';


export class ModelClass extends Class implements Serialization, Validation {

  public isPolymorphic: boolean;
  //  public serializeStatements = new Statements();
  private validateMethod?: Method;
  private discriminators: Map<string, ModelClass>;
  private parentModelClasses: Array<ModelClass>;
  private modelInterface: ModelInterface;
  private get schema() { return this.objectFeatures.schema; }
  private state: State;
  private btj!: Method;
  private atj!: Method;
  private bfj!: Method;
  private afj!: Method;
  public hasHeaderProperties: boolean;
  private objectFeatures: ObjectFeatures;

  constructor(namespace: Namespace, schemaWithFeatures: ObjectFeatures, state: State, objectInitializer?: Partial<ModelClass>) {

    super(namespace, schemaWithFeatures.schema.details.csharp.name);
    this.objectFeatures = schemaWithFeatures;
    this.isPolymorphic = false;
    this.discriminators = new Map<string, ModelClass>();
    this.parentModelClasses = new Array<ModelClass>();
    this.state = state;

    this.apply(objectInitializer);
    this.partial = true;

    // create an interface for this model class

    // mark the code-model with the class we're creating.
    this.schema.details.csharp.classImplementation = this;

    const modelInterface = this.schema.details.csharp.interfaceImplementation || new ModelInterface(this.namespace, this.schema, this, this.state);
    this.interfaces.push(modelInterface);
    this.modelInterface = modelInterface;

    // add Partial methods for serialization
    this.addPartialMethods();

    // set up the declaration for the toJson method.
    const container = new Parameter('container', ClientRuntime.JsonObject);
    const mode = new Parameter('serializationMode', ClientRuntime.JsonMode);

    const toJsonMethod = this.addMethod(new Method('ToJson', ClientRuntime.JsonNode, {
      parameters: [container, mode],
    }));

    // setup the declaration for the json deserializer constructor
    const deserializerConstructor = this.addMethod(new Constructor(this, { parameters: [new Parameter('json', ClientRuntime.JsonObject)], access: Access.Internal }));

    if (this.schema.discriminator) {
      // this has a discriminator property.
      // our children are expected to tell us who they are
      this.isPolymorphic = true;
      // we'll add a deserializer factory method a bit later..
    }

    this.hasHeaderProperties = values(this.schema.properties).linq.any(property => property.details.csharp[HeaderProperty] === HeaderPropertyType.Header || property.details.csharp[HeaderProperty] === HeaderPropertyType.Header);

    if (this.schema.extensions['x-ms-discriminator-value']) {
      // we have a discriminator value, and we should tell our parent who we are so that they can build a proper deserializer method.
      // um. just how do we *really* know which allOf is polymorphic?
      // that's really sad.
      for (const eachAllOf of items(this.schema.allOf)) {
        const parentSchema = eachAllOf.value;
        const aState = this.state.path('allOf', eachAllOf.key);

        const parentDecl = this.state.project.modelsNamespace.resolveTypeDeclaration(parentSchema, true, aState);

        const parentClass = <ModelClass>parentSchema.details.csharp.classImplementation;
        if (parentClass.isPolymorphic) {
          // remember this class for later.
          this.parentModelClasses.push(parentClass);

          // tell that parent who we are.
          parentClass.addDiscriminator(this.schema.extensions['x-ms-discriminator-value'], this);
        }
      }
    }

    const defaultConstructor = this.addMethod(new Constructor(this)); // default constructor for fits and giggles.

    const serializeStatements = new Statements();
    const deserializeStatements = new Statements();
    const validationStatements = new Statements();

    // handle <allOf>s
    // add an 'implements' for the interface for the allOf.
    for (const eachSchema of items(this.schema.allOf)) {
      // gs01: Critical -- pull thru parent allOf's!
      const aSchema = eachSchema.value;

      const aState = this.state.path('allOf', eachSchema.key);

      const td = this.state.project.modelsNamespace.resolveTypeDeclaration(aSchema, true, aState);
      const className = (<ModelClass>aSchema.details.csharp.classImplementation).fullName;
      const fieldName = camelCase(deconstruct(className.replace(/^.*\./, '')));

      // add the interface as a parent to our interface.
      const iface = <ModelInterface>aSchema.details.csharp.interfaceImplementation;

      modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new InitializedField(`_${fieldName}`, td, { value: `new ${className}()` }, { access: Access.Private }));

      // now, create proxy properties for the members
      iface.allProperties.map((each) => {
        // make sure we don't over expose read-only properties.
        const p = this.add(new ProxyProperty(backingField, each, this.state));
        if (each.setAccess === Access.Internal) {
          p.setterStatements = undefined;
        }
        return p;
      });

      serializeStatements.add(`${backingField.value}?.ToJson(result, ${mode.use});`);
      deserializeStatements.add(`${backingField.value} = new ${className}(json);`);
      validationStatements.add(td.validatePresence(backingField.name));
      validationStatements.add(td.validateValue(backingField.name));
    }
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.

    // add properties
    for (const { key: propertyName, value: property } of items(this.schema.properties)) {
      const prop = new ModelProperty(this, property, propertyName, this.state.path('properties', propertyName));
      this.add(prop);

      if (property.details.csharp[HeaderProperty] === HeaderPropertyType.Header) {
        // it's a header only property. Don't serialize unless the mode has Microsoft.Rest.ClientRuntime.JsonMode.IncludeHeaders enabled
        serializeStatements.add(If({ value: `${mode.use}.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeHeaders)` }, prop.jsonSerializationStatement));
      } else {
        if (property.schema.readOnly) {
          serializeStatements.add(If({ value: `${mode.use}.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly)` }, prop.jsonSerializationStatement));
        } else {
          serializeStatements.add(prop.jsonSerializationStatement);
        }
      }
      deserializeStatements.add(prop.jsonDeserializationStatement);
      validationStatements.add(prop.validatePresenceStatement);
      validationStatements.add(prop.validationStatement);
    }

    if (this.schema.additionalProperties) {
      if (this.schema.additionalProperties === true) {
        // we should generate an additionalProperties property that catches all extra properties as object
        const valueSchema = {};
      } else {
        // we should generate an additionalProperties property that catches all extra properties as the type specified by
        const valueSchema = this.schema.additionalProperties;
      }
    }

    if (validationStatements.count > 0) {
      // we do have something to valdiate!

      // add the IValidates implementation to this object.
      this.interfaces.push(ClientRuntime.IValidates);
      this.validateMethod = this.addMethod(new Method('Validate', dotnet.System.Threading.Tasks.Task(), {
        async: Modifier.Async,
        parameters: [new Parameter('listener', ClientRuntime.IEventListener)],
      }));
      this.validateMethod.add(validationStatements);
    }

    const $this = this;

    // generate the implementation for toJson
    toJsonMethod.add(function* () {
      yield `var result = ${container.use} ?? new ${ClientRuntime.JsonObject.declaration}();`;
      yield EOL;

      yield `bool returnNow = false;`;
      yield `${$this.btj.name}(ref result, ref returnNow);`;

      yield If({ value: `returnNow` }, `return result;`);

      // get serialization statements
      yield serializeStatements;

      yield `${$this.atj.name}(ref result);`;
      yield `return result;`;
    });

    // and let's fill in the deserializer constructor statements now.

    deserializerConstructor.add(function* () {
      yield `bool returnNow = false;`;
      yield `${$this.bfj.name}(json, ref returnNow);`;
      yield If({ value: `returnNow` }, `return;`);

      yield deserializeStatements;
      yield `${$this.afj.name}(json);`;
    });

    // add from headers method if class or any of the parents pulls in header values.
    // FromHeaders( headers IEnumerable<KeyValuePair<string, IEnumerable<string>>> ) { ... }

    const headerProperties = values(this.properties).linq.where(p => (<ModelProperty>p).IsHeaderProperty);

    if (this.hasHeaderProperties) {
      // add header deserializer method
      const headers = new Parameter('headers', ClientRuntime.KeyValuePairs);
      const readHeaders = new Method('ReadHeaders', this, {
        access: Access.Internal,
        parameters: [headers],
        *body() {

          yield ForEach('header', headers, function* () {
            yield Switch({ value: 'header.Key' }, function* () {

              for (const hparam of headerProperties) {
                yield Case(`"${(<ModelProperty>hparam).serializedName}"`, (<ModelProperty>hparam).assignPrivate(new LiteralExpression('header.Value')));
              }
            });
            yield '';
          });
          yield `return this;`;
        }
      }).addTo(this);

    }
  }

  public get definition(): string {
    const $this = this;
    // gotta write this just before we write out the class, since we had to wait until everyone had reported to their parents.
    const d = this.discriminators;
    const isp = this.isPolymorphic;
    // create the FromJson method
    const node = new Parameter('node', ClientRuntime.JsonNode);
    const fromJson = this.addMethod(new Method('FromJson', this.modelInterface, { parameters: [node], static: Modifier.Static }));
    fromJson.add(function* () {

      const json = IsDeclaration(node, ClientRuntime.JsonObject, 'json');

      if (isp) {
        yield If(Not(json.check), Return(dotnet.Null));
        yield '// Polymorphic type -- select the appropriate constructor using the discriminator';
        /** go thru the list of polymorphic values for the discriminator, and call the target class's constructor for that */

        if ($this.schema.discriminator) {
          yield Switch({ value: `json.StringProperty("${$this.schema.discriminator.propertyName}")` }, function* () {
            for (const { key, value } of items(d)) {
              yield TerminalCase(`"${key}"`, function* () {
                yield Return(value.newInstance(json));
              });
            }
          });
        }
        yield Return($this.newInstance(json));
      } else {
        // just tell it to create the instance (providing that it's a JSonObject)
        yield Return(Ternery(json.check, $this.newInstance(json), dotnet.Null));
      }
    });

    return super.definition;
  }

  public validateValue(propertyName: string): OneOrMoreStatements {
    return this.objectFeatures.validateValue(propertyName);
  }
  public validatePresence(propertyName: string): OneOrMoreStatements {
    return this.objectFeatures.validatePresence(propertyName);
  }
  jsonSerializationImplementation(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.objectFeatures.jsonSerializationImplementation(containerName, propertyName, serializedName);
  }
  jsonDeserializationImplementationOnProperty(containerName: string, propertyName: string, serializedName: string): OneOrMoreStatements {
    return this.objectFeatures.jsonDeserializationImplementationOnProperty(containerName, propertyName, serializedName);
  }
  jsonDeserializationImplementationOnNode(nodeExpression: string): OneOrMoreStatements {
    return this.objectFeatures.jsonDeserializationImplementationOnNode(nodeExpression);
  }
  serializeInstanceToJson(instance: string): OneOrMoreStatements {
    return this.objectFeatures.serializeInstanceToJson(instance);
  }


  public addDiscriminator(discriminatorValue: string, modelClass: ModelClass) {
    this.discriminators.set(discriminatorValue, modelClass);

    // tell any polymorphic parents incase we're doing subclass of a subclass.
    for (const each of this.parentModelClasses) {
      each.addDiscriminator(discriminatorValue, modelClass);
    }
  }

  protected addPartialMethods() {
    // add partial methods for future customization
    this.btj = this.addMethod(new PartialMethod('BeforeToJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', ClientRuntime.JsonObject, { modifier: ParameterModifier.Ref, description: 'The JSON container that the serialization result will be placed in.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the serialization should be processed, or if the method should return instantly.' }),
      ],
    }));

    this.atj = this.addMethod(new PartialMethod('AfterToJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('container', ClientRuntime.JsonObject, { modifier: ParameterModifier.Ref, description: 'The JSON container that the serialization result will be placed in.' }),
      ],
    }));

    this.bfj = this.addMethod(new PartialMethod('BeforeFromJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('json', ClientRuntime.JsonObject, { description: 'The JsonNode that should be deserialized into this object.' }),
        new Parameter('returnNow', dotnet.Bool, { modifier: ParameterModifier.Ref, description: 'Determines if the rest of the deserialization should be processed, or if the method should return instantly.' }),
      ],
    }));

    this.afj = this.addMethod(new PartialMethod('AfterFromJson', dotnet.Void, {
      access: Access.Default,
      parameters: [
        new Parameter('json', ClientRuntime.JsonObject, { description: 'The JsonNode that should be deserialized into this object.' }),
      ],
    }));
  }
}
