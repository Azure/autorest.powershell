// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the Asset Endpoint Profile properties.</summary>
    public partial class AssetEndpointProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal
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

        /// <summary>Backing field for <see cref="DiscoveredAssetEndpointProfileRef" /> property.</summary>
        private string _discoveredAssetEndpointProfileRef;

        /// <summary>
        /// Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery
        /// flow. Discovered asset endpoint profile name must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string DiscoveredAssetEndpointProfileRef { get => this._discoveredAssetEndpointProfileRef; set => this._discoveredAssetEndpointProfileRef = value; }

        /// <summary>Backing field for <see cref="EndpointProfileType" /> property.</summary>
        private string _endpointProfileType;

        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string EndpointProfileType { get => this._endpointProfileType; set => this._endpointProfileType = value; }

        /// <summary>Internal Acessors for Authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.Authentication { get => (this._authentication = this._authentication ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Authentication()); set { {_authentication = value;} } }

        /// <summary>Internal Acessors for AuthenticationUsernamePasswordCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.AuthenticationUsernamePasswordCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).UsernamePasswordCredentials = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AuthenticationX509Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.AuthenticationX509Credentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509Credentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509Credentials = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatus Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError> Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusInternal)Status).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusInternal)Status).Error = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Uuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfilePropertiesInternal.Uuid { get => this._uuid; set { {_uuid = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatus _status;

        /// <summary>
        /// Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.AssetEndpointProfileStatus()); }

        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError> StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusInternal)Status).Error; }

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

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; }

        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string X509CredentialsCertificateSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509CredentialsCertificateSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal)Authentication).X509CredentialsCertificateSecretName = value ?? null; }

        /// <summary>Creates an new <see cref="AssetEndpointProfileProperties" /> instance.</summary>
        public AssetEndpointProfileProperties()
        {

        }
    }
    /// Defines the Asset Endpoint Profile properties.
    public partial interface IAssetEndpointProfileProperties :
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
        /// Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery
        /// flow. Discovered asset endpoint profile name must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery flow. Discovered asset endpoint profile name must be provided.",
        SerializedName = @"discoveredAssetEndpointProfileRef",
        PossibleTypes = new [] { typeof(string) })]
        string DiscoveredAssetEndpointProfileRef { get; set; }
        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the configuration for the connector type that is being used with the endpoint profile.",
        SerializedName = @"endpointProfileType",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointProfileType { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Array object to transfer and persist errors that originate from the Edge.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError> StatusError { get;  }
        /// <summary>
        /// The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress
        /// URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
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
        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Globally unique, immutable, non-reusable id.",
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get;  }
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
    /// Defines the Asset Endpoint Profile properties.
    internal partial interface IAssetEndpointProfilePropertiesInternal

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
        /// Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery
        /// flow. Discovered asset endpoint profile name must be provided.
        /// </summary>
        string DiscoveredAssetEndpointProfileRef { get; set; }
        /// <summary>
        /// Defines the configuration for the connector type that is being used with the endpoint profile.
        /// </summary>
        string EndpointProfileType { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Accepted", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatus Status { get; set; }
        /// <summary>Array object to transfer and persist errors that originate from the Edge.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError> StatusError { get; set; }
        /// <summary>
        /// The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress
        /// URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration.
        /// </summary>
        string TargetAddress { get; set; }
        /// <summary>The name of the secret containing the password.</summary>
        string UsernamePasswordCredentialsPasswordSecretName { get; set; }
        /// <summary>The name of the secret containing the username.</summary>
        string UsernamePasswordCredentialsUsernameSecretName { get; set; }
        /// <summary>Globally unique, immutable, non-reusable id.</summary>
        string Uuid { get; set; }
        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        string X509CredentialsCertificateSecretName { get; set; }

    }
}