// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the Security profile settings for the virtual machine or virtual
    /// machine scale set.
    /// </summary>
    public partial class SecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal
    {

        /// <summary>Backing field for <see cref="EncryptionAtHost" /> property.</summary>
        private bool? _encryptionAtHost;

        /// <summary>
        /// This property can be used by user in the request to enable or disable the Host
        /// Encryption for the virtual machine or virtual machine scale set. This will
        /// enable the encryption for all the disks including Resource/Temp disk at host
        /// itself. The default behavior is: The Encryption at host will be disabled unless
        /// this property is set to true for the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EncryptionAtHost { get => this._encryptionAtHost; set => this._encryptionAtHost = value; }

        /// <summary>Backing field for <see cref="EncryptionIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity _encryptionIdentity;

        /// <summary>
        /// Specifies the Managed Identity used by ADE to get access token for keyvault
        /// operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity EncryptionIdentity { get => (this._encryptionIdentity = this._encryptionIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.EncryptionIdentity()); set => this._encryptionIdentity = value; }

        /// <summary>Specifies ARM Resource ID of one of the user identities associated with the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string EncryptionIdentityUserAssignedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentityInternal)EncryptionIdentity).UserAssignedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentityInternal)EncryptionIdentity).UserAssignedIdentityResourceId = value ?? null; }

        /// <summary>Internal Acessors for EncryptionIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal.EncryptionIdentity { get => (this._encryptionIdentity = this._encryptionIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.EncryptionIdentity()); set { {_encryptionIdentity = value;} } }

        /// <summary>Internal Acessors for ProxyAgentSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal.ProxyAgentSetting { get => (this._proxyAgentSetting = this._proxyAgentSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ProxyAgentSettings()); set { {_proxyAgentSetting = value;} } }

        /// <summary>Internal Acessors for UefiSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityProfileInternal.UefiSetting { get => (this._uefiSetting = this._uefiSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.UefiSettings()); set { {_uefiSetting = value;} } }

        /// <summary>Backing field for <see cref="ProxyAgentSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings _proxyAgentSetting;

        /// <summary>
        /// Specifies ProxyAgent settings while creating the virtual machine. Minimum
        /// api-version: 2023-09-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings ProxyAgentSetting { get => (this._proxyAgentSetting = this._proxyAgentSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ProxyAgentSettings()); set => this._proxyAgentSetting = value; }

        /// <summary>
        /// Specifies whether ProxyAgent feature should be enabled on the virtual machine
        /// or virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? ProxyAgentSettingEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal)ProxyAgentSetting).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal)ProxyAgentSetting).Enabled = value ?? default(bool); }

        /// <summary>
        /// Increase the value of this property allows user to reset the key used for
        /// securing communication channel between guest and host.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? ProxyAgentSettingKeyIncarnationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal)ProxyAgentSetting).KeyIncarnationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal)ProxyAgentSetting).KeyIncarnationId = value ?? default(int); }

        /// <summary>
        /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        /// ProxyAgent will start to audit or monitor but not enforce access control over
        /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ProxyAgentSettingMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal)ProxyAgentSetting).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettingsInternal)ProxyAgentSetting).Mode = value ?? null; }

        /// <summary>Backing field for <see cref="SecurityType" /> property.</summary>
        private string _securityType;

        /// <summary>
        /// Specifies the SecurityType of the virtual machine. It has to be set to any
        /// specified value to enable UefiSettings. The default behavior is: UefiSettings
        /// will not be enabled unless this property is set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string SecurityType { get => this._securityType; set => this._securityType = value; }

        /// <summary>Backing field for <see cref="UefiSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings _uefiSetting;

        /// <summary>
        /// Specifies the security settings like secure boot and vTPM used while creating
        /// the virtual machine. Minimum api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings UefiSetting { get => (this._uefiSetting = this._uefiSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.UefiSettings()); set => this._uefiSetting = value; }

        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? UefiSettingSecureBootEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettingsInternal)UefiSetting).SecureBootEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettingsInternal)UefiSetting).SecureBootEnabled = value ?? default(bool); }

        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? UefiSettingVTpmEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettingsInternal)UefiSetting).VTpmEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettingsInternal)UefiSetting).VTpmEnabled = value ?? default(bool); }

        /// <summary>Creates an new <see cref="SecurityProfile" /> instance.</summary>
        public SecurityProfile()
        {

        }
    }
    /// Specifies the Security profile settings for the virtual machine or virtual
    /// machine scale set.
    public partial interface ISecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This property can be used by user in the request to enable or disable the Host
        /// Encryption for the virtual machine or virtual machine scale set. This will
        /// enable the encryption for all the disks including Resource/Temp disk at host
        /// itself. The default behavior is: The Encryption at host will be disabled unless
        /// this property is set to true for the resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property can be used by user in the request to enable or disable the Host
        Encryption for the virtual machine or virtual machine scale set. This will
        enable the encryption for all the disks including Resource/Temp disk at host
        itself. The default behavior is: The Encryption at host will be disabled unless
        this property is set to true for the resource.",
        SerializedName = @"encryptionAtHost",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EncryptionAtHost { get; set; }
        /// <summary>Specifies ARM Resource ID of one of the user identities associated with the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies ARM Resource ID of one of the user identities associated with the VM.",
        SerializedName = @"userAssignedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionIdentityUserAssignedIdentityResourceId { get; set; }
        /// <summary>
        /// Specifies whether ProxyAgent feature should be enabled on the virtual machine
        /// or virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether ProxyAgent feature should be enabled on the virtual machine
        or virtual machine scale set.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ProxyAgentSettingEnabled { get; set; }
        /// <summary>
        /// Increase the value of this property allows user to reset the key used for
        /// securing communication channel between guest and host.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Increase the value of this property allows user to reset the key used for
        securing communication channel between guest and host.",
        SerializedName = @"keyIncarnationId",
        PossibleTypes = new [] { typeof(int) })]
        int? ProxyAgentSettingKeyIncarnationId { get; set; }
        /// <summary>
        /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        /// ProxyAgent will start to audit or monitor but not enforce access control over
        /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        ProxyAgent will start to audit or monitor but not enforce access control over
        requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        access control. The default value is Enforce mode.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Audit", "Enforce")]
        string ProxyAgentSettingMode { get; set; }
        /// <summary>
        /// Specifies the SecurityType of the virtual machine. It has to be set to any
        /// specified value to enable UefiSettings. The default behavior is: UefiSettings
        /// will not be enabled unless this property is set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the SecurityType of the virtual machine. It has to be set to any
        specified value to enable UefiSettings. The default behavior is: UefiSettings
        will not be enabled unless this property is set.",
        SerializedName = @"securityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TrustedLaunch", "ConfidentialVM")]
        string SecurityType { get; set; }
        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether secure boot should be enabled on the virtual machine. Minimum
        api-version: 2020-12-01.",
        SerializedName = @"secureBootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UefiSettingSecureBootEnabled { get; set; }
        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether vTPM should be enabled on the virtual machine. Minimum
        api-version: 2020-12-01.",
        SerializedName = @"vTpmEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UefiSettingVTpmEnabled { get; set; }

    }
    /// Specifies the Security profile settings for the virtual machine or virtual
    /// machine scale set.
    internal partial interface ISecurityProfileInternal

    {
        /// <summary>
        /// This property can be used by user in the request to enable or disable the Host
        /// Encryption for the virtual machine or virtual machine scale set. This will
        /// enable the encryption for all the disks including Resource/Temp disk at host
        /// itself. The default behavior is: The Encryption at host will be disabled unless
        /// this property is set to true for the resource.
        /// </summary>
        bool? EncryptionAtHost { get; set; }
        /// <summary>
        /// Specifies the Managed Identity used by ADE to get access token for keyvault
        /// operations.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IEncryptionIdentity EncryptionIdentity { get; set; }
        /// <summary>Specifies ARM Resource ID of one of the user identities associated with the VM.</summary>
        string EncryptionIdentityUserAssignedIdentityResourceId { get; set; }
        /// <summary>
        /// Specifies ProxyAgent settings while creating the virtual machine. Minimum
        /// api-version: 2023-09-01.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IProxyAgentSettings ProxyAgentSetting { get; set; }
        /// <summary>
        /// Specifies whether ProxyAgent feature should be enabled on the virtual machine
        /// or virtual machine scale set.
        /// </summary>
        bool? ProxyAgentSettingEnabled { get; set; }
        /// <summary>
        /// Increase the value of this property allows user to reset the key used for
        /// securing communication channel between guest and host.
        /// </summary>
        int? ProxyAgentSettingKeyIncarnationId { get; set; }
        /// <summary>
        /// Specifies the mode that ProxyAgent will execute on if the feature is enabled.
        /// ProxyAgent will start to audit or monitor but not enforce access control over
        /// requests to host endpoints in Audit mode, while in Enforce mode it will enforce
        /// access control. The default value is Enforce mode.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Audit", "Enforce")]
        string ProxyAgentSettingMode { get; set; }
        /// <summary>
        /// Specifies the SecurityType of the virtual machine. It has to be set to any
        /// specified value to enable UefiSettings. The default behavior is: UefiSettings
        /// will not be enabled unless this property is set.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TrustedLaunch", "ConfidentialVM")]
        string SecurityType { get; set; }
        /// <summary>
        /// Specifies the security settings like secure boot and vTPM used while creating
        /// the virtual machine. Minimum api-version: 2020-12-01.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IUefiSettings UefiSetting { get; set; }
        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        bool? UefiSettingSecureBootEnabled { get; set; }
        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. Minimum
        /// api-version: 2020-12-01.
        /// </summary>
        bool? UefiSettingVTpmEnabled { get; set; }

    }
}