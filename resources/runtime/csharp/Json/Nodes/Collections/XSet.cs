using System;
using System.Collections;
using System.Collections.Generic;

namespace Carbon.Json
{
    public class XSet<T> : JsonArray, IEnumerable<JsonNode>
    {
        private readonly HashSet<T> values;
        private readonly JsonType elementType;
        private readonly TypeCode elementCode;

        public XSet(IEnumerable<T> values)
            : this(new HashSet<T>(values))
        { }

        public XSet(HashSet<T> values)
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

        public override JsonType Type => JsonType.Array;

        public override JsonType? ElementType => elementType;

        public bool IsReadOnly => true;

        public override int Count => values.Count;

        public override bool IsSet => true;

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

        public HashSet<T> AsHashSet() => values;
    }
}