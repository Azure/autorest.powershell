namespace Microsoft.Rest.ClientRuntime
{
    using System;

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Class)]
    public class InfoAttribute : Attribute
    {
        public bool Required { get; set; } = false;
        public bool ReadOnly { get; set; } = false;
        public Type[] PossibleTypes { get; set; } = new Type[0];
        public string Description { get; set; } = "";
        public string SerializedName { get; set; } = "";
    }
}