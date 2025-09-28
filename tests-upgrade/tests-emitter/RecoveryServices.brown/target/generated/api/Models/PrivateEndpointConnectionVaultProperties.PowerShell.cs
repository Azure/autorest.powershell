// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>
    /// Information to be stored in Vault properties as an element of privateEndpointConnections List.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointConnectionVaultPropertiesTypeConverter))]
    public partial class PrivateEndpointConnectionVaultProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PrivateEndpointConnectionVaultProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PrivateEndpointConnectionVaultProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PrivateEndpointConnectionVaultProperties" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="PrivateEndpointConnectionVaultProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PrivateEndpointConnectionVaultProperties(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnection) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpoint) content.GetValueForProperty("PrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpoint, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkServiceConnectionState) content.GetValueForProperty("PrivateLinkServiceConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionState, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateLinkServiceConnectionStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("GroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).GroupId = (System.Collections.Generic.List<string>) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).GroupId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PrivateEndpointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpointId = (string) content.GetValueForProperty("PrivateEndpointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpointId, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionStateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateStatus = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateDescription = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionStateActionsRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateActionsRequired = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateActionsRequired",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateActionsRequired, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PrivateEndpointConnectionVaultProperties(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnection) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpoint = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpoint) content.GetValueForProperty("PrivateEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpoint, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionState = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkServiceConnectionState) content.GetValueForProperty("PrivateLinkServiceConnectionState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionState, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateLinkServiceConnectionStateTypeConverter.ConvertFrom);
            }
            if (content.Contains("GroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).GroupId = (System.Collections.Generic.List<string>) content.GetValueForProperty("GroupId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).GroupId, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PrivateEndpointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpointId = (string) content.GetValueForProperty("PrivateEndpointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateEndpointId, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionStateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateStatus = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionStateDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateDescription = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateDescription",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateDescription, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkServiceConnectionStateActionsRequired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateActionsRequired = (string) content.GetValueForProperty("PrivateLinkServiceConnectionStateActionsRequired",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultPropertiesInternal)this).PrivateLinkServiceConnectionStateActionsRequired, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Information to be stored in Vault properties as an element of privateEndpointConnections List.
    [System.ComponentModel.TypeConverter(typeof(PrivateEndpointConnectionVaultPropertiesTypeConverter))]
    public partial interface IPrivateEndpointConnectionVaultProperties

    {

    }
}