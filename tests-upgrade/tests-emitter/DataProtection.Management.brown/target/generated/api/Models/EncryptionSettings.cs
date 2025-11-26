// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Customer Managed Key details of the resource.</summary>
    public partial class EncryptionSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal
    {

        /// <summary>Backing field for <see cref="InfrastructureEncryption" /> property.</summary>
        private string _infrastructureEncryption;

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string InfrastructureEncryption { get => this._infrastructureEncryption; set => this._infrastructureEncryption = value; }

        /// <summary>Backing field for <see cref="KekIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity _kekIdentity;

        /// <summary>The details of the managed identity used for CMK</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity KekIdentity { get => (this._kekIdentity = this._kekIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKekIdentity()); set => this._kekIdentity = value; }

        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentityInternal)KekIdentity).IdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentityInternal)KekIdentity).IdentityId = value ?? null; }

        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentityInternal)KekIdentity).IdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentityInternal)KekIdentity).IdentityType = value ?? null; }

        /// <summary>Backing field for <see cref="KeyVaultProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties _keyVaultProperty;

        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKeyVaultProperties()); set => this._keyVaultProperty = value; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultPropertiesInternal)KeyVaultProperty).KeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultPropertiesInternal)KeyVaultProperty).KeyUri = value ?? null; }

        /// <summary>Internal Acessors for KekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal.KekIdentity { get => (this._kekIdentity = this._kekIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKekIdentity()); set { {_kekIdentity = value;} } }

        /// <summary>Internal Acessors for KeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal.KeyVaultProperty { get => (this._keyVaultProperty = this._keyVaultProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.CmkKeyVaultProperties()); set { {_keyVaultProperty = value;} } }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Encryption state of the Backup Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="EncryptionSettings" /> instance.</summary>
        public EncryptionSettings()
        {

        }
    }
    /// Customer Managed Key details of the resource.
    public partial interface IEncryptionSettings :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enabling/Disabling the Double Encryption state",
        SerializedName = @"infrastructureEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string InfrastructureEncryption { get; set; }
        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types: 'UserAssigned' only.",
        SerializedName = @"identityId",
        PossibleTypes = new [] { typeof(string) })]
        string KekIdentityId { get; set; }
        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created managed identity.",
        SerializedName = @"identityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string KekIdentityType { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key uri of the Customer Managed Key",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>Encryption state of the Backup Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Encryption state of the Backup Vault.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled", "Inconsistent")]
        string State { get; set; }

    }
    /// Customer Managed Key details of the resource.
    internal partial interface IEncryptionSettingsInternal

    {
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string InfrastructureEncryption { get; set; }
        /// <summary>The details of the managed identity used for CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity KekIdentity { get; set; }
        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        string KekIdentityId { get; set; }
        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string KekIdentityType { get; set; }
        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties KeyVaultProperty { get; set; }
        /// <summary>The key uri of the Customer Managed Key</summary>
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>Encryption state of the Backup Vault.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled", "Inconsistent")]
        string State { get; set; }

    }
}