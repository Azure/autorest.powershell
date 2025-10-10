// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The description of an X509 CA Certificate.</summary>
    public partial class CertificateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private byte[] _certificate;

        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public byte[] Certificate { get => this._certificate; set => this._certificate = value; }

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private global::System.DateTime? _created;

        /// <summary>The certificate's creation date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public global::System.DateTime? Created { get => this._created; }

        /// <summary>Backing field for <see cref="Expiry" /> property.</summary>
        private global::System.DateTime? _expiry;

        /// <summary>The certificate's expiration date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public global::System.DateTime? Expiry { get => this._expiry; }

        /// <summary>Backing field for <see cref="IsVerified" /> property.</summary>
        private bool? _isVerified;

        /// <summary>Determines whether certificate has been verified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public bool? IsVerified { get => this._isVerified; set => this._isVerified = value; }

        /// <summary>Internal Acessors for Created</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal.Created { get => this._created; set { {_created = value;} } }

        /// <summary>Internal Acessors for Expiry</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal.Expiry { get => this._expiry; set { {_expiry = value;} } }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal.Subject { get => this._subject; set { {_subject = value;} } }

        /// <summary>Internal Acessors for Thumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal.Thumbprint { get => this._thumbprint; set { {_thumbprint = value;} } }

        /// <summary>Internal Acessors for Updated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal.Updated { get => this._updated; set { {_updated = value;} } }

        /// <summary>Backing field for <see cref="Subject" /> property.</summary>
        private string _subject;

        /// <summary>The certificate's subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Subject { get => this._subject; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>The certificate's thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; }

        /// <summary>Backing field for <see cref="Updated" /> property.</summary>
        private global::System.DateTime? _updated;

        /// <summary>The certificate's last update date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public global::System.DateTime? Updated { get => this._updated; }

        /// <summary>Creates an new <see cref="CertificateProperties" /> instance.</summary>
        public CertificateProperties()
        {

        }
    }
    /// The description of an X509 CA Certificate.
    public partial interface ICertificateProperties :
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
        /// <summary>The certificate's creation date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate's creation date and time.",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Created { get;  }
        /// <summary>The certificate's expiration date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate's expiration date and time.",
        SerializedName = @"expiry",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Expiry { get;  }
        /// <summary>Determines whether certificate has been verified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines whether certificate has been verified.",
        SerializedName = @"isVerified",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsVerified { get; set; }
        /// <summary>The certificate's subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate's subject name.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get;  }
        /// <summary>The certificate's thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate's thumbprint.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get;  }
        /// <summary>The certificate's last update date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The certificate's last update date and time.",
        SerializedName = @"updated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Updated { get;  }

    }
    /// The description of an X509 CA Certificate.
    internal partial interface ICertificatePropertiesInternal

    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        byte[] Certificate { get; set; }
        /// <summary>The certificate's creation date and time.</summary>
        global::System.DateTime? Created { get; set; }
        /// <summary>The certificate's expiration date and time.</summary>
        global::System.DateTime? Expiry { get; set; }
        /// <summary>Determines whether certificate has been verified.</summary>
        bool? IsVerified { get; set; }
        /// <summary>The certificate's subject name.</summary>
        string Subject { get; set; }
        /// <summary>The certificate's thumbprint.</summary>
        string Thumbprint { get; set; }
        /// <summary>The certificate's last update date and time.</summary>
        global::System.DateTime? Updated { get; set; }

    }
}