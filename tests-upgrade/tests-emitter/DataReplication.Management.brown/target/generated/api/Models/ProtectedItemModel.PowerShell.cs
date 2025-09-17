// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>Protected item model.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProtectedItemModelTypeConverter))]
    public partial class ProtectedItemModel
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModel"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProtectedItemModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModel"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProtectedItemModel(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProtectedItemModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProtectedItemModel" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProtectedItemModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ResynchronizationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResynchronizationState = (string) content.GetValueForProperty("ResynchronizationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResynchronizationState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("CurrentJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedEnableProtectionJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedEnableProtectionJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedPlannedFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedPlannedFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastTestFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastTestFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationExtensionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationExtensionName = (string) content.GetValueForProperty("ReplicationExtensionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationExtensionName, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CorrelationId = (string) content.GetValueForProperty("CorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionStateDescription = (string) content.GetValueForProperty("ProtectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverState = (string) content.GetValueForProperty("TestFailoverState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverState, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverStateDescription = (string) content.GetValueForProperty("TestFailoverStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectName = (string) content.GetValueForProperty("FabricObjectName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).SourceFabricProviderId = (string) content.GetValueForProperty("SourceFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).SourceFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricProviderId = (string) content.GetValueForProperty("TargetFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricId = (string) content.GetValueForProperty("FabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricId = (string) content.GetValueForProperty("TargetFabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricAgentId = (string) content.GetValueForProperty("FabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricAgentId = (string) content.GetValueForProperty("TargetFabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("ResyncRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResyncRequired = (bool?) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastSuccessfulPlannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulPlannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulPlannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulPlannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulUnplannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulUnplannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulUnplannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulUnplannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulTestFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulTestFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulTestFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulTestFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AllowedJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).AllowedJob = (System.Collections.Generic.List<string>) content.GetValueForProperty("AllowedJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).AllowedJob, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ReplicationHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationHealth = (string) content.GetValueForProperty("ReplicationHealth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationHealth, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).HealthError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).HealthError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("CurrentJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobScenarioName = (string) content.GetValueForProperty("CurrentJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobId = (string) content.GetValueForProperty("CurrentJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobId, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobName = (string) content.GetValueForProperty("CurrentJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobDisplayName = (string) content.GetValueForProperty("CurrentJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobState = (string) content.GetValueForProperty("CurrentJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobEndTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobScenarioName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobId = (string) content.GetValueForProperty("LastFailedEnableProtectionJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobDisplayName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobState = (string) content.GetValueForProperty("LastFailedEnableProtectionJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobScenarioName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobId = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobDisplayName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobState = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobScenarioName = (string) content.GetValueForProperty("LastTestFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobId = (string) content.GetValueForProperty("LastTestFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobName = (string) content.GetValueForProperty("LastTestFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobDisplayName = (string) content.GetValueForProperty("LastTestFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobState = (string) content.GetValueForProperty("LastTestFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProtectedItemModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ResynchronizationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResynchronizationState = (string) content.GetValueForProperty("ResynchronizationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResynchronizationState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("CurrentJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedEnableProtectionJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedEnableProtectionJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedPlannedFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedPlannedFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastTestFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastTestFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationExtensionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationExtensionName = (string) content.GetValueForProperty("ReplicationExtensionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationExtensionName, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CorrelationId = (string) content.GetValueForProperty("CorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionStateDescription = (string) content.GetValueForProperty("ProtectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ProtectionStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverState = (string) content.GetValueForProperty("TestFailoverState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverState, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverStateDescription = (string) content.GetValueForProperty("TestFailoverStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TestFailoverStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectName = (string) content.GetValueForProperty("FabricObjectName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricObjectName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).SourceFabricProviderId = (string) content.GetValueForProperty("SourceFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).SourceFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricProviderId = (string) content.GetValueForProperty("TargetFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricId = (string) content.GetValueForProperty("FabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricId = (string) content.GetValueForProperty("TargetFabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricAgentId = (string) content.GetValueForProperty("FabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).FabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricAgentId = (string) content.GetValueForProperty("TargetFabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).TargetFabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("ResyncRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResyncRequired = (bool?) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastSuccessfulPlannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulPlannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulPlannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulPlannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulUnplannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulUnplannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulUnplannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulUnplannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulTestFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulTestFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulTestFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastSuccessfulTestFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AllowedJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).AllowedJob = (System.Collections.Generic.List<string>) content.GetValueForProperty("AllowedJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).AllowedJob, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ReplicationHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationHealth = (string) content.GetValueForProperty("ReplicationHealth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).ReplicationHealth, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).HealthError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).HealthError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("CurrentJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobScenarioName = (string) content.GetValueForProperty("CurrentJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobId = (string) content.GetValueForProperty("CurrentJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobId, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobName = (string) content.GetValueForProperty("CurrentJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobDisplayName = (string) content.GetValueForProperty("CurrentJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobState = (string) content.GetValueForProperty("CurrentJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobEndTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CurrentJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobScenarioName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobId = (string) content.GetValueForProperty("LastFailedEnableProtectionJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobDisplayName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobState = (string) content.GetValueForProperty("LastFailedEnableProtectionJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedEnableProtectionJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobScenarioName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobId = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobDisplayName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobState = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastFailedPlannedFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobScenarioName = (string) content.GetValueForProperty("LastTestFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobId = (string) content.GetValueForProperty("LastTestFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobName = (string) content.GetValueForProperty("LastTestFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobDisplayName = (string) content.GetValueForProperty("LastTestFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobState = (string) content.GetValueForProperty("LastTestFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).LastTestFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
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
    /// Protected item model.
    [System.ComponentModel.TypeConverter(typeof(ProtectedItemModelTypeConverter))]
    public partial interface IProtectedItemModel

    {

    }
}