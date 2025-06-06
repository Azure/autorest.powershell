// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. For a
    /// list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(LinuxConfigurationTypeConverter))]
    public partial class LinuxConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LinuxConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LinuxConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LinuxConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="LinuxConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LinuxConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Ssh"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).Ssh = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration) content.GetValueForProperty("Ssh",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).Ssh, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("PatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings) content.GetValueForProperty("PatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisablePasswordAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication = (bool?) content.GetValueForProperty("DisablePasswordAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).ProvisionVMAgent = (bool?) content.GetValueForProperty("ProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).ProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).EnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("EnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).EnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).SshPublicKey = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>) content.GetValueForProperty("SshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).SshPublicKey, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshPublicKeyTypeConverter.ConvertFrom));
            }
            if (content.Contains("PatchSettingAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("PatchSettingAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PatchSettingPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingPatchMode = (string) content.GetValueForProperty("PatchSettingPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("PatchSettingAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAssessmentMode = (string) content.GetValueForProperty("PatchSettingAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting = (string) content.GetValueForProperty("AutomaticByPlatformSettingRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LinuxConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Ssh"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).Ssh = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshConfiguration) content.GetValueForProperty("Ssh",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).Ssh, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("PatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxPatchSettings) content.GetValueForProperty("PatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DisablePasswordAuthentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication = (bool?) content.GetValueForProperty("DisablePasswordAuthentication",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).DisablePasswordAuthentication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).ProvisionVMAgent = (bool?) content.GetValueForProperty("ProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).ProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).EnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("EnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).EnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SshPublicKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).SshPublicKey = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>) content.GetValueForProperty("SshPublicKey",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).SshPublicKey, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISshPublicKey>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshPublicKeyTypeConverter.ConvertFrom));
            }
            if (content.Contains("PatchSettingAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("PatchSettingAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PatchSettingPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingPatchMode = (string) content.GetValueForProperty("PatchSettingPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("PatchSettingAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAssessmentMode = (string) content.GetValueForProperty("PatchSettingAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).PatchSettingAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting = (string) content.GetValueForProperty("AutomaticByPlatformSettingRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

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
    }
    /// Specifies the Linux operating system settings on the virtual machine. For a
    /// list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://learn.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    [System.ComponentModel.TypeConverter(typeof(LinuxConfigurationTypeConverter))]
    public partial interface ILinuxConfiguration

    {

    }
}