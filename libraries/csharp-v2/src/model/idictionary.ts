import { InitializedField } from '#csharp/code-dom/field';
import { Method } from '#csharp/code-dom/method';
import { Class } from '#csharp/code-dom/class';
import { TypeDeclaration } from '#csharp/code-dom/type-declaration';

export function implementIDictionary(keyType: TypeDeclaration, valueType: TypeDeclaration, targetClass: Class) {


  // add a container for the dictionary
  // targetClass.Add(new InitializedField)

  // hook up all the methods to the container

  /*
        public object this[string key] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ICollection<string> Keys => throw new System.NotImplementedException();

        public ICollection<object> Values => throw new System.NotImplementedException();

        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => throw new System.NotImplementedException();

        public void Add(string key, object value)
        {
            throw new System.NotImplementedException();
        }

        public void Add(KeyValuePair<string, object> item)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(KeyValuePair<string, object> item)
        {
            throw new System.NotImplementedException();
        }

        public bool ContainsKey(string key)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(KeyValuePair<string, object> item)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGetValue(string key, out object value)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
  */
}