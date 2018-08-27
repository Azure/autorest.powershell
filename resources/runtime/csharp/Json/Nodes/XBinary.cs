using System;

namespace Carbon.Json
{
    public sealed class XBinary : JsonNode
    {
        private readonly byte[] _value;
        private readonly string _base64;

        public XBinary(byte[] value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public XBinary(string base64EncodedString)
        {
            _base64 = base64EncodedString ?? throw new ArgumentNullException(nameof(base64EncodedString));
        }

        public override JsonType Type => JsonType.Binary;

        public byte[] Value => _value ?? Convert.FromBase64String(_base64);

        #region #region Implicit Casts

        public static implicit operator byte[] (XBinary data) => data.Value;

        public static implicit operator XBinary(byte[] data) => new XBinary(data);

        #endregion

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => _base64 ?? Convert.ToBase64String(_value);
    }
}