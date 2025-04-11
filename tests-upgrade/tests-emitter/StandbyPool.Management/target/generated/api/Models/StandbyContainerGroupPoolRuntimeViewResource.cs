// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Contains information about a standby container group pool as last known by the StandbyPool resource provider.
    /// </summary>
    public partial class StandbyContainerGroupPoolRuntimeViewResource :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResource,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ProxyResource();

        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).ForecastValueInstancesRequestedCount; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>
        /// A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> InstanceCountSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).InstanceCountSummary; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>Internal Acessors for ForecastValueInstancesRequestedCount</summary>
        System.Collections.Generic.List<long> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.ForecastValueInstancesRequestedCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).ForecastValueInstancesRequestedCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).ForecastValueInstancesRequestedCount = value; }

        /// <summary>Internal Acessors for InstanceCountSummary</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.InstanceCountSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).InstanceCountSummary; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).InstanceCountSummary = value; }

        /// <summary>Internal Acessors for Prediction</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolPrediction Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.Prediction { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).Prediction; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).Prediction = value; }

        /// <summary>Internal Acessors for PredictionForecastInfo</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.PredictionForecastInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastInfo = value; }

        /// <summary>Internal Acessors for PredictionForecastStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.PredictionForecastStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastStartTime = value; }

        /// <summary>Internal Acessors for PredictionForecastValue</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolForecastValues Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.PredictionForecastValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastValue = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceProperties Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolRuntimeViewResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for StatusCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.StatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).StatusCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).StatusCode = value; }

        /// <summary>Internal Acessors for StatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceInternal.StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).StatusMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).StatusMessage = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string PredictionForecastInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastInfo; }

        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public global::System.DateTime? PredictionForecastStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).PredictionForecastStartTime; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolRuntimeViewResourceProperties()); set => this._property = value; }

        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string StatusCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).StatusCode; }

        /// <summary>Displays the StandbyPool health state details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string StatusMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourcePropertiesInternal)Property).StatusMessage; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>
        /// Creates an new <see cref="StandbyContainerGroupPoolRuntimeViewResource" /> instance.
        /// </summary>
        public StandbyContainerGroupPoolRuntimeViewResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Contains information about a standby container group pool as last known by the StandbyPool resource provider.
    public partial interface IStandbyContainerGroupPoolRuntimeViewResource :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResource
    {
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the predicted count of instances to be requested from the standby pool.",
        SerializedName = @"instancesRequestedCount",
        PossibleTypes = new [] { typeof(long) })]
        System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get;  }
        /// <summary>
        /// A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.",
        SerializedName = @"instanceCountSummary",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> InstanceCountSummary { get;  }
        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays additional information for the prediction of the standby pool.",
        SerializedName = @"forecastInfo",
        PossibleTypes = new [] { typeof(string) })]
        string PredictionForecastInfo { get;  }
        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the UTC timestamp of when the prediction was retrieved for the standby pool.",
        SerializedName = @"forecastStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PredictionForecastStartTime { get;  }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the provisioning state of the standby pool",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the healthy state of the StandbyPool.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("HealthState/healthy", "HealthState/degraded")]
        string StatusCode { get;  }
        /// <summary>Displays the StandbyPool health state details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the StandbyPool health state details.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string StatusMessage { get;  }

    }
    /// Contains information about a standby container group pool as last known by the StandbyPool resource provider.
    internal partial interface IStandbyContainerGroupPoolRuntimeViewResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResourceInternal
    {
        /// <summary>
        /// Displays the predicted count of instances to be requested from the standby pool.
        /// </summary>
        System.Collections.Generic.List<long> ForecastValueInstancesRequestedCount { get; set; }
        /// <summary>
        /// A list containing the counts of container groups in each possible state, as known by the StandbyPool resource provider.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupInstanceCountSummary> InstanceCountSummary { get; set; }
        /// <summary>Displays prediction information of the standby pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolPrediction Prediction { get; set; }
        /// <summary>Displays additional information for the prediction of the standby pool.</summary>
        string PredictionForecastInfo { get; set; }
        /// <summary>
        /// Displays the UTC timestamp of when the prediction was retrieved for the standby pool.
        /// </summary>
        global::System.DateTime? PredictionForecastStartTime { get; set; }
        /// <summary>Displays the forecast information of the standby pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolForecastValues PredictionForecastValue { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolRuntimeViewResourceProperties Property { get; set; }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Display status of the standby pool</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus Status { get; set; }
        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("HealthState/healthy", "HealthState/degraded")]
        string StatusCode { get; set; }
        /// <summary>Displays the StandbyPool health state details.</summary>
        string StatusMessage { get; set; }

    }
}