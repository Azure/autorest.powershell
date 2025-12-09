// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Long term retention policy.</summary>
    public partial class LongTermRetentionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy __retentionPolicy = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RetentionPolicy();

        /// <summary>Backing field for <see cref="DailySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule _dailySchedule;

        /// <summary>Daily retention schedule of the protection policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule DailySchedule { get => (this._dailySchedule = this._dailySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionSchedule()); set => this._dailySchedule = value; }

        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? DailyScheduleRetentionDurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionDurationCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionDurationCount = value ?? default(int); }

        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string DailyScheduleRetentionDurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionDurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionDurationType = value ?? null; }

        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> DailyScheduleRetentionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionTime = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DailySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.DailySchedule { get => (this._dailySchedule = this._dailySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailyRetentionSchedule()); set { {_dailySchedule = value;} } }

        /// <summary>Internal Acessors for DailyScheduleRetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.DailyScheduleRetentionDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionScheduleInternal)DailySchedule).RetentionDuration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonthlySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.MonthlySchedule { get => (this._monthlySchedule = this._monthlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionSchedule()); set { {_monthlySchedule = value;} } }

        /// <summary>Internal Acessors for MonthlyScheduleRetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.MonthlyScheduleRetentionDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionDuration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonthlyScheduleRetentionScheduleDaily</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.MonthlyScheduleRetentionScheduleDaily { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleDaily; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleDaily = value ?? null /* model class */; }

        /// <summary>Internal Acessors for MonthlyScheduleRetentionScheduleWeekly</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.MonthlyScheduleRetentionScheduleWeekly { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleWeekly; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleWeekly = value ?? null /* model class */; }

        /// <summary>Internal Acessors for WeeklySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionSchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.WeeklySchedule { get => (this._weeklySchedule = this._weeklySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionSchedule()); set { {_weeklySchedule = value;} } }

        /// <summary>Internal Acessors for WeeklyScheduleRetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.WeeklyScheduleRetentionDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionDuration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for YearlySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.YearlySchedule { get => (this._yearlySchedule = this._yearlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.YearlyRetentionSchedule()); set { {_yearlySchedule = value;} } }

        /// <summary>Internal Acessors for YearlyScheduleRetentionDuration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.YearlyScheduleRetentionDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionDuration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for YearlyScheduleRetentionScheduleDaily</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.YearlyScheduleRetentionScheduleDaily { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleDaily; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleDaily = value ?? null /* model class */; }

        /// <summary>Internal Acessors for YearlyScheduleRetentionScheduleWeekly</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ILongTermRetentionPolicyInternal.YearlyScheduleRetentionScheduleWeekly { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleWeekly; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleWeekly = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="MonthlySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule _monthlySchedule;

        /// <summary>Monthly retention schedule of the protection policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule MonthlySchedule { get => (this._monthlySchedule = this._monthlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MonthlyRetentionSchedule()); set => this._monthlySchedule = value; }

        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? MonthlyScheduleRetentionDurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionDurationCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionDurationCount = value ?? default(int); }

        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string MonthlyScheduleRetentionDurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionDurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionDurationType = value ?? null; }

        /// <summary>List of days of the month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleDailyDaysOfTheMonth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleDailyDaysOfTheMonth = value ?? null /* arrayOf */; }

        /// <summary>Retention schedule format type for monthly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string MonthlyScheduleRetentionScheduleFormatType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleFormatType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleFormatType = value ?? null; }

        /// <summary>List of days of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleWeeklyDaysOfTheWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleWeeklyDaysOfTheWeek = value ?? null /* arrayOf */; }

        /// <summary>List of weeks of month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleWeeklyWeeksOfTheMonth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionScheduleWeeklyWeeksOfTheMonth = value ?? null /* arrayOf */; }

        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> MonthlyScheduleRetentionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionScheduleInternal)MonthlySchedule).RetentionTime = value ?? null /* arrayOf */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "LongTermRetentionPolicy"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal)__retentionPolicy).Type = "LongTermRetentionPolicy"; }

        /// <summary>Backing field for <see cref="WeeklySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionSchedule _weeklySchedule;

        /// <summary>Weekly retention schedule of the protection policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionSchedule WeeklySchedule { get => (this._weeklySchedule = this._weeklySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklyRetentionSchedule()); set => this._weeklySchedule = value; }

        /// <summary>List of days of week for weekly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> WeeklyScheduleDaysOfTheWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).DaysOfTheWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).DaysOfTheWeek = value ?? null /* arrayOf */; }

        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? WeeklyScheduleRetentionDurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionDurationCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionDurationCount = value ?? default(int); }

        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string WeeklyScheduleRetentionDurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionDurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionDurationType = value ?? null; }

        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> WeeklyScheduleRetentionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionScheduleInternal)WeeklySchedule).RetentionTime = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="YearlySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule _yearlySchedule;

        /// <summary>Yearly retention schedule of the protection policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule YearlySchedule { get => (this._yearlySchedule = this._yearlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.YearlyRetentionSchedule()); set => this._yearlySchedule = value; }

        /// <summary>List of months of year of yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> YearlyScheduleMonthsOfYear { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).MonthsOfYear; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).MonthsOfYear = value ?? null /* arrayOf */; }

        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? YearlyScheduleRetentionDurationCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionDurationCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionDurationCount = value ?? default(int); }

        /// <summary>Retention duration type of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string YearlyScheduleRetentionDurationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionDurationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionDurationType = value ?? null; }

        /// <summary>List of days of the month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> YearlyScheduleRetentionScheduleDailyDaysOfTheMonth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleDailyDaysOfTheMonth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleDailyDaysOfTheMonth = value ?? null /* arrayOf */; }

        /// <summary>Retention schedule format for yearly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string YearlyScheduleRetentionScheduleFormatType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleFormatType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleFormatType = value ?? null; }

        /// <summary>List of days of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleWeeklyDaysOfTheWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleWeeklyDaysOfTheWeek = value ?? null /* arrayOf */; }

        /// <summary>List of weeks of month.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleWeeklyWeeksOfTheMonth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionScheduleWeeklyWeeksOfTheMonth = value ?? null /* arrayOf */; }

        /// <summary>Retention times of retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> YearlyScheduleRetentionTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionScheduleInternal)YearlySchedule).RetentionTime = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="LongTermRetentionPolicy" /> instance.</summary>
        public LongTermRetentionPolicy()
        {
            this.__retentionPolicy.Type = "LongTermRetentionPolicy";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__retentionPolicy), __retentionPolicy);
            await eventListener.AssertObjectIsValid(nameof(__retentionPolicy), __retentionPolicy);
        }
    }
    /// Long term retention policy.
    public partial interface ILongTermRetentionPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicy
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
        int? DailyScheduleRetentionDurationCount { get; set; }
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
        string DailyScheduleRetentionDurationType { get; set; }
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
        System.Collections.Generic.List<global::System.DateTime> DailyScheduleRetentionTime { get; set; }
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
        int? MonthlyScheduleRetentionDurationCount { get; set; }
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
        string MonthlyScheduleRetentionDurationType { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth { get; set; }
        /// <summary>Retention schedule format type for monthly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Retention schedule format type for monthly retention policy.",
        SerializedName = @"retentionScheduleFormatType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly")]
        string MonthlyScheduleRetentionScheduleFormatType { get; set; }
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
        System.Collections.Generic.List<string> MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek { get; set; }
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
        System.Collections.Generic.List<string> MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth { get; set; }
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
        System.Collections.Generic.List<global::System.DateTime> MonthlyScheduleRetentionTime { get; set; }
        /// <summary>List of days of week for weekly retention policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of days of week for weekly retention policy.",
        SerializedName = @"daysOfTheWeek",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> WeeklyScheduleDaysOfTheWeek { get; set; }
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
        int? WeeklyScheduleRetentionDurationCount { get; set; }
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
        string WeeklyScheduleRetentionDurationType { get; set; }
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
        System.Collections.Generic.List<global::System.DateTime> WeeklyScheduleRetentionTime { get; set; }
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
        System.Collections.Generic.List<string> YearlyScheduleMonthsOfYear { get; set; }
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
        int? YearlyScheduleRetentionDurationCount { get; set; }
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
        string YearlyScheduleRetentionDurationType { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> YearlyScheduleRetentionScheduleDailyDaysOfTheMonth { get; set; }
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
        string YearlyScheduleRetentionScheduleFormatType { get; set; }
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
        System.Collections.Generic.List<string> YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek { get; set; }
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
        System.Collections.Generic.List<string> YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth { get; set; }
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
        System.Collections.Generic.List<global::System.DateTime> YearlyScheduleRetentionTime { get; set; }

    }
    /// Long term retention policy.
    internal partial interface ILongTermRetentionPolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionPolicyInternal
    {
        /// <summary>Daily retention schedule of the protection policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionSchedule DailySchedule { get; set; }
        /// <summary>Retention duration of retention Policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration DailyScheduleRetentionDuration { get; set; }
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        int? DailyScheduleRetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string DailyScheduleRetentionDurationType { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        System.Collections.Generic.List<global::System.DateTime> DailyScheduleRetentionTime { get; set; }
        /// <summary>Monthly retention schedule of the protection policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMonthlyRetentionSchedule MonthlySchedule { get; set; }
        /// <summary>Retention duration of retention Policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration MonthlyScheduleRetentionDuration { get; set; }
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        int? MonthlyScheduleRetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string MonthlyScheduleRetentionDurationType { get; set; }
        /// <summary>Daily retention format for monthly retention policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat MonthlyScheduleRetentionScheduleDaily { get; set; }
        /// <summary>List of days of the month.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> MonthlyScheduleRetentionScheduleDailyDaysOfTheMonth { get; set; }
        /// <summary>Retention schedule format type for monthly retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly")]
        string MonthlyScheduleRetentionScheduleFormatType { get; set; }
        /// <summary>Weekly retention format for monthly retention policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat MonthlyScheduleRetentionScheduleWeekly { get; set; }
        /// <summary>List of days of the week.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> MonthlyScheduleRetentionScheduleWeeklyDaysOfTheWeek { get; set; }
        /// <summary>List of weeks of month.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("First", "Second", "Third", "Fourth", "Last", "Invalid")]
        System.Collections.Generic.List<string> MonthlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        System.Collections.Generic.List<global::System.DateTime> MonthlyScheduleRetentionTime { get; set; }
        /// <summary>Weekly retention schedule of the protection policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionSchedule WeeklySchedule { get; set; }
        /// <summary>List of days of week for weekly retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> WeeklyScheduleDaysOfTheWeek { get; set; }
        /// <summary>Retention duration of retention Policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration WeeklyScheduleRetentionDuration { get; set; }
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        int? WeeklyScheduleRetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string WeeklyScheduleRetentionDurationType { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        System.Collections.Generic.List<global::System.DateTime> WeeklyScheduleRetentionTime { get; set; }
        /// <summary>Yearly retention schedule of the protection policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IYearlyRetentionSchedule YearlySchedule { get; set; }
        /// <summary>List of months of year of yearly retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December")]
        System.Collections.Generic.List<string> YearlyScheduleMonthsOfYear { get; set; }
        /// <summary>Retention duration of retention Policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRetentionDuration YearlyScheduleRetentionDuration { get; set; }
        /// <summary>
        /// Count of duration types. Retention duration is obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks, retention duration will be three weeks.
        /// </summary>
        int? YearlyScheduleRetentionDurationCount { get; set; }
        /// <summary>Retention duration type of retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Days", "Weeks", "Months", "Years")]
        string YearlyScheduleRetentionDurationType { get; set; }
        /// <summary>Daily retention format for yearly retention policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyRetentionFormat YearlyScheduleRetentionScheduleDaily { get; set; }
        /// <summary>List of days of the month.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDay> YearlyScheduleRetentionScheduleDailyDaysOfTheMonth { get; set; }
        /// <summary>Retention schedule format for yearly retention policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly")]
        string YearlyScheduleRetentionScheduleFormatType { get; set; }
        /// <summary>Weekly retention format for yearly retention policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyRetentionFormat YearlyScheduleRetentionScheduleWeekly { get; set; }
        /// <summary>List of days of the week.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> YearlyScheduleRetentionScheduleWeeklyDaysOfTheWeek { get; set; }
        /// <summary>List of weeks of month.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("First", "Second", "Third", "Fourth", "Last", "Invalid")]
        System.Collections.Generic.List<string> YearlyScheduleRetentionScheduleWeeklyWeeksOfTheMonth { get; set; }
        /// <summary>Retention times of retention policy.</summary>
        System.Collections.Generic.List<global::System.DateTime> YearlyScheduleRetentionTime { get; set; }

    }
}