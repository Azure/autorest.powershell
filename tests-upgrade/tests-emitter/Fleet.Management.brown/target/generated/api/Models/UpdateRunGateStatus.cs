// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The status of the Gate, as represented in the Update Run.</summary>
    public partial class UpdateRunGateStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Detail; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The human-readable display name of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="GateId" /> property.</summary>
        private string _gateId;

        /// <summary>The resource id of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string GateId { get => this._gateId; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for GateId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.GateId { get => this._gateId; set { {_gateId = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Message = value ?? null; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusCompletedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.StatusCompletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).CompletedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).CompletedTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for StatusError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.StatusStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for StatusState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.StatusState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).State = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateStatusInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatusInternal)Status).Target = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus _status;

        /// <summary>The status of the Gate.</summary>
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

        /// <summary>Creates an new <see cref="UpdateRunGateStatus" /> instance.</summary>
        public UpdateRunGateStatus()
        {

        }
    }
    /// The status of the Gate, as represented in the Update Run.
    public partial interface IUpdateRunGateStatus :
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
        /// <summary>The human-readable display name of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The human-readable display name of the Gate.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>The resource id of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource id of the Gate.",
        SerializedName = @"gateId",
        PossibleTypes = new [] { typeof(string) })]
        string GateId { get;  }
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
    /// The status of the Gate, as represented in the Update Run.
    internal partial interface IUpdateRunGateStatusInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get; set; }
        /// <summary>The human-readable display name of the Gate.</summary>
        string DisplayName { get; set; }
        /// <summary>The resource id of the Gate.</summary>
        string GateId { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>The status of the Gate.</summary>
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