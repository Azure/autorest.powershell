/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { KnownMediaType, HeaderProperty, HeaderPropertyType } from '@microsoft.azure/autorest.codemodel-v3';

import { camelCase, deconstruct, items, values } from '@microsoft.azure/codegen';
import { Access, Class, Constructor, Expression, ExpressionOrLiteral, Field, If, InitializedField, Method, Modifier, Namespace, OneOrMoreStatements, Parameter, Statements, System, TypeDeclaration, valueOf, Variable } from '@microsoft.azure/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation } from '../schema/object';
import { implementIDictionary } from './idictionary';
import { ModelInterface } from './interface';
import { JsonSerializableClass } from './model-class-json';
import { XmlSerializableClass } from './model-class-xml';
import { ModelProperty } from './property';
import { ProxyProperty } from './proxy-property';

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
  public get schema() { return this.implementation.schema; }
  /* @internal */ public state: State;
  /* @internal */ public btj!: Method;
  /* @internal */ public atj!: Method;
  /* @internal */ public bfj!: Method;
  /* @internal */ public afj!: Method;
  /* @internal */ public backingFields = new Array<BackingField>();
  /* @internal */ public implementation: ObjectImplementation;
  /* @internal */ public validationEventListener: Parameter;
  private jsonSerializer: JsonSerializableClass | undefined;
  private xmlSerializer: XmlSerializableClass | undefined;

  public hasHeaderProperties: boolean;

  constructor(namespace: Namespace, schemaWithFeatures: ObjectImplementation, state: State, objectInitializer?: Partial<ModelClass>) {

    super(namespace, schemaWithFeatures.schema.details.csharp.name);
    this.implementation = schemaWithFeatures;

    // mark the code-model with the class we're creating.
    this.schema.details.csharp.classImplementation = this;

    this.isPolymorphic = false;
    this.discriminators = new Map<string, ModelClass>();
    this.parentModelClasses = new Array<ModelClass>();
    this.state = state;

    this.apply(objectInitializer);
    this.partial = true;

    // create an interface for this model class



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
      for (const { key: eachAllOfIndex, value: eachAllOfValue } of items(this.schema.allOf)) {
        const parentSchema = eachAllOfValue;
        const aState = this.state.path('allOf', eachAllOfIndex);

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

    const defaultConstructor = this.addMethod(new Constructor(this, { description: `Creates an new <see cref="${this.name}" /> instance.` })); // default constructor for fits and giggles.
    const validationStatements = new Statements();
    this.validationEventListener = new Parameter('eventListener', ClientRuntime.IEventListener, { description: `an <see cref="${ClientRuntime.IEventListener}" /> instance that will receive validation events.` });

    // handle <allOf>s
    // add an 'implements' for the interface for the allOf.
    for (const { key: eachSchemaIndex, value: eachSchemaValue } of items(this.schema.allOf)) {
      // gs01: Critical -- pull thru parent allOf's!
      const aSchema = eachSchemaValue;

      const aState = this.state.path('allOf', eachSchemaIndex);

      const td = this.state.project.modelsNamespace.resolveTypeDeclaration(aSchema, true, aState);
      const className = (<ModelClass>aSchema.details.csharp.classImplementation).fullName;
      const fieldName = camelCase(deconstruct(className.replace(/^.*\./, '')));

      // add the interface as a parent to our interface.
      const iface = <ModelInterface>aSchema.details.csharp.interfaceImplementation;

      this.modelInterface.interfaces.push(iface);

      // add a field for the inherited values
      const backingField = this.addField(new InitializedField(`_${fieldName}`, td, `new ${className}()`, { access: Access.Private, description: `Backing field for <see cref="${this.fileName}" />` }));
      this.backingFields.push({
        className,
        typeDeclaration: td,
        field: backingField
      });
      // now, create proxy properties for the members
      iface.allProperties.map((each) => {
        // make sure we don't over expose read-only properties.
        const p = this.add(new ProxyProperty(backingField, each, this.state, { description: `Inherited model <see cref="${iface.name}" /> - ${eachSchemaValue.details.csharp.description}` }));
        if (each.setAccess === Access.Internal) {
          p.setterStatements = undefined;
        }
        return p;
      });

      validationStatements.add(td.validatePresence(this.validationEventListener, backingField));
      validationStatements.add(td.validateValue(this.validationEventListener, backingField));
    }

    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.

    // add properties
    for (const { key: index, value: property } of items(this.schema.properties)) {
      const name = property.serializedName || property.details.csharp.name;
      const prop = new ModelProperty(this, property, name, this.state.path('properties', index));
      this.add(prop);

      validationStatements.add(prop.validatePresenceStatement(this.validationEventListener));
      validationStatements.add(prop.validationStatement(this.validationEventListener));
    }

    if (this.schema.additionalProperties) {
      if (this.schema.additionalProperties === true) {
        // we're going to implement IDictionary<string, object>
        implementIDictionary(System.String, System.Object, this);

      } else {
        // we're going to implement IDictionary<string, schema.additionalProperties>

      }

    }
    if (!this.state.project.storagePipeline) {
      if (validationStatements.implementation.trim()) {
        // we do have something to valdiate!

        // add the IValidates implementation to this object.
        this.interfaces.push(ClientRuntime.IValidates);
        this.validateMethod = this.addMethod(new Method('Validate', System.Threading.Tasks.Task(), {
          async: Modifier.Async,
          parameters: [this.validationEventListener],
          description: `Validates that this object meets the validation criteria.`,
          returnsDescription: `A <see cref="${System.Threading.Tasks.Task()}" /> that will be complete when validation is completed.`
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

    if (this.state.project.jsonSerialization) {
      this.jsonSerializer = new JsonSerializableClass(this);
    }

    if (hasNonHeaderProperties) {
      if (this.state.project.xmlSerialization) {
        this.xmlSerializer = new XmlSerializableClass(this);
      }
      // if (this.state.project.jsonSerialization) {
      // this.jsonSerializer = new JsonSerializableClass(this);
      // }
    }
  }

  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validateValue(eventListener, property);
  }
  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.implementation.validatePresence(eventListener, property);
  }

  public addDiscriminator(discriminatorValue: string, modelClass: ModelClass) {
    this.discriminators.set(discriminatorValue, modelClass);

    // tell any polymorphic parents incase we're doing subclass of a subclass.
    for (const each of this.parentModelClasses) {
      each.addDiscriminator(discriminatorValue, modelClass);
    }
  }
}
