import { Field, System, Property, toExpression, dotnet, Parameter, ParameterModifier, Method, Class, TypeDeclaration } from '@microsoft.azure/codegen-csharp';

export function implementIDictionary(targetClass: Class, name: String, keyType: TypeDeclaration, valueType: TypeDeclaration) {
  console.error(`ADDING IDICTIONARY [${keyType}, ${valueType}] to class ${targetClass.fullName}`);
  
  // add the interface to the list of interfaces for the class
  targetClass.interfaces.push(System.Collections.Generic.IDictionary(keyType, valueType));

  // the backing field
  const dictionaryType = System.Collections.Generic.Dictionary(keyType, valueType);
  const field = targetClass.add(new Field(`__${name}`, dictionaryType, { initialValue: dictionaryType.new() }));

  // the parameters used in methods.
  const itemType = System.Collections.Generic.KeyValuePair(keyType, valueType);
  const pKey = new Parameter('key', keyType);
  const pValue = new Parameter('value', valueType);
  const pItem = new Parameter('item', itemType);
  const pItemArray = new Parameter('items', dotnet.Array(itemType));
  const pIndex = new Parameter('index', dotnet.Int);
  const pOutValue = new Parameter('value', valueType, { modifier: ParameterModifier.Out });

  targetClass.add(new Property('Keys', System.Collections.Generic.ICollection(keyType), { get: toExpression(`${field}.Keys`) }));
  targetClass.add(new Property('Values', System.Collections.Generic.ICollection(valueType), { get: toExpression(`${field}.Values`) }));
  targetClass.add(new Property('Count', dotnet.Int, { get: toExpression(`${field}.Count`) }));
  targetClass.add(new Property('IsReadOnly', dotnet.Bool, { get: toExpression(`${field}.IsReadOnly`) }));

  targetClass.add(new Method('Add', dotnet.Void, { parameters: [pKey, pValue], body: toExpression(`${field}.Add( ${pKey}, ${pValue})`) }));
  targetClass.add(new Method('Add', dotnet.Void, { parameters: [pItem], body: toExpression(`${field}.Add( ${pItem})`) }));
  targetClass.add(new Method('Clear', dotnet.Void, { body: toExpression(`${field}.Clear()`) }));

  targetClass.add(new Method('Contains', dotnet.Bool, { parameters: [pItem], body: toExpression(`${field}.Contains( ${pItem})`) }));
  targetClass.add(new Method('ContainsKey', dotnet.Bool, { parameters: [pKey], body: toExpression(`${field}.ContainsKey( ${pKey})`) }));
  targetClass.add(new Method('CopyTo', dotnet.Void, { parameters: [pItemArray, pIndex], body: toExpression(`${field}.CopyTo(${pItemArray},${pIndex})`) }));

  targetClass.add(new Method('GetEnumerator', System.Collections.Generic.IEnumerator(itemType), { body: toExpression(`${field}.GetEnumerator()`) }));
  targetClass.add(new Method('IEnumerable.GetEnumerator', System.Collections.IEnumerator, { body: toExpression(`${field}.GetEnumerator()`) }));

  targetClass.add(new Method('Remove', dotnet.Bool, { parameters: [pKey], body: toExpression(`${field}.Remove( ${pKey})`) }));
  targetClass.add(new Method('Remove', dotnet.Bool, { parameters: [pItem], body: toExpression(`${field}.Remove( ${pItem})`) }));

  targetClass.add(new Method('TryGetValue', dotnet.Bool, { parameters: [pKey, pOutValue], body: toExpression(`${field}.TryGetValue( ${pKey}, out ${pOutValue})`) }));
}


  // add a container for the dictionary
  // targetClass.Add(new InitializedField)

  // hook up all the methods to the container

  /*
       
        
        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) => this._additionalProperties.CopyTo(array, arrayIndex);
        
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => this._additionalProperties.GetEnumerator();
        
        public bool Remove(string key) => this._additionalProperties.Remove(key);
        
        public bool Remove(KeyValuePair<string, object> item) => this._additionalProperties.Remove(item);
        
        public bool TryGetValue(string key, out object value) => this._additionalProperties.TryGetValue(key, out value);
        
        IEnumerator IEnumerable.GetEnumerator()=> this._additionalProperties.GetEnumerator();


         private global::System.Collections.Generic.Dictionary<string, T> _additionalProperties = new global::System.Collections.Generic.Dictionary<string, T>();
        public object this[string key] {
           get => this._additionalProperties[key];
           set => this._additionalProperties[key] = value;
        }

        public ICollection<string> Keys => this._additionalProperties.Keys;

        public ICollection<object> Values => this._additionalProperties.Values;

        public int Count => this._additionalProperties.Count;

        public bool IsReadOnly => this._additionalProperties.IsReadOnly;

        public void Add(string key, object value) => this._additionalProperties.Add(key, value);

        public void Add(KeyValuePair<string, object> item) => this._additionalProperties.Add(item);

        public void Clear() => this._additionalProperties.Clear();

        public bool Contains(KeyValuePair<string, object> item) => this._additionalProperties.Contains(item);

        public bool ContainsKey(string key) this._additionalProperties.ContainsKey(key);
        */
