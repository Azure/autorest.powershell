// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>The properties of a mongo cluster.</summary>
    public partial class MongoClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal
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

        /// <summary>Backing field for <see cref="ClusterStatus" /> property.</summary>
        private string _clusterStatus;

        /// <summary>The status of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string ClusterStatus { get => this._clusterStatus; }

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

        /// <summary>Backing field for <see cref="ConnectionString" /> property.</summary>
        private string _connectionString;

        /// <summary>The default mongo connection string for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string ConnectionString { get => this._connectionString; }

        /// <summary>Backing field for <see cref="CreateMode" /> property.</summary>
        private string _createMode;

        /// <summary>The mode to create a mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string CreateMode { get => this._createMode; set => this._createMode = value; }

        /// <summary>Backing field for <see cref="HighAvailability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties _highAvailability;

        /// <summary>The high availability properties of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityProperties()); set => this._highAvailability = value; }

        /// <summary>The target high availability mode requested for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string HighAvailabilityTargetMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityPropertiesInternal)HighAvailability).TargetMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityPropertiesInternal)HighAvailability).TargetMode = value ?? null; }

        /// <summary>Backing field for <see cref="InfrastructureVersion" /> property.</summary>
        private string _infrastructureVersion;

        /// <summary>The infrastructure version the cluster is provisioned on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string InfrastructureVersion { get => this._infrastructureVersion; }

        /// <summary>Internal Acessors for Administrator</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.Administrator { get => (this._administrator = this._administrator ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.AdministratorProperties()); set { {_administrator = value;} } }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.BackupProperties()); set { {_backup = value;} } }

        /// <summary>Internal Acessors for BackupEarliestRestoreTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupPropertiesInternal)Backup).EarliestRestoreTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupPropertiesInternal)Backup).EarliestRestoreTime = value; }

        /// <summary>Internal Acessors for ClusterStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ClusterStatus { get => this._clusterStatus; set { {_clusterStatus = value;} } }

        /// <summary>Internal Acessors for Compute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.Compute { get => (this._compute = this._compute ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ComputeProperties()); set { {_compute = value;} } }

        /// <summary>Internal Acessors for ConnectionString</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ConnectionString { get => this._connectionString; set { {_connectionString = value;} } }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.HighAvailabilityProperties()); set { {_highAvailability = value;} } }

        /// <summary>Internal Acessors for InfrastructureVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.InfrastructureVersion { get => this._infrastructureVersion; set { {_infrastructureVersion = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.PrivateEndpointConnection { get => this._privateEndpointConnection; set { {_privateEndpointConnection = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Replica</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.Replica { get => (this._replica = this._replica ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ReplicationProperties()); set { {_replica = value;} } }

        /// <summary>Internal Acessors for ReplicaParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ReplicaParameter { get => (this._replicaParameter = this._replicaParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterReplicaParameters()); set { {_replicaParameter = value;} } }

        /// <summary>Internal Acessors for ReplicaReplicationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ReplicaReplicationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).ReplicationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).ReplicationState = value; }

        /// <summary>Internal Acessors for ReplicaRole</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ReplicaRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).Role; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).Role = value; }

        /// <summary>Internal Acessors for ReplicaSourceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.ReplicaSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).SourceResourceId = value; }

        /// <summary>Internal Acessors for RestoreParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.RestoreParameter { get => (this._restoreParameter = this._restoreParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterRestoreParameters()); set { {_restoreParameter = value;} } }

        /// <summary>Internal Acessors for Sharding</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.Sharding { get => (this._sharding = this._sharding ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ShardingProperties()); set { {_sharding = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal.Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.StorageProperties()); set { {_storage = value;} } }

        /// <summary>Backing field for <see cref="PreviewFeature" /> property.</summary>
        private System.Collections.Generic.List<string> _previewFeature;

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> PreviewFeature { get => this._previewFeature; set => this._previewFeature = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> _privateEndpointConnection;

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => this._privateEndpointConnection; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="Replica" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties _replica;

        /// <summary>The replication properties for the mongo cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties Replica { get => (this._replica = this._replica ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ReplicationProperties()); }

        /// <summary>Backing field for <see cref="ReplicaParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters _replicaParameter;

        /// <summary>The parameters to create a replica mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters ReplicaParameter { get => (this._replicaParameter = this._replicaParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterReplicaParameters()); set => this._replicaParameter = value; }

        /// <summary>The location of the source cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaParameterSourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParametersInternal)ReplicaParameter).SourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParametersInternal)ReplicaParameter).SourceLocation = value ?? null; }

        /// <summary>The id of the replication source cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaParameterSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParametersInternal)ReplicaParameter).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParametersInternal)ReplicaParameter).SourceResourceId = value ?? null; }

        /// <summary>The replication link state of the replica cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaReplicationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).ReplicationState; }

        /// <summary>The replication role of the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).Role; }

        /// <summary>The resource id the source cluster for the replica cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationPropertiesInternal)Replica).SourceResourceId; }

        /// <summary>Backing field for <see cref="RestoreParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters _restoreParameter;

        /// <summary>The parameters to create a point-in-time restore mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters RestoreParameter { get => (this._restoreParameter = this._restoreParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterRestoreParameters()); set => this._restoreParameter = value; }

        /// <summary>UTC point in time to restore a mongo cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public global::System.DateTime? RestoreParameterPointInTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParametersInternal)RestoreParameter).PointInTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParametersInternal)RestoreParameter).PointInTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Resource ID to locate the source cluster to restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string RestoreParameterSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParametersInternal)RestoreParameter).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParametersInternal)RestoreParameter).SourceResourceId = value ?? null; }

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

        /// <summary>Creates an new <see cref="MongoClusterProperties" /> instance.</summary>
        public MongoClusterProperties()
        {

        }
    }
    /// The properties of a mongo cluster.
    public partial interface IMongoClusterProperties :
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
        /// <summary>The status of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the mongo cluster.",
        SerializedName = @"clusterStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Ready", "Provisioning", "Updating", "Starting", "Stopping", "Stopped", "Dropping")]
        string ClusterStatus { get;  }
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
        /// <summary>The default mongo connection string for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The default mongo connection string for the cluster.",
        SerializedName = @"connectionString",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionString { get;  }
        /// <summary>The mode to create a mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The mode to create a mongo cluster.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Default", "PointInTimeRestore", "GeoReplica", "Replica")]
        string CreateMode { get; set; }
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
        /// <summary>The infrastructure version the cluster is provisioned on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The infrastructure version the cluster is provisioned on.",
        SerializedName = @"infrastructureVersion",
        PossibleTypes = new [] { typeof(string) })]
        string InfrastructureVersion { get;  }
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
        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of private endpoint connections.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get;  }
        /// <summary>The provisioning state of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the mongo cluster.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "InProgress", "Updating", "Dropping")]
        string ProvisioningState { get;  }
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
        /// <summary>The location of the source cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The location of the source cluster",
        SerializedName = @"sourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaParameterSourceLocation { get; set; }
        /// <summary>The id of the replication source cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The id of the replication source cluster.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaParameterSourceResourceId { get; set; }
        /// <summary>The replication link state of the replica cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The replication link state of the replica cluster.",
        SerializedName = @"replicationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Active", "Catchup", "Provisioning", "Updating", "Broken", "Reconfiguring")]
        string ReplicaReplicationState { get;  }
        /// <summary>The replication role of the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The replication role of the cluster",
        SerializedName = @"role",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Primary", "AsyncReplica", "GeoAsyncReplica")]
        string ReplicaRole { get;  }
        /// <summary>The resource id the source cluster for the replica cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource id the source cluster for the replica cluster.",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaSourceResourceId { get;  }
        /// <summary>UTC point in time to restore a mongo cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UTC point in time to restore a mongo cluster",
        SerializedName = @"pointInTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RestoreParameterPointInTimeUtc { get; set; }
        /// <summary>Resource ID to locate the source cluster to restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID to locate the source cluster to restore",
        SerializedName = @"sourceResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string RestoreParameterSourceResourceId { get; set; }
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
    /// The properties of a mongo cluster.
    internal partial interface IMongoClusterPropertiesInternal

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
        /// <summary>The status of the mongo cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Ready", "Provisioning", "Updating", "Starting", "Stopping", "Stopped", "Dropping")]
        string ClusterStatus { get; set; }
        /// <summary>The compute properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Compute { get; set; }
        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        string ComputeTier { get; set; }
        /// <summary>The default mongo connection string for the cluster.</summary>
        string ConnectionString { get; set; }
        /// <summary>The mode to create a mongo cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Default", "PointInTimeRestore", "GeoReplica", "Replica")]
        string CreateMode { get; set; }
        /// <summary>The high availability properties of the mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties HighAvailability { get; set; }
        /// <summary>The target high availability mode requested for the cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Disabled", "SameZone", "ZoneRedundantPreferred")]
        string HighAvailabilityTargetMode { get; set; }
        /// <summary>The infrastructure version the cluster is provisioned on.</summary>
        string InfrastructureVersion { get; set; }
        /// <summary>List of private endpoint connections.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("GeoReplicas")]
        System.Collections.Generic.List<string> PreviewFeature { get; set; }
        /// <summary>List of private endpoint connections.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>The provisioning state of the mongo cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "InProgress", "Updating", "Dropping")]
        string ProvisioningState { get; set; }
        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>The replication properties for the mongo cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties Replica { get; set; }
        /// <summary>The parameters to create a replica mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters ReplicaParameter { get; set; }
        /// <summary>The location of the source cluster</summary>
        string ReplicaParameterSourceLocation { get; set; }
        /// <summary>The id of the replication source cluster.</summary>
        string ReplicaParameterSourceResourceId { get; set; }
        /// <summary>The replication link state of the replica cluster.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Active", "Catchup", "Provisioning", "Updating", "Broken", "Reconfiguring")]
        string ReplicaReplicationState { get; set; }
        /// <summary>The replication role of the cluster</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PSArgumentCompleterAttribute("Primary", "AsyncReplica", "GeoAsyncReplica")]
        string ReplicaRole { get; set; }
        /// <summary>The resource id the source cluster for the replica cluster.</summary>
        string ReplicaSourceResourceId { get; set; }
        /// <summary>The parameters to create a point-in-time restore mongo cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters RestoreParameter { get; set; }
        /// <summary>UTC point in time to restore a mongo cluster</summary>
        global::System.DateTime? RestoreParameterPointInTimeUtc { get; set; }
        /// <summary>Resource ID to locate the source cluster to restore</summary>
        string RestoreParameterSourceResourceId { get; set; }
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