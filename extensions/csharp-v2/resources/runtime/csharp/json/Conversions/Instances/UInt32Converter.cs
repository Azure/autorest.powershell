namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class UInt32Converter : JsonConverter<uint>
    {
        public override JsonNode ToJson(uint value) => new JsonNumber(value);

        public override uint FromJson(JsonNode node) => (uint)node;
    }
}