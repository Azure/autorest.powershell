// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties that can be updated for a server.</summary>
    public partial class ServerPropertiesForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal
    {

        /// <summary>Backing field for <see cref="AdministratorLoginPassword" /> property.</summary>
        private System.Security.SecureString _administratorLoginPassword;

        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Security.SecureString AdministratorLoginPassword { get => this._administratorLoginPassword; set => this._administratorLoginPassword = value; }

        /// <summary>Backing field for <see cref="Backup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup _backup;

        /// <summary>Backup related properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Backup()); set => this._backup = value; }

        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).EarliestRestoreDate; }

        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string BackupGeoRedundantBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).GeoRedundantBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).GeoRedundantBackup = value ?? null; }

        /// <summary>Backup interval hours for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupIntervalHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).IntervalHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).IntervalHour = value ?? default(int); }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).RetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).RetentionDay = value ?? default(int); }

        /// <summary>Backing field for <see cref="DataEncryption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption _dataEncryption;

        /// <summary>The Data Encryption for CMK.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption DataEncryption { get => (this._dataEncryption = this._dataEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.DataEncryption()); set => this._dataEncryption = value; }

        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionGeoBackupKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).GeoBackupKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).GeoBackupKeyUri = value ?? null; }

        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionGeoBackupUserAssignedIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).GeoBackupUserAssignedIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).GeoBackupUserAssignedIdentityId = value ?? null; }

        /// <summary>Primary key uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionPrimaryKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).PrimaryKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).PrimaryKeyUri = value ?? null; }

        /// <summary>Primary user identity resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionPrimaryUserAssignedIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).PrimaryUserAssignedIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).PrimaryUserAssignedIdentityId = value ?? null; }

        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryptionInternal)DataEncryption).Type = value ?? null; }

        /// <summary>Backing field for <see cref="HighAvailability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability _highAvailability;

        /// <summary>High availability related properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.HighAvailability()); set => this._highAvailability = value; }

        /// <summary>High availability mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).Mode = value ?? null; }

        /// <summary>HA Replication mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityReplicationMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).ReplicationMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).ReplicationMode = value ?? null; }

        /// <summary>Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityStandbyAvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).StandbyAvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).StandbyAvailabilityZone = value ?? null; }

        /// <summary>The state of server high availability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).State; }

        /// <summary>Backing field for <see cref="MaintenancePolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy _maintenancePolicy;

        /// <summary>Maintenance policy of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy MaintenancePolicy { get => (this._maintenancePolicy = this._maintenancePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenancePolicy()); set => this._maintenancePolicy = value; }

        /// <summary>The patch strategy of this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenancePolicyPatchStrategy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicyInternal)MaintenancePolicy).PatchStrategy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicyInternal)MaintenancePolicy).PatchStrategy = value ?? null; }

        /// <summary>Backing field for <see cref="MaintenanceWindow" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow _maintenanceWindow;

        /// <summary>Maintenance window of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenanceWindow()); set => this._maintenanceWindow = value; }

        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowBatchOfMaintenance { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).BatchOfMaintenance; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).BatchOfMaintenance = value ?? null; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).CustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).CustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).DayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).DayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).StartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).StartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).StartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal)MaintenanceWindow).StartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Backup()); set { {_backup = value;} } }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).EarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).EarliestRestoreDate = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for DataEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.DataEncryption { get => (this._dataEncryption = this._dataEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.DataEncryption()); set { {_dataEncryption = value;} } }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.HighAvailability()); set { {_highAvailability = value;} } }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).State = value ?? null; }

        /// <summary>Internal Acessors for MaintenancePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.MaintenancePolicy { get => (this._maintenancePolicy = this._maintenancePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenancePolicy()); set { {_maintenancePolicy = value;} } }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenanceWindow()); set { {_maintenanceWindow = value;} } }

        /// <summary>Internal Acessors for Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.Network { get => (this._network = this._network ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Network()); set { {_network = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Storage()); set { {_storage = value;} } }

        /// <summary>Internal Acessors for StorageSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal.StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Sku = value ?? null; }

        /// <summary>Backing field for <see cref="Network" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork _network;

        /// <summary>Network related properties of a server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork Network { get => (this._network = this._network ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Network()); set => this._network = value; }

        /// <summary>Delegated subnet resource id used to setup vnet for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkDelegatedSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetworkInternal)Network).DelegatedSubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetworkInternal)Network).DelegatedSubnetResourceId = value ?? null; }

        /// <summary>Private DNS zone resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkPrivateDnsZoneResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetworkInternal)Network).PrivateDnsZoneResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetworkInternal)Network).PrivateDnsZoneResourceId = value ?? null; }

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkPublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetworkInternal)Network).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetworkInternal)Network).PublicNetworkAccess = value ?? null; }

        /// <summary>Backing field for <see cref="ReplicationRole" /> property.</summary>
        private string _replicationRole;

        /// <summary>The replication role of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ReplicationRole { get => this._replicationRole; set => this._replicationRole = value; }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage _storage;

        /// <summary>Storage related properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Storage()); set => this._storage = value; }

        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageAutoGrow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).AutoGrow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).AutoGrow = value ?? null; }

        /// <summary>Enable IO Auto Scaling or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageAutoIoScaling { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).AutoIoScaling; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).AutoIoScaling = value ?? null; }

        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageIop { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Iop; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Iop = value ?? default(int); }

        /// <summary>Enable Log On Disk or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageLogOnDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).LogOnDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).LogOnDisk = value ?? null; }

        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageRedundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Redundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Redundancy = value ?? null; }

        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).SizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).SizeGb = value ?? default(int); }

        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Sku; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ServerPropertiesForUpdate" /> instance.</summary>
        public ServerPropertiesForUpdate()
        {

        }
    }
    /// The properties that can be updated for a server.
    public partial interface IServerPropertiesForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The password of the administrator login.",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Earliest restore point creation time (ISO8601 format)",
        SerializedName = @"earliestRestoreDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? BackupEarliestRestoreDate { get;  }
        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether or not geo redundant backup is enabled.",
        SerializedName = @"geoRedundantBackup",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup interval hours for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup interval hours for the server.",
        SerializedName = @"backupIntervalHours",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupIntervalHour { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupRetentionDay { get; set; }
        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup",
        SerializedName = @"geoBackupKeyURI",
        PossibleTypes = new [] { typeof(string) })]
        string DataEncryptionGeoBackupKeyUri { get; set; }
        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup",
        SerializedName = @"geoBackupUserAssignedIdentityId",
        PossibleTypes = new [] { typeof(string) })]
        string DataEncryptionGeoBackupUserAssignedIdentityId { get; set; }
        /// <summary>Primary key uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Primary key uri",
        SerializedName = @"primaryKeyURI",
        PossibleTypes = new [] { typeof(string) })]
        string DataEncryptionPrimaryKeyUri { get; set; }
        /// <summary>Primary user identity resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Primary user identity resource id",
        SerializedName = @"primaryUserAssignedIdentityId",
        PossibleTypes = new [] { typeof(string) })]
        string DataEncryptionPrimaryUserAssignedIdentityId { get; set; }
        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureKeyVault", "SystemManaged")]
        string DataEncryptionType { get; set; }
        /// <summary>High availability mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"High availability mode for a server.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Disabled", "ZoneRedundant", "SameZone")]
        string HighAvailabilityMode { get; set; }
        /// <summary>HA Replication mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"HA Replication mode for a server.",
        SerializedName = @"replicationMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("BinaryLog", "RedoLog")]
        string HighAvailabilityReplicationMode { get; set; }
        /// <summary>Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Availability zone of the standby server.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>The state of server high availability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The state of server high availability.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("NotEnabled", "CreatingStandby", "Healthy", "FailingOver", "RemovingStandby")]
        string HighAvailabilityState { get;  }
        /// <summary>The patch strategy of this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The patch strategy of this server",
        SerializedName = @"patchStrategy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Regular", "VirtualCanary")]
        string MaintenancePolicyPatchStrategy { get; set; }
        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The batch of maintenance when enabled the custom managed maintenance window of a server.",
        SerializedName = @"batchOfMaintenance",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "Batch1", "Batch2")]
        string MaintenanceWindowBatchOfMaintenance { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"indicates whether custom window is enabled or disabled",
        SerializedName = @"customWindow",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"day of week for maintenance window",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"start hour for maintenance window",
        SerializedName = @"startHour",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"start minute for maintenance window",
        SerializedName = @"startMinute",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>Delegated subnet resource id used to setup vnet for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Delegated subnet resource id used to setup vnet for a server.",
        SerializedName = @"delegatedSubnetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkDelegatedSubnetResourceId { get; set; }
        /// <summary>Private DNS zone resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private DNS zone resource id.",
        SerializedName = @"privateDnsZoneResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkPrivateDnsZoneResourceId { get; set; }
        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string NetworkPublicNetworkAccess { get; set; }
        /// <summary>The replication role of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The replication role of the server.",
        SerializedName = @"replicationRole",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        string ReplicationRole { get; set; }
        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable Storage Auto Grow or not.",
        SerializedName = @"autoGrow",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string StorageAutoGrow { get; set; }
        /// <summary>Enable IO Auto Scaling or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable IO Auto Scaling or not.",
        SerializedName = @"autoIoScaling",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string StorageAutoIoScaling { get; set; }
        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage IOPS for a server.",
        SerializedName = @"iops",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageIop { get; set; }
        /// <summary>Enable Log On Disk or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable Log On Disk or not.",
        SerializedName = @"logOnDisk",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string StorageLogOnDisk { get; set; }
        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The redundant type of the server storage. The parameter is used for server creation.",
        SerializedName = @"storageRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("LocalRedundancy", "ZoneRedundancy")]
        string StorageRedundancy { get; set; }
        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max storage size allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageSizeGb { get; set; }
        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The sku name of the server storage.",
        SerializedName = @"storageSku",
        PossibleTypes = new [] { typeof(string) })]
        string StorageSku { get;  }
        /// <summary>Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("5.7", "8.0.21", "8.4")]
        string Version { get; set; }

    }
    /// The properties that can be updated for a server.
    internal partial interface IServerPropertiesForUpdateInternal

    {
        /// <summary>The password of the administrator login.</summary>
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>Backup related properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup Backup { get; set; }
        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        global::System.DateTime? BackupEarliestRestoreDate { get; set; }
        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup interval hours for the server.</summary>
        int? BackupIntervalHour { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        int? BackupRetentionDay { get; set; }
        /// <summary>The Data Encryption for CMK.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption DataEncryption { get; set; }
        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        string DataEncryptionGeoBackupKeyUri { get; set; }
        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        string DataEncryptionGeoBackupUserAssignedIdentityId { get; set; }
        /// <summary>Primary key uri</summary>
        string DataEncryptionPrimaryKeyUri { get; set; }
        /// <summary>Primary user identity resource id</summary>
        string DataEncryptionPrimaryUserAssignedIdentityId { get; set; }
        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureKeyVault", "SystemManaged")]
        string DataEncryptionType { get; set; }
        /// <summary>High availability related properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability HighAvailability { get; set; }
        /// <summary>High availability mode for a server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Disabled", "ZoneRedundant", "SameZone")]
        string HighAvailabilityMode { get; set; }
        /// <summary>HA Replication mode for a server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("BinaryLog", "RedoLog")]
        string HighAvailabilityReplicationMode { get; set; }
        /// <summary>Availability zone of the standby server.</summary>
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>The state of server high availability.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("NotEnabled", "CreatingStandby", "Healthy", "FailingOver", "RemovingStandby")]
        string HighAvailabilityState { get; set; }
        /// <summary>Maintenance policy of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy MaintenancePolicy { get; set; }
        /// <summary>The patch strategy of this server</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Regular", "VirtualCanary")]
        string MaintenancePolicyPatchStrategy { get; set; }
        /// <summary>Maintenance window of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "Batch1", "Batch2")]
        string MaintenanceWindowBatchOfMaintenance { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>Network related properties of a server</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork Network { get; set; }
        /// <summary>Delegated subnet resource id used to setup vnet for a server.</summary>
        string NetworkDelegatedSubnetResourceId { get; set; }
        /// <summary>Private DNS zone resource id.</summary>
        string NetworkPrivateDnsZoneResourceId { get; set; }
        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string NetworkPublicNetworkAccess { get; set; }
        /// <summary>The replication role of the server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        string ReplicationRole { get; set; }
        /// <summary>Storage related properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage Storage { get; set; }
        /// <summary>Enable Storage Auto Grow or not.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string StorageAutoGrow { get; set; }
        /// <summary>Enable IO Auto Scaling or not.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string StorageAutoIoScaling { get; set; }
        /// <summary>Storage IOPS for a server.</summary>
        int? StorageIop { get; set; }
        /// <summary>Enable Log On Disk or not.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string StorageLogOnDisk { get; set; }
        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("LocalRedundancy", "ZoneRedundancy")]
        string StorageRedundancy { get; set; }
        /// <summary>Max storage size allowed for a server.</summary>
        int? StorageSizeGb { get; set; }
        /// <summary>The sku name of the server storage.</summary>
        string StorageSku { get; set; }
        /// <summary>Server version.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("5.7", "8.0.21", "8.4")]
        string Version { get; set; }

    }
}