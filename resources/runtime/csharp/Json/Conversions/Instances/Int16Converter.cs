namespace Carbon.Json.Converters
{
    internal sealed class Int16Converter : JsonConverter<short>
    {
        public override JsonNode ToJson(short value) => new JsonNumber(value);

        public override short FromJson(JsonNode node) => (short)node;
    }
}