// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The parameters used to create a key.</summary>
    public partial class ManagedHsmKeyCreateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal
    {

        /// <summary>Determines whether or not the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeEnabled = value ?? default(bool); }

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributeExpire { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeExpire; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeExpire = value ?? default(long); }

        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string AttributeExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeExpiryTime = value ?? null; }

        /// <summary>Indicates if the private key can be exported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeExportable { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeExportable; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeExportable = value ?? default(bool); }

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributeNotBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeNotBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeNotBefore = value ?? default(long); }

        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string AttributeRecoveryLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeRecoveryLevel; }

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributesCreated; }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributesUpdated; }

        /// <summary>
        /// The elliptic curve name. For valid values, see JsonWebKeyCurveName. Default for EC and EC-HSM keys is P-256
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string CurveName { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).CurveName; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).CurveName = value ?? null; }

        /// <summary>Array of JsonWebKeyOperation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> KeyOp { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyOp; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyOp = value ?? null /* arrayOf */; }

        /// <summary>
        /// The key size in bits. For example: 2048, 3072, or 4096 for RSA. Default for RSA and RSA-HSM keys is 2048. Exception made
        /// for bring your own key (BYOK), key exchange keys default to 4096.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public int? KeySize { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeySize; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeySize = value ?? default(int); }

        /// <summary>The URI to retrieve the current version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string KeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyUri; }

        /// <summary>The URI to retrieve the specific version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string KeyUriWithVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyUriWithVersion; }

        /// <summary>The type of the key. For valid values, see JsonWebKeyType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string Kty { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).Kty; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).Kty = value ?? null; }

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).Attribute = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AttributeRecoveryLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.AttributeRecoveryLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeRecoveryLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributeRecoveryLevel = value ?? null; }

        /// <summary>Internal Acessors for AttributesCreated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.AttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributesCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributesCreated = value ?? default(long); }

        /// <summary>Internal Acessors for AttributesUpdated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.AttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributesUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).AttributesUpdated = value ?? default(long); }

        /// <summary>Internal Acessors for KeyUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.KeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyUri = value ?? null; }

        /// <summary>Internal Acessors for KeyUriWithVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.KeyUriWithVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyUriWithVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).KeyUriWithVersion = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReleasePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicy Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.ReleasePolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).ReleasePolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).ReleasePolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RotationPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicy Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.RotationPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RotationPolicyAttribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyRotationPolicyAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.RotationPolicyAttribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttribute = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RotationPolicyAttributesCreated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.RotationPolicyAttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttributesCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttributesCreated = value ?? default(long); }

        /// <summary>Internal Acessors for RotationPolicyAttributesUpdated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersInternal.RotationPolicyAttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttributesUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttributesUpdated = value ?? default(long); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties _property;

        /// <summary>The properties of the key to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyProperties()); set => this._property = value; }

        /// <summary>Content type and version of key release policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string ReleasePolicyContentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).ReleasePolicyContentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).ReleasePolicyContentType = value ?? null; }

        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public byte[] ReleasePolicyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).ReleasePolicyData; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).ReleasePolicyData = value ?? null /* byte array */; }

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? RotationPolicyAttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttributesCreated; }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? RotationPolicyAttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyAttributesUpdated; }

        /// <summary>The lifetimeActions for key rotation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeAction> RotationPolicyLifetimeAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyLifetimeAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal)Property).RotationPolicyLifetimeAction = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersTags _tag;

        /// <summary>The tags that will be assigned to the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyCreateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ManagedHsmKeyCreateParameters" /> instance.</summary>
        public ManagedHsmKeyCreateParameters()
        {

        }
    }
    /// The parameters used to create a key.
    public partial interface IManagedHsmKeyCreateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>Determines whether or not the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines whether or not the object is enabled.",
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
        PossibleTypes = new [] { typeof(long) })]
        long? AttributeExpire { get; set; }
        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.",
        SerializedName = @"expiryTime",
        PossibleTypes = new [] { typeof(string) })]
        string AttributeExpiryTime { get; set; }
        /// <summary>Indicates if the private key can be exported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if the private key can be exported.",
        SerializedName = @"exportable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AttributeExportable { get; set; }
        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Not before date in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"nbf",
        PossibleTypes = new [] { typeof(long) })]
        long? AttributeNotBefore { get; set; }
        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.",
        SerializedName = @"recoveryLevel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("Purgeable", "Recoverable+Purgeable", "Recoverable", "Recoverable+ProtectedSubscription")]
        string AttributeRecoveryLevel { get;  }
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Creation time in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(long) })]
        long? AttributesCreated { get;  }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last updated time in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"updated",
        PossibleTypes = new [] { typeof(long) })]
        long? AttributesUpdated { get;  }
        /// <summary>
        /// The elliptic curve name. For valid values, see JsonWebKeyCurveName. Default for EC and EC-HSM keys is P-256
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The elliptic curve name. For valid values, see JsonWebKeyCurveName. Default for EC and EC-HSM keys is P-256",
        SerializedName = @"curveName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("P-256", "P-384", "P-521", "P-256K")]
        string CurveName { get; set; }
        /// <summary>Array of JsonWebKeyOperation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of JsonWebKeyOperation",
        SerializedName = @"keyOps",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("encrypt", "decrypt", "sign", "verify", "wrapKey", "unwrapKey", "import", "release")]
        System.Collections.Generic.List<string> KeyOp { get; set; }
        /// <summary>
        /// The key size in bits. For example: 2048, 3072, or 4096 for RSA. Default for RSA and RSA-HSM keys is 2048. Exception made
        /// for bring your own key (BYOK), key exchange keys default to 4096.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key size in bits. For example: 2048, 3072, or 4096 for RSA. Default for RSA and RSA-HSM keys is 2048. Exception made for bring your own key (BYOK), key exchange keys default to 4096.",
        SerializedName = @"keySize",
        PossibleTypes = new [] { typeof(int) })]
        int? KeySize { get; set; }
        /// <summary>The URI to retrieve the current version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URI to retrieve the current version of the key.",
        SerializedName = @"keyUri",
        PossibleTypes = new [] { typeof(string) })]
        string KeyUri { get;  }
        /// <summary>The URI to retrieve the specific version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The URI to retrieve the specific version of the key.",
        SerializedName = @"keyUriWithVersion",
        PossibleTypes = new [] { typeof(string) })]
        string KeyUriWithVersion { get;  }
        /// <summary>The type of the key. For valid values, see JsonWebKeyType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the key. For valid values, see JsonWebKeyType.",
        SerializedName = @"kty",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("EC", "EC-HSM", "RSA", "RSA-HSM")]
        string Kty { get; set; }
        /// <summary>Content type and version of key release policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Content type and version of key release policy",
        SerializedName = @"contentType",
        PossibleTypes = new [] { typeof(string) })]
        string ReleasePolicyContentType { get; set; }
        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Blob encoding the policy rules under which the key can be released.",
        SerializedName = @"data",
        PossibleTypes = new [] { typeof(byte[]) })]
        byte[] ReleasePolicyData { get; set; }
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Creation time in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"created",
        PossibleTypes = new [] { typeof(long) })]
        long? RotationPolicyAttributesCreated { get;  }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last updated time in seconds since 1970-01-01T00:00:00Z.",
        SerializedName = @"updated",
        PossibleTypes = new [] { typeof(long) })]
        long? RotationPolicyAttributesUpdated { get;  }
        /// <summary>The lifetimeActions for key rotation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The lifetimeActions for key rotation action.",
        SerializedName = @"lifetimeActions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeAction) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeAction> RotationPolicyLifetimeAction { get; set; }
        /// <summary>The tags that will be assigned to the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The tags that will be assigned to the key.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersTags Tag { get; set; }

    }
    /// The parameters used to create a key.
    internal partial interface IManagedHsmKeyCreateParametersInternal

    {
        /// <summary>The attributes of the key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributes Attribute { get; set; }
        /// <summary>Determines whether or not the object is enabled.</summary>
        bool? AttributeEnabled { get; set; }
        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        long? AttributeExpire { get; set; }
        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        string AttributeExpiryTime { get; set; }
        /// <summary>Indicates if the private key can be exported.</summary>
        bool? AttributeExportable { get; set; }
        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        long? AttributeNotBefore { get; set; }
        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("Purgeable", "Recoverable+Purgeable", "Recoverable", "Recoverable+ProtectedSubscription")]
        string AttributeRecoveryLevel { get; set; }
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? AttributesCreated { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? AttributesUpdated { get; set; }
        /// <summary>
        /// The elliptic curve name. For valid values, see JsonWebKeyCurveName. Default for EC and EC-HSM keys is P-256
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("P-256", "P-384", "P-521", "P-256K")]
        string CurveName { get; set; }
        /// <summary>Array of JsonWebKeyOperation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("encrypt", "decrypt", "sign", "verify", "wrapKey", "unwrapKey", "import", "release")]
        System.Collections.Generic.List<string> KeyOp { get; set; }
        /// <summary>
        /// The key size in bits. For example: 2048, 3072, or 4096 for RSA. Default for RSA and RSA-HSM keys is 2048. Exception made
        /// for bring your own key (BYOK), key exchange keys default to 4096.
        /// </summary>
        int? KeySize { get; set; }
        /// <summary>The URI to retrieve the current version of the key.</summary>
        string KeyUri { get; set; }
        /// <summary>The URI to retrieve the specific version of the key.</summary>
        string KeyUriWithVersion { get; set; }
        /// <summary>The type of the key. For valid values, see JsonWebKeyType.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("EC", "EC-HSM", "RSA", "RSA-HSM")]
        string Kty { get; set; }
        /// <summary>The properties of the key to be created.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties Property { get; set; }
        /// <summary>
        /// Key release policy in response. It will be used for both output and input. Omitted if empty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicy ReleasePolicy { get; set; }
        /// <summary>Content type and version of key release policy</summary>
        string ReleasePolicyContentType { get; set; }
        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        byte[] ReleasePolicyData { get; set; }
        /// <summary>
        /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicy RotationPolicy { get; set; }
        /// <summary>The attributes of key rotation policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyRotationPolicyAttributes RotationPolicyAttribute { get; set; }
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? RotationPolicyAttributesCreated { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? RotationPolicyAttributesUpdated { get; set; }
        /// <summary>The lifetimeActions for key rotation action.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeAction> RotationPolicyLifetimeAction { get; set; }
        /// <summary>The tags that will be assigned to the key.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyCreateParametersTags Tag { get; set; }

    }
}