using System;

namespace Carbon.Json
{
    public class ConversionException : Exception
    {
        public ConversionException(string message)
            : base(message) { }

        public ConversionException(JsonNode node, Type targetType)
            : base($"Cannot convert '{node.Type}' to a {targetType.Name}") { }
    }
}