namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class StringConverter : JsonConverter<string>
    {
        public override JsonNode ToJson(string value) => new JsonString(value);

        public override string FromJson(JsonNode node) => node.ToString();
    }
}