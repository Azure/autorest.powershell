// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>IaaS VM workload-specific backup policy.</summary>
    public partial class AzureIaaSvmProtectionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicy __protectionPolicy = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ProtectionPolicy();

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => "AzureIaasVM"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).BackupManagementType = "AzureIaasVM"; }

        /// <summary>Backing field for <see cref="InstantRpDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetails _instantRpDetail;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetails InstantRpDetail { get => (this._instantRpDetail = this._instantRpDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InstantRpAdditionalDetails()); set => this._instantRpDetail = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string InstantRpDetailAzureBackupRgNamePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetailsInternal)InstantRpDetail).AzureBackupRgNamePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetailsInternal)InstantRpDetail).AzureBackupRgNamePrefix = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string InstantRpDetailAzureBackupRgNameSuffix { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetailsInternal)InstantRpDetail).AzureBackupRgNameSuffix; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetailsInternal)InstantRpDetail).AzureBackupRgNameSuffix = value ?? null; }

        /// <summary>Backing field for <see cref="InstantRpRetentionRangeInDay" /> property.</summary>
        private int? _instantRpRetentionRangeInDay;

        /// <summary>Instant RP retention policy range in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? InstantRpRetentionRangeInDay { get => this._instantRpRetentionRangeInDay; set => this._instantRpRetentionRangeInDay = value; }

        /// <summary>Internal Acessors for InstantRpDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyInternal.InstantRpDetail { get => (this._instantRpDetail = this._instantRpDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InstantRpAdditionalDetails()); set { {_instantRpDetail = value;} } }

        /// <summary>Internal Acessors for RetentionPolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyInternal.RetentionPolicy { get => (this._retentionPolicy = this._retentionPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicy()); set { {_retentionPolicy = value;} } }

        /// <summary>Internal Acessors for SchedulePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyInternal.SchedulePolicy { get => (this._schedulePolicy = this._schedulePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicy()); set { {_schedulePolicy = value;} } }

        /// <summary>Backing field for <see cref="PolicyType" /> property.</summary>
        private string _policyType;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string PolicyType { get => this._policyType; set => this._policyType = value; }

        /// <summary>Number of items associated with this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public int? ProtectedItemsCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ProtectedItemsCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ProtectedItemsCount = value ?? default(int); }

        /// <summary>ResourceGuard Operation Requests</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ResourceGuardOperationRequest { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ResourceGuardOperationRequest; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal)__protectionPolicy).ResourceGuardOperationRequest = value ?? null /* arrayOf */; }

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

        /// <summary>Backing field for <see cref="SnapshotConsistencyType" /> property.</summary>
        private string _snapshotConsistencyType;

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string SnapshotConsistencyType { get => this._snapshotConsistencyType; set => this._snapshotConsistencyType = value; }

        /// <summary>Backing field for <see cref="TieringPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyTieringPolicy _tieringPolicy;

        /// <summary>
        /// Tiering policy to automatically move RPs to another tier
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyTieringPolicy TieringPolicy { get => (this._tieringPolicy = this._tieringPolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmProtectionPolicyTieringPolicy()); set => this._tieringPolicy = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>
        /// TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Creates an new <see cref="AzureIaaSvmProtectionPolicy" /> instance.</summary>
        public AzureIaaSvmProtectionPolicy()
        {
            this.__protectionPolicy.BackupManagementType = "AzureIaasVM";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectionPolicy), __protectionPolicy);
            await eventListener.AssertObjectIsValid(nameof(__protectionPolicy), __protectionPolicy);
        }
    }
    /// IaaS VM workload-specific backup policy.
    public partial interface IAzureIaaSvmProtectionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicy
    {
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"azureBackupRGNamePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string InstantRpDetailAzureBackupRgNamePrefix { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"azureBackupRGNameSuffix",
        PossibleTypes = new [] { typeof(string) })]
        string InstantRpDetailAzureBackupRgNameSuffix { get; set; }
        /// <summary>Instant RP retention policy range in days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Instant RP retention policy range in days",
        SerializedName = @"instantRpRetentionRangeInDays",
        PossibleTypes = new [] { typeof(int) })]
        int? InstantRpRetentionRangeInDay { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"policyType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "V1", "V2")]
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
        SerializedName = @"snapshotConsistencyType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("OnlyCrashConsistent")]
        string SnapshotConsistencyType { get; set; }
        /// <summary>
        /// Tiering policy to automatically move RPs to another tier
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tiering policy to automatically move RPs to another tier
        Key is Target Tier, defined in RecoveryPointTierType enum.
        Tiering policy specifies the criteria to move RP to the target tier.",
        SerializedName = @"tieringPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyTieringPolicy) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyTieringPolicy TieringPolicy { get; set; }
        /// <summary>
        /// TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"TimeZone optional input as string. For example: TimeZone = ""Pacific Standard Time"".",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }

    }
    /// IaaS VM workload-specific backup policy.
    internal partial interface IAzureIaaSvmProtectionPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionPolicyInternal
    {
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInstantRpAdditionalDetails InstantRpDetail { get; set; }

        string InstantRpDetailAzureBackupRgNamePrefix { get; set; }

        string InstantRpDetailAzureBackupRgNameSuffix { get; set; }
        /// <summary>Instant RP retention policy range in days</summary>
        int? InstantRpRetentionRangeInDay { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "V1", "V2")]
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

        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("OnlyCrashConsistent")]
        string SnapshotConsistencyType { get; set; }
        /// <summary>
        /// Tiering policy to automatically move RPs to another tier
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmProtectionPolicyTieringPolicy TieringPolicy { get; set; }
        /// <summary>
        /// TimeZone optional input as string. For example: TimeZone = "Pacific Standard Time".
        /// </summary>
        string TimeZone { get; set; }

    }
}