
import { any, items, keys, values } from '#common/dictionary';
import { camelCase, deconstruct, EOL, fixLeadingNumber, indent, nameof, pascalCase } from '#common/text-manipulation';
import { Access, Modifier } from '#csharp/code-dom/access-modifier';
import { Class } from '#csharp/code-dom/class';
import { Constructor } from '#csharp/code-dom/constructor';
import { Expression, ExpressionOrLiteral, Is, IsDeclaration, LiteralExpression, valueOf } from '#csharp/code-dom/expression';
import { Field, InitializedField } from '#csharp/code-dom/field';
import { Method, PartialMethod } from '#csharp/code-dom/method';
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

import { TypeDeclaration } from '#csharp/code-dom/type-declaration';
import { JsonSerializableClass } from '#csharp/lowlevel-generator/model/model-class-json';
import { EnhancedTypeDeclaration } from '#csharp/schema/extended-type-declaration';
import { ObjectImplementation } from '#csharp/schema/object';
import { HeaderProperty, HeaderPropertyType } from '#remodeler/tweak-model';
import { State } from '../generator';
import { ModelInterface } from './interface';
import { ModelProperty } from './property';
import { ProxyProperty } from './proxy-property';

import { KnownMediaType } from '#common/media-types';
import { Variable } from '#csharp/code-dom/variable';
import { XmlSerializableClass } from '#csharp/lowlevel-generator/model/model-class-xml';
import { System } from '#csharp/code-dom/dotnet';

export interface BackingField {
  field: Field;
  typeDeclaration: TypeDeclaration;
  className: string;
}

