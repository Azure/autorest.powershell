namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class SingleConverter : JsonConverter<float>
    {
        public override JsonNode ToJson(float value) => new JsonNumber(value.ToString());

        public override float FromJson(JsonNode node) => (float)node;
    }
}