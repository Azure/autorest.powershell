// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The updatable properties of the AssetEndpointProfile.</summary>
    public partial class AssetEndpointProfileUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdditionalConfiguration" /> property.</summary>
        private string _additionalConfiguration;

        /// <summary>
        /// Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string AdditionalConfiguration { get => this._additionalConfiguration; set => this._additionalConfiguration = value; }

        /// <summary>Backing field for <see cref="Authentication" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication _authentication;

        /// <summary>Defines the client authentication mechanism to the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication Authentication { get => (this._authentication = this._authentication ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Authentication()); set => this._authentication = value; }

        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string AuthenticationMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).Method; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).Method = value ?? null; }

        /// <summary>Backing field for <see cref="EndpointProfileType" /> property.</summary>
        private string _endpointProfileType;

        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string EndpointProfileType { get => this._endpointProfileType; set => this._endpointProfileType = value; }

        /// <summary>Internal Acessors for Authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal.Authentication { get => (this._authentication = this._authentication ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Authentication()); set { {_authentication = value;} } }

        /// <summary>Internal Acessors for AuthenticationUsernamePasswordCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal.AuthenticationUsernamePasswordCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentials = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AuthenticationX509Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal.AuthenticationX509Credentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509Credentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509Credentials = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="TargetAddress" /> property.</summary>
        private string _targetAddress;

        /// <summary>
        /// The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress
        /// URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string TargetAddress { get => this._targetAddress; set => this._targetAddress = value; }

        /// <summary>The name of the secret containing the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string UsernamePasswordCredentialsPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentialsPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentialsPasswordSecretName = value ?? null; }

        /// <summary>The name of the secret containing the username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string UsernamePasswordCredentialsUsernameSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentialsUsernameSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentialsUsernameSecretName = value ?? null; }

        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string X509CredentialsCertificateSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509CredentialsCertificateSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509CredentialsCertificateSecretName = value ?? null; }

        /// <summary>Creates an new <see cref="AssetEndpointProfileUpdateProperties" /> instance.</summary>
        public AssetEndpointProfileUpdateProperties()
        {

        }
    }
    /// The updatable properties of the AssetEndpointProfile.
    public partial interface IAssetEndpointProfileUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF).",
        SerializedName = @"additionalConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string AdditionalConfiguration { get; set; }
        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the method to authenticate the user of the client at the server.",
        SerializedName = @"method",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Anonymous", "Certificate", "UsernamePassword")]
        string AuthenticationMethod { get; set; }
        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the configuration for the connector type that is being used with the endpoint profile.",
        SerializedName = @"endpointProfileType",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointProfileType { get; set; }
        /// <summary>
        /// The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress
        /// URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.",
        SerializedName = @"targetAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAddress { get; set; }
        /// <summary>The name of the secret containing the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the secret containing the password.",
        SerializedName = @"passwordSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string UsernamePasswordCredentialsPasswordSecretName { get; set; }
        /// <summary>The name of the secret containing the username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the secret containing the username.",
        SerializedName = @"usernameSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string UsernamePasswordCredentialsUsernameSecretName { get; set; }
        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).",
        SerializedName = @"certificateSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string X509CredentialsCertificateSecretName { get; set; }

    }
    /// The updatable properties of the AssetEndpointProfile.
    internal partial interface IAssetEndpointProfileUpdatePropertiesInternal

    {
        /// <summary>
        /// Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF).
        /// </summary>
        string AdditionalConfiguration { get; set; }
        /// <summary>Defines the client authentication mechanism to the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication Authentication { get; set; }
        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Anonymous", "Certificate", "UsernamePassword")]
        string AuthenticationMethod { get; set; }
        /// <summary>
        /// Defines the username and password references when UsernamePassword user authentication mode is selected.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials AuthenticationUsernamePasswordCredentials { get; set; }
        /// <summary>
        /// Defines the certificate reference when Certificate user authentication mode is selected.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials AuthenticationX509Credentials { get; set; }
        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        string EndpointProfileType { get; set; }
        /// <summary>
        /// The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress
        /// URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.
        /// </summary>
        string TargetAddress { get; set; }
        /// <summary>The name of the secret containing the password.</summary>
        string UsernamePasswordCredentialsPasswordSecretName { get; set; }
        /// <summary>The name of the secret containing the username.</summary>
        string UsernamePasswordCredentialsUsernameSecretName { get; set; }
        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        string X509CredentialsCertificateSecretName { get; set; }

    }
}