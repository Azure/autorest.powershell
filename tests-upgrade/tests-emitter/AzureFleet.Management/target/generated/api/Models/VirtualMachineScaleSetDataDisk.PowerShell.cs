// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>Describes a virtual machine scale set data disk.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetDataDiskTypeConverter))]
    public partial class VirtualMachineScaleSetDataDisk
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetDataDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineScaleSetDataDisk(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetDataDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineScaleSetDataDisk(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineScaleSetDataDisk" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VirtualMachineScaleSetDataDisk" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetDataDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineScaleSetDataDisk(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters) content.GetValueForProperty("ManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Lun"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Lun = (int) content.GetValueForProperty("Lun",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Lun, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Caching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Caching = (string) content.GetValueForProperty("Caching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Caching, global::System.Convert.ToString);
            }
            if (content.Contains("WriteAcceleratorEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).WriteAcceleratorEnabled = (bool?) content.GetValueForProperty("WriteAcceleratorEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).WriteAcceleratorEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).CreateOption = (string) content.GetValueForProperty("CreateOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).CreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskSizeGb = (int?) content.GetValueForProperty("DiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DiskIopsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskIopsReadWrite = (long?) content.GetValueForProperty("DiskIopsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskIopsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DiskMBpsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskMBpsReadWrite = (long?) content.GetValueForProperty("DiskMBpsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskMBpsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DeleteOption = (string) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("ManagedDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile) content.GetValueForProperty("ManagedDiskSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskStorageAccountType = (string) content.GetValueForProperty("ManagedDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("SecurityProfileDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileSecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileSecurityEncryptionType = (string) content.GetValueForProperty("SecurityProfileSecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileSecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetDataDisk"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineScaleSetDataDisk(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDisk = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters) content.GetValueForProperty("ManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDisk, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Lun"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Lun = (int) content.GetValueForProperty("Lun",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Lun, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Caching"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Caching = (string) content.GetValueForProperty("Caching",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Caching, global::System.Convert.ToString);
            }
            if (content.Contains("WriteAcceleratorEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).WriteAcceleratorEnabled = (bool?) content.GetValueForProperty("WriteAcceleratorEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).WriteAcceleratorEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CreateOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).CreateOption = (string) content.GetValueForProperty("CreateOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).CreateOption, global::System.Convert.ToString);
            }
            if (content.Contains("DiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskSizeGb = (int?) content.GetValueForProperty("DiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DiskIopsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskIopsReadWrite = (long?) content.GetValueForProperty("DiskIopsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskIopsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DiskMBpsReadWrite"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskMBpsReadWrite = (long?) content.GetValueForProperty("DiskMBpsReadWrite",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DiskMBpsReadWrite, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeleteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DeleteOption = (string) content.GetValueForProperty("DeleteOption",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).DeleteOption, global::System.Convert.ToString);
            }
            if (content.Contains("ManagedDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("ManagedDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskSecurityProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskSecurityProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile) content.GetValueForProperty("ManagedDiskSecurityProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskSecurityProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedDiskStorageAccountType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskStorageAccountType = (string) content.GetValueForProperty("ManagedDiskStorageAccountType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).ManagedDiskStorageAccountType, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSet = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters) content.GetValueForProperty("SecurityProfileDiskEncryptionSet",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSet, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityProfileSecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileSecurityEncryptionType = (string) content.GetValueForProperty("SecurityProfileSecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileSecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityProfileDiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSetId = (string) content.GetValueForProperty("SecurityProfileDiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal)this).SecurityProfileDiskEncryptionSetId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Describes a virtual machine scale set data disk.
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineScaleSetDataDiskTypeConverter))]
    public partial interface IVirtualMachineScaleSetDataDisk

    {

    }
}