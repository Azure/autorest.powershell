namespace Microsoft.Rest.ClientRuntime
{
    public static partial class Events
    {
        public const string CmdletProcessRecordStart = nameof(CmdletProcessRecordStart);
        public const string CmdletException = nameof(CmdletException);
        public const string CmdletGetPipeline = nameof(CmdletGetPipeline);
        public const string CmdletBeforeAPICall = nameof(CmdletBeforeAPICall);
        public const string CmdletAfterAPICall =  nameof(CmdletAfterAPICall);

        public const string Verbose =  nameof(Verbose);
        public const string Debug =  nameof(Debug);
        public const string Information =  nameof(Information);
        public const string Error =  nameof(Error);
        public const string Warning =  nameof(Warning);
    }

}