export class ModelClass extends Class implements EnhancedTypeDeclaration {
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    return this.implementation.deserializeFromContainerMember(mediaType, container, serializedName, defaultValue);
  }
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return this.implementation.deserializeFromNode(mediaType, node, defaultValue);
  }
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string): Expression {
    return this.implementation.serializeToNode(mediaType, value, serializedName);
  }

  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral): Expression {
    return this.implementation.serializeToContent(mediaType, value);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.implementation.deserializeFromString(mediaType, content, defaultValue);
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.implementation.deserializeFromResponse(mediaType, content, defaultValue);
  }
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string): OneOrMoreStatements {
    return this.implementation.serializeToContainerMember(mediaType, value, container, serializedName);
  }

  get isXmlAttribute(): boolean {
    return this.implementation.isXmlAttribute;
  }

  get isRequired(): boolean {
    return this.implementation.isRequired;
  }

  public isPolymorphic: boolean;
  /* @internal */ public validateMethod?: Method;
  /* @internal */ public discriminators: Map<string, ModelClass>;
  /* @internal */ public parentModelClasses: Array<ModelClass>;
  /* @internal */ public modelInterface!: ModelInterface;
  /* @internal */ public get schema() { return this.implementation.schema; }
  /* @internal */ public state: State;
  /* @internal */ public btj!: Method;
  /* @internal */ public atj!: Method;
  /* @internal */ public bfj!: Method;
  /* @internal */ public afj!: Method;
  /* @internal */ public backingFields = new Array<BackingField>();
  /* @internal */ public implementation: ObjectImplementation;
  private jsonSerializer: JsonSerializableClass | undefined;
  private xmlSerializer: XmlSerializableClass | undefined;

  public hasHeaderProperties: boolean;

  constructor(namespace: Namespace, schemaWithFeatures: ObjectImplementation, state: State, objectInitializer?: Partial<ModelClass>) {

    super(namespace, schemaWithFeatures.schema.details.csharp.name);
    this.implementation = schemaWithFeatures;
    this.isPolymorphic = false;
    this.discriminators = new Map<string, ModelClass>();
    this.parentModelClasses = new Array<ModelClass>();
    this.state = state;

    this.apply(objectInitializer);
    this.partial = true;

    // create an interface for this model class

    // mark the code-model with the class we're creating.
    this.schema.details.csharp.classImplementation = this;

    // get all the header properties for this model
    this.hasHeaderProperties = values(this.schema.properties).linq.any(property => property.details.csharp[HeaderProperty] === HeaderPropertyType.Header || property.details.csharp[HeaderProperty] === HeaderPropertyType.Header);

    const modelInterface = this.schema.details.csharp.interfaceImplementation || new ModelInterface(this.namespace, this.schema, this, this.state);
    this.modelInterface = modelInterface;
    this.interfaces.push(modelInterface);

    if (this.schema.discriminator) {
      // this has a discriminator property.
      // our children are expected to tell us who they are
      this.isPolymorphic = true;
      // we'll add a deserializer factory method a bit later..
    }

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

      this.modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new InitializedField(`_${fieldName}`, td, `new ${className}()`, { access: Access.Private }));
      this.backingFields.push({
        className,
        typeDeclaration: td,
        field: backingField
      });
      // now, create proxy properties for the members
      iface.allProperties.map((each) => {
        // make sure we don't over expose read-only properties.
        const p = this.add(new ProxyProperty(backingField, each, this.state));
        if (each.setAccess === Access.Internal) {
          p.setterStatements = undefined;
        }
        return p;
      });

      validationStatements.add(td.validatePresence(backingField));
      validationStatements.add(td.validateValue(backingField));
    }

    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.

    // add properties
    for (const { key: propertyName, value: property } of items(this.schema.properties)) {
      const prop = new ModelProperty(this, property, property.serializedName || propertyName, this.state.path('properties', propertyName));
      this.add(prop);

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
    if (!this.state.project.storagePipeline) {
      if (validationStatements.implementation.trim()) {
        // we do have something to valdiate!

        // add the IValidates implementation to this object.
        this.interfaces.push(ClientRuntime.IValidates);
        this.validateMethod = this.addMethod(new Method('Validate', System.Threading.Tasks.Task(), {
          async: Modifier.Async,
          parameters: [new Parameter('listener', ClientRuntime.IEventListener)],
        }));
        this.validateMethod.add(validationStatements);
      }
    }

    // add from headers method if class or any of the parents pulls in header values.
    // FromHeaders( headers IEnumerable<KeyValuePair<string, IEnumerable<string>>> ) { ... }

    const headerProperties = values(this.properties).linq.where(p => (<ModelProperty>p).IsHeaderProperty);

    if (this.hasHeaderProperties) {
      // add header deserializer method
      const headers = new Parameter('headers', System.Net.Http.Headers.HttpResponseHeaders);

      const readHeaders = new Method('ReadHeaders', this, {
        access: Access.Internal,
        parameters: [headers],
        *body() {
          for (const hp of headerProperties) {
            const hparam = <ModelProperty>hp;
            if (hparam.serializedName === 'x-ms-meta') {
              yield `${hparam.backingName} = System.Linq.Enumerable.ToDictionary(System.Linq.Enumerable.Where(${valueOf(headers)}, header => header.Key.StartsWith("x-ms-meta-")), header => header.Key.Substring(10), header => System.Linq.Enumerable.FirstOrDefault(header.Value));`;
            } else {
              const values = `__${camelCase(['header', ...deconstruct(hparam.serializedName)])}Values`;
              yield If(`${valueOf(headers)}.TryGetValues("${hparam.serializedName}", out var ${values})`, `${hparam.assignPrivate(hparam.deserializeFromContainerMember(KnownMediaType.Header, headers, values))}`);
            }
          }
          yield `return this;`;
        }
      }).addTo(this);
    }
    const hasNonHeaderProperties = values(this.properties).linq.any(p => !(<ModelProperty>p).IsHeaderProperty);

    if (hasNonHeaderProperties) {
      if (this.state.project.xmlSerialization) {
        this.xmlSerializer = new XmlSerializableClass(this);
      }
      if (this.state.project.jsonSerialization) {
        this.jsonSerializer = new JsonSerializableClass(this);
      }
    }
  }

  public validateValue(property: Variable): OneOrMoreStatements {
    return this.implementation.validateValue(property);
  }
  public validatePresence(property: Variable): OneOrMoreStatements {
    return this.implementation.validatePresence(property);
  }

  public addDiscriminator(discriminatorValue: string, modelClass: ModelClass) {
    this.discriminators.set(discriminatorValue, modelClass);

    // tell any polymorphic parents incase we're doing subclass of a subclass.
    for (const each of this.parentModelClasses) {
      each.addDiscriminator(discriminatorValue, modelClass);
    }
  }
}
