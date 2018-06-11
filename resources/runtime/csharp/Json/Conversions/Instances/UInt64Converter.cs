namespace Carbon.Json.Converters
{
    internal sealed class UInt64Converter : JsonConverter<ulong>
    {
        public override JsonNode ToJson(ulong value) => new JsonNumber(value.ToString());

        public override ulong FromJson(JsonNode node) => (ulong)node;
    }
}