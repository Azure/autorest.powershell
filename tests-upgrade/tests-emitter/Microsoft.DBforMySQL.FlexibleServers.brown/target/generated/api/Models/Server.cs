// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents a server.</summary>
    public partial class Server :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServer,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.TrackedResource();

        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string AdministratorLogin { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).AdministratorLogin; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).AdministratorLogin = value ?? null; }

        /// <summary>The password of the administrator login (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public System.Security.SecureString AdministratorLoginPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).AdministratorLoginPassword; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).AdministratorLoginPassword = value ?? null; }

        /// <summary>availability Zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string AvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).AvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).AvailabilityZone = value ?? null; }

        /// <summary>Earliest restore point creation time (ISO8601 format)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupEarliestRestoreDate; }

        /// <summary>Whether or not geo redundant backup is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string BackupGeoRedundantBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupGeoRedundantBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupGeoRedundantBackup = value ?? null; }

        /// <summary>Backup interval hours for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupIntervalHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupIntervalHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupIntervalHour = value ?? default(int); }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? BackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupRetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupRetentionDay = value ?? default(int); }

        /// <summary>The mode to create a new MySQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string CreateMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).CreateMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).CreateMode = value ?? null; }

        /// <summary>
        /// Geo backup key uri as key vault can't cross region, need cmk in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionGeoBackupKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionGeoBackupKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionGeoBackupKeyUri = value ?? null; }

        /// <summary>
        /// Geo backup user identity resource id as identity can't cross region, need identity in same region as geo backup
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionGeoBackupUserAssignedIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionGeoBackupUserAssignedIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionGeoBackupUserAssignedIdentityId = value ?? null; }

        /// <summary>Primary key uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionPrimaryKeyUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionPrimaryKeyUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionPrimaryKeyUri = value ?? null; }

        /// <summary>Primary user identity resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionPrimaryUserAssignedIdentityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionPrimaryUserAssignedIdentityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionPrimaryUserAssignedIdentityId = value ?? null; }

        /// <summary>The key type, AzureKeyVault for enable cmk, SystemManaged for disable cmk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string DataEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryptionType = value ?? null; }

        /// <summary>
        /// The server database port. Can only be specified when the server is being created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? DatabasePort { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DatabasePort; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DatabasePort = value ?? default(int); }

        /// <summary>Major version and actual engine version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string FullVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).FullVersion; }

        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string FullyQualifiedDomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).FullyQualifiedDomainName; }

        /// <summary>High availability mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityMode = value ?? null; }

        /// <summary>HA Replication mode for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityReplicationMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityReplicationMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityReplicationMode = value ?? null; }

        /// <summary>Availability zone of the standby server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityStandbyAvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityStandbyAvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityStandbyAvailabilityZone = value ?? null; }

        /// <summary>The state of server high availability.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityState; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Id; }

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

        /// <summary>Relative path of data directory in storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ImportSourcePropertyDataDirPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertyDataDirPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertyDataDirPath = value ?? null; }

        /// <summary>
        /// Sas token for accessing source storage. Read and list permissions are required for sas token.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public System.Security.SecureString ImportSourcePropertySasToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertySasToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertySasToken = value ?? null; }

        /// <summary>Storage type of import source.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ImportSourcePropertyStorageType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertyStorageType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertyStorageType = value ?? null; }

        /// <summary>Uri of the import source storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ImportSourcePropertyStorageUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertyStorageUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourcePropertyStorageUrl = value ?? null; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>
        /// The mysql parameter lower_case_table_names. Can only be specified when the server is being created. Allowed values 1 or
        /// 2.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? LowerCaseTableName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).LowerCaseTableName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).LowerCaseTableName = value ?? default(int); }

        /// <summary>The patch strategy of this server</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenancePolicyPatchStrategy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenancePolicyPatchStrategy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenancePolicyPatchStrategy = value ?? null; }

        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowBatchOfMaintenance { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowBatchOfMaintenance; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowBatchOfMaintenance = value ?? null; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowCustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowCustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowDayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowDayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowStartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowStartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowStartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindowStartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IBackup Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.Backup { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Backup; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Backup = value ?? null /* model class */; }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupEarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).BackupEarliestRestoreDate = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for DataEncryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDataEncryption Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.DataEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).DataEncryption = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FullVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.FullVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).FullVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).FullVersion = value ?? null; }

        /// <summary>Internal Acessors for FullyQualifiedDomainName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.FullyQualifiedDomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).FullyQualifiedDomainName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).FullyQualifiedDomainName = value ?? null; }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.HighAvailability { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailability; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailability = value ?? null /* model class */; }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).HighAvailabilityState = value ?? null; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentity Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlServerIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for ImportSourceProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportSourceProperties Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.ImportSourceProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourceProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ImportSourceProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MaintenancePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePolicy Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.MaintenancePolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenancePolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenancePolicy = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.MaintenanceWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).MaintenanceWindow = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.INetwork Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.Network { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Network; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Network = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).PrivateEndpointConnection = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerProperties Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ServerProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReplicaCapacity</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.ReplicaCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ReplicaCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ReplicaCapacity = value ?? default(int); }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSku Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MySqlServerSku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).State = value ?? null; }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.Storage { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Storage; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Storage = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StorageSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerInternal.StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageSku = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Delegated subnet resource id used to setup vnet for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkDelegatedSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).NetworkDelegatedSubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).NetworkDelegatedSubnetResourceId = value ?? null; }

        /// <summary>Private DNS zone resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkPrivateDnsZoneResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).NetworkPrivateDnsZoneResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).NetworkPrivateDnsZoneResourceId = value ?? null; }

        /// <summary>
        /// Whether or not public network access is allowed for this server. Value is 'Disabled' when server has VNet integration.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string NetworkPublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).NetworkPublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).NetworkPublicNetworkAccess = value ?? null; }

        /// <summary>PrivateEndpointConnections related properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerProperties _property;

        /// <summary>Properties of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ServerProperties()); set => this._property = value; }

        /// <summary>The maximum number of replicas that a primary server can have.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? ReplicaCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ReplicaCapacity; }

        /// <summary>The replication role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ReplicationRole { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ReplicationRole; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).ReplicationRole = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? RestorePointInTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).RestorePointInTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).RestorePointInTime = value ?? default(global::System.DateTime); }

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

        /// <summary>The source MySQL server id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string SourceServerResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).SourceServerResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).SourceServerResourceId = value ?? null; }

        /// <summary>The state of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).State; }

        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageAutoGrow { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageAutoGrow; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageAutoGrow = value ?? null; }

        /// <summary>Enable IO Auto Scaling or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageAutoIoScaling { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageAutoIoScaling; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageAutoIoScaling = value ?? null; }

        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageIop { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageIop; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageIop = value ?? default(int); }

        /// <summary>Enable Log On Disk or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageLogOnDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageLogOnDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageLogOnDisk = value ?? null; }

        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageRedundancy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageRedundancy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageRedundancy = value ?? null; }

        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public int? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageSizeGb = value ?? default(int); }

        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string StorageSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).StorageSku; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>
        /// Major version of MySQL. 8.0.21 stands for MySQL 8.0, 5.7.44 stands for MySQL 5.7
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>Creates an new <see cref="Server" /> instance.</summary>
        public Server()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Represents a server.
    public partial interface IServer :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResource
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
    /// Represents a server.
    internal partial interface IServerInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ITrackedResourceInternal
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
        /// <summary>Properties of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerProperties Property { get; set; }
        /// <summary>The maximum number of replicas that a primary server can have.</summary>
        int? ReplicaCapacity { get; set; }
        /// <summary>The replication role.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("None", "Source", "Replica")]
        string ReplicationRole { get; set; }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from.
        /// </summary>
        global::System.DateTime? RestorePointInTime { get; set; }
        /// <summary>The SKU (pricing tier) of the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMySqlServerSku Sku { get; set; }
        /// <summary>The name of the sku, e.g. Standard_D32s_v3.</summary>
        string SkuName { get; set; }
        /// <summary>The tier of the particular SKU, e.g. GeneralPurpose.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Burstable", "GeneralPurpose", "MemoryOptimized")]
        string SkuTier { get; set; }
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