// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>AutonomousDbVersion resource definition</summary>
    public partial class AutonomousDbVersion :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersion,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ProxyResource();

        /// <summary>The Autonomous Database workload type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public string DbWorkload { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).DbWorkload; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).DbWorkload = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>True if this version of the Oracle Database software's default is free.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public bool? IsDefaultForFree { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsDefaultForFree; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsDefaultForFree = value ?? default(bool); }

        /// <summary>True if this version of the Oracle Database software's default is paid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public bool? IsDefaultForPaid { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsDefaultForPaid; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsDefaultForPaid = value ?? default(bool); }

        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public bool? IsFreeTierEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsFreeTierEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsFreeTierEnabled = value ?? default(bool); }

        /// <summary>True if this version of the Oracle Database software has payments enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public bool? IsPaidEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsPaidEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).IsPaidEnabled = value ?? default(bool); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionProperties Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.AutonomousDbVersionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.AutonomousDbVersionProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Supported Autonomous Db versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="AutonomousDbVersion" /> instance.</summary>
        public AutonomousDbVersion()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// AutonomousDbVersion resource definition
    public partial interface IAutonomousDbVersion :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IProxyResource
    {
        /// <summary>The Autonomous Database workload type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Autonomous Database workload type",
        SerializedName = @"dbWorkload",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("OLTP", "DW", "AJD", "APEX")]
        string DbWorkload { get; set; }
        /// <summary>True if this version of the Oracle Database software's default is free.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"True if this version of the Oracle Database software's default is free.",
        SerializedName = @"isDefaultForFree",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultForFree { get; set; }
        /// <summary>True if this version of the Oracle Database software's default is paid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"True if this version of the Oracle Database software's default is paid.",
        SerializedName = @"isDefaultForPaid",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultForPaid { get; set; }
        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.",
        SerializedName = @"isFreeTierEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsFreeTierEnabled { get; set; }
        /// <summary>True if this version of the Oracle Database software has payments enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"True if this version of the Oracle Database software has payments enabled.",
        SerializedName = @"isPaidEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPaidEnabled { get; set; }
        /// <summary>Supported Autonomous Db versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supported Autonomous Db versions.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// AutonomousDbVersion resource definition
    internal partial interface IAutonomousDbVersionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IProxyResourceInternal
    {
        /// <summary>The Autonomous Database workload type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("OLTP", "DW", "AJD", "APEX")]
        string DbWorkload { get; set; }
        /// <summary>True if this version of the Oracle Database software's default is free.</summary>
        bool? IsDefaultForFree { get; set; }
        /// <summary>True if this version of the Oracle Database software's default is paid.</summary>
        bool? IsDefaultForPaid { get; set; }
        /// <summary>
        /// True if this version of the Oracle Database software can be used for Always-Free Autonomous Databases.
        /// </summary>
        bool? IsFreeTierEnabled { get; set; }
        /// <summary>True if this version of the Oracle Database software has payments enabled.</summary>
        bool? IsPaidEnabled { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IAutonomousDbVersionProperties Property { get; set; }
        /// <summary>Supported Autonomous Db versions.</summary>
        string Version { get; set; }

    }
}