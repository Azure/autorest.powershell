// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Vault model.</summary>
    public partial class VaultIdentityModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVaultIdentityModel,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVaultIdentityModelInternal
    {

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVaultIdentityModelInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVaultIdentityModelInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>
        /// Gets or sets the object ID of the service principal object for the managed identity that is used to grant role-based access
        /// to an Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// Gets or sets a Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Gets or sets the identityType which can be either SystemAssigned or None.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="VaultIdentityModel" /> instance.</summary>
        public VaultIdentityModel()
        {

        }
    }
    /// Vault model.
    public partial interface IVaultIdentityModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the object ID of the service principal object for the managed identity that is used to grant role-based access
        /// to an Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the object ID of the service principal object for the managed identity that is used to grant role-based access to an Azure resource.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }
        /// <summary>
        /// Gets or sets a Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets a Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }
        /// <summary>Gets or sets the identityType which can be either SystemAssigned or None.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the identityType which can be either SystemAssigned or None.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned")]
        string Type { get; set; }

    }
    /// Vault model.
    internal partial interface IVaultIdentityModelInternal

    {
        /// <summary>
        /// Gets or sets the object ID of the service principal object for the managed identity that is used to grant role-based access
        /// to an Azure resource.
        /// </summary>
        string PrincipalId { get; set; }
        /// <summary>
        /// Gets or sets a Globally Unique Identifier (GUID) that represents the Azure AD tenant where the resource is now a member.
        /// </summary>
        string TenantId { get; set; }
        /// <summary>Gets or sets the identityType which can be either SystemAssigned or None.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned")]
        string Type { get; set; }

    }
}