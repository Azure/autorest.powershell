// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>The application resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationResourceTypeConverter))]
    public partial class ApplicationResource
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationResource(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy) content.GetValueForProperty("UpgradePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ManagedIdentity = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>) content.GetValueForProperty("ManagedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ManagedIdentity, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUserAssignedIdentityTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyApplicationHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyApplicationHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy) content.GetValueForProperty("UpgradePolicyApplicationHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyApplicationHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyRollingUpgradeMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy) content.GetValueForProperty("UpgradePolicyRollingUpgradeMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyForceRestart = (bool?) content.GetValueForProperty("UpgradePolicyForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradePolicyInstanceCloseDelayDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyInstanceCloseDelayDuration = (long?) content.GetValueForProperty("UpgradePolicyInstanceCloseDelayDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyInstanceCloseDelayDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyUpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeMode = (string) content.GetValueForProperty("UpgradePolicyUpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradePolicyUpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout = (long?) content.GetValueForProperty("UpgradePolicyUpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyRecreateApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRecreateApplication = (bool?) content.GetValueForProperty("UpgradePolicyRecreateApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRecreateApplication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyFailureAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyFailureAction = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyFailureAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyFailureAction, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationHealthPolicyConsiderWarningAsError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyConsiderWarningAsError = (bool?) content.GetValueForProperty("ApplicationHealthPolicyConsiderWarningAsError",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyConsiderWarningAsError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = (int?) content.GetValueForProperty("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationHealthPolicyServiceTypeHealthPolicyMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) content.GetValueForProperty("ApplicationHealthPolicyServiceTypeHealthPolicyMap",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationResource(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradePolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUpgradePolicy) content.GetValueForProperty("UpgradePolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUpgradePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ManagedIdentity = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>) content.GetValueForProperty("ManagedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ManagedIdentity, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationUserAssignedIdentityTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResourcePropertiesParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyApplicationHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyApplicationHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicy) content.GetValueForProperty("UpgradePolicyApplicationHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyApplicationHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyRollingUpgradeMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IRollingUpgradeMonitoringPolicy) content.GetValueForProperty("UpgradePolicyRollingUpgradeMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRollingUpgradeMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.RollingUpgradeMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradePolicyForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyForceRestart = (bool?) content.GetValueForProperty("UpgradePolicyForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradePolicyInstanceCloseDelayDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyInstanceCloseDelayDuration = (long?) content.GetValueForProperty("UpgradePolicyInstanceCloseDelayDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyInstanceCloseDelayDuration, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyUpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeMode = (string) content.GetValueForProperty("UpgradePolicyUpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradePolicyUpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout = (long?) content.GetValueForProperty("UpgradePolicyUpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyUpgradeReplicaSetCheckTimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UpgradePolicyRecreateApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRecreateApplication = (bool?) content.GetValueForProperty("UpgradePolicyRecreateApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).UpgradePolicyRecreateApplication, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyFailureAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyFailureAction = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyFailureAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyFailureAction, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy) content.GetValueForProperty("ApplicationHealthPolicyDefaultServiceTypeHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyDefaultServiceTypeHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceTypeHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationHealthPolicyConsiderWarningAsError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyConsiderWarningAsError = (bool?) content.GetValueForProperty("ApplicationHealthPolicyConsiderWarningAsError",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyConsiderWarningAsError, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication = (int?) content.GetValueForProperty("ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyMaxPercentUnhealthyDeployedApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationHealthPolicyServiceTypeHealthPolicyMap"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap) content.GetValueForProperty("ApplicationHealthPolicyServiceTypeHealthPolicyMap",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).ApplicationHealthPolicyServiceTypeHealthPolicyMap, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationHealthPolicyServiceTypeHealthPolicyMapTypeConverter.ConvertFrom);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("RollingUpgradeMonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).RollingUpgradeMonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyPartitionsPerService, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition = (int?) content.GetValueForProperty("DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourceInternal)this).DefaultServiceTypeHealthPolicyMaxPercentUnhealthyReplicasPerPartition, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ApplicationResource" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The application resource.
    [System.ComponentModel.TypeConverter(typeof(ApplicationResourceTypeConverter))]
    public partial interface IApplicationResource

    {

    }
}