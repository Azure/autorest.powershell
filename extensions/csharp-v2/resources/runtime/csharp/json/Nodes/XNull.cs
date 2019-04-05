namespace Carbon.Json
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public sealed class XNull : JsonNode
    {
        public static readonly XNull Instance = new XNull();

        private XNull() { }

        public override JsonType Type => JsonType.Null;
    }
}