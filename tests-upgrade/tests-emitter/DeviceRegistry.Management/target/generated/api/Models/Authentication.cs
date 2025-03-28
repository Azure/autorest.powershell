// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Definition of the client authentication mechanism to the server.</summary>
    public partial class Authentication :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthentication,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal
    {

        /// <summary>Backing field for <see cref="Method" /> property.</summary>
        private string _method;

        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Method { get => this._method; set => this._method = value; }

        /// <summary>Internal Acessors for UsernamePasswordCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal.UsernamePasswordCredentials { get => (this._usernamePasswordCredentials = this._usernamePasswordCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.UsernamePasswordCredentials()); set { {_usernamePasswordCredentials = value;} } }

        /// <summary>Internal Acessors for X509Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAuthenticationInternal.X509Credentials { get => (this._x509Credentials = this._x509Credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.X509Credentials()); set { {_x509Credentials = value;} } }

        /// <summary>Backing field for <see cref="UsernamePasswordCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials _usernamePasswordCredentials;

        /// <summary>
        /// Defines the username and password references when UsernamePassword user authentication mode is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials UsernamePasswordCredentials { get => (this._usernamePasswordCredentials = this._usernamePasswordCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.UsernamePasswordCredentials()); set => this._usernamePasswordCredentials = value; }

        /// <summary>The name of the secret containing the password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string UsernamePasswordCredentialsPasswordSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentialsInternal)UsernamePasswordCredentials).PasswordSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentialsInternal)UsernamePasswordCredentials).PasswordSecretName = value ?? null; }

        /// <summary>The name of the secret containing the username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string UsernamePasswordCredentialsUsernameSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentialsInternal)UsernamePasswordCredentials).UsernameSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentialsInternal)UsernamePasswordCredentials).UsernameSecretName = value ?? null; }

        /// <summary>Backing field for <see cref="X509Credentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials _x509Credentials;

        /// <summary>
        /// Defines the certificate reference when Certificate user authentication mode is selected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials X509Credentials { get => (this._x509Credentials = this._x509Credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.X509Credentials()); set => this._x509Credentials = value; }

        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string X509CredentialsCertificateSecretName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509CredentialsInternal)X509Credentials).CertificateSecretName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509CredentialsInternal)X509Credentials).CertificateSecretName = value ?? null; }

        /// <summary>Creates an new <see cref="Authentication" /> instance.</summary>
        public Authentication()
        {

        }
    }
    /// Definition of the client authentication mechanism to the server.
    public partial interface IAuthentication :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the method to authenticate the user of the client at the server.",
        SerializedName = @"method",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Anonymous", "Certificate", "UsernamePassword")]
        string Method { get; set; }
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
    /// Definition of the client authentication mechanism to the server.
    internal partial interface IAuthenticationInternal

    {
        /// <summary>Defines the method to authenticate the user of the client at the server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Anonymous", "Certificate", "UsernamePassword")]
        string Method { get; set; }
        /// <summary>
        /// Defines the username and password references when UsernamePassword user authentication mode is selected.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IUsernamePasswordCredentials UsernamePasswordCredentials { get; set; }
        /// <summary>The name of the secret containing the password.</summary>
        string UsernamePasswordCredentialsPasswordSecretName { get; set; }
        /// <summary>The name of the secret containing the username.</summary>
        string UsernamePasswordCredentialsUsernameSecretName { get; set; }
        /// <summary>
        /// Defines the certificate reference when Certificate user authentication mode is selected.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IX509Credentials X509Credentials { get; set; }
        /// <summary>
        /// The name of the secret containing the certificate and private key (e.g. stored as .der/.pem or .der/.pfx).
        /// </summary>
        string X509CredentialsCertificateSecretName { get; set; }

    }
}