// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The AutoUpgradeProfile resource.</summary>
    public partial class AutoUpgradeProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ProxyResource();

        /// <summary>Configures how auto-upgrade will be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Channel { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).Channel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).Channel = value ?? null; }

        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? Disabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).Disabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).Disabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorAdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorCode; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorDetail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorMessage; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorTarget; }

        /// <summary>
        /// If upgrade channel is not TargetKubernetesVersion, this field must be False.
        /// If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
        /// (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
        /// By default, this is set to False.
        /// For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? LongTermSupport { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LongTermSupport; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LongTermSupport = value ?? default(bool); }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.ETag { get => this._eTag; set { {_eTag = value;} } }

        /// <summary>Internal Acessors for LastTriggerErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.LastTriggerErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorAdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorAdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.LastTriggerErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorCode = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.LastTriggerErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.LastTriggerErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorMessage = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.LastTriggerErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).LastTriggerErrorTarget = value ?? null; }

        /// <summary>Internal Acessors for NodeImageSelection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.NodeImageSelection { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).NodeImageSelection; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).NodeImageSelection = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatus = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastTriggerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.StatusLastTriggerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastTriggerStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.StatusLastTriggerStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerStatus = value ?? null; }

        /// <summary>Internal Acessors for StatusLastTriggerUpgradeVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.StatusLastTriggerUpgradeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerUpgradeVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerUpgradeVersion = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusLastTriggeredAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileInternal.StatusLastTriggeredAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggeredAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggeredAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string NodeImageSelectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).NodeImageSelectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).NodeImageSelectionType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the AutoUpgradeProfile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusLastTriggerStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerStatus; }

        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> StatusLastTriggerUpgradeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggerUpgradeVersion; }

        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusLastTriggeredAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).AutoUpgradeProfileStatusLastTriggeredAt; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example,
        /// "1.30".
        /// By default, this is empty.
        /// If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
        /// If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string TargetKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).TargetKubernetesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).TargetKubernetesVersion = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>
        /// The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters
        /// which are members of the fleet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateStrategyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).UpdateStrategyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)Property).UpdateStrategyId = value ?? null; }

        /// <summary>Creates an new <see cref="AutoUpgradeProfile" /> instance.</summary>
        public AutoUpgradeProfile()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// The AutoUpgradeProfile resource.
    public partial interface IAutoUpgradeProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResource
    {
        /// <summary>Configures how auto-upgrade will be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Configures how auto-upgrade will be run.",
        SerializedName = @"channel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Stable", "Rapid", "NodeImage", "TargetKubernetesVersion")]
        string Channel { get; set; }
        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        By default, this is set to False.",
        SerializedName = @"disabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Disabled { get; set; }
        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.  Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get;  }
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string LastTriggerErrorCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string LastTriggerErrorMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string LastTriggerErrorTarget { get;  }
        /// <summary>
        /// If upgrade channel is not TargetKubernetesVersion, this field must be False.
        /// If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
        /// (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
        /// By default, this is set to False.
        /// For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"  If upgrade channel is not TargetKubernetesVersion, this field must be False.
          If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
          (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
          By default, this is set to False.
          For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support",
        SerializedName = @"longTermSupport",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LongTermSupport { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The node image upgrade type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The provisioning state of the AutoUpgradeProfile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the AutoUpgradeProfile resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last AutoUpgrade trigger.",
        SerializedName = @"lastTriggerStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string StatusLastTriggerStatus { get;  }
        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The target Kubernetes version or node image versions of the last trigger.",
        SerializedName = @"lastTriggerUpgradeVersions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> StatusLastTriggerUpgradeVersion { get;  }
        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.",
        SerializedName = @"lastTriggeredAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusLastTriggeredAt { get;  }
        /// <summary>
        /// This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example,
        /// "1.30".
        /// By default, this is empty.
        /// If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
        /// If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"  This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example, ""1.30"".
          By default, this is empty.
          If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
          If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.",
        SerializedName = @"targetKubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TargetKubernetesVersion { get; set; }
        /// <summary>
        /// The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters
        /// which are members of the fleet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters which are members of the fleet.",
        SerializedName = @"updateStrategyId",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateStrategyId { get; set; }

    }
    /// The AutoUpgradeProfile resource.
    internal partial interface IAutoUpgradeProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResourceInternal
    {
        /// <summary>Configures how auto-upgrade will be run.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Stable", "Rapid", "NodeImage", "TargetKubernetesVersion")]
        string Channel { get; set; }
        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        bool? Disabled { get; set; }
        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        string ETag { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string LastTriggerErrorCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get; set; }
        /// <summary>The error message.</summary>
        string LastTriggerErrorMessage { get; set; }
        /// <summary>The error target.</summary>
        string LastTriggerErrorTarget { get; set; }
        /// <summary>
        /// If upgrade channel is not TargetKubernetesVersion, this field must be False.
        /// If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
        /// (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
        /// By default, this is set to False.
        /// For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support
        /// </summary>
        bool? LongTermSupport { get; set; }
        /// <summary>The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection NodeImageSelection { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties Property { get; set; }
        /// <summary>The provisioning state of the AutoUpgradeProfile resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>The status of the auto upgrade profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus Status { get; set; }
        /// <summary>The error details of the last trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusLastTriggerError { get; set; }
        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string StatusLastTriggerStatus { get; set; }
        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        System.Collections.Generic.List<string> StatusLastTriggerUpgradeVersion { get; set; }
        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        global::System.DateTime? StatusLastTriggeredAt { get; set; }
        /// <summary>
        /// This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example,
        /// "1.30".
        /// By default, this is empty.
        /// If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
        /// If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.
        /// </summary>
        string TargetKubernetesVersion { get; set; }
        /// <summary>
        /// The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters
        /// which are members of the fleet.
        /// </summary>
        string UpdateStrategyId { get; set; }

    }
}