using System;

namespace Carbon.Json
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class ConversionException : Exception
    {
        public ConversionException(string message)
            : base(message) { }

        public ConversionException(JsonNode node, Type targetType)
            : base($"Cannot convert '{node.Type}' to a {targetType.Name}") { }
    }
}