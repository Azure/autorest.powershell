namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class BooleanConverter : JsonConverter<bool>
    {
        public override JsonNode ToJson(bool value) => new JsonBoolean(value);

        public override bool FromJson(JsonNode node) => (bool)node;
    }
}