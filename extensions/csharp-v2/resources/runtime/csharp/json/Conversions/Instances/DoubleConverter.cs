namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class DoubleConverter : JsonConverter<double>
    {
        public override JsonNode ToJson(double value) => new JsonNumber(value);

        public override double FromJson(JsonNode node) => (double)node;
    }
}