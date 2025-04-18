// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Trigger evaluation response.</summary>
    public partial class TriggerEvaluationProperty :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationProperty,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal
    {

        /// <summary>Backing field for <see cref="EvaluationEndTime" /> property.</summary>
        private global::System.DateTime? _evaluationEndTime;

        /// <summary>The time when the evaluation is end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? EvaluationEndTime { get => this._evaluationEndTime; }

        /// <summary>Internal Acessors for EvaluationEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal.EvaluationEndTime { get => this._evaluationEndTime; set { {_evaluationEndTime = value;} } }

        /// <summary>Internal Acessors for TriggerTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal.TriggerTime { get => this._triggerTime; set { {_triggerTime = value;} } }

        /// <summary>Backing field for <see cref="QuickAssessment" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment> _quickAssessment;

        /// <summary>List of quick assessments</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment> QuickAssessment { get => this._quickAssessment; set => this._quickAssessment = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceId;

        /// <summary>List of resource ids to be evaluated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="TriggerTime" /> property.</summary>
        private global::System.DateTime? _triggerTime;

        /// <summary>The time when the evaluation is triggered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public global::System.DateTime? TriggerTime { get => this._triggerTime; }

        /// <summary>Creates an new <see cref="TriggerEvaluationProperty" /> instance.</summary>
        public TriggerEvaluationProperty()
        {

        }
    }
    /// Trigger evaluation response.
    public partial interface ITriggerEvaluationProperty :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The time when the evaluation is end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The time when the evaluation is end.",
        SerializedName = @"evaluationEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EvaluationEndTime { get;  }
        /// <summary>List of quick assessments</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of quick assessments",
        SerializedName = @"quickAssessments",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment> QuickAssessment { get; set; }
        /// <summary>List of resource ids to be evaluated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of resource ids to be evaluated",
        SerializedName = @"resourceIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceId { get; set; }
        /// <summary>The time when the evaluation is triggered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The time when the evaluation is triggered.",
        SerializedName = @"triggerTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TriggerTime { get;  }

    }
    /// Trigger evaluation response.
    internal partial interface ITriggerEvaluationPropertyInternal

    {
        /// <summary>The time when the evaluation is end.</summary>
        global::System.DateTime? EvaluationEndTime { get; set; }
        /// <summary>List of quick assessments</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment> QuickAssessment { get; set; }
        /// <summary>List of resource ids to be evaluated</summary>
        System.Collections.Generic.List<string> ResourceId { get; set; }
        /// <summary>The time when the evaluation is triggered.</summary>
        global::System.DateTime? TriggerTime { get; set; }

    }
}