namespace Carbon.Json.Converters
{
    internal sealed class Int32Converter : JsonConverter<int>
    {
        public override JsonNode ToJson(int value) => new JsonNumber(value);

        public override int FromJson(JsonNode node) => (int)node;
    }
}