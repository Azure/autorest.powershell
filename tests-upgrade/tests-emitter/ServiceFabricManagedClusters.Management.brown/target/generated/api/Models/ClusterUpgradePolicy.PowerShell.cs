// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>Describes the policy used when upgrading the cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ClusterUpgradePolicyTypeConverter))]
    public partial class ClusterUpgradePolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ClusterUpgradePolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy) content.GetValueForProperty("HealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeltaHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy) content.GetValueForProperty("DeltaHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradeDeltaHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy) content.GetValueForProperty("MonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).ForceRestart = (bool?) content.GetValueForProperty("ForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).ForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout = (string) content.GetValueForProperty("UpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyNode = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyApplication = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ClusterUpgradePolicy(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("HealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy) content.GetValueForProperty("HealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeltaHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy) content.GetValueForProperty("DeltaHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradeDeltaHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("MonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy) content.GetValueForProperty("MonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).ForceRestart = (bool?) content.GetValueForProperty("ForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).ForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout = (string) content.GetValueForProperty("UpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyNode = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyApplication = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).HealthPolicyMaxPercentUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicyInternal)this).MonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ClusterUpgradePolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ClusterUpgradePolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ClusterUpgradePolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ClusterUpgradePolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Describes the policy used when upgrading the cluster.
    [System.ComponentModel.TypeConverter(typeof(ClusterUpgradePolicyTypeConverter))]
    public partial interface IClusterUpgradePolicy

    {

    }
}