// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>Describes a virtual machine scale set OS profile.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetOSProfileTypeConverter))]
    public partial class VirtualMachineScaleSetOSProfile
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineScaleSetOSProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineScaleSetOSProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineScaleSetOSProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachineScaleSetOSProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineScaleSetOSProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("WindowsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration) content.GetValueForProperty("WindowsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration) content.GetValueForProperty("LinuxConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComputerNamePrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).ComputerNamePrefix = (string) content.GetValueForProperty("ComputerNamePrefix",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).ComputerNamePrefix, global::System.Convert.ToString);
            }
            if (content.Contains("AdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminUsername = (string) content.GetValueForProperty("AdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminPassword = (System.Security.SecureString) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("CustomData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).CustomData = (System.Security.SecureString) content.GetValueForProperty("CustomData",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).CustomData, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("Secret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).Secret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup>) content.GetValueForProperty("Secret",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).Secret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VaultSecretGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("AllowExtensionOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AllowExtensionOperation = (bool?) content.GetValueForProperty("AllowExtensionOperation",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AllowExtensionOperation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RequireGuestProvisionSignal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).RequireGuestProvisionSignal = (bool?) content.GetValueForProperty("RequireGuestProvisionSignal",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).RequireGuestProvisionSignal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowConfigurationPatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings) content.GetValueForProperty("WindowConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WindowConfigurationWinRm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationWinRm = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration) content.GetValueForProperty("WindowConfigurationWinRm",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationWinRm, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("WindowConfigurationProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationProvisionVMAgent = (bool?) content.GetValueForProperty("WindowConfigurationProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowConfigurationEnableAutomaticUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableAutomaticUpdate = (bool?) content.GetValueForProperty("WindowConfigurationEnableAutomaticUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableAutomaticUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowConfigurationTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationTimeZone = (string) content.GetValueForProperty("WindowConfigurationTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("WindowConfigurationAdditionalUnattendContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationAdditionalUnattendContent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>) content.GetValueForProperty("WindowConfigurationAdditionalUnattendContent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationAdditionalUnattendContent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalUnattendContentTypeConverter.ConvertFrom));
            }
            if (content.Contains("WindowConfigurationEnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("WindowConfigurationEnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WinRmListener"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WinRmListener = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>) content.GetValueForProperty("WinRmListener",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WinRmListener, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmListenerTypeConverter.ConvertFrom));
            }
            if (content.Contains("LinuxConfigurationSsh"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationSsh = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration) content.GetValueForProperty("LinuxConfigurationSsh",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationSsh, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfigurationPatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings) content.GetValueForProperty("LinuxConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfigurationDisablePasswordAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationDisablePasswordAuthentication = (bool?) content.GetValueForProperty("LinuxConfigurationDisablePasswordAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationDisablePasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LinuxConfigurationProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationProvisionVMAgent = (bool?) content.GetValueForProperty("LinuxConfigurationProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LinuxConfigurationEnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationEnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("LinuxConfigurationEnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationEnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).SshPublicKey = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>) content.GetValueForProperty("SshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).SshPublicKey, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshPublicKeyTypeConverter.ConvertFrom));
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("WindowsConfigurationPatchSettingsAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WindowsConfigurationPatchSettingsPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsPatchMode = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("PatchSettingEnableHotpatching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).PatchSettingEnableHotpatching = (bool?) content.GetValueForProperty("PatchSettingEnableHotpatching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).PatchSettingEnableHotpatching, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("LinuxConfigurationPatchSettingsAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsPatchMode = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineScaleSetOSProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("WindowsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration) content.GetValueForProperty("WindowsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration) content.GetValueForProperty("LinuxConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfiguration, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComputerNamePrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).ComputerNamePrefix = (string) content.GetValueForProperty("ComputerNamePrefix",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).ComputerNamePrefix, global::System.Convert.ToString);
            }
            if (content.Contains("AdminUsername"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminUsername = (string) content.GetValueForProperty("AdminUsername",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminUsername, global::System.Convert.ToString);
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminPassword = (System.Security.SecureString) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("CustomData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).CustomData = (System.Security.SecureString) content.GetValueForProperty("CustomData",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).CustomData, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("Secret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).Secret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup>) content.GetValueForProperty("Secret",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).Secret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VaultSecretGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("AllowExtensionOperation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AllowExtensionOperation = (bool?) content.GetValueForProperty("AllowExtensionOperation",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).AllowExtensionOperation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RequireGuestProvisionSignal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).RequireGuestProvisionSignal = (bool?) content.GetValueForProperty("RequireGuestProvisionSignal",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).RequireGuestProvisionSignal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowConfigurationPatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings) content.GetValueForProperty("WindowConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WindowConfigurationWinRm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationWinRm = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration) content.GetValueForProperty("WindowConfigurationWinRm",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationWinRm, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("WindowConfigurationProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationProvisionVMAgent = (bool?) content.GetValueForProperty("WindowConfigurationProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowConfigurationEnableAutomaticUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableAutomaticUpdate = (bool?) content.GetValueForProperty("WindowConfigurationEnableAutomaticUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableAutomaticUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowConfigurationTimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationTimeZone = (string) content.GetValueForProperty("WindowConfigurationTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationTimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("WindowConfigurationAdditionalUnattendContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationAdditionalUnattendContent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>) content.GetValueForProperty("WindowConfigurationAdditionalUnattendContent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationAdditionalUnattendContent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalUnattendContentTypeConverter.ConvertFrom));
            }
            if (content.Contains("WindowConfigurationEnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("WindowConfigurationEnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowConfigurationEnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WinRmListener"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WinRmListener = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>) content.GetValueForProperty("WinRmListener",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WinRmListener, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmListenerTypeConverter.ConvertFrom));
            }
            if (content.Contains("LinuxConfigurationSsh"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationSsh = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration) content.GetValueForProperty("LinuxConfigurationSsh",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationSsh, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfigurationPatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings) content.GetValueForProperty("LinuxConfigurationPatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfigurationDisablePasswordAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationDisablePasswordAuthentication = (bool?) content.GetValueForProperty("LinuxConfigurationDisablePasswordAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationDisablePasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LinuxConfigurationProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationProvisionVMAgent = (bool?) content.GetValueForProperty("LinuxConfigurationProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LinuxConfigurationEnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationEnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("LinuxConfigurationEnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationEnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).SshPublicKey = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>) content.GetValueForProperty("SshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).SshPublicKey, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshPublicKeyTypeConverter.ConvertFrom));
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("WindowsConfigurationPatchSettingsAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WindowsConfigurationPatchSettingsPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsPatchMode = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("PatchSettingEnableHotpatching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).PatchSettingEnableHotpatching = (bool?) content.GetValueForProperty("PatchSettingEnableHotpatching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).PatchSettingEnableHotpatching, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("LinuxConfigurationPatchSettingsAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsPatchMode = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAssessmentMode = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting = (string) content.GetValueForProperty("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).WindowsConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting = (string) content.GetValueForProperty("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfileInternal)this).LinuxConfigurationPatchSettingsAutomaticByPlatformSettingsBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Describes a virtual machine scale set OS profile.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetOSProfileTypeConverter))]
    public partial interface IVirtualMachineScaleSetOSProfile

    {

    }
}