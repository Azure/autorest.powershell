using System;

namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class GuidConverter : JsonConverter<Guid>
    {
        public override JsonNode ToJson(Guid value) => new JsonString(value.ToString());

        public override Guid FromJson(JsonNode node) => (Guid)node;
    }
}