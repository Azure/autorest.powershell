namespace Carbon.Json
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public partial class JsonBoolean
    {
        public static JsonBoolean Create(bool? value) => value is bool b ? new JsonBoolean(b) : null;
        public bool ToBoolean() => Value;

        internal override object ToValue() => Value;
    }
}