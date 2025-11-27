// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>
    /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
    /// </summary>
    public partial class RotationPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes _attribute;

        /// <summary>The attributes of key rotation policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyRotationPolicyAttributes()); set => this._attribute = value; }

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).Created; }

        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string AttributeExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).ExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).ExpiryTime = value ?? null; }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public long? AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).Updated; }

        /// <summary>Backing field for <see cref="LifetimeAction" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction> _lifetimeAction;

        /// <summary>The lifetimeActions for key rotation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction> LifetimeAction { get => this._lifetimeAction; set => this._lifetimeAction = value; }

        /// <summary>Internal Acessors for Attribute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal.Attribute { get => (this._attribute = this._attribute ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.KeyRotationPolicyAttributes()); set { {_attribute = value;} } }

        /// <summary>Internal Acessors for AttributeCreated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal.AttributeCreated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).Created = value ?? default(long); }

        /// <summary>Internal Acessors for AttributeUpdated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IRotationPolicyInternal.AttributeUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).Updated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal)Attribute).Updated = value ?? default(long); }

        /// <summary>Creates an new <see cref="RotationPolicy" /> instance.</summary>
        public RotationPolicy()
        {

        }
    }
    /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
    public partial interface IRotationPolicy :
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
        PossibleTypes = new [] { typeof(long) })]
        long? AttributeCreated { get;  }
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
        long? AttributeUpdated { get;  }
        /// <summary>The lifetimeActions for key rotation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The lifetimeActions for key rotation action.",
        SerializedName = @"lifetimeActions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction> LifetimeAction { get; set; }

    }
    /// Key rotation policy in response. It will be used for both output and input. Omitted if empty
    internal partial interface IRotationPolicyInternal

    {
        /// <summary>The attributes of key rotation policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes Attribute { get; set; }
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? AttributeCreated { get; set; }
        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        string AttributeExpiryTime { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? AttributeUpdated { get; set; }
        /// <summary>The lifetimeActions for key rotation action.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ILifetimeAction> LifetimeAction { get; set; }

    }
}