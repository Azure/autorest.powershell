// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Eligibility of RP to be moved to another tier</summary>
    public partial class AzureWorkloadRecoveryPointMoveReadinessInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfoInternal
    {

        /// <summary>
        /// Creates an new <see cref="AzureWorkloadRecoveryPointMoveReadinessInfo" /> instance.
        /// </summary>
        public AzureWorkloadRecoveryPointMoveReadinessInfo()
        {

        }
    }
    /// Eligibility of RP to be moved to another tier
    public partial interface IAzureWorkloadRecoveryPointMoveReadinessInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointMoveReadinessInfo>
    {

    }
    /// Eligibility of RP to be moved to another tier
    internal partial interface IAzureWorkloadRecoveryPointMoveReadinessInfoInternal

    {

    }
}