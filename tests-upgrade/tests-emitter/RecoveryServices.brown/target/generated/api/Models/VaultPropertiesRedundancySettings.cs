// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>The redundancy Settings of a Vault</summary>
    public partial class VaultPropertiesRedundancySettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesRedundancySettingsInternal
    {

        /// <summary>Backing field for <see cref="CrossRegionRestore" /> property.</summary>
        private string _crossRegionRestore;

        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string CrossRegionRestore { get => this._crossRegionRestore; set => this._crossRegionRestore = value; }

        /// <summary>Backing field for <see cref="StandardTierStorageRedundancy" /> property.</summary>
        private string _standardTierStorageRedundancy;

        /// <summary>The storage redundancy setting of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string StandardTierStorageRedundancy { get => this._standardTierStorageRedundancy; set => this._standardTierStorageRedundancy = value; }

        /// <summary>Creates an new <see cref="VaultPropertiesRedundancySettings" /> instance.</summary>
        public VaultPropertiesRedundancySettings()
        {

        }
    }
    /// The redundancy Settings of a Vault
    public partial interface IVaultPropertiesRedundancySettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to show if Cross Region Restore is enabled on the Vault or not",
        SerializedName = @"crossRegionRestore",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string CrossRegionRestore { get; set; }
        /// <summary>The storage redundancy setting of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The storage redundancy setting of a vault",
        SerializedName = @"standardTierStorageRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "LocallyRedundant", "GeoRedundant", "ZoneRedundant")]
        string StandardTierStorageRedundancy { get; set; }

    }
    /// The redundancy Settings of a Vault
    internal partial interface IVaultPropertiesRedundancySettingsInternal

    {
        /// <summary>Flag to show if Cross Region Restore is enabled on the Vault or not</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string CrossRegionRestore { get; set; }
        /// <summary>The storage redundancy setting of a vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "LocallyRedundant", "GeoRedundant", "ZoneRedundant")]
        string StandardTierStorageRedundancy { get; set; }

    }
}