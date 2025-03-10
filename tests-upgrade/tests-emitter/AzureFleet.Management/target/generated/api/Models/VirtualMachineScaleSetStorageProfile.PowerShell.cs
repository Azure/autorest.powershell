// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>Describes a virtual machine scale set storage profile.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetStorageProfileTypeConverter))]
    public partial class VirtualMachineScaleSetStorageProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineScaleSetStorageProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfile"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineScaleSetStorageProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineScaleSetStorageProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="VirtualMachineScaleSetStorageProfile" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineScaleSetStorageProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReference = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference) content.GetValueForProperty("ImageReference",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReference, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk) content.GetValueForProperty("OSDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DataDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk>) content.GetValueForProperty("DataDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DataDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetDataDiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("DiskControllerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiskControllerType = (string) content.GetValueForProperty("DiskControllerType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiskControllerType, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceExactVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceExactVersion = (string) content.GetValueForProperty("ImageReferenceExactVersion",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceExactVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSharedGalleryImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSharedGalleryImageId = (string) content.GetValueForProperty("ImageReferenceSharedGalleryImageId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSharedGalleryImageId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceCommunityGalleryImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceCommunityGalleryImageId = (string) content.GetValueForProperty("ImageReferenceCommunityGalleryImageId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceCommunityGalleryImageId, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskDiffDiskSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDiffDiskSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings) content.GetValueForProperty("OSDiskDiffDiskSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDiffDiskSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiffDiskSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDiskImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualHardDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDiskManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters) content.GetValueForProperty("OSDiskManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskManagedDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDiskName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskName = (string) content.GetValueForProperty("OSDiskName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskName, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskCaching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCaching = (string) content.GetValueForProperty("OSDiskCaching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCaching, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskWriteAcceleratorEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskWriteAcceleratorEnabled = (bool?) content.GetValueForProperty("OSDiskWriteAcceleratorEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskWriteAcceleratorEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSDiskCreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCreateOption = (string) content.GetValueForProperty("OSDiskCreateOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskSizeGb = (int?) content.GetValueForProperty("OSDiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSDiskOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskOstype = (string) content.GetValueForProperty("OSDiskOstype",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskOstype, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskVhdContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskVhdContainer = (System.Collections.Generic.List<string>) content.GetValueForProperty("OSDiskVhdContainer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskVhdContainer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OSDiskDeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDeleteOption = (string) content.GetValueForProperty("OSDiskDeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingOption = (string) content.GetValueForProperty("DiffDiskSettingOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingPlacement"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingPlacement = (string) content.GetValueForProperty("DiffDiskSettingPlacement",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingPlacement, global::System.Convert.ToString);
            }
            if (content.Contains("ImageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageUri = (string) content.GetValueForProperty("ImageUri",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("ManagedDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile) content.GetValueForProperty("ManagedDiskSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskStorageAccountType = (string) content.GetValueForProperty("ManagedDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("SecurityProfileDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileSecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileSecurityEncryptionType = (string) content.GetValueForProperty("SecurityProfileSecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileSecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetStorageProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineScaleSetStorageProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ImageReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReference = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference) content.GetValueForProperty("ImageReference",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReference, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ImageReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk) content.GetValueForProperty("OSDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DataDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk>) content.GetValueForProperty("DataDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DataDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetDataDiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("DiskControllerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiskControllerType = (string) content.GetValueForProperty("DiskControllerType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiskControllerType, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceId = (string) content.GetValueForProperty("ImageReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferencePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferencePublisher = (string) content.GetValueForProperty("ImageReferencePublisher",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferencePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceOffer = (string) content.GetValueForProperty("ImageReferenceOffer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceOffer, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSku = (string) content.GetValueForProperty("ImageReferenceSku",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSku, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceVersion = (string) content.GetValueForProperty("ImageReferenceVersion",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceExactVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceExactVersion = (string) content.GetValueForProperty("ImageReferenceExactVersion",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceExactVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceSharedGalleryImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSharedGalleryImageId = (string) content.GetValueForProperty("ImageReferenceSharedGalleryImageId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceSharedGalleryImageId, global::System.Convert.ToString);
            }
            if (content.Contains("ImageReferenceCommunityGalleryImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceCommunityGalleryImageId = (string) content.GetValueForProperty("ImageReferenceCommunityGalleryImageId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageReferenceCommunityGalleryImageId, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskDiffDiskSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDiffDiskSetting = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings) content.GetValueForProperty("OSDiskDiffDiskSetting",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDiffDiskSetting, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiffDiskSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDiskImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskImage = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk) content.GetValueForProperty("OSDiskImage",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskImage, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualHardDiskTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDiskManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters) content.GetValueForProperty("OSDiskManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskManagedDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSDiskName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskName = (string) content.GetValueForProperty("OSDiskName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskName, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskCaching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCaching = (string) content.GetValueForProperty("OSDiskCaching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCaching, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskWriteAcceleratorEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskWriteAcceleratorEnabled = (bool?) content.GetValueForProperty("OSDiskWriteAcceleratorEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskWriteAcceleratorEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSDiskCreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCreateOption = (string) content.GetValueForProperty("OSDiskCreateOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskCreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskSizeGb = (int?) content.GetValueForProperty("OSDiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSDiskOstype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskOstype = (string) content.GetValueForProperty("OSDiskOstype",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskOstype, global::System.Convert.ToString);
            }
            if (content.Contains("OSDiskVhdContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskVhdContainer = (System.Collections.Generic.List<string>) content.GetValueForProperty("OSDiskVhdContainer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskVhdContainer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("OSDiskDeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDeleteOption = (string) content.GetValueForProperty("OSDiskDeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).OSDiskDeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingOption = (string) content.GetValueForProperty("DiffDiskSettingOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiffDiskSettingPlacement"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingPlacement = (string) content.GetValueForProperty("DiffDiskSettingPlacement",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).DiffDiskSettingPlacement, global::System.Convert.ToString);
            }
            if (content.Contains("ImageUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageUri = (string) content.GetValueForProperty("ImageUri",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ImageUri, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("ManagedDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile) content.GetValueForProperty("ManagedDiskSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskStorageAccountType = (string) content.GetValueForProperty("ManagedDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).ManagedDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("SecurityProfileDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileSecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileSecurityEncryptionType = (string) content.GetValueForProperty("SecurityProfileSecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileSecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal)this).SecurityProfileDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Describes a virtual machine scale set storage profile.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetStorageProfileTypeConverter))]
    public partial interface IVirtualMachineScaleSetStorageProfile

    {

    }
}