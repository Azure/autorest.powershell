// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Properties of the secret</summary>
    public partial class SecretPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes _attribute;

        /// <summary>The attributes of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretAttributes()); set => this._attribute = value; }

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Created; }

        /// <summary>Determines whether the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Enabled = value ?? default(bool); }

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeExpire { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Expire; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Expire = value ?? default(global::System.DateTime); }

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeNotBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).NotBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).NotBefore = value ?? default(global::System.DateTime); }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public global::System.DateTime? AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Updated; }

        /// <summary>Backing field for <see cref="ContentType" /> property.</summary>
        private string _contentType;

        /// <summary>The content type of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string ContentType { get => this._contentType; set => this._contentType = value; }

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal.Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.SecretAttributes()); set { {_attribute = value;} } }

        /// <summary>Internal Acessors for AttributeCreated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal.AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Created = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for AttributeUpdated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretPatchPropertiesInternal.AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Updated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)Attribute).Updated = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="SecretPatchProperties" /> instance.</summary>
        public SecretPatchProperties()
        {

        }
    }
    /// Properties of the secret
    public partial interface ISecretPatchProperties :
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
    /// Properties of the secret
    internal partial interface ISecretPatchPropertiesInternal

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
        /// <summary>The value of the secret.</summary>
        string Value { get; set; }

    }
}