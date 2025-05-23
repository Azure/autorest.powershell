// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes the properties of a Virtual Machine Scale Set Extension.</summary>
    public partial class VirtualMachineScaleSetExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeMinorVersion" /> property.</summary>
        private bool? _autoUpgradeMinorVersion;

        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is
        /// available at deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? AutoUpgradeMinorVersion { get => this._autoUpgradeMinorVersion; set => this._autoUpgradeMinorVersion = value; }

        /// <summary>Backing field for <see cref="EnableAutomaticUpgrade" /> property.</summary>
        private bool? _enableAutomaticUpgrade;

        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the
        /// platform if there is a newer version of the extension available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableAutomaticUpgrade { get => this._enableAutomaticUpgrade; set => this._enableAutomaticUpgrade = value; }

        /// <summary>Backing field for <see cref="ForceUpdateTag" /> property.</summary>
        private string _forceUpdateTag;

        /// <summary>
        /// If a value is provided and is different from the previous value, the extension
        /// handler will be forced to update even if the extension configuration has not
        /// changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ForceUpdateTag { get => this._forceUpdateTag; set => this._forceUpdateTag = value; }

        /// <summary>Internal Acessors for ProtectedSettingFromKeyVaultSourceVault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionPropertiesInternal.ProtectedSettingFromKeyVaultSourceVault { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal)ProtectedSettingsFromKeyVault).SourceVault; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal)ProtectedSettingsFromKeyVault).SourceVault = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProtectedSettingsFromKeyVault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReference Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionPropertiesInternal.ProtectedSettingsFromKeyVault { get => (this._protectedSettingsFromKeyVault = this._protectedSettingsFromKeyVault ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.KeyVaultSecretReference()); set { {_protectedSettingsFromKeyVault = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetExtensionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProtectedSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings _protectedSetting;

        /// <summary>
        /// The extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings ProtectedSetting { get => (this._protectedSetting = this._protectedSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Settings()); set => this._protectedSetting = value; }

        /// <summary>The URL referencing a secret in a Key Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ProtectedSettingFromKeyVaultSecretUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal)ProtectedSettingsFromKeyVault).SecretUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal)ProtectedSettingsFromKeyVault).SecretUrl = value ?? null; }

        /// <summary>Backing field for <see cref="ProtectedSettingsFromKeyVault" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReference _protectedSettingsFromKeyVault;

        /// <summary>
        /// The extensions protected settings that are passed by reference, and consumed
        /// from key vault
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReference ProtectedSettingsFromKeyVault { get => (this._protectedSettingsFromKeyVault = this._protectedSettingsFromKeyVault ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.KeyVaultSecretReference()); set => this._protectedSettingsFromKeyVault = value; }

        /// <summary>Backing field for <see cref="ProvisionAfterExtension" /> property.</summary>
        private System.Collections.Generic.List<string> _provisionAfterExtension;

        /// <summary>
        /// Collection of extension names after which this extension needs to be
        /// provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ProvisionAfterExtension { get => this._provisionAfterExtension; set => this._provisionAfterExtension = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings _setting;

        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.Settings()); set => this._setting = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SourceVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal)ProtectedSettingsFromKeyVault).SourceVaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReferenceInternal)ProtectedSettingsFromKeyVault).SourceVaultId = value ?? null; }

        /// <summary>Backing field for <see cref="SuppressFailure" /> property.</summary>
        private bool? _suppressFailure;

        /// <summary>
        /// Indicates whether failures stemming from the extension will be suppressed
        /// (Operational failures such as not connecting to the VM will not be suppressed
        /// regardless of this value). The default is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? SuppressFailure { get => this._suppressFailure; set => this._suppressFailure = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="TypeHandlerVersion" /> property.</summary>
        private string _typeHandlerVersion;

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string TypeHandlerVersion { get => this._typeHandlerVersion; set => this._typeHandlerVersion = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetExtensionProperties" /> instance.
        /// </summary>
        public VirtualMachineScaleSetExtensionProperties()
        {

        }
    }
    /// Describes the properties of a Virtual Machine Scale Set Extension.
    public partial interface IVirtualMachineScaleSetExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is
        /// available at deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the extension should use a newer minor version if one is
        available at deployment time. Once deployed, however, the extension will not
        upgrade minor versions unless redeployed, even with this property set to true.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the
        /// platform if there is a newer version of the extension available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the extension should be automatically upgraded by the
        platform if there is a newer version of the extension available.",
        SerializedName = @"enableAutomaticUpgrade",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>
        /// If a value is provided and is different from the previous value, the extension
        /// handler will be forced to update even if the extension configuration has not
        /// changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If a value is provided and is different from the previous value, the extension
        handler will be forced to update even if the extension configuration has not
        changed.",
        SerializedName = @"forceUpdateTag",
        PossibleTypes = new [] { typeof(string) })]
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = true,
        Description = @"The extension can contain either protectedSettings or
        protectedSettingsFromKeyVault or no protected settings at all.",
        SerializedName = @"protectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings ProtectedSetting { get; set; }
        /// <summary>The URL referencing a secret in a Key Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL referencing a secret in a Key Vault.",
        SerializedName = @"secretUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectedSettingFromKeyVaultSecretUrl { get; set; }
        /// <summary>
        /// Collection of extension names after which this extension needs to be
        /// provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Collection of extension names after which this extension needs to be
        provisioned.",
        SerializedName = @"provisionAfterExtensions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ProvisionAfterExtension { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state, which only appears in the response.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the extension handler publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Json formatted public settings for the extension.",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings Setting { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SourceVaultId { get; set; }
        /// <summary>
        /// Indicates whether failures stemming from the extension will be suppressed
        /// (Operational failures such as not connecting to the VM will not be suppressed
        /// regardless of this value). The default is false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether failures stemming from the extension will be suppressed
        (Operational failures such as not connecting to the VM will not be suppressed
        regardless of this value). The default is false.",
        SerializedName = @"suppressFailures",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SuppressFailure { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the type of the extension; an example is ""CustomScriptExtension"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the script handler.",
        SerializedName = @"typeHandlerVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TypeHandlerVersion { get; set; }

    }
    /// Describes the properties of a Virtual Machine Scale Set Extension.
    internal partial interface IVirtualMachineScaleSetExtensionPropertiesInternal

    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is
        /// available at deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the
        /// platform if there is a newer version of the extension available.
        /// </summary>
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>
        /// If a value is provided and is different from the previous value, the extension
        /// handler will be forced to update even if the extension configuration has not
        /// changed.
        /// </summary>
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings ProtectedSetting { get; set; }
        /// <summary>The URL referencing a secret in a Key Vault.</summary>
        string ProtectedSettingFromKeyVaultSecretUrl { get; set; }
        /// <summary>The relative URL of the Key Vault containing the secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource ProtectedSettingFromKeyVaultSourceVault { get; set; }
        /// <summary>
        /// The extensions protected settings that are passed by reference, and consumed
        /// from key vault
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IKeyVaultSecretReference ProtectedSettingsFromKeyVault { get; set; }
        /// <summary>
        /// Collection of extension names after which this extension needs to be
        /// provisioned.
        /// </summary>
        System.Collections.Generic.List<string> ProvisionAfterExtension { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The name of the extension handler publisher.</summary>
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings Setting { get; set; }
        /// <summary>Resource Id</summary>
        string SourceVaultId { get; set; }
        /// <summary>
        /// Indicates whether failures stemming from the extension will be suppressed
        /// (Operational failures such as not connecting to the VM will not be suppressed
        /// regardless of this value). The default is false.
        /// </summary>
        bool? SuppressFailure { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string TypeHandlerVersion { get; set; }

    }
}