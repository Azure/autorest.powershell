// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    /// </summary>
    public partial class NodeTypeProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json ? new NodeTypeProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject into a new instance of <see cref="NodeTypeProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal NodeTypeProperties(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_applicationPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("applicationPorts"), out var __jsonApplicationPorts) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescription.FromJson(__jsonApplicationPorts) : _applicationPort;}
            {_ephemeralPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("ephemeralPorts"), out var __jsonEphemeralPorts) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescription.FromJson(__jsonEphemeralPorts) : _ephemeralPort;}
            {_vMManagedIdentity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("vmManagedIdentity"), out var __jsonVMManagedIdentity) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMManagedIdentity.FromJson(__jsonVMManagedIdentity) : _vMManagedIdentity;}
            {_vMImagePlan = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("vmImagePlan"), out var __jsonVMImagePlan) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMImagePlan.FromJson(__jsonVMImagePlan) : _vMImagePlan;}
            {_isPrimary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("isPrimary"), out var __jsonIsPrimary) ? (bool)__jsonIsPrimary : _isPrimary;}
            {_vMInstanceCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("vmInstanceCount"), out var __jsonVMInstanceCount) ? (int)__jsonVMInstanceCount : _vMInstanceCount;}
            {_dataDiskSizeGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("dataDiskSizeGB"), out var __jsonDataDiskSizeGb) ? (int?)__jsonDataDiskSizeGb : _dataDiskSizeGb;}
            {_dataDiskType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("dataDiskType"), out var __jsonDataDiskType) ? (string)__jsonDataDiskType : (string)_dataDiskType;}
            {_dataDiskLetter = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("dataDiskLetter"), out var __jsonDataDiskLetter) ? (string)__jsonDataDiskLetter : (string)_dataDiskLetter;}
            {_placementProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("placementProperties"), out var __jsonPlacementProperties) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesPlacementProperties.FromJson(__jsonPlacementProperties) : _placementProperty;}
            {_capacity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("capacities"), out var __jsonCapacities) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesCapacities.FromJson(__jsonCapacities) : _capacity;}
            {_vMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmSize"), out var __jsonVMSize) ? (string)__jsonVMSize : (string)_vMSize;}
            {_vMImagePublisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmImagePublisher"), out var __jsonVMImagePublisher) ? (string)__jsonVMImagePublisher : (string)_vMImagePublisher;}
            {_vMImageOffer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmImageOffer"), out var __jsonVMImageOffer) ? (string)__jsonVMImageOffer : (string)_vMImageOffer;}
            {_vMImageSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmImageSku"), out var __jsonVMImageSku) ? (string)__jsonVMImageSku : (string)_vMImageSku;}
            {_vMImageVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmImageVersion"), out var __jsonVMImageVersion) ? (string)__jsonVMImageVersion : (string)_vMImageVersion;}
            {_vMSecret = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("vmSecrets"), out var __jsonVMSecrets) ? If( __jsonVMSecrets as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VaultSecretGroup.FromJson(__u) )) ))() : null : _vMSecret;}
            {_vMExtension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("vmExtensions"), out var __jsonVMExtensions) ? If( __jsonVMExtensions as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssExtension.FromJson(__p) )) ))() : null : _vMExtension;}
            {_isStateless = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("isStateless"), out var __jsonIsStateless) ? (bool?)__jsonIsStateless : _isStateless;}
            {_multiplePlacementGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("multiplePlacementGroups"), out var __jsonMultiplePlacementGroups) ? (bool?)__jsonMultiplePlacementGroups : _multiplePlacementGroup;}
            {_frontendConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("frontendConfigurations"), out var __jsonFrontendConfigurations) ? If( __jsonFrontendConfigurations as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FrontendConfiguration.FromJson(__k) )) ))() : null : _frontendConfiguration;}
            {_networkSecurityRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("networkSecurityRules"), out var __jsonNetworkSecurityRules) ? If( __jsonNetworkSecurityRules as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NetworkSecurityRule.FromJson(__f) )) ))() : null : _networkSecurityRule;}
            {_additionalDataDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("additionalDataDisks"), out var __jsonAdditionalDataDisks) ? If( __jsonAdditionalDataDisks as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__b, (__a)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssDataDisk.FromJson(__a) )) ))() : null : _additionalDataDisk;}
            {_enableEncryptionAtHost = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableEncryptionAtHost"), out var __jsonEnableEncryptionAtHost) ? (bool?)__jsonEnableEncryptionAtHost : _enableEncryptionAtHost;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_enableAcceleratedNetworking = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableAcceleratedNetworking"), out var __jsonEnableAcceleratedNetworking) ? (bool?)__jsonEnableAcceleratedNetworking : _enableAcceleratedNetworking;}
            {_useDefaultPublicLoadBalancer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("useDefaultPublicLoadBalancer"), out var __jsonUseDefaultPublicLoadBalancer) ? (bool?)__jsonUseDefaultPublicLoadBalancer : _useDefaultPublicLoadBalancer;}
            {_useTempDataDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("useTempDataDisk"), out var __jsonUseTempDataDisk) ? (bool?)__jsonUseTempDataDisk : _useTempDataDisk;}
            {_enableOverProvisioning = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableOverProvisioning"), out var __jsonEnableOverProvisioning) ? (bool?)__jsonEnableOverProvisioning : _enableOverProvisioning;}
            {_zone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("zones"), out var __jsonZones) ? If( __jsonZones as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___w, (___v)=>(string) (___v is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString ___u ? (string)(___u.ToString()) : null)) ))() : null : _zone;}
            {_isSpotVM = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("isSpotVM"), out var __jsonIsSpotVM) ? (bool?)__jsonIsSpotVM : _isSpotVM;}
            {_hostGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("hostGroupId"), out var __jsonHostGroupId) ? (string)__jsonHostGroupId : (string)_hostGroupId;}
            {_useEphemeralOSDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("useEphemeralOSDisk"), out var __jsonUseEphemeralOSDisk) ? (bool?)__jsonUseEphemeralOSDisk : _useEphemeralOSDisk;}
            {_spotRestoreTimeout = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("spotRestoreTimeout"), out var __jsonSpotRestoreTimeout) ? (string)__jsonSpotRestoreTimeout : (string)_spotRestoreTimeout;}
            {_evictionPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("evictionPolicy"), out var __jsonEvictionPolicy) ? (string)__jsonEvictionPolicy : (string)_evictionPolicy;}
            {_vMImageResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmImageResourceId"), out var __jsonVMImageResourceId) ? (string)__jsonVMImageResourceId : (string)_vMImageResourceId;}
            {_subnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("subnetId"), out var __jsonSubnetId) ? (string)__jsonSubnetId : (string)_subnetId;}
            {_vMSetupAction = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("vmSetupActions"), out var __jsonVMSetupActions) ? If( __jsonVMSetupActions as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___r, (___q)=>(string) (___q is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString ___p ? (string)(___p.ToString()) : null)) ))() : null : _vMSetupAction;}
            {_securityType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("securityType"), out var __jsonSecurityType) ? (string)__jsonSecurityType : (string)_securityType;}
            {_securityEncryptionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("securityEncryptionType"), out var __jsonSecurityEncryptionType) ? (string)__jsonSecurityEncryptionType : (string)_securityEncryptionType;}
            {_secureBootEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("secureBootEnabled"), out var __jsonSecureBootEnabled) ? (bool?)__jsonSecureBootEnabled : _secureBootEnabled;}
            {_enableNodePublicIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableNodePublicIP"), out var __jsonEnableNodePublicIP) ? (bool?)__jsonEnableNodePublicIP : _enableNodePublicIP;}
            {_enableNodePublicIPv6 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("enableNodePublicIPv6"), out var __jsonEnableNodePublicIPv6) ? (bool?)__jsonEnableNodePublicIPv6 : _enableNodePublicIPv6;}
            {_vMSharedGalleryImageId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("vmSharedGalleryImageId"), out var __jsonVMSharedGalleryImageId) ? (string)__jsonVMSharedGalleryImageId : (string)_vMSharedGalleryImageId;}
            {_natGatewayId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("natGatewayId"), out var __jsonNatGatewayId) ? (string)__jsonNatGatewayId : (string)_natGatewayId;}
            {_natConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("natConfigurations"), out var __jsonNatConfigurations) ? If( __jsonNatConfigurations as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___m) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___m, (___l)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeNatConfig.FromJson(___l) )) ))() : null : _natConfiguration;}
            {_serviceArtifactReferenceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("serviceArtifactReferenceId"), out var __jsonServiceArtifactReferenceId) ? (string)__jsonServiceArtifactReferenceId : (string)_serviceArtifactReferenceId;}
            {_dscpConfigurationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("dscpConfigurationId"), out var __jsonDscpConfigurationId) ? (string)__jsonDscpConfigurationId : (string)_dscpConfigurationId;}
            {_additionalNetworkInterfaceConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("additionalNetworkInterfaceConfigurations"), out var __jsonAdditionalNetworkInterfaceConfigurations) ? If( __jsonAdditionalNetworkInterfaceConfigurations as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___h) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___h, (___g)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AdditionalNetworkInterfaceConfiguration.FromJson(___g) )) ))() : null : _additionalNetworkInterfaceConfiguration;}
            {_computerNamePrefix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("computerNamePrefix"), out var __jsonComputerNamePrefix) ? (string)__jsonComputerNamePrefix : (string)_computerNamePrefix;}
            {_vMApplication = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("vmApplications"), out var __jsonVMApplications) ? If( __jsonVMApplications as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var ___c) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___c, (___b)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMApplication.FromJson(___b) )) ))() : null : _vMApplication;}
            {_zoneBalance = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("zoneBalance"), out var __jsonZoneBalance) ? (bool?)__jsonZoneBalance : _zoneBalance;}
            {_isOutboundOnly = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean>("isOutboundOnly"), out var __jsonIsOutboundOnly) ? (bool?)__jsonIsOutboundOnly : _isOutboundOnly;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="NodeTypeProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="NodeTypeProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._applicationPort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._applicationPort.ToJson(null,serializationMode) : null, "applicationPorts" ,container.Add );
            AddIf( null != this._ephemeralPort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._ephemeralPort.ToJson(null,serializationMode) : null, "ephemeralPorts" ,container.Add );
            AddIf( null != this._vMManagedIdentity ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._vMManagedIdentity.ToJson(null,serializationMode) : null, "vmManagedIdentity" ,container.Add );
            AddIf( null != this._vMImagePlan ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._vMImagePlan.ToJson(null,serializationMode) : null, "vmImagePlan" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean(this._isPrimary), "isPrimary" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber(this._vMInstanceCount), "vmInstanceCount" ,container.Add );
            AddIf( null != this._dataDiskSizeGb ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber((int)this._dataDiskSizeGb) : null, "dataDiskSizeGB" ,container.Add );
            AddIf( null != (((object)this._dataDiskType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._dataDiskType.ToString()) : null, "dataDiskType" ,container.Add );
            AddIf( null != (((object)this._dataDiskLetter)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._dataDiskLetter.ToString()) : null, "dataDiskLetter" ,container.Add );
            AddIf( null != this._placementProperty ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._placementProperty.ToJson(null,serializationMode) : null, "placementProperties" ,container.Add );
            AddIf( null != this._capacity ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._capacity.ToJson(null,serializationMode) : null, "capacities" ,container.Add );
            AddIf( null != (((object)this._vMSize)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMSize.ToString()) : null, "vmSize" ,container.Add );
            AddIf( null != (((object)this._vMImagePublisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMImagePublisher.ToString()) : null, "vmImagePublisher" ,container.Add );
            AddIf( null != (((object)this._vMImageOffer)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMImageOffer.ToString()) : null, "vmImageOffer" ,container.Add );
            AddIf( null != (((object)this._vMImageSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMImageSku.ToString()) : null, "vmImageSku" ,container.Add );
            AddIf( null != (((object)this._vMImageVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMImageVersion.ToString()) : null, "vmImageVersion" ,container.Add );
            if (null != this._vMSecret)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __x in this._vMSecret )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("vmSecrets",__w);
            }
            if (null != this._vMExtension)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __s in this._vMExtension )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("vmExtensions",__r);
            }
            AddIf( null != this._isStateless ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._isStateless) : null, "isStateless" ,container.Add );
            AddIf( null != this._multiplePlacementGroup ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._multiplePlacementGroup) : null, "multiplePlacementGroups" ,container.Add );
            if (null != this._frontendConfiguration)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __n in this._frontendConfiguration )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("frontendConfigurations",__m);
            }
            if (null != this._networkSecurityRule)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __i in this._networkSecurityRule )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("networkSecurityRules",__h);
            }
            if (null != this._additionalDataDisk)
            {
                var __c = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __d in this._additionalDataDisk )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("additionalDataDisks",__c);
            }
            AddIf( null != this._enableEncryptionAtHost ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableEncryptionAtHost) : null, "enableEncryptionAtHost" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != this._enableAcceleratedNetworking ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableAcceleratedNetworking) : null, "enableAcceleratedNetworking" ,container.Add );
            AddIf( null != this._useDefaultPublicLoadBalancer ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._useDefaultPublicLoadBalancer) : null, "useDefaultPublicLoadBalancer" ,container.Add );
            AddIf( null != this._useTempDataDisk ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._useTempDataDisk) : null, "useTempDataDisk" ,container.Add );
            AddIf( null != this._enableOverProvisioning ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableOverProvisioning) : null, "enableOverProvisioning" ,container.Add );
            if (null != this._zone)
            {
                var ___x = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___y in this._zone )
                {
                    AddIf(null != (((object)___y)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(___y.ToString()) : null ,___x.Add);
                }
                container.Add("zones",___x);
            }
            AddIf( null != this._isSpotVM ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._isSpotVM) : null, "isSpotVM" ,container.Add );
            AddIf( null != (((object)this._hostGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._hostGroupId.ToString()) : null, "hostGroupId" ,container.Add );
            AddIf( null != this._useEphemeralOSDisk ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._useEphemeralOSDisk) : null, "useEphemeralOSDisk" ,container.Add );
            AddIf( null != (((object)this._spotRestoreTimeout)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._spotRestoreTimeout.ToString()) : null, "spotRestoreTimeout" ,container.Add );
            AddIf( null != (((object)this._evictionPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._evictionPolicy.ToString()) : null, "evictionPolicy" ,container.Add );
            AddIf( null != (((object)this._vMImageResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMImageResourceId.ToString()) : null, "vmImageResourceId" ,container.Add );
            AddIf( null != (((object)this._subnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._subnetId.ToString()) : null, "subnetId" ,container.Add );
            if (null != this._vMSetupAction)
            {
                var ___s = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___t in this._vMSetupAction )
                {
                    AddIf(null != (((object)___t)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(___t.ToString()) : null ,___s.Add);
                }
                container.Add("vmSetupActions",___s);
            }
            AddIf( null != (((object)this._securityType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._securityType.ToString()) : null, "securityType" ,container.Add );
            AddIf( null != (((object)this._securityEncryptionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._securityEncryptionType.ToString()) : null, "securityEncryptionType" ,container.Add );
            AddIf( null != this._secureBootEnabled ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._secureBootEnabled) : null, "secureBootEnabled" ,container.Add );
            AddIf( null != this._enableNodePublicIP ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableNodePublicIP) : null, "enableNodePublicIP" ,container.Add );
            AddIf( null != this._enableNodePublicIPv6 ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._enableNodePublicIPv6) : null, "enableNodePublicIPv6" ,container.Add );
            AddIf( null != (((object)this._vMSharedGalleryImageId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._vMSharedGalleryImageId.ToString()) : null, "vmSharedGalleryImageId" ,container.Add );
            AddIf( null != (((object)this._natGatewayId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._natGatewayId.ToString()) : null, "natGatewayId" ,container.Add );
            if (null != this._natConfiguration)
            {
                var ___n = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___o in this._natConfiguration )
                {
                    AddIf(___o?.ToJson(null, serializationMode) ,___n.Add);
                }
                container.Add("natConfigurations",___n);
            }
            AddIf( null != (((object)this._serviceArtifactReferenceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._serviceArtifactReferenceId.ToString()) : null, "serviceArtifactReferenceId" ,container.Add );
            AddIf( null != (((object)this._dscpConfigurationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._dscpConfigurationId.ToString()) : null, "dscpConfigurationId" ,container.Add );
            if (null != this._additionalNetworkInterfaceConfiguration)
            {
                var ___i = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___j in this._additionalNetworkInterfaceConfiguration )
                {
                    AddIf(___j?.ToJson(null, serializationMode) ,___i.Add);
                }
                container.Add("additionalNetworkInterfaceConfigurations",___i);
            }
            AddIf( null != (((object)this._computerNamePrefix)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._computerNamePrefix.ToString()) : null, "computerNamePrefix" ,container.Add );
            if (null != this._vMApplication)
            {
                var ___d = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var ___e in this._vMApplication )
                {
                    AddIf(___e?.ToJson(null, serializationMode) ,___d.Add);
                }
                container.Add("vmApplications",___d);
            }
            AddIf( null != this._zoneBalance ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._zoneBalance) : null, "zoneBalance" ,container.Add );
            AddIf( null != this._isOutboundOnly ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonBoolean((bool)this._isOutboundOnly) : null, "isOutboundOnly" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}