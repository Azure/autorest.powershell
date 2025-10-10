// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    public partial class VerificationCodeResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IVerificationCodeResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private byte[] _certificate;

        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public byte[] Certificate { get => this._certificate; set => this._certificate = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private string _created;

        /// <summary>Certificate created time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Created { get => this._created; set => this._created = value; }

        /// <summary>Backing field for <see cref="Expiry" /> property.</summary>
        private string _expiry;

        /// <summary>Code expiry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Expiry { get => this._expiry; set => this._expiry = value; }

        /// <summary>Backing field for <see cref="IsVerified" /> property.</summary>
        private bool? _isVerified;

        /// <summary>Indicate if the certificate is verified by owner of private key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public bool? IsVerified { get => this._isVerified; set => this._isVerified = value; }

        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        /// <summary>Certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Subject { get => this._subject; set => this._subject = value; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; set => this._thumbprint = value; }

        /// <summary>Backing field for <see cref="Updated" /> property.</summary>
        private string _updated;

        /// <summary>Certificate updated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Updated { get => this._updated; set => this._updated = value; }

        /// <summary>Backing field for <see cref="VerificationCode" /> property.</summary>
        private string _verificationCode;

        /// <summary>Verification code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string VerificationCode { get => this._verificationCode; set => this._verificationCode = value; }

        /// <summary>Creates an new <see cref="VerificationCodeResponseProperties" /> instance.</summary>
        public VerificationCodeResponseProperties()
        {

        }
    }
    public partial interface IVerificationCodeResponseProperties :
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
    internal partial interface IVerificationCodeResponsePropertiesInternal

    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        byte[] Certificate { get; set; }
        /// <summary>Certificate created time.</summary>
        string Created { get; set; }
        /// <summary>Code expiry.</summary>
        string Expiry { get; set; }
        /// <summary>Indicate if the certificate is verified by owner of private key.</summary>
        bool? IsVerified { get; set; }
        /// <summary>Certificate subject.</summary>
        string Subject { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        string Thumbprint { get; set; }
        /// <summary>Certificate updated time.</summary>
        string Updated { get; set; }
        /// <summary>Verification code.</summary>
        string VerificationCode { get; set; }

    }
}