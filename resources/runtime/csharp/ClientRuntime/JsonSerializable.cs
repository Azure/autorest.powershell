
using Carbon.Json;

namespace Microsoft.Rest.ClientRuntime
{
    [System.Flags]
    public enum JsonMode
    {
        None = 0,
        IncludeHeaders = 1 << 0,
        IncludeReadOnly = 1 << 1,

        IncludeAll = IncludeHeaders | IncludeReadOnly
    }

    public interface IJsonSerializable
    {
        JsonNode ToJson(JsonObject container = null, JsonMode serializationMode = JsonMode.None);
    }

}