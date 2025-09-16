// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>Describes the managed cluster resource properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterPropertiesTypeConverter))]
    public partial class ManagedClusterProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedClusterProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AzureActiveDirectory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectory = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory) content.GetValueForProperty("AzureActiveDirectory",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectory, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AzureActiveDirectoryTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationTypeVersionsCleanupPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionsCleanupPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy) content.GetValueForProperty("ApplicationTypeVersionsCleanupPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionsCleanupPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationTypeVersionsCleanupPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescription = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy) content.GetValueForProperty("UpgradeDescription",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescription, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DnsName = (string) content.GetValueForProperty("DnsName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DnsName, global::System.Convert.ToString);
            }
            if (content.Contains("Fqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Fqdn, global::System.Convert.ToString);
            }
            if (content.Contains("Ipv4Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv4Address = (string) content.GetValueForProperty("Ipv4Address",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv4Address, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterId = (string) content.GetValueForProperty("ClusterId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterId, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterState = (string) content.GetValueForProperty("ClusterState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterState, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterCertificateThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCertificateThumbprint = (System.Collections.Generic.List<string>) content.GetValueForProperty("ClusterCertificateThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCertificateThumbprint, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ClientConnectionPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClientConnectionPort = (int?) content.GetValueForProperty("ClientConnectionPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClientConnectionPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HttpGatewayConnectionPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayConnectionPort = (int?) content.GetValueForProperty("HttpGatewayConnectionPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayConnectionPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AdminUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminUserName = (string) content.GetValueForProperty("AdminUserName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminUserName, global::System.Convert.ToString);
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminPassword = (System.Security.SecureString) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("LoadBalancingRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).LoadBalancingRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule>) content.GetValueForProperty("LoadBalancingRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).LoadBalancingRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.LoadBalancingRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("AllowRdpAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllowRdpAccess = (bool?) content.GetValueForProperty("AllowRdpAccess",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllowRdpAccess, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NetworkSecurityRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).NetworkSecurityRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>) content.GetValueForProperty("NetworkSecurityRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).NetworkSecurityRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NetworkSecurityRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("Client"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Client = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate>) content.GetValueForProperty("Client",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Client, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClientCertificateTypeConverter.ConvertFrom));
            }
            if (content.Contains("FabricSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).FabricSetting = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription>) content.GetValueForProperty("FabricSetting",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).FabricSetting, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SettingsSectionDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterCodeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCodeVersion = (string) content.GetValueForProperty("ClusterCodeVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCodeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterUpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeMode = (string) content.GetValueForProperty("ClusterUpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterUpgradeCadence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeCadence = (string) content.GetValueForProperty("ClusterUpgradeCadence",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeCadence, global::System.Convert.ToString);
            }
            if (content.Contains("AddonFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AddonFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("AddonFeature",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AddonFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EnableAutoOSUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableAutoOSUpgrade = (bool?) content.GetValueForProperty("EnableAutoOSUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableAutoOSUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ZonalResiliency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalResiliency = (bool?) content.GetValueForProperty("ZonalResiliency",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalResiliency, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableIpv6"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableIpv6 = (bool?) content.GetValueForProperty("EnableIpv6",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableIpv6, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("IPTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).IPTag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>) content.GetValueForProperty("IPTag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).IPTag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("Ipv6Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv6Address = (string) content.GetValueForProperty("Ipv6Address",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv6Address, global::System.Convert.ToString);
            }
            if (content.Contains("EnableServicePublicIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableServicePublicIP = (bool?) content.GetValueForProperty("EnableServicePublicIP",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableServicePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AuxiliarySubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AuxiliarySubnet = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet>) content.GetValueForProperty("AuxiliarySubnet",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AuxiliarySubnet, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ServiceEndpoint = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint>) content.GetValueForProperty("ServiceEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ServiceEndpoint, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceEndpointTypeConverter.ConvertFrom));
            }
            if (content.Contains("ZonalUpdateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalUpdateMode = (string) content.GetValueForProperty("ZonalUpdateMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalUpdateMode, global::System.Convert.ToString);
            }
            if (content.Contains("UseCustomVnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UseCustomVnet = (bool?) content.GetValueForProperty("UseCustomVnet",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UseCustomVnet, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PublicIPPrefixId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPPrefixId = (string) content.GetValueForProperty("PublicIPPrefixId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPPrefixId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPv6PrefixId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPv6PrefixId = (string) content.GetValueForProperty("PublicIPv6PrefixId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPv6PrefixId, global::System.Convert.ToString);
            }
            if (content.Contains("DdosProtectionPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DdosProtectionPlanId = (string) content.GetValueForProperty("DdosProtectionPlanId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DdosProtectionPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGatewayTokenAuthConnectionPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayTokenAuthConnectionPort = (int?) content.GetValueForProperty("HttpGatewayTokenAuthConnectionPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayTokenAuthConnectionPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EnableHttpGatewayExclusiveAuthMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableHttpGatewayExclusiveAuthMode = (bool?) content.GetValueForProperty("EnableHttpGatewayExclusiveAuthMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableHttpGatewayExclusiveAuthMode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoGeneratedDomainNameLabelScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AutoGeneratedDomainNameLabelScope = (string) content.GetValueForProperty("AutoGeneratedDomainNameLabelScope",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AutoGeneratedDomainNameLabelScope, global::System.Convert.ToString);
            }
            if (content.Contains("AllocatedOutboundPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllocatedOutboundPort = (int?) content.GetValueForProperty("AllocatedOutboundPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllocatedOutboundPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VMImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).VMImage = (string) content.GetValueForProperty("VMImage",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).VMImage, global::System.Convert.ToString);
            }
            if (content.Contains("EnableOutboundOnlyNodeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableOutboundOnlyNodeType = (bool?) content.GetValueForProperty("EnableOutboundOnlyNodeType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableOutboundOnlyNodeType, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AzureActiveDirectoryTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryTenantId = (string) content.GetValueForProperty("AzureActiveDirectoryTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureActiveDirectoryClusterApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClusterApplication = (string) content.GetValueForProperty("AzureActiveDirectoryClusterApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClusterApplication, global::System.Convert.ToString);
            }
            if (content.Contains("AzureActiveDirectoryClientApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClientApplication = (string) content.GetValueForProperty("AzureActiveDirectoryClientApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClientApplication, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep = (int?) content.GetValueForProperty("ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("UpgradeDescriptionHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy) content.GetValueForProperty("UpgradeDescriptionHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescriptionDeltaHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionDeltaHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy) content.GetValueForProperty("UpgradeDescriptionDeltaHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionDeltaHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradeDeltaHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescriptionMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy) content.GetValueForProperty("UpgradeDescriptionMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescriptionForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionForceRestart = (bool?) content.GetValueForProperty("UpgradeDescriptionForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradeDescriptionUpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionUpgradeReplicaSetCheckTimeout = (string) content.GetValueForProperty("UpgradeDescriptionUpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionUpgradeReplicaSetCheckTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyNode = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyApplication = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ManagedClusterProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AzureActiveDirectory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectory = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory) content.GetValueForProperty("AzureActiveDirectory",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectory, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AzureActiveDirectoryTypeConverter.ConvertFrom);
            }
            if (content.Contains("ApplicationTypeVersionsCleanupPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionsCleanupPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationTypeVersionsCleanupPolicy) content.GetValueForProperty("ApplicationTypeVersionsCleanupPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionsCleanupPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationTypeVersionsCleanupPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescription = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradePolicy) content.GetValueForProperty("UpgradeDescription",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescription, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DnsName = (string) content.GetValueForProperty("DnsName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DnsName, global::System.Convert.ToString);
            }
            if (content.Contains("Fqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Fqdn = (string) content.GetValueForProperty("Fqdn",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Fqdn, global::System.Convert.ToString);
            }
            if (content.Contains("Ipv4Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv4Address = (string) content.GetValueForProperty("Ipv4Address",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv4Address, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterId = (string) content.GetValueForProperty("ClusterId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterId, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterState = (string) content.GetValueForProperty("ClusterState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterState, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterCertificateThumbprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCertificateThumbprint = (System.Collections.Generic.List<string>) content.GetValueForProperty("ClusterCertificateThumbprint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCertificateThumbprint, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ClientConnectionPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClientConnectionPort = (int?) content.GetValueForProperty("ClientConnectionPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClientConnectionPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HttpGatewayConnectionPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayConnectionPort = (int?) content.GetValueForProperty("HttpGatewayConnectionPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayConnectionPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AdminUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminUserName = (string) content.GetValueForProperty("AdminUserName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminUserName, global::System.Convert.ToString);
            }
            if (content.Contains("AdminPassword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminPassword = (System.Security.SecureString) content.GetValueForProperty("AdminPassword",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AdminPassword, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("LoadBalancingRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).LoadBalancingRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule>) content.GetValueForProperty("LoadBalancingRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).LoadBalancingRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.LoadBalancingRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("AllowRdpAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllowRdpAccess = (bool?) content.GetValueForProperty("AllowRdpAccess",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllowRdpAccess, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NetworkSecurityRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).NetworkSecurityRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>) content.GetValueForProperty("NetworkSecurityRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).NetworkSecurityRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NetworkSecurityRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("Client"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Client = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate>) content.GetValueForProperty("Client",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Client, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClientCertificateTypeConverter.ConvertFrom));
            }
            if (content.Contains("FabricSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).FabricSetting = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription>) content.GetValueForProperty("FabricSetting",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).FabricSetting, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SettingsSectionDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterCodeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCodeVersion = (string) content.GetValueForProperty("ClusterCodeVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterCodeVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterUpgradeMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeMode = (string) content.GetValueForProperty("ClusterUpgradeMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeMode, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterUpgradeCadence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeCadence = (string) content.GetValueForProperty("ClusterUpgradeCadence",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ClusterUpgradeCadence, global::System.Convert.ToString);
            }
            if (content.Contains("AddonFeature"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AddonFeature = (System.Collections.Generic.List<string>) content.GetValueForProperty("AddonFeature",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AddonFeature, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EnableAutoOSUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableAutoOSUpgrade = (bool?) content.GetValueForProperty("EnableAutoOSUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableAutoOSUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ZonalResiliency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalResiliency = (bool?) content.GetValueForProperty("ZonalResiliency",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalResiliency, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableIpv6"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableIpv6 = (bool?) content.GetValueForProperty("EnableIpv6",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableIpv6, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("IPTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).IPTag = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>) content.GetValueForProperty("IPTag",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).IPTag, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPTagTypeConverter.ConvertFrom));
            }
            if (content.Contains("Ipv6Address"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv6Address = (string) content.GetValueForProperty("Ipv6Address",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).Ipv6Address, global::System.Convert.ToString);
            }
            if (content.Contains("EnableServicePublicIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableServicePublicIP = (bool?) content.GetValueForProperty("EnableServicePublicIP",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableServicePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AuxiliarySubnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AuxiliarySubnet = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet>) content.GetValueForProperty("AuxiliarySubnet",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AuxiliarySubnet, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubnetTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ServiceEndpoint = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint>) content.GetValueForProperty("ServiceEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ServiceEndpoint, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceEndpointTypeConverter.ConvertFrom));
            }
            if (content.Contains("ZonalUpdateMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalUpdateMode = (string) content.GetValueForProperty("ZonalUpdateMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ZonalUpdateMode, global::System.Convert.ToString);
            }
            if (content.Contains("UseCustomVnet"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UseCustomVnet = (bool?) content.GetValueForProperty("UseCustomVnet",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UseCustomVnet, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PublicIPPrefixId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPPrefixId = (string) content.GetValueForProperty("PublicIPPrefixId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPPrefixId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicIPv6PrefixId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPv6PrefixId = (string) content.GetValueForProperty("PublicIPv6PrefixId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).PublicIPv6PrefixId, global::System.Convert.ToString);
            }
            if (content.Contains("DdosProtectionPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DdosProtectionPlanId = (string) content.GetValueForProperty("DdosProtectionPlanId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DdosProtectionPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("HttpGatewayTokenAuthConnectionPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayTokenAuthConnectionPort = (int?) content.GetValueForProperty("HttpGatewayTokenAuthConnectionPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HttpGatewayTokenAuthConnectionPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EnableHttpGatewayExclusiveAuthMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableHttpGatewayExclusiveAuthMode = (bool?) content.GetValueForProperty("EnableHttpGatewayExclusiveAuthMode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableHttpGatewayExclusiveAuthMode, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoGeneratedDomainNameLabelScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AutoGeneratedDomainNameLabelScope = (string) content.GetValueForProperty("AutoGeneratedDomainNameLabelScope",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AutoGeneratedDomainNameLabelScope, global::System.Convert.ToString);
            }
            if (content.Contains("AllocatedOutboundPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllocatedOutboundPort = (int?) content.GetValueForProperty("AllocatedOutboundPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AllocatedOutboundPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VMImage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).VMImage = (string) content.GetValueForProperty("VMImage",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).VMImage, global::System.Convert.ToString);
            }
            if (content.Contains("EnableOutboundOnlyNodeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableOutboundOnlyNodeType = (bool?) content.GetValueForProperty("EnableOutboundOnlyNodeType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).EnableOutboundOnlyNodeType, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AzureActiveDirectoryTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryTenantId = (string) content.GetValueForProperty("AzureActiveDirectoryTenantId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureActiveDirectoryClusterApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClusterApplication = (string) content.GetValueForProperty("AzureActiveDirectoryClusterApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClusterApplication, global::System.Convert.ToString);
            }
            if (content.Contains("AzureActiveDirectoryClientApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClientApplication = (string) content.GetValueForProperty("AzureActiveDirectoryClientApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).AzureActiveDirectoryClientApplication, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep = (int?) content.GetValueForProperty("ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).ApplicationTypeVersionCleanupPolicyMaxUnusedVersionsToKeep, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("UpgradeDescriptionHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterHealthPolicy) content.GetValueForProperty("UpgradeDescriptionHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescriptionDeltaHealthPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionDeltaHealthPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterUpgradeDeltaHealthPolicy) content.GetValueForProperty("UpgradeDescriptionDeltaHealthPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionDeltaHealthPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradeDeltaHealthPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescriptionMonitoringPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionMonitoringPolicy = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClusterMonitoringPolicy) content.GetValueForProperty("UpgradeDescriptionMonitoringPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionMonitoringPolicy, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterMonitoringPolicyTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeDescriptionForceRestart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionForceRestart = (bool?) content.GetValueForProperty("UpgradeDescriptionForceRestart",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionForceRestart, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UpgradeDescriptionUpgradeReplicaSetCheckTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionUpgradeReplicaSetCheckTimeout = (string) content.GetValueForProperty("UpgradeDescriptionUpgradeReplicaSetCheckTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).UpgradeDescriptionUpgradeReplicaSetCheckTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyNode = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("HealthPolicyMaxPercentUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyApplication = (int?) content.GetValueForProperty("HealthPolicyMaxPercentUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).HealthPolicyMaxPercentUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentUpgradeDomainDeltaUnhealthyNode, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication = (int?) content.GetValueForProperty("DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).DeltaHealthPolicyMaxPercentDeltaUnhealthyApplication, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MonitoringPolicyHealthCheckWaitDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckWaitDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckWaitDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckWaitDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckStableDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckStableDuration = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckStableDuration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckStableDuration, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyHealthCheckRetryTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckRetryTimeout = (string) content.GetValueForProperty("MonitoringPolicyHealthCheckRetryTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyHealthCheckRetryTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringPolicyUpgradeDomainTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeDomainTimeout = (string) content.GetValueForProperty("MonitoringPolicyUpgradeDomainTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterPropertiesInternal)this).MonitoringPolicyUpgradeDomainTimeout, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

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
    /// Describes the managed cluster resource properties.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterPropertiesTypeConverter))]
    public partial interface IManagedClusterProperties

    {

    }
}