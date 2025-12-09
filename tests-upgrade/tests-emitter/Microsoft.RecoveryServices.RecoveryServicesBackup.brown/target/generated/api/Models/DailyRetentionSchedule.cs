// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Daily retention schedule.</summary>
    public partial class DailyRetentionSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal
    {

        /// <summary>Internal Acessors for RetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal.RetentionDuration { get => (this._retentionDuration = this._retentionDuration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDuration()); set { {_retentionDuration = value;} } }

        /// <summary>Backing field for <see cref="RetentionDuration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration _retentionDuration;

        /// <summary>Retention duration of retention Policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration RetentionDuration { get => (this._retentionDuration = this._retentionDuration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDuration()); set => this._retentionDuration = value; }

        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? RetentionDurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).Count; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).Count = value ?? default(int); }

        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RetentionDurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).DurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDurationInternal)RetentionDuration).DurationType = value ?? null; }

        /// <summary>Backing field for <see cref="RetentionTime" /> property.</summary>
        private System.Collections.Generic.List<global::System.DateTime> _retentionTime;

        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<global::System.DateTime> RetentionTime { get => this._retentionTime; set => this._retentionTime = value; }

        /// <summary>Creates an new <see cref="DailyRetentionSchedule" /> instance.</summary>
        public DailyRetentionSchedule()
        {

        }
    }
    /// Daily retention schedule.
    public partial interface IDailyRetentionSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? RetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention duration type of retention policy.",
        SerializedName = @"durationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string RetentionDurationType { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention times of retention policy.",
        SerializedName = @"retentionTimes",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        System.Collections.Generic.List<global::System.DateTime> RetentionTime { get; set; }

    }
    /// Daily retention schedule.
    internal partial interface IDailyRetentionScheduleInternal

    {
        /// <summary>Retention duration of retention Policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration RetentionDuration { get; set; }
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        int? RetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string RetentionDurationType { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        System.Collections.Generic.List<global::System.DateTime> RetentionTime { get; set; }

    }
}