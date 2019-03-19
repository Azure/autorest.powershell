using System;

namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class DateTimeConverter : JsonConverter<DateTime>
    {
        public override JsonNode ToJson(DateTime value)
        {
            return new JsonDate(value);
        }

        public override DateTime FromJson(JsonNode node) => (DateTime)node;
    }
}