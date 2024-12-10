// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>The updatable properties of the MongoCluster.</summary>
    public partial class MongoClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Administrator" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties _administrator;

        /// <summary>The local administrator properties for the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Administrator { get => (this._administrator = this._administrator ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorProperties()); set => this._administrator = value; }

        /// <summary>The administrator password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string AdministratorPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorPropertiesInternal)Administrator).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorPropertiesInternal)Administrator).Password = value ?? null; }

        /// <summary>The administrator user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string AdministratorUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorPropertiesInternal)Administrator).UserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorPropertiesInternal)Administrator).UserName = value ?? null; }

        /// <summary>Backing field for <see cref="Backup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties _backup;

        /// <summary>The backup properties of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupProperties()); set => this._backup = value; }

        /// <summary>Earliest restore timestamp in UTC ISO8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupPropertiesInternal)Backup).EarliestRestoreTime; }

        /// <summary>Backing field for <see cref="Compute" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties _compute;

        /// <summary>The compute properties of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Compute { get => (this._compute = this._compute ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputeProperties()); set => this._compute = value; }

        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ComputeTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputePropertiesInternal)Compute).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputePropertiesInternal)Compute).Tier = value ?? null; }

        /// <summary>Backing field for <see cref="HighAvailability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties _highAvailability;

        /// <summary>The high availability properties of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityProperties()); set => this._highAvailability = value; }

        /// <summary>The target high availability mode requested for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string HighAvailabilityTargetMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityPropertiesInternal)HighAvailability).TargetMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityPropertiesInternal)HighAvailability).TargetMode = value ?? null; }

        /// <summary>Internal Acessors for Administrator</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.Administrator { get => (this._administrator = this._administrator ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorProperties()); set { {_administrator = value;} } }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupProperties()); set { {_backup = value;} } }

        /// <summary>Internal Acessors for BackupEarliestRestoreTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupPropertiesInternal)Backup).EarliestRestoreTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupPropertiesInternal)Backup).EarliestRestoreTime = value; }

        /// <summary>Internal Acessors for Compute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.Compute { get => (this._compute = this._compute ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputeProperties()); set { {_compute = value;} } }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityProperties()); set { {_highAvailability = value;} } }

        /// <summary>Internal Acessors for Sharding</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.Sharding { get => (this._sharding = this._sharding ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingProperties()); set { {_sharding = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal.Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StorageProperties()); set { {_storage = value;} } }

        /// <summary>Backing field for <see cref="PreviewFeature" /> property.</summary>
        private System.Collections.Generic.List<string> _previewFeature;

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> PreviewFeature { get => this._previewFeature; set => this._previewFeature = value; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="ServerVersion" /> property.</summary>
        private string _serverVersion;

        /// <summary>
        /// The Mongo DB server version. Defaults to the latest available version if not specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string ServerVersion { get => this._serverVersion; set => this._serverVersion = value; }

        /// <summary>Backing field for <see cref="Sharding" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties _sharding;

        /// <summary>The sharding properties of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties Sharding { get => (this._sharding = this._sharding ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingProperties()); set => this._sharding = value; }

        /// <summary>Number of shards to provision on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public int? ShardingShardCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingPropertiesInternal)Sharding).ShardCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingPropertiesInternal)Sharding).ShardCount = value ?? default(int); }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties _storage;

        /// <summary>The storage properties of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StorageProperties()); set => this._storage = value; }

        /// <summary>The size of the data disk assigned to each server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public long? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStoragePropertiesInternal)Storage).SizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStoragePropertiesInternal)Storage).SizeGb = value ?? default(long); }

        /// <summary>Creates an new <see cref="MongoClusterUpdateProperties" /> instance.</summary>
        public MongoClusterUpdateProperties()
        {

        }
    }
    /// The updatable properties of the MongoCluster.
    public partial interface IMongoClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IJsonSerializable
    {
        /// <summary>The administrator password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The administrator password.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorPassword { get; set; }
        /// <summary>The administrator user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The administrator user name.",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorUserName { get; set; }
        /// <summary>Earliest restore timestamp in UTC ISO8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Earliest restore timestamp in UTC ISO8601 format.",
        SerializedName = @"earliestRestoreTime",
        PossibleTypes = new [] { typeof(string) })]
        string BackupEarliestRestoreTime { get;  }
        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30', 'M40'.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeTier { get; set; }
        /// <summary>The target high availability mode requested for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The target high availability mode requested for the cluster.",
        SerializedName = @"targetMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Disabled", "SameZone", "ZoneRedundantPreferred")]
        string HighAvailabilityTargetMode { get; set; }
        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of private endpoint connections.",
        SerializedName = @"previewFeatures",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("GeoReplicas")]
        System.Collections.Generic.List<string> PreviewFeature { get; set; }
        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether or not public endpoint access is allowed for this mongo cluster.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>
        /// The Mongo DB server version. Defaults to the latest available version if not specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Mongo DB server version. Defaults to the latest available version if not specified.",
        SerializedName = @"serverVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ServerVersion { get; set; }
        /// <summary>Number of shards to provision on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of shards to provision on the cluster.",
        SerializedName = @"shardCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ShardingShardCount { get; set; }
        /// <summary>The size of the data disk assigned to each server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The size of the data disk assigned to each server.",
        SerializedName = @"sizeGb",
        PossibleTypes = new [] { typeof(long) })]
        long? StorageSizeGb { get; set; }

    }
    /// The updatable properties of the MongoCluster.
    internal partial interface IMongoClusterUpdatePropertiesInternal

    {
        /// <summary>The local administrator properties for the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Administrator { get; set; }
        /// <summary>The administrator password.</summary>
        string AdministratorPassword { get; set; }
        /// <summary>The administrator user name.</summary>
        string AdministratorUserName { get; set; }
        /// <summary>The backup properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties Backup { get; set; }
        /// <summary>Earliest restore timestamp in UTC ISO8601 format.</summary>
        string BackupEarliestRestoreTime { get; set; }
        /// <summary>The compute properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Compute { get; set; }
        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        string ComputeTier { get; set; }
        /// <summary>The high availability properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties HighAvailability { get; set; }
        /// <summary>The target high availability mode requested for the cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Disabled", "SameZone", "ZoneRedundantPreferred")]
        string HighAvailabilityTargetMode { get; set; }
        /// <summary>List of private endpoint connections.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("GeoReplicas")]
        System.Collections.Generic.List<string> PreviewFeature { get; set; }
        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>
        /// The Mongo DB server version. Defaults to the latest available version if not specified.
        /// </summary>
        string ServerVersion { get; set; }
        /// <summary>The sharding properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties Sharding { get; set; }
        /// <summary>Number of shards to provision on the cluster.</summary>
        int? ShardingShardCount { get; set; }
        /// <summary>The storage properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties Storage { get; set; }
        /// <summary>The size of the data disk assigned to each server.</summary>
        long? StorageSizeGb { get; set; }

    }
}