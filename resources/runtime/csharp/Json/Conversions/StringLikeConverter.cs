using System;
using System.Reflection;

namespace Carbon.Json.Converters
{
    public sealed class StringLikeConverter : IJsonConverter
    {
        private readonly Type type;
        private readonly MethodInfo parseMethod;

        public StringLikeConverter(Type type)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
            this.parseMethod = StringLikeHelper.GetParseMethod(type);
        }
        
        public object FromJson(JsonNode node) => 
            parseMethod.Invoke(null, new[] { node.ToString() });

        public JsonNode ToJson(object value) =>
            new JsonString(value.ToString());        
    }

    internal static class StringLikeHelper
    {
        public static bool IsStringLike(Type type)
        {
            return GetParseMethod(type) != null;
        }

        public static MethodInfo GetParseMethod(Type type)
        {
            var method = type.GetMethod("Parse", new[] { typeof(string) });

            if (method?.IsPublic != true) return null;

            return method;
        }
    }
}