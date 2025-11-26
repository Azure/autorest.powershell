// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>
    /// Warning object used by layers that have access to localized content, and propagate that to user
    /// </summary>
    public partial class UserFacingWarningDetail :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetail,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal
    {

        /// <summary>Internal Acessors for Warning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingWarningDetailInternal.Warning { get => (this._warning = this._warning ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingError()); set { {_warning = value;} } }

        /// <summary>Backing field for <see cref="ResourceName" /> property.</summary>
        private string _resourceName;

        /// <summary>Name of resource for which warning is raised.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ResourceName { get => this._resourceName; set => this._resourceName = value; }

        /// <summary>Backing field for <see cref="Warning" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError _warning;

        /// <summary>Error details for the warning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Warning { get => (this._warning = this._warning ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.UserFacingError()); set => this._warning = value; }

        /// <summary>Unique code for this error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string WarningCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Code = value ?? null; }

        /// <summary>Additional related Errors</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> WarningDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Detail = value ?? null /* arrayOf */; }

        /// <summary>Inner Error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError WarningInnerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).InnerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).InnerError = value ?? null /* model class */; }

        /// <summary>Whether the operation will be retryable or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? WarningIsRetryable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).IsRetryable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).IsRetryable = value ?? default(bool); }

        /// <summary>Whether the operation is due to a user error or service error</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public bool? WarningIsUserError { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).IsUserError; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).IsUserError = value ?? default(bool); }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string WarningMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Message = value ?? null; }

        /// <summary>Any key value pairs that can be injected inside error object</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties WarningProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Property = value ?? null /* model class */; }

        /// <summary>RecommendedAction � localized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> WarningRecommendedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).RecommendedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).RecommendedAction = value ?? null /* arrayOf */; }

        /// <summary>Target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string WarningTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorInternal)Warning).Target = value ?? null; }

        /// <summary>Creates an new <see cref="UserFacingWarningDetail" /> instance.</summary>
        public UserFacingWarningDetail()
        {

        }
    }
    /// Warning object used by layers that have access to localized content, and propagate that to user
    public partial interface IUserFacingWarningDetail :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        /// <summary>Name of resource for which warning is raised.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of resource for which warning is raised.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceName { get; set; }
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
        string WarningCode { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> WarningDetail { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError WarningInnerError { get; set; }
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
        bool? WarningIsRetryable { get; set; }
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
        bool? WarningIsUserError { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string WarningMessage { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties WarningProperty { get; set; }
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
        System.Collections.Generic.List<string> WarningRecommendedAction { get; set; }
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
        string WarningTarget { get; set; }

    }
    /// Warning object used by layers that have access to localized content, and propagate that to user
    internal partial interface IUserFacingWarningDetailInternal

    {
        /// <summary>Name of resource for which warning is raised.</summary>
        string ResourceName { get; set; }
        /// <summary>Error details for the warning.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError Warning { get; set; }
        /// <summary>Unique code for this error</summary>
        string WarningCode { get; set; }
        /// <summary>Additional related Errors</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingError> WarningDetail { get; set; }
        /// <summary>Inner Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IInnerError WarningInnerError { get; set; }
        /// <summary>Whether the operation will be retryable or not</summary>
        bool? WarningIsRetryable { get; set; }
        /// <summary>Whether the operation is due to a user error or service error</summary>
        bool? WarningIsUserError { get; set; }

        string WarningMessage { get; set; }
        /// <summary>Any key value pairs that can be injected inside error object</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IUserFacingErrorProperties WarningProperty { get; set; }
        /// <summary>RecommendedAction � localized.</summary>
        System.Collections.Generic.List<string> WarningRecommendedAction { get; set; }
        /// <summary>Target of the error.</summary>
        string WarningTarget { get; set; }

    }
}