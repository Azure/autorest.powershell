import { Field, System, Property, toExpression, dotnet, Parameter, ParameterModifier, Method, Class, TypeDeclaration, Indexer, Access, Variable, Expression, If, And, ForEach, LocalVariable, ImplicitCastOperator } from '@microsoft.azure/codegen-csharp';
import { ModelClass } from './model-class';
import { EnhancedTypeDeclaration } from '../schema/extended-type-declaration';
import { ClientRuntime } from '../clientruntime';
import { getAllVirtualProperties } from '@microsoft.azure/autorest.codemodel-v3';

export class DictionaryImplementation extends Class {
  private get state() { return this.modelClass.state; };
  private get schema() { return this.modelClass.schema; };
  public valueType!: TypeDeclaration | EnhancedTypeDeclaration;
  public ownsDictionary = false;

  constructor(protected modelClass: ModelClass, objectInitializer?: Partial<DictionaryImplementation>) {
    super(modelClass.namespace, modelClass.name);
    this.apply(objectInitializer);
  }

  init(valueType?: TypeDeclaration, accessViaMember?: Expression) {
    if (valueType && accessViaMember) {
      this.valueType = valueType;
      this.implementIDictionary(this, '', System.String, valueType, accessViaMember);

    }
    else {
      if (this.schema.additionalProperties) {
        this.ownsDictionary = true;
        this.valueType = this.schema.additionalProperties === true ? System.Object : this.state.project.modelsNamespace.resolveTypeDeclaration(this.schema.additionalProperties, true, this.state)
        this.modelClass.modelInterface.interfaces.push(this.implementIDictionary(this, 'additionalProperties', System.String, this.valueType));
      }
    }

    return this;
  }

  addSerialization() {
    if (this.modelClass.jsonSerializer) {
      // add serializer methods.
      // this.modelClass.jsonSerializer


    }
  }

  implementIDictionary(targetClass: Class, name: String, keyType: TypeDeclaration, valueType: TypeDeclaration, accessViaMember?: Expression) {
    const containerInterfaceType = { declaration: `${ClientRuntime}.IAssociativeArray<${valueType.declaration}>`, allProperties: [] }
    const dictionaryInterfaceType = System.Collections.Generic.IDictionary(keyType, valueType);
    const itemType = System.Collections.Generic.KeyValuePair(keyType, valueType);

    // add the interface to the list of interfaces for the class
    targetClass.interfaces.push(containerInterfaceType);

    // the backing field
    const dictionaryType = System.Collections.Generic.Dictionary(keyType, valueType);

    accessViaMember = accessViaMember || targetClass.add(new Field(`__${name}`, dictionaryType, { access: Access.Protected, initialValue: dictionaryType.new() }));

    const indexer = targetClass.add(new Indexer(keyType, valueType, { get: toExpression(`${accessViaMember}[index]`), set: toExpression(`${accessViaMember}[index] = value`) }));

    // the parameters used in methods.

    const pKey = new Parameter('key', keyType);
    const pValue = new Parameter('value', valueType);
    const pOutValue = new Parameter('value', valueType, { modifier: ParameterModifier.Out });

    targetClass.add(new Property(`${containerInterfaceType.declaration}.Keys`, System.Collections.Generic.IEnumerable(keyType), { get: toExpression(`${accessViaMember}.Keys`), getAccess: Access.Explicit }));
    targetClass.add(new Property(`${containerInterfaceType.declaration}.Values`, System.Collections.Generic.IEnumerable(valueType), { get: toExpression(`${accessViaMember}.Values`), getAccess: Access.Explicit }));
    targetClass.add(new Property(`${containerInterfaceType.declaration}.Count`, dotnet.Int, { get: toExpression(`${accessViaMember}.Count`), getAccess: Access.Explicit }));
    if (name) {
      targetClass.add(new ImplicitCastOperator(dictionaryType, targetClass, `source.${accessViaMember}`));
      targetClass.add(new Property(`${containerInterfaceType.declaration}.AdditionalProperties`, dictionaryInterfaceType, { get: toExpression(`${accessViaMember}`), getAccess: Access.Explicit }));
    } else {
      targetClass.add(new Property(`${containerInterfaceType.declaration}.AdditionalProperties`, dictionaryInterfaceType, { get: toExpression(`${accessViaMember}.AdditionalProperties`), getAccess: Access.Explicit }));
    }
    targetClass.add(new Method(`Add`, dotnet.Void, { parameters: [pKey, pValue], body: toExpression(`${accessViaMember}.Add( ${pKey}, ${pValue})`), access: Access.Public }));
    targetClass.add(new Method(`Clear`, dotnet.Void, { body: toExpression(`${accessViaMember}.Clear()`), access: Access.Public }));

    targetClass.add(new Method(`ContainsKey`, dotnet.Bool, { parameters: [pKey], body: toExpression(`${accessViaMember}.ContainsKey( ${pKey})`), access: Access.Public }));

    targetClass.add(new Method(`Remove`, dotnet.Bool, { parameters: [pKey], body: toExpression(`${accessViaMember}.Remove( ${pKey})`), access: Access.Public }));

    targetClass.add(new Method(`TryGetValue`, dotnet.Bool, { parameters: [pKey, pOutValue], body: toExpression(`${accessViaMember}.TryGetValue( ${pKey}, out ${pOutValue})`), access: Access.Public }));

    const all = getAllVirtualProperties(this.schema.details.csharp.virtualProperties);
    const exclusions = all.map(each => `"${each.name}"`).join(',');

    // add a CopyFrom that takes an IDictionary or PSObject and copies the values into this dictionary
    for (const pDictType of [System.Collections.IDictionary, { declaration: `global::System.Management.Automation.PSObject` }]) {
      const pDict = new Parameter('source', pDictType);
      targetClass.add(new Method('CopyFrom', dotnet.Void, {
        parameters: [pDict], body: function* () {
          yield If(pDict.IsNotNull, function* () {

            yield ForEach('property', ` Microsoft.Rest.ClientRuntime.PowerShell.TypeConverterExtensions.GetFilteredProperties(${pDict.value}, ${System.Collections.Generic.HashSet(System.String).new()} { ${exclusions} } )`, function* () {

              yield If(And(`null != property.Key`, `null != property.Value`), function* () {
                yield `this.${accessViaMember}.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<${valueType.declaration}>( property.Value));`
              });
            })
          })
        }
      }));
    }

    // return dictionaryInterfaceType;
    return containerInterfaceType;
  }

  public get fileName(): string {
    return `${super.fileName}.dictionary`;
  }
}
