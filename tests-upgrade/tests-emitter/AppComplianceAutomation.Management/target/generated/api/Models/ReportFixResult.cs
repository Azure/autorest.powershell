// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Report fix result.</summary>
    public partial class ReportFixResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportFixResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportFixResultInternal
    {

        /// <summary>Internal Acessors for Reason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportFixResultInternal.Reason { get => this._reason; set { {_reason = value;} } }

        /// <summary>Internal Acessors for Result</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IReportFixResultInternal.Result { get => this._result; set { {_result = value;} } }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>If the report fix action failed, to indicate the detailed failed reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; }

        /// <summary>Backing field for <see cref="Result" /> property.</summary>
        private string _result;

        /// <summary>Indicates whether the fix action is Succeeded or Failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string Result { get => this._result; }

        /// <summary>Creates an new <see cref="ReportFixResult" /> instance.</summary>
        public ReportFixResult()
        {

        }
    }
    /// Report fix result.
    public partial interface IReportFixResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>If the report fix action failed, to indicate the detailed failed reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If the report fix action failed, to indicate the detailed failed reason.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get;  }
        /// <summary>Indicates whether the fix action is Succeeded or Failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates whether the fix action is Succeeded or Failed.",
        SerializedName = @"result",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string Result { get;  }

    }
    /// Report fix result.
    internal partial interface IReportFixResultInternal

    {
        /// <summary>If the report fix action failed, to indicate the detailed failed reason.</summary>
        string Reason { get; set; }
        /// <summary>Indicates whether the fix action is Succeeded or Failed.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string Result { get; set; }

    }
}