// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of certificate</summary>
    public partial class CertificateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private string _certificate;

        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Certificate { get => this._certificate; }

        /// <summary>Backing field for <see cref="ExpiryUtc" /> property.</summary>
        private global::System.DateTime? _expiryUtc;

        /// <summary>The certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? ExpiryUtc { get => this._expiryUtc; }

        /// <summary>Internal Acessors for Certificate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Certificate { get => this._certificate; set { {_certificate = value;} } }

        /// <summary>Internal Acessors for ExpiryUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.ExpiryUtc { get => this._expiryUtc; set { {_expiryUtc = value;} } }

        /// <summary>Internal Acessors for NotBeforeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.NotBeforeUtc { get => this._notBeforeUtc; set { {_notBeforeUtc = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Subject { get => this._subject; set { {_subject = value;} } }

        /// <summary>Internal Acessors for Thumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificatePropertiesInternal.Thumbprint { get => this._thumbprint; set { {_thumbprint = value;} } }

        /// <summary>Backing field for <see cref="NotBeforeUtc" /> property.</summary>
        private global::System.DateTime? _notBeforeUtc;

        /// <summary>The certificate not before date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime? NotBeforeUtc { get => this._notBeforeUtc; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The certificate status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        /// <summary>The certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Subject { get => this._subject; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>The certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; }

        /// <summary>Creates an new <see cref="CertificateProperties" /> instance.</summary>
        public CertificateProperties()
        {

        }
    }
    /// The properties of certificate
    public partial interface ICertificateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate as a UTF-8 encoded base 64 string.",
        SerializedName = @"certificate",
        PossibleTypes = new [] { typeof(string) })]
        string Certificate { get;  }
        /// <summary>The certificate expiry date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate expiry date.",
        SerializedName = @"expiryUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExpiryUtc { get;  }
        /// <summary>The certificate not before date.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate not before date.",
        SerializedName = @"notBeforeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NotBeforeUtc { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>The certificate status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Active", "Inactive", "Expired", "Revoked")]
        string Status { get;  }
        /// <summary>The certificate subject.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate subject.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get;  }
        /// <summary>The certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate thumbprint.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get;  }

    }
    /// The properties of certificate
    internal partial interface ICertificatePropertiesInternal

    {
        /// <summary>The certificate as a UTF-8 encoded base 64 string.</summary>
        string Certificate { get; set; }
        /// <summary>The certificate expiry date.</summary>
        global::System.DateTime? ExpiryUtc { get; set; }
        /// <summary>The certificate not before date.</summary>
        global::System.DateTime? NotBeforeUtc { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>The certificate status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("Active", "Inactive", "Expired", "Revoked")]
        string Status { get; set; }
        /// <summary>The certificate subject.</summary>
        string Subject { get; set; }
        /// <summary>The certificate thumbprint.</summary>
        string Thumbprint { get; set; }

    }
}