// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>The X509 Certificate.</summary>
    public partial class CertificateResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ProxyResource();

        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public byte[] Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Certificate = value ?? null /* byte array */; }

        /// <summary>The certificate's creation date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? Created { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Created; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>The entity tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; }

        /// <summary>The certificate's expiration date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? Expiry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Expiry; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Determines whether certificate has been verified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public bool? IsVerified { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).IsVerified; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).IsVerified = value ?? default(bool); }

        /// <summary>Internal Acessors for Created</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Created { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Created = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Etag</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Etag { get => this._etag; set { {_etag = value;} } }

        /// <summary>Internal Acessors for Expiry</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Expiry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Expiry; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Expiry = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.CertificateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Subject</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Subject = value ?? null; }

        /// <summary>Internal Acessors for Thumbprint</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Thumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Thumbprint = value ?? null; }

        /// <summary>Internal Acessors for Updated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateResponseInternal.Updated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Updated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Updated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateProperties _property;

        /// <summary>properties of a certificate</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.CertificateProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The certificate's subject name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Subject; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>The certificate's thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Thumbprint; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>The certificate's last update date and time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? Updated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificatePropertiesInternal)Property).Updated; }

        /// <summary>Creates an new <see cref="CertificateResponse" /> instance.</summary>
        public CertificateResponse()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// The X509 Certificate.
    public partial interface ICertificateResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProxyResource
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
        /// <summary>The entity tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The entity tag.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get;  }
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
    /// The X509 Certificate.
    internal partial interface ICertificateResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IProxyResourceInternal
    {
        /// <summary>base-64 representation of X509 certificate .cer file or just .pem file content.</summary>
        byte[] Certificate { get; set; }
        /// <summary>The certificate's creation date and time.</summary>
        global::System.DateTime? Created { get; set; }
        /// <summary>The entity tag.</summary>
        string Etag { get; set; }
        /// <summary>The certificate's expiration date and time.</summary>
        global::System.DateTime? Expiry { get; set; }
        /// <summary>Determines whether certificate has been verified.</summary>
        bool? IsVerified { get; set; }
        /// <summary>properties of a certificate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ICertificateProperties Property { get; set; }
        /// <summary>The certificate's subject name.</summary>
        string Subject { get; set; }
        /// <summary>The certificate's thumbprint.</summary>
        string Thumbprint { get; set; }
        /// <summary>The certificate's last update date and time.</summary>
        global::System.DateTime? Updated { get; set; }

    }
}