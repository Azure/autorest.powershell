namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class Int32Converter : JsonConverter<int>
    {
        public override JsonNode ToJson(int value) => new JsonNumber(value);

        public override int FromJson(JsonNode node) => (int)node;
    }
}