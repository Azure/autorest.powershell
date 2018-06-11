namespace Carbon.Json.Converters
{
    internal sealed class DoubleConverter : JsonConverter<double>
    {
        public override JsonNode ToJson(double value) => new JsonNumber(value);

        public override double FromJson(JsonNode node) => (double)node;
    }
}