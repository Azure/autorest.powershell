// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>ImportFromStorage Response Properties</summary>
    public partial class ImportFromStorageResponseType :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportFromStorageResponseType,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IImportFromStorageResponseTypeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType __operationProgressResponseType = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.OperationProgressResponseType();

        /// <summary>Backing field for <see cref="EstimatedCompletionTime" /> property.</summary>
        private global::System.DateTime? _estimatedCompletionTime;

        /// <summary>The estimated time of operation completion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? EstimatedCompletionTime { get => this._estimatedCompletionTime; set => this._estimatedCompletionTime = value; }

        /// <summary>Identifies the type of source operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string ObjectType { get => "ImportFromStorageResponse"; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal)__operationProgressResponseType).ObjectType = "ImportFromStorageResponse"; }

        /// <summary>Creates an new <see cref="ImportFromStorageResponseType" /> instance.</summary>
        public ImportFromStorageResponseType()
        {
            this.__operationProgressResponseType.ObjectType = "ImportFromStorageResponse";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__operationProgressResponseType), __operationProgressResponseType);
            await eventListener.AssertObjectIsValid(nameof(__operationProgressResponseType), __operationProgressResponseType);
        }
    }
    /// ImportFromStorage Response Properties
    public partial interface IImportFromStorageResponseType :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType
    {
        /// <summary>The estimated time of operation completion.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The estimated time of operation completion.",
        SerializedName = @"estimatedCompletionTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EstimatedCompletionTime { get; set; }

    }
    /// ImportFromStorage Response Properties
    internal partial interface IImportFromStorageResponseTypeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal
    {
        /// <summary>The estimated time of operation completion.</summary>
        global::System.DateTime? EstimatedCompletionTime { get; set; }

    }
}