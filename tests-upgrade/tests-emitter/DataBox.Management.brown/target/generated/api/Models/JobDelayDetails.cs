// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job Delay Notification details</summary>
    public partial class JobDelayDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetailsInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the delay.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="ErrorCode" /> property.</summary>
        private string _errorCode;

        /// <summary>Delay Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ErrorCode { get => this._errorCode; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetailsInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for ErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetailsInternal.ErrorCode { get => this._errorCode; set { {_errorCode = value;} } }

        /// <summary>Internal Acessors for ResolutionTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetailsInternal.ResolutionTime { get => this._resolutionTime; set { {_resolutionTime = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetailsInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDelayDetailsInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="ResolutionTime" /> property.</summary>
        private global::System.DateTime? _resolutionTime;

        /// <summary>Timestamp when the delay notification was resolved.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public global::System.DateTime? ResolutionTime { get => this._resolutionTime; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>Timestamp when the delay notification was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of notification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="JobDelayDetails" /> instance.</summary>
        public JobDelayDetails()
        {

        }
    }
    /// Job Delay Notification details
    public partial interface IJobDelayDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Description of the delay.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Description of the delay.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Delay Error code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Delay Error code",
        SerializedName = @"errorCode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("InternalIssueDelay", "ActiveOrderLimitBreachedDelay", "HighDemandDelay", "LargeNumberOfFilesDelay")]
        string ErrorCode { get;  }
        /// <summary>Timestamp when the delay notification was resolved.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Timestamp when the delay notification was resolved.",
        SerializedName = @"resolutionTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResolutionTime { get;  }
        /// <summary>Timestamp when the delay notification was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Timestamp when the delay notification was created.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>Status of notification</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of notification",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Active", "Resolved")]
        string Status { get;  }

    }
    /// Job Delay Notification details
    internal partial interface IJobDelayDetailsInternal

    {
        /// <summary>Description of the delay.</summary>
        string Description { get; set; }
        /// <summary>Delay Error code</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("InternalIssueDelay", "ActiveOrderLimitBreachedDelay", "HighDemandDelay", "LargeNumberOfFilesDelay")]
        string ErrorCode { get; set; }
        /// <summary>Timestamp when the delay notification was resolved.</summary>
        global::System.DateTime? ResolutionTime { get; set; }
        /// <summary>Timestamp when the delay notification was created.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Status of notification</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Active", "Resolved")]
        string Status { get; set; }

    }
}