namespace Carbon.Json
{
    using System;
    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public partial class XNodeArray
    {
        public static XNodeArray Create<T>(T[] source, Func<T, JsonNode> selector)
        {
            if (source == null || selector == null)
            {
                return null;
            }
            var result = new XNodeArray();
            foreach (var item in source.Select(selector))
            {
                result.SafeAdd(item);
            }
            return result;
        }
        public void SafeAdd(JsonNode item)
        {
            if (item != null)
            {
                items.Add(item);
            }
        }
        public void SafeAdd(Func<JsonNode> itemFn)
        {
            if (itemFn != null)
            {
                var item = itemFn();
                if (item != null)
                {
                    items.Add(item);
                }
            }
        }
    }
}