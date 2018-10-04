using System;

namespace Carbon.Json.Converters
{
    internal sealed class DateTimeConverter : JsonConverter<DateTime>
    {
        public override JsonNode ToJson(DateTime value)
        {
            return new JsonDate(value);
        }

        public override DateTime FromJson(JsonNode node) => (DateTime)node;
    }
}