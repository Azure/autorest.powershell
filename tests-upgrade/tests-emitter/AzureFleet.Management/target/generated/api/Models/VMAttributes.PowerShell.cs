// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>
    /// VMAttributes that will be used to filter VMSizes which will be used to build Fleet.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(VMAttributesTypeConverter))]
    public partial class VMAttributes
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMAttributes(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMAttributes(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMAttributes" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMAttributes" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMAttributes(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VCpuCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("VCpuCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("MemoryInGiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiB = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("MemoryInGiB",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiB, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("MemoryInGiBPerVcpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpu = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("MemoryInGiBPerVcpu",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpu, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("LocalStorageInGiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiB = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("LocalStorageInGiB",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiB, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("DataDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkInterfaceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("NetworkInterfaceCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkBandwidthInMbps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbps = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("NetworkBandwidthInMbps",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbps, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("RdmaNetworkInterfaceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("RdmaNetworkInterfaceCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("AcceleratorCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("AcceleratorCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("LocalStorageSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageSupport = (string) content.GetValueForProperty("LocalStorageSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageSupport, global::System.Convert.ToString);
            }
            if (content.Contains("LocalStorageDiskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageDiskType = (System.Collections.Generic.List<string>) content.GetValueForProperty("LocalStorageDiskType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageDiskType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RdmaSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaSupport = (string) content.GetValueForProperty("RdmaSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaSupport, global::System.Convert.ToString);
            }
            if (content.Contains("AcceleratorSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorSupport = (string) content.GetValueForProperty("AcceleratorSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorSupport, global::System.Convert.ToString);
            }
            if (content.Contains("AcceleratorManufacturer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorManufacturer = (System.Collections.Generic.List<string>) content.GetValueForProperty("AcceleratorManufacturer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorManufacturer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AcceleratorType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorType = (System.Collections.Generic.List<string>) content.GetValueForProperty("AcceleratorType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VMCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VMCategory = (System.Collections.Generic.List<string>) content.GetValueForProperty("VMCategory",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VMCategory, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ArchitectureType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ArchitectureType = (System.Collections.Generic.List<string>) content.GetValueForProperty("ArchitectureType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ArchitectureType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CpuManufacturer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).CpuManufacturer = (System.Collections.Generic.List<string>) content.GetValueForProperty("CpuManufacturer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).CpuManufacturer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BurstableSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).BurstableSupport = (string) content.GetValueForProperty("BurstableSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).BurstableSupport, global::System.Convert.ToString);
            }
            if (content.Contains("ExcludedVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ExcludedVMSize = (System.Collections.Generic.List<string>) content.GetValueForProperty("ExcludedVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ExcludedVMSize, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MemoryInGiBMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMax = (double?) content.GetValueForProperty("MemoryInGiBMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("MemoryInGiBPerVcpuMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMax = (double?) content.GetValueForProperty("MemoryInGiBPerVcpuMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("LocalStorageInGiBMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMax = (double?) content.GetValueForProperty("LocalStorageInGiBMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("NetworkBandwidthInMbpsMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMax = (double?) content.GetValueForProperty("NetworkBandwidthInMbpsMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("VCpuCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMin = (int?) content.GetValueForProperty("VCpuCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VCpuCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMax = (int?) content.GetValueForProperty("VCpuCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MemoryInGiBMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMin = (double?) content.GetValueForProperty("MemoryInGiBMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("MemoryInGiBPerVcpuMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMin = (double?) content.GetValueForProperty("MemoryInGiBPerVcpuMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("LocalStorageInGiBMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMin = (double?) content.GetValueForProperty("LocalStorageInGiBMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("DataDiskCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMin = (int?) content.GetValueForProperty("DataDiskCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataDiskCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMax = (int?) content.GetValueForProperty("DataDiskCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NetworkInterfaceCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMin = (int?) content.GetValueForProperty("NetworkInterfaceCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NetworkInterfaceCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMax = (int?) content.GetValueForProperty("NetworkInterfaceCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NetworkBandwidthInMbpsMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMin = (double?) content.GetValueForProperty("NetworkBandwidthInMbpsMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("RdmaNetworkInterfaceCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMin = (int?) content.GetValueForProperty("RdmaNetworkInterfaceCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RdmaNetworkInterfaceCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMax = (int?) content.GetValueForProperty("RdmaNetworkInterfaceCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AcceleratorCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMin = (int?) content.GetValueForProperty("AcceleratorCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AcceleratorCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMax = (int?) content.GetValueForProperty("AcceleratorCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributes"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMAttributes(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VCpuCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("VCpuCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("MemoryInGiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiB = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("MemoryInGiB",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiB, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("MemoryInGiBPerVcpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpu = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("MemoryInGiBPerVcpu",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpu, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("LocalStorageInGiB"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiB = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("LocalStorageInGiB",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiB, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("DataDiskCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("DataDiskCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkInterfaceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("NetworkInterfaceCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkBandwidthInMbps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbps = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble) content.GetValueForProperty("NetworkBandwidthInMbps",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbps, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDoubleTypeConverter.ConvertFrom);
            }
            if (content.Contains("RdmaNetworkInterfaceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("RdmaNetworkInterfaceCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("AcceleratorCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCount = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger) content.GetValueForProperty("AcceleratorCount",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCount, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxIntegerTypeConverter.ConvertFrom);
            }
            if (content.Contains("LocalStorageSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageSupport = (string) content.GetValueForProperty("LocalStorageSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageSupport, global::System.Convert.ToString);
            }
            if (content.Contains("LocalStorageDiskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageDiskType = (System.Collections.Generic.List<string>) content.GetValueForProperty("LocalStorageDiskType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageDiskType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RdmaSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaSupport = (string) content.GetValueForProperty("RdmaSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaSupport, global::System.Convert.ToString);
            }
            if (content.Contains("AcceleratorSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorSupport = (string) content.GetValueForProperty("AcceleratorSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorSupport, global::System.Convert.ToString);
            }
            if (content.Contains("AcceleratorManufacturer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorManufacturer = (System.Collections.Generic.List<string>) content.GetValueForProperty("AcceleratorManufacturer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorManufacturer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AcceleratorType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorType = (System.Collections.Generic.List<string>) content.GetValueForProperty("AcceleratorType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VMCategory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VMCategory = (System.Collections.Generic.List<string>) content.GetValueForProperty("VMCategory",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VMCategory, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ArchitectureType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ArchitectureType = (System.Collections.Generic.List<string>) content.GetValueForProperty("ArchitectureType",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ArchitectureType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CpuManufacturer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).CpuManufacturer = (System.Collections.Generic.List<string>) content.GetValueForProperty("CpuManufacturer",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).CpuManufacturer, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("BurstableSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).BurstableSupport = (string) content.GetValueForProperty("BurstableSupport",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).BurstableSupport, global::System.Convert.ToString);
            }
            if (content.Contains("ExcludedVMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ExcludedVMSize = (System.Collections.Generic.List<string>) content.GetValueForProperty("ExcludedVMSize",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).ExcludedVMSize, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MemoryInGiBMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMax = (double?) content.GetValueForProperty("MemoryInGiBMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("MemoryInGiBPerVcpuMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMax = (double?) content.GetValueForProperty("MemoryInGiBPerVcpuMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("LocalStorageInGiBMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMax = (double?) content.GetValueForProperty("LocalStorageInGiBMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("NetworkBandwidthInMbpsMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMax = (double?) content.GetValueForProperty("NetworkBandwidthInMbpsMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMax, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("VCpuCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMin = (int?) content.GetValueForProperty("VCpuCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VCpuCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMax = (int?) content.GetValueForProperty("VCpuCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).VCpuCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MemoryInGiBMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMin = (double?) content.GetValueForProperty("MemoryInGiBMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("MemoryInGiBPerVcpuMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMin = (double?) content.GetValueForProperty("MemoryInGiBPerVcpuMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).MemoryInGiBPerVcpuMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("LocalStorageInGiBMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMin = (double?) content.GetValueForProperty("LocalStorageInGiBMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).LocalStorageInGiBMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("DataDiskCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMin = (int?) content.GetValueForProperty("DataDiskCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataDiskCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMax = (int?) content.GetValueForProperty("DataDiskCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).DataDiskCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NetworkInterfaceCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMin = (int?) content.GetValueForProperty("NetworkInterfaceCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NetworkInterfaceCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMax = (int?) content.GetValueForProperty("NetworkInterfaceCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkInterfaceCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("NetworkBandwidthInMbpsMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMin = (double?) content.GetValueForProperty("NetworkBandwidthInMbpsMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).NetworkBandwidthInMbpsMin, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("RdmaNetworkInterfaceCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMin = (int?) content.GetValueForProperty("RdmaNetworkInterfaceCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RdmaNetworkInterfaceCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMax = (int?) content.GetValueForProperty("RdmaNetworkInterfaceCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).RdmaNetworkInterfaceCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AcceleratorCountMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMin = (int?) content.GetValueForProperty("AcceleratorCountMin",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AcceleratorCountMax"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMax = (int?) content.GetValueForProperty("AcceleratorCountMax",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal)this).AcceleratorCountMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMAttributes that will be used to filter VMSizes which will be used to build Fleet.
    [System.ComponentModel.TypeConverter(typeof(VMAttributesTypeConverter))]
    public partial interface IVMAttributes

    {

    }
}