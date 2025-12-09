// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of a server.</summary>
    public partial class ServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdministratorLogin" /> property.</summary>
        private string _administratorLogin;

        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string AdministratorLogin { get => this._administratorLogin; set => this._administratorLogin = value; }

        /// <summary>Backing field for <see cref="AdministratorLoginPassword" /> property.</summary>
        private System.Security.SecureString _administratorLoginPassword;

        /// <summary>The password of the administrator login (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Security.SecureString AdministratorLoginPassword { get => this._administratorLoginPassword; set => this._administratorLoginPassword = value; }

        /// <summary>Backing field for <see cref="AvailabilityZone" /> property.</summary>
        private string _availabilityZone;

        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string AvailabilityZone { get => this._availabilityZone; set => this._availabilityZone = value; }

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

        /// <summary>Backing field for <see cref="CreateMode" /> property.</summary>
        private string _createMode;

        /// <summary>The mode to create a new MySQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string CreateMode { get => this._createMode; set => this._createMode = value; }

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

        /// <summary>Backing field for <see cref="DatabasePort" /> property.</summary>
        private int? _databasePort;

        /// <summary>
        /// The server database port. Can only be specified when the server is being created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? DatabasePort { get => this._databasePort; set => this._databasePort = value; }

        /// <summary>Backing field for <see cref="FullVersion" /> property.</summary>
        private string _fullVersion;

        /// <summary>Major version and actual engine version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string FullVersion { get => this._fullVersion; }

        /// <summary>Backing field for <see cref="FullyQualifiedDomainName" /> property.</summary>
        private string _fullyQualifiedDomainName;

        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; }

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

        /// <summary>Backing field for <see cref="ImportSourceProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourceProperties _importSourceProperty;

        /// <summary>Source properties for import from storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourceProperties ImportSourceProperty { get => (this._importSourceProperty = this._importSourceProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ImportSourceProperties()); set => this._importSourceProperty = value; }

        /// <summary>Relative path of data directory in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ImportSourcePropertyDataDirPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).DataDirPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).DataDirPath = value ?? null; }

        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public System.Security.SecureString ImportSourcePropertySasToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).SasToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).SasToken = value ?? null; }

        /// <summary>Storage type of import source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ImportSourcePropertyStorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).StorageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).StorageType = value ?? null; }

        /// <summary>Uri of the import source storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ImportSourcePropertyStorageUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).StorageUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourcePropertiesInternal)ImportSourceProperty).StorageUrl = value ?? null; }

        /// <summary>Backing field for <see cref="LowerCaseTableName" /> property.</summary>
        private int? _lowerCaseTableName;

        /// <summary>
        /// The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or
        /// 2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? LowerCaseTableName { get => this._lowerCaseTableName; set => this._lowerCaseTableName = value; }

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

        /// <summary>
        /// Maintenance window of a server. Known issue: cannot be set during server creation or updated with other properties during
        /// server update; must be updated separately.
        /// </summary>
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
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Backup()); set { {_backup = value;} } }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).EarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackupInternal)Backup).EarliestRestoreDate = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for DataEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.DataEncryption { get => (this._dataEncryption = this._dataEncryption ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.DataEncryption()); set { {_dataEncryption = value;} } }

        /// <summary>Internal Acessors for FullVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.FullVersion { get => this._fullVersion; set { {_fullVersion = value;} } }

        /// <summary>Internal Acessors for FullyQualifiedDomainName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; set { {_fullyQualifiedDomainName = value;} } }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.HighAvailability()); set { {_highAvailability = value;} } }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailabilityInternal)HighAvailability).State = value ?? null; }

        /// <summary>Internal Acessors for ImportSourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourceProperties Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.ImportSourceProperty { get => (this._importSourceProperty = this._importSourceProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ImportSourceProperties()); set { {_importSourceProperty = value;} } }

        /// <summary>Internal Acessors for MaintenancePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.MaintenancePolicy { get => (this._maintenancePolicy = this._maintenancePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenancePolicy()); set { {_maintenancePolicy = value;} } }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenanceWindow()); set { {_maintenanceWindow = value;} } }

        /// <summary>Internal Acessors for Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.Network { get => (this._network = this._network ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Network()); set { {_network = value;} } }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.PrivateEndpointConnection { get => this._privateEndpointConnection; set { {_privateEndpointConnection = value;} } }

        /// <summary>Internal Acessors for ReplicaCapacity</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.ReplicaCapacity { get => this._replicaCapacity; set { {_replicaCapacity = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Storage()); set { {_storage = value;} } }

        /// <summary>Internal Acessors for StorageSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal.StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal)Storage).Sku = value ?? null; }

        /// <summary>Backing field for <see cref="Network" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork _network;

        /// <summary>Network related properties of a server.</summary>
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

        /// <summary>Backing field for <see cref="PrivateEndpointConnection" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> _privateEndpointConnection;

        /// <summary>PrivateEndpointConnections related properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => this._privateEndpointConnection; }

        /// <summary>Backing field for <see cref="ReplicaCapacity" /> property.</summary>
        private int? _replicaCapacity;

        /// <summary>The maximum number of replicas that a primary server can have.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? ReplicaCapacity { get => this._replicaCapacity; }

        /// <summary>Backing field for <see cref="ReplicationRole" /> property.</summary>
        private string _replicationRole;

        /// <summary>The replication role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ReplicationRole { get => this._replicationRole; set => this._replicationRole = value; }

        /// <summary>Backing field for <see cref="RestorePointInTime" /> property.</summary>
        private global::System.DateTime? _restorePointInTime;

        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? RestorePointInTime { get => this._restorePointInTime; set => this._restorePointInTime = value; }

        /// <summary>Backing field for <see cref="SourceServerResourceId" /> property.</summary>
        private string _sourceServerResourceId;

        /// <summary>The source MySQL server id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string SourceServerResourceId { get => this._sourceServerResourceId; set => this._sourceServerResourceId = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The state of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string State { get => this._state; }

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

        /// <summary>
        /// Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ServerProperties" /> instance.</summary>
        public ServerProperties()
        {

        }
    }
    /// The properties of a server.
    public partial interface IServerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).",
        SerializedName = @"administratorLogin",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorLogin { get; set; }
        /// <summary>The password of the administrator login (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = true,
        Description = @"The password of the administrator login (required for server creation).",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"availability Zone information of the server.",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }
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
        /// <summary>The mode to create a new MySQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"The mode to create a new MySQL server.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "PointInTimeRestore", "Replica", "GeoRestore")]
        string CreateMode { get; set; }
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
        /// <summary>
        /// The server database port. Can only be specified when the server is being created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The server database port. Can only be specified when the server is being created.",
        SerializedName = @"databasePort",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabasePort { get; set; }
        /// <summary>Major version and actual engine version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Major version and actual engine version",
        SerializedName = @"fullVersion",
        PossibleTypes = new [] { typeof(string) })]
        string FullVersion { get;  }
        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The fully qualified domain name of a server.",
        SerializedName = @"fullyQualifiedDomainName",
        PossibleTypes = new [] { typeof(string) })]
        string FullyQualifiedDomainName { get;  }
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
        /// <summary>Relative path of data directory in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Relative path of data directory in storage.",
        SerializedName = @"dataDirPath",
        PossibleTypes = new [] { typeof(string) })]
        string ImportSourcePropertyDataDirPath { get; set; }
        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Sas token for accessing source storage. Read and list permissions are required for sas token.",
        SerializedName = @"sasToken",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString ImportSourcePropertySasToken { get; set; }
        /// <summary>Storage type of import source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Storage type of import source.",
        SerializedName = @"storageType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureBlob")]
        string ImportSourcePropertyStorageType { get; set; }
        /// <summary>Uri of the import source storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Uri of the import source storage.",
        SerializedName = @"storageUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ImportSourcePropertyStorageUrl { get; set; }
        /// <summary>
        /// The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or
        /// 2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or 2.",
        SerializedName = @"lowerCaseTableNames",
        PossibleTypes = new [] { typeof(int) })]
        int? LowerCaseTableName { get; set; }
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
        Create = false,
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
        Create = false,
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
        Create = false,
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
        Create = false,
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
        Create = false,
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
        Update = false,
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
        Update = false,
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
        Update = false,
        Description = @"Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string NetworkPublicNetworkAccess { get; set; }
        /// <summary>PrivateEndpointConnections related properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"PrivateEndpointConnections related properties of a server.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get;  }
        /// <summary>The maximum number of replicas that a primary server can have.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The maximum number of replicas that a primary server can have.",
        SerializedName = @"replicaCapacity",
        PossibleTypes = new [] { typeof(int) })]
        int? ReplicaCapacity { get;  }
        /// <summary>The replication role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The replication role.",
        SerializedName = @"replicationRole",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        string ReplicationRole { get; set; }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Restore point creation time (ISO8601 format), specifying the time to restore from.",
        SerializedName = @"restorePointInTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RestorePointInTime { get; set; }
        /// <summary>The source MySQL server id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The source MySQL server id.",
        SerializedName = @"sourceServerResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceServerResourceId { get; set; }
        /// <summary>The state of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The state of a server.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Ready", "Dropping", "Disabled", "Starting", "Stopping", "Stopped", "Updating")]
        string State { get;  }
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
        /// <summary>
        /// Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("5.7", "8.0.21", "8.4")]
        string Version { get; set; }

    }
    /// The properties of a server.
    internal partial interface IServerPropertiesInternal

    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        string AdministratorLogin { get; set; }
        /// <summary>The password of the administrator login (required for server creation).</summary>
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>availability Zone information of the server.</summary>
        string AvailabilityZone { get; set; }
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
        /// <summary>The mode to create a new MySQL server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "PointInTimeRestore", "Replica", "GeoRestore")]
        string CreateMode { get; set; }
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
        /// <summary>
        /// The server database port. Can only be specified when the server is being created.
        /// </summary>
        int? DatabasePort { get; set; }
        /// <summary>Major version and actual engine version</summary>
        string FullVersion { get; set; }
        /// <summary>The fully qualified domain name of a server.</summary>
        string FullyQualifiedDomainName { get; set; }
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
        /// <summary>Source properties for import from storage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourceProperties ImportSourceProperty { get; set; }
        /// <summary>Relative path of data directory in storage.</summary>
        string ImportSourcePropertyDataDirPath { get; set; }
        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        System.Security.SecureString ImportSourcePropertySasToken { get; set; }
        /// <summary>Storage type of import source.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("AzureBlob")]
        string ImportSourcePropertyStorageType { get; set; }
        /// <summary>Uri of the import source storage.</summary>
        string ImportSourcePropertyStorageUrl { get; set; }
        /// <summary>
        /// The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or
        /// 2.
        /// </summary>
        int? LowerCaseTableName { get; set; }
        /// <summary>Maintenance policy of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy MaintenancePolicy { get; set; }
        /// <summary>The patch strategy of this server</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Regular", "VirtualCanary")]
        string MaintenancePolicyPatchStrategy { get; set; }
        /// <summary>
        /// Maintenance window of a server. Known issue: cannot be set during server creation or updated with other properties during
        /// server update; must be updated separately.
        /// </summary>
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
        /// <summary>Network related properties of a server.</summary>
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
        /// <summary>PrivateEndpointConnections related properties of a server.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>The maximum number of replicas that a primary server can have.</summary>
        int? ReplicaCapacity { get; set; }
        /// <summary>The replication role.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        string ReplicationRole { get; set; }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        global::System.DateTime? RestorePointInTime { get; set; }
        /// <summary>The source MySQL server id.</summary>
        string SourceServerResourceId { get; set; }
        /// <summary>The state of a server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Ready", "Dropping", "Disabled", "Starting", "Stopping", "Stopped", "Updating")]
        string State { get; set; }
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
        /// <summary>
        /// Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("5.7", "8.0.21", "8.4")]
        string Version { get; set; }

    }
}