// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the properties of a Virtual Machine Scale Set Extension.</summary>
    public partial class VmssExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeMinorVersion" /> property.</summary>
        private bool? _autoUpgradeMinorVersion;

        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? AutoUpgradeMinorVersion { get => this._autoUpgradeMinorVersion; set => this._autoUpgradeMinorVersion = value; }

        /// <summary>Backing field for <see cref="EnableAutomaticUpgrade" /> property.</summary>
        private bool? _enableAutomaticUpgrade;

        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension
        /// available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableAutomaticUpgrade { get => this._enableAutomaticUpgrade; set => this._enableAutomaticUpgrade = value; }

        /// <summary>Backing field for <see cref="ForceUpdateTag" /> property.</summary>
        private string _forceUpdateTag;

        /// <summary>
        /// If a value is provided and is different from the previous value, the extension handler will be forced to update even if
        /// the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ForceUpdateTag { get => this._forceUpdateTag; set => this._forceUpdateTag = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProtectedSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny _protectedSetting;

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny ProtectedSetting { get => (this._protectedSetting = this._protectedSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Any()); set => this._protectedSetting = value; }

        /// <summary>Backing field for <see cref="ProvisionAfterExtension" /> property.</summary>
        private System.Collections.Generic.List<string> _provisionAfterExtension;

        /// <summary>
        /// Collection of extension names after which this extension needs to be provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ProvisionAfterExtension { get => this._provisionAfterExtension; set => this._provisionAfterExtension = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="Setting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny _setting;

        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny Setting { get => (this._setting = this._setting ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Any()); set => this._setting = value; }

        /// <summary>Backing field for <see cref="SetupOrder" /> property.</summary>
        private System.Collections.Generic.List<string> _setupOrder;

        /// <summary>Indicates the setup order for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SetupOrder { get => this._setupOrder; set => this._setupOrder = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="TypeHandlerVersion" /> property.</summary>
        private string _typeHandlerVersion;

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string TypeHandlerVersion { get => this._typeHandlerVersion; set => this._typeHandlerVersion = value; }

        /// <summary>Creates an new <see cref="VmssExtensionProperties" /> instance.</summary>
        public VmssExtensionProperties()
        {

        }
    }
    /// Describes the properties of a Virtual Machine Scale Set Extension.
    public partial interface IVmssExtensionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.",
        SerializedName = @"autoUpgradeMinorVersion",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension
        /// available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available.",
        SerializedName = @"enableAutomaticUpgrade",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>
        /// If a value is provided and is different from the previous value, the extension handler will be forced to update even if
        /// the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If a value is provided and is different from the previous value, the extension handler will be forced to update even if the extension configuration has not changed.",
        SerializedName = @"forceUpdateTag",
        PossibleTypes = new [] { typeof(string) })]
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.",
        SerializedName = @"protectedSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny ProtectedSetting { get; set; }
        /// <summary>
        /// Collection of extension names after which this extension needs to be provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Collection of extension names after which this extension needs to be provisioned.",
        SerializedName = @"provisionAfterExtensions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ProvisionAfterExtension { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the extension handler publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Json formatted public settings for the extension.",
        SerializedName = @"settings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny Setting { get; set; }
        /// <summary>Indicates the setup order for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the setup order for the extension.",
        SerializedName = @"setupOrder",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("BeforeSFRuntime")]
        System.Collections.Generic.List<string> SetupOrder { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the type of the extension; an example is ""CustomScriptExtension"".",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
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
    internal partial interface IVmssExtensionPropertiesInternal

    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension
        /// available.
        /// </summary>
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>
        /// If a value is provided and is different from the previous value, the extension handler will be forced to update even if
        /// the extension configuration has not changed.
        /// </summary>
        string ForceUpdateTag { get; set; }
        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny ProtectedSetting { get; set; }
        /// <summary>
        /// Collection of extension names after which this extension needs to be provisioned.
        /// </summary>
        System.Collections.Generic.List<string> ProvisionAfterExtension { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The name of the extension handler publisher.</summary>
        string Publisher { get; set; }
        /// <summary>Json formatted public settings for the extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny Setting { get; set; }
        /// <summary>Indicates the setup order for the extension.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("BeforeSFRuntime")]
        System.Collections.Generic.List<string> SetupOrder { get; set; }
        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        string Type { get; set; }
        /// <summary>Specifies the version of the script handler.</summary>
        string TypeHandlerVersion { get; set; }

    }
}