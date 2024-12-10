// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>Describes a virtual machine scale set operating system disk.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetOSDiskTypeConverter))]
    public partial class VirtualMachineScaleSetOSDisk
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineScaleSetOSDisk(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineScaleSetOSDisk(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineScaleSetOSDisk" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachineScaleSetOSDisk" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineScaleSetOSDisk(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiffDiskSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings) content.GetValueForProperty("DiffDiskSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiffDiskSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Image = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Image, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualHardDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters) content.GetValueForProperty("ManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Caching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Caching = (string) content.GetValueForProperty("Caching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Caching, global::System.Convert.ToString);
            }
            if (content.Contains("WriteAcceleratorEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).WriteAcceleratorEnabled = (bool?) content.GetValueForProperty("WriteAcceleratorEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).WriteAcceleratorEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).CreateOption = (string) content.GetValueForProperty("CreateOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).CreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiskSizeGb = (int?) content.GetValueForProperty("DiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("VhdContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).VhdContainer = (System.Collections.Generic.List<string>) content.GetValueForProperty("VhdContainer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).VhdContainer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DeleteOption = (string) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingOption = (string) content.GetValueForProperty("DiffDiskSettingOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingPlacement"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingPlacement = (string) content.GetValueForProperty("DiffDiskSettingPlacement",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingPlacement, global::System.Convert.ToString);
            }
            if (content.Contains("ImageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ImageUri = (string) content.GetValueForProperty("ImageUri",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ImageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("ManagedDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile) content.GetValueForProperty("ManagedDiskSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskStorageAccountType = (string) content.GetValueForProperty("ManagedDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("SecurityProfileDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileSecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileSecurityEncryptionType = (string) content.GetValueForProperty("SecurityProfileSecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileSecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineScaleSetOSDisk(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DiffDiskSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings) content.GetValueForProperty("DiffDiskSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiffDiskSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Image"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Image = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk) content.GetValueForProperty("Image",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Image, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualHardDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters) content.GetValueForProperty("ManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Caching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Caching = (string) content.GetValueForProperty("Caching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Caching, global::System.Convert.ToString);
            }
            if (content.Contains("WriteAcceleratorEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).WriteAcceleratorEnabled = (bool?) content.GetValueForProperty("WriteAcceleratorEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).WriteAcceleratorEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).CreateOption = (string) content.GetValueForProperty("CreateOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).CreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiskSizeGb = (int?) content.GetValueForProperty("DiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("VhdContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).VhdContainer = (System.Collections.Generic.List<string>) content.GetValueForProperty("VhdContainer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).VhdContainer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DeleteOption = (string) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingOption = (string) content.GetValueForProperty("DiffDiskSettingOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingPlacement"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingPlacement = (string) content.GetValueForProperty("DiffDiskSettingPlacement",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).DiffDiskSettingPlacement, global::System.Convert.ToString);
            }
            if (content.Contains("ImageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ImageUri = (string) content.GetValueForProperty("ImageUri",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ImageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("ManagedDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile) content.GetValueForProperty("ManagedDiskSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskStorageAccountType = (string) content.GetValueForProperty("ManagedDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).ManagedDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("SecurityProfileDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileSecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileSecurityEncryptionType = (string) content.GetValueForProperty("SecurityProfileSecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileSecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)this).SecurityProfileDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Describes a virtual machine scale set operating system disk.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetOSDiskTypeConverter))]
    public partial interface IVirtualMachineScaleSetOSDisk

    {

    }
}