// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The type used for update operations of the Pool.</summary>
    public partial class PoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal
    {

        /// <summary>Defines pool buffer/stand-by agents.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfileResourcePrediction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfileResourcePrediction = value ?? null /* model class */; }

        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile AgentProfileResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfileResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfileResourcePredictionsProfile = value ?? null /* model class */; }

        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string DevCenterProjectResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).DevCenterProjectResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).DevCenterProjectResourceId = value ?? null; }

        /// <summary>Defines the type of fabric the agent will run on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).FabricProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).FabricProfile = value ?? null /* model class */; }

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

        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public int? MaximumConcurrency { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).MaximumConcurrency; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).MaximumConcurrency = value ?? default(int); }

        /// <summary>Internal Acessors for AgentProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal.AgentProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfile = value; }

        /// <summary>Internal Acessors for AgentProfileResourcePredictionsProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal.AgentProfileResourcePredictionsProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfileResourcePredictionsProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).AgentProfileResourcePredictionsProfile = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdateProperties()); set { {_property = value;} } }

        /// <summary>Defines the organization in which the pool will be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile OrganizationProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).OrganizationProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).OrganizationProfile = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.PoolUpdateProperties()); set => this._property = value; }

        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string ResourcePredictionProfileKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).ResourcePredictionProfileKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdatePropertiesInternal)Property).ResourcePredictionProfileKind = value ?? null; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="PoolUpdate" /> instance.</summary>
        public PoolUpdate()
        {

        }
    }
    /// The type used for update operations of the Pool.
    public partial interface IPoolUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
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
        /// <summary>Defines the type of fabric the agent will run on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the type of fabric the agent will run on.",
        SerializedName = @"fabricProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get; set; }
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
        /// <summary>Defines the organization in which the pool will be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the organization in which the pool will be used.",
        SerializedName = @"organizationProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IOrganizationProfile OrganizationProfile { get; set; }
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
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags Tag { get; set; }

    }
    /// The type used for update operations of the Pool.
    internal partial interface IPoolUpdateInternal

    {
        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfile AgentProfile { get; set; }
        /// <summary>Defines pool buffer/stand-by agents.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions AgentProfileResourcePrediction { get; set; }
        /// <summary>Defines how the pool buffer/stand-by agents is provided.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile AgentProfileResourcePredictionsProfile { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Defines the type of fabric the agent will run on.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IFabricProfile FabricProfile { get; set; }
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IPoolUpdateProperties Property { get; set; }
        /// <summary>The status of the current operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Manual", "Automatic")]
        string ResourcePredictionProfileKind { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ITags Tag { get; set; }

    }
}