// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// IaaS VM workload-specific restore with integrated rehydration of recovery point.
    /// </summary>
    public partial class IaasVMRestoreWithRehydrationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequest __iaasVMRestoreRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRestoreRequest();

        /// <summary>
        /// Affinity group associated to VM to be restored. Used only for Classic Compute Virtual Machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string AffinityGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).AffinityGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).AffinityGroup = value ?? null; }

        /// <summary>
        /// Should a new cloud service be created while restoring the VM. If this is false, VM will be restored to the same
        /// cloud service as it was at the time of backup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? CreateNewCloudService { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).CreateNewCloudService; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).CreateNewCloudService = value ?? default(bool); }

        /// <summary>
        /// DiskEncryptionSet's ID - needed if the VM needs to be encrypted at rest during restore with customer managed key.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string DiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).DiskEncryptionSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).DiskEncryptionSetId = value ?? null; }

        /// <summary>Details needed if the VM was encrypted at the time of backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IEncryptionDetails EncryptionDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetail = value ?? null /* model class */; }

        /// <summary>
        /// Identifies whether this backup copy represents an encrypted VM at the time of backup.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? EncryptionDetailEncryptionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailEncryptionEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailEncryptionEnabled = value ?? default(bool); }

        /// <summary>Key Url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EncryptionDetailKekUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailKekUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailKekUrl = value ?? null; }

        /// <summary>ID of Key Vault where KEK is stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EncryptionDetailKekVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailKekVaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailKekVaultId = value ?? null; }

        /// <summary>Secret Url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EncryptionDetailSecretKeyUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailSecretKeyUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailSecretKeyUrl = value ?? null; }

        /// <summary>ID of Key Vault where Secret is stored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EncryptionDetailSecretKeyVaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailSecretKeyVaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetailSecretKeyVaultId = value ?? null; }

        /// <summary>
        /// Target extended location where the VM should be restored,
        /// should be null if restore is to be done in public cloud
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedLocation ExtendedLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocation = value ?? null /* model class */; }

        /// <summary>Name of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocationName = value ?? null; }

        /// <summary>Type of the extended location. Possible values include: 'EdgeZone'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocationType = value ?? null; }

        /// <summary>IaaS VM workload specific restore details for restores using managed identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityBasedRestoreDetails IdentityBasedRestoreDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetail = value ?? null /* model class */; }

        /// <summary>Gets the class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string IdentityBasedRestoreDetailObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetailObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetailObjectType = value ?? null; }

        /// <summary>Fully qualified ARM ID of the target storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string IdentityBasedRestoreDetailTargetStorageAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetailTargetStorageAccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetailTargetStorageAccountId = value ?? null; }

        /// <summary>Managed Identity information required to access customer storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityInfo IdentityInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfo = value ?? null /* model class */; }

        /// <summary>To differentiate if the managed identity is system assigned or user assigned</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? IdentityInfoIsSystemAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfoIsSystemAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfoIsSystemAssignedIdentity = value ?? default(bool); }

        /// <summary>
        /// Managed Identity Resource Id
        /// Optional: Might not be required in the case of system assigned managed identity
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string IdentityInfoManagedIdentityResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfoManagedIdentityResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfoManagedIdentityResourceId = value ?? null; }

        /// <summary>Internal Acessors for EncryptionDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IEncryptionDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal.EncryptionDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).EncryptionDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal.ExtendedLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).ExtendedLocation = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IdentityBasedRestoreDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityBasedRestoreDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal.IdentityBasedRestoreDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityBasedRestoreDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IdentityInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal.IdentityInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).IdentityInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecuredVMDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISecuredVMDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal.SecuredVMDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SecuredVMDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SecuredVMDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TargetDiskNetworkAccessSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetDiskNetworkAccessSettings Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal.TargetDiskNetworkAccessSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for RecoveryPointRehydrationInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal.RecoveryPointRehydrationInfo { get => (this._recoveryPointRehydrationInfo = this._recoveryPointRehydrationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointRehydrationInfo()); set { {_recoveryPointRehydrationInfo = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "IaasVMRestoreWithRehydrationRequest"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__iaasVMRestoreRequest).ObjectType = "IaasVMRestoreWithRehydrationRequest"; }

        /// <summary>Original Storage Account Option</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? OriginalStorageAccountOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).OriginalStorageAccountOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).OriginalStorageAccountOption = value ?? default(bool); }

        /// <summary>ID of the backup copy to be recovered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RecoveryPointId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RecoveryPointId = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointRehydrationInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo _recoveryPointRehydrationInfo;

        /// <summary>RP Rehydration Info</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo RecoveryPointRehydrationInfo { get => (this._recoveryPointRehydrationInfo = this._recoveryPointRehydrationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointRehydrationInfo()); set => this._recoveryPointRehydrationInfo = value; }

        /// <summary>Rehydration Priority</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RecoveryPointRehydrationInfoRehydrationPriority { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationPriority; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationPriority = value ?? null; }

        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RecoveryPointRehydrationInfoRehydrationRetentionDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationRetentionDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfoInternal)RecoveryPointRehydrationInfo).RehydrationRetentionDuration = value ?? null; }

        /// <summary>Type of this recovery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RecoveryType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RecoveryType = value ?? null; }

        /// <summary>Region in which the virtual machine is restored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Region { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).Region; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).Region = value ?? null; }

        /// <summary>ResourceGuardOperationRequests on which LAC check will be performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__iaasVMRestoreRequest).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)__iaasVMRestoreRequest).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

        /// <summary>List of Disk LUNs for partial restore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<int> RestoreDiskLunList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RestoreDiskLunList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RestoreDiskLunList = value ?? null /* arrayOf */; }

        /// <summary>Flag to denote of an Unmanaged disk VM should be restored with Managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? RestoreWithManagedDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RestoreWithManagedDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).RestoreWithManagedDisk = value ?? default(bool); }

        /// <summary>Stores Secured VM Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISecuredVMDetails SecuredVMDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SecuredVMDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SecuredVMDetail = value ?? null /* model class */; }

        /// <summary>Gets or Sets Disk Encryption Set Id for Secured VM OS Disk</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SecuredVMDetailSecuredVmosdiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SecuredVMDetailSecuredVmosdiskEncryptionSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SecuredVMDetailSecuredVmosdiskEncryptionSetId = value ?? null; }

        /// <summary>Fully qualified ARM ID of the VM which is being recovered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SourceResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SourceResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SourceResourceId = value ?? null; }

        /// <summary>
        /// Fully qualified ARM ID of the storage account to which the VM has to be restored.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string StorageAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).StorageAccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).StorageAccountId = value ?? null; }

        /// <summary>
        /// Subnet ID, is the subnet ID associated with the to be restored VM. For Classic VMs it would be
        /// {VnetID}/Subnet/{SubnetName} and, for the Azure Resource Manager VMs it would be ARM resource ID used to represent
        /// the subnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).SubnetId = value ?? null; }

        /// <summary>Specifies target network access settings for disks of VM to be restored,</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetDiskNetworkAccessSettings TargetDiskNetworkAccessSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSetting = value ?? null /* model class */; }

        /// <summary>
        /// Gets or sets the ARM resource ID of the target disk access to be used when TargetDiskNetworkAccessOption is set to TargetDiskNetworkAccessOption.UseNew
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetDiskNetworkAccessSettingTargetDiskAccessId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSettingTargetDiskAccessId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSettingTargetDiskAccessId = value ?? null; }

        /// <summary>Network access settings to be used for restored disks</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption = value ?? null; }

        /// <summary>
        /// Fully qualified ARM ID of the domain name to be associated to the VM being restored. This applies only to Classic
        /// Virtual Machines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetDomainNameId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDomainNameId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetDomainNameId = value ?? null; }

        /// <summary>
        /// This is the ARM Id of the resource group that you want to create for this Virtual machine and other artifacts.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetResourceGroupId = value ?? null; }

        /// <summary>
        /// This is the complete ARM Id of the VM that will be created.
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string TargetVirtualMachineId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetVirtualMachineId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).TargetVirtualMachineId = value ?? null; }

        /// <summary>
        /// This is the virtual network Id of the vnet that will be attached to the virtual machine.
        /// User will be validated for join action permissions in the linked access.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string VirtualNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).VirtualNetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).VirtualNetworkId = value ?? null; }

        /// <summary>Target zone where the VM and its disks should be restored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)__iaasVMRestoreRequest).Zone = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="IaasVMRestoreWithRehydrationRequest" /> instance.</summary>
        public IaasVMRestoreWithRehydrationRequest()
        {
            this.__iaasVMRestoreRequest.ObjectType = "IaasVMRestoreWithRehydrationRequest";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__iaasVMRestoreRequest), __iaasVMRestoreRequest);
            await eventListener.AssertObjectIsValid(nameof(__iaasVMRestoreRequest), __iaasVMRestoreRequest);
        }
    }
    /// IaaS VM workload-specific restore with integrated rehydration of recovery point.
    public partial interface IIaasVMRestoreWithRehydrationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequest
    {
        /// <summary>Rehydration Priority</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rehydration Priority",
        SerializedName = @"rehydrationPriority",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Standard", "High")]
        string RecoveryPointRehydrationInfoRehydrationPriority { get; set; }
        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"How long the rehydrated RP should be kept
        Should be ISO8601 Duration format e.g. ""P7D""",
        SerializedName = @"rehydrationRetentionDuration",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointRehydrationInfoRehydrationRetentionDuration { get; set; }

    }
    /// IaaS VM workload-specific restore with integrated rehydration of recovery point.
    internal partial interface IIaasVMRestoreWithRehydrationRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal
    {
        /// <summary>RP Rehydration Info</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo RecoveryPointRehydrationInfo { get; set; }
        /// <summary>Rehydration Priority</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Standard", "High")]
        string RecoveryPointRehydrationInfoRehydrationPriority { get; set; }
        /// <summary>
        /// How long the rehydrated RP should be kept
        /// Should be ISO8601 Duration format e.g. "P7D"
        /// </summary>
        string RecoveryPointRehydrationInfoRehydrationRetentionDuration { get; set; }

    }
}