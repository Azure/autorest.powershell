// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.PowerShell;

    /// <summary>Defines the Asset Endpoint Profile properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(AssetEndpointProfilePropertiesTypeConverter))]
    public partial class AssetEndpointProfileProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AssetEndpointProfileProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Authentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Authentication = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication) content.GetValueForProperty("Authentication",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Authentication, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AuthenticationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Uuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Uuid, global::System.Convert.ToString);
            }
            if (content.Contains("TargetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).TargetAddress = (string) content.GetValueForProperty("TargetAddress",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).TargetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).EndpointProfileType = (string) content.GetValueForProperty("EndpointProfileType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).EndpointProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AdditionalConfiguration = (string) content.GetValueForProperty("AdditionalConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AdditionalConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("DiscoveredAssetEndpointProfileRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).DiscoveredAssetEndpointProfileRef = (string) content.GetValueForProperty("DiscoveredAssetEndpointProfileRef",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).DiscoveredAssetEndpointProfileRef, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationX509Credentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationX509Credentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials) content.GetValueForProperty("AuthenticationX509Credentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationX509Credentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.X509CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthenticationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationMethod = (string) content.GetValueForProperty("AuthenticationMethod",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).StatusError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError>) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).StatusError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatusErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AuthenticationUsernamePasswordCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationUsernamePasswordCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials) content.GetValueForProperty("AuthenticationUsernamePasswordCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationUsernamePasswordCredentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.UsernamePasswordCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UsernamePasswordCredentialsUsernameSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsUsernameSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("UsernamePasswordCredentialsPasswordSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("X509CredentialsCertificateSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).X509CredentialsCertificateSecretName = (string) content.GetValueForProperty("X509CredentialsCertificateSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).X509CredentialsCertificateSecretName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AssetEndpointProfileProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Authentication"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Authentication = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication) content.GetValueForProperty("Authentication",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Authentication, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AuthenticationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Uuid"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Uuid = (string) content.GetValueForProperty("Uuid",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).Uuid, global::System.Convert.ToString);
            }
            if (content.Contains("TargetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).TargetAddress = (string) content.GetValueForProperty("TargetAddress",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).TargetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).EndpointProfileType = (string) content.GetValueForProperty("EndpointProfileType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).EndpointProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AdditionalConfiguration = (string) content.GetValueForProperty("AdditionalConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AdditionalConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("DiscoveredAssetEndpointProfileRef"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).DiscoveredAssetEndpointProfileRef = (string) content.GetValueForProperty("DiscoveredAssetEndpointProfileRef",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).DiscoveredAssetEndpointProfileRef, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationX509Credentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationX509Credentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials) content.GetValueForProperty("AuthenticationX509Credentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationX509Credentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.X509CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthenticationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationMethod = (string) content.GetValueForProperty("AuthenticationMethod",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).StatusError = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError>) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).StatusError, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError>(__y, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatusErrorTypeConverter.ConvertFrom));
            }
            if (content.Contains("AuthenticationUsernamePasswordCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationUsernamePasswordCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials) content.GetValueForProperty("AuthenticationUsernamePasswordCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).AuthenticationUsernamePasswordCredentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.UsernamePasswordCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UsernamePasswordCredentialsUsernameSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsUsernameSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("UsernamePasswordCredentialsPasswordSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("X509CredentialsCertificateSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).X509CredentialsCertificateSecretName = (string) content.GetValueForProperty("X509CredentialsCertificateSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal)this).X509CredentialsCertificateSecretName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AssetEndpointProfileProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AssetEndpointProfileProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AssetEndpointProfileProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AssetEndpointProfileProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Defines the Asset Endpoint Profile properties.
    [System.ComponentModel.TypeConverter(typeof(AssetEndpointProfilePropertiesTypeConverter))]
    public partial interface IAssetEndpointProfileProperties

    {

    }
}