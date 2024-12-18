// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The type used for update operations of the AssetEndpointProfile.</summary>
    public partial class AssetEndpointProfileUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateInternal
    {

        /// <summary>
        /// Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string AdditionalConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AdditionalConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AdditionalConfiguration = value ?? null; }

        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string AuthenticationMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AuthenticationMethod; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AuthenticationMethod = value ?? null; }

        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string EndpointProfileType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).EndpointProfileType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).EndpointProfileType = value ?? null; }

        /// <summary>Internal Acessors for Authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateInternal.Authentication { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).Authentication; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).Authentication = value; }

        /// <summary>Internal Acessors for AuthenticationUsernamePasswordCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateInternal.AuthenticationUsernamePasswordCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AuthenticationUsernamePasswordCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AuthenticationUsernamePasswordCredentials = value; }

        /// <summary>Internal Acessors for AuthenticationX509Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateInternal.AuthenticationX509Credentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AuthenticationX509Credentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).AuthenticationX509Credentials = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileUpdateProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Tags()); set => this._tag = value; }

        /// <summary>
        /// The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress
        /// URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string TargetAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).TargetAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).TargetAddress = value ?? null; }

        /// <summary>The name of the secret containing the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string UsernamePasswordCredentialsPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).UsernamePasswordCredentialsPasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).UsernamePasswordCredentialsPasswordSecretName = value ?? null; }

        /// <summary>The name of the secret containing the username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string UsernamePasswordCredentialsUsernameSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).UsernamePasswordCredentialsUsernameSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).UsernamePasswordCredentialsUsernameSecretName = value ?? null; }

        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string X509CredentialsCertificateSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).X509CredentialsCertificateSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdatePropertiesInternal)Property).X509CredentialsCertificateSecretName = value ?? null; }

        /// <summary>Creates an new <see cref="AssetEndpointProfileUpdate" /> instance.</summary>
        public AssetEndpointProfileUpdate()
        {

        }
    }
    /// The type used for update operations of the AssetEndpointProfile.
    public partial interface IAssetEndpointProfileUpdate :
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
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get; set; }
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
    /// The type used for update operations of the AssetEndpointProfile.
    internal partial interface IAssetEndpointProfileUpdateInternal

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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileUpdateProperties Property { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITags Tag { get; set; }
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