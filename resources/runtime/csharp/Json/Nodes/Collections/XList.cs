using System;
using System.Collections;
using System.Collections.Generic;

namespace Carbon.Json
{
    public class XList<T> : JsonArray, IEnumerable<JsonNode>
    {
        private readonly IList<T> values;
        private readonly JsonType elementType;
        private readonly TypeCode elementCode;

        public XList(IList<T> values)
        {
            #region Preconditions

            if (values == null)
                throw new ArgumentNullException(nameof(values));

            if (values.Count == 0)
                throw new ArgumentException("Must not be empty", nameof(values));

            #endregion

            this.values = values;
            this.elementCode = System.Type.GetTypeCode(typeof(T));
            this.elementType = XHelper.GetElementType(this.elementCode);
        }

        public override JsonNode this[int index] =>
            XHelper.Create(elementType, elementCode, values[index]);

        public override JsonType? ElementType => elementType;

        public override int Count => values.Count;

        public bool IsReadOnly => values.IsReadOnly;

        #region IList

        public void Add(T value)
        {
            values.Add(value);
        }

        public bool Contains(T value)
            => values.Contains(value);

        #endregion

        #region IEnumerable Members

        IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator()
        {
            foreach (var value in values)
            {
                yield return XHelper.Create(elementType, elementCode, value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var value in values)
            {
                yield return XHelper.Create(elementType, elementCode, value);
            }
        }

        #endregion
    }
}