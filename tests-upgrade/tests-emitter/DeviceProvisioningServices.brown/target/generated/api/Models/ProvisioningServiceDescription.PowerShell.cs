// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell;

    /// <summary>The description of the provisioning service.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProvisioningServiceDescriptionTypeConverter))]
    public partial class ProvisioningServiceDescription
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ProvisioningServiceDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescription"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescription DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProvisioningServiceDescription(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ProvisioningServiceDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescription"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescription DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProvisioningServiceDescription(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProvisioningServiceDescription" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProvisioningServiceDescription" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescription FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ProvisioningServiceDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProvisioningServiceDescription(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsSkuInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Resourcegroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Resourcegroup = (string) content.GetValueForProperty("Resourcegroup",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Resourcegroup, global::System.Convert.ToString);
            }
            if (content.Contains("Subscriptionid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Subscriptionid = (string) content.GetValueForProperty("Subscriptionid",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Subscriptionid, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Location1 = (string) content.GetValueForProperty("Location1",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Location1, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("AllocationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AllocationPolicy = (string) content.GetValueForProperty("AllocationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AllocationPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuCapacity = (long?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeviceRegistryNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespace = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription) content.GetValueForProperty("DeviceRegistryNamespace",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespace, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("IPFilterRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IPFilterRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>) content.GetValueForProperty("IPFilterRule",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IPFilterRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPFilterRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IotHub"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IotHub = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>) content.GetValueForProperty("IotHub",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IotHub, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotHubDefinitionDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ServiceOperationsHostName = (string) content.GetValueForProperty("ServiceOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ServiceOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceProvisioningHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceProvisioningHostName = (string) content.GetValueForProperty("DeviceProvisioningHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceProvisioningHostName, global::System.Convert.ToString);
            }
            if (content.Contains("IdScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdScope = (string) content.GetValueForProperty("IdScope",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdScope, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AuthorizationPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>) content.GetValueForProperty("AuthorizationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AuthorizationPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SharedAccessSignatureAuthorizationRuleAccessRightsDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableDataResidency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).EnableDataResidency = (bool?) content.GetValueForProperty("EnableDataResidency",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).EnableDataResidency, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PortalOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PortalOperationsHostName = (string) content.GetValueForProperty("PortalOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PortalOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceAuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType = (string) content.GetValueForProperty("DeviceRegistryNamespaceAuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuTier, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ProvisioningServiceDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProvisioningServiceDescription(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuInfo) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsSkuInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Etag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Etag, global::System.Convert.ToString);
            }
            if (content.Contains("Resourcegroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Resourcegroup = (string) content.GetValueForProperty("Resourcegroup",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Resourcegroup, global::System.Convert.ToString);
            }
            if (content.Contains("Subscriptionid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Subscriptionid = (string) content.GetValueForProperty("Subscriptionid",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Subscriptionid, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Location1 = (string) content.GetValueForProperty("Location1",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITrackedResourceInternal)this).Location1, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("AllocationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AllocationPolicy = (string) content.GetValueForProperty("AllocationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AllocationPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("SkuCapacity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuCapacity = (long?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeviceRegistryNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespace = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription) content.GetValueForProperty("DeviceRegistryNamespace",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespace, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("IPFilterRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IPFilterRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>) content.GetValueForProperty("IPFilterRule",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IPFilterRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPFilterRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IotHub"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IotHub = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>) content.GetValueForProperty("IotHub",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IotHub, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotHubDefinitionDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ServiceOperationsHostName = (string) content.GetValueForProperty("ServiceOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).ServiceOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceProvisioningHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceProvisioningHostName = (string) content.GetValueForProperty("DeviceProvisioningHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceProvisioningHostName, global::System.Convert.ToString);
            }
            if (content.Contains("IdScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdScope = (string) content.GetValueForProperty("IdScope",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdScope, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AuthorizationPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>) content.GetValueForProperty("AuthorizationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).AuthorizationPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SharedAccessSignatureAuthorizationRuleAccessRightsDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableDataResidency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).EnableDataResidency = (bool?) content.GetValueForProperty("EnableDataResidency",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).EnableDataResidency, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PortalOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PortalOperationsHostName = (string) content.GetValueForProperty("PortalOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).PortalOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceAuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType = (string) content.GetValueForProperty("DeviceRegistryNamespaceAuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType, global::System.Convert.ToString);
            }
            if (content.Contains("SkuName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuName, global::System.Convert.ToString);
            }
            if (content.Contains("SkuTier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuTier = (string) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).SkuTier, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IManagedServiceIdentityUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ManagedServiceIdentityUserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProvisioningServiceDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The description of the provisioning service.
    [System.ComponentModel.TypeConverter(typeof(ProvisioningServiceDescriptionTypeConverter))]
    public partial interface IProvisioningServiceDescription

    {

    }
}