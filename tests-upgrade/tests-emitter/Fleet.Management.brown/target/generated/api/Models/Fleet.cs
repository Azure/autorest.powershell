// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The Fleet resource.</summary>
    public partial class Fleet :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleet,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.TrackedResource();

        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AgentProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).AgentProfileSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).AgentProfileSubnetId = value ?? null; }

        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AgentProfileVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).AgentProfileVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).AgentProfileVMSize = value ?? null; }

        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? ApiServerAccessProfileEnablePrivateCluster { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ApiServerAccessProfileEnablePrivateCluster; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ApiServerAccessProfileEnablePrivateCluster = value ?? default(bool); }

        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public bool? ApiServerAccessProfileEnableVnetIntegration { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ApiServerAccessProfileEnableVnetIntegration; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ApiServerAccessProfileEnableVnetIntegration = value ?? default(bool); }

        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ApiServerAccessProfileSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ApiServerAccessProfileSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ApiServerAccessProfileSubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; }

        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfileDnsPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileDnsPrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileDnsPrefix = value ?? null; }

        /// <summary>The FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfileFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileFqdn; }

        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfileKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileKubernetesVersion; }

        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string HubProfilePortalFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfilePortalFqdn; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentity _identity;

        /// <summary>Managed identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorAdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorCode; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorDetail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorMessage; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorTarget; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for ETag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.ETag { get => this._eTag; set { {_eTag = value;} } }

        /// <summary>Internal Acessors for HubProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.HubProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HubProfileAgentProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.HubProfileAgentProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileAgentProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileAgentProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HubProfileApiServerAccessProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.HubProfileApiServerAccessProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileApiServerAccessProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileApiServerAccessProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HubProfileFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.HubProfileFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileFqdn = value ?? null; }

        /// <summary>Internal Acessors for HubProfileKubernetesVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.HubProfileKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileKubernetesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfileKubernetesVersion = value ?? null; }

        /// <summary>Internal Acessors for HubProfilePortalFqdn</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.HubProfilePortalFqdn { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfilePortalFqdn; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).HubProfilePortalFqdn = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorAdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorAdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorCode = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorMessage = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).LastOperationErrorTarget = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).Status = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.StatusLastOperationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).StatusLastOperationError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).StatusLastOperationError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetInternal.StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).StatusLastOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).StatusLastOperationId = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetProperties()); set => this._property = value; }

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The last operation ID for the fleet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetPropertiesInternal)Property).StatusLastOperationId; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Fleet" /> instance.</summary>
        public Fleet()
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
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// The Fleet resource.
    public partial interface IFleet :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResource
    {
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be generated and used.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string AgentProfileSubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The virtual machine size of the Fleet hub.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string AgentProfileVMSize { get; set; }
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to create the Fleet hub as a private cluster or not.",
        SerializedName = @"enablePrivateCluster",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApiServerAccessProfileEnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to enable apiserver vnet integration for the Fleet hub or not.",
        SerializedName = @"enableVnetIntegration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApiServerAccessProfileEnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string ApiServerAccessProfileSubnetId { get; set; }
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
        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"DNS prefix used to create the FQDN for the Fleet hub.",
        SerializedName = @"dnsPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string HubProfileDnsPrefix { get; set; }
        /// <summary>The FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The FQDN of the Fleet hub.",
        SerializedName = @"fqdn",
        PossibleTypes = new [] { typeof(string) })]
        string HubProfileFqdn { get;  }
        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Kubernetes version of the Fleet hub.",
        SerializedName = @"kubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string HubProfileKubernetesVersion { get;  }
        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Azure Portal FQDN of the Fleet hub.",
        SerializedName = @"portalFqdn",
        PossibleTypes = new [] { typeof(string) })]
        string HubProfilePortalFqdn { get;  }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Updating", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>The last operation ID for the fleet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The last operation ID for the fleet.",
        SerializedName = @"lastOperationId",
        PossibleTypes = new [] { typeof(string) })]
        string StatusLastOperationId { get;  }

    }
    /// The Fleet resource.
    internal partial interface IFleetInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ITrackedResourceInternal
    {
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        string AgentProfileSubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        string AgentProfileVMSize { get; set; }
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        bool? ApiServerAccessProfileEnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        bool? ApiServerAccessProfileEnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        string ApiServerAccessProfileSubnetId { get; set; }
        /// <summary>
        /// If eTag is provided in the response body, it may also be provided as a header per the normal etag convention. Entity tags
        /// are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in the etag (section
        /// 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header fields.
        /// </summary>
        string ETag { get; set; }
        /// <summary>The FleetHubProfile configures the Fleet's hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetHubProfile HubProfile { get; set; }
        /// <summary>The agent profile for the Fleet hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile HubProfileAgentProfile { get; set; }
        /// <summary>The access profile for the Fleet hub API server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile HubProfileApiServerAccessProfile { get; set; }
        /// <summary>DNS prefix used to create the FQDN for the Fleet hub.</summary>
        string HubProfileDnsPrefix { get; set; }
        /// <summary>The FQDN of the Fleet hub.</summary>
        string HubProfileFqdn { get; set; }
        /// <summary>The Kubernetes version of the Fleet hub.</summary>
        string HubProfileKubernetesVersion { get; set; }
        /// <summary>The Azure Portal FQDN of the Fleet hub.</summary>
        string HubProfilePortalFqdn { get; set; }
        /// <summary>Managed identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned, UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedServiceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetProperties Property { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Creating", "Updating", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Status information for the fleet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetStatus Status { get; set; }
        /// <summary>The last operation error for the fleet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusLastOperationError { get; set; }
        /// <summary>The last operation ID for the fleet.</summary>
        string StatusLastOperationId { get; set; }

    }
}