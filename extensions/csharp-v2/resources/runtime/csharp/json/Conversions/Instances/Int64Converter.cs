namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class Int64Converter : JsonConverter<long>
    {
        public override JsonNode ToJson(long value) => new JsonNumber(value);

        public override long FromJson(JsonNode node) => (long)node;
    }
}