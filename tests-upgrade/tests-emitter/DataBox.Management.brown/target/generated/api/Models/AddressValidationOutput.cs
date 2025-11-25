// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Output of the address validation api.</summary>
    public partial class AddressValidationOutput :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutput,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal
    {

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).AdditionalInfo; }

        /// <summary>List of alternate addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> AlternateAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal)Property).AlternateAddress; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Code; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Detail; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AlternateAddress</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.AlternateAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal)Property).AlternateAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal)Property).AlternateAddress = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AddressValidationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Target = value ?? null; }

        /// <summary>Internal Acessors for ValidationStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.ValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal)Property).ValidationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal)Property).ValidationStatus = value ?? null; }

        /// <summary>Internal Acessors for ValidationType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationOutputInternal.ValidationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).ValidationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).ValidationType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationProperties _property;

        /// <summary>The address validation properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.AddressValidationProperties()); }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).Target; }

        /// <summary>The address validation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationPropertiesInternal)Property).ValidationStatus; }

        /// <summary>Identifies the type of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ValidationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal)Property).ValidationType; }

        /// <summary>Creates an new <see cref="AddressValidationOutput" /> instance.</summary>
        public AddressValidationOutput()
        {

        }
    }
    /// Output of the address validation api.
    public partial interface IAddressValidationOutput :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets additional error info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get;  }
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
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets details for the error.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get;  }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message parsed from the body of the http error response.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }
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
        /// <summary>Identifies the type of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Identifies the type of validation response.",
        SerializedName = @"validationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        string ValidationType { get;  }

    }
    /// Output of the address validation api.
    internal partial interface IAddressValidationOutputInternal

    {
        /// <summary>Gets or sets additional error info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get; set; }
        /// <summary>List of alternate addresses.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress> AlternateAddress { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get; set; }
        /// <summary>Error code and message of validation response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>The address validation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAddressValidationProperties Property { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }
        /// <summary>The address validation status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Valid", "Invalid", "Ambiguous")]
        string ValidationStatus { get; set; }
        /// <summary>Identifies the type of validation response.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        string ValidationType { get; set; }

    }
}