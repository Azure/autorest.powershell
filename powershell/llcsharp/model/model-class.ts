/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { HeaderProperty, HeaderPropertyType, KnownMediaType, VirtualProperty, getAllVirtualProperties } from '@azure-tools/codemodel-v3';

import { camelCase, deconstruct, DeepPartial } from '@azure-tools/codegen';
import { items, values } from '@azure-tools/linq';
import { Access, Class, Constructor, Expression, ExpressionOrLiteral, Field, If, Method, Modifier, Namespace, OneOrMoreStatements, Parameter, Statements, System, TypeDeclaration, valueOf, Variable, BackedProperty, Property, Virtual, toExpression, StringExpression, LiteralExpression, Attribute } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation } from '../schema/object';
import { ModelInterface } from './interface';
import { JsonSerializableClass } from './model-class-json';
import { ModelProperty } from './property';
import { PropertyOriginAttribute, DoNotFormatAttribute, FormatTableAttribute } from '../csharp-declarations';
import { Schema } from '../code-model';
import { DictionaryImplementation } from './model-class-dictionary';

function getVirtualPropertyName(vp?: VirtualProperty) {
  return vp ? vp.name : '';
}
export interface BackingField {
  field: Field;
  typeDeclaration: TypeDeclaration;
  className: string;
}

export class ModelClass extends Class implements EnhancedTypeDeclaration {
  deserializeFromContainerMember(mediaType: KnownMediaType, container: ExpressionOrLiteral, serializedName: string, defaultValue: Expression): Expression {
    return this.featureImplementation.deserializeFromContainerMember(mediaType, container, serializedName, defaultValue);
  }
  deserializeFromNode(mediaType: KnownMediaType, node: ExpressionOrLiteral, defaultValue: Expression): Expression {
    return this.featureImplementation.deserializeFromNode(mediaType, node, defaultValue);
  }
  serializeToNode(mediaType: KnownMediaType, value: ExpressionOrLiteral, serializedName: string, mode: Expression): Expression {
    return this.featureImplementation.serializeToNode(mediaType, value, serializedName, mode);
  }

  get defaultOfType() {
    return toExpression('null /* model class */');
  }

  get convertObjectMethod() {
    return this.featureImplementation.convertObjectMethod;
  }
  /** emits an expression serialize this to a HttpContent */
  serializeToContent(mediaType: KnownMediaType, value: ExpressionOrLiteral, mode: Expression): Expression {
    return this.featureImplementation.serializeToContent(mediaType, value, mode);
  }

  /** emits an expression to deserialize content from a string */
  deserializeFromString(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.featureImplementation.deserializeFromString(mediaType, content, defaultValue);
  }
  /** emits an expression to deserialize content from a content/response */
  deserializeFromResponse(mediaType: KnownMediaType, content: ExpressionOrLiteral, defaultValue: Expression): Expression | undefined {
    return this.featureImplementation.deserializeFromResponse(mediaType, content, defaultValue);
  }
  serializeToContainerMember(mediaType: KnownMediaType, value: ExpressionOrLiteral, container: Variable, serializedName: string, mode: Expression): OneOrMoreStatements {
    return this.featureImplementation.serializeToContainerMember(mediaType, value, container, serializedName, mode);
  }

  get isXmlAttribute(): boolean {
    return this.featureImplementation.isXmlAttribute;
  }

  public isNullable = true;

  get isRequired(): boolean {
    return this.featureImplementation.isRequired;
  }

  public isPolymorphic = false;
  public get schema() { return this.featureImplementation.schema; }

  /* @internal */ validateMethod?: Method;
  /* @internal */ discriminators: Map<string, ModelClass> = new Map<string, ModelClass>();
  /* @internal */ parentModelClasses: Array<ModelClass> = new Array<ModelClass>();
  /* @internal */ get modelInterface(): ModelInterface { return <ModelInterface>this.schema.details.csharp.interfaceImplementation; }
  /* @internal */ get internalModelInterface(): ModelInterface { return <ModelInterface>this.schema.details.csharp.internalInterfaceImplementation; }

