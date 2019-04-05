namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public abstract class JsonConverter<T> : IJsonConverter
    {
        public abstract T FromJson(JsonNode node);

        public abstract JsonNode ToJson(T value);

        #region IConverter

        object IJsonConverter.FromJson(JsonNode node) => FromJson(node);

        JsonNode IJsonConverter.ToJson(object value) => ToJson((T)value);

        #endregion
    }
}