using System.Collections;
using System.Collections.Generic;

namespace Carbon.Json
{
    public partial class XNodeArray : JsonArray, ICollection<JsonNode>
    {
        private readonly List<JsonNode> items;

        public XNodeArray()
        {
            items = new List<JsonNode>();
        }

        public XNodeArray(params JsonNode[] values)
        {
            items = new List<JsonNode>(values);
        }

        public override JsonNode this[int index] => items[index];

        public override JsonType? ElementType => null;

        public bool IsReadOnly => false;

        public override int Count => items.Count;

        #region ICollection<XNode> Members

        public void Add(JsonNode item)
        {
            items.Add(item);
        }

        void ICollection<JsonNode>.Clear()
        {
            items.Clear();
        }

        public bool Contains(JsonNode item) => items.Contains(item);

        void ICollection<JsonNode>.CopyTo(JsonNode[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public bool Remove(JsonNode item)
        {
            return items.Remove(item);
        }

        #endregion

        #region IEnumerable Members

        IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator()
            => items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => items.GetEnumerator();

        #endregion
    }
}