  /* @internal */  state: State;
  /* @internal */  backingFields = new Array<BackingField>();
  /* @internal */  featureImplementation: ObjectImplementation;
  /* @internal */  validationEventListener: Parameter = new Parameter('eventListener', ClientRuntime.IEventListener, { description: `an <see cref="${ClientRuntime.IEventListener}" /> instance that will receive validation events.` });
  /* @internal */  jsonSerializer?: JsonSerializableClass;
  // /* @internal */  xmlSerializer?: XmlSerializableClass;
  /* @internal */  dictionaryImpl?: DictionaryImplementation;

  private readonly validationStatements = new Statements();
  public ownedProperties = new Array<ModelProperty>();
  private pMap = new Map<VirtualProperty, ModelProperty>();

  // public hasHeaderProperties: boolean;

  constructor(namespace: Namespace, schemaWithFeatures: ObjectImplementation, state: State, objectInitializer?: DeepPartial<ModelClass>) {
    super(namespace, schemaWithFeatures.schema.details.csharp.name);
    this.featureImplementation = schemaWithFeatures;
    this.schema.details.csharp.classImplementation = this; // mark the code-model with the class we're creating.
    this.state = state;
    this.apply(objectInitializer);

    if (this.state.getValue('powershell') && this.schema.details.csharp.suppressFormat) {
      this.add(new Attribute(DoNotFormatAttribute));
    }

    // must be a partial class
    this.partial = true;

    this.handleDiscriminator();

    // create an interface for this model class
    if (!this.schema.details.csharp.interfaceImplementation) {
      (this.schema.details.csharp.interfaceImplementation = new ModelInterface(this.namespace, this.schema.details.csharp.interfaceName || `I${this.schema.details.csharp.name}`, this, this.state)).init();
    }
    this.interfaces.push(this.modelInterface);

    if (!this.schema.details.csharp.internalInterfaceImplementation) {
      (this.schema.details.csharp.internalInterfaceImplementation = new ModelInterface(this.namespace, this.schema.details.csharp.internalInterfaceName || `I${this.schema.details.csharp.name}Internal`, this, this.state, { accessModifier: Access.Internal })).init();
    }

    this.interfaces.push(this.internalModelInterface);

    // add default constructor
    this.addMethod(new Constructor(this, { description: `Creates an new <see cref="${this.name}" /> instance.` })); // default constructor for fits and giggles.

    // handle parent interface implementation
    if (!this.handleAllOf()) {
      // handle the AdditionalProperties if used
      if (this.schema.additionalProperties) {
        this.dictionaryImpl = new DictionaryImplementation(this).init();
      }
    }

    // create the properties for ths schema
    this.createProperties();

    // add validation implementation
    this.addValidation();

    // add header properties for this model.
    // DISABLED.
    this.addHeaderDeserializer();

    if (this.state.project.jsonSerialization) {
      this.jsonSerializer = new JsonSerializableClass(this);
    }
  }

