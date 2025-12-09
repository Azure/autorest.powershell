// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents Operation Results API Response</summary>
    public partial class OperationProgressResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResult"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResult __operationStatusResult = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.OperationStatusResult();

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorDetail> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Detail; }

        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>If present, details of the operation error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorDetail Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Error = value ?? null /* model class */; }

        /// <summary>Fully qualified ID for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Id = value ?? null; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Message; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResultInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.OperationProgressResponseType()); set { {_property = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Message = value ?? null; }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).ResourceId = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Target = value ?? null; }

        /// <summary>Name of the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Name = value ?? null; }

        /// <summary>Identifies the type of source operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal)Property).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal)Property).ObjectType = value ?? null; }

        /// <summary>The operations list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResult> Operation { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Operation = value ?? null /* arrayOf */; }

        /// <summary>Percent of the operation that is complete.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public double? PercentComplete { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).PercentComplete; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).PercentComplete = value ?? default(double); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType _property;

        /// <summary>The response properties specific to the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.OperationProgressResponseType()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Fully qualified ID of the resource against which the original async operation was started.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string ResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).ResourceId; }

        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Status = value ; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal)__operationStatusResult).Target; }

        /// <summary>Creates an new <see cref="OperationProgressResult" /> instance.</summary>
        public OperationProgressResult()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__operationStatusResult), __operationStatusResult);
            await eventListener.AssertObjectIsValid(nameof(__operationStatusResult), __operationStatusResult);
        }
    }
    /// Represents Operation Results API Response
    public partial interface IOperationProgressResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResult
    {
        /// <summary>Identifies the type of source operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identifies the type of source operation",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("BackupAndExportResponse", "ImportFromStorageResponse")]
        string ObjectType { get; set; }

    }
    /// Represents Operation Results API Response
    internal partial interface IOperationProgressResultInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationStatusResultInternal
    {
        /// <summary>Identifies the type of source operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("BackupAndExportResponse", "ImportFromStorageResponse")]
        string ObjectType { get; set; }
        /// <summary>The response properties specific to the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType Property { get; set; }

    }
}