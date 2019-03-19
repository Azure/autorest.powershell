namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class JsonObjectConverter : JsonConverter<JsonObject>
    {
        public override JsonNode ToJson(JsonObject value) => value;

        public override JsonObject FromJson(JsonNode node) => (JsonObject)node;
    }
}