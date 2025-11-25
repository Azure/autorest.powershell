// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Minimum fields that must be present in any type of validation request.</summary>
    public partial class ValidationInputRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal
    {

        /// <summary>Backing field for <see cref="ValidationType" /> property.</summary>
        private string _validationType;

        /// <summary>Identifies the type of validation request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ValidationType { get => this._validationType; set => this._validationType = value; }

        /// <summary>Creates an new <see cref="ValidationInputRequest" /> instance.</summary>
        public ValidationInputRequest()
        {

        }
    }
    /// Minimum fields that must be present in any type of validation request.
    public partial interface IValidationInputRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Identifies the type of validation request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identifies the type of validation request.",
        SerializedName = @"validationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        string ValidationType { get; set; }

    }
    /// Minimum fields that must be present in any type of validation request.
    internal partial interface IValidationInputRequestInternal

    {
        /// <summary>Identifies the type of validation request.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        string ValidationType { get; set; }

    }
}