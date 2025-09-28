// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>
    /// Certificate corresponding to a vault that can be used by clients to register themselves with the vault.
    /// </summary>
    public partial class VaultCertificateResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultCertificateResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultCertificateResponseInternal
    {

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string AuthType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).AuthType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).AuthType = value ?? null; }

        /// <summary>The base64 encoded certificate raw data string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public byte[] Certificate { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Certificate; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Certificate = value ?? null /* byte array */; }

        /// <summary>Certificate friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).FriendlyName = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource Id represents the complete path to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Certificate issuer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Issuer { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Issuer; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Issuer = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultCertificateResponseInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultCertificateResponseInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultCertificateResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCertificateDetails()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultCertificateResponseInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Resource name associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetails _property;

        /// <summary>Certificate details representing the Vault credentials.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetails Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCertificateDetails()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Resource ID of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public long? ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).ResourceId = value ?? default(long); }

        /// <summary>Certificate Subject Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Subject { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Subject; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Subject = value ?? null; }

        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Thumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Thumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).Thumbprint = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Certificate Validity start Date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? ValidFrom { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).ValidFrom; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).ValidFrom = value ?? default(global::System.DateTime); }

        /// <summary>Certificate Validity End Date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public global::System.DateTime? ValidTo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).ValidTo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetailsInternal)Property).ValidTo = value ?? default(global::System.DateTime); }

        /// <summary>Creates an new <see cref="VaultCertificateResponse" /> instance.</summary>
        public VaultCertificateResponse()
        {

        }
    }
    /// Certificate corresponding to a vault that can be used by clients to register themselves with the vault.
    public partial interface IVaultCertificateResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.",
        SerializedName = @"authType",
        PossibleTypes = new [] { typeof(string) })]
        string AuthType { get; set; }
        /// <summary>The base64 encoded certificate raw data string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The base64 encoded certificate raw data string.",
        SerializedName = @"certificate",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] Certificate { get; set; }
        /// <summary>Certificate friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate friendly name.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>Resource Id represents the complete path to the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id represents the complete path to the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Certificate issuer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate issuer.",
        SerializedName = @"issuer",
        PossibleTypes = new [] { typeof(string) })]
        string Issuer { get; set; }
        /// <summary>Resource name associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource name associated with the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Resource ID of the vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID of the vault.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(long) })]
        long? ResourceId { get; set; }
        /// <summary>Certificate Subject Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate Subject Name.",
        SerializedName = @"subject",
        PossibleTypes = new [] { typeof(string) })]
        string Subject { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate thumbprint.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get; set; }
        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }
        /// <summary>Certificate Validity start Date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate Validity start Date time.",
        SerializedName = @"validFrom",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ValidFrom { get; set; }
        /// <summary>Certificate Validity End Date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate Validity End Date time.",
        SerializedName = @"validTo",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ValidTo { get; set; }

    }
    /// Certificate corresponding to a vault that can be used by clients to register themselves with the vault.
    internal partial interface IVaultCertificateResponseInternal

    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        string AuthType { get; set; }
        /// <summary>The base64 encoded certificate raw data string.</summary>
        byte[] Certificate { get; set; }
        /// <summary>Certificate friendly name.</summary>
        string FriendlyName { get; set; }
        /// <summary>Resource Id represents the complete path to the resource.</summary>
        string Id { get; set; }
        /// <summary>Certificate issuer.</summary>
        string Issuer { get; set; }
        /// <summary>Resource name associated with the resource.</summary>
        string Name { get; set; }
        /// <summary>Certificate details representing the Vault credentials.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCertificateDetails Property { get; set; }
        /// <summary>Resource ID of the vault.</summary>
        long? ResourceId { get; set; }
        /// <summary>Certificate Subject Name.</summary>
        string Subject { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        string Thumbprint { get; set; }
        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        string Type { get; set; }
        /// <summary>Certificate Validity start Date time.</summary>
        global::System.DateTime? ValidFrom { get; set; }
        /// <summary>Certificate Validity End Date time.</summary>
        global::System.DateTime? ValidTo { get; set; }

    }
}