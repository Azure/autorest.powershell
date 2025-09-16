// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>Describes the policy for a monitored application upgrade.</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationUpgradePolicyTypeConverter))]
    public partial class ApplicationUpgradePolicy
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationUpgradePolicy(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy) content.GetValueForProperty("RollingUpgradeMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ForceRestart = (bool?) content.GetValueForProperty("ForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("InstanceCloseDelayDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).InstanceCloseDelayDuration = (long?) content.GetValueForProperty("InstanceCloseDelayDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).InstanceCloseDelayDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeMode = (string) content.GetValueForProperty("UpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout = (long?) content.GetValueForProperty("UpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecreateApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RecreateApplication = (bool?) content.GetValueForProperty("RecreateApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RecreateApplication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyFailureAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyFailureAction = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyFailureAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyFailureAction, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationHealthPolicyConsiderWarningAsError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyConsiderWarningAsError = (bool?) content.GetValueForProperty("ApplicationHealthPolicyConsiderWarningAsError",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyConsiderWarningAsError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = (int?) content.GetValueForProperty("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationHealthPolicyServiceTypeHealthPolicyMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) content.GetValueForProperty("ApplicationHealthPolicyServiceTypeHealthPolicyMap",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationUpgradePolicy(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy) content.GetValueForProperty("RollingUpgradeMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ForceRestart = (bool?) content.GetValueForProperty("ForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("InstanceCloseDelayDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).InstanceCloseDelayDuration = (long?) content.GetValueForProperty("InstanceCloseDelayDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).InstanceCloseDelayDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeMode = (string) content.GetValueForProperty("UpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout = (long?) content.GetValueForProperty("UpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).UpgradeReplicaSetCheckTimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecreateApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RecreateApplication = (bool?) content.GetValueForProperty("RecreateApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RecreateApplication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyFailureAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyFailureAction = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyFailureAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyFailureAction, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationHealthPolicyConsiderWarningAsError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyConsiderWarningAsError = (bool?) content.GetValueForProperty("ApplicationHealthPolicyConsiderWarningAsError",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyConsiderWarningAsError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = (int?) content.GetValueForProperty("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationHealthPolicyServiceTypeHealthPolicyMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) content.GetValueForProperty("ApplicationHealthPolicyServiceTypeHealthPolicyMap",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicyInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationUpgradePolicy(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicy"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationUpgradePolicy(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationUpgradePolicy" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ApplicationUpgradePolicy" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Describes the policy for a monitored application upgrade.
    [System.ComponentModel.TypeConverter(typeof(ApplicationUpgradePolicyTypeConverter))]
    public partial interface IApplicationUpgradePolicy

    {

    }
}