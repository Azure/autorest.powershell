/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
import { HeaderProperty, HeaderPropertyType, KnownMediaType, VirtualProperty, getAllVirtualProperties } from '@azure-tools/codemodel-v3';
import { getPascalIdentifier, camelCase, deconstruct, DeepPartial } from '@azure-tools/codegen';
import { items, values } from '@azure-tools/linq';
import { Access, Class, Constructor, Expression, ExpressionOrLiteral, Field, If, Method, Modifier, Namespace, OneOrMoreStatements, Parameter, Statements, System, TypeDeclaration, valueOf, Variable, BackedProperty, Property, Virtual, toExpression, StringExpression, LiteralExpression, Attribute } from '@azure-tools/codegen-csharp';
import { ClientRuntime } from '../clientruntime';
import { State } from '../generator';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ObjectImplementation } from '../schema/object';
import { ModelInterface } from './interface';
import { JsonSerializableClass } from './model-class-json';
import { ModelProperty } from './property';
import { PropertyOriginAttribute, DoNotFormatAttribute, FormatTableAttribute, ConstantAttribute } from '../csharp-declarations';
import { Schema } from '../code-model';
import { DictionaryImplementation } from './model-class-dictionary';
import { Languages, Language, Schema as NewSchema, SchemaType, ObjectSchema, DictionarySchema } from '@autorest/codemodel';
import { VirtualProperty as NewVirtualProperty, getAllVirtualProperties as newGetAllVirtualProperties } from '../../utils/schema';

