// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Vault extended information.</summary>
    public partial class VaultExtendedInfoResource :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoResource,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ProxyResource();

        /// <summary>Algorithm for Vault ExtendedInfo</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Algorithm { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).Algorithm; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).Algorithm = value ?? null; }

        /// <summary>Encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string EncryptionKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).EncryptionKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).EncryptionKey = value ?? null; }

        /// <summary>Encryption key thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string EncryptionKeyThumbprint { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).EncryptionKeyThumbprint; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).EncryptionKeyThumbprint = value ?? null; }

        /// <summary>Backing field for <see cref="Etag" /> property.</summary>
        private string _etag;

        /// <summary>etag for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Etag { get => this._etag; set => this._etag = value; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Integrity key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string IntegrityKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).IntegrityKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoInternal)Property).IntegrityKey = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfoResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultExtendedInfo()); set { {_property = value;} } }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo _property;

        /// <summary>Vault extended information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultExtendedInfo()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }

        /// <summary>Creates an new <see cref="VaultExtendedInfoResource" /> instance.</summary>
        public VaultExtendedInfoResource()
        {

        }
    }
    /// Vault extended information.
    public partial interface IVaultExtendedInfoResource :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IProxyResource
    {
        /// <summary>Algorithm for Vault ExtendedInfo</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Algorithm for Vault ExtendedInfo",
        SerializedName = @"algorithm",
        PossibleTypes = new [] { typeof(string) })]
        string Algorithm { get; set; }
        /// <summary>Encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Encryption key.",
        SerializedName = @"encryptionKey",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionKey { get; set; }
        /// <summary>Encryption key thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Encryption key thumbprint.",
        SerializedName = @"encryptionKeyThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionKeyThumbprint { get; set; }
        /// <summary>etag for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"etag for the resource.",
        SerializedName = @"etag",
        PossibleTypes = new [] { typeof(string) })]
        string Etag { get; set; }
        /// <summary>Integrity key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Integrity key.",
        SerializedName = @"integrityKey",
        PossibleTypes = new [] { typeof(string) })]
        string IntegrityKey { get; set; }

    }
    /// Vault extended information.
    internal partial interface IVaultExtendedInfoResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IProxyResourceInternal
    {
        /// <summary>Algorithm for Vault ExtendedInfo</summary>
        string Algorithm { get; set; }
        /// <summary>Encryption key.</summary>
        string EncryptionKey { get; set; }
        /// <summary>Encryption key thumbprint.</summary>
        string EncryptionKeyThumbprint { get; set; }
        /// <summary>etag for the resource.</summary>
        string Etag { get; set; }
        /// <summary>Integrity key.</summary>
        string IntegrityKey { get; set; }
        /// <summary>Vault extended information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultExtendedInfo Property { get; set; }

    }
}