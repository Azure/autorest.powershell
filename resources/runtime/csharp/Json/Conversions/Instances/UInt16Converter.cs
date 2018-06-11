namespace Carbon.Json.Converters
{
    internal sealed class UInt16Converter : JsonConverter<ushort>
    {
        public override JsonNode ToJson(ushort value) => new JsonNumber(value);

        public override ushort FromJson(JsonNode node) => (ushort)node;
    }
}