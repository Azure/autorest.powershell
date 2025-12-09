// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Parameters allowed to update for a server.</summary>
    public partial class ServerForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal
    {

        /// <summary>The password of the administrator login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public System.Security.SecureString AdministratorLoginPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).AdministratorLoginPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).AdministratorLoginPassword = value ?? null; }

        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate; }

        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string BackupGeoRedundantBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupGeoRedundantBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupGeoRedundantBackup = value ?? null; }

        /// <summary>Backup interval hours for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupIntervalHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupIntervalHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupIntervalHour = value ?? default(int); }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupRetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupRetentionDay = value ?? default(int); }

        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionGeoBackupKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionGeoBackupKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionGeoBackupKeyUri = value ?? null; }

        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionGeoBackupUserAssignedIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionGeoBackupUserAssignedIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionGeoBackupUserAssignedIdentityId = value ?? null; }

        /// <summary>Primary key uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionPrimaryKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionPrimaryKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionPrimaryKeyUri = value ?? null; }

        /// <summary>Primary user identity resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionPrimaryUserAssignedIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionPrimaryUserAssignedIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionPrimaryUserAssignedIdentityId = value ?? null; }

        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryptionType = value ?? null; }

        /// <summary>High availability mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityMode = value ?? null; }

        /// <summary>HA Replication mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityReplicationMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityReplicationMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityReplicationMode = value ?? null; }

        /// <summary>Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityStandbyAvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityStandbyAvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityStandbyAvailabilityZone = value ?? null; }

        /// <summary>The state of server high availability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentity _identity;

        /// <summary>The cmk identity for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlServerIdentity()); set => this._identity = value; }

        /// <summary>ObjectId from the KeyVault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).PrincipalId; }

        /// <summary>TenantId from the KeyVault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).TenantId; }

        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>Metadata of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The patch strategy of this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenancePolicyPatchStrategy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenancePolicyPatchStrategy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenancePolicyPatchStrategy = value ?? null; }

        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowBatchOfMaintenance { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowBatchOfMaintenance; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowBatchOfMaintenance = value ?? null; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowCustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowCustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowDayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowDayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindowStartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.Backup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Backup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Backup = value ?? null /* model class */; }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).BackupEarliestRestoreDate = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for DataEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.DataEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).DataEncryption = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.HighAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailability = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).HighAvailabilityState = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentity Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlServerIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for MaintenancePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.MaintenancePolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenancePolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenancePolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.MaintenanceWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).MaintenanceWindow = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.Network { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Network; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Network = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdate Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ServerPropertiesForUpdate()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSku Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlServerSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.Storage { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Storage = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StorageSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateInternal.StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageSku = value ?? null; }

        /// <summary>Delegated subnet resource id used to setup vnet for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkDelegatedSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).NetworkDelegatedSubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).NetworkDelegatedSubnetResourceId = value ?? null; }

        /// <summary>Private DNS zone resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkPrivateDnsZoneResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).NetworkPrivateDnsZoneResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).NetworkPrivateDnsZoneResourceId = value ?? null; }

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkPublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).NetworkPublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).NetworkPublicNetworkAccess = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdate _property;

        /// <summary>The properties that can be updated for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ServerPropertiesForUpdate()); set => this._property = value; }

        /// <summary>The replication role of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ReplicationRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).ReplicationRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).ReplicationRole = value ?? null; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSku _sku;

        /// <summary>The SKU (pricing tier) of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlServerSku()); set => this._sku = value; }

        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSkuInternal)Sku).Name = value ?? null; }

        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSkuInternal)Sku).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSkuInternal)Sku).Tier = value ?? null; }

        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageAutoGrow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageAutoGrow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageAutoGrow = value ?? null; }

        /// <summary>Enable IO Auto Scaling or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageAutoIoScaling { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageAutoIoScaling; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageAutoIoScaling = value ?? null; }

        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageIop { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageIop; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageIop = value ?? default(int); }

        /// <summary>Enable Log On Disk or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageLogOnDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageLogOnDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageLogOnDisk = value ?? null; }

        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageRedundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageRedundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageRedundancy = value ?? null; }

        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageSizeGb = value ?? default(int); }

        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).StorageSku; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateTags _tag;

        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ServerForUpdateTags()); set => this._tag = value; }

        /// <summary>Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdateInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="ServerForUpdate" /> instance.</summary>
        public ServerForUpdate()
        {

        }
    }
    /// Parameters allowed to update for a server.
    public partial interface IServerForUpdate :
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
        /// <summary>ObjectId from the KeyVault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ObjectId from the KeyVault",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>TenantId from the KeyVault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"TenantId from the KeyVault",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of managed service identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>Metadata of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Metadata of user assigned identity.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the sku, e.g. Standard_D32s_v3.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The tier of the particular SKU, e.g. GeneralPurpose.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Burstable", "GeneralPurpose", "MemoryOptimized")]
        string SkuTier { get; set; }
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
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Application-specific metadata in the form of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateTags Tag { get; set; }
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
    /// Parameters allowed to update for a server.
    internal partial interface IServerForUpdateInternal

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
        /// <summary>The cmk identity for the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentity Identity { get; set; }
        /// <summary>ObjectId from the KeyVault</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>TenantId from the KeyVault</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Type of managed service identity.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>Metadata of user assigned identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
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
        /// <summary>The properties that can be updated for a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesForUpdate Property { get; set; }
        /// <summary>The replication role of the server.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        string ReplicationRole { get; set; }
        /// <summary>The SKU (pricing tier) of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSku Sku { get; set; }
        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Burstable", "GeneralPurpose", "MemoryOptimized")]
        string SkuTier { get; set; }
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
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerForUpdateTags Tag { get; set; }
        /// <summary>Server version.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("5.7", "8.0.21", "8.4")]
        string Version { get; set; }

    }
}