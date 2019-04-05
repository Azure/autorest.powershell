using System;

namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public sealed class JsonConverterAttribute : Attribute
    {
        public JsonConverterAttribute(Type type)
        {
            Converter = (IJsonConverter)Activator.CreateInstance(type);
        }

        public IJsonConverter Converter { get; }
    }
}