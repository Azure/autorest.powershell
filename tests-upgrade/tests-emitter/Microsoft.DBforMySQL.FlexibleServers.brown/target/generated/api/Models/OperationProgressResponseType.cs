// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents the response properties specific to the operation</summary>
    public partial class OperationProgressResponseType :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseType,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IOperationProgressResponseTypeInternal
    {

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        /// <summary>Identifies the type of source operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; set => this._objectType = value; }

        /// <summary>Creates an new <see cref="OperationProgressResponseType" /> instance.</summary>
        public OperationProgressResponseType()
        {

        }
    }
    /// Represents the response properties specific to the operation
    public partial interface IOperationProgressResponseType :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Identifies the type of source operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = true,
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
    /// Represents the response properties specific to the operation
    internal partial interface IOperationProgressResponseTypeInternal

    {
        /// <summary>Identifies the type of source operation</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("BackupAndExportResponse", "ImportFromStorageResponse")]
        string ObjectType { get; set; }

    }
}