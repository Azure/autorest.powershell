// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>storage edition capability</summary>
    public partial class StorageEditionCapability :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal
    {

        /// <summary>Backing field for <see cref="MaxBackupIntervalHour" /> property.</summary>
        private long? _maxBackupIntervalHour;

        /// <summary>Maximum backup interval hours</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? MaxBackupIntervalHour { get => this._maxBackupIntervalHour; }

        /// <summary>Backing field for <see cref="MaxBackupRetentionDay" /> property.</summary>
        private long? _maxBackupRetentionDay;

        /// <summary>Maximum backup retention days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? MaxBackupRetentionDay { get => this._maxBackupRetentionDay; }

        /// <summary>Backing field for <see cref="MaxStorageSize" /> property.</summary>
        private long? _maxStorageSize;

        /// <summary>The maximum supported storage size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? MaxStorageSize { get => this._maxStorageSize; }

        /// <summary>Internal Acessors for MaxBackupIntervalHour</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.MaxBackupIntervalHour { get => this._maxBackupIntervalHour; set { {_maxBackupIntervalHour = value;} } }

        /// <summary>Internal Acessors for MaxBackupRetentionDay</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.MaxBackupRetentionDay { get => this._maxBackupRetentionDay; set { {_maxBackupRetentionDay = value;} } }

        /// <summary>Internal Acessors for MaxStorageSize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.MaxStorageSize { get => this._maxStorageSize; set { {_maxStorageSize = value;} } }

        /// <summary>Internal Acessors for MinBackupIntervalHour</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.MinBackupIntervalHour { get => this._minBackupIntervalHour; set { {_minBackupIntervalHour = value;} } }

        /// <summary>Internal Acessors for MinBackupRetentionDay</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.MinBackupRetentionDay { get => this._minBackupRetentionDay; set { {_minBackupRetentionDay = value;} } }

        /// <summary>Internal Acessors for MinStorageSize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.MinStorageSize { get => this._minStorageSize; set { {_minStorageSize = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapabilityInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="MinBackupIntervalHour" /> property.</summary>
        private long? _minBackupIntervalHour;

        /// <summary>Minimal backup interval hours</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? MinBackupIntervalHour { get => this._minBackupIntervalHour; }

        /// <summary>Backing field for <see cref="MinBackupRetentionDay" /> property.</summary>
        private long? _minBackupRetentionDay;

        /// <summary>Minimal backup retention days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? MinBackupRetentionDay { get => this._minBackupRetentionDay; }

        /// <summary>Backing field for <see cref="MinStorageSize" /> property.</summary>
        private long? _minStorageSize;

        /// <summary>The minimal supported storage size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? MinStorageSize { get => this._minStorageSize; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>storage edition name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="StorageEditionCapability" /> instance.</summary>
        public StorageEditionCapability()
        {

        }
    }
    /// storage edition capability
    public partial interface IStorageEditionCapability :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Maximum backup interval hours</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Maximum backup interval hours",
        SerializedName = @"maxBackupIntervalHours",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxBackupIntervalHour { get;  }
        /// <summary>Maximum backup retention days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Maximum backup retention days",
        SerializedName = @"maxBackupRetentionDays",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxBackupRetentionDay { get;  }
        /// <summary>The maximum supported storage size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The maximum supported storage size.",
        SerializedName = @"maxStorageSize",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxStorageSize { get;  }
        /// <summary>Minimal backup interval hours</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Minimal backup interval hours",
        SerializedName = @"minBackupIntervalHours",
        PossibleTypes = new [] { typeof(long) })]
        long? MinBackupIntervalHour { get;  }
        /// <summary>Minimal backup retention days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Minimal backup retention days",
        SerializedName = @"minBackupRetentionDays",
        PossibleTypes = new [] { typeof(long) })]
        long? MinBackupRetentionDay { get;  }
        /// <summary>The minimal supported storage size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The minimal supported storage size.",
        SerializedName = @"minStorageSize",
        PossibleTypes = new [] { typeof(long) })]
        long? MinStorageSize { get;  }
        /// <summary>storage edition name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"storage edition name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// storage edition capability
    internal partial interface IStorageEditionCapabilityInternal

    {
        /// <summary>Maximum backup interval hours</summary>
        long? MaxBackupIntervalHour { get; set; }
        /// <summary>Maximum backup retention days</summary>
        long? MaxBackupRetentionDay { get; set; }
        /// <summary>The maximum supported storage size.</summary>
        long? MaxStorageSize { get; set; }
        /// <summary>Minimal backup interval hours</summary>
        long? MinBackupIntervalHour { get; set; }
        /// <summary>Minimal backup retention days</summary>
        long? MinBackupRetentionDay { get; set; }
        /// <summary>The minimal supported storage size.</summary>
        long? MinStorageSize { get; set; }
        /// <summary>storage edition name</summary>
        string Name { get; set; }

    }
}