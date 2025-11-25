// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>
    /// Minimum properties that should be present in each individual validation response.
    /// </summary>
    public partial class ValidationInputResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal
    {

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError _error;

        /// <summary>Error code and message of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudError()); }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CloudError()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputResponseInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target = value ?? null; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudErrorInternal)Error).Target; }

        /// <summary>Backing field for <see cref="ValidationType" /> property.</summary>
        private string _validationType;

        /// <summary>Identifies the type of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ValidationType { get => this._validationType; set => this._validationType = value; }

        /// <summary>Creates an new <see cref="ValidationInputResponse" /> instance.</summary>
        public ValidationInputResponse()
        {

        }
    }
    /// Minimum properties that should be present in each individual validation response.
    public partial interface IValidationInputResponse :
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
        /// <summary>Identifies the type of validation response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identifies the type of validation response.",
        SerializedName = @"validationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        string ValidationType { get; set; }

    }
    /// Minimum properties that should be present in each individual validation response.
    internal partial interface IValidationInputResponseInternal

    {
        /// <summary>Gets or sets additional error info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Detail { get; set; }
        /// <summary>Error code and message of validation response.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }
        /// <summary>Identifies the type of validation response.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ValidateAddress", "ValidateSubscriptionIsAllowedToCreateJob", "ValidatePreferences", "ValidateCreateOrderLimit", "ValidateSkuAvailability", "ValidateDataTransferDetails")]
        string ValidationType { get; set; }

    }
}