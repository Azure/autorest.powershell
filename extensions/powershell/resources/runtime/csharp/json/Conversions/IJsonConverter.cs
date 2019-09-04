namespace Carbon.Json.Converters
{
    public interface IJsonConverter
    {
        JsonNode ToJson(object value);

        object FromJson(JsonNode node);
    }
}