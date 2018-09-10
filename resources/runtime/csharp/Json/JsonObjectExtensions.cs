namespace Carbon.Json
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public partial class JsonObject
    {
        public void SafeAdd(string name, Func<JsonNode> valueFn)
        {
            if (valueFn != null)
            {
                var value = valueFn();
                if (null != value)
                {
                    items.Add(name, value);
                }
            }
        }

        public void SafeAdd(string name, JsonNode value)
        {
            if (null != value)
            {
                items.Add(name, value);
            }
        }

        public T NullableProperty<T>(string propertyName) where T : JsonNode
        {
            if (this.TryGetValue(propertyName, out JsonNode value))
            {
                if (value.IsNull)
                {
                    return null;
                }
                if (value is T tval)
                {
                    return tval;
                }
                /* it's present, but not the correct type...  */
                throw new Exception($"Property {propertyName} in object expected type {typeof(T).Name} but value of type {value.Type.ToString()} was found.");
            }
            return null;
        }

        public JsonObject Property(string propertyName)
        {
            return PropertyT<JsonObject>(propertyName);
        }

        public T PropertyT<T>(string propertyName) where T : JsonNode
        {
            if (this.TryGetValue(propertyName, out JsonNode value))
            {
                if (value.IsNull)
                {
                    return null; // we're going to assume that the consumer knows what to do if null is explicity returned?
                }

                if (value is T tval)
                {
                    return tval;
                }
                /* it's present, but not the correct type...  */
                throw new Exception($"Property {propertyName} in object expected type {typeof(T).Name} but value of type {value.Type.ToString()} was found.");
            }
            return null;
        }

        public int NumberProperty(string propertyName, ref int output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToInt() ?? output;
        public float NumberProperty(string propertyName, ref float output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToFloat() ?? output;
        public byte NumberProperty(string propertyName, ref byte output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToByte() ?? output;
        public long NumberProperty(string propertyName, ref long output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToLong() ?? output;
        public double NumberProperty(string propertyName, ref double output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToDouble() ?? output;
        public decimal NumberProperty(string propertyName, ref decimal output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToDecimal() ?? output;
        public short NumberProperty(string propertyName, ref short output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToShort() ?? output;
        public DateTime NumberProperty(string propertyName, ref DateTime output) => output = this.PropertyT<JsonNumber>(propertyName)?.ToDateTime() ?? output;

        public int? NumberProperty(string propertyName, ref int? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToInt() ?? null;
        public float? NumberProperty(string propertyName, ref float? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToFloat() ?? null;
        public byte? NumberProperty(string propertyName, ref byte? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToByte() ?? null;
        public long? NumberProperty(string propertyName, ref long? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToLong() ?? null;
        public double? NumberProperty(string propertyName, ref double? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToDouble() ?? null;
        public decimal? NumberProperty(string propertyName, ref decimal? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToDecimal() ?? null;
        public short? NumberProperty(string propertyName, ref short? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToShort() ?? null;

        public DateTime? NumberProperty(string propertyName, ref DateTime? output) => output = this.NullableProperty<JsonNumber>(propertyName)?.ToDateTime() ?? null;


        public string StringProperty(string propertyName) => this.PropertyT<JsonString>(propertyName)?.ToString();
        public string StringProperty(string propertyName, ref string output) => output = this.PropertyT<JsonString>(propertyName)?.ToString() ?? output;
        public char StringProperty(string propertyName, ref char output) => output = this.PropertyT<JsonString>(propertyName)?.ToChar() ?? output;
        public char? StringProperty(string propertyName, ref char? output) => output = this.PropertyT<JsonString>(propertyName)?.ToChar() ?? null;

        public DateTime StringProperty(string propertyName, ref DateTime output) => DateTime.TryParse(this.PropertyT<JsonString>(propertyName)?.ToString(), out output) ? output : output;
        public DateTime? StringProperty(string propertyName, ref DateTime? output) => output = DateTime.TryParse(this.PropertyT<JsonString>(propertyName)?.ToString(), out var o) ? o : output;


        public bool BooleanProperty(string propertyName, ref bool output) => output = this.PropertyT<JsonBoolean>(propertyName)?.ToBoolean() ?? output;
        public bool? BooleanProperty(string propertyName, ref bool? output) => output = this.PropertyT<JsonBoolean>(propertyName)?.ToBoolean() ?? null;

        public T[] ArrayProperty<T>(string propertyName, ref T[] output, Func<JsonNode, T> deserializer)
        {
            var array = this.PropertyT<JsonArray>(propertyName);
            if (array != null)
            {
                output = new T[array.Count];
                for (var i = 0; i < output.Length; i++)
                {
                    output[i] = deserializer(array[i]);
                }
            }
            return output;
        }

        public Dictionary<string, T> DictionaryProperty<T>(string propertyName, ref Dictionary<string, T> output, Func<JsonNode, T> deserializer)
        {
            var dictionary = this.PropertyT<JsonObject>(propertyName);
            if (output == null)
            {
                output = new Dictionary<string, T>();
            }
            else
            {
                output.Clear();
            }
            if (dictionary != null)
            {
                foreach (var key in dictionary.Keys)
                {
                    output[key] = deserializer(dictionary[key]);
                }
            }
            return output;
        }

        public static JsonObject Create<T>(IDictionary<string, T> source, Func<T, JsonNode> selector)
        {
            if (source == null || selector == null)
            {
                return null;
            }
            var result = new JsonObject();

            foreach (var key in source.Keys)
            {
                result.SafeAdd(key, selector(source[key]));
            }
            return result;
        }
    }

    public class foo<T> where T : new()
    {

    }

    public partial class JsonString
    {
        public static string DateFormat = "yyyy-MM-dd";
        public static string DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        public static string DateTimeRfc1123Format = "R";

        public static JsonString Create(string value) => value == null ? null : new JsonString(value);
        public static JsonString Create(char? value) => value is char c ? new JsonString(c.ToString()) : null;

        public static JsonString CreateDate(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateFormat, CultureInfo.CurrentCulture)) : null;
        public static JsonString CreateDateTime(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeFormat, CultureInfo.CurrentCulture)) : null;
        public static JsonString CreateDateTimeRfc1123(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeRfc1123Format, CultureInfo.CurrentCulture)) : null;

        public char ToChar() => this.Value?.ToString()?.FirstOrDefault() ?? default(char);
        public static implicit operator char(JsonString value) => value?.ToString()?.FirstOrDefault() ?? default(char);
        public static implicit operator char? (JsonString value) => value?.ToString()?.FirstOrDefault();

        public static implicit operator DateTime(JsonString value) => DateTime.TryParse(value, out var output) ? output : default(DateTime);
        public static implicit operator DateTime? (JsonString value) => DateTime.TryParse(value, out var output) ? output : default(DateTime?);

    }
    public partial class JsonBoolean
    {
        public static JsonBoolean Create(bool? value) => value is bool b ? new JsonBoolean(b) : null;
        public bool ToBoolean() => Value;

    }
    public partial class JsonNumber
    {
        public static readonly DateTime EpochDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static long ToUnixTime(DateTime dateTime)
        {
            return (long)dateTime.Subtract(EpochDate).TotalSeconds;
        }
        private static DateTime FromUnixTime(long totalSeconds)
        {
            return EpochDate.AddSeconds(totalSeconds);
        }
        public byte ToByte() => this;
        public int ToInt() => this;
        public long ToLong() => this;
        public short ToShort() => this;
        public UInt16 ToUInt16() => this;
        public UInt32 ToUInt32() => this;
        public UInt64 ToUInt64() => this;
        public decimal ToDecimal() => this;
        public double ToDouble() => this;
        public float ToFloat() => this;

        public static JsonNumber Create(int? value) => value is int n ? new JsonNumber(n) : null;
        public static JsonNumber Create(long? value) => value is long n ? new JsonNumber(n) : null;
        public static JsonNumber Create(float? value) => value is float n ? new JsonNumber(n) : null;
        public static JsonNumber Create(double? value) => value is double n ? new JsonNumber(n) : null;
        public static JsonNumber Create(decimal? value) => value is decimal n ? new JsonNumber(n) : null;
        public static JsonNumber Create(DateTime? value) => value is DateTime date ? new JsonNumber(ToUnixTime(date)) : null;

        public static implicit operator DateTime(JsonNumber number) => FromUnixTime(number);
        public DateTime ToDateTime() => this;

        public JsonNumber(decimal value)
        {
            this.value = value.ToString();
        }
    }

    public partial class XNodeArray
    {
        public static XNodeArray Create<T>(T[] source, Func<T, JsonNode> selector)
        {
            if (source == null || selector == null)
            {
                return null;
            }
            var result = new XNodeArray();
            foreach (var item in source.Select(selector))
            {
                result.SafeAdd(item);
            }
            return result;
        }
        public void SafeAdd(JsonNode item)
        {
            if (item != null)
            {
                items.Add(item);
            }
        }
        public void SafeAdd(Func<JsonNode> itemFn)
        {
            if (itemFn != null)
            {
                var item = itemFn();
                if (item != null)
                {
                    items.Add(item);
                }
            }
        }
    }


}