// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>The list of scheduled operations.</summary>
    public partial class ScheduledOperationsType :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IScheduledOperationsType,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IScheduledOperationsTypeInternal
    {

        /// <summary>Backing field for <see cref="DayOfWeek" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeek _dayOfWeek;

        /// <summary>Day of week</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeek DayOfWeek { get => (this._dayOfWeek = this._dayOfWeek ?? new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.DayOfWeek()); set => this._dayOfWeek = value; }

        /// <summary>Name of the day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Inlined)]
        public string DayOfWeekName { get => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeekInternal)DayOfWeek).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeekInternal)DayOfWeek).Name = value ; }

        /// <summary>Internal Acessors for DayOfWeek</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeek Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IScheduledOperationsTypeInternal.DayOfWeek { get => (this._dayOfWeek = this._dayOfWeek ?? new Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.DayOfWeek()); set { {_dayOfWeek = value;} } }

        /// <summary>Backing field for <see cref="ScheduledStartTime" /> property.</summary>
        private string _scheduledStartTime;

        /// <summary>auto start time. value must be of ISO-8601 format HH:mm</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string ScheduledStartTime { get => this._scheduledStartTime; set => this._scheduledStartTime = value; }

        /// <summary>Backing field for <see cref="ScheduledStopTime" /> property.</summary>
        private string _scheduledStopTime;

        /// <summary>auto stop time. value must be of ISO-8601 format HH:mm</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string ScheduledStopTime { get => this._scheduledStopTime; set => this._scheduledStopTime = value; }

        /// <summary>Creates an new <see cref="ScheduledOperationsType" /> instance.</summary>
        public ScheduledOperationsType()
        {

        }
    }
    /// The list of scheduled operations.
    public partial interface IScheduledOperationsType :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Name of the day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the day of the week.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday")]
        string DayOfWeekName { get; set; }
        /// <summary>auto start time. value must be of ISO-8601 format HH:mm</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"auto start time. value must be of ISO-8601 format HH:mm",
        SerializedName = @"scheduledStartTime",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduledStartTime { get; set; }
        /// <summary>auto stop time. value must be of ISO-8601 format HH:mm</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"auto stop time. value must be of ISO-8601 format HH:mm",
        SerializedName = @"scheduledStopTime",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduledStopTime { get; set; }

    }
    /// The list of scheduled operations.
    internal partial interface IScheduledOperationsTypeInternal

    {
        /// <summary>Day of week</summary>
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeek DayOfWeek { get; set; }
        /// <summary>Name of the day of the week.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday")]
        string DayOfWeekName { get; set; }
        /// <summary>auto start time. value must be of ISO-8601 format HH:mm</summary>
        string ScheduledStartTime { get; set; }
        /// <summary>auto stop time. value must be of ISO-8601 format HH:mm</summary>
        string ScheduledStopTime { get; set; }

    }
}