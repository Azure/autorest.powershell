using System;

namespace Carbon.Json
{
    public sealed partial class JsonBoolean : JsonNode
    {
        public static readonly JsonBoolean True = new JsonBoolean(true);
        public static readonly JsonBoolean False = new JsonBoolean(false);

        public JsonBoolean(bool value)
        {
            Value = value;
        }

        public bool Value { get; }

        public override JsonType Type => JsonType.Boolean;

        public static new JsonBoolean Parse(string text)
        {
            switch (text)
            {
                case "false": return False;
                case "true": return True;

                default: throw new ArgumentException($"Expected true or false. Was {text}.");
            }
        }

        #region Implicit Casts

        public static implicit operator bool(JsonBoolean data) => data.Value;

        public static implicit operator JsonBoolean(bool data) => new JsonBoolean(data);

        #endregion
    }
}