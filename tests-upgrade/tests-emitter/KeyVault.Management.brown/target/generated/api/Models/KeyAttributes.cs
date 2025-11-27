// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The object attributes managed by the Azure Key Vault service.</summary>
    public partial class KeyAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributes,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal
    {

        /// <summary>Backing field for <see cref="Created" /> property.</summary>
        private long? _created;

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public long? Created { get => this._created; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Determines whether or not the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="Expire" /> property.</summary>
        private long? _expire;

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public long? Expire { get => this._expire; set => this._expire = value; }

        /// <summary>Backing field for <see cref="Exportable" /> property.</summary>
        private bool? _exportable;

        /// <summary>Indicates if the private key can be exported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public bool? Exportable { get => this._exportable; set => this._exportable = value; }

        /// <summary>Internal Acessors for Created</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal.Created { get => this._created; set { {_created = value;} } }

        /// <summary>Internal Acessors for RecoveryLevel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal.RecoveryLevel { get => this._recoveryLevel; set { {_recoveryLevel = value;} } }

        /// <summary>Internal Acessors for Updated</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IKeyAttributesInternal.Updated { get => this._updated; set { {_updated = value;} } }

        /// <summary>Backing field for <see cref="NotBefore" /> property.</summary>
        private long? _notBefore;

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public long? NotBefore { get => this._notBefore; set => this._notBefore = value; }

        /// <summary>Backing field for <see cref="RecoveryLevel" /> property.</summary>
        private string _recoveryLevel;

        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string RecoveryLevel { get => this._recoveryLevel; }

        /// <summary>Backing field for <see cref="Updated" /> property.</summary>
        private long? _updated;

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public long? Updated { get => this._updated; }

        /// <summary>Creates an new <see cref="KeyAttributes" /> instance.</summary>
        public KeyAttributes()
        {

        }
    }
    /// The object attributes managed by the Azure Key Vault service.
    public partial interface IKeyAttributes :
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
        bool? Enabled { get; set; }
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
        long? Expire { get; set; }
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
        bool? Exportable { get; set; }
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
        long? NotBefore { get; set; }
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
        string RecoveryLevel { get;  }
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
    /// The object attributes managed by the Azure Key Vault service.
    internal partial interface IKeyAttributesInternal

    {
        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? Created { get; set; }
        /// <summary>Determines whether or not the object is enabled.</summary>
        bool? Enabled { get; set; }
        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        long? Expire { get; set; }
        /// <summary>Indicates if the private key can be exported.</summary>
        bool? Exportable { get; set; }
        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        long? NotBefore { get; set; }
        /// <summary>
        /// The deletion recovery level currently in effect for the object. If it contains 'Purgeable', then the object can be permanently
        /// deleted by a privileged user; otherwise, only the system can purge the object at the end of the retention interval.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("Purgeable", "Recoverable+Purgeable", "Recoverable", "Recoverable+ProtectedSubscription")]
        string RecoveryLevel { get; set; }
        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        long? Updated { get; set; }

    }
}