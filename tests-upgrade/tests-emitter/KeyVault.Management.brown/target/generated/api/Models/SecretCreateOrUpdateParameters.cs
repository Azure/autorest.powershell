// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Parameters for creating or updating a secret</summary>
    public partial class SecretCreateOrUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal
    {

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

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal.Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AttributeCreated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal.AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeCreated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for AttributeUpdated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal.AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).AttributeUpdated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SecretUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal.SecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUri = value ?? null; }

        /// <summary>Internal Acessors for SecretUriWithVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersInternal.SecretUriWithVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUriWithVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUriWithVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties _property;

        /// <summary>Properties of the secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretProperties()); set => this._property = value; }

        /// <summary>The URI to retrieve the current version of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string SecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUri; }

        /// <summary>The URI to retrieve the specific version of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string SecretUriWithVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).SecretUriWithVersion; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags _tag;

        /// <summary>The tags that will be assigned to the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretCreateOrUpdateParametersTags()); set => this._tag = value; }

        /// <summary>
        /// The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended
        /// for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPropertiesInternal)Property).Value = value ?? null; }

        /// <summary>Creates an new <see cref="SecretCreateOrUpdateParameters" /> instance.</summary>
        public SecretCreateOrUpdateParameters()
        {

        }
    }
    /// Parameters for creating or updating a secret
    public partial interface ISecretCreateOrUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
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
        string SecretUri { get;  }
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
        string SecretUriWithVersion { get;  }
        /// <summary>The tags that will be assigned to the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The tags that will be assigned to the secret.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags Tag { get; set; }
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
    /// Parameters for creating or updating a secret
    internal partial interface ISecretCreateOrUpdateParametersInternal

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
        /// <summary>Properties of the secret</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretProperties Property { get; set; }
        /// <summary>The URI to retrieve the current version of the secret.</summary>
        string SecretUri { get; set; }
        /// <summary>The URI to retrieve the specific version of the secret.</summary>
        string SecretUriWithVersion { get; set; }
        /// <summary>The tags that will be assigned to the secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretCreateOrUpdateParametersTags Tag { get; set; }
        /// <summary>
        /// The value of the secret. NOTE: 'value' will never be returned from the service, as APIs using this model are is intended
        /// for internal use in ARM deployments. Users should use the data-plane REST service for interaction with vault secrets.
        /// </summary>
        string Value { get; set; }

    }
}