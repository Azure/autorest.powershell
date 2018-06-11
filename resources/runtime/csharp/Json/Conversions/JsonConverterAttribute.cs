using System;

namespace Carbon.Json.Converters
{
    public sealed class JsonConverterAttribute : Attribute
    {
        public JsonConverterAttribute(Type type)
        {
            Converter = (IJsonConverter)Activator.CreateInstance(type);
        }

        public IJsonConverter Converter { get; }
    }
}