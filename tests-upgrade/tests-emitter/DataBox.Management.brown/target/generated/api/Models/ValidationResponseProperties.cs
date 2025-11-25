// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Properties of pre job creation validation response.</summary>
    public partial class ValidationResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IndividualResponseDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> _individualResponseDetail;

        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> IndividualResponseDetail { get => this._individualResponseDetail; }

        /// <summary>Internal Acessors for IndividualResponseDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal.IndividualResponseDetail { get => this._individualResponseDetail; set { {_individualResponseDetail = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Overall validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="ValidationResponseProperties" /> instance.</summary>
        public ValidationResponseProperties()
        {

        }
    }
    /// Properties of pre job creation validation response.
    public partial interface IValidationResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of response details contain validationType and its response as key and value respectively.",
        SerializedName = @"individualResponseDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse),typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> IndividualResponseDetail { get;  }
        /// <summary>Overall validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Overall validation status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("AllValidToProceed", "InputsRevisitRequired", "CertainInputValidationsSkipped")]
        string Status { get;  }

    }
    /// Properties of pre job creation validation response.
    internal partial interface IValidationResponsePropertiesInternal

    {
        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> IndividualResponseDetail { get; set; }
        /// <summary>Overall validation status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("AllValidToProceed", "InputsRevisitRequired", "CertainInputValidationsSkipped")]
        string Status { get; set; }

    }
}