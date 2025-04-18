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

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

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

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

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
        /// <summary>Identity validation id used for the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
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

    }
    /// Properties of the certificate profile.
    internal partial interface ICertificateProfilePropertiesInternal

    {
        /// <summary>List of renewed certificates.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Certificate { get; set; }
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
        /// <summary>Profile type of the certificate.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("PublicTrust", "PrivateTrust", "PrivateTrustCIPolicy", "VBSEnclave", "PublicTrustTest")]
        string ProfileType { get; set; }
        /// <summary>Status of the current operation on certificate profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Status of the certificate profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Active", "Disabled", "Suspended")]
        string Status { get; set; }

    }
}