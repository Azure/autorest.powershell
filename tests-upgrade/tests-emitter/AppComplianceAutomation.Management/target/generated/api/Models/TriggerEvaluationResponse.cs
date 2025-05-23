// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Trigger evaluation response.</summary>
    public partial class TriggerEvaluationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationResponseInternal
    {

        /// <summary>The time when the evaluation is end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? EvaluationEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).EvaluationEndTime; }

        /// <summary>Internal Acessors for EvaluationEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationResponseInternal.EvaluationEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).EvaluationEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).EvaluationEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationProperty Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.TriggerEvaluationProperty()); set { {_property = value;} } }

        /// <summary>Internal Acessors for TriggerTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationResponseInternal.TriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).TriggerTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).TriggerTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationProperty _property;

        /// <summary>trigger evaluation property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationProperty Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.TriggerEvaluationProperty()); set => this._property = value; }

        /// <summary>List of quick assessments</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment> QuickAssessment { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).QuickAssessment; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).QuickAssessment = value ?? null /* arrayOf */; }

        /// <summary>List of resource ids to be evaluated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).ResourceId = value ?? null /* arrayOf */; }

        /// <summary>The time when the evaluation is triggered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Inlined)]
        public global::System.DateTime? TriggerTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationPropertyInternal)Property).TriggerTime; }

        /// <summary>Creates an new <see cref="TriggerEvaluationResponse" /> instance.</summary>
        public TriggerEvaluationResponse()
        {

        }
    }
    /// Trigger evaluation response.
    public partial interface ITriggerEvaluationResponse :
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
    internal partial interface ITriggerEvaluationResponseInternal

    {
        /// <summary>The time when the evaluation is end.</summary>
        global::System.DateTime? EvaluationEndTime { get; set; }
        /// <summary>trigger evaluation property.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationProperty Property { get; set; }
        /// <summary>List of quick assessments</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IQuickAssessment> QuickAssessment { get; set; }
        /// <summary>List of resource ids to be evaluated</summary>
        System.Collections.Generic.List<string> ResourceId { get; set; }
        /// <summary>The time when the evaluation is triggered.</summary>
        global::System.DateTime? TriggerTime { get; set; }

    }
}