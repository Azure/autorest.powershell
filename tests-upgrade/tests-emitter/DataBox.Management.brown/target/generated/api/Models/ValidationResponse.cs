// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Response of pre job creation validations.</summary>
    public partial class ValidationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseInternal
    {

        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> IndividualResponseDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal)Property).IndividualResponseDetail; }

        /// <summary>Internal Acessors for IndividualResponseDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseInternal.IndividualResponseDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal)Property).IndividualResponseDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal)Property).IndividualResponseDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidationResponseProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseProperties _property;

        /// <summary>Properties of pre job creation validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidationResponseProperties()); }

        /// <summary>Overall validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponsePropertiesInternal)Property).Status; }

        /// <summary>Creates an new <see cref="ValidationResponse" /> instance.</summary>
        public ValidationResponse()
        {

        }
    }
    /// Response of pre job creation validations.
    public partial interface IValidationResponse :
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
    /// Response of pre job creation validations.
    internal partial interface IValidationResponseInternal

    {
        /// <summary>
        /// List of response details contain validationType and its response as key and value respectively.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse> IndividualResponseDetail { get; set; }
        /// <summary>Properties of pre job creation validation response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationResponseProperties Property { get; set; }
        /// <summary>Overall validation status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("AllValidToProceed", "InputsRevisitRequired", "CertainInputValidationsSkipped")]
        string Status { get; set; }

    }
}