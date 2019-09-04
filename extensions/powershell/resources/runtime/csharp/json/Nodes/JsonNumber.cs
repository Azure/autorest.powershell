using System;

namespace Carbon.Json
{
    public sealed partial class JsonNumber : JsonNode
    {
        private readonly string value;
        private readonly bool overflows = false;

        public JsonNumber(string value)
        {
            this.value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public JsonNumber(int value)
        {
            this.value = value.ToString();
        }

        public JsonNumber(long value)
        {
            this.value = value.ToString();

            if (value > 9007199254740991)
            {
                overflows = true;
            }
        }

        public JsonNumber(float value)
        {
            this.value = value.ToString();
        }

        public JsonNumber(double value)
        {
            this.value = value.ToString();
        }

        public override JsonType Type => JsonType.Number;

        public string Value => value;

        #region Helpers

        public bool Overflows => overflows;

        public bool IsInteger => !value.Contains(".");

        public bool IsFloat => value.Contains(".");

        #endregion

        #region Casting

        public static implicit operator byte(JsonNumber number)
            => byte.Parse(number.Value);

        public static implicit operator short(JsonNumber number)
            => short.Parse(number.Value);

        public static implicit operator int(JsonNumber number)
            => int.Parse(number.Value);

        public static implicit operator long(JsonNumber number)
            => long.Parse(number.value);

        public static implicit operator UInt16(JsonNumber number)
            => ushort.Parse(number.Value);

        public static implicit operator UInt32(JsonNumber number)
            => uint.Parse(number.Value);

        public static implicit operator UInt64(JsonNumber number)
            => ulong.Parse(number.Value);

        public static implicit operator decimal(JsonNumber number)
            => decimal.Parse(number.Value);

        public static implicit operator Double(JsonNumber number)
            => double.Parse(number.value);

        public static implicit operator float(JsonNumber number)
            => float.Parse(number.value);

        public static implicit operator JsonNumber(short data)
            => new JsonNumber(data.ToString());

        public static implicit operator JsonNumber(int data)
            => new JsonNumber(data);

        public static implicit operator JsonNumber(long data)
            => new JsonNumber(data);

        public static implicit operator JsonNumber(Single data)
            => new JsonNumber(data.ToString());

        public static implicit operator JsonNumber(double data)
            => new JsonNumber(data.ToString());

        #endregion

        public override string ToString() => value;
    }
}