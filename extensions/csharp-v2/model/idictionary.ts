import { Field, System, Property, toExpression, dotnet, Parameter, ParameterModifier, Method, Class, TypeDeclaration, Indexer, Access, Variable, Expression } from '@microsoft.azure/codegen-csharp';

export function implementIDictionary(targetClass: Class, name: String, keyType: TypeDeclaration, valueType: TypeDeclaration, accessViaMember?: Expression) {
  const dictionaryInterfaceType = System.Collections.Generic.IDictionary(keyType, valueType);

  // add the interface to the list of interfaces for the class
  targetClass.interfaces.push(dictionaryInterfaceType);

  // the backing field
  const dictionaryType = System.Collections.Generic.Dictionary(keyType, valueType);
  accessViaMember = accessViaMember || targetClass.add(new Field(`__${name}`, dictionaryInterfaceType, { initialValue: dictionaryType.new() }));

  const indexer = targetClass.add(new Indexer(keyType, valueType, { get: toExpression(`${accessViaMember}["index"]`), set: toExpression(`${accessViaMember}["index"] = value`) }));

  // the parameters used in methods.
  const itemType = System.Collections.Generic.KeyValuePair(keyType, valueType);
  const pKey = new Parameter('key', keyType);
  const pValue = new Parameter('value', valueType);
  const pItem = new Parameter('item', itemType);
  const pItemArray = new Parameter('items', dotnet.Array(itemType));
  const pIndex = new Parameter('index', dotnet.Int);
  const pOutValue = new Parameter('value', valueType, { modifier: ParameterModifier.Out });

  targetClass.add(new Property('Keys', System.Collections.Generic.ICollection(keyType), { get: toExpression(`${accessViaMember}.Keys`) }));
  targetClass.add(new Property('Values', System.Collections.Generic.ICollection(valueType), { get: toExpression(`${accessViaMember}.Values`) }));
  targetClass.add(new Property('Count', dotnet.Int, { get: toExpression(`${accessViaMember}.Count`) }));
  targetClass.add(new Property('IsReadOnly', dotnet.Bool, { get: toExpression(`${accessViaMember}.IsReadOnly`) }));

  targetClass.add(new Method('Add', dotnet.Void, { parameters: [pKey, pValue], body: toExpression(`${accessViaMember}.Add( ${pKey}, ${pValue})`) }));
  targetClass.add(new Method('Add', dotnet.Void, { parameters: [pItem], body: toExpression(`${accessViaMember}.Add( ${pItem})`) }));
  targetClass.add(new Method('Clear', dotnet.Void, { body: toExpression(`${accessViaMember}.Clear()`) }));

  targetClass.add(new Method('Contains', dotnet.Bool, { parameters: [pItem], body: toExpression(`${accessViaMember}.Contains( ${pItem})`) }));
  targetClass.add(new Method('ContainsKey', dotnet.Bool, { parameters: [pKey], body: toExpression(`${accessViaMember}.ContainsKey( ${pKey})`) }));
  targetClass.add(new Method('CopyTo', dotnet.Void, { parameters: [pItemArray, pIndex], body: toExpression(`${accessViaMember}.CopyTo(${pItemArray},${pIndex})`) }));

  targetClass.add(new Method('GetEnumerator', System.Collections.Generic.IEnumerator(itemType), { body: toExpression(`${accessViaMember}.GetEnumerator()`) }));
  targetClass.add(new Method('global::System.Collections.IEnumerable.GetEnumerator', System.Collections.IEnumerator, { body: toExpression(`${accessViaMember}.GetEnumerator()`), access: Access.Explicit }));

  targetClass.add(new Method('Remove', dotnet.Bool, { parameters: [pKey], body: toExpression(`${accessViaMember}.Remove( ${pKey})`) }));
  targetClass.add(new Method('Remove', dotnet.Bool, { parameters: [pItem], body: toExpression(`${accessViaMember}.Remove( ${pItem})`) }));

  targetClass.add(new Method('TryGetValue', dotnet.Bool, { parameters: [pKey, pOutValue], body: toExpression(`${accessViaMember}.TryGetValue( ${pKey}, out ${pOutValue})`) }));

  return dictionaryInterfaceType;
}