export function getVirtualPropertyName(vp?: NewVirtualProperty): string {

  if (vp && vp.accessViaMember && vp.accessViaProperty?.accessViaMember) {
    return getVirtualPropertyName(vp.accessViaMember);
  }
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
  /* @internal */ get modelInterface(): ModelInterface { return <ModelInterface>this.schema.language.csharp?.interfaceImplementation; }
  /* @internal */ get internalModelInterface(): ModelInterface { return <ModelInterface>this.schema.language.csharp?.internalInterfaceImplementation; }

  /* @internal */  state: State;
  /* @internal */  backingFields = new Array<BackingField>();
  /* @internal */  featureImplementation: ObjectImplementation;
  /* @internal */  validationEventListener: Parameter = new Parameter('eventListener', ClientRuntime.IEventListener, { description: `an <see cref="${ClientRuntime.IEventListener}" /> instance that will receive validation events.` });
  /* @internal */  jsonSerializer?: JsonSerializableClass;
  // /* @internal */  xmlSerializer?: XmlSerializableClass;
  /* @internal */  dictionaryImpl?: DictionaryImplementation;
  /* @internal */ constructorMethod?: Method;

  private readonly validationStatements = new Statements();
  public ownedProperties = new Array<ModelProperty>();
  private pMap = new Map<NewVirtualProperty, ModelProperty>();

  // public hasHeaderProperties: boolean;

  constructor(namespace: Namespace, schemaWithFeatures: ObjectImplementation, state: State, objectInitializer?: DeepPartial<ModelClass>) {
    super(namespace, schemaWithFeatures.schema.language.csharp?.name || '');
    this.featureImplementation = schemaWithFeatures;
    this.schema.language.csharp = this.schema.language.csharp || new Language();
    this.schema.language.csharp.classImplementation = this; // mark the code-model with the class we're creating.
    this.state = state;
    this.apply(objectInitializer);

    if (this.schema.language.csharp.suppressFormat) {
      this.add(new Attribute(DoNotFormatAttribute));
    }

    // must be a partial class
    this.partial = true;

    this.handleDiscriminator();

    // create an interface for this model class
    if (!this.schema.language.csharp.interfaceImplementation) {
      (this.schema.language.csharp.interfaceImplementation = new ModelInterface(this.namespace, this.schema.language.csharp.interfaceName || `I${this.schema.language.csharp.name}`, this, this.state));

    }
    this.interfaces.push(this.modelInterface);

    if (!this.schema.language.csharp.internalInterfaceImplementation) {
      (this.schema.language.csharp.internalInterfaceImplementation = new ModelInterface(this.namespace, this.schema.language.csharp.internalInterfaceName || `I${this.schema.language.csharp.name}Internal`, this, this.state, { accessModifier: Access.Internal }));

    }

    this.interfaces.push(this.internalModelInterface);

    this.schema.language.csharp.internalInterfaceImplementation.init();
    this.schema.language.csharp.interfaceImplementation.init();

    // add default constructor
    this.constructorMethod = this.addMethod(new Constructor(this, { description: `Creates an new <see cref="${this.name}" /> instance.` })); // default constructor for fits and giggles.

    // handle parent interface implementation
    if (!this.handleAllOf()) {
      // handle the AdditionalProperties if used
      const dictSchema = (<NewSchema>this.schema).type === SchemaType.Dictionary ? this.schema :
        this.schema.parents?.immediate?.find((schema) => schema.type === SchemaType.Dictionary);
      if (dictSchema) {
        this.dictionaryImpl = new DictionaryImplementation(this).init();
      }
    }

    // create the properties for this schema
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

  private nested(virtualProperty: NewVirtualProperty, internal: boolean): string {
    if (virtualProperty.accessViaProperty) {
      if (virtualProperty.accessViaProperty.accessViaProperty) {
        // return `/*1*/${getVirtualPropertyName(virtualProperty.accessViaMember)}.${this.nested(virtualProperty.accessViaProperty.accessViaProperty, internal)}`;
        return `${getVirtualPropertyName(virtualProperty.accessViaMember)}.${this.nested(virtualProperty.accessViaProperty.accessViaProperty, internal)}`;
      }
    }
    //return `/*2*/${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
    return `${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
  }

  private accessor(virtualProperty: NewVirtualProperty, internal = false): string {
    if (virtualProperty.accessViaProperty) {
      const prefix = virtualProperty.accessViaProperty.accessViaProperty ? this.nested(virtualProperty.accessViaProperty.accessViaProperty, internal) : '';
      const containingProperty = this.pMap.get(virtualProperty.accessViaProperty);
      if (containingProperty && virtualProperty.accessViaMember) {
        //return `/*3*/((${virtualProperty.accessViaMember.originalContainingSchema.details.csharp.fullInternalInterfaceName})${containingProperty.name}${prefix}).${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
        return `((${virtualProperty.accessViaMember.originalContainingSchema.language.csharp?.fullInternalInterfaceName})${containingProperty.name}${prefix}).${getVirtualPropertyName(virtualProperty.accessViaMember)}`;
      }
    }
    //    return `/*4* ${virtualProperty.name}/${virtualProperty.accessViaMember?.name}/${virtualProperty.accessViaProperty?.name} */${getVirtualPropertyName(virtualProperty.accessViaMember) || '/*!!*/' + virtualProperty.name}`;
    return `${getVirtualPropertyName(virtualProperty.accessViaMember) || virtualProperty.name}`;
  }

  private createProperties() {
    // generate a protected backing field for each
    // and then expand the nested properties into this class forwarding to the member.  

    // add properties
    if (this.schema.language.csharp?.virtualProperties) {

      /* Owned Properties */
      for (const virtualProperty of values(<Array<NewVirtualProperty>>(this.schema.language.csharp.virtualProperties.owned))) {
        let isPolymorphic = false;
        if (virtualProperty.private && virtualProperty.property.schema.type === SchemaType.Object && (<ObjectSchema>virtualProperty.property.schema).discriminator) {
          isPolymorphic = true;
        }
        const actualProperty = virtualProperty.property;
        let n = 0;
        const isRequired = !!(virtualProperty.required && virtualProperty.read && virtualProperty.create && virtualProperty.update);
        const decl = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>actualProperty.schema, isRequired, this.state.path('schema'));

        /* public property */
        const myProperty = new ModelProperty(virtualProperty.name, <NewSchema>actualProperty.schema, isRequired, actualProperty.serializedName, actualProperty.language.csharp?.description || '', this.state.path('properties', n++), {
          initializer: actualProperty.language.csharp?.constantValue ? typeof actualProperty.language.csharp.constantValue === 'string' ? new StringExpression(actualProperty.language.csharp.constantValue) : new LiteralExpression(actualProperty.language.csharp.constantValue) : undefined
        });

        if (virtualProperty.readOnly || actualProperty.language.csharp?.readOnly || actualProperty.readOnly) {
          myProperty.set = undefined;
        }
        myProperty.language = virtualProperty.property.language;

        if (actualProperty.language.csharp?.constantValue !== undefined) {
          myProperty.setAccess = Access.Internal;
          myProperty.set = undefined;
        }

        if (virtualProperty.private && !isPolymorphic) {
          // when properties are inlined, the container accessor can be internalized. I think.
          myProperty.setAccess = Access.Internal;
          myProperty.getAccess = Access.Internal;
        }

        if (virtualProperty.private) {
          this.pMap.set(virtualProperty, myProperty);
        }

        this.ownedProperties.push(this.add(myProperty));

        if (myProperty.getAccess !== Access.Public || myProperty.setAccess !== Access.Public || myProperty.set === undefined || isPolymorphic) {
          /* internal interface property */

          this.add(new Property(`${virtualProperty.originalContainingSchema.language.csharp?.internalInterfaceImplementation.fullName}.${virtualProperty.name}`, decl, {
            description: `Internal Acessors for ${virtualProperty.name}`,
            getAccess: Access.Explicit,
            setAccess: Access.Explicit,
            get: myProperty.get,
            set: myProperty.assignPrivate('value')
          }));
        }

        myProperty.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Owned`] }));
        this.addFormatAttributesToProperty(myProperty, virtualProperty);
      }

      /* Inherited properties. */
      for (const virtualProperty of values(<Array<NewVirtualProperty>>(this.schema.language.csharp.virtualProperties.inherited))) {
        let isPolymorphic = false;
        if (virtualProperty.private && virtualProperty.property.schema.type === SchemaType.Object && (<ObjectSchema>virtualProperty.property.schema).discriminator) {
          isPolymorphic = true;
        }
        // so each parent property that is getting exposed
        // has to be accessed via the field in this.backingFields
        const parentField = <BackingField>this.backingFields.find(each => virtualProperty.accessViaSchema ? virtualProperty.accessViaSchema.language.csharp?.interfaceImplementation.fullName === each.typeDeclaration.declaration : false);

        const isRequired = !!(virtualProperty.required && virtualProperty.read && virtualProperty.create && virtualProperty.update);
        const propertyType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>virtualProperty.property.schema, isRequired, this.state);
        const requiredPropertyType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>virtualProperty.property.schema, true, this.state);
        const opsType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>virtualProperty.originalContainingSchema, false, this.state);
        const via = <NewVirtualProperty>virtualProperty.accessViaProperty;
        const parentCast = `(${virtualProperty.originalContainingSchema.language.csharp?.internalInterfaceImplementation.fullName})`;
        let getFunc = toExpression(`(${parentCast}${parentField.field.name}).${this.accessor(virtualProperty)}`);
        let setFunc = (virtualProperty.readOnly || virtualProperty.property.language.csharp?.constantValue) ? undefined : toExpression(`(${parentCast}${parentField.field.name}).${this.accessor(virtualProperty)} = value ${isRequired ? '' : ` ?? ${requiredPropertyType.defaultOfType}`}`);
        let isConstant = false;
        if (virtualProperty.property.isDiscriminator && this.schema.discriminatorValue) {
          for (const parent of values(this.schema.parents?.all)) {
            if ((<ObjectSchema>parent).discriminator?.property === virtualProperty.property) {
              getFunc = toExpression(`"${this.schema.discriminatorValue}"`);
              setFunc = toExpression(`(${parentCast}${parentField.field.name}).${this.accessor(virtualProperty)} = "${this.schema.discriminatorValue}"`);
              isConstant = true;
              if (virtualProperty.property.language.csharp?.constantValue === undefined && !virtualProperty.readOnly) {
                this.constructorMethod?.add(`this.${parentField.field.name}.${this.accessor(virtualProperty)} = "${this.schema.discriminatorValue}";`);
              }
              break;
            }
          }
        }

        const vp = this.add(new Property(virtualProperty.name, propertyType, {
          description: virtualProperty.property.language.csharp?.description,
          get: getFunc,
          set: setFunc
        }));

        if (virtualProperty.property.language.csharp?.constantValue !== undefined) {
          vp.setAccess = Access.Internal;
          vp.set = undefined;
        }

        if (virtualProperty.private && !isPolymorphic) {
          vp.setAccess = Access.Internal;
          vp.getAccess = Access.Internal;
        }

        if (vp.getAccess !== Access.Public || vp.setAccess !== Access.Public || vp.set === undefined || isPolymorphic) {

          this.add(new Property(`${virtualProperty.originalContainingSchema.language.csharp?.internalInterfaceImplementation.fullName}.${virtualProperty.name}`, propertyType, {
            description: `Internal Acessors for ${virtualProperty.name}`,
            getAccess: Access.Explicit,
            setAccess: Access.Explicit,
            get: toExpression(`(${parentCast}${parentField.field.name}).${via.name}`),
            set: toExpression(`(${parentCast}${parentField.field.name}).${via.name} = value ${isRequired ? '' : ` ?? ${requiredPropertyType.defaultOfType}`}`)
          }));
        }
        if (isConstant) {
          vp.add(new Attribute(ConstantAttribute));
        }
        vp.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Inherited`] }));
        this.addFormatAttributesToProperty(vp, virtualProperty);
      }

      /* Inlined properties. */
      for (const virtualProperty of values(<Array<NewVirtualProperty>>this.schema.language.csharp.virtualProperties.inlined)) {
        let isPolymorphic = false;
        if (virtualProperty.private && virtualProperty.property.schema.type === SchemaType.Object && (<ObjectSchema>virtualProperty.property.schema).discriminator) {
          // continue;
          // can't remove it, it has to be either public or internally implemented.
          isPolymorphic = true;
        }
        const isRequired = !!(virtualProperty.required && virtualProperty.read && virtualProperty.create && virtualProperty.update);
        if (virtualProperty.accessViaProperty) {
          const containingProperty = this.pMap.get(virtualProperty.accessViaProperty);
          if (containingProperty) {

            const propertyType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>virtualProperty.property.schema, isRequired, this.state);
            const requiredPropertyType = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>virtualProperty.property.schema, true, this.state);

            // regular inlined property
            const vp = new Property(virtualProperty.name, propertyType, {
              description: virtualProperty.property.language.csharp?.description,
              get: toExpression(`${this.accessor(virtualProperty)}`),
              set: (virtualProperty.readOnly || virtualProperty.property.language.csharp?.constantValue) ? undefined : toExpression(`${this.accessor(virtualProperty)} = value ${isRequired ? '' : ` ?? ${requiredPropertyType.defaultOfType}`}`)
            });

            if (!virtualProperty.private || isPolymorphic) {
              this.add(vp);
            }

            if (virtualProperty.private || vp.getAccess !== Access.Public || vp.setAccess !== Access.Public || vp.set === undefined || isPolymorphic) {
              this.add(new Property(`${virtualProperty.originalContainingSchema.language.csharp?.internalInterfaceImplementation.fullName}.${virtualProperty.name}`, propertyType, {
                description: `Internal Acessors for ${virtualProperty.name}`,
                getAccess: Access.Explicit,
                setAccess: Access.Explicit,
                get: vp.get,
                set: toExpression(`${this.accessor(virtualProperty)} = value ${isRequired ? '' : ` ?? ${requiredPropertyType.defaultOfType}`}`)
              }));
            }

            if (virtualProperty.property.language.csharp?.constantValue !== undefined) {
              vp.setAccess = Access.Internal;
              vp.set = undefined;
            }

            vp.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Inlined`] }));
            this.addFormatAttributesToProperty(vp, virtualProperty);
          }
        }
      }

      /* Appended properties. */
      if (this.state.project.resourceGroupAppend && this.state.project.azure && this.schema.extensions && this.schema.extensions['is-return-object']) {
        this.appendResourceGroupName();
      }
    }
  }
  private addFormatAttributesToProperty(property: Property, virtualProperty: NewVirtualProperty) {
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
        returnsDescription: `A <see cref = "${System.Threading.Tasks.Task()}" /> that will be complete when validation is completed.`
      }));
      this.validateMethod.add(this.validationStatements);
    }
  }

  private additionalPropertiesType(aSchema: NewSchema): TypeDeclaration | undefined {
    const schema = aSchema.type === SchemaType.Dictionary ? aSchema :
      aSchema.type === SchemaType.Object ? (<ObjectSchema>aSchema).parents?.immediate?.find((s) => s.type === SchemaType.Dictionary) :
        undefined;
    if (schema) {
      const dictSchema = <DictionarySchema>schema;
      if (dictSchema.elementType.type === SchemaType.Any) {
        return System.Object;

      } else {
        // we're going to implement IDictionary<string, schema.additionalProperties>
        return this.state.project.modelsNamespace.NewResolveTypeDeclaration(dictSchema.elementType, true, this.state);
      }
    } else
      for (const each of values((<ObjectSchema>aSchema).parents?.immediate)) {
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
    for (const { key: eachSchemaIndex, value: eachSchemaValue } of items(this.schema.parents?.immediate)) {
      if (eachSchemaValue.type === SchemaType.Dictionary) {
        continue;
      }
      const aSchema = eachSchemaValue;
      const aState = this.state.path('allOf', eachSchemaIndex);

      const td = this.state.project.modelsNamespace.NewResolveTypeDeclaration(aSchema, true, aState);
      const parentClass = (<ModelClass>aSchema.language.csharp?.classImplementation);
      const className = parentClass.fullName;
      const fieldName = camelCase(deconstruct(className.replace(/^.*\./, '')));

      // add the interface as a parent to our interface.
      const iface = <ModelInterface>aSchema.language.csharp?.interfaceImplementation;

      // add a field for the inherited values
      const backingField = this.addField(new Field(`__${fieldName}`, td, { initialValue: `new ${className}()`, access: Access.Private, description: `Backing field for Inherited model <see cref= "${td.declaration}" /> ` }));
      this.backingFields.push({
        className,
        typeDeclaration: td,
        field: backingField
      });
      this.validationStatements.add(td.validatePresence(this.validationEventListener, backingField));
      this.validationStatements.add(td.validateValue(this.validationEventListener, backingField));

      this.internalModelInterface.interfaces.push(<ModelInterface>aSchema.language.csharp?.internalInterfaceImplementation);
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

    if (this.schema.discriminatorValue) {
      // we have a discriminator value, and we should tell our parent who we are so that they can build a proper deserializer method.
      // um. just how do we *really* know which allOf is polymorphic?
      // that's really sad.
      for (const { key: eachAllOfIndex, value: eachAllOfValue } of items(this.schema.parents?.all)) {
        const parentSchema = eachAllOfValue;
        const aState = this.state.path('allOf', eachAllOfIndex);

        // ensure the parent schema has it's class created first.
        this.state.project.modelsNamespace.NewResolveTypeDeclaration(parentSchema, true, aState);

        const parentClass = <ModelClass>parentSchema.language.csharp?.classImplementation;
        if (!!parentClass && parentClass.isPolymorphic) {
          // remember this class for later.
          this.parentModelClasses.push(parentClass);

          // tell that parent who we are.
          parentClass.addDiscriminator(this.schema.discriminatorValue, this);
        }
      }
    }
  }
  private addHeaderDeserializer() {
    const avp = newGetAllVirtualProperties(this.schema.language.csharp?.virtualProperties);
    const headers = new Parameter('headers', System.Net.Http.Headers.HttpResponseHeaders);
    const readHeaders = new Method(`${ClientRuntime.IHeaderSerializable}.ReadHeaders`, undefined, {
      access: Access.Explicit,
      parameters: [headers],
    });

    let used = false;
    let i = 0;
    for (const headerProperty of values(avp).where(each => each.property.language.csharp?.[HeaderProperty] === HeaderPropertyType.HeaderAndBody || each.property.language.csharp?.[HeaderProperty] === HeaderPropertyType.Header)) {
      used = true;
      const t = `((${headerProperty.originalContainingSchema.language.csharp?.fullInternalInterfaceName})this)`;
      const values = `__${camelCase([...deconstruct(headerProperty.property.serializedName), 'Header'])}`;
      const td = this.state.project.modelsNamespace.NewResolveTypeDeclaration(headerProperty.property.schema, false, this.state);
      readHeaders.add(If(`${valueOf(headers)}.TryGetValues("${headerProperty.property.serializedName}", out var ${values}${i})`, `${t}.${headerProperty.name} = ${td.deserializeFromContainerMember(KnownMediaType.Header, headers, values + i, td.defaultOfType)};`));
      i++;
    }
    if (used) {
      this.interfaces.push(ClientRuntime.IHeaderSerializable);
      this.add(readHeaders);
    }
  }

  private appendResourceGroupName() {
    const virtualProperties = newGetAllVirtualProperties(this.schema.language.csharp?.virtualProperties);
    const idProperties = values(virtualProperties).where(each => each.name === 'Id').toArray();
    const resourceGroupNameProperties = values(virtualProperties).where(each => each.name === 'ResourceGroupName').toArray();

    if (idProperties.length == 1 && resourceGroupNameProperties.length === 0) {
      const idProperty = idProperties[0];
      const resourceGroupNamePropertyName = getPascalIdentifier('ResourceGroupName');
      const resourceGroupNameDescription = 'Gets the resource group name';
      const actualResourceGroupProperty = idProperty.property;
      actualResourceGroupProperty.serializedName = resourceGroupNamePropertyName;
      const decl = this.state.project.modelsNamespace.NewResolveTypeDeclaration(<NewSchema>actualResourceGroupProperty.schema, false, this.state.path('schema'));

      const resourceGroupNameProperty = new Property(`${resourceGroupNamePropertyName}`, decl, {
        description: resourceGroupNameDescription,
        getAccess: Access.Public,
        setAccess: Access.Public,
        get: toExpression('(new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null)')
      });

      const format = this.state.project.formats[`${this.schema.language.csharp?.name}`];

      const virtualResourceGroupNameProperty = {
        name: resourceGroupNamePropertyName,
        property: actualResourceGroupProperty,
        private: false,
        nameComponents: [resourceGroupNamePropertyName],
        nameOptions: [resourceGroupNamePropertyName],
        description: resourceGroupNameDescription,
        originalContainingSchema: actualResourceGroupProperty.schema,
        alias: [],
        required: false,
        format: format
      };

      resourceGroupNameProperty.add(new Attribute(PropertyOriginAttribute, { parameters: [`${this.state.project.serviceNamespace}.PropertyOrigin.Owned`] }));
      this.addFormatAttributesToProperty(resourceGroupNameProperty, virtualResourceGroupNameProperty);

      this.add(resourceGroupNameProperty);
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
