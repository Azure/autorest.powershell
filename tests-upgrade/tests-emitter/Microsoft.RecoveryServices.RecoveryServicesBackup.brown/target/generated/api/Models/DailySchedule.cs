// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Daily schedule of this policy</summary>
    public partial class DailySchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailySchedule,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDailyScheduleInternal
    {

        /// <summary>Backing field for <see cref="ScheduleRunTime" /> property.</summary>
        private System.Collections.Generic.List<global::System.DateTime> _scheduleRunTime;

        /// <summary>List of times of day this schedule has to be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get => this._scheduleRunTime; set => this._scheduleRunTime = value; }

        /// <summary>Creates an new <see cref="DailySchedule" /> instance.</summary>
        public DailySchedule()
        {

        }
    }
    /// Daily schedule of this policy
    public partial interface IDailySchedule :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
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
        System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get; set; }

    }
    /// Daily schedule of this policy
    internal partial interface IDailyScheduleInternal

    {
        /// <summary>List of times of day this schedule has to be run.</summary>
        System.Collections.Generic.List<global::System.DateTime> ScheduleRunTime { get; set; }

    }
}