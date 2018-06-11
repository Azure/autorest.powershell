using System;

namespace Carbon.Json.Converters
{
    internal sealed class EnumConverter : IJsonConverter
    {
        private readonly Type type;

        public EnumConverter(Type type)
        {
            this.type = type ?? throw new ArgumentNullException(nameof(type));
        }

        public JsonNode ToJson(object value) => new JsonString(value.ToString());

        public object FromJson(JsonNode node)
        {
            if (node.Type == JsonType.Number)
            {
                return Enum.ToObject(type, (int)node);
            }

            return Enum.Parse(type, node, ignoreCase: true);
        }
    }
}