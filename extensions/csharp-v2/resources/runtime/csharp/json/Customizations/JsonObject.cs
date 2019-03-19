namespace Carbon.Json
{
    using System;
    using System.Collections.Generic;

    public partial class JsonObject
    {
        internal override object ToValue() => Microsoft.Rest.ClientRuntime.JsonSerializable.FromJson(this, new System.Collections.Generic.Dictionary<string, object>());

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
                //throw new Exception($"Property {propertyName} in object expected type {typeof(T).Name} but value of type {value.Type.ToString()} was found.");
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
                // throw new Exception($"Property {propertyName} in object expected type {typeof(T).Name} but value of type {value.Type.ToString()} was found.");
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


}