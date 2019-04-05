namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class Int16Converter : JsonConverter<short>
    {
        public override JsonNode ToJson(short value) => new JsonNumber(value);

        public override short FromJson(JsonNode node) => (short)node;
    }
}