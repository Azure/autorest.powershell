// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    /// </summary>
    public partial class FleetMember :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMember,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ProxyResource();

        /// <summary>
        /// The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ClusterResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).ClusterResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).ClusterResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; }

        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Group { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).Group; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).Group = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels Label { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).Label; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).Label = value ?? null /* model class */; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorAdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorCode; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorDetail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorMessage; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorTarget; }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.ETag { get => this._eTag; set { {_eTag = value;} } }

        /// <summary>Internal Acessors for LastOperationErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorAdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorAdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorCode = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorMessage = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).LastOperationErrorTarget = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).Status = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.StatusLastOperationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).StatusLastOperationError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).StatusLastOperationError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberInternal.StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).StatusLastOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).StatusLastOperationId = value ?? null; }

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

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberProperties()); set => this._property = value; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The last operation ID for the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal)Property).StatusLastOperationId; }

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
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="FleetMember" /> instance.</summary>
        public FleetMember()
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
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    public partial interface IFleetMember :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResource
    {
        /// <summary>
        /// The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.",
        SerializedName = @"clusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterResourceId { get; set; }
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
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The group this member belongs to for multi-cluster update management.",
        SerializedName = @"group",
        PossibleTypes = new [] { typeof(string) })]
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The labels for the fleet member.",
        SerializedName = @"labels",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels Label { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get;  }
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
        string LastOperationErrorCode { get;  }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get;  }
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
        string LastOperationErrorMessage { get;  }
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
        string LastOperationErrorTarget { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Joining", "Leaving", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>The last operation ID for the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The last operation ID for the fleet member",
        SerializedName = @"lastOperationId",
        PossibleTypes = new [] { typeof(string) })]
        string StatusLastOperationId { get;  }

    }
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    internal partial interface IFleetMemberInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IProxyResourceInternal
    {
        /// <summary>
        /// The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.
        /// </summary>
        string ClusterResourceId { get; set; }
        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        string ETag { get; set; }
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels Label { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string LastOperationErrorCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get; set; }
        /// <summary>The error message.</summary>
        string LastOperationErrorMessage { get; set; }
        /// <summary>The error target.</summary>
        string LastOperationErrorTarget { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberProperties Property { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Joining", "Leaving", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Status information of the last operation for fleet member.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus Status { get; set; }
        /// <summary>The last operation error of the fleet member</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusLastOperationError { get; set; }
        /// <summary>The last operation ID for the fleet member</summary>
        string StatusLastOperationId { get; set; }

    }
}