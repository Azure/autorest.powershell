// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Class containing security settings of vault</summary>
    public partial class SecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettings,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal
    {

        /// <summary>Backing field for <see cref="EncryptionSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings _encryptionSetting;

        /// <summary>Customer Managed Key details of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings EncryptionSetting { get => (this._encryptionSetting = this._encryptionSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.EncryptionSettings()); set => this._encryptionSetting = value; }

        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string EncryptionSettingInfrastructureEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).InfrastructureEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).InfrastructureEncryption = value ?? null; }

        /// <summary>Encryption state of the Backup Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string EncryptionSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).State = value ?? null; }

        /// <summary>Backing field for <see cref="ImmutabilitySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings _immutabilitySetting;

        /// <summary>Immutability Settings at vault level</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings ImmutabilitySetting { get => (this._immutabilitySetting = this._immutabilitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ImmutabilitySettings()); set => this._immutabilitySetting = value; }

        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ImmutabilitySettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettingsInternal)ImmutabilitySetting).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettingsInternal)ImmutabilitySetting).State = value ?? null; }

        /// <summary>
        /// The managed identity to be used which has access permissions to the Key Vault. Provide a value here in case identity types:
        /// 'UserAssigned' only.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KekIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KekIdentityId = value ?? null; }

        /// <summary>
        /// The identity type. 'SystemAssigned' and 'UserAssigned' are mutually exclusive. 'SystemAssigned' will use implicitly created
        /// managed identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KekIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KekIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KekIdentityType = value ?? null; }

        /// <summary>The key uri of the Customer Managed Key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string KeyVaultPropertyKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KeyVaultPropertyKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KeyVaultPropertyKeyUri = value ?? null; }

        /// <summary>Internal Acessors for EncryptionSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal.EncryptionSetting { get => (this._encryptionSetting = this._encryptionSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.EncryptionSettings()); set { {_encryptionSetting = value;} } }

        /// <summary>Internal Acessors for EncryptionSettingKekIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal.EncryptionSettingKekIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KekIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KekIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for EncryptionSettingKeyVaultProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal.EncryptionSettingKeyVaultProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KeyVaultProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettingsInternal)EncryptionSetting).KeyVaultProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal.ImmutabilitySetting { get => (this._immutabilitySetting = this._immutabilitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ImmutabilitySettings()); set { {_immutabilitySetting = value;} } }

        /// <summary>Internal Acessors for SoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISecuritySettingsInternal.SoftDeleteSetting { get => (this._softDeleteSetting = this._softDeleteSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SoftDeleteSettings()); set { {_softDeleteSetting = value;} } }

        /// <summary>Backing field for <see cref="SoftDeleteSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings _softDeleteSetting;

        /// <summary>Soft delete related settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings SoftDeleteSetting { get => (this._softDeleteSetting = this._softDeleteSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.SoftDeleteSettings()); set => this._softDeleteSetting = value; }

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public double? SoftDeleteSettingRetentionDurationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).RetentionDurationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).RetentionDurationInDay = value ?? default(double); }

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).State = value ?? null; }

        /// <summary>Creates an new <see cref="SecuritySettings" /> instance.</summary>
        public SecuritySettings()
        {

        }
    }
    /// Class containing security settings of vault
    public partial interface ISecuritySettings :
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
        string EncryptionSettingInfrastructureEncryption { get; set; }
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
        string EncryptionSettingState { get; set; }
        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Immutability state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
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
        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft delete retention duration",
        SerializedName = @"retentionDurationInDays",
        PossibleTypes = new [] { typeof(double) })]
        double? SoftDeleteSettingRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of soft delete",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Off", "On", "AlwaysOn")]
        string SoftDeleteSettingState { get; set; }

    }
    /// Class containing security settings of vault
    internal partial interface ISecuritySettingsInternal

    {
        /// <summary>Customer Managed Key details of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IEncryptionSettings EncryptionSetting { get; set; }
        /// <summary>Enabling/Disabling the Double Encryption state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionSettingInfrastructureEncryption { get; set; }
        /// <summary>The details of the managed identity used for CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKekIdentity EncryptionSettingKekIdentity { get; set; }
        /// <summary>The properties of the Key Vault which hosts CMK</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ICmkKeyVaultProperties EncryptionSettingKeyVaultProperty { get; set; }
        /// <summary>Encryption state of the Backup Vault.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Enabled", "Disabled", "Inconsistent")]
        string EncryptionSettingState { get; set; }
        /// <summary>Immutability Settings at vault level</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IImmutabilitySettings ImmutabilitySetting { get; set; }
        /// <summary>Immutability state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
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
        /// <summary>The key uri of the Customer Managed Key</summary>
        string KeyVaultPropertyKeyUri { get; set; }
        /// <summary>Soft delete related settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.ISoftDeleteSettings SoftDeleteSetting { get; set; }
        /// <summary>Soft delete retention duration</summary>
        double? SoftDeleteSettingRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("Off", "On", "AlwaysOn")]
        string SoftDeleteSettingState { get; set; }

    }
}