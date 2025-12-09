// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Simple policy schedule.</summary>
    public partial class SimpleSchedulePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy __schedulePolicy = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SchedulePolicy();

        /// <summary>Backing field for <see cref="HourlySchedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule _hourlySchedule;

        /// <summary>Hourly Schedule of this Policy</summary>
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

        /// <summary>Internal Acessors for HourlySchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IHourlySchedule Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISimpleSchedulePolicyInternal.HourlySchedule { get => (this._hourlySchedule = this._hourlySchedule ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.HourlySchedule()); set { {_hourlySchedule = value;} } }

        /// <summary>Backing field for <see cref="ScheduleRunDay" /> property.</summary>
        private System.Collections.Generic.List<string> _scheduleRunDay;

        /// <summary>List of days of week this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ScheduleRunDay { get => this._scheduleRunDay; set => this._scheduleRunDay = value; }

        /// <summary>Backing field for <see cref="ScheduleRunFrequency" /> property.</summary>
        private string _scheduleRunFrequency;

        /// <summary>Frequency of the schedule operation of this policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ScheduleRunFrequency { get => this._scheduleRunFrequency; set => this._scheduleRunFrequency = value; }

        /// <summary>Backing field for <see cref="ScheduleRunTime" /> property.</summary>
        private System.Collections.Generic.List<global::System.DateTime> _scheduleRunTime;

        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get => this._scheduleRunTime; set => this._scheduleRunTime = value; }

        /// <summary>Backing field for <see cref="ScheduleWeeklyFrequency" /> property.</summary>
        private int? _scheduleWeeklyFrequency;

        /// <summary>At every number weeks this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public int? ScheduleWeeklyFrequency { get => this._scheduleWeeklyFrequency; set => this._scheduleWeeklyFrequency = value; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "SimpleSchedulePolicy"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal)__schedulePolicy).Type = "SimpleSchedulePolicy"; }

        /// <summary>Creates an new <see cref="SimpleSchedulePolicy" /> instance.</summary>
        public SimpleSchedulePolicy()
        {
            this.__schedulePolicy.Type = "SimpleSchedulePolicy";
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
    /// Simple policy schedule.
    public partial interface ISimpleSchedulePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy
    {
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
        /// <summary>List of days of week this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of days of week this schedule has to be run.",
        SerializedName = @"scheduleRunDays",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> ScheduleRunDay { get; set; }
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
        System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get; set; }
        /// <summary>At every number weeks this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"At every number weeks this schedule has to be run.",
        SerializedName = @"scheduleWeeklyFrequency",
        PossibleTypes = new [] { typeof(int) })]
        int? ScheduleWeeklyFrequency { get; set; }

    }
    /// Simple policy schedule.
    internal partial interface ISimpleSchedulePolicyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal
    {
        /// <summary>Hourly Schedule of this Policy</summary>
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
        /// <summary>List of days of week this schedule has to be run.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> ScheduleRunDay { get; set; }
        /// <summary>Frequency of the schedule operation of this policy.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Daily", "Weekly", "Hourly")]
        string ScheduleRunFrequency { get; set; }
        /// <summary>List of times of day this schedule has to be run.</summary>
        System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get; set; }
        /// <summary>At every number weeks this schedule has to be run.</summary>
        int? ScheduleWeeklyFrequency { get; set; }

    }
}