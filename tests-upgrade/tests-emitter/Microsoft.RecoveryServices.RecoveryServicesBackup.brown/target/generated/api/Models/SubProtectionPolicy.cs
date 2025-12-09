// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Sub-protection policy which includes schedule and retention</summary>
    public partial class SubProtectionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal
    {

        /// <summary>Internal Acessors for RetentionPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal.RetentionPolicy { get => (this._retentionPolicy = this._retentionPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicy()); set { {_retentionPolicy = value;} } }

        /// <summary>Internal Acessors for SchedulePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal.SchedulePolicy { get => (this._schedulePolicy = this._schedulePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicy()); set { {_schedulePolicy = value;} } }

        /// <summary>Internal Acessors for SnapshotBackupAdditionalDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal.SnapshotBackupAdditionalDetail { get => (this._snapshotBackupAdditionalDetail = this._snapshotBackupAdditionalDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotBackupAdditionalDetails()); set { {_snapshotBackupAdditionalDetail = value;} } }

        /// <summary>
        /// Internal Acessors for SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal.SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetail = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for UserAssignedManagedIdentityDetailUserAssignedIdentityProperty
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyInternal.UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="PolicyType" /> property.</summary>
        private string _policyType;

        /// <summary>Type of backup policy type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string PolicyType { get => this._policyType; set => this._policyType = value; }

        /// <summary>Backing field for <see cref="RetentionPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy _retentionPolicy;

        /// <summary>Retention policy with the details on backup copy retention ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy RetentionPolicy { get => (this._retentionPolicy = this._retentionPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicy()); set => this._retentionPolicy = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RetentionPolicyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)RetentionPolicy).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)RetentionPolicy).Type = value ?? null; }

        /// <summary>Backing field for <see cref="SchedulePolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy _schedulePolicy;

        /// <summary>Backup schedule specified as part of backup policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy SchedulePolicy { get => (this._schedulePolicy = this._schedulePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicy()); set => this._schedulePolicy = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string SchedulePolicyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)SchedulePolicy).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)SchedulePolicy).Type = value ?? null; }

        /// <summary>Backing field for <see cref="SnapshotBackupAdditionalDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails _snapshotBackupAdditionalDetail;

        /// <summary>Snapshot Backup related fields for WorkloadType SaPHanaSystem</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails SnapshotBackupAdditionalDetail { get => (this._snapshotBackupAdditionalDetail = this._snapshotBackupAdditionalDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotBackupAdditionalDetails()); set => this._snapshotBackupAdditionalDetail = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string SnapshotBackupAdditionalDetailInstantRpDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).InstantRpDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).InstantRpDetail = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).InstantRpRetentionRangeInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).InstantRpRetentionRangeInDay = value ?? default(int); }

        /// <summary>Backing field for <see cref="TieringPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy _tieringPolicy;

        /// <summary>
        /// Tiering policy to automatically move RPs to another tier.
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy TieringPolicy { get => (this._tieringPolicy = this._tieringPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SubProtectionPolicyTieringPolicy()); set => this._tieringPolicy = value; }

        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyClientId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedIdentityPropertyClientId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedIdentityPropertyClientId = value ?? null; }

        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedIdentityPropertyPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedIdentityPropertyPrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedIdentityPropertyPrincipalId = value ?? null; }

        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentityDetailIdentityArmId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetailIdentityArmId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetailIdentityArmId = value ?? null; }

        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string UserAssignedManagedIdentityDetailIdentityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetailIdentityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetailsInternal)SnapshotBackupAdditionalDetail).UserAssignedManagedIdentityDetailIdentityName = value ?? null; }

        /// <summary>Creates an new <see cref="SubProtectionPolicy" /> instance.</summary>
        public SubProtectionPolicy()
        {

        }
    }
    /// Sub-protection policy which includes schedule and retention
    public partial interface ISubProtectionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Type of backup policy type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup policy type",
        SerializedName = @"policyType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Full", "Differential", "Log", "CopyOnlyFull", "Incremental", "SnapshotFull", "SnapshotCopyOnlyFull")]
        string PolicyType { get; set; }
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.",
        SerializedName = @"retentionPolicyType",
        PossibleTypes = new [] { typeof(string) })]
        string RetentionPolicyType { get; set; }
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.",
        SerializedName = @"schedulePolicyType",
        PossibleTypes = new [] { typeof(string) })]
        string SchedulePolicyType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"instantRPDetails",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotBackupAdditionalDetailInstantRpDetail { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"instantRpRetentionRangeInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay { get; set; }
        /// <summary>
        /// Tiering policy to automatically move RPs to another tier.
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tiering policy to automatically move RPs to another tier.
        Key is Target Tier, defined in RecoveryPointTierType enum.
        Tiering policy specifies the criteria to move RP to the target tier.",
        SerializedName = @"tieringPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy TieringPolicy { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The client ID of the assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The principal ID of the assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentityPropertyPrincipalId { get; set; }
        /// <summary>The ARM id of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM id of the assigned identity.",
        SerializedName = @"identityArmId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentityDetailIdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the assigned identity.",
        SerializedName = @"identityName",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedManagedIdentityDetailIdentityName { get; set; }

    }
    /// Sub-protection policy which includes schedule and retention
    internal partial interface ISubProtectionPolicyInternal

    {
        /// <summary>Type of backup policy type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Full", "Differential", "Log", "CopyOnlyFull", "Incremental", "SnapshotFull", "SnapshotCopyOnlyFull")]
        string PolicyType { get; set; }
        /// <summary>Retention policy with the details on backup copy retention ranges.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy RetentionPolicy { get; set; }
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        string RetentionPolicyType { get; set; }
        /// <summary>Backup schedule specified as part of backup policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy SchedulePolicy { get; set; }
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        string SchedulePolicyType { get; set; }
        /// <summary>Snapshot Backup related fields for WorkloadType SaPHanaSystem</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotBackupAdditionalDetails SnapshotBackupAdditionalDetail { get; set; }

        string SnapshotBackupAdditionalDetailInstantRpDetail { get; set; }

        int? SnapshotBackupAdditionalDetailInstantRpRetentionRangeInDay { get; set; }
        /// <summary>User assigned managed identity details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails SnapshotBackupAdditionalDetailUserAssignedManagedIdentityDetail { get; set; }
        /// <summary>
        /// Tiering policy to automatically move RPs to another tier.
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy TieringPolicy { get; set; }
        /// <summary>The client ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyClientId { get; set; }
        /// <summary>The principal ID of the assigned identity.</summary>
        string UserAssignedIdentityPropertyPrincipalId { get; set; }
        /// <summary>The ARM id of the assigned identity.</summary>
        string UserAssignedManagedIdentityDetailIdentityArmId { get; set; }
        /// <summary>The name of the assigned identity.</summary>
        string UserAssignedManagedIdentityDetailIdentityName { get; set; }
        /// <summary>User assigned managed identity properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties UserAssignedManagedIdentityDetailUserAssignedIdentityProperty { get; set; }

    }
}