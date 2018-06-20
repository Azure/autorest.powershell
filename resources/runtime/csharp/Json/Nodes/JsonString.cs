using System;

namespace Carbon.Json
{
    public sealed partial class JsonString : JsonNode
    {
        public JsonString(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public override JsonType Type => JsonType.String;

        public string Value { get; }

        public int Length => Value.Length;

        #region #region Implicit Casts

        public static implicit operator string(JsonString data) => data.Value;

        public static implicit operator JsonString(string data) => new JsonString(data);

        #endregion

        public override int GetHashCode()
            => Value.GetHashCode();

        public override string ToString() => Value;
    }
}