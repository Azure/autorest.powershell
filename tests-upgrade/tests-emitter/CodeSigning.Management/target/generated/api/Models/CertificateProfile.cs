// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Certificate profile resource.</summary>
    public partial class CertificateProfile :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ProxyResource();

        /// <summary>Backing field for <see cref="AzureAsyncOperation" /> property.</summary>
        private string _azureAsyncOperation;

        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string AzureAsyncOperation { get => this._azureAsyncOperation; set => this._azureAsyncOperation = value; }

        /// <summary>List of renewed certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Certificate; }

        /// <summary>Used as L in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string City { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).City; }

        /// <summary>Used as CN in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string CommonName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).CommonName; }

        /// <summary>Used as C in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Country; }

        /// <summary>Enhanced key usage of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string EnhancedKeyUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).EnhancedKeyUsage; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Identity validation id used for the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string IdentityValidationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IdentityValidationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IdentityValidationId = value ?? null; }

        /// <summary>
        /// Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public bool? IncludeCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeCity = value ?? default(bool); }

        /// <summary>
        /// Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public bool? IncludeCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeCountry; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeCountry = value ?? default(bool); }

        /// <summary>Whether to include PC in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public bool? IncludePostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludePostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludePostalCode = value ?? default(bool); }

        /// <summary>
        /// Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public bool? IncludeState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeState = value ?? default(bool); }

        /// <summary>Whether to include STREET in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public bool? IncludeStreetAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeStreetAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).IncludeStreetAddress = value ?? default(bool); }

        /// <summary>Internal Acessors for Certificate</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate> Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Certificate = value; }

        /// <summary>Internal Acessors for City</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.City { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).City = value; }

        /// <summary>Internal Acessors for CommonName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.CommonName { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).CommonName; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).CommonName = value; }

        /// <summary>Internal Acessors for Country</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Country = value; }

        /// <summary>Internal Acessors for EnhancedKeyUsage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.EnhancedKeyUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).EnhancedKeyUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).EnhancedKeyUsage = value; }

        /// <summary>Internal Acessors for Organization</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.Organization { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Organization; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Organization = value; }

        /// <summary>Internal Acessors for OrganizationUnit</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.OrganizationUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).OrganizationUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).OrganizationUnit = value; }

        /// <summary>Internal Acessors for PostalCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.PostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).PostalCode = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfileProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).State = value; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for StreetAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal.StreetAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).StreetAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).StreetAddress = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Used as O in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string Organization { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Organization; }

        /// <summary>Used as OU in the private trust certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string OrganizationUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).OrganizationUnit; }

        /// <summary>Used as PC in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string PostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).PostalCode; }

        /// <summary>Profile type of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string ProfileType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).ProfileType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).ProfileType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfileProperties()); set => this._property = value; }

        /// <summary>Status of the current operation on certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Used as S in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).State; }

        /// <summary>Status of the certificate profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).Status; }

        /// <summary>Used as STREET in the certificate subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inlined)]
        public string StreetAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfilePropertiesInternal)Property).StreetAddress; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="CertificateProfile" /> instance.</summary>
        public CertificateProfile()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Azure-AsyncOperation", out var __azureAsyncOperationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).AzureAsyncOperation = System.Linq.Enumerable.FirstOrDefault(__azureAsyncOperationHeader0) is string __headerAzureAsyncOperationHeader0 ? __headerAzureAsyncOperationHeader0 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader1) is string __headerRetryAfterHeader1 ? int.TryParse( __headerRetryAfterHeader1, out int __headerRetryAfterHeader1Value ) ? __headerRetryAfterHeader1Value : default(int?) : default(int?);
            }
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Certificate profile resource.
    public partial interface ICertificateProfile :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IProxyResource
    {
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Azure-AsyncOperation",
        PossibleTypes = new [] { typeof(string) })]
        string AzureAsyncOperation { get; set; }
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
        Required = false,
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

        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
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
    /// Certificate profile resource.
    internal partial interface ICertificateProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IProxyResourceInternal
    {
        string AzureAsyncOperation { get; set; }
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties Property { get; set; }
        /// <summary>Status of the current operation on certificate profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

        int? RetryAfter { get; set; }
        /// <summary>Used as S in the certificate subject name.</summary>
        string State { get; set; }
        /// <summary>Status of the certificate profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("Active", "Disabled", "Suspended")]
        string Status { get; set; }
        /// <summary>Used as STREET in the certificate subject name.</summary>
        string StreetAddress { get; set; }

    }
}