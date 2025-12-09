// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// The base backup engine class. All workload specific backup engines derive from this class.
    /// </summary>
    public partial class BackupEngineBaseResource :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResource,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Resource();

        /// <summary>Backup agent version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string AzureBackupAgentVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).AzureBackupAgentVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).AzureBackupAgentVersion = value ?? null; }

        /// <summary>ID of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string BackupEngineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupEngineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupEngineId = value ?? null; }

        /// <summary>
        /// Status of the backup engine with the Recovery Services Vault. = {Active/Deleting/DeleteFailed}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string BackupEngineState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupEngineState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupEngineState = value ?? null; }

        /// <summary>Type of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string BackupEngineType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupEngineType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupEngineType = value ?? null; }

        /// <summary>Type of backup management for the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).BackupManagementType = value ?? null; }

        /// <summary>Flag indicating if the backup engine be registered, once already registered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? CanReRegister { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).CanReRegister; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).CanReRegister = value ?? default(bool); }

        /// <summary>Backup engine version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string DpmVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).DpmVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).DpmVersion = value ?? null; }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>Optional ETag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; set => this._eTag = value; }

        /// <summary>Disk space currently available in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public double? ExtendedInfoAvailableDiskSpace { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoAvailableDiskSpace; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoAvailableDiskSpace = value ?? default(double); }

        /// <summary>Protected instances in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? ExtendedInfoAzureProtectedInstance { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoAzureProtectedInstance; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoAzureProtectedInstance = value ?? default(int); }

        /// <summary>Database name of backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoDatabaseName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoDatabaseName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoDatabaseName = value ?? null; }

        /// <summary>Number of disks in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? ExtendedInfoDiskCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoDiskCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoDiskCount = value ?? default(int); }

        /// <summary>Number of protected items in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? ExtendedInfoProtectedItemsCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoProtectedItemsCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoProtectedItemsCount = value ?? default(int); }

        /// <summary>Number of protected servers in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? ExtendedInfoProtectedServersCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoProtectedServersCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoProtectedServersCount = value ?? default(int); }

        /// <summary>Last refresh time in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExtendedInfoRefreshedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoRefreshedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoRefreshedAt = value ?? default(global::System.DateTime); }

        /// <summary>Disk space used in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public double? ExtendedInfoUsedDiskSpace { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoUsedDiskSpace; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfoUsedDiskSpace = value ?? default(double); }

        /// <summary>Friendly name of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).FriendlyName = value ?? null; }

        /// <summary>Backup status of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).HealthStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).HealthStatus = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Id; }

        /// <summary>To check if backup agent upgrade available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? IsAzureBackupAgentUpgradeAvailable { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).IsAzureBackupAgentUpgradeAvailable; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).IsAzureBackupAgentUpgradeAvailable = value ?? default(bool); }

        /// <summary>To check if backup engine upgrade available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? IsDpmUpgradeAvailable { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).IsDpmUpgradeAvailable; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).IsDpmUpgradeAvailable = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal.ExtendedInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).ExtendedInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBase Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBase()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBase _property;

        /// <summary>BackupEngineBaseResource properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBase Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBase()); set => this._property = value; }

        /// <summary>Registration status of the backup engine with the Recovery Services Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RegistrationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).RegistrationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseInternal)Property).RegistrationStatus = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).SystemDataLastModifiedByType; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BackupEngineBaseResourceTags()); set => this._tag = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="BackupEngineBaseResource" /> instance.</summary>
        public BackupEngineBaseResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// The base backup engine class. All workload specific backup engines derive from this class.
    public partial interface IBackupEngineBaseResource :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResource
    {
        /// <summary>Backup agent version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup agent version",
        SerializedName = @"azureBackupAgentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string AzureBackupAgentVersion { get; set; }
        /// <summary>ID of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ID of the backup engine.",
        SerializedName = @"backupEngineId",
        PossibleTypes = new [] { typeof(string) })]
        string BackupEngineId { get; set; }
        /// <summary>
        /// Status of the backup engine with the Recovery Services Vault. = {Active/Deleting/DeleteFailed}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the backup engine with the Recovery Services Vault. = {Active/Deleting/DeleteFailed}",
        SerializedName = @"backupEngineState",
        PossibleTypes = new [] { typeof(string) })]
        string BackupEngineState { get; set; }
        /// <summary>Type of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the backup engine.",
        SerializedName = @"backupEngineType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "DpmBackupEngine", "AzureBackupServerEngine")]
        string BackupEngineType { get; set; }
        /// <summary>Type of backup management for the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup management for the backup engine.",
        SerializedName = @"backupManagementType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "AzureIaasVM", "MAB", "DPM", "AzureBackupServer", "AzureSql", "AzureStorage", "AzureWorkload", "DefaultBackup")]
        string BackupManagementType { get; set; }
        /// <summary>Flag indicating if the backup engine be registered, once already registered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag indicating if the backup engine be registered, once already registered.",
        SerializedName = @"canReRegister",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CanReRegister { get; set; }
        /// <summary>Backup engine version</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup engine version",
        SerializedName = @"dpmVersion",
        PossibleTypes = new [] { typeof(string) })]
        string DpmVersion { get; set; }
        /// <summary>Optional ETag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional ETag.",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get; set; }
        /// <summary>Disk space currently available in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Disk space currently available in the backup engine.",
        SerializedName = @"availableDiskSpace",
        PossibleTypes = new [] { typeof(double) })]
        double? ExtendedInfoAvailableDiskSpace { get; set; }
        /// <summary>Protected instances in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Protected instances in the backup engine.",
        SerializedName = @"azureProtectedInstances",
        PossibleTypes = new [] { typeof(int) })]
        int? ExtendedInfoAzureProtectedInstance { get; set; }
        /// <summary>Database name of backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Database name of backup engine.",
        SerializedName = @"databaseName",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoDatabaseName { get; set; }
        /// <summary>Number of disks in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of disks in the backup engine.",
        SerializedName = @"diskCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ExtendedInfoDiskCount { get; set; }
        /// <summary>Number of protected items in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of protected items in the backup engine.",
        SerializedName = @"protectedItemsCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ExtendedInfoProtectedItemsCount { get; set; }
        /// <summary>Number of protected servers in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of protected servers in the backup engine.",
        SerializedName = @"protectedServersCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ExtendedInfoProtectedServersCount { get; set; }
        /// <summary>Last refresh time in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last refresh time in the backup engine.",
        SerializedName = @"refreshedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExtendedInfoRefreshedAt { get; set; }
        /// <summary>Disk space used in the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Disk space used in the backup engine.",
        SerializedName = @"usedDiskSpace",
        PossibleTypes = new [] { typeof(double) })]
        double? ExtendedInfoUsedDiskSpace { get; set; }
        /// <summary>Friendly name of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Friendly name of the backup engine.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>Backup status of the backup engine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Backup status of the backup engine.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get; set; }
        /// <summary>To check if backup agent upgrade available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To check if backup agent upgrade available",
        SerializedName = @"isAzureBackupAgentUpgradeAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAzureBackupAgentUpgradeAvailable { get; set; }
        /// <summary>To check if backup engine upgrade available</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To check if backup engine upgrade available",
        SerializedName = @"isDpmUpgradeAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDpmUpgradeAvailable { get; set; }
        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Registration status of the backup engine with the Recovery Services Vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Registration status of the backup engine with the Recovery Services Vault.",
        SerializedName = @"registrationStatus",
        PossibleTypes = new [] { typeof(string) })]
        string RegistrationStatus { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags Tag { get; set; }

    }
    /// The base backup engine class. All workload specific backup engines derive from this class.
    internal partial interface IBackupEngineBaseResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceInternal
    {
        /// <summary>Backup agent version</summary>
        string AzureBackupAgentVersion { get; set; }
        /// <summary>ID of the backup engine.</summary>
        string BackupEngineId { get; set; }
        /// <summary>
        /// Status of the backup engine with the Recovery Services Vault. = {Active/Deleting/DeleteFailed}
        /// </summary>
        string BackupEngineState { get; set; }
        /// <summary>Type of the backup engine.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "DpmBackupEngine", "AzureBackupServerEngine")]
        string BackupEngineType { get; set; }
        /// <summary>Type of backup management for the backup engine.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "AzureIaasVM", "MAB", "DPM", "AzureBackupServer", "AzureSql", "AzureStorage", "AzureWorkload", "DefaultBackup")]
        string BackupManagementType { get; set; }
        /// <summary>Flag indicating if the backup engine be registered, once already registered.</summary>
        bool? CanReRegister { get; set; }
        /// <summary>Backup engine version</summary>
        string DpmVersion { get; set; }
        /// <summary>Optional ETag.</summary>
        string ETag { get; set; }
        /// <summary>Extended info of the backupengine</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineExtendedInfo ExtendedInfo { get; set; }
        /// <summary>Disk space currently available in the backup engine.</summary>
        double? ExtendedInfoAvailableDiskSpace { get; set; }
        /// <summary>Protected instances in the backup engine.</summary>
        int? ExtendedInfoAzureProtectedInstance { get; set; }
        /// <summary>Database name of backup engine.</summary>
        string ExtendedInfoDatabaseName { get; set; }
        /// <summary>Number of disks in the backup engine.</summary>
        int? ExtendedInfoDiskCount { get; set; }
        /// <summary>Number of protected items in the backup engine.</summary>
        int? ExtendedInfoProtectedItemsCount { get; set; }
        /// <summary>Number of protected servers in the backup engine.</summary>
        int? ExtendedInfoProtectedServersCount { get; set; }
        /// <summary>Last refresh time in the backup engine.</summary>
        global::System.DateTime? ExtendedInfoRefreshedAt { get; set; }
        /// <summary>Disk space used in the backup engine.</summary>
        double? ExtendedInfoUsedDiskSpace { get; set; }
        /// <summary>Friendly name of the backup engine.</summary>
        string FriendlyName { get; set; }
        /// <summary>Backup status of the backup engine.</summary>
        string HealthStatus { get; set; }
        /// <summary>To check if backup agent upgrade available</summary>
        bool? IsAzureBackupAgentUpgradeAvailable { get; set; }
        /// <summary>To check if backup engine upgrade available</summary>
        bool? IsDpmUpgradeAvailable { get; set; }
        /// <summary>The geo-location where the resource lives</summary>
        string Location { get; set; }
        /// <summary>BackupEngineBaseResource properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBase Property { get; set; }
        /// <summary>Registration status of the backup engine with the Recovery Services Vault.</summary>
        string RegistrationStatus { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBackupEngineBaseResourceTags Tag { get; set; }

    }
}