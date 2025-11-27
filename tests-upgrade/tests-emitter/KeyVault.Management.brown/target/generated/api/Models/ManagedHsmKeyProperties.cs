// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The properties of the key.</summary>
    public partial class ManagedHsmKeyProperties :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyProperties,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributes _attribute;

        /// <summary>The attributes of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributes Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyAttributes()); set => this._attribute = value; }

        /// <summary>Determines whether or not the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Enabled = value ?? default(bool); }

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributeExpire { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Expire; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Expire = value ?? default(long); }

        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string AttributeExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeExpiryTime = value ?? null; }

        /// <summary>Indicates if the private key can be exported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public bool? AttributeExportable { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Exportable; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Exportable = value ?? default(bool); }

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributeNotBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).NotBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).NotBefore = value ?? default(long); }

        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string AttributeRecoveryLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).RecoveryLevel; }

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Created; }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Updated; }

        /// <summary>Backing field for <see cref="CurveName" /> property.</summary>
        private string _curveName;

        /// <summary>
        /// The elliptic curve name. For valid values, see JsonWebKeyCurveName. Default for EC and EC-HSM keys is P-256
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string CurveName { get => this._curveName; set => this._curveName = value; }

        /// <summary>Backing field for <see cref="KeyOp" /> property.</summary>
        private System.Collections.Generic.List<string> _keyOp;

        /// <summary>Array of JsonWebKeyOperation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> KeyOp { get => this._keyOp; set => this._keyOp = value; }

        /// <summary>Backing field for <see cref="KeySize" /> property.</summary>
        private int? _keySize;

        /// <summary>
        /// The key size in bits. For example: 2048, 3072, or 4096 for RSA. Default for RSA and RSA-HSM keys is 2048. Exception made
        /// for bring your own key (BYOK), key exchange keys default to 4096.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public int? KeySize { get => this._keySize; set => this._keySize = value; }

        /// <summary>Backing field for <see cref="KeyUri" /> property.</summary>
        private string _keyUri;

        /// <summary>The URI to retrieve the current version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string KeyUri { get => this._keyUri; }

        /// <summary>Backing field for <see cref="KeyUriWithVersion" /> property.</summary>
        private string _keyUriWithVersion;

        /// <summary>The URI to retrieve the specific version of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string KeyUriWithVersion { get => this._keyUriWithVersion; }

        /// <summary>Backing field for <see cref="Kty" /> property.</summary>
        private string _kty;

        /// <summary>The type of the key. For valid values, see JsonWebKeyType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Kty { get => this._kty; set => this._kty = value; }

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyAttributes()); set { {_attribute = value;} } }

        /// <summary>Internal Acessors for AttributeRecoveryLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.AttributeRecoveryLevel { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).RecoveryLevel; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).RecoveryLevel = value ?? null; }

        /// <summary>Internal Acessors for AttributesCreated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.AttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Created = value ?? default(long); }

        /// <summary>Internal Acessors for AttributesUpdated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.AttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Updated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyAttributesInternal)Attribute).Updated = value ?? default(long); }

        /// <summary>Internal Acessors for KeyUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.KeyUri { get => this._keyUri; set { {_keyUri = value;} } }

        /// <summary>Internal Acessors for KeyUriWithVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.KeyUriWithVersion { get => this._keyUriWithVersion; set { {_keyUriWithVersion = value;} } }

        /// <summary>Internal Acessors for ReleasePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicy Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.ReleasePolicy { get => (this._releasePolicy = this._releasePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyReleasePolicy()); set { {_releasePolicy = value;} } }

        /// <summary>Internal Acessors for RotationPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicy Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.RotationPolicy { get => (this._rotationPolicy = this._rotationPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmRotationPolicy()); set { {_rotationPolicy = value;} } }

        /// <summary>Internal Acessors for RotationPolicyAttribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyRotationPolicyAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.RotationPolicyAttribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).Attribute = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RotationPolicyAttributesCreated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.RotationPolicyAttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeCreated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeCreated = value ?? default(long); }

        /// <summary>Internal Acessors for RotationPolicyAttributesUpdated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyPropertiesInternal.RotationPolicyAttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeUpdated = value ?? default(long); }

        /// <summary>Backing field for <see cref="ReleasePolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicy _releasePolicy;

        /// <summary>
        /// Key release policy in response. It will be used for both output and input. Omitted if empty
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicy ReleasePolicy { get => (this._releasePolicy = this._releasePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmKeyReleasePolicy()); set => this._releasePolicy = value; }

        /// <summary>Content type and version of key release policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string ReleasePolicyContentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicyInternal)ReleasePolicy).ContentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicyInternal)ReleasePolicy).ContentType = value ?? null; }

        /// <summary>Blob encoding the policy rules under which the key can be released.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public byte[] ReleasePolicyData { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicyInternal)ReleasePolicy).Data; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmKeyReleasePolicyInternal)ReleasePolicy).Data = value ?? null /* byte array */; }

        /// <summary>Backing field for <see cref="RotationPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicy _rotationPolicy;

        /// <summary>
        /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicy RotationPolicy { get => (this._rotationPolicy = this._rotationPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmRotationPolicy()); set => this._rotationPolicy = value; }

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? RotationPolicyAttributesCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeCreated; }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? RotationPolicyAttributesUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).AttributeUpdated; }

        /// <summary>The lifetimeActions for key rotation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeAction> RotationPolicyLifetimeAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).LifetimeAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmRotationPolicyInternal)RotationPolicy).LifetimeAction = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ManagedHsmKeyProperties" /> instance.</summary>
        public ManagedHsmKeyProperties()
        {

        }
    }
    /// The properties of the key.
    public partial interface IManagedHsmKeyProperties :
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

    }
    /// The properties of the key.
    internal partial interface IManagedHsmKeyPropertiesInternal

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

    }
}