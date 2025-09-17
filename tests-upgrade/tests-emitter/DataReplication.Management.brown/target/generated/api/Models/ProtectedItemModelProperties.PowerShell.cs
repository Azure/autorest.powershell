// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    /// <summary>Protected item model properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProtectedItemModelPropertiesTypeConverter))]
    public partial class ProtectedItemModelProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProtectedItemModelProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProtectedItemModelProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProtectedItemModelProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProtectedItemModelProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProtectedItemModelProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CurrentJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("CurrentJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedEnableProtectionJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedEnableProtectionJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedPlannedFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedPlannedFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastTestFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastTestFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationExtensionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationExtensionName = (string) content.GetValueForProperty("ReplicationExtensionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationExtensionName, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CorrelationId = (string) content.GetValueForProperty("CorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionStateDescription = (string) content.GetValueForProperty("ProtectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverState = (string) content.GetValueForProperty("TestFailoverState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverState, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverStateDescription = (string) content.GetValueForProperty("TestFailoverStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("ResynchronizationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResynchronizationState = (string) content.GetValueForProperty("ResynchronizationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResynchronizationState, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectName = (string) content.GetValueForProperty("FabricObjectName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).SourceFabricProviderId = (string) content.GetValueForProperty("SourceFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).SourceFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricProviderId = (string) content.GetValueForProperty("TargetFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricId = (string) content.GetValueForProperty("FabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricId = (string) content.GetValueForProperty("TargetFabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricAgentId = (string) content.GetValueForProperty("FabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricAgentId = (string) content.GetValueForProperty("TargetFabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("ResyncRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResyncRequired = (bool?) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastSuccessfulPlannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulPlannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulPlannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulPlannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulUnplannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulUnplannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulUnplannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulUnplannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulTestFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulTestFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulTestFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulTestFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AllowedJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).AllowedJob = (System.Collections.Generic.List<string>) content.GetValueForProperty("AllowedJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).AllowedJob, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ReplicationHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationHealth = (string) content.GetValueForProperty("ReplicationHealth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationHealth, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).HealthError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("CurrentJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobScenarioName = (string) content.GetValueForProperty("CurrentJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobId = (string) content.GetValueForProperty("CurrentJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobId, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobName = (string) content.GetValueForProperty("CurrentJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobDisplayName = (string) content.GetValueForProperty("CurrentJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobState = (string) content.GetValueForProperty("CurrentJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobEndTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobScenarioName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobId = (string) content.GetValueForProperty("LastFailedEnableProtectionJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobDisplayName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobState = (string) content.GetValueForProperty("LastFailedEnableProtectionJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobScenarioName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobId = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobDisplayName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobState = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobScenarioName = (string) content.GetValueForProperty("LastTestFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobId = (string) content.GetValueForProperty("LastTestFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobName = (string) content.GetValueForProperty("LastTestFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobDisplayName = (string) content.GetValueForProperty("LastTestFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobState = (string) content.GetValueForProperty("LastTestFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProtectedItemModelProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CurrentJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("CurrentJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedEnableProtectionJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedEnableProtectionJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastFailedPlannedFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastFailedPlannedFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastTestFailoverJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJob = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties) content.GetValueForProperty("LastTestFailoverJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJob, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationExtensionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationExtensionName = (string) content.GetValueForProperty("ReplicationExtensionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationExtensionName, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CorrelationId = (string) content.GetValueForProperty("CorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionState = (string) content.GetValueForProperty("ProtectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionState, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionStateDescription = (string) content.GetValueForProperty("ProtectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ProtectionStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverState = (string) content.GetValueForProperty("TestFailoverState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverState, global::System.Convert.ToString);
            }
            if (content.Contains("TestFailoverStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverStateDescription = (string) content.GetValueForProperty("TestFailoverStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TestFailoverStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("ResynchronizationState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResynchronizationState = (string) content.GetValueForProperty("ResynchronizationState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResynchronizationState, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectId = (string) content.GetValueForProperty("FabricObjectId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricObjectName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectName = (string) content.GetValueForProperty("FabricObjectName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricObjectName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).SourceFabricProviderId = (string) content.GetValueForProperty("SourceFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).SourceFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricProviderId = (string) content.GetValueForProperty("TargetFabricProviderId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricId = (string) content.GetValueForProperty("FabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricId = (string) content.GetValueForProperty("TargetFabricId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricId, global::System.Convert.ToString);
            }
            if (content.Contains("FabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricAgentId = (string) content.GetValueForProperty("FabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).FabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetFabricAgentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricAgentId = (string) content.GetValueForProperty("TargetFabricAgentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).TargetFabricAgentId, global::System.Convert.ToString);
            }
            if (content.Contains("ResyncRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResyncRequired = (bool?) content.GetValueForProperty("ResyncRequired",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ResyncRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastSuccessfulPlannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulPlannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulPlannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulPlannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulUnplannedFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulUnplannedFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulUnplannedFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulUnplannedFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastSuccessfulTestFailoverTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulTestFailoverTime = (global::System.DateTime?) content.GetValueForProperty("LastSuccessfulTestFailoverTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastSuccessfulTestFailoverTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AllowedJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).AllowedJob = (System.Collections.Generic.List<string>) content.GetValueForProperty("AllowedJob",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).AllowedJob, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ReplicationHealth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationHealth = (string) content.GetValueForProperty("ReplicationHealth",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).ReplicationHealth, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).HealthError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).HealthError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("CurrentJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobScenarioName = (string) content.GetValueForProperty("CurrentJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobId = (string) content.GetValueForProperty("CurrentJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobId, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobName = (string) content.GetValueForProperty("CurrentJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobDisplayName = (string) content.GetValueForProperty("CurrentJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobState = (string) content.GetValueForProperty("CurrentJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobState, global::System.Convert.ToString);
            }
            if (content.Contains("CurrentJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobStartTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CurrentJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobEndTime = (global::System.DateTime?) content.GetValueForProperty("CurrentJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CurrentJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobScenarioName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobId = (string) content.GetValueForProperty("LastFailedEnableProtectionJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobDisplayName = (string) content.GetValueForProperty("LastFailedEnableProtectionJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobState = (string) content.GetValueForProperty("LastFailedEnableProtectionJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedEnableProtectionJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedEnableProtectionJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedEnableProtectionJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedEnableProtectionJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobScenarioName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobId = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobDisplayName = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobState = (string) content.GetValueForProperty("LastFailedPlannedFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastFailedPlannedFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastFailedPlannedFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastFailedPlannedFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastFailedPlannedFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobScenarioName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobScenarioName = (string) content.GetValueForProperty("LastTestFailoverJobScenarioName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobScenarioName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobId = (string) content.GetValueForProperty("LastTestFailoverJobId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobId, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobName = (string) content.GetValueForProperty("LastTestFailoverJobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobDisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobDisplayName = (string) content.GetValueForProperty("LastTestFailoverJobDisplayName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobState = (string) content.GetValueForProperty("LastTestFailoverJobState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobState, global::System.Convert.ToString);
            }
            if (content.Contains("LastTestFailoverJobStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobStartTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobStartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastTestFailoverJobEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobEndTime = (global::System.DateTime?) content.GetValueForProperty("LastTestFailoverJobEndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).LastTestFailoverJobEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
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
    /// Protected item model properties.
    [System.ComponentModel.TypeConverter(typeof(ProtectedItemModelPropertiesTypeConverter))]
    public partial interface IProtectedItemModelProperties

    {

    }
}