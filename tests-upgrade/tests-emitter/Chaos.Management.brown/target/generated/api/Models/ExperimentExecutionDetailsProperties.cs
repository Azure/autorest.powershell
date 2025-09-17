// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents the extended properties of an experiment execution.</summary>
    public partial class ExperimentExecutionDetailsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FailureReason" /> property.</summary>
        private string _failureReason;

        /// <summary>The reason why the execution failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string FailureReason { get => this._failureReason; }

        /// <summary>Backing field for <see cref="LastActionAt" /> property.</summary>
        private global::System.DateTime? _lastActionAt;

        /// <summary>String that represents the last action date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public global::System.DateTime? LastActionAt { get => this._lastActionAt; }

        /// <summary>Internal Acessors for FailureReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.FailureReason { get => this._failureReason; set { {_failureReason = value;} } }

        /// <summary>Internal Acessors for LastActionAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.LastActionAt { get => this._lastActionAt; set { {_lastActionAt = value;} } }

        /// <summary>Internal Acessors for RunInformation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformation Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.RunInformation { get => (this._runInformation = this._runInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ExperimentExecutionDetailsPropertiesRunInformation()); set { {_runInformation = value;} } }

        /// <summary>Internal Acessors for RunInformationStep</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.RunInformationStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformationInternal)RunInformation).Step; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformationInternal)RunInformation).Step = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StartedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.StartedAt { get => this._startedAt; set { {_startedAt = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for StoppedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesInternal.StoppedAt { get => this._stoppedAt; set { {_stoppedAt = value;} } }

        /// <summary>Backing field for <see cref="RunInformation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformation _runInformation;

        /// <summary>The information of the experiment run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformation RunInformation { get => (this._runInformation = this._runInformation ?? new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ExperimentExecutionDetailsPropertiesRunInformation()); }

        /// <summary>The steps of the experiment run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> RunInformationStep { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformationInternal)RunInformation).Step; }

        /// <summary>Backing field for <see cref="StartedAt" /> property.</summary>
        private global::System.DateTime? _startedAt;

        /// <summary>String that represents the start date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public global::System.DateTime? StartedAt { get => this._startedAt; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Backing field for <see cref="StoppedAt" /> property.</summary>
        private global::System.DateTime? _stoppedAt;

        /// <summary>String that represents the stop date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public global::System.DateTime? StoppedAt { get => this._stoppedAt; }

        /// <summary>Creates an new <see cref="ExperimentExecutionDetailsProperties" /> instance.</summary>
        public ExperimentExecutionDetailsProperties()
        {

        }
    }
    /// Model that represents the extended properties of an experiment execution.
    public partial interface IExperimentExecutionDetailsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>The reason why the execution failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The reason why the execution failed.",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string FailureReason { get;  }
        /// <summary>String that represents the last action date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the last action date time.",
        SerializedName = @"lastActionAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastActionAt { get;  }
        /// <summary>The steps of the experiment run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The steps of the experiment run.",
        SerializedName = @"steps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> RunInformationStep { get;  }
        /// <summary>String that represents the start date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the start date time.",
        SerializedName = @"startedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartedAt { get;  }
        /// <summary>The status of the execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the execution.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get;  }
        /// <summary>String that represents the stop date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"String that represents the stop date time.",
        SerializedName = @"stoppedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StoppedAt { get;  }

    }
    /// Model that represents the extended properties of an experiment execution.
    internal partial interface IExperimentExecutionDetailsPropertiesInternal

    {
        /// <summary>The reason why the execution failed.</summary>
        string FailureReason { get; set; }
        /// <summary>String that represents the last action date time.</summary>
        global::System.DateTime? LastActionAt { get; set; }
        /// <summary>The information of the experiment run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IExperimentExecutionDetailsPropertiesRunInformation RunInformation { get; set; }
        /// <summary>The steps of the experiment run.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IStepStatus> RunInformationStep { get; set; }
        /// <summary>String that represents the start date time.</summary>
        global::System.DateTime? StartedAt { get; set; }
        /// <summary>The status of the execution.</summary>
        string Status { get; set; }
        /// <summary>String that represents the stop date time.</summary>
        global::System.DateTime? StoppedAt { get; set; }

    }
}