// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Specifies set of extensions that should be installed onto the virtual machines.</summary>
    public partial class VmssExtension :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionInternal
    {

        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed,
        /// however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? AutoUpgradeMinorVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).AutoUpgradeMinorVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).AutoUpgradeMinorVersion = value ?? default(bool); }

        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension
        /// available.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? EnableAutomaticUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).EnableAutomaticUpgrade; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).EnableAutomaticUpgrade = value ?? default(bool); }

        /// <summary>
        /// If a value is provided and is different from the previous value, the extension handler will be forced to update even if
        /// the extension configuration has not changed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ForceUpdateTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ForceUpdateTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ForceUpdateTag = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionProperties Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssExtensionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionProperties _property;

        /// <summary>Describes the properties of a Virtual Machine Scale Set Extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssExtensionProperties()); set => this._property = value; }

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny ProtectedSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProtectedSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProtectedSetting = value ?? null /* model class */; }

        /// <summary>
        /// Collection of extension names after which this extension needs to be provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ProvisionAfterExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProvisionAfterExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProvisionAfterExtension = value ?? null /* arrayOf */; }

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>The name of the extension handler publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string Publisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).Publisher = value ; }

        /// <summary>Json formatted public settings for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAny Setting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).Setting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).Setting = value ?? null /* model class */; }

        /// <summary>Indicates the setup order for the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SetupOrder { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).SetupOrder; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).SetupOrder = value ?? null /* arrayOf */; }

        /// <summary>Specifies the type of the extension; an example is "CustomScriptExtension".</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).Type = value ; }

        /// <summary>Specifies the version of the script handler.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string TypeHandlerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).TypeHandlerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionPropertiesInternal)Property).TypeHandlerVersion = value ; }

        /// <summary>Creates an new <see cref="VmssExtension" /> instance.</summary>
        public VmssExtension()
        {

        }
    }
    /// Specifies set of extensions that should be installed onto the virtual machines.
    public partial interface IVmssExtension :
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
        /// <summary>The name of the extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the extension.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
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
    /// Specifies set of extensions that should be installed onto the virtual machines.
    internal partial interface IVmssExtensionInternal

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
        /// <summary>The name of the extension.</summary>
        string Name { get; set; }
        /// <summary>Describes the properties of a Virtual Machine Scale Set Extension.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtensionProperties Property { get; set; }
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