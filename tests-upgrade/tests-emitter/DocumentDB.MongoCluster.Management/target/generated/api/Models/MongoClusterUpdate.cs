// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>The type used for update operations of the MongoCluster.</summary>
    public partial class MongoClusterUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal
    {

        /// <summary>The administrator password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public System.Security.SecureString AdministratorPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).AdministratorPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).AdministratorPassword = value ?? null; }

        /// <summary>The administrator user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string AdministratorUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).AdministratorUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).AdministratorUserName = value ?? null; }

        /// <summary>Earliest restore timestamp in UTC ISO8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).BackupEarliestRestoreTime; }

        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ComputeTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).ComputeTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).ComputeTier = value ?? null; }

        /// <summary>The target high availability mode requested for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string HighAvailabilityTargetMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).HighAvailabilityTargetMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).HighAvailabilityTargetMode = value ?? null; }

        /// <summary>Internal Acessors for Administrator</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.Administrator { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Administrator; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Administrator = value; }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.Backup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Backup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Backup = value; }

        /// <summary>Internal Acessors for BackupEarliestRestoreTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).BackupEarliestRestoreTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).BackupEarliestRestoreTime = value; }

        /// <summary>Internal Acessors for Compute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.Compute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Compute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Compute = value; }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.HighAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).HighAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).HighAvailability = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sharding</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.Sharding { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Sharding; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Sharding = value; }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateInternal.Storage { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).Storage = value; }

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreviewFeature { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).PreviewFeature; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).PreviewFeature = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterUpdateProperties()); set => this._property = value; }

        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>
        /// The Mongo DB server version. Defaults to the latest available version if not specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ServerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).ServerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).ServerVersion = value ?? null; }

        /// <summary>Number of shards to provision on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public int? ShardingShardCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).ShardingShardCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).ShardingShardCount = value ?? default(int); }

        /// <summary>The size of the data disk assigned to each server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public long? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).StorageSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdatePropertiesInternal)Property).StorageSizeGb = value ?? default(long); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="MongoClusterUpdate" /> instance.</summary>
        public MongoClusterUpdate()
        {

        }
    }
    /// The type used for update operations of the MongoCluster.
    public partial interface IMongoClusterUpdate :
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
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorPassword { get; set; }
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
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags Tag { get; set; }

    }
    /// The type used for update operations of the MongoCluster.
    internal partial interface IMongoClusterUpdateInternal

    {
        /// <summary>The local administrator properties for the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Administrator { get; set; }
        /// <summary>The administrator password.</summary>
        System.Security.SecureString AdministratorPassword { get; set; }
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterUpdateProperties Property { get; set; }
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
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags Tag { get; set; }

    }
}