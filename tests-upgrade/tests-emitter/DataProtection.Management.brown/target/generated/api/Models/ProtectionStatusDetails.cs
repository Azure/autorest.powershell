// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Protection status details</summary>
    public partial class ProtectionStatusDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal
    {

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError _errorDetail;

        /// <summary>Specifies the protection status error of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingError()); set => this._errorDetail = value; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Code = value ?? null; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetailDetails { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Detail = value ?? null /* arrayOf */; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).InnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).InnerError = value ?? null /* model class */; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).IsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).IsRetryable = value ?? default(bool); }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? ErrorDetailIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).IsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).IsUserError = value ?? default(bool); }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Message = value ?? null; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Property = value ?? null /* model class */; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).RecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).RecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ErrorDetailTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)ErrorDetail).Target = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IProtectionStatusDetailsInternal.ErrorDetail { get => (this._errorDetail = this._errorDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingError()); set { {_errorDetail = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="ProtectionStatusDetails" /> instance.</summary>
        public ProtectionStatusDetails()
        {

        }
    }
    /// Protection status details
    public partial interface IProtectionStatusDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unique code for this error",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get; set; }
        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional related Errors",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetailDetails { get; set; }
        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Inner Error",
        SerializedName = @"innerError",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether the operation will be retryable or not",
        SerializedName = @"isRetryable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ErrorDetailIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether the operation is due to a user error or service error",
        SerializedName = @"isUserError",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ErrorDetailIsUserError { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get; set; }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Any key value pairs that can be injected inside error object",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get; set; }
        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"RecommendedAction � localized.",
        SerializedName = @"recommendedAction",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailTarget { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the protection status of the resource",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ConfiguringProtection", "ConfiguringProtectionFailed", "ProtectionConfigured", "ProtectionStopped", "SoftDeleted", "SoftDeleting")]
        string Status { get; set; }

    }
    /// Protection status details
    internal partial interface IProtectionStatusDetailsInternal

    {
        /// <summary>Specifies the protection status error of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError ErrorDetail { get; set; }
        /// <summary>Unique code for this error</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Additional related Errors</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> ErrorDetailDetails { get; set; }
        /// <summary>Inner Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError ErrorDetailInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        bool? ErrorDetailIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        bool? ErrorDetailIsUserError { get; set; }

        string ErrorDetailMessage { get; set; }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties ErrorDetailProperty { get; set; }
        /// <summary>RecommendedAction � localized.</summary>
        System.Collections.Generic.List<string> ErrorDetailRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        string ErrorDetailTarget { get; set; }
        /// <summary>Specifies the protection status of the resource</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PSArgumentCompleterAttribute("ConfiguringProtection", "ConfiguringProtectionFailed", "ProtectionConfigured", "ProtectionStopped", "SoftDeleted", "SoftDeleting")]
        string Status { get; set; }

    }
}