// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(RecoveryServicesDataReplicationIdentityTypeConverter))]
    public partial class RecoveryServicesDataReplicationIdentity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentity"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryServicesDataReplicationIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentity"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryServicesDataReplicationIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryServicesDataReplicationIdentity" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="RecoveryServicesDataReplicationIdentity" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryServicesDataReplicationIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("VaultName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).VaultName = (string) content.GetValueForProperty("VaultName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).VaultName, global::System.Convert.ToString);
            }
            if (content.Contains("EmailConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EmailConfigurationName = (string) content.GetValueForProperty("EmailConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EmailConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("EventName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EventName = (string) content.GetValueForProperty("EventName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EventName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricName = (string) content.GetValueForProperty("FabricName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricAgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricAgentName = (string) content.GetValueForProperty("FabricAgentName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricAgentName, global::System.Convert.ToString);
            }
            if (content.Contains("JobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).JobName = (string) content.GetValueForProperty("JobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).JobName, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnectionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionName = (string) content.GetValueForProperty("PrivateEndpointConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnectionProxyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionProxyName = (string) content.GetValueForProperty("PrivateEndpointConnectionProxyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionProxyName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateLinkResourceName = (string) content.GetValueForProperty("PrivateLinkResourceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateLinkResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectedItemName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ProtectedItemName = (string) content.GetValueForProperty("ProtectedItemName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ProtectedItemName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).RecoveryPointName = (string) content.GetValueForProperty("RecoveryPointName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).RecoveryPointName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationExtensionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ReplicationExtensionName = (string) content.GetValueForProperty("ReplicationExtensionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ReplicationExtensionName, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).DeploymentId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RecoveryServicesDataReplicationIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryServicesDataReplicationIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("VaultName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).VaultName = (string) content.GetValueForProperty("VaultName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).VaultName, global::System.Convert.ToString);
            }
            if (content.Contains("EmailConfigurationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EmailConfigurationName = (string) content.GetValueForProperty("EmailConfigurationName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EmailConfigurationName, global::System.Convert.ToString);
            }
            if (content.Contains("EventName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EventName = (string) content.GetValueForProperty("EventName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).EventName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricName = (string) content.GetValueForProperty("FabricName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricName, global::System.Convert.ToString);
            }
            if (content.Contains("FabricAgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricAgentName = (string) content.GetValueForProperty("FabricAgentName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).FabricAgentName, global::System.Convert.ToString);
            }
            if (content.Contains("JobName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).JobName = (string) content.GetValueForProperty("JobName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).JobName, global::System.Convert.ToString);
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnectionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionName = (string) content.GetValueForProperty("PrivateEndpointConnectionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpointConnectionProxyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionProxyName = (string) content.GetValueForProperty("PrivateEndpointConnectionProxyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateEndpointConnectionProxyName, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateLinkResourceName = (string) content.GetValueForProperty("PrivateLinkResourceName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).PrivateLinkResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectedItemName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ProtectedItemName = (string) content.GetValueForProperty("ProtectedItemName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ProtectedItemName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).RecoveryPointName = (string) content.GetValueForProperty("RecoveryPointName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).RecoveryPointName, global::System.Convert.ToString);
            }
            if (content.Contains("ReplicationExtensionName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ReplicationExtensionName = (string) content.GetValueForProperty("ReplicationExtensionName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).ReplicationExtensionName, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).DeploymentId = (string) content.GetValueForProperty("DeploymentId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).DeploymentId, global::System.Convert.ToString);
            }
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal)this).Id, global::System.Convert.ToString);
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
    [System.ComponentModel.TypeConverter(typeof(RecoveryServicesDataReplicationIdentityTypeConverter))]
    public partial interface IRecoveryServicesDataReplicationIdentity

    {

    }
}