// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Yearly retention schedule.</summary>
    public partial class YearlyRetentionSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal
    {

        /// <summary>Internal Acessors for RetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal.RetentionDuration { get => (this._retentionDuration = this._retentionDuration ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionDuration()); set { {_retentionDuration = value;} } }

        /// <summary>Internal Acessors for RetentionScheduleDaily</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal.RetentionScheduleDaily { get => (this._retentionScheduleDaily = this._retentionScheduleDaily ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormat()); set { {_retentionScheduleDaily = value;} } }

        /// <summary>Internal Acessors for RetentionScheduleWeekly</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal.RetentionScheduleWeekly { get => (this._retentionScheduleWeekly = this._retentionScheduleWeekly ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormat()); set { {_retentionScheduleWeekly = value;} } }

        /// <summary>Backing field for <see cref="MonthsOfYear" /> property.</summary>
        private System.Collections.Generic.List<string> _monthsOfYear;

        /// <summary>List of months of year of yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MonthsOfYear { get => this._monthsOfYear; set => this._monthsOfYear = value; }

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

        /// <summary>Backing field for <see cref="RetentionScheduleDaily" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat _retentionScheduleDaily;

        /// <summary>Daily retention format for yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat RetentionScheduleDaily { get => (this._retentionScheduleDaily = this._retentionScheduleDaily ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionFormat()); set => this._retentionScheduleDaily = value; }

        /// <summary>List of days of the month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> RetentionScheduleDailyDaysOfTheMonth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormatInternal)RetentionScheduleDaily).DaysOfTheMonth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormatInternal)RetentionScheduleDaily).DaysOfTheMonth = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="RetentionScheduleFormatType" /> property.</summary>
        private string _retentionScheduleFormatType;

        /// <summary>Retention schedule format for yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string RetentionScheduleFormatType { get => this._retentionScheduleFormatType; set => this._retentionScheduleFormatType = value; }

        /// <summary>Backing field for <see cref="RetentionScheduleWeekly" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat _retentionScheduleWeekly;

        /// <summary>Weekly retention format for yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat RetentionScheduleWeekly { get => (this._retentionScheduleWeekly = this._retentionScheduleWeekly ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionFormat()); set => this._retentionScheduleWeekly = value; }

        /// <summary>List of days of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RetentionScheduleWeeklyDaysOfTheWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormatInternal)RetentionScheduleWeekly).DaysOfTheWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormatInternal)RetentionScheduleWeekly).DaysOfTheWeek = value ?? null /* arrayOf */; }

        /// <summary>List of weeks of month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RetentionScheduleWeeklyWeeksOfTheMonth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormatInternal)RetentionScheduleWeekly).WeeksOfTheMonth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormatInternal)RetentionScheduleWeekly).WeeksOfTheMonth = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="RetentionTime" /> property.</summary>
        private System.Collections.Generic.List<global::System.DateTime> _retentionTime;

        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<global::System.DateTime> RetentionTime { get => this._retentionTime; set => this._retentionTime = value; }

        /// <summary>Creates an new <see cref="YearlyRetentionSchedule" /> instance.</summary>
        public YearlyRetentionSchedule()
        {

        }
    }
    /// Yearly retention schedule.
    public partial interface IYearlyRetentionSchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>List of months of year of yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of months of year of yearly retention policy.",
        SerializedName = @"monthsOfYear",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December")]
        System.Collections.Generic.List<string> MonthsOfYear { get; set; }
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
        /// <summary>List of days of the month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of days of the month.",
        SerializedName = @"daysOfTheMonth",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> RetentionScheduleDailyDaysOfTheMonth { get; set; }
        /// <summary>Retention schedule format for yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention schedule format for yearly retention policy.",
        SerializedName = @"retentionScheduleFormatType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly")]
        string RetentionScheduleFormatType { get; set; }
        /// <summary>List of days of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of days of the week.",
        SerializedName = @"daysOfTheWeek",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> RetentionScheduleWeeklyDaysOfTheWeek { get; set; }
        /// <summary>List of weeks of month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of weeks of month.",
        SerializedName = @"weeksOfTheMonth",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("First", "Second", "Third", "Fourth", "Last", "Invalid")]
        System.Collections.Generic.List<string> RetentionScheduleWeeklyWeeksOfTheMonth { get; set; }
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
    /// Yearly retention schedule.
    internal partial interface IYearlyRetentionScheduleInternal

    {
        /// <summary>List of months of year of yearly retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December")]
        System.Collections.Generic.List<string> MonthsOfYear { get; set; }
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
        /// <summary>Daily retention format for yearly retention policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat RetentionScheduleDaily { get; set; }
        /// <summary>List of days of the month.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> RetentionScheduleDailyDaysOfTheMonth { get; set; }
        /// <summary>Retention schedule format for yearly retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly")]
        string RetentionScheduleFormatType { get; set; }
        /// <summary>Weekly retention format for yearly retention policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat RetentionScheduleWeekly { get; set; }
        /// <summary>List of days of the week.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> RetentionScheduleWeeklyDaysOfTheWeek { get; set; }
        /// <summary>List of weeks of month.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("First", "Second", "Third", "Fourth", "Last", "Invalid")]
        System.Collections.Generic.List<string> RetentionScheduleWeeklyWeeksOfTheMonth { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        System.Collections.Generic.List<global::System.DateTime> RetentionTime { get; set; }

    }
}