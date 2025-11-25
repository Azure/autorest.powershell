// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job stages.</summary>
    public partial class JobStages :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal
    {

        /// <summary>Backing field for <see cref="DelayInformation" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails> _delayInformation;

        /// <summary>Delay information for the job stages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails> DelayInformation { get => this._delayInformation; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="JobStageDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny _jobStageDetail;

        /// <summary>Job Stage Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny JobStageDetail { get => (this._jobStageDetail = this._jobStageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Any()); }

        /// <summary>Internal Acessors for DelayInformation</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal.DelayInformation { get => this._delayInformation; set { {_delayInformation = value;} } }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for JobStageDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal.JobStageDetail { get => (this._jobStageDetail = this._jobStageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Any()); set { {_jobStageDetail = value;} } }

        /// <summary>Internal Acessors for StageName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal.StageName { get => this._stageName; set { {_stageName = value;} } }

        /// <summary>Internal Acessors for StageStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal.StageStatus { get => this._stageStatus; set { {_stageStatus = value;} } }

        /// <summary>Internal Acessors for StageTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStagesInternal.StageTime { get => this._stageTime; set { {_stageTime = value;} } }

        /// <summary>Backing field for <see cref="StageName" /> property.</summary>
        private string _stageName;

        /// <summary>Name of the job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string StageName { get => this._stageName; }

        /// <summary>Backing field for <see cref="StageStatus" /> property.</summary>
        private string _stageStatus;

        /// <summary>Status of the job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string StageStatus { get => this._stageStatus; }

        /// <summary>Backing field for <see cref="StageTime" /> property.</summary>
        private global::System.DateTime? _stageTime;

        /// <summary>Time for the job stage in UTC ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public global::System.DateTime? StageTime { get => this._stageTime; }

        /// <summary>Creates an new <see cref="JobStages" /> instance.</summary>
        public JobStages()
        {

        }
    }
    /// Job stages.
    public partial interface IJobStages :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Delay information for the job stages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Delay information for the job stages.",
        SerializedName = @"delayInformation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails> DelayInformation { get;  }
        /// <summary>Display name of the job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Display name of the job stage.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Job Stage Details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Job Stage Details",
        SerializedName = @"jobStageDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny JobStageDetail { get;  }
        /// <summary>Name of the job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the job stage.",
        SerializedName = @"stageName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DeviceOrdered", "DevicePrepared", "Dispatched", "Delivered", "PickedUp", "AtAzureDC", "DataCopy", "Completed", "CompletedWithErrors", "Cancelled", "Failed_IssueReportedAtCustomer", "Failed_IssueDetectedAtAzureDC", "Aborted", "CompletedWithWarnings", "ReadyToDispatchFromAzureDC", "ReadyToReceiveAtAzureDC", "Created", "ShippedToAzureDC", "AwaitingShipmentDetails", "PreparingToShipFromAzureDC", "ShippedToCustomer")]
        string StageName { get;  }
        /// <summary>Status of the job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the job stage.",
        SerializedName = @"stageStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling", "SucceededWithErrors", "WaitingForCustomerAction", "SucceededWithWarnings", "WaitingForCustomerActionForKek", "WaitingForCustomerActionForCleanUp", "CustomerActionPerformedForCleanUp", "CustomerActionPerformed")]
        string StageStatus { get;  }
        /// <summary>Time for the job stage in UTC ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time for the job stage in UTC ISO 8601 format.",
        SerializedName = @"stageTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StageTime { get;  }

    }
    /// Job stages.
    internal partial interface IJobStagesInternal

    {
        /// <summary>Delay information for the job stages.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails> DelayInformation { get; set; }
        /// <summary>Display name of the job stage.</summary>
        string DisplayName { get; set; }
        /// <summary>Job Stage Details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAny JobStageDetail { get; set; }
        /// <summary>Name of the job stage.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DeviceOrdered", "DevicePrepared", "Dispatched", "Delivered", "PickedUp", "AtAzureDC", "DataCopy", "Completed", "CompletedWithErrors", "Cancelled", "Failed_IssueReportedAtCustomer", "Failed_IssueDetectedAtAzureDC", "Aborted", "CompletedWithWarnings", "ReadyToDispatchFromAzureDC", "ReadyToReceiveAtAzureDC", "Created", "ShippedToAzureDC", "AwaitingShipmentDetails", "PreparingToShipFromAzureDC", "ShippedToCustomer")]
        string StageName { get; set; }
        /// <summary>Status of the job stage.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling", "SucceededWithErrors", "WaitingForCustomerAction", "SucceededWithWarnings", "WaitingForCustomerActionForKek", "WaitingForCustomerActionForCleanUp", "CustomerActionPerformedForCleanUp", "CustomerActionPerformed")]
        string StageStatus { get; set; }
        /// <summary>Time for the job stage in UTC ISO 8601 format.</summary>
        global::System.DateTime? StageTime { get; set; }

    }
}