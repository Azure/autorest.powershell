// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Weekly schedule of this policy</summary>
    public partial class WeeklySchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklySchedule,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWeeklyScheduleInternal
    {

        /// <summary>Backing field for <see cref="ScheduleRunDay" /> property.</summary>
        private System.Collections.Generic.List<string> _scheduleRunDay;

        /// <summary>Array of DayOfWeek</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ScheduleRunDay { get => this._scheduleRunDay; set => this._scheduleRunDay = value; }

        /// <summary>Backing field for <see cref="ScheduleRunTime" /> property.</summary>
        private System.Collections.Generic.List<global::System.DateTime> _scheduleRunTime;

        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get => this._scheduleRunTime; set => this._scheduleRunTime = value; }

        /// <summary>Creates an new <see cref="WeeklySchedule" /> instance.</summary>
        public WeeklySchedule()
        {

        }
    }
    /// Weekly schedule of this policy
    public partial interface IWeeklySchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
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
        System.Collections.Generic.List<string> ScheduleRunDay { get; set; }
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

    }
    /// Weekly schedule of this policy
    internal partial interface IWeeklyScheduleInternal

    {
        /// <summary>Array of DayOfWeek</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday")]
        System.Collections.Generic.List<string> ScheduleRunDay { get; set; }
        /// <summary>List of times of day this schedule has to be run.</summary>
        System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get; set; }

    }
}