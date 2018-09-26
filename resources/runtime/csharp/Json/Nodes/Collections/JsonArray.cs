using System;
using System.Collections;
using System.Collections.Generic;

namespace Carbon.Json
{
    public abstract partial class JsonArray : JsonNode, IEnumerable<JsonNode>
    {
        public override JsonType Type => JsonType.Array;

        public abstract JsonType? ElementType { get; }

        public abstract int Count { get; }

        public virtual bool IsSet => false;

        public bool IsEmpty => Count == 0;

        #region IEnumerable

        IEnumerator<JsonNode> IEnumerable<JsonNode>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Static Helpers

        public static JsonArray Create(short[] values)
            => new XImmutableArray<short>(values);

        public static JsonArray Create(int[] values)
            => new XImmutableArray<int>(values);

        public static JsonArray Create(long[] values)
            => new XImmutableArray<long>(values);

        public static JsonArray Create(decimal[] values)
            => new XImmutableArray<decimal>(values);

        public static JsonArray Create(float[] values)
            => new XImmutableArray<float>(values);

        public static JsonArray Create(string[] values)
            => new XImmutableArray<string>(values);

        public static JsonArray Create(XBinary[] values)
            => new XImmutableArray<XBinary>(values);

        #endregion

        public static new JsonArray Parse(string text)
            => (JsonArray)JsonNode.Parse(text);
    }
}