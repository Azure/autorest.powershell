// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The attributes of key rotation policy.</summary>
    public partial class KeyRotationPolicyAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributes,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal
    {

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private long? _created;

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public long? Created { get => this._created; }

        /// <summary>Backing field for <see cref="ExpiryTime" /> property.</summary>
        private string _expiryTime;

        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string ExpiryTime { get => this._expiryTime; set => this._expiryTime = value; }

        /// <summary>Internal Acessors for Created</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal.Created { get => this._created; set { {_created = value;} } }

        /// <summary>Internal Acessors for Updated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyRotationPolicyAttributesInternal.Updated { get => this._updated; set { {_updated = value;} } }

        /// <summary>Backing field for <see cref="Updated" /> property.</summary>
        private long? _updated;

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public long? Updated { get => this._updated; }

        /// <summary>Creates an new <see cref="KeyRotationPolicyAttributes" /> instance.</summary>
        public KeyRotationPolicyAttributes()
        {

        }
    }
    /// The attributes of key rotation policy.
    public partial interface IKeyRotationPolicyAttributes :
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
        long? Created { get;  }
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
        string ExpiryTime { get; set; }
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
        long? Updated { get;  }

    }
    /// The attributes of key rotation policy.
    internal partial interface IKeyRotationPolicyAttributesInternal

    {
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? Created { get; set; }
        /// <summary>
        /// The expiration time for the new key version. It should be in ISO8601 format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        string ExpiryTime { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? Updated { get; set; }

    }
}