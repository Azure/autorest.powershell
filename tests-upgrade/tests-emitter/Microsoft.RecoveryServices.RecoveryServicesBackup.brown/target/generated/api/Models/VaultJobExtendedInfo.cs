// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Vault Job for CMK - has CMK specific info.</summary>
    public partial class VaultJobExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoInternal
    {

        /// <summary>Backing field for <see cref="PropertyBag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag _propertyBag;

        /// <summary>Job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag PropertyBag { get => (this._propertyBag = this._propertyBag ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.VaultJobExtendedInfoPropertyBag()); set => this._propertyBag = value; }

        /// <summary>Creates an new <see cref="VaultJobExtendedInfo" /> instance.</summary>
        public VaultJobExtendedInfo()
        {

        }
    }
    /// Vault Job for CMK - has CMK specific info.
    public partial interface IVaultJobExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Job properties.",
        SerializedName = @"propertyBag",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag PropertyBag { get; set; }

    }
    /// Vault Job for CMK - has CMK specific info.
    internal partial interface IVaultJobExtendedInfoInternal

    {
        /// <summary>Job properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag PropertyBag { get; set; }

    }
}