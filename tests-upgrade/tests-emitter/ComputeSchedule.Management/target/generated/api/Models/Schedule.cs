// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The schedule details for the user request</summary>
    public partial class Schedule :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.ISchedule,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IScheduleInternal
    {

        /// <summary>Backing field for <see cref="DeadLine" /> property.</summary>
        private global::System.DateTime? _deadLine;

        /// <summary>The deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? DeadLine { get => this._deadLine; set => this._deadLine = value; }

        /// <summary>Backing field for <see cref="Deadline" /> property.</summary>
        private global::System.DateTime? _deadline;

        /// <summary>The deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public global::System.DateTime? Deadline { get => this._deadline; set => this._deadline = value; }

        /// <summary>Backing field for <see cref="DeadlineType" /> property.</summary>
        private string _deadlineType;

        /// <summary>The deadlinetype of the operation, this can either be InitiateAt or CompleteBy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string DeadlineType { get => this._deadlineType; set => this._deadlineType = value; }

        /// <summary>Backing field for <see cref="TimeZone" /> property.</summary>
        private string _timeZone;

        /// <summary>The timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string TimeZone { get => this._timeZone; set => this._timeZone = value; }

        /// <summary>Backing field for <see cref="Timezone" /> property.</summary>
        private string _timezone;

        /// <summary>The timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string Timezone { get => this._timezone; set => this._timezone = value; }

        /// <summary>Creates an new <see cref="Schedule" /> instance.</summary>
        public Schedule()
        {

        }
    }
    /// The schedule details for the user request
    public partial interface ISchedule :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>The deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deadline for the operation",
        SerializedName = @"deadLine",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DeadLine { get; set; }
        /// <summary>The deadline for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deadline for the operation",
        SerializedName = @"deadline",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Deadline { get; set; }
        /// <summary>The deadlinetype of the operation, this can either be InitiateAt or CompleteBy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deadlinetype of the operation, this can either be InitiateAt or CompleteBy",
        SerializedName = @"deadlineType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        string DeadlineType { get; set; }
        /// <summary>The timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timezone for the operation",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZone { get; set; }
        /// <summary>The timezone for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timezone for the operation",
        SerializedName = @"timezone",
        PossibleTypes = new [] { typeof(string) })]
        string Timezone { get; set; }

    }
    /// The schedule details for the user request
    internal partial interface IScheduleInternal

    {
        /// <summary>The deadline for the operation</summary>
        global::System.DateTime? DeadLine { get; set; }
        /// <summary>The deadline for the operation</summary>
        global::System.DateTime? Deadline { get; set; }
        /// <summary>The deadlinetype of the operation, this can either be InitiateAt or CompleteBy</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PSArgumentCompleterAttribute("Unknown", "InitiateAt", "CompleteBy")]
        string DeadlineType { get; set; }
        /// <summary>The timezone for the operation</summary>
        string TimeZone { get; set; }
        /// <summary>The timezone for the operation</summary>
        string Timezone { get; set; }

    }
}