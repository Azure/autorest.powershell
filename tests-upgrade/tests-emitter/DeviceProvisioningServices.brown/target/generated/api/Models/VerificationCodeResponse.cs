// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Description of the response of the verification code.</summary>
    public partial class VerificationCodeResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseInternal
    {

        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public byte[] Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Certificate = value ?? null /* byte array */; }

        /// <summary>Certificate created time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Created { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Created = value ?? null; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>Request etag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>Code expiry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Expiry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Expiry; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Expiry = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Indicate if the certificate is verified by owner of private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public bool? IsVerified { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).IsVerified; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).IsVerified = value ?? default(bool); }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.VerificationCodeResponseProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.VerificationCodeResponseProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Subject = value ?? null; }

        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Thumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Thumbprint = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Certificate updated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Updated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Updated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).Updated = value ?? null; }

        /// <summary>Verification code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string VerificationCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).VerificationCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal)Property).VerificationCode = value ?? null; }

        /// <summary>Creates an new <see cref="VerificationCodeResponse" /> instance.</summary>
        public VerificationCodeResponse()
        {

        }
    }
    /// Description of the response of the verification code.
    public partial interface IVerificationCodeResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"base-64 representation of X509 certificate .cer file or just .pem file content.",
        SerializedName = @"certificate",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] Certificate { get; set; }
        /// <summary>Certificate created time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate created time.",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(string) })]
        string Created { get; set; }
        /// <summary>Request etag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Request etag.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
        /// <summary>Code expiry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Code expiry.",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(string) })]
        string Expiry { get; set; }
        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Indicate if the certificate is verified by owner of private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicate if the certificate is verified by owner of private key.",
        SerializedName = @"isVerified",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsVerified { get; set; }
        /// <summary>Name of certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of certificate.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate subject.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate thumbprint.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get; set; }
        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }
        /// <summary>Certificate updated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate updated time.",
        SerializedName = @"updated",
        PossibleTypes = new [] { typeof(string) })]
        string Updated { get; set; }
        /// <summary>Verification code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Verification code.",
        SerializedName = @"verificationCode",
        PossibleTypes = new [] { typeof(string) })]
        string VerificationCode { get; set; }

    }
    /// Description of the response of the verification code.
    internal partial interface IVerificationCodeResponseInternal

    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        byte[] Certificate { get; set; }
        /// <summary>Certificate created time.</summary>
        string Created { get; set; }
        /// <summary>Request etag.</summary>
        string Etag { get; set; }
        /// <summary>Code expiry.</summary>
        string Expiry { get; set; }
        /// <summary>The resource identifier.</summary>
        string Id { get; set; }
        /// <summary>Indicate if the certificate is verified by owner of private key.</summary>
        bool? IsVerified { get; set; }
        /// <summary>Name of certificate.</summary>
        string Name { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties Property { get; set; }
        /// <summary>Certificate subject.</summary>
        string Subject { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        string Thumbprint { get; set; }
        /// <summary>The resource type.</summary>
        string Type { get; set; }
        /// <summary>Certificate updated time.</summary>
        string Updated { get; set; }
        /// <summary>Verification code.</summary>
        string VerificationCode { get; set; }

    }
}