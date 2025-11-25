// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Properties of create order limit for subscription validation response.</summary>
    public partial class CreateOrderLimitForSubscriptionValidationResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICreateOrderLimitForSubscriptionValidationResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICreateOrderLimitForSubscriptionValidationResponsePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse __validationInputResponse = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidationInputResponse();

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Code; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Detail; }

        /// <summary>Error code and message of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Error = value ?? null /* model class */; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Message; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICreateOrderLimitForSubscriptionValidationResponsePropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Target = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Create order limit validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Target; }

        /// <summary>Identifies the type of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ValidationType { get => "ValidateCreateOrderLimit"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).ValidationType = "ValidateCreateOrderLimit"; }

        /// <summary>
        /// Creates an new <see cref="CreateOrderLimitForSubscriptionValidationResponseProperties" /> instance.
        /// </summary>
        public CreateOrderLimitForSubscriptionValidationResponseProperties()
        {
            this.__validationInputResponse.ValidationType = "ValidateCreateOrderLimit";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__validationInputResponse), __validationInputResponse);
            await eventListener.AssertObjectIsValid(nameof(__validationInputResponse), __validationInputResponse);
        }
    }
    /// Properties of create order limit for subscription validation response.
    public partial interface ICreateOrderLimitForSubscriptionValidationResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse
    {
        /// <summary>Create order limit validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Create order limit validation status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Valid", "Invalid", "Skipped")]
        string Status { get;  }

    }
    /// Properties of create order limit for subscription validation response.
    internal partial interface ICreateOrderLimitForSubscriptionValidationResponsePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal
    {
        /// <summary>Create order limit validation status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Valid", "Invalid", "Skipped")]
        string Status { get; set; }

    }
}