// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>The application resource properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationResourcePropertiesTypeConverter))]
    public partial class ApplicationResourceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UpgradePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy) content.GetValueForProperty("UpgradePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ManagedIdentity = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>) content.GetValueForProperty("ManagedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ManagedIdentity, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUserAssignedIdentityTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyApplicationHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyApplicationHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy) content.GetValueForProperty("UpgradePolicyApplicationHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyApplicationHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyRollingUpgradeMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy) content.GetValueForProperty("UpgradePolicyRollingUpgradeMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyForceRestart = (bool?) content.GetValueForProperty("UpgradePolicyForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradePolicyInstanceCloseDelayDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyInstanceCloseDelayDuration = (long?) content.GetValueForProperty("UpgradePolicyInstanceCloseDelayDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyInstanceCloseDelayDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyUpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeMode = (string) content.GetValueForProperty("UpgradePolicyUpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradePolicyUpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout = (long?) content.GetValueForProperty("UpgradePolicyUpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyRecreateApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRecreateApplication = (bool?) content.GetValueForProperty("UpgradePolicyRecreateApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRecreateApplication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyFailureAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyFailureAction = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyFailureAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyFailureAction, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationHealthPolicyConsiderWarningAsError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyConsiderWarningAsError = (bool?) content.GetValueForProperty("ApplicationHealthPolicyConsiderWarningAsError",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyConsiderWarningAsError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = (int?) content.GetValueForProperty("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationHealthPolicyServiceTypeHealthPolicyMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) content.GetValueForProperty("ApplicationHealthPolicyServiceTypeHealthPolicyMap",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UpgradePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy) content.GetValueForProperty("UpgradePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ManagedIdentity = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>) content.GetValueForProperty("ManagedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ManagedIdentity, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUserAssignedIdentityTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyApplicationHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyApplicationHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy) content.GetValueForProperty("UpgradePolicyApplicationHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyApplicationHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyRollingUpgradeMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy) content.GetValueForProperty("UpgradePolicyRollingUpgradeMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyForceRestart = (bool?) content.GetValueForProperty("UpgradePolicyForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradePolicyInstanceCloseDelayDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyInstanceCloseDelayDuration = (long?) content.GetValueForProperty("UpgradePolicyInstanceCloseDelayDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyInstanceCloseDelayDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyUpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeMode = (string) content.GetValueForProperty("UpgradePolicyUpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradePolicyUpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout = (long?) content.GetValueForProperty("UpgradePolicyUpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyRecreateApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRecreateApplication = (bool?) content.GetValueForProperty("UpgradePolicyRecreateApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).UpgradePolicyRecreateApplication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyFailureAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyFailureAction = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyFailureAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyFailureAction, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationHealthPolicyConsiderWarningAsError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyConsiderWarningAsError = (bool?) content.GetValueForProperty("ApplicationHealthPolicyConsiderWarningAsError",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyConsiderWarningAsError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = (int?) content.GetValueForProperty("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationHealthPolicyServiceTypeHealthPolicyMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) content.GetValueForProperty("ApplicationHealthPolicyServiceTypeHealthPolicyMap",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationResourceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationResourceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ApplicationResourceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The application resource properties.
    [System.ComponentModel.TypeConverter(typeof(ApplicationResourcePropertiesTypeConverter))]
    public partial interface IApplicationResourceProperties

    {

    }
}