  private nested(virtualProperty: VirtualProperty, internal: boolean): string {
    if (virtualProperty.accessViaProperty) {
      if (virtualProperty.accessViaProperty.accessViaProperty) {
        return `${getVirtualPropertyName(virtualProperty.accessViaMember)}.${this.nested(virtualProperty.accessViaProperty.accessViaProperty, internal)}`;
      }
    }
    return `${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
  }

  private accessor(virtualProperty: VirtualProperty, internal = false): string {
    if (virtualProperty.accessViaProperty) {
      const prefix = virtualProperty.accessViaProperty.accessViaProperty ? this.nested(virtualProperty.accessViaProperty.accessViaProperty, internal) : '';
      const containingProperty = this.pMap.get(virtualProperty.accessViaProperty);
      if (containingProperty && virtualProperty.accessViaMember) {
        return `((${virtualProperty.accessViaMember.originalContainingSchema.details.csharp.fullInternalInterfaceName})${containingProperty.name}${prefix}).${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
      }
    }
    return `${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
  }

  private createProperties() {
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.  

    // add properties
    if (this.schema.details.csharp.virtualProperties) {
      const addFormatAttributesToProperty = (property: Property, virtualProperty: VirtualProperty) => {
        if (virtualProperty.format) {
          if (virtualProperty.format.suppressFormat) {
            property.add(new Attribute(DoNotFormatAttribute));
          } else {
            const parameters = [];
            if (virtualProperty.format.index !== undefined) {
              parameters.push(`Index = ${virtualProperty.format.index}`);
            }

            if (virtualProperty.format.label !== undefined) {
              parameters.push(`Label = ${new StringExpression(virtualProperty.format.label)}`);
            }

            if (virtualProperty.format.width !== undefined) {
              parameters.push(`Width = ${virtualProperty.format.width}`);
            }

            property.add(new Attribute(FormatTableAttribute, { parameters }));
          }
        }
      };

      /* Owned Properties */
      for (const virtualProperty of values(this.schema.details.csharp.virtualProperties.owned)) {
        const actualProperty = virtualProperty.property;
        let n = 0;
        const decl = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>actualProperty.schema, actualProperty.details.csharp.required, this.state.path('schema'));

        /* public property */
        const myProperty = new ModelProperty(virtualProperty.name, <Schema>actualProperty.schema, actualProperty.details.csharp.required, actualProperty.serializedName, actualProperty.details.csharp.description, this.state.path('properties', n++), {
          initializer: actualProperty.details.csharp.constantValue ? typeof actualProperty.details.csharp.constantValue === 'string' ? new StringExpression(actualProperty.details.csharp.constantValue) : new LiteralExpression(actualProperty.details.csharp.constantValue) : undefined
        });

        if (actualProperty.details.csharp.readOnly) {
          myProperty.set = undefined;
        }
        myProperty.details = virtualProperty.property.details;

        if (actualProperty.details.csharp.constantValue !== undefined) {
          myProperty.setAccess = Access.Internal;
          myProperty.set = undefined;
        }

        if (virtualProperty.private) {
          // when properties are inlined, the container accessor can be internalized. I think.
          myProperty.setAccess = Access.Internal;
          myProperty.getAccess = Access.Internal;
          this.pMap.set(virtualProperty, myProperty);
        }

        this.ownedProperties.push(this.add(myProperty));

        if (myProperty.getAccess !== Access.Public || myProperty.setAccess !== Access.Public || myProperty.set === undefined) {
          /* internal interface property */
          this.add(new Property(`${virtualProperty.originalContainingSchema.details.csharp.internalInterfaceImplementation.fullName}.${virtualProperty.name}`, decl, {
            description: `Internal Acessors for ${virtualProperty.name}`,
            getAccess: Access.Explicit,
            setAccess: Access.Explicit,
            get: myProperty.get,
            set: myProperty.assignPrivate('value')
          }));
        }

        if (this.state.getValue('powershell')) {
          myProperty.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Owned`] }));
          addFormatAttributesToProperty(myProperty, virtualProperty);
        }
      }

      /* Inherited properties. */
      for (const virtualProperty of values(this.schema.details.csharp.virtualProperties.inherited)) {
        // so each parent property that is getting exposed
        // has to be accessed via the field in this.backingFields
        const parentField = <BackingField>this.backingFields.find(each => virtualProperty.accessViaSchema ? virtualProperty.accessViaSchema.details.csharp.interfaceImplementation.fullName === each.typeDeclaration.declaration : false);

        const propertyType = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>virtualProperty.property.schema, virtualProperty.property.details.csharp.required, this.state);
        const via = <VirtualProperty>virtualProperty.accessViaProperty;
        const parentCast = `(${virtualProperty.originalContainingSchema.details.csharp.internalInterfaceImplementation.fullName})`;
        const vp = this.add(new Property(virtualProperty.name, propertyType, {
          description: virtualProperty.property.details.csharp.description,
          get: toExpression(`(${parentCast}${parentField.field.name}).${via.name}`),
          set: (virtualProperty.property.details.csharp.readOnly || virtualProperty.property.details.csharp.constantValue) ? undefined : toExpression(`(${parentCast}${parentField.field.name}).${via.name} = value`)
        }));

        if (virtualProperty.property.details.csharp.constantValue !== undefined) {
          vp.setAccess = Access.Internal;
          vp.set = undefined;
        }

        if (vp.getAccess !== Access.Public || vp.setAccess !== Access.Public || vp.set === undefined) {

          this.add(new Property(`${virtualProperty.originalContainingSchema.details.csharp.internalInterfaceImplementation.fullName}.${virtualProperty.name}`, propertyType, {
            description: `Internal Acessors for ${virtualProperty.name}`,
            getAccess: Access.Explicit,
            setAccess: Access.Explicit,
            get: toExpression(`(${parentCast}${parentField.field.name}).${via.name}`),
            set: toExpression(`(${parentCast}${parentField.field.name}).${via.name} = value`)
          }));
        }

        if (this.state.getValue('powershell')) {
          vp.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Inherited`] }));
          addFormatAttributesToProperty(vp, virtualProperty);
        }
      }

      /* Inlined properties. */
      for (const virtualProperty of values(this.schema.details.csharp.virtualProperties.inlined)) {
        if (virtualProperty.private) {
          // continue;
          // can't remove it, it has to be either public or internally implemented.
        }

        if (virtualProperty.accessViaProperty) {
          const containingProperty = this.pMap.get(virtualProperty.accessViaProperty);
          if (containingProperty) {

            const propertyType = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>virtualProperty.property.schema, virtualProperty.property.details.csharp.required, this.state);

            // regular inlined property
            const vp = new Property(virtualProperty.name, propertyType, {
              description: virtualProperty.property.details.csharp.description,
              get: toExpression(`${this.accessor(virtualProperty)}`),
              set: (virtualProperty.property.details.csharp.readOnly || virtualProperty.property.details.csharp.constantValue) ? undefined : toExpression(`${this.accessor(virtualProperty)} = value`)
            });

            if (!virtualProperty.private) {
              this.add(vp);
            }

            if (virtualProperty.private || vp.getAccess !== Access.Public || vp.setAccess !== Access.Public || vp.set === undefined) {
              this.add(new Property(`${virtualProperty.originalContainingSchema.details.csharp.internalInterfaceImplementation.fullName}.${virtualProperty.name}`, propertyType, {
                description: `Internal Acessors for ${virtualProperty.name}`,
                getAccess: Access.Explicit,
                setAccess: Access.Explicit,
                get: vp.get,
                set: toExpression(`${this.accessor(virtualProperty)} = value`)
              }));
            }

            if (virtualProperty.property.details.csharp.constantValue !== undefined) {
              vp.setAccess = Access.Internal;
              vp.set = undefined;
            }

            if (this.state.getValue('powershell')) {
              vp.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Inlined`] }));
              addFormatAttributesToProperty(vp, virtualProperty);
            }
          }
        }
      }

    }
  }

  private addValidation() {
    if (this.validationStatements.implementation.trim()) {
      // we do have something to valdiate!

      // add the IValidates implementation to this object.
      this.interfaces.push(ClientRuntime.IValidates);
      this.validateMethod = this.addMethod(new Method('Validate', System.Threading.Tasks.Task(), {
        async: Modifier.Async,
        parameters: [this.validationEventListener],
        description: 'Validates that this object meets the validation criteria.',
        returnsDescription: `A < see cref = "${System.Threading.Tasks.Task()}" /> that will be complete when validation is completed.`
      }));
      this.validateMethod.add(this.validationStatements);
    }
  }

  private additionalPropertiesType(aSchema: Schema): TypeDeclaration | undefined {
    if (aSchema.additionalProperties) {

      if (aSchema.additionalProperties === true) {
        return System.Object;

      } else {
        // we're going to implement IDictionary<string, schema.additionalProperties>
        return this.state.project.modelsNamespace.resolveTypeDeclaration(aSchema.additionalProperties, true, this.state);
      }
    } else
      for (const each of values(aSchema.allOf)) {
        const r = this.additionalPropertiesType(each);
        if (r) {
          return r;
        }
      }
    return undefined;
  }

  private handleAllOf() {
    let hasAdditionalPropertiesInParent = false;
    // handle <allOf>s
    // add an 'implements' for the interface for the allOf.
    for (const { key: eachSchemaIndex, value: eachSchemaValue } of items(this.schema.allOf)) {
      const aSchema = eachSchemaValue;
      const aState = this.state.path('allOf', eachSchemaIndex);

      const td = this.state.project.modelsNamespace.resolveTypeDeclaration(aSchema, true, aState);
      const parentClass = (<ModelClass>aSchema.details.csharp.classImplementation);
      const className = parentClass.fullName;
      const fieldName = camelCase(deconstruct(className.replace(/^.*\./, '')));

      // add the interface as a parent to our interface.
      const iface = <ModelInterface>aSchema.details.csharp.interfaceImplementation;

      // add a field for the inherited values
      const backingField = this.addField(new Field(`__${fieldName}`, td, { initialValue: `new ${className}()`, access: Access.Private, description: `Backing field for Inherited model <see cref= "${td.declaration}" /> ` }));
      this.backingFields.push({
        className,
        typeDeclaration: td,
        field: backingField
      });
      this.validationStatements.add(td.validatePresence(this.validationEventListener, backingField));
      this.validationStatements.add(td.validateValue(this.validationEventListener, backingField));

      this.internalModelInterface.interfaces.push(<ModelInterface>aSchema.details.csharp.internalInterfaceImplementation);
      this.modelInterface.interfaces.push(iface);

      //
      const addlPropType = this.additionalPropertiesType(aSchema);
      if (addlPropType) {
        this.dictionaryImpl = new DictionaryImplementation(this).init(addlPropType, backingField);
        hasAdditionalPropertiesInParent = true;
      }
    }
    return hasAdditionalPropertiesInParent;
  }

  private handleDiscriminator() {
    if (this.schema.discriminator) {
      // this has a discriminator property.
      // our children are expected to tell us who they are
      this.isPolymorphic = true;
      // we'll add a deserializer factory method a bit later..
    }

    if (this.schema.details.csharp.discriminatorValue) {
      // we have a discriminator value, and we should tell our parent who we are so that they can build a proper deserializer method.
      // um. just how do we *really* know which allOf is polymorphic?
      // that's really sad.
      for (const { key: eachAllOfIndex, value: eachAllOfValue } of items(this.schema.allOf)) {
        const parentSchema = eachAllOfValue;
        const aState = this.state.path('allOf', eachAllOfIndex);

        // ensure the parent schema has it's class created first.
        this.state.project.modelsNamespace.resolveTypeDeclaration(parentSchema, true, aState);

        const parentClass = <ModelClass>parentSchema.details.csharp.classImplementation;
        if (parentClass.isPolymorphic) {
          // remember this class for later.
          this.parentModelClasses.push(parentClass);

          // tell that parent who we are.
          parentClass.addDiscriminator(this.schema.details.csharp.discriminatorValue, this);
        }
      }
    }
  }
  private addHeaderDeserializer() {
    const avp = getAllVirtualProperties(this.schema.details.csharp.virtualProperties);
    const headers = new Parameter('headers', System.Net.Http.Headers.HttpResponseHeaders);
    const readHeaders = new Method(`${ClientRuntime.IHeaderSerializable}.ReadHeaders`, undefined, {
      access: Access.Explicit,
      parameters: [headers],
    });

    let used = false;

    for (const headerProperty of values(avp).where(each => each.property.details.csharp[HeaderProperty] === HeaderPropertyType.HeaderAndBody || each.property.details.csharp[HeaderProperty] === HeaderPropertyType.Header)) {
      used = true;
      const t = `((${headerProperty.originalContainingSchema.details.csharp.fullInternalInterfaceName})this)`;
      const values = `__${camelCase([...deconstruct(headerProperty.property.serializedName), 'Header'])}`;
      const td = this.state.project.modelsNamespace.resolveTypeDeclaration(<Schema>headerProperty.property.schema, false, this.state.path('schema'));
      readHeaders.add(If(`${valueOf(headers)}.TryGetValues("${headerProperty.property.serializedName}", out var ${values})`, `${t}.${headerProperty.name} = ${td.deserializeFromContainerMember(KnownMediaType.Header, headers, values, td.defaultOfType)};`));
    }
    if (used) {
      this.interfaces.push(ClientRuntime.IHeaderSerializable);
      this.add(readHeaders);
    }
  }

  public validateValue(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.featureImplementation.validateValue(eventListener, property);
  }
  public validatePresence(eventListener: Variable, property: Variable): OneOrMoreStatements {
    return this.featureImplementation.validatePresence(eventListener, property);
  }

  public addDiscriminator(discriminatorValue: string, modelClass: ModelClass) {
    this.discriminators.set(discriminatorValue, modelClass);

    // tell any polymorphic parents incase we're doing subclass of a subclass.
    for (const each of this.parentModelClasses) {
      each.addDiscriminator(discriminatorValue, modelClass);
    }
  }
}