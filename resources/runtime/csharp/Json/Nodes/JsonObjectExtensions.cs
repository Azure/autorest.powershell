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
                    return null; //gs01:???
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
                if (value is T tval)
                {
                    return tval;
                }
                /* it's present, but not the correct type...  */
                throw new Exception($"Property {propertyName} in object expected type {typeof(T).Name} but value of type {value.Type.ToString()} was found.");
            }
            return null;
        }

        public int NumberProperty(string propertyName, ref int output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public float NumberProperty(string propertyName, ref float output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public byte NumberProperty(string propertyName, ref byte output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public long NumberProperty(string propertyName, ref long output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public double NumberProperty(string propertyName, ref double output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public decimal NumberProperty(string propertyName, ref decimal output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public short NumberProperty(string propertyName, ref short output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public DateTime NumberProperty(string propertyName, ref DateTime output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;

        public int? NumberProperty(string propertyName, ref int? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public float? NumberProperty(string propertyName, ref float? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public byte? NumberProperty(string propertyName, ref byte? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public long? NumberProperty(string propertyName, ref long? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public double? NumberProperty(string propertyName, ref double? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public decimal? NumberProperty(string propertyName, ref decimal? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;
        public short? NumberProperty(string propertyName, ref short? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;

        public DateTime? NumberProperty(string propertyName, ref DateTime? output) => output = this.PropertyT<JsonNumber>(propertyName) ?? output;


        public string StringProperty(string propertyName) => this.PropertyT<JsonString>(propertyName);
        public string StringProperty(string propertyName, ref string output) => output = this.PropertyT<JsonString>(propertyName) ?? output;
        public char StringProperty(string propertyName, ref char output) => output = this.PropertyT<JsonString>(propertyName) ?? output;
        public char? StringProperty(string propertyName, ref char? output) => output = this.PropertyT<JsonString>(propertyName) ?? output;

        public DateTime StringProperty(string propertyName, ref DateTime output) => DateTime.TryParse(this.PropertyT<JsonString>(propertyName), out output) ? output : output;
        public DateTime? StringProperty(string propertyName, ref DateTime? output) => output = DateTime.TryParse(this.PropertyT<JsonString>(propertyName), out var o) ? o : output;


        public bool BooleanProperty(string propertyName, ref bool output) => output = this.PropertyT<JsonBoolean>(propertyName) ?? output;
        public bool? BooleanProperty(string propertyName, ref bool? output) => output = this.PropertyT<JsonBoolean>(propertyName) ?? output;

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

        public static implicit operator char(JsonString value) => value?.ToString()?.FirstOrDefault() ?? default(char);
        public static implicit operator char? (JsonString value) => value?.ToString()?.FirstOrDefault();

        public static implicit operator DateTime(JsonString value) => DateTime.TryParse(value, out var output) ? output : default(DateTime);
        public static implicit operator DateTime? (JsonString value) => DateTime.TryParse(value, out var output) ? output : default(DateTime?);

    }
    public partial class JsonBoolean
    {
        public static JsonBoolean Create(bool? value) => value is bool b ? new JsonBoolean(b) : null;

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

        public static JsonNumber Create(int? value) => value is int n ? new JsonNumber(n) : null;
        public static JsonNumber Create(long? value) => value is long n ? new JsonNumber(n) : null;
        public static JsonNumber Create(float? value) => value is float n ? new JsonNumber(n) : null;
        public static JsonNumber Create(double? value) => value is double n ? new JsonNumber(n) : null;
        public static JsonNumber Create(decimal? value) => value is decimal n ? new JsonNumber(n) : null;
        public static JsonNumber Create(DateTime? value) => value is DateTime date ? new JsonNumber(ToUnixTime(date)) : null;

        public static implicit operator DateTime(JsonNumber number) => FromUnixTime(number);

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