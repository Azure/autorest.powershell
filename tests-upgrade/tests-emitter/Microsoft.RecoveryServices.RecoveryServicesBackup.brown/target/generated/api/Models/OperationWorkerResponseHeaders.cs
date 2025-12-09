// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>HTTP headers associated with this operation.</summary>
    public partial class OperationWorkerResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationWorkerResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IOperationWorkerResponseHeadersInternal
    {

        /// <summary>Creates an new <see cref="OperationWorkerResponseHeaders" /> instance.</summary>
        public OperationWorkerResponseHeaders()
        {

        }
    }
    /// HTTP headers associated with this operation.
    public partial interface IOperationWorkerResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>
    {

    }
    /// HTTP headers associated with this operation.
    internal partial interface IOperationWorkerResponseHeadersInternal

    {

    }
}