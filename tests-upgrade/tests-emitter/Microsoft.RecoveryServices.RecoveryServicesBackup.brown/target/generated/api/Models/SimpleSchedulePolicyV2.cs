// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>The V2 policy schedule for IaaS that supports hourly backups.</summary>
    public partial class SimpleSchedulePolicyV2 :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy __schedulePolicy = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicy();

        /// <summary>Backing field for <see cref="DailySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule _dailySchedule;

        /// <summary>Daily schedule of this policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule DailySchedule { get => (this._dailySchedule = this._dailySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailySchedule()); set => this._dailySchedule = value; }

        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> DailyScheduleRunTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyScheduleInternal)DailySchedule).ScheduleRunTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyScheduleInternal)DailySchedule).ScheduleRunTime = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="HourlySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule _hourlySchedule;

        /// <summary>hourly schedule of this policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule HourlySchedule { get => (this._hourlySchedule = this._hourlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlySchedule()); set => this._hourlySchedule = value; }

        /// <summary>
        /// Interval at which backup needs to be triggered. For hourly the value
        /// can be 4/6/8/12
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? HourlyScheduleInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlyScheduleInternal)HourlySchedule).Interval; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlyScheduleInternal)HourlySchedule).Interval = value ?? default(int); }

        /// <summary>To specify duration of the backup window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public int? HourlyScheduleWindowDuration { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlyScheduleInternal)HourlySchedule).ScheduleWindowDuration; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlyScheduleInternal)HourlySchedule).ScheduleWindowDuration = value ?? default(int); }

        /// <summary>To specify start time of the backup window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? HourlyScheduleWindowStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlyScheduleInternal)HourlySchedule).ScheduleWindowStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlyScheduleInternal)HourlySchedule).ScheduleWindowStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for DailySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal.DailySchedule { get => (this._dailySchedule = this._dailySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DailySchedule()); set { {_dailySchedule = value;} } }

        /// <summary>Internal Acessors for HourlySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal.HourlySchedule { get => (this._hourlySchedule = this._hourlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlySchedule()); set { {_hourlySchedule = value;} } }

        /// <summary>Internal Acessors for WeeklySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyV2Internal.WeeklySchedule { get => (this._weeklySchedule = this._weeklySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklySchedule()); set { {_weeklySchedule = value;} } }

        /// <summary>Backing field for <see cref="ScheduleRunFrequency" /> property.</summary>
        private string _scheduleRunFrequency;

        /// <summary>Frequency of the schedule operation of this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ScheduleRunFrequency { get => this._scheduleRunFrequency; set => this._scheduleRunFrequency = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "SimpleSchedulePolicyV2"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)__schedulePolicy).Type = "SimpleSchedulePolicyV2"; }

        /// <summary>Backing field for <see cref="WeeklySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule _weeklySchedule;

        /// <summary>Weekly schedule of this policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule WeeklySchedule { get => (this._weeklySchedule = this._weeklySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.WeeklySchedule()); set => this._weeklySchedule = value; }

        /// <summary>Array of DayOfWeek</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> WeeklyScheduleRunDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyScheduleInternal)WeeklySchedule).ScheduleRunDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyScheduleInternal)WeeklySchedule).ScheduleRunDay = value ?? null /* arrayOf */; }

        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> WeeklyScheduleRunTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyScheduleInternal)WeeklySchedule).ScheduleRunTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyScheduleInternal)WeeklySchedule).ScheduleRunTime = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="SimpleSchedulePolicyV2" /> instance.</summary>
        public SimpleSchedulePolicyV2()
        {
            this.__schedulePolicy.Type = "SimpleSchedulePolicyV2";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__schedulePolicy), __schedulePolicy);
            await eventListener.AssertObjectIsValid(nameof(__schedulePolicy), __schedulePolicy);
        }
    }
    /// The V2 policy schedule for IaaS that supports hourly backups.
    public partial interface ISimpleSchedulePolicyV2 :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy
    {
        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of times of day this schedule has to be run.",
        SerializedName = @"scheduleRunTimes",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        System.Collections.Generic.List<global::System.DateTime> DailyScheduleRunTime { get; set; }
        /// <summary>
        /// Interval at which backup needs to be triggered. For hourly the value
        /// can be 4/6/8/12
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Interval at which backup needs to be triggered. For hourly the value
        can be 4/6/8/12",
        SerializedName = @"interval",
        PossibleTypes = new [] { typeof(int) })]
        int? HourlyScheduleInterval { get; set; }
        /// <summary>To specify duration of the backup window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To specify duration of the backup window",
        SerializedName = @"scheduleWindowDuration",
        PossibleTypes = new [] { typeof(int) })]
        int? HourlyScheduleWindowDuration { get; set; }
        /// <summary>To specify start time of the backup window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To specify start time of the backup window",
        SerializedName = @"scheduleWindowStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? HourlyScheduleWindowStartTime { get; set; }
        /// <summary>Frequency of the schedule operation of this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Frequency of the schedule operation of this policy.",
        SerializedName = @"scheduleRunFrequency",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly", "Hourly")]
        string ScheduleRunFrequency { get; set; }
        /// <summary>Array of DayOfWeek</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of DayOfWeek",
        SerializedName = @"scheduleRunDays",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> WeeklyScheduleRunDay { get; set; }
        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of times of day this schedule has to be run.",
        SerializedName = @"scheduleRunTimes",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        System.Collections.Generic.List<global::System.DateTime> WeeklyScheduleRunTime { get; set; }

    }
    /// The V2 policy schedule for IaaS that supports hourly backups.
    internal partial interface ISimpleSchedulePolicyV2Internal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal
    {
        /// <summary>Daily schedule of this policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule DailySchedule { get; set; }
        /// <summary>List of times of day this schedule has to be run.</summary>
        System.Collections.Generic.List<global::System.DateTime> DailyScheduleRunTime { get; set; }
        /// <summary>hourly schedule of this policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule HourlySchedule { get; set; }
        /// <summary>
        /// Interval at which backup needs to be triggered. For hourly the value
        /// can be 4/6/8/12
        /// </summary>
        int? HourlyScheduleInterval { get; set; }
        /// <summary>To specify duration of the backup window</summary>
        int? HourlyScheduleWindowDuration { get; set; }
        /// <summary>To specify start time of the backup window</summary>
        global::System.DateTime? HourlyScheduleWindowStartTime { get; set; }
        /// <summary>Frequency of the schedule operation of this policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly", "Hourly")]
        string ScheduleRunFrequency { get; set; }
        /// <summary>Weekly schedule of this policy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule WeeklySchedule { get; set; }
        /// <summary>Array of DayOfWeek</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> WeeklyScheduleRunDay { get; set; }
        /// <summary>List of times of day this schedule has to be run.</summary>
        System.Collections.Generic.List<global::System.DateTime> WeeklyScheduleRunTime { get; set; }

    }
}