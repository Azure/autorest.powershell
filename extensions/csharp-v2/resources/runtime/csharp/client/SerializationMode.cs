namespace Microsoft.Rest.ClientRuntime
{
    [System.Flags]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public enum SerializationMode
    {
        None = 0,
        IncludeHeaders = 1 << 0,
        IncludeReadOnly = 1 << 1,

        IncludeAll = IncludeHeaders | IncludeReadOnly
    }
}