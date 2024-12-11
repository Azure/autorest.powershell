// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Extensions;

    /// <summary>Represents a mongo cluster resource.</summary>
    public partial class MongoCluster :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoCluster,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IValidates,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IHeaderSerializable
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.TrackedResource();

        /// <summary>The administrator password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string AdministratorPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).AdministratorPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).AdministratorPassword = value ?? null; }

        /// <summary>The administrator user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string AdministratorUserName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).AdministratorUserName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).AdministratorUserName = value ?? null; }

        /// <summary>Earliest restore timestamp in UTC ISO8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).BackupEarliestRestoreTime; }

        /// <summary>The status of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ClusterStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ClusterStatus; }

        /// <summary>
        /// The compute tier to assign to the cluster, where each tier maps to a virtual-core and memory size. Example values: 'M30',
        /// 'M40'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ComputeTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ComputeTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ComputeTier = value ?? null; }

        /// <summary>The default mongo connection string for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ConnectionString { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ConnectionString; }

        /// <summary>The mode to create a mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string CreateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).CreateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).CreateMode = value ?? null; }

        /// <summary>The target high availability mode requested for the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string HighAvailabilityTargetMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).HighAvailabilityTargetMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).HighAvailabilityTargetMode = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The infrastructure version the cluster is provisioned on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string InfrastructureVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).InfrastructureVersion; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Internal Acessors for Administrator</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IAdministratorProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Administrator { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Administrator; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Administrator = value; }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IBackupProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Backup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Backup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Backup = value; }

        /// <summary>Internal Acessors for BackupEarliestRestoreTime</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.BackupEarliestRestoreTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).BackupEarliestRestoreTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).BackupEarliestRestoreTime = value; }

        /// <summary>Internal Acessors for ClusterStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ClusterStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ClusterStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ClusterStatus = value; }

        /// <summary>Internal Acessors for Compute</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IComputeProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Compute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Compute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Compute = value; }

        /// <summary>Internal Acessors for ConnectionString</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ConnectionString { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ConnectionString; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ConnectionString = value; }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IHighAvailabilityProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.HighAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).HighAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).HighAvailability = value; }

        /// <summary>Internal Acessors for InfrastructureVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.InfrastructureVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).InfrastructureVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).InfrastructureVersion = value; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PrivateEndpointConnection = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Replica</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IReplicationProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Replica { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Replica; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Replica = value; }

        /// <summary>Internal Acessors for ReplicaParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterReplicaParameters Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ReplicaParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaParameter = value; }

        /// <summary>Internal Acessors for ReplicaReplicationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ReplicaReplicationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaReplicationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaReplicationState = value; }

        /// <summary>Internal Acessors for ReplicaRole</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ReplicaRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaRole = value; }

        /// <summary>Internal Acessors for ReplicaSourceResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.ReplicaSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaSourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaSourceResourceId = value; }

        /// <summary>Internal Acessors for RestoreParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterRestoreParameters Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.RestoreParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).RestoreParameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).RestoreParameter = value; }

        /// <summary>Internal Acessors for Sharding</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IShardingProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Sharding { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Sharding; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Sharding = value; }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IStorageProperties Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal.Storage { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).Storage = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreviewFeature { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PreviewFeature; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PreviewFeature = value ?? null /* arrayOf */; }

        /// <summary>List of private endpoint connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.MongoClusterProperties()); set => this._property = value; }

        /// <summary>The provisioning state of the mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Whether or not public endpoint access is allowed for this mongo cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>The location of the source cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaParameterSourceLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaParameterSourceLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaParameterSourceLocation = value ?? null; }

        /// <summary>The id of the replication source cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaParameterSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaParameterSourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaParameterSourceResourceId = value ?? null; }

        /// <summary>The replication link state of the replica cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaReplicationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaReplicationState; }

        /// <summary>The replication role of the cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaRole; }

        /// <summary>The resource id the source cluster for the replica cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ReplicaSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ReplicaSourceResourceId; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>UTC point in time to restore a mongo cluster</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public global::System.DateTime? RestoreParameterPointInTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).RestoreParameterPointInTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).RestoreParameterPointInTimeUtc = value ?? default(global::System.DateTime); }

        /// <summary>Resource ID to locate the source cluster to restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string RestoreParameterSourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).RestoreParameterSourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).RestoreParameterSourceResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>
        /// The Mongo DB server version. Defaults to the latest available version if not specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public string ServerVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ServerVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ServerVersion = value ?? null; }

        /// <summary>Number of shards to provision on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public int? ShardingShardCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ShardingShardCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).ShardingShardCount = value ?? default(int); }

        /// <summary>The size of the data disk assigned to each server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inlined)]
        public long? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).StorageSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterPropertiesInternal)Property).StorageSizeGb = value ?? default(long); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Origin(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IResourceInternal)__trackedResource).Type; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader0) is string __headerRetryAfterHeader0 ? int.TryParse( __headerRetryAfterHeader0, out int __headerRetryAfterHeader0Value ) ? __headerRetryAfterHeader0Value : default(int?) : default(int?);
            }
        }

        /// <summary>Creates an new <see cref="MongoCluster" /> instance.</summary>
        public MongoCluster()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Represents a mongo cluster resource.
    public partial interface IMongoCluster :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResource
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

        [Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }
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
    /// Represents a mongo cluster resource.
    internal partial interface IMongoClusterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.ITrackedResourceInternal
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MongoCluster.Models.IMongoClusterProperties Property { get; set; }
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

        int? RetryAfter { get; set; }
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