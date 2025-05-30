// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    public partial class Pool :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPool,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.TrackedResource();

        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile AgentProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfile = value ?? null /* model class */; }

        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string AgentProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileKind = value ?? null; }

        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileResourcePrediction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileResourcePrediction = value ?? null /* model class */; }

        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile AgentProfileResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string DevCenterProjectResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).DevCenterProjectResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).DevCenterProjectResourceId = value ?? null; }

        /// <summary>Defines the type of fabric the agent will run on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).FabricProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).FabricProfile = value ?? null /* model class */; }

        /// <summary>Discriminator property for FabricProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string FabricProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).FabricProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).FabricProfileKind = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>The type of managed identity assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public int? MaximumConcurrency { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).MaximumConcurrency; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).MaximumConcurrency = value ?? default(int); }

        /// <summary>Internal Acessors for AgentProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.AgentProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AgentProfileResourcePredictionsProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.AgentProfileResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).AgentProfileResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FabricProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.FabricProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).FabricProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).FabricProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for OrganizationProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.OrganizationProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).OrganizationProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).OrganizationProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Defines the organization in which the pool will be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile OrganizationProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).OrganizationProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).OrganizationProfile = value ?? null /* model class */; }

        /// <summary>Discriminator property for OrganizationProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string OrganizationProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).OrganizationProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).OrganizationProfileKind = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolProperties()); set => this._property = value; }

        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ResourcePredictionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).ResourcePredictionProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolPropertiesInternal)Property).ResourcePredictionProfileKind = value ?? null; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceInternal)__trackedResource).Type; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Creates an new <see cref="Pool" /> instance.</summary>
        public Pool()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    public partial interface IPool :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResource
    {
        /// <summary>Discriminator property for AgentProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for AgentProfile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string AgentProfileKind { get; set; }
        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines pool buffer/stand-by agents.",
        SerializedName = @"resourcePredictions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the DevCenter Project the pool belongs to.",
        SerializedName = @"devCenterProjectResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Discriminator property for FabricProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for FabricProfile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string FabricProfileKind { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of managed identity assigned to this resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identities assigned to this resource by the user.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines how many resources can there be created at any given time.",
        SerializedName = @"maximumConcurrency",
        PossibleTypes = new [] { typeof(int) })]
        int? MaximumConcurrency { get; set; }
        /// <summary>Discriminator property for OrganizationProfile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for OrganizationProfile.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationProfileKind { get; set; }
        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of the current operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines how the stand-by scheme should be provided.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Manual", "Automatic")]
        string ResourcePredictionProfileKind { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    internal partial interface IPoolInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITrackedResourceInternal
    {
        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile AgentProfile { get; set; }
        /// <summary>Discriminator property for AgentProfile.</summary>
        string AgentProfileKind { get; set; }
        /// <summary>Defines pool buffer/stand-by agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get; set; }
        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile AgentProfileResourcePredictionsProfile { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Defines the type of fabric the agent will run on.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get; set; }
        /// <summary>Discriminator property for FabricProfile.</summary>
        string FabricProfileKind { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>The type of managed identity assigned to this resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>The identities assigned to this resource by the user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Defines how many resources can there be created at any given time.</summary>
        int? MaximumConcurrency { get; set; }
        /// <summary>Defines the organization in which the pool will be used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile OrganizationProfile { get; set; }
        /// <summary>Discriminator property for OrganizationProfile.</summary>
        string OrganizationProfileKind { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolProperties Property { get; set; }
        /// <summary>The status of the current operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Manual", "Automatic")]
        string ResourcePredictionProfileKind { get; set; }

        int? RetryAfter { get; set; }

    }
}