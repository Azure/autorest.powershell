// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The status of a UpdateGroup.</summary>
    public partial class UpdateGroupStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).AdditionalInfo; }

        /// <summary>Backing field for <see cref="AfterGate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> _afterGate;

        /// <summary>The list of Gates that will run after this UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> AfterGate { get => this._afterGate; }

        /// <summary>Backing field for <see cref="BeforeGate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> _beforeGate;

        /// <summary>The list of Gates that will run before this UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> BeforeGate { get => this._beforeGate; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Detail; }

        /// <summary>Backing field for <see cref="Member" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IMemberUpdateStatus> _member;

        /// <summary>The list of member this UpdateGroup updates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IMemberUpdateStatus> Member { get => this._member; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AfterGate</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.AfterGate { get => this._afterGate; set { {_afterGate = value;} } }

        /// <summary>Internal Acessors for BeforeGate</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.BeforeGate { get => this._beforeGate; set { {_beforeGate = value;} } }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Member</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IMemberUpdateStatus> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Member { get => this._member; set { {_member = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Message = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusCompletedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.StatusCompletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).CompletedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).CompletedTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for StatusError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.StatusStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for StatusState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.StatusState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).State = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupStatusInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Target = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus _status;

        /// <summary>The status of the UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateStatus()); }

        /// <summary>The time the operation or group was completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusCompletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).CompletedTime; }

        /// <summary>The time the operation or group was started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).StartTime; }

        /// <summary>The State of the operation or group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).State; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Target; }

        /// <summary>Creates an new <see cref="UpdateGroupStatus" /> instance.</summary>
        public UpdateGroupStatus()
        {

        }
    }
    /// The status of a UpdateGroup.
    public partial interface IUpdateGroupStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get;  }
        /// <summary>The list of Gates that will run after this UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of Gates that will run after this UpdateGroup.",
        SerializedName = @"afterGates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> AfterGate { get;  }
        /// <summary>The list of Gates that will run before this UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of Gates that will run before this UpdateGroup.",
        SerializedName = @"beforeGates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> BeforeGate { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get;  }
        /// <summary>The list of member this UpdateGroup updates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The list of member this UpdateGroup updates.",
        SerializedName = @"members",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IMemberUpdateStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IMemberUpdateStatus> Member { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The name of the UpdateGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the UpdateGroup.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The time the operation or group was completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The time the operation or group was completed.",
        SerializedName = @"completedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusCompletedTime { get;  }
        /// <summary>The time the operation or group was started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The time the operation or group was started.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusStartTime { get;  }
        /// <summary>The State of the operation or group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The State of the operation or group.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("NotStarted", "Running", "Stopping", "Stopped", "Skipped", "Failed", "Pending", "Completed")]
        string StatusState { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// The status of a UpdateGroup.
    internal partial interface IUpdateGroupStatusInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>The list of Gates that will run after this UpdateGroup.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> AfterGate { get; set; }
        /// <summary>The list of Gates that will run before this UpdateGroup.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus> BeforeGate { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get; set; }
        /// <summary>The list of member this UpdateGroup updates.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IMemberUpdateStatus> Member { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The name of the UpdateGroup.</summary>
        string Name { get; set; }
        /// <summary>The status of the UpdateGroup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus Status { get; set; }
        /// <summary>The time the operation or group was completed.</summary>
        global::System.DateTime? StatusCompletedTime { get; set; }
        /// <summary>The error details when a failure is encountered.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusError { get; set; }
        /// <summary>The time the operation or group was started.</summary>
        global::System.DateTime? StatusStartTime { get; set; }
        /// <summary>The State of the operation or group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("NotStarted", "Running", "Stopping", "Stopped", "Skipped", "Failed", "Pending", "Completed")]
        string StatusState { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}