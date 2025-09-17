// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>AzStackHCI fabric model custom properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzStackHciFabricModelCustomPropertiesTypeConverter))]
    public partial class AzStackHciFabricModelCustomProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzStackHciFabricModelCustomProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Cluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).Cluster = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties) content.GetValueForProperty("Cluster",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).Cluster, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzStackHciSiteId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).AzStackHciSiteId = (string) content.GetValueForProperty("AzStackHciSiteId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).AzStackHciSiteId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplianceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ApplianceName = (System.Collections.Generic.List<string>) content.GetValueForProperty("ApplianceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ApplianceName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("FabricResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricResourceId = (string) content.GetValueForProperty("FabricResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricContainerId = (string) content.GetValueForProperty("FabricContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationSolutionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationSolutionId = (string) content.GetValueForProperty("MigrationSolutionId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationSolutionId, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationHubUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationHubUri = (string) content.GetValueForProperty("MigrationHubUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationHubUri, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterResourceName = (string) content.GetValueForProperty("ClusterResourceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterStorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageAccountName = (string) content.GetValueForProperty("ClusterStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterStorageContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageContainer = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties>) content.GetValueForProperty("ClusterStorageContainer",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageContainer, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.StorageContainerPropertiesTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzStackHciFabricModelCustomProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Cluster"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).Cluster = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties) content.GetValueForProperty("Cluster",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).Cluster, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciClusterPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzStackHciSiteId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).AzStackHciSiteId = (string) content.GetValueForProperty("AzStackHciSiteId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).AzStackHciSiteId, global::System.Convert.ToString);
            }
            if (content.Contains("ApplianceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ApplianceName = (System.Collections.Generic.List<string>) content.GetValueForProperty("ApplianceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ApplianceName, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("FabricResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricResourceId = (string) content.GetValueForProperty("FabricResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricContainerId = (string) content.GetValueForProperty("FabricContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).FabricContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationSolutionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationSolutionId = (string) content.GetValueForProperty("MigrationSolutionId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationSolutionId, global::System.Convert.ToString);
            }
            if (content.Contains("MigrationHubUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationHubUri = (string) content.GetValueForProperty("MigrationHubUri",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).MigrationHubUri, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)this).InstanceType, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterResourceName = (string) content.GetValueForProperty("ClusterResourceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterStorageAccountName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageAccountName = (string) content.GetValueForProperty("ClusterStorageAccountName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterStorageContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageContainer = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties>) content.GetValueForProperty("ClusterStorageContainer",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal)this).ClusterStorageContainer, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.StorageContainerPropertiesTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzStackHciFabricModelCustomProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciFabricModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzStackHciFabricModelCustomProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzStackHciFabricModelCustomProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AzStackHciFabricModelCustomProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// AzStackHCI fabric model custom properties.
    [System.ComponentModel.TypeConverter(typeof(AzStackHciFabricModelCustomPropertiesTypeConverter))]
    public partial interface IAzStackHciFabricModelCustomProperties

    {

    }
}