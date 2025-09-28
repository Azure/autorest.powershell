// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Operation Resource</summary>
    public partial class OperationResource :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResource,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>End time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError _error;

        /// <summary>
        /// Required if status == failed or status == canceled. This is the OData v4 error format, used by the RPC and will go into
        /// the v2.2 Azure REST API guidelines.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Error()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>It should match what is used to GET the operation result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.Error()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Message = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IOperationResourceInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Target = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// It must match the last segment of the "id" field, and will typically be a GUID / system generated value
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>Start time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status of the operation. (InProgress/Success/Failed/Cancelled)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorInternal)Error).Target; }

        /// <summary>Creates an new <see cref="OperationResource" /> instance.</summary>
        public OperationResource()
        {

        }
    }
    /// Operation Resource
    public partial interface IOperationResource :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Detail { get;  }
        /// <summary>End time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"End time of the operation",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
        /// <summary>It should match what is used to GET the operation result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"It should match what is used to GET the operation result",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>
        /// It must match the last segment of the "id" field, and will typically be a GUID / system generated value
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"It must match the last segment of the ""id"" field, and will typically be a GUID / system generated value",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Start time of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Start time of the operation",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the operation. (InProgress/Success/Failed/Cancelled)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of the operation. (InProgress/Success/Failed/Cancelled)",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// Operation Resource
    internal partial interface IOperationResourceInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError> Detail { get; set; }
        /// <summary>End time of the operation</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>
        /// Required if status == failed or status == canceled. This is the OData v4 error format, used by the RPC and will go into
        /// the v2.2 Azure REST API guidelines.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IError Error { get; set; }
        /// <summary>It should match what is used to GET the operation result</summary>
        string Id { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>
        /// It must match the last segment of the "id" field, and will typically be a GUID / system generated value
        /// </summary>
        string Name { get; set; }
        /// <summary>Start time of the operation</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The status of the operation. (InProgress/Success/Failed/Cancelled)</summary>
        string Status { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }

    }
}