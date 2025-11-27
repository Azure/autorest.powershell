// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Resource information with extended details.</summary>
    public partial class Secret :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecret,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ProxyResource();

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeCreated; }

        /// <summary>Determines whether the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeEnabled = value ?? default(bool); }

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeExpire { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeExpire; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeExpire = value ?? default(global::System.DateTime); }

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeNotBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeNotBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeNotBefore = value ?? default(global::System.DateTime); }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeUpdated; }

        /// <summary>The content type of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string ContentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).ContentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).ContentType = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Azure location of the key vault resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AttributeCreated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeCreated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for AttributeUpdated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeUpdated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretTags()); set { {_tag = value;} } }

        /// <summary>Internal Acessors for Uri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUri = value ?? null; }

        /// <summary>Internal Acessors for UriWithVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretInternal.UriWithVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUriWithVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUriWithVersion = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties _property;

        /// <summary>Properties of the secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags _tag;

        /// <summary>Tags assigned to the key vault resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretTags()); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>The URI to retrieve the current version of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUri; }

        /// <summary>The URI to retrieve the specific version of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string UriWithVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUriWithVersion; }

        /// <summary>
        /// The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended
        /// for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Value = value ?? null; }

        /// <summary>Creates an new <see cref="Secret" /> instance.</summary>
        public Secret()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Resource information with extended details.
    public partial interface ISecret :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IProxyResource
    {
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Creation time in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AttributeCreated { get;  }
        /// <summary>Determines whether the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines whether the object is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AttributeEnabled { get; set; }
        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Expiry date in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"exp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AttributeExpire { get; set; }
        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Not before date in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"nbf",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AttributeNotBefore { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last updated time in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"updated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AttributeUpdated { get;  }
        /// <summary>The content type of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The content type of the secret.",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ContentType { get; set; }
        /// <summary>Azure location of the key vault resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure location of the key vault resource.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>Tags assigned to the key vault resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Tags assigned to the key vault resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags Tag { get;  }
        /// <summary>The URI to retrieve the current version of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URI to retrieve the current version of the secret.",
        SerializedName = @"secretUri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get;  }
        /// <summary>The URI to retrieve the specific version of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URI to retrieve the specific version of the secret.",
        SerializedName = @"secretUriWithVersion",
        PossibleTypes = new [] { typeof(string) })]
        string UriWithVersion { get;  }
        /// <summary>
        /// The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended
        /// for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Resource information with extended details.
    internal partial interface ISecretInternal :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IProxyResourceInternal
    {
        /// <summary>The attributes of the secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes Attribute { get; set; }
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        global::System.DateTime? AttributeCreated { get; set; }
        /// <summary>Determines whether the object is enabled.</summary>
        bool? AttributeEnabled { get; set; }
        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        global::System.DateTime? AttributeExpire { get; set; }
        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        global::System.DateTime? AttributeNotBefore { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        global::System.DateTime? AttributeUpdated { get; set; }
        /// <summary>The content type of the secret.</summary>
        string ContentType { get; set; }
        /// <summary>Azure location of the key vault resource.</summary>
        string Location { get; set; }
        /// <summary>Properties of the secret</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties Property { get; set; }
        /// <summary>Tags assigned to the key vault resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretTags Tag { get; set; }
        /// <summary>The URI to retrieve the current version of the secret.</summary>
        string Uri { get; set; }
        /// <summary>The URI to retrieve the specific version of the secret.</summary>
        string UriWithVersion { get; set; }
        /// <summary>
        /// The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended
        /// for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// </summary>
        string Value { get; set; }

    }
}