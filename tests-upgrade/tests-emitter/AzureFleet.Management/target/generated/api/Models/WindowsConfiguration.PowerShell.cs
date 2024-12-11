// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>Specifies Windows operating system settings on the virtual machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(WindowsConfigurationTypeConverter))]
    public partial class WindowsConfiguration
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WindowsConfiguration(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WindowsConfiguration(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WindowsConfiguration" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="WindowsConfiguration" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfiguration FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WindowsConfiguration(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings) content.GetValueForProperty("PatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WinRm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRm = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration) content.GetValueForProperty("WinRm",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRm, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).ProvisionVMAgent = (bool?) content.GetValueForProperty("ProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).ProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableAutomaticUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableAutomaticUpdate = (bool?) content.GetValueForProperty("EnableAutomaticUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableAutomaticUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalUnattendContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AdditionalUnattendContent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>) content.GetValueForProperty("AdditionalUnattendContent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AdditionalUnattendContent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalUnattendContentTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("EnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WinRmListener"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRmListener = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>) content.GetValueForProperty("WinRmListener",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRmListener, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmListenerTypeConverter.ConvertFrom));
            }
            if (content.Contains("PatchSettingAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("PatchSettingAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PatchSettingPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingPatchMode = (string) content.GetValueForProperty("PatchSettingPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("PatchSettingEnableHotpatching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingEnableHotpatching = (bool?) content.GetValueForProperty("PatchSettingEnableHotpatching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingEnableHotpatching, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PatchSettingAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAssessmentMode = (string) content.GetValueForProperty("PatchSettingAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting = (string) content.GetValueForProperty("AutomaticByPlatformSettingRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WindowsConfiguration(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PatchSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPatchSettings) content.GetValueForProperty("PatchSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.PatchSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WinRm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRm = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmConfiguration) content.GetValueForProperty("WinRm",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRm, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisionVMAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).ProvisionVMAgent = (bool?) content.GetValueForProperty("ProvisionVMAgent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).ProvisionVMAgent, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableAutomaticUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableAutomaticUpdate = (bool?) content.GetValueForProperty("EnableAutomaticUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableAutomaticUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TimeZone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).TimeZone = (string) content.GetValueForProperty("TimeZone",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).TimeZone, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalUnattendContent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AdditionalUnattendContent = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>) content.GetValueForProperty("AdditionalUnattendContent",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AdditionalUnattendContent, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalUnattendContent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalUnattendContentTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableVMAgentPlatformUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableVMAgentPlatformUpdate = (bool?) content.GetValueForProperty("EnableVMAgentPlatformUpdate",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).EnableVMAgentPlatformUpdate, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("WinRmListener"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRmListener = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>) content.GetValueForProperty("WinRmListener",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).WinRmListener, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWinRmListener>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WinRmListenerTypeConverter.ConvertFrom));
            }
            if (content.Contains("PatchSettingAutomaticByPlatformSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsVMGuestPatchAutomaticByPlatformSettings) content.GetValueForProperty("PatchSettingAutomaticByPlatformSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAutomaticByPlatformSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsVMGuestPatchAutomaticByPlatformSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PatchSettingPatchMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingPatchMode = (string) content.GetValueForProperty("PatchSettingPatchMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingPatchMode, global::System.Convert.ToString);
            }
            if (content.Contains("PatchSettingEnableHotpatching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingEnableHotpatching = (bool?) content.GetValueForProperty("PatchSettingEnableHotpatching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingEnableHotpatching, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PatchSettingAssessmentMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAssessmentMode = (string) content.GetValueForProperty("PatchSettingAssessmentMode",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).PatchSettingAssessmentMode, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingRebootSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting = (string) content.GetValueForProperty("AutomaticByPlatformSettingRebootSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingRebootSetting, global::System.Convert.ToString);
            }
            if (content.Contains("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule = (bool?) content.GetValueForProperty("AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IWindowsConfigurationInternal)this).AutomaticByPlatformSettingBypassPlatformSafetyChecksOnUserSchedule, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Specifies Windows operating system settings on the virtual machine.
    [System.ComponentModel.TypeConverter(typeof(WindowsConfigurationTypeConverter))]
    public partial interface IWindowsConfiguration

    {

    }
}