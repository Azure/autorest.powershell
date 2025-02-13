// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Properties of the certificate profile.</summary>
    public partial class CertificateProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> _certificate;

        /// <summary>List of renewed certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Certificate { get => this._certificate; }

        /// <summary>Backing field for <see cref="City" /> property.</summary>
        private string _city;

        /// <summary>Used as L in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string City { get => this._city; }

        /// <summary>Backing field for <see cref="CommonName" /> property.</summary>
        private string _commonName;

        /// <summary>Used as CN in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string CommonName { get => this._commonName; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Used as C in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Country { get => this._country; }

        /// <summary>Backing field for <see cref="EnhancedKeyUsage" /> property.</summary>
        private string _enhancedKeyUsage;

        /// <summary>Enhanced key usage of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string EnhancedKeyUsage { get => this._enhancedKeyUsage; }

        /// <summary>Backing field for <see cref="IdentityValidationId" /> property.</summary>
        private string _identityValidationId;

        /// <summary>Identity validation id used for the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string IdentityValidationId { get => this._identityValidationId; set => this._identityValidationId = value; }

        /// <summary>Backing field for <see cref="IncludeCity" /> property.</summary>
        private bool? _includeCity;

        /// <summary>
        /// Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public bool? IncludeCity { get => this._includeCity; set => this._includeCity = value; }

        /// <summary>Backing field for <see cref="IncludeCountry" /> property.</summary>
        private bool? _includeCountry;

        /// <summary>
        /// Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public bool? IncludeCountry { get => this._includeCountry; set => this._includeCountry = value; }

        /// <summary>Backing field for <see cref="IncludePostalCode" /> property.</summary>
        private bool? _includePostalCode;

        /// <summary>Whether to include PC in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public bool? IncludePostalCode { get => this._includePostalCode; set => this._includePostalCode = value; }

        /// <summary>Backing field for <see cref="IncludeState" /> property.</summary>
        private bool? _includeState;

        /// <summary>
        /// Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public bool? IncludeState { get => this._includeState; set => this._includeState = value; }

        /// <summary>Backing field for <see cref="IncludeStreetAddress" /> property.</summary>
        private bool? _includeStreetAddress;

        /// <summary>Whether to include STREET in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public bool? IncludeStreetAddress { get => this._includeStreetAddress; set => this._includeStreetAddress = value; }

        /// <summary>Internal Acessors for Certificate</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.Certificate { get => this._certificate; set { {_certificate = value;} } }

        /// <summary>Internal Acessors for City</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.City { get => this._city; set { {_city = value;} } }

        /// <summary>Internal Acessors for CommonName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.CommonName { get => this._commonName; set { {_commonName = value;} } }

        /// <summary>Internal Acessors for Country</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.Country { get => this._country; set { {_country = value;} } }

        /// <summary>Internal Acessors for EnhancedKeyUsage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.EnhancedKeyUsage { get => this._enhancedKeyUsage; set { {_enhancedKeyUsage = value;} } }

        /// <summary>Internal Acessors for Organization</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.Organization { get => this._organization; set { {_organization = value;} } }

        /// <summary>Internal Acessors for OrganizationUnit</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.OrganizationUnit { get => this._organizationUnit; set { {_organizationUnit = value;} } }

        /// <summary>Internal Acessors for PostalCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.PostalCode { get => this._postalCode; set { {_postalCode = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for StreetAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.StreetAddress { get => this._streetAddress; set { {_streetAddress = value;} } }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        /// <summary>Used as O in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; }

        /// <summary>Backing field for <see cref="OrganizationUnit" /> property.</summary>
        private string _organizationUnit;

        /// <summary>Used as OU in the private trust certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string OrganizationUnit { get => this._organizationUnit; }

        /// <summary>Backing field for <see cref="PostalCode" /> property.</summary>
        private string _postalCode;

        /// <summary>Used as PC in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string PostalCode { get => this._postalCode; }

        /// <summary>Backing field for <see cref="ProfileType" /> property.</summary>
        private string _profileType;

        /// <summary>Profile type of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string ProfileType { get => this._profileType; set => this._profileType = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Status of the current operation on certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Used as S in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string State { get => this._state; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="StreetAddress" /> property.</summary>
        private string _streetAddress;

        /// <summary>Used as STREET in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string StreetAddress { get => this._streetAddress; }

        /// <summary>Creates an new <see cref="CertificateProfileProperties" /> instance.</summary>
        public CertificateProfileProperties()
        {

        }
    }
    /// Properties of the certificate profile.
    public partial interface ICertificateProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>List of renewed certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of renewed certificates.",
        SerializedName = @"certificates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Certificate { get;  }
        /// <summary>Used as L in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as L in the certificate subject name.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string City { get;  }
        /// <summary>Used as CN in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as CN in the certificate subject name.",
        SerializedName = @"commonName",
        PossibleTypes = new [] { typeof(string) })]
        string CommonName { get;  }
        /// <summary>Used as C in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as C in the certificate subject name.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get;  }
        /// <summary>Enhanced key usage of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Enhanced key usage of the certificate.",
        SerializedName = @"enhancedKeyUsage",
        PossibleTypes = new [] { typeof(string) })]
        string EnhancedKeyUsage { get;  }
        /// <summary>Identity validation id used for the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity validation id used for the certificate subject name.",
        SerializedName = @"identityValidationId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityValidationId { get; set; }
        /// <summary>
        /// Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types",
        SerializedName = @"includeCity",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludeCity { get; set; }
        /// <summary>
        /// Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types",
        SerializedName = @"includeCountry",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludeCountry { get; set; }
        /// <summary>Whether to include PC in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to include PC in the certificate subject name.",
        SerializedName = @"includePostalCode",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludePostalCode { get; set; }
        /// <summary>
        /// Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types",
        SerializedName = @"includeState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludeState { get; set; }
        /// <summary>Whether to include STREET in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to include STREET in the certificate subject name.",
        SerializedName = @"includeStreetAddress",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IncludeStreetAddress { get; set; }
        /// <summary>Used as O in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as O in the certificate subject name.",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get;  }
        /// <summary>Used as OU in the private trust certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as OU in the private trust certificate subject name.",
        SerializedName = @"organizationUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationUnit { get;  }
        /// <summary>Used as PC in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as PC in the certificate subject name.",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string PostalCode { get;  }
        /// <summary>Profile type of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Profile type of the certificate.",
        SerializedName = @"profileType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("PublicTrust", "PrivateTrust", "PrivateTrustCIPolicy", "VBSEnclave", "PublicTrustTest")]
        string ProfileType { get; set; }
        /// <summary>Status of the current operation on certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the current operation on certificate profile.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Used as S in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as S in the certificate subject name.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get;  }
        /// <summary>Status of the certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the certificate profile.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Active", "Disabled", "Suspended")]
        string Status { get;  }
        /// <summary>Used as STREET in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Used as STREET in the certificate subject name.",
        SerializedName = @"streetAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StreetAddress { get;  }

    }
    /// Properties of the certificate profile.
    internal partial interface ICertificateProfilePropertiesInternal

    {
        /// <summary>List of renewed certificates.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Certificate { get; set; }
        /// <summary>Used as L in the certificate subject name.</summary>
        string City { get; set; }
        /// <summary>Used as CN in the certificate subject name.</summary>
        string CommonName { get; set; }
        /// <summary>Used as C in the certificate subject name.</summary>
        string Country { get; set; }
        /// <summary>Enhanced key usage of the certificate.</summary>
        string EnhancedKeyUsage { get; set; }
        /// <summary>Identity validation id used for the certificate subject name.</summary>
        string IdentityValidationId { get; set; }
        /// <summary>
        /// Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        bool? IncludeCity { get; set; }
        /// <summary>
        /// Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        bool? IncludeCountry { get; set; }
        /// <summary>Whether to include PC in the certificate subject name.</summary>
        bool? IncludePostalCode { get; set; }
        /// <summary>
        /// Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        bool? IncludeState { get; set; }
        /// <summary>Whether to include STREET in the certificate subject name.</summary>
        bool? IncludeStreetAddress { get; set; }
        /// <summary>Used as O in the certificate subject name.</summary>
        string Organization { get; set; }
        /// <summary>Used as OU in the private trust certificate subject name.</summary>
        string OrganizationUnit { get; set; }
        /// <summary>Used as PC in the certificate subject name.</summary>
        string PostalCode { get; set; }
        /// <summary>Profile type of the certificate.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("PublicTrust", "PrivateTrust", "PrivateTrustCIPolicy", "VBSEnclave", "PublicTrustTest")]
        string ProfileType { get; set; }
        /// <summary>Status of the current operation on certificate profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Used as S in the certificate subject name.</summary>
        string State { get; set; }
        /// <summary>Status of the certificate profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Active", "Disabled", "Suspended")]
        string Status { get; set; }
        /// <summary>Used as STREET in the certificate subject name.</summary>
        string StreetAddress { get; set; }

    }
}