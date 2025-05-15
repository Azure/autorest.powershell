// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The data type resource.</summary>
    public partial class DataType :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataType,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ProxyResource();

        /// <summary>Field for database cache retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public int? DatabaseCacheRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).DatabaseCacheRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).DatabaseCacheRetention = value ?? default(int); }

        /// <summary>Field for database data retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public int? DatabaseRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).DatabaseRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).DatabaseRetention = value ?? default(int); }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataTypeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for StateReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeInternal.StateReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).StateReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).StateReason = value ?? null; }

        /// <summary>Internal Acessors for VisualizationUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeInternal.VisualizationUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).VisualizationUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).VisualizationUrl = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataTypeProperties()); set => this._property = value; }

        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>State of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).State = value ?? null; }

        /// <summary>Reason for the state of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string StateReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).StateReason; }

        /// <summary>Field for storage output retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public int? StorageOutputRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).StorageOutputRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).StorageOutputRetention = value ?? default(int); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Url for data visualization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string VisualizationUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal)Property).VisualizationUrl; }

        /// <summary>Creates an new <see cref="DataType" /> instance.</summary>
        public DataType()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// The data type resource.
    public partial interface IDataType :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IProxyResource
    {
        /// <summary>Field for database cache retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field for database cache retention in days.",
        SerializedName = @"databaseCacheRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseCacheRetention { get; set; }
        /// <summary>Field for database data retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field for database data retention in days.",
        SerializedName = @"databaseRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseRetention { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Latest provisioning state  of data product.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
        /// <summary>State of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of data type.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Stopped", "Running")]
        string State { get; set; }
        /// <summary>Reason for the state of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Reason for the state of data type.",
        SerializedName = @"stateReason",
        PossibleTypes = new [] { typeof(string) })]
        string StateReason { get;  }
        /// <summary>Field for storage output retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field for storage output retention in days.",
        SerializedName = @"storageOutputRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageOutputRetention { get; set; }
        /// <summary>Url for data visualization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url for data visualization.",
        SerializedName = @"visualizationUrl",
        PossibleTypes = new [] { typeof(string) })]
        string VisualizationUrl { get;  }

    }
    /// The data type resource.
    internal partial interface IDataTypeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IProxyResourceInternal
    {
        /// <summary>Field for database cache retention in days.</summary>
        int? DatabaseCacheRetention { get; set; }
        /// <summary>Field for database data retention in days.</summary>
        int? DatabaseRetention { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeProperties Property { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>State of data type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Stopped", "Running")]
        string State { get; set; }
        /// <summary>Reason for the state of data type.</summary>
        string StateReason { get; set; }
        /// <summary>Field for storage output retention in days.</summary>
        int? StorageOutputRetention { get; set; }
        /// <summary>Url for data visualization.</summary>
        string VisualizationUrl { get; set; }

    }
}