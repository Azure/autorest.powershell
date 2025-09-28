// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Customer Managed Key details of the resource.</summary>
    public partial class VaultPropertiesEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal
    {

        /// <summary>Backing field for <see cref="InfrastructureEncryption" /> property.</summary>
        private string _infrastructureEncryption;

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string InfrastructureEncryption { get => this._infrastructureEncryption; set => this._infrastructureEncryption = value; }

        /// <summary>Backing field for <see cref="KekIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity _kekIdentity;

        /// <summary>The details of the identity used for CMK</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity KekIdentity { get => (this._kekIdentity = this._kekIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKekIdentity()); set => this._kekIdentity = value; }

        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public bool? KekIdentityUseSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentityInternal)KekIdentity).UseSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentityInternal)KekIdentity).UseSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KekIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentityInternal)KekIdentity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentityInternal)KekIdentity).UserAssignedIdentity = value ?? null; }

        /// <summary>Backing field for <see cref="KeyVaultProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties _keyVaultProperty;

        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKeyVaultProperties()); set => this._keyVaultProperty = value; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultPropertiesInternal)KeyVaultProperty).KeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultPropertiesInternal)KeyVaultProperty).KeyUri = value ?? null; }

        /// <summary>Internal Acessors for KekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal.KekIdentity { get => (this._kekIdentity = this._kekIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKekIdentity()); set { {_kekIdentity = value;} } }

        /// <summary>Internal Acessors for KeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultPropertiesEncryptionInternal.KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CmkKeyVaultProperties()); set { {_keyVaultProperty = value;} } }

        /// <summary>Creates an new <see cref="VaultPropertiesEncryption" /> instance.</summary>
        public VaultPropertiesEncryption()
        {

        }
    }
    /// Customer Managed Key details of the resource.
    public partial interface IVaultPropertiesEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enabling/Disabling the Double Encryption state",
        SerializedName = @"infrastructureEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string InfrastructureEncryption { get; set; }
        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field",
        SerializedName = @"useSystemAssignedIdentity",
        PossibleTypes = new [] { typeof(bool) })]
        bool? KekIdentityUseSystemAssignedIdentity { get; set; }
        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string KekIdentityUserAssignedIdentity { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key uri of the Customer Managed Key",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyUri { get; set; }

    }
    /// Customer Managed Key details of the resource.
    internal partial interface IVaultPropertiesEncryptionInternal

    {
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string InfrastructureEncryption { get; set; }
        /// <summary>The details of the identity used for CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKekIdentity KekIdentity { get; set; }
        /// <summary>
        /// Indicate that system assigned identity should be used. Mutually exclusive with 'userAssignedIdentity' field
        /// </summary>
        bool? KekIdentityUseSystemAssignedIdentity { get; set; }
        /// <summary>
        /// The user assigned identity to be used to grant permissions in case the type of identity used is UserAssigned
        /// </summary>
        string KekIdentityUserAssignedIdentity { get; set; }
        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICmkKeyVaultProperties KeyVaultProperty { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        string KeyVaultPropertyKeyUri { get; set; }

    }
}