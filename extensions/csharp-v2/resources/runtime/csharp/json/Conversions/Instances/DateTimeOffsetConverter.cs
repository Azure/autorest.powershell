using System;

namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        public override JsonNode ToJson(DateTimeOffset value) => new JsonDate(value);

        public override DateTimeOffset FromJson(JsonNode node) => (DateTimeOffset)node;
    }
}