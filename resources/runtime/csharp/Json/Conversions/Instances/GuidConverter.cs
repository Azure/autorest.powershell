using System;

namespace Carbon.Json.Converters
{
    internal sealed class GuidConverter : JsonConverter<Guid>
    {
        public override JsonNode ToJson(Guid value) => new JsonString(value.ToString());

        public override Guid FromJson(JsonNode node) => (Guid)node;
    }
}