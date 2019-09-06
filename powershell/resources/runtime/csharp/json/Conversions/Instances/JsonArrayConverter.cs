namespace Carbon.Json.Converters
{
    internal sealed class JsonArrayConverter : JsonConverter<JsonArray>
    {
        public override JsonNode ToJson(JsonArray value) => value;

        public override JsonArray FromJson(JsonNode node) => (JsonArray)node;
    }
}