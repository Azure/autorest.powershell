// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The address validation output.</summary>
    public partial class AddressValidationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal,
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

        /// <summary>Backing field for <see cref="AlternateAddress" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> _alternateAddress;

        /// <summary>List of alternate addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> AlternateAddress { get => this._alternateAddress; }

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

        /// <summary>Internal Acessors for AlternateAddress</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal.AlternateAddress { get => this._alternateAddress; set { {_alternateAddress = value;} } }

        /// <summary>Internal Acessors for ValidationStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal.ValidationStatus { get => this._validationStatus; set { {_validationStatus = value;} } }

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

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).Target; }

        /// <summary>Backing field for <see cref="ValidationStatus" /> property.</summary>
        private string _validationStatus;

        /// <summary>The address validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ValidationStatus { get => this._validationStatus; }

        /// <summary>Identifies the type of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ValidationType { get => "ValidateAddress"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)__validationInputResponse).ValidationType = "ValidateAddress"; }

        /// <summary>Creates an new <see cref="AddressValidationProperties" /> instance.</summary>
        public AddressValidationProperties()
        {
            this.__validationInputResponse.ValidationType = "ValidateAddress";
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
    /// The address validation output.
    public partial interface IAddressValidationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse
    {
        /// <summary>List of alternate addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of alternate addresses.",
        SerializedName = @"alternateAddresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> AlternateAddress { get;  }
        /// <summary>The address validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The address validation status.",
        SerializedName = @"validationStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Valid", "Invalid", "Ambiguous")]
        string ValidationStatus { get;  }

    }
    /// The address validation output.
    internal partial interface IAddressValidationPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal
    {
        /// <summary>List of alternate addresses.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> AlternateAddress { get; set; }
        /// <summary>The address validation status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Valid", "Invalid", "Ambiguous")]
        string ValidationStatus { get; set; }

    }
}