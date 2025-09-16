// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Specifies set of certificates that should be installed onto the virtual machines.
    /// </summary>
    public partial class VaultSecretGroup :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroupInternal
    {

        /// <summary>Internal Acessors for SourceVault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroupInternal.SourceVault { get => (this._sourceVault = this._sourceVault ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource()); set { {_sourceVault = value;} } }

        /// <summary>Backing field for <see cref="SourceVault" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource _sourceVault;

        /// <summary>
        /// The relative URL of the Key Vault containing all of the certificates in VaultCertificates.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource SourceVault { get => (this._sourceVault = this._sourceVault ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource()); set => this._sourceVault = value; }

        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SourceVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResourceInternal)SourceVault).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResourceInternal)SourceVault).Id = value ?? null; }

        /// <summary>Backing field for <see cref="VaultCertificate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificate> _vaultCertificate;

        /// <summary>The list of key vault references in SourceVault which contain certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificate> VaultCertificate { get => this._vaultCertificate; set => this._vaultCertificate = value; }

        /// <summary>Creates an new <see cref="VaultSecretGroup" /> instance.</summary>
        public VaultSecretGroup()
        {

        }
    }
    /// Specifies set of certificates that should be installed onto the virtual machines.
    public partial interface IVaultSecretGroup :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVaultId { get; set; }
        /// <summary>The list of key vault references in SourceVault which contain certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of key vault references in SourceVault which contain certificates.",
        SerializedName = @"vaultCertificates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificate) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificate> VaultCertificate { get; set; }

    }
    /// Specifies set of certificates that should be installed onto the virtual machines.
    internal partial interface IVaultSecretGroupInternal

    {
        /// <summary>
        /// The relative URL of the Key Vault containing all of the certificates in VaultCertificates.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource SourceVault { get; set; }
        /// <summary>Azure resource identifier.</summary>
        string SourceVaultId { get; set; }
        /// <summary>The list of key vault references in SourceVault which contain certificates.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultCertificate> VaultCertificate { get; set; }

    }
}