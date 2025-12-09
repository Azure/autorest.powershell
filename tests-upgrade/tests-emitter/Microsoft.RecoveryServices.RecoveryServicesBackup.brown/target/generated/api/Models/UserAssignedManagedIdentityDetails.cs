// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>User assigned managed identity details</summary>
    public partial class UserAssignedManagedIdentityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal
    {

        /// <summary>Backing field for <see cref="IdentityArmId" /> property.</summary>
        private string _identityArmId;

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string IdentityArmId { get => this._identityArmId; set => this._identityArmId = value; }

        /// <summary>Backing field for <see cref="IdentityName" /> property.</summary>
        private string _identityName;

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string IdentityName { get => this._identityName; set => this._identityName = value; }

        /// <summary>Internal Acessors for UserAssignedIdentityProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetailsInternal.UserAssignedIdentityProperty { get => (this._userAssignedIdentityProperty = this._userAssignedIdentityProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedIdentityProperties()); set { {_userAssignedIdentityProperty = value;} } }

        /// <summary>Backing field for <see cref="UserAssignedIdentityProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties _userAssignedIdentityProperty;

        /// <summary>User assigned managed identity properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedIdentityProperty { get => (this._userAssignedIdentityProperty = this._userAssignedIdentityProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedIdentityProperties()); set => this._userAssignedIdentityProperty = value; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityPropertiesInternal)UserAssignedIdentityProperty).ClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityPropertiesInternal)UserAssignedIdentityProperty).ClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityPropertiesInternal)UserAssignedIdentityProperty).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityPropertiesInternal)UserAssignedIdentityProperty).PrincipalId = value ?? null; }

        /// <summary>Creates an new <see cref="UserAssignedManagedIdentityDetails" /> instance.</summary>
        public UserAssignedManagedIdentityDetails()
        {

        }
    }
    /// User assigned managed identity details
    public partial interface IUserAssignedManagedIdentityDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM id of the assigned identity.",
        SerializedName = @"identityArmId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the assigned identity.",
        SerializedName = @"identityName",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityName { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The client ID of the assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The principal ID of the assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyPrincipalId { get; set; }

    }
    /// User assigned managed identity details
    internal partial interface IUserAssignedManagedIdentityDetailsInternal

    {
        /// <summary>The ARM id of the assigned identity.</summary>
        string IdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        string IdentityName { get; set; }
        /// <summary>User assigned managed identity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedIdentityProperty { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyPrincipalId { get; set; }

    }
}