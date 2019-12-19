/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

import { Field, System, Property, toExpression, dotnet, Parameter, ParameterModifier, Method, Class, TypeDeclaration, Indexer, Access, Variable, Expression, If, ForEach, And, LocalVariable } from '@azure-tools/codegen-csharp';

export function implementIDictionary(targetClass: Class, name: string, keyType: TypeDeclaration, valueType: TypeDeclaration, accessViaMember?: Expression) {
  const dictionaryInterfaceType = System.Collections.Generic.IDictionary(keyType, valueType);
  const itemType = System.Collections.Generic.KeyValuePair(keyType, valueType);
  const collectionInterfaceType = System.Collections.Generic.ICollection(itemType);
  const enumerableInterfaceType = System.Collections.Generic.IEnumerable(itemType);
  // add the interface to the list of interfaces for the class
  targetClass.interfaces.push(dictionaryInterfaceType);

  // the backing field
  const dictionaryType = System.Collections.Generic.Dictionary(keyType, valueType);
  accessViaMember = accessViaMember || targetClass.add(new Field(`__${name}`, dictionaryInterfaceType, { initialValue: dictionaryType.new() }));

  const indexer = targetClass.add(new Indexer(keyType, valueType, { get: toExpression(`${accessViaMember}["index"]`), set: toExpression(`${accessViaMember}["index"] = value`) }));

  // the parameters used in methods.

  const pKey = new Parameter('key', keyType);
  const pValue = new Parameter('value', valueType);
  const pItem = new Parameter('item', itemType);
  const pItemArray = new Parameter('items', dotnet.Array(itemType));
  const pIndex = new Parameter('index', dotnet.Int);
  const pOutValue = new Parameter('value', valueType, { modifier: ParameterModifier.Out });

  targetClass.add(new Property(`${dictionaryInterfaceType.declaration}.Keys`, System.Collections.Generic.ICollection(keyType), { get: toExpression(`${accessViaMember}.Keys`), getAccess: Access.Explicit }));
  targetClass.add(new Property(`${dictionaryInterfaceType.declaration}.Values`, System.Collections.Generic.ICollection(valueType), { get: toExpression(`${accessViaMember}.Values`), getAccess: Access.Explicit }));
  targetClass.add(new Property(`${collectionInterfaceType.declaration}.Count`, dotnet.Int, { get: toExpression(`${accessViaMember}.Count`), getAccess: Access.Explicit }));
  targetClass.add(new Property(`${collectionInterfaceType.declaration}.IsReadOnly`, dotnet.Bool, { get: toExpression(`${accessViaMember}.IsReadOnly`), getAccess: Access.Explicit }));

  targetClass.add(new Method(`${dictionaryInterfaceType.declaration}.Add`, dotnet.Void, { parameters: [pKey, pValue], body: toExpression(`${accessViaMember}.Add( ${pKey}, ${pValue})`), access: Access.Explicit }));
  targetClass.add(new Method(`${collectionInterfaceType.declaration}.Add`, dotnet.Void, { parameters: [pItem], body: toExpression(`${accessViaMember}.Add( ${pItem})`), access: Access.Explicit }));
  targetClass.add(new Method(`${collectionInterfaceType.declaration}.Clear`, dotnet.Void, { body: toExpression(`${accessViaMember}.Clear()`), access: Access.Explicit }));

  targetClass.add(new Method(`${collectionInterfaceType.declaration}.Contains`, dotnet.Bool, { parameters: [pItem], body: toExpression(`${accessViaMember}.Contains( ${pItem})`), access: Access.Explicit }));
  targetClass.add(new Method(`${dictionaryInterfaceType.declaration}.ContainsKey`, dotnet.Bool, { parameters: [pKey], body: toExpression(`${accessViaMember}.ContainsKey( ${pKey})`), access: Access.Explicit }));
  targetClass.add(new Method(`${collectionInterfaceType.declaration}.CopyTo`, dotnet.Void, { parameters: [pItemArray, pIndex], body: toExpression(`${accessViaMember}.CopyTo(${pItemArray},${pIndex})`), access: Access.Explicit }));

  targetClass.add(new Method(`${enumerableInterfaceType.declaration}.GetEnumerator`, System.Collections.Generic.IEnumerator(itemType), { body: toExpression(`${accessViaMember}.GetEnumerator()`), access: Access.Explicit }));
  targetClass.add(new Method('global::System.Collections.IEnumerable.GetEnumerator', System.Collections.IEnumerator, { body: toExpression(`${accessViaMember}.GetEnumerator()`), access: Access.Explicit }));

  targetClass.add(new Method(`${dictionaryInterfaceType.declaration}.Remove`, dotnet.Bool, { parameters: [pKey], body: toExpression(`${accessViaMember}.Remove( ${pKey})`), access: Access.Explicit }));
  targetClass.add(new Method(`${collectionInterfaceType.declaration}.Remove`, dotnet.Bool, { parameters: [pItem], body: toExpression(`${accessViaMember}.Remove( ${pItem})`), access: Access.Explicit }));

  targetClass.add(new Method(`${dictionaryInterfaceType.declaration}.TryGetValue`, dotnet.Bool, { parameters: [pKey, pOutValue], body: toExpression(`${accessViaMember}.TryGetValue( ${pKey}, out ${pOutValue})`), access: Access.Explicit }));

  return dictionaryInterfaceType;
}