// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Security Settings of the vault</summary>
    public partial class SecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettings,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal
    {

        /// <summary>Backing field for <see cref="ImmutabilitySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings _immutabilitySetting;

        /// <summary>Immutability Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings ImmutabilitySetting { get => (this._immutabilitySetting = this._immutabilitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ImmutabilitySettings()); set => this._immutabilitySetting = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string ImmutabilitySettingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettingsInternal)ImmutabilitySetting).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettingsInternal)ImmutabilitySetting).State = value ?? null; }

        /// <summary>Internal Acessors for ImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal.ImmutabilitySetting { get => (this._immutabilitySetting = this._immutabilitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ImmutabilitySettings()); set { {_immutabilitySetting = value;} } }

        /// <summary>Internal Acessors for MultiUserAuthorization</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal.MultiUserAuthorization { get => this._multiUserAuthorization; set { {_multiUserAuthorization = value;} } }

        /// <summary>Internal Acessors for SoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal.SoftDeleteSetting { get => (this._softDeleteSetting = this._softDeleteSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SoftDeleteSettings()); set { {_softDeleteSetting = value;} } }

        /// <summary>Internal Acessors for SourceScanConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal.SourceScanConfiguration { get => (this._sourceScanConfiguration = this._sourceScanConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SourceScanConfiguration()); set { {_sourceScanConfiguration = value;} } }

        /// <summary>Internal Acessors for SourceScanConfigurationSourceScanIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISecuritySettingsInternal.SourceScanConfigurationSourceScanIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).SourceScanIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).SourceScanIdentity = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="MultiUserAuthorization" /> property.</summary>
        private string _multiUserAuthorization;

        /// <summary>MUA Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string MultiUserAuthorization { get => this._multiUserAuthorization; }

        /// <summary>Backing field for <see cref="SoftDeleteSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings _softDeleteSetting;

        /// <summary>Soft delete Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings SoftDeleteSetting { get => (this._softDeleteSetting = this._softDeleteSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SoftDeleteSettings()); set => this._softDeleteSetting = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingEnhancedSecurityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).EnhancedSecurityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).EnhancedSecurityState = value ?? null; }

        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).SoftDeleteRetentionPeriodInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).SoftDeleteRetentionPeriodInDay = value ?? default(int); }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SoftDeleteSettingSoftDeleteState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).SoftDeleteState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettingsInternal)SoftDeleteSetting).SoftDeleteState = value ?? null; }

        /// <summary>Backing field for <see cref="SourceScanConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration _sourceScanConfiguration;

        /// <summary>Source scan configuration of vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration SourceScanConfiguration { get => (this._sourceScanConfiguration = this._sourceScanConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SourceScanConfiguration()); set => this._sourceScanConfiguration = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanConfigurationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).State = value ?? null; }

        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityOperationIdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).SourceScanIdentityOperationIdentityType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).SourceScanIdentityOperationIdentityType = value ?? null; }

        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string SourceScanIdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).SourceScanIdentityUserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfigurationInternal)SourceScanConfiguration).SourceScanIdentityUserAssignedIdentity = value ?? null; }

        /// <summary>Creates an new <see cref="SecuritySettings" /> instance.</summary>
        public SecuritySettings()
        {

        }
    }
    /// Security Settings of the vault
    public partial interface ISecuritySettings :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
        /// <summary>MUA Settings of a vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"MUA Settings of a vault",
        SerializedName = @"multiUserAuthorization",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string MultiUserAuthorization { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"enhancedSecurityState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingEnhancedSecurityState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Soft delete retention period in days",
        SerializedName = @"softDeleteRetentionPeriodInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"softDeleteState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingSoftDeleteState { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string SourceScanConfigurationState { get; set; }
        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type that should be used for an operation.",
        SerializedName = @"operationIdentityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string SourceScanIdentityOperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity to be used for an operation if operationIdentityType is UserAssigned.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string SourceScanIdentityUserAssignedIdentity { get; set; }

    }
    /// Security Settings of the vault
    internal partial interface ISecuritySettingsInternal

    {
        /// <summary>Immutability Settings of a vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IImmutabilitySettings ImmutabilitySetting { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Disabled", "Unlocked", "Locked")]
        string ImmutabilitySettingState { get; set; }
        /// <summary>MUA Settings of a vault</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string MultiUserAuthorization { get; set; }
        /// <summary>Soft delete Settings of a vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISoftDeleteSettings SoftDeleteSetting { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingEnhancedSecurityState { get; set; }
        /// <summary>Soft delete retention period in days</summary>
        int? SoftDeleteSettingSoftDeleteRetentionPeriodInDay { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled", "AlwaysON")]
        string SoftDeleteSettingSoftDeleteState { get; set; }
        /// <summary>Source scan configuration of vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISourceScanConfiguration SourceScanConfiguration { get; set; }
        /// <summary>Identity details to be used for an operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity SourceScanConfigurationSourceScanIdentity { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("Invalid", "Enabled", "Disabled")]
        string SourceScanConfigurationState { get; set; }
        /// <summary>Identity type that should be used for an operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string SourceScanIdentityOperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        string SourceScanIdentityUserAssignedIdentity { get; set; }

    }
}