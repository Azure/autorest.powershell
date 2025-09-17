// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>HyperV to AzStackHCI Protected item model custom properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(HyperVToAzStackHciprotectedItemModelCustomPropertiesTypeConverter))]
    public partial class HyperVToAzStackHciprotectedItemModelCustomProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HyperVToAzStackHciprotectedItemModelCustomProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HyperVToAzStackHciprotectedItemModelCustomProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HyperVToAzStackHciprotectedItemModelCustomProperties" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="HyperVToAzStackHciprotectedItemModelCustomProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HyperVToAzStackHciprotectedItemModelCustomProperties(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfig = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig) content.GetValueForProperty("DynamicMemoryConfig",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfig, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ActiveLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ActiveLocation = (string) content.GetValueForProperty("ActiveLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ActiveLocation, global::System.Convert.ToString);
            }
            if (content.Contains("TargetHciClusterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetHciClusterId = (string) content.GetValueForProperty("TargetHciClusterId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetHciClusterId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetArcClusterCustomLocationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetArcClusterCustomLocationId = (string) content.GetValueForProperty("TargetArcClusterCustomLocationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetArcClusterCustomLocationId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetAzStackHciClusterName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetAzStackHciClusterName = (string) content.GetValueForProperty("TargetAzStackHciClusterName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetAzStackHciClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricDiscoveryMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FabricDiscoveryMachineId = (string) content.GetValueForProperty("FabricDiscoveryMachineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FabricDiscoveryMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("DisksToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DisksToInclude = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcidiskInput>) content.GetValueForProperty("DisksToInclude",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DisksToInclude, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcidiskInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcidiskInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("NicsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).NicsToInclude = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>) content.GetValueForProperty("NicsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).NicsToInclude, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcinicInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("SourceVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceVMName = (string) content.GetValueForProperty("SourceVMName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceVMName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceCpuCore = (int?) content.GetValueForProperty("SourceCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SourceMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceMemoryInMegaByte = (double?) content.GetValueForProperty("SourceMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceMemoryInMegaByte, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("TargetVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMName = (string) content.GetValueForProperty("TargetVMName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetResourceGroupId = (string) content.GetValueForProperty("TargetResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).StorageContainerId = (string) content.GetValueForProperty("StorageContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).StorageContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("HyperVGeneration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).HyperVGeneration = (string) content.GetValueForProperty("HyperVGeneration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).HyperVGeneration, global::System.Convert.ToString);
            }
            if (content.Contains("TargetNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetNetworkId = (string) content.GetValueForProperty("TargetNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("TestNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TestNetworkId = (string) content.GetValueForProperty("TestNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TestNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetCpuCore = (int?) content.GetValueForProperty("TargetCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsDynamicRam"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).IsDynamicRam = (bool?) content.GetValueForProperty("IsDynamicRam",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).IsDynamicRam, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TargetMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetMemoryInMegaByte = (int?) content.GetValueForProperty("TargetMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetMemoryInMegaByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RunAsAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).RunAsAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceFabricAgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceFabricAgentName = (string) content.GetValueForProperty("SourceFabricAgentName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceFabricAgentName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricAgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetFabricAgentName = (string) content.GetValueForProperty("TargetFabricAgentName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetFabricAgentName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceApplianceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceApplianceName = (string) content.GetValueForProperty("SourceApplianceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceApplianceName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetApplianceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetApplianceName = (string) content.GetValueForProperty("TargetApplianceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetApplianceName, global::System.Convert.ToString);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("OSName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSName = (string) content.GetValueForProperty("OSName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSName, global::System.Convert.ToString);
            }
            if (content.Contains("FirmwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FirmwareType = (string) content.GetValueForProperty("FirmwareType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FirmwareType, global::System.Convert.ToString);
            }
            if (content.Contains("TargetLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetLocation = (string) content.GetValueForProperty("TargetLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetLocation, global::System.Convert.ToString);
            }
            if (content.Contains("CustomLocationRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).CustomLocationRegion = (string) content.GetValueForProperty("CustomLocationRegion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).CustomLocationRegion, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverRecoveryPointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FailoverRecoveryPointId = (string) content.GetValueForProperty("FailoverRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FailoverRecoveryPointId, global::System.Convert.ToString);
            }
            if (content.Contains("LastRecoveryPointReceived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointReceived = (global::System.DateTime?) content.GetValueForProperty("LastRecoveryPointReceived",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointReceived, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastRecoveryPointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointId = (string) content.GetValueForProperty("LastRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointId, global::System.Convert.ToString);
            }
            if (content.Contains("InitialReplicationProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).InitialReplicationProgressPercentage = (int?) content.GetValueForProperty("InitialReplicationProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).InitialReplicationProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ResyncProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ResyncProgressPercentage = (int?) content.GetValueForProperty("ResyncProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ResyncProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ProtectedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedDiskProperties>) content.GetValueForProperty("ProtectedDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedDiskProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedDiskPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectedNic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedNic = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedNicProperties>) content.GetValueForProperty("ProtectedNic",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedNic, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedNicProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedNicPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("TargetVMBiosId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMBiosId = (string) content.GetValueForProperty("TargetVMBiosId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMBiosId, global::System.Convert.ToString);
            }
            if (content.Contains("LastReplicationUpdateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastReplicationUpdateTime = (global::System.DateTime?) content.GetValueForProperty("LastReplicationUpdateTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastReplicationUpdateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("DynamicMemoryConfigMaximumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMaximumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigMinimumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMinimumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigTargetMemoryBufferPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage = (int?) content.GetValueForProperty("DynamicMemoryConfigTargetMemoryBufferPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HyperVToAzStackHciprotectedItemModelCustomProperties(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfig = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig) content.GetValueForProperty("DynamicMemoryConfig",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfig, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ActiveLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ActiveLocation = (string) content.GetValueForProperty("ActiveLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ActiveLocation, global::System.Convert.ToString);
            }
            if (content.Contains("TargetHciClusterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetHciClusterId = (string) content.GetValueForProperty("TargetHciClusterId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetHciClusterId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetArcClusterCustomLocationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetArcClusterCustomLocationId = (string) content.GetValueForProperty("TargetArcClusterCustomLocationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetArcClusterCustomLocationId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetAzStackHciClusterName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetAzStackHciClusterName = (string) content.GetValueForProperty("TargetAzStackHciClusterName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetAzStackHciClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricDiscoveryMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FabricDiscoveryMachineId = (string) content.GetValueForProperty("FabricDiscoveryMachineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FabricDiscoveryMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("DisksToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DisksToInclude = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcidiskInput>) content.GetValueForProperty("DisksToInclude",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DisksToInclude, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcidiskInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcidiskInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("NicsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).NicsToInclude = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>) content.GetValueForProperty("NicsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).NicsToInclude, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcinicInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("SourceVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceVMName = (string) content.GetValueForProperty("SourceVMName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceVMName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceCpuCore = (int?) content.GetValueForProperty("SourceCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SourceMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceMemoryInMegaByte = (double?) content.GetValueForProperty("SourceMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceMemoryInMegaByte, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("TargetVMName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMName = (string) content.GetValueForProperty("TargetVMName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetResourceGroupId = (string) content.GetValueForProperty("TargetResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).StorageContainerId = (string) content.GetValueForProperty("StorageContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).StorageContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("HyperVGeneration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).HyperVGeneration = (string) content.GetValueForProperty("HyperVGeneration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).HyperVGeneration, global::System.Convert.ToString);
            }
            if (content.Contains("TargetNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetNetworkId = (string) content.GetValueForProperty("TargetNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("TestNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TestNetworkId = (string) content.GetValueForProperty("TestNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TestNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetCpuCore = (int?) content.GetValueForProperty("TargetCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsDynamicRam"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).IsDynamicRam = (bool?) content.GetValueForProperty("IsDynamicRam",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).IsDynamicRam, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TargetMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetMemoryInMegaByte = (int?) content.GetValueForProperty("TargetMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetMemoryInMegaByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RunAsAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).RunAsAccountId = (string) content.GetValueForProperty("RunAsAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).RunAsAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceFabricAgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceFabricAgentName = (string) content.GetValueForProperty("SourceFabricAgentName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceFabricAgentName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricAgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetFabricAgentName = (string) content.GetValueForProperty("TargetFabricAgentName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetFabricAgentName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceApplianceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceApplianceName = (string) content.GetValueForProperty("SourceApplianceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).SourceApplianceName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetApplianceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetApplianceName = (string) content.GetValueForProperty("TargetApplianceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetApplianceName, global::System.Convert.ToString);
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("OSName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSName = (string) content.GetValueForProperty("OSName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).OSName, global::System.Convert.ToString);
            }
            if (content.Contains("FirmwareType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FirmwareType = (string) content.GetValueForProperty("FirmwareType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FirmwareType, global::System.Convert.ToString);
            }
            if (content.Contains("TargetLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetLocation = (string) content.GetValueForProperty("TargetLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetLocation, global::System.Convert.ToString);
            }
            if (content.Contains("CustomLocationRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).CustomLocationRegion = (string) content.GetValueForProperty("CustomLocationRegion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).CustomLocationRegion, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverRecoveryPointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FailoverRecoveryPointId = (string) content.GetValueForProperty("FailoverRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).FailoverRecoveryPointId, global::System.Convert.ToString);
            }
            if (content.Contains("LastRecoveryPointReceived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointReceived = (global::System.DateTime?) content.GetValueForProperty("LastRecoveryPointReceived",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointReceived, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastRecoveryPointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointId = (string) content.GetValueForProperty("LastRecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastRecoveryPointId, global::System.Convert.ToString);
            }
            if (content.Contains("InitialReplicationProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).InitialReplicationProgressPercentage = (int?) content.GetValueForProperty("InitialReplicationProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).InitialReplicationProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ResyncProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ResyncProgressPercentage = (int?) content.GetValueForProperty("ResyncProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ResyncProgressPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ProtectedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedDiskProperties>) content.GetValueForProperty("ProtectedDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedDiskProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedDiskPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProtectedNic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedNic = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedNicProperties>) content.GetValueForProperty("ProtectedNic",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).ProtectedNic, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedNicProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedNicPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("TargetVMBiosId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMBiosId = (string) content.GetValueForProperty("TargetVMBiosId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).TargetVMBiosId, global::System.Convert.ToString);
            }
            if (content.Contains("LastReplicationUpdateTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastReplicationUpdateTime = (global::System.DateTime?) content.GetValueForProperty("LastReplicationUpdateTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).LastReplicationUpdateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("DynamicMemoryConfigMaximumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMaximumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMaximumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigMinimumMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte = (long?) content.GetValueForProperty("DynamicMemoryConfigMinimumMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigMinimumMemoryInMegaByte, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DynamicMemoryConfigTargetMemoryBufferPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage = (int?) content.GetValueForProperty("DynamicMemoryConfigTargetMemoryBufferPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomPropertiesInternal)this).DynamicMemoryConfigTargetMemoryBufferPercentage, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
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
    [System.ComponentModel.TypeConverter(typeof(HyperVToAzStackHciprotectedItemModelCustomPropertiesTypeConverter))]
    public partial interface IHyperVToAzStackHciprotectedItemModelCustomProperties

    {

    }
}