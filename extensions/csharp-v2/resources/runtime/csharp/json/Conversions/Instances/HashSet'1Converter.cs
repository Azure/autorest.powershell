using System.Collections.Generic;
using System.Linq;

namespace Carbon.Json.Converters
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal sealed class HashSetConverter<T> : JsonConverter<HashSet<T>>
    {
        public override JsonNode ToJson(HashSet<T> value)
        {
            return new XSet<T>(value);
        }

        public override HashSet<T> FromJson(JsonNode node)
        {
            var collection = node as ICollection<JsonNode>;

            if (collection.Count == 0) return null;

            // TODO: Remove Linq depedency
            return new HashSet<T>(collection.Cast<T>());
        }
    }
}