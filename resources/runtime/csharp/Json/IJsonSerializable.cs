
using Carbon.Json;

namespace Microsoft.Rest.ClientRuntime
{
    public interface IJsonSerializable
    {
        JsonNode ToJson(JsonObject container = null, SerializationMode serializationMode = SerializationMode.None);
    }
}