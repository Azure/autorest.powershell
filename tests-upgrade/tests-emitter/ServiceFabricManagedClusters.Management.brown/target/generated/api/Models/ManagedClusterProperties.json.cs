// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the managed cluster resource properties.</summary>
    public partial class ManagedClusterProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedClusterProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json ? new ManagedClusterProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject into a new instance of <see cref="ManagedClusterProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ManagedClusterProperties(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_azureActiveDirectory = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("azureActiveDirectory"), out var __jsonAzureActiveDirectory) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AzureActiveDirectory.FromJson(__jsonAzureActiveDirectory) : _azureActiveDirectory;}
            {_applicationTypeVersionsCleanupPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("applicationTypeVersionsCleanupPolicy"), out var __jsonApplicationTypeVersionsCleanupPolicy) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ApplicationTypeVersionsCleanupPolicy.FromJson(__jsonApplicationTypeVersionsCleanupPolicy) : _applicationTypeVersionsCleanupPolicy;}
            {_upgradeDescription = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("upgradeDescription"), out var __jsonUpgradeDescription) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClusterUpgradePolicy.FromJson(__jsonUpgradeDescription) : _upgradeDescription;}
            {_dnsName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("dnsName"), out var __jsonDnsName) ? (string)__jsonDnsName : (string)_dnsName;}
            {_fqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("fqdn"), out var __jsonFqdn) ? (string)__jsonFqdn : (string)_fqdn;}
            {_ipv4Address = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("ipv4Address"), out var __jsonIpv4Address) ? (string)__jsonIpv4Address : (string)_ipv4Address;}
            {_clusterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("clusterId"), out var __jsonClusterId) ? (string)__jsonClusterId : (string)_clusterId;}
            {_clusterState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("clusterState"), out var __jsonClusterState) ? (string)__jsonClusterState : (string)_clusterState;}
            {_clusterCertificateThumbprint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("clusterCertificateThumbprints"), out var __jsonClusterCertificateThumbprints) ? If( __jsonClusterCertificateThumbprints as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _clusterCertificateThumbprint;}
            {_clientConnectionPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("clientConnectionPort"), out var __jsonClientConnectionPort) ? (int?)__jsonClientConnectionPort : _clientConnectionPort;}
            {_httpGatewayConnectionPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("httpGatewayConnectionPort"), out var __jsonHttpGatewayConnectionPort) ? (int?)__jsonHttpGatewayConnectionPort : _httpGatewayConnectionPort;}
            {_adminUserName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("adminUserName"), out var __jsonAdminUserName) ? (string)__jsonAdminUserName : (string)_adminUserName;}
            {_adminPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("adminPassword"), out var __jsonAdminPassword) ? new System.Net.NetworkCredential("",(string)__jsonAdminPassword).SecurePassword : _adminPassword;}
            {_loadBalancingRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("loadBalancingRules"), out var __jsonLoadBalancingRules) ? If( __jsonLoadBalancingRules as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.LoadBalancingRule.FromJson(__p) )) ))() : null : _loadBalancingRule;}
            {_allowRdpAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("allowRdpAccess"), out var __jsonAllowRdpAccess) ? (bool?)__jsonAllowRdpAccess : _allowRdpAccess;}
            {_networkSecurityRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("networkSecurityRules"), out var __jsonNetworkSecurityRules) ? If( __jsonNetworkSecurityRules as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NetworkSecurityRule.FromJson(__k) )) ))() : null : _networkSecurityRule;}
            {_client = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("clients"), out var __jsonClients) ? If( __jsonClients as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ClientCertificate.FromJson(__f) )) ))() : null : _client;}
            {_fabricSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("fabricSettings"), out var __jsonFabricSettings) ? If( __jsonFabricSettings as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__b, (__a)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISettingsSectionDescription) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SettingsSectionDescription.FromJson(__a) )) ))() : null : _fabricSetting;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_clusterCodeVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("clusterCodeVersion"), out var __jsonClusterCodeVersion) ? (string)__jsonClusterCodeVersion : (string)_clusterCodeVersion;}
            {_clusterUpgradeMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("clusterUpgradeMode"), out var __jsonClusterUpgradeMode) ? (string)__jsonClusterUpgradeMode : (string)_clusterUpgradeMode;}
            {_clusterUpgradeCadence = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("clusterUpgradeCadence"), out var __jsonClusterUpgradeCadence) ? (string)__jsonClusterUpgradeCadence : (string)_clusterUpgradeCadence;}
            {_addonFeature = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("addonFeatures"), out var __jsonAddonFeatures) ? If( __jsonAddonFeatures as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___w, (___v)=>(string) (___v is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString ___u ? (string)(___u.ToString()) : null)) ))() : null : _addonFeature;}
            {_enableAutoOSUpgrade = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableAutoOSUpgrade"), out var __jsonEnableAutoOSUpgrade) ? (bool?)__jsonEnableAutoOSUpgrade : _enableAutoOSUpgrade;}
            {_zonalResiliency = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("zonalResiliency"), out var __jsonZonalResiliency) ? (bool?)__jsonZonalResiliency : _zonalResiliency;}
            {_enableIpv6 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableIpv6"), out var __jsonEnableIpv6) ? (bool?)__jsonEnableIpv6 : _enableIpv6;}
            {_subnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("subnetId"), out var __jsonSubnetId) ? (string)__jsonSubnetId : (string)_subnetId;}
            {_iPTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("ipTags"), out var __jsonIPTags) ? If( __jsonIPTags as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___r, (___q)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPTag.FromJson(___q) )) ))() : null : _iPTag;}
            {_ipv6Address = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("ipv6Address"), out var __jsonIpv6Address) ? (string)__jsonIpv6Address : (string)_ipv6Address;}
            {_enableServicePublicIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableServicePublicIP"), out var __jsonEnableServicePublicIP) ? (bool?)__jsonEnableServicePublicIP : _enableServicePublicIP;}
            {_auxiliarySubnet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("auxiliarySubnets"), out var __jsonAuxiliarySubnets) ? If( __jsonAuxiliarySubnets as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___m, (___l)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.Subnet.FromJson(___l) )) ))() : null : _auxiliarySubnet;}
            {_serviceEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("serviceEndpoints"), out var __jsonServiceEndpoints) ? If( __jsonServiceEndpoints as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___h) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___h, (___g)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceEndpoint) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceEndpoint.FromJson(___g) )) ))() : null : _serviceEndpoint;}
            {_zonalUpdateMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("zonalUpdateMode"), out var __jsonZonalUpdateMode) ? (string)__jsonZonalUpdateMode : (string)_zonalUpdateMode;}
            {_useCustomVnet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("useCustomVnet"), out var __jsonUseCustomVnet) ? (bool?)__jsonUseCustomVnet : _useCustomVnet;}
            {_publicIPPrefixId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("publicIPPrefixId"), out var __jsonPublicIPPrefixId) ? (string)__jsonPublicIPPrefixId : (string)_publicIPPrefixId;}
            {_publicIPv6PrefixId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("publicIPv6PrefixId"), out var __jsonPublicIPv6PrefixId) ? (string)__jsonPublicIPv6PrefixId : (string)_publicIPv6PrefixId;}
            {_ddosProtectionPlanId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("ddosProtectionPlanId"), out var __jsonDdosProtectionPlanId) ? (string)__jsonDdosProtectionPlanId : (string)_ddosProtectionPlanId;}
            {_httpGatewayTokenAuthConnectionPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("httpGatewayTokenAuthConnectionPort"), out var __jsonHttpGatewayTokenAuthConnectionPort) ? (int?)__jsonHttpGatewayTokenAuthConnectionPort : _httpGatewayTokenAuthConnectionPort;}
            {_enableHttpGatewayExclusiveAuthMode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableHttpGatewayExclusiveAuthMode"), out var __jsonEnableHttpGatewayExclusiveAuthMode) ? (bool?)__jsonEnableHttpGatewayExclusiveAuthMode : _enableHttpGatewayExclusiveAuthMode;}
            {_autoGeneratedDomainNameLabelScope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("autoGeneratedDomainNameLabelScope"), out var __jsonAutoGeneratedDomainNameLabelScope) ? (string)__jsonAutoGeneratedDomainNameLabelScope : (string)_autoGeneratedDomainNameLabelScope;}
            {_allocatedOutboundPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("allocatedOutboundPorts"), out var __jsonAllocatedOutboundPorts) ? (int?)__jsonAllocatedOutboundPorts : _allocatedOutboundPort;}
            {_vMImage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("VMImage"), out var __jsonVMImage) ? (string)__jsonVMImage : (string)_vMImage;}
            {_enableOutboundOnlyNodeType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableOutboundOnlyNodeTypes"), out var __jsonEnableOutboundOnlyNodeTypes) ? (bool?)__jsonEnableOutboundOnlyNodeTypes : _enableOutboundOnlyNodeType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ManagedClusterProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ManagedClusterProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._azureActiveDirectory ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._azureActiveDirectory.ToJson(null,serializationMode) : null, "azureActiveDirectory" ,container.Add );
            AddIf( null != this._applicationTypeVersionsCleanupPolicy ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._applicationTypeVersionsCleanupPolicy.ToJson(null,serializationMode) : null, "applicationTypeVersionsCleanupPolicy" ,container.Add );
            AddIf( null != this._upgradeDescription ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._upgradeDescription.ToJson(null,serializationMode) : null, "upgradeDescription" ,container.Add );
            AddIf( null != (((object)this._dnsName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._dnsName.ToString()) : null, "dnsName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._fqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._fqdn.ToString()) : null, "fqdn" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._ipv4Address)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._ipv4Address.ToString()) : null, "ipv4Address" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._clusterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._clusterId.ToString()) : null, "clusterId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._clusterState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._clusterState.ToString()) : null, "clusterState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._clusterCertificateThumbprint)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                    foreach( var __x in this._clusterCertificateThumbprint )
                    {
                        AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                    }
                    container.Add("clusterCertificateThumbprints",__w);
                }
            }
            AddIf( null != this._clientConnectionPort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber((int)this._clientConnectionPort) : null, "clientConnectionPort" ,container.Add );
            AddIf( null != this._httpGatewayConnectionPort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber((int)this._httpGatewayConnectionPort) : null, "httpGatewayConnectionPort" ,container.Add );
            AddIf( null != (((object)this._adminUserName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._adminUserName.ToString()) : null, "adminUserName" ,container.Add );
            AddIf( null != (((object)this._adminPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this._adminPassword))) : null, "adminPassword" ,container.Add );
            if (null != this._loadBalancingRule)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __s in this._loadBalancingRule )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("loadBalancingRules",__r);
            }
            AddIf( null != this._allowRdpAccess ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._allowRdpAccess) : null, "allowRdpAccess" ,container.Add );
            if (null != this._networkSecurityRule)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __n in this._networkSecurityRule )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("networkSecurityRules",__m);
            }
            if (null != this._client)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __i in this._client )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("clients",__h);
            }
            if (null != this._fabricSetting)
            {
                var __c = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __d in this._fabricSetting )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("fabricSettings",__c);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._clusterCodeVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._clusterCodeVersion.ToString()) : null, "clusterCodeVersion" ,container.Add );
            AddIf( null != (((object)this._clusterUpgradeMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._clusterUpgradeMode.ToString()) : null, "clusterUpgradeMode" ,container.Add );
            AddIf( null != (((object)this._clusterUpgradeCadence)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._clusterUpgradeCadence.ToString()) : null, "clusterUpgradeCadence" ,container.Add );
            if (null != this._addonFeature)
            {
                var ___x = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___y in this._addonFeature )
                {
                    AddIf(null != (((object)___y)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(___y.ToString()) : null ,___x.Add);
                }
                container.Add("addonFeatures",___x);
            }
            AddIf( null != this._enableAutoOSUpgrade ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableAutoOSUpgrade) : null, "enableAutoOSUpgrade" ,container.Add );
            AddIf( null != this._zonalResiliency ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._zonalResiliency) : null, "zonalResiliency" ,container.Add );
            AddIf( null != this._enableIpv6 ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableIpv6) : null, "enableIpv6" ,container.Add );
            AddIf( null != (((object)this._subnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._subnetId.ToString()) : null, "subnetId" ,container.Add );
            if (null != this._iPTag)
            {
                var ___s = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___t in this._iPTag )
                {
                    AddIf(___t?.ToJson(null, serializationMode) ,___s.Add);
                }
                container.Add("ipTags",___s);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._ipv6Address)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._ipv6Address.ToString()) : null, "ipv6Address" ,container.Add );
            }
            AddIf( null != this._enableServicePublicIP ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableServicePublicIP) : null, "enableServicePublicIP" ,container.Add );
            if (null != this._auxiliarySubnet)
            {
                var ___n = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___o in this._auxiliarySubnet )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("auxiliarySubnets",___n);
            }
            if (null != this._serviceEndpoint)
            {
                var ___i = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___j in this._serviceEndpoint )
                {
                    AddIf(___j?.ToJson(null, serializationMode) ,___i.Add);
                }
                container.Add("serviceEndpoints",___i);
            }
            AddIf( null != (((object)this._zonalUpdateMode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._zonalUpdateMode.ToString()) : null, "zonalUpdateMode" ,container.Add );
            AddIf( null != this._useCustomVnet ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._useCustomVnet) : null, "useCustomVnet" ,container.Add );
            AddIf( null != (((object)this._publicIPPrefixId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._publicIPPrefixId.ToString()) : null, "publicIPPrefixId" ,container.Add );
            AddIf( null != (((object)this._publicIPv6PrefixId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._publicIPv6PrefixId.ToString()) : null, "publicIPv6PrefixId" ,container.Add );
            AddIf( null != (((object)this._ddosProtectionPlanId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._ddosProtectionPlanId.ToString()) : null, "ddosProtectionPlanId" ,container.Add );
            AddIf( null != this._httpGatewayTokenAuthConnectionPort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber((int)this._httpGatewayTokenAuthConnectionPort) : null, "httpGatewayTokenAuthConnectionPort" ,container.Add );
            AddIf( null != this._enableHttpGatewayExclusiveAuthMode ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableHttpGatewayExclusiveAuthMode) : null, "enableHttpGatewayExclusiveAuthMode" ,container.Add );
            AddIf( null != (((object)this._autoGeneratedDomainNameLabelScope)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._autoGeneratedDomainNameLabelScope.ToString()) : null, "autoGeneratedDomainNameLabelScope" ,container.Add );
            AddIf( null != this._allocatedOutboundPort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber((int)this._allocatedOutboundPort) : null, "allocatedOutboundPorts" ,container.Add );
            AddIf( null != (((object)this._vMImage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMImage.ToString()) : null, "VMImage" ,container.Add );
            AddIf( null != this._enableOutboundOnlyNodeType ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableOutboundOnlyNodeType) : null, "enableOutboundOnlyNodeTypes" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}