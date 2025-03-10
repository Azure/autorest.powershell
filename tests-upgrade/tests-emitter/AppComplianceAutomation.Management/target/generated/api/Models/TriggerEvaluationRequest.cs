// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Trigger evaluation request.</summary>
    public partial class TriggerEvaluationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ITriggerEvaluationRequestInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceId;

        /// <summary>List of resource ids to be evaluated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="TriggerEvaluationRequest" /> instance.</summary>
        public TriggerEvaluationRequest()
        {

        }
    }
    /// Trigger evaluation request.
    public partial interface ITriggerEvaluationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>List of resource ids to be evaluated</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of resource ids to be evaluated",
        SerializedName = @"resourceIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceId { get; set; }

    }
    /// Trigger evaluation request.
    internal partial interface ITriggerEvaluationRequestInternal

    {
        /// <summary>List of resource ids to be evaluated</summary>
        System.Collections.Generic.List<string> ResourceId { get; set; }

    }
}