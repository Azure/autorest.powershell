namespace Carbon.Json.Converters
{
    internal sealed class SingleConverter : JsonConverter<float>
    {
        public override JsonNode ToJson(float value) => new JsonNumber(value.ToString());

        public override float FromJson(JsonNode node) => (float)node;
    }
}