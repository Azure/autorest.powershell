using System;

namespace Carbon.Json.Converters
{
    internal sealed class UriConverter : JsonConverter<Uri>
    {
        public override JsonNode ToJson(Uri value) => new JsonString(value.AbsoluteUri);

        public override Uri FromJson(JsonNode node) => (Uri)node;
    }
}