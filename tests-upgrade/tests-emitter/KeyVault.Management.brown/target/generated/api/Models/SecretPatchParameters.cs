// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Parameters for patching a secret</summary>
    public partial class SecretPatchParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParameters,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersInternal
    {

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeCreated; }

        /// <summary>Determines whether the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeEnabled = value ?? default(bool); }

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeExpire { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeExpire; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeExpire = value ?? default(global::System.DateTime); }

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeNotBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeNotBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeNotBefore = value ?? default(global::System.DateTime); }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeUpdated; }

        /// <summary>The content type of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string ContentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).ContentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).ContentType = value ?? null; }

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersInternal.Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AttributeCreated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersInternal.AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeCreated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for AttributeUpdated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersInternal.AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).AttributeUpdated = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties _property;

        /// <summary>Properties of the secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersTags _tag;

        /// <summary>The tags that will be assigned to the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretPatchParametersTags()); set => this._tag = value; }

        /// <summary>The value of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal)Property).Value = value ?? null; }

        /// <summary>Creates an new <see cref="SecretPatchParameters" /> instance.</summary>
        public SecretPatchParameters()
        {

        }
    }
    /// Parameters for patching a secret
    public partial interface ISecretPatchParameters :
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
        /// <summary>The tags that will be assigned to the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The tags that will be assigned to the secret.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersTags Tag { get; set; }
        /// <summary>The value of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of the secret.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Parameters for patching a secret
    internal partial interface ISecretPatchParametersInternal

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
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties Property { get; set; }
        /// <summary>The tags that will be assigned to the secret.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchParametersTags Tag { get; set; }
        /// <summary>The value of the secret.</summary>
        string Value { get; set; }

    }
}