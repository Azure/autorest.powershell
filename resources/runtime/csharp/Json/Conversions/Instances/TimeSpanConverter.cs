using System;

namespace Carbon.Json.Converters
{
    internal sealed class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override JsonNode ToJson(TimeSpan value) => new JsonString(value.ToString());

        public override TimeSpan FromJson(JsonNode node) => (TimeSpan)node;
    }
}