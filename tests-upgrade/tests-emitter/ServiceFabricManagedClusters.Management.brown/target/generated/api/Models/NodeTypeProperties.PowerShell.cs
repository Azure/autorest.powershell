// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(NodeTypePropertiesTypeConverter))]
    public partial class NodeTypeProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new NodeTypeProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new NodeTypeProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="NodeTypeProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="NodeTypeProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal NodeTypeProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPort = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription) content.GetValueForProperty("ApplicationPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPort, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("EphemeralPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPort = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription) content.GetValueForProperty("EphemeralPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPort, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMManagedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity) content.GetValueForProperty("VMManagedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMManagedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMImagePlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlan = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan) content.GetValueForProperty("VMImagePlan",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlan, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMImagePlanTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsPrimary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsPrimary = (bool) content.GetValueForProperty("IsPrimary",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsPrimary, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VMInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMInstanceCount = (int) content.GetValueForProperty("VMInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMInstanceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataDiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskSizeGb = (int?) content.GetValueForProperty("DataDiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataDiskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskType = (string) content.GetValueForProperty("DataDiskType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskType, global::System.Convert.ToString);
            }
            if (content.Contains("DataDiskLetter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskLetter = (string) content.GetValueForProperty("DataDiskLetter",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskLetter, global::System.Convert.ToString);
            }
            if (content.Contains("PlacementProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).PlacementProperty = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties) content.GetValueForProperty("PlacementProperty",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).PlacementProperty, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesPlacementPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesCapacitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSize, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePublisher = (string) content.GetValueForProperty("VMImagePublisher",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageOffer = (string) content.GetValueForProperty("VMImageOffer",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageOffer, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageSku = (string) content.GetValueForProperty("VMImageSku",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageSku, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageVersion = (string) content.GetValueForProperty("VMImageVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageVersion, global::System.Convert.ToString);
            }
            if (content.Contains("VMSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSecret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup>) content.GetValueForProperty("VMSecret",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSecret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VaultSecretGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("VMExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMExtension = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension>) content.GetValueForProperty("VMExtension",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMExtension, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssExtensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsStateless"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsStateless = (bool?) content.GetValueForProperty("IsStateless",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsStateless, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MultiplePlacementGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).MultiplePlacementGroup = (bool?) content.GetValueForProperty("MultiplePlacementGroup",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).MultiplePlacementGroup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("FrontendConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).FrontendConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration>) content.GetValueForProperty("FrontendConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).FrontendConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FrontendConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NetworkSecurityRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>) content.GetValueForProperty("NetworkSecurityRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NetworkSecurityRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NetworkSecurityRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalDataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalDataDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk>) content.GetValueForProperty("AdditionalDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalDataDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssDataDiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableEncryptionAtHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableEncryptionAtHost = (bool?) content.GetValueForProperty("EnableEncryptionAtHost",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableEncryptionAtHost, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("EnableAcceleratedNetworking"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableAcceleratedNetworking = (bool?) content.GetValueForProperty("EnableAcceleratedNetworking",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableAcceleratedNetworking, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UseDefaultPublicLoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseDefaultPublicLoadBalancer = (bool?) content.GetValueForProperty("UseDefaultPublicLoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseDefaultPublicLoadBalancer, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UseTempDataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseTempDataDisk = (bool?) content.GetValueForProperty("UseTempDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseTempDataDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableOverProvisioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableOverProvisioning = (bool?) content.GetValueForProperty("EnableOverProvisioning",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableOverProvisioning, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsSpotVM"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsSpotVM = (bool?) content.GetValueForProperty("IsSpotVM",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsSpotVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HostGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).HostGroupId = (string) content.GetValueForProperty("HostGroupId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).HostGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("UseEphemeralOSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseEphemeralOSDisk = (bool?) content.GetValueForProperty("UseEphemeralOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseEphemeralOSDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SpotRestoreTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SpotRestoreTimeout = (string) content.GetValueForProperty("SpotRestoreTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SpotRestoreTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("EvictionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EvictionPolicy = (string) content.GetValueForProperty("EvictionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EvictionPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageResourceId = (string) content.GetValueForProperty("VMImageResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VMSetupAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSetupAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("VMSetupAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSetupAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SecurityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityType = (string) content.GetValueForProperty("SecurityType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityEncryptionType = (string) content.GetValueForProperty("SecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecureBootEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecureBootEnabled = (bool?) content.GetValueForProperty("SecureBootEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecureBootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableNodePublicIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIP = (bool?) content.GetValueForProperty("EnableNodePublicIP",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableNodePublicIPv6"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIPv6 = (bool?) content.GetValueForProperty("EnableNodePublicIPv6",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIPv6, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VMSharedGalleryImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSharedGalleryImageId = (string) content.GetValueForProperty("VMSharedGalleryImageId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSharedGalleryImageId, global::System.Convert.ToString);
            }
            if (content.Contains("NatGatewayId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatGatewayId = (string) content.GetValueForProperty("NatGatewayId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatGatewayId, global::System.Convert.ToString);
            }
            if (content.Contains("NatConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig>) content.GetValueForProperty("NatConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeNatConfigTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceArtifactReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ServiceArtifactReferenceId = (string) content.GetValueForProperty("ServiceArtifactReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ServiceArtifactReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("DscpConfigurationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DscpConfigurationId = (string) content.GetValueForProperty("DscpConfigurationId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DscpConfigurationId, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalNetworkInterfaceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalNetworkInterfaceConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration>) content.GetValueForProperty("AdditionalNetworkInterfaceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalNetworkInterfaceConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AdditionalNetworkInterfaceConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ComputerNamePrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ComputerNamePrefix = (string) content.GetValueForProperty("ComputerNamePrefix",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ComputerNamePrefix, global::System.Convert.ToString);
            }
            if (content.Contains("VMApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMApplication = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication>) content.GetValueForProperty("VMApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMApplication, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMApplicationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ZoneBalance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ZoneBalance = (bool?) content.GetValueForProperty("ZoneBalance",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ZoneBalance, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsOutboundOnly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsOutboundOnly = (bool?) content.GetValueForProperty("IsOutboundOnly",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsOutboundOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationPortStartPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortStartPort = (int?) content.GetValueForProperty("ApplicationPortStartPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortStartPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationPortEndPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortEndPort = (int?) content.GetValueForProperty("ApplicationPortEndPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortEndPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EphemeralPortStartPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortStartPort = (int?) content.GetValueForProperty("EphemeralPortStartPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortStartPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EphemeralPortEndPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortEndPort = (int?) content.GetValueForProperty("EphemeralPortEndPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortEndPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VMManagedIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentityUserAssignedIdentity = (System.Collections.Generic.List<string>) content.GetValueForProperty("VMManagedIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentityUserAssignedIdentity, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VMImagePlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanName = (string) content.GetValueForProperty("VMImagePlanName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanName, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePlanProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanProduct = (string) content.GetValueForProperty("VMImagePlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanProduct, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePlanPromotionCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPromotionCode = (string) content.GetValueForProperty("VMImagePlanPromotionCode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPromotionCode, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePlanPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPublisher = (string) content.GetValueForProperty("VMImagePlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPublisher, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal NodeTypeProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPort = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription) content.GetValueForProperty("ApplicationPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPort, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("EphemeralPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPort = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription) content.GetValueForProperty("EphemeralPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPort, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.EndpointRangeDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMManagedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMManagedIdentity) content.GetValueForProperty("VMManagedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMManagedIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMImagePlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlan = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMImagePlan) content.GetValueForProperty("VMImagePlan",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlan, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMImagePlanTypeConverter.ConvertFrom);
            }
            if (content.Contains("IsPrimary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsPrimary = (bool) content.GetValueForProperty("IsPrimary",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsPrimary, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VMInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMInstanceCount = (int) content.GetValueForProperty("VMInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMInstanceCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataDiskSizeGb"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskSizeGb = (int?) content.GetValueForProperty("DataDiskSizeGb",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskSizeGb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DataDiskType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskType = (string) content.GetValueForProperty("DataDiskType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskType, global::System.Convert.ToString);
            }
            if (content.Contains("DataDiskLetter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskLetter = (string) content.GetValueForProperty("DataDiskLetter",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DataDiskLetter, global::System.Convert.ToString);
            }
            if (content.Contains("PlacementProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).PlacementProperty = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties) content.GetValueForProperty("PlacementProperty",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).PlacementProperty, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesPlacementPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Capacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Capacity = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities) content.GetValueForProperty("Capacity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Capacity, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypePropertiesCapacitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("VMSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSize, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePublisher = (string) content.GetValueForProperty("VMImagePublisher",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePublisher, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageOffer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageOffer = (string) content.GetValueForProperty("VMImageOffer",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageOffer, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageSku = (string) content.GetValueForProperty("VMImageSku",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageSku, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageVersion = (string) content.GetValueForProperty("VMImageVersion",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageVersion, global::System.Convert.ToString);
            }
            if (content.Contains("VMSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSecret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup>) content.GetValueForProperty("VMSecret",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSecret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVaultSecretGroup>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VaultSecretGroupTypeConverter.ConvertFrom));
            }
            if (content.Contains("VMExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMExtension = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension>) content.GetValueForProperty("VMExtension",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMExtension, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssExtension>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssExtensionTypeConverter.ConvertFrom));
            }
            if (content.Contains("IsStateless"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsStateless = (bool?) content.GetValueForProperty("IsStateless",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsStateless, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MultiplePlacementGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).MultiplePlacementGroup = (bool?) content.GetValueForProperty("MultiplePlacementGroup",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).MultiplePlacementGroup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("FrontendConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).FrontendConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration>) content.GetValueForProperty("FrontendConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).FrontendConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FrontendConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("NetworkSecurityRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NetworkSecurityRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>) content.GetValueForProperty("NetworkSecurityRule",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NetworkSecurityRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NetworkSecurityRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalDataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalDataDisk = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk>) content.GetValueForProperty("AdditionalDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalDataDisk, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVmssDataDisk>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VmssDataDiskTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableEncryptionAtHost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableEncryptionAtHost = (bool?) content.GetValueForProperty("EnableEncryptionAtHost",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableEncryptionAtHost, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("EnableAcceleratedNetworking"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableAcceleratedNetworking = (bool?) content.GetValueForProperty("EnableAcceleratedNetworking",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableAcceleratedNetworking, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UseDefaultPublicLoadBalancer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseDefaultPublicLoadBalancer = (bool?) content.GetValueForProperty("UseDefaultPublicLoadBalancer",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseDefaultPublicLoadBalancer, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("UseTempDataDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseTempDataDisk = (bool?) content.GetValueForProperty("UseTempDataDisk",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseTempDataDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableOverProvisioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableOverProvisioning = (bool?) content.GetValueForProperty("EnableOverProvisioning",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableOverProvisioning, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsSpotVM"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsSpotVM = (bool?) content.GetValueForProperty("IsSpotVM",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsSpotVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HostGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).HostGroupId = (string) content.GetValueForProperty("HostGroupId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).HostGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("UseEphemeralOSDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseEphemeralOSDisk = (bool?) content.GetValueForProperty("UseEphemeralOSDisk",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).UseEphemeralOSDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SpotRestoreTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SpotRestoreTimeout = (string) content.GetValueForProperty("SpotRestoreTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SpotRestoreTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("EvictionPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EvictionPolicy = (string) content.GetValueForProperty("EvictionPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EvictionPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("VMImageResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageResourceId = (string) content.GetValueForProperty("VMImageResourceId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImageResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VMSetupAction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSetupAction = (System.Collections.Generic.List<string>) content.GetValueForProperty("VMSetupAction",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSetupAction, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("SecurityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityType = (string) content.GetValueForProperty("SecurityType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityType, global::System.Convert.ToString);
            }
            if (content.Contains("SecurityEncryptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityEncryptionType = (string) content.GetValueForProperty("SecurityEncryptionType",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecurityEncryptionType, global::System.Convert.ToString);
            }
            if (content.Contains("SecureBootEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecureBootEnabled = (bool?) content.GetValueForProperty("SecureBootEnabled",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).SecureBootEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableNodePublicIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIP = (bool?) content.GetValueForProperty("EnableNodePublicIP",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableNodePublicIPv6"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIPv6 = (bool?) content.GetValueForProperty("EnableNodePublicIPv6",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EnableNodePublicIPv6, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VMSharedGalleryImageId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSharedGalleryImageId = (string) content.GetValueForProperty("VMSharedGalleryImageId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMSharedGalleryImageId, global::System.Convert.ToString);
            }
            if (content.Contains("NatGatewayId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatGatewayId = (string) content.GetValueForProperty("NatGatewayId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatGatewayId, global::System.Convert.ToString);
            }
            if (content.Contains("NatConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig>) content.GetValueForProperty("NatConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).NatConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.NodeTypeNatConfigTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceArtifactReferenceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ServiceArtifactReferenceId = (string) content.GetValueForProperty("ServiceArtifactReferenceId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ServiceArtifactReferenceId, global::System.Convert.ToString);
            }
            if (content.Contains("DscpConfigurationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DscpConfigurationId = (string) content.GetValueForProperty("DscpConfigurationId",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).DscpConfigurationId, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalNetworkInterfaceConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalNetworkInterfaceConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration>) content.GetValueForProperty("AdditionalNetworkInterfaceConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).AdditionalNetworkInterfaceConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AdditionalNetworkInterfaceConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ComputerNamePrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ComputerNamePrefix = (string) content.GetValueForProperty("ComputerNamePrefix",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ComputerNamePrefix, global::System.Convert.ToString);
            }
            if (content.Contains("VMApplication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMApplication = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication>) content.GetValueForProperty("VMApplication",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMApplication, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.VMApplicationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ZoneBalance"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ZoneBalance = (bool?) content.GetValueForProperty("ZoneBalance",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ZoneBalance, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsOutboundOnly"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsOutboundOnly = (bool?) content.GetValueForProperty("IsOutboundOnly",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).IsOutboundOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationPortStartPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortStartPort = (int?) content.GetValueForProperty("ApplicationPortStartPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortStartPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ApplicationPortEndPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortEndPort = (int?) content.GetValueForProperty("ApplicationPortEndPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).ApplicationPortEndPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EphemeralPortStartPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortStartPort = (int?) content.GetValueForProperty("EphemeralPortStartPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortStartPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EphemeralPortEndPort"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortEndPort = (int?) content.GetValueForProperty("EphemeralPortEndPort",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).EphemeralPortEndPort, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("VMManagedIdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentityUserAssignedIdentity = (System.Collections.Generic.List<string>) content.GetValueForProperty("VMManagedIdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMManagedIdentityUserAssignedIdentity, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VMImagePlanName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanName = (string) content.GetValueForProperty("VMImagePlanName",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanName, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePlanProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanProduct = (string) content.GetValueForProperty("VMImagePlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanProduct, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePlanPromotionCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPromotionCode = (string) content.GetValueForProperty("VMImagePlanPromotionCode",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPromotionCode, global::System.Convert.ToString);
            }
            if (content.Contains("VMImagePlanPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPublisher = (string) content.GetValueForProperty("VMImagePlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesInternal)this).VMImagePlanPublisher, global::System.Convert.ToString);
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
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    [System.ComponentModel.TypeConverter(typeof(NodeTypePropertiesTypeConverter))]
    public partial interface INodeTypeProperties

    {

    }
}