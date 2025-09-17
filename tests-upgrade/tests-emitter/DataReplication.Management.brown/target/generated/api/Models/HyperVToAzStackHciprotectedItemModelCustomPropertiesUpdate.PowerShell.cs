// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>HyperV to AzStackHCI Protected item model custom properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateTypeConverter))]
    public partial class HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate" />, deserializing the
        /// content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DynamicMemoryConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig) content.GetValueForProperty("DynamicMemoryConfig",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("NicsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>) content.GetValueForProperty("NicsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcinicInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("TargetCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore = (int?) content.GetValueForProperty("TargetCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsDynamicRam"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam = (bool?) content.GetValueForProperty("IsDynamicRam",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TargetMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte = (int?) content.GetValueForProperty("TargetMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("DynamicMemoryConfigMaximumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMaximumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigMinimumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMinimumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigTargetMemoryBufferPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage = (int?) content.GetValueForProperty("DynamicMemoryConfigTargetMemoryBufferPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DynamicMemoryConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig) content.GetValueForProperty("DynamicMemoryConfig",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("NicsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>) content.GetValueForProperty("NicsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcinicInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("TargetCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore = (int?) content.GetValueForProperty("TargetCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsDynamicRam"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam = (bool?) content.GetValueForProperty("IsDynamicRam",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TargetMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte = (int?) content.GetValueForProperty("TargetMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("DynamicMemoryConfigMaximumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMaximumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigMinimumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMinimumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigTargetMemoryBufferPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage = (int?) content.GetValueForProperty("DynamicMemoryConfigTargetMemoryBufferPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// HyperV to AzStackHCI Protected item model custom properties.
    [System.ComponentModel.TypeConverter(typeof(HyperVToAzStackHciprotectedItemModelCustomPropertiesUpdateTypeConverter))]
    public partial interface IHyperVToAzStackHciprotectedItemModelCustomPropertiesUpdate

    {

    }
}