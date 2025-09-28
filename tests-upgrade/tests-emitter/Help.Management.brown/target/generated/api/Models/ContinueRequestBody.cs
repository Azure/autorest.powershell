// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Troubleshooter ContinueRequest body.</summary>
    public partial class ContinueRequestBody :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IContinueRequestBody,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IContinueRequestBodyInternal
    {

        /// <summary>Backing field for <see cref="Response" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResponse> _response;

        /// <summary>Array of TroubleshooterResponse</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResponse> Response { get => this._response; set => this._response = value; }

        /// <summary>Backing field for <see cref="StepId" /> property.</summary>
        private string _stepId;

        /// <summary>Unique id of the result.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string StepId { get => this._stepId; set => this._stepId = value; }

        /// <summary>Creates an new <see cref="ContinueRequestBody" /> instance.</summary>
        public ContinueRequestBody()
        {

        }
    }
    /// Troubleshooter ContinueRequest body.
    public partial interface IContinueRequestBody :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        /// <summary>Array of TroubleshooterResponse</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of TroubleshooterResponse",
        SerializedName = @"responses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResponse) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResponse> Response { get; set; }
        /// <summary>Unique id of the result.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique id of the result.",
        SerializedName = @"stepId",
        PossibleTypes = new [] { typeof(string) })]
        string StepId { get; set; }

    }
    /// Troubleshooter ContinueRequest body.
    internal partial interface IContinueRequestBodyInternal

    {
        /// <summary>Array of TroubleshooterResponse</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Help.Models.ITroubleshooterResponse> Response { get; set; }
        /// <summary>Unique id of the result.</summary>
        string StepId { get; set; }

    }
}