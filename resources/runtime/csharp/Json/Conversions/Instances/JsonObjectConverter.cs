namespace Carbon.Json.Converters
{
    internal sealed class JsonObjectConverter : JsonConverter<JsonObject>
    {
        public override JsonNode ToJson(JsonObject value) => value;

        public override JsonObject FromJson(JsonNode node) => (JsonObject)node;
    }
}