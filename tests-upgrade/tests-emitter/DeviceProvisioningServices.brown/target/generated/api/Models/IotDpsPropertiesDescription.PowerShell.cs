// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.PowerShell;

    /// <summary>
    /// the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system
    /// generated properties such as hostname and idScope
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(IotDpsPropertiesDescriptionTypeConverter))]
    public partial class IotDpsPropertiesDescription
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IotDpsPropertiesDescription(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IotDpsPropertiesDescription(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IotDpsPropertiesDescription" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IotDpsPropertiesDescription" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IotDpsPropertiesDescription(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceRegistryNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespace = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription) content.GetValueForProperty("DeviceRegistryNamespace",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespace, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("IPFilterRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IPFilterRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>) content.GetValueForProperty("IPFilterRule",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IPFilterRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPFilterRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IotHub"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IotHub = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>) content.GetValueForProperty("IotHub",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IotHub, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotHubDefinitionDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AllocationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AllocationPolicy = (string) content.GetValueForProperty("AllocationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AllocationPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ServiceOperationsHostName = (string) content.GetValueForProperty("ServiceOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ServiceOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceProvisioningHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceProvisioningHostName = (string) content.GetValueForProperty("DeviceProvisioningHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceProvisioningHostName, global::System.Convert.ToString);
            }
            if (content.Contains("IdScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IdScope = (string) content.GetValueForProperty("IdScope",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IdScope, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AuthorizationPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>) content.GetValueForProperty("AuthorizationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AuthorizationPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SharedAccessSignatureAuthorizationRuleAccessRightsDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableDataResidency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).EnableDataResidency = (bool?) content.GetValueForProperty("EnableDataResidency",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).EnableDataResidency, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PortalOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PortalOperationsHostName = (string) content.GetValueForProperty("PortalOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PortalOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceAuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType = (string) content.GetValueForProperty("DeviceRegistryNamespaceAuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotDpsPropertiesDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IotDpsPropertiesDescription(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceRegistryNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespace = (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IDeviceRegistryNamespaceDescription) content.GetValueForProperty("DeviceRegistryNamespace",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespace, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("IPFilterRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IPFilterRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>) content.GetValueForProperty("IPFilterRule",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IPFilterRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPFilterRuleTypeConverter.ConvertFrom));
            }
            if (content.Contains("PrivateEndpointConnection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PrivateEndpointConnection = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("IotHub"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IotHub = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>) content.GetValueForProperty("IotHub",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IotHub, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotHubDefinitionDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("AllocationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AllocationPolicy = (string) content.GetValueForProperty("AllocationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AllocationPolicy, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ServiceOperationsHostName = (string) content.GetValueForProperty("ServiceOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).ServiceOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceProvisioningHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceProvisioningHostName = (string) content.GetValueForProperty("DeviceProvisioningHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceProvisioningHostName, global::System.Convert.ToString);
            }
            if (content.Contains("IdScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IdScope = (string) content.GetValueForProperty("IdScope",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).IdScope, global::System.Convert.ToString);
            }
            if (content.Contains("AuthorizationPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AuthorizationPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>) content.GetValueForProperty("AuthorizationPolicy",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).AuthorizationPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SharedAccessSignatureAuthorizationRuleAccessRightsDescriptionTypeConverter.ConvertFrom));
            }
            if (content.Contains("EnableDataResidency"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).EnableDataResidency = (bool?) content.GetValueForProperty("EnableDataResidency",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).EnableDataResidency, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PortalOperationsHostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PortalOperationsHostName = (string) content.GetValueForProperty("PortalOperationsHostName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).PortalOperationsHostName, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceAuthenticationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType = (string) content.GetValueForProperty("DeviceRegistryNamespaceAuthenticationType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceAuthenticationType, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId = (string) content.GetValueForProperty("DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescriptionInternal)this).DeviceRegistryNamespaceSelectedUserAssignedIdentityResourceId, global::System.Convert.ToString);
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
    /// the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system
    /// generated properties such as hostname and idScope
    [System.ComponentModel.TypeConverter(typeof(IotDpsPropertiesDescriptionTypeConverter))]
    public partial interface IIotDpsPropertiesDescription

    {

    }
}