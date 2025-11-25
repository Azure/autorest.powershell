// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request to validate subscription permission to create jobs.</summary>
    public partial class SubscriptionIsAllowedToCreateJobValidationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISubscriptionIsAllowedToCreateJobValidationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISubscriptionIsAllowedToCreateJobValidationRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest __validationInputRequest = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidationInputRequest();

        /// <summary>Identifies the type of validation request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ValidationType { get => "ValidateSubscriptionIsAllowedToCreateJob"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)__validationInputRequest).ValidationType = "ValidateSubscriptionIsAllowedToCreateJob"; }

        /// <summary>
        /// Creates an new <see cref="SubscriptionIsAllowedToCreateJobValidationRequest" /> instance.
        /// </summary>
        public SubscriptionIsAllowedToCreateJobValidationRequest()
        {
            this.__validationInputRequest.ValidationType = "ValidateSubscriptionIsAllowedToCreateJob";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__validationInputRequest), __validationInputRequest);
            await eventListener.AssertObjectIsValid(nameof(__validationInputRequest), __validationInputRequest);
        }
    }
    /// Request to validate subscription permission to create jobs.
    public partial interface ISubscriptionIsAllowedToCreateJobValidationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest
    {

    }
    /// Request to validate subscription permission to create jobs.
    internal partial interface ISubscriptionIsAllowedToCreateJobValidationRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal
    {

    }
}