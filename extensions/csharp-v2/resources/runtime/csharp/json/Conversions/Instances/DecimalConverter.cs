namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class DecimalConverter : JsonConverter<decimal>
    {
        public override JsonNode ToJson(decimal value) => new JsonNumber(value.ToString());

        public override decimal FromJson(JsonNode node)
        {
            return (decimal)node;
        }
    }
}