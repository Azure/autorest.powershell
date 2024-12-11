// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.PowerShell;

    /// <summary>The updatable properties of the AssetEndpointProfile.</summary>
    [System.ComponentModel.TypeConverter(typeof(AssetEndpointProfileUpdatePropertiesTypeConverter))]
    public partial class AssetEndpointProfileUpdateProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AssetEndpointProfileUpdateProperties(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).Authentication = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication) content.GetValueForProperty("Authentication",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).Authentication, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AuthenticationTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).TargetAddress = (string) content.GetValueForProperty("TargetAddress",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).TargetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).EndpointProfileType = (string) content.GetValueForProperty("EndpointProfileType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).EndpointProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AdditionalConfiguration = (string) content.GetValueForProperty("AdditionalConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AdditionalConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationX509Credentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationX509Credentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials) content.GetValueForProperty("AuthenticationX509Credentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationX509Credentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.X509CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthenticationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationMethod = (string) content.GetValueForProperty("AuthenticationMethod",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationUsernamePasswordCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationUsernamePasswordCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials) content.GetValueForProperty("AuthenticationUsernamePasswordCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationUsernamePasswordCredentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.UsernamePasswordCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UsernamePasswordCredentialsUsernameSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsUsernameSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("UsernamePasswordCredentialsPasswordSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("X509CredentialsCertificateSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).X509CredentialsCertificateSecretName = (string) content.GetValueForProperty("X509CredentialsCertificateSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).X509CredentialsCertificateSecretName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AssetEndpointProfileUpdateProperties(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).Authentication = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication) content.GetValueForProperty("Authentication",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).Authentication, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AuthenticationTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).TargetAddress = (string) content.GetValueForProperty("TargetAddress",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).TargetAddress, global::System.Convert.ToString);
            }
            if (content.Contains("EndpointProfileType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).EndpointProfileType = (string) content.GetValueForProperty("EndpointProfileType",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).EndpointProfileType, global::System.Convert.ToString);
            }
            if (content.Contains("AdditionalConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AdditionalConfiguration = (string) content.GetValueForProperty("AdditionalConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AdditionalConfiguration, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationX509Credentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationX509Credentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials) content.GetValueForProperty("AuthenticationX509Credentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationX509Credentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.X509CredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AuthenticationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationMethod = (string) content.GetValueForProperty("AuthenticationMethod",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("AuthenticationUsernamePasswordCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationUsernamePasswordCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials) content.GetValueForProperty("AuthenticationUsernamePasswordCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).AuthenticationUsernamePasswordCredentials, Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.UsernamePasswordCredentialsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UsernamePasswordCredentialsUsernameSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsUsernameSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsUsernameSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("UsernamePasswordCredentialsPasswordSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName = (string) content.GetValueForProperty("UsernamePasswordCredentialsPasswordSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).UsernamePasswordCredentialsPasswordSecretName, global::System.Convert.ToString);
            }
            if (content.Contains("X509CredentialsCertificateSecretName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).X509CredentialsCertificateSecretName = (string) content.GetValueForProperty("X509CredentialsCertificateSecretName",((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)this).X509CredentialsCertificateSecretName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AssetEndpointProfileUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AssetEndpointProfileUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AssetEndpointProfileUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AssetEndpointProfileUpdateProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The updatable properties of the AssetEndpointProfile.
    [System.ComponentModel.TypeConverter(typeof(AssetEndpointProfileUpdatePropertiesTypeConverter))]
    public partial interface IAssetEndpointProfileUpdateProperties

    {

    }
}