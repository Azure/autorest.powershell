using System;

namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override JsonNode ToJson(TimeSpan value) => new JsonString(value.ToString());

        public override TimeSpan FromJson(JsonNode node) => (TimeSpan)node;
    }
}