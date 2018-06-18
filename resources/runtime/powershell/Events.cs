namespace Microsoft.Rest.ClientRuntime
{
    public static partial class Events
    {
        public const string CmdletProcessRecordStart = nameof(CmdletProcessRecordStart);
        public const string CmdletException = nameof(CmdletException);
        public const string CmdletGetPipeline = nameof(CmdletGetPipeline);
        public const string CmdletBeforeAPICall = nameof(CmdletBeforeAPICall);
        public const string CmdletAfterAPICall =  nameof(CmdletAfterAPICall);
    }

}