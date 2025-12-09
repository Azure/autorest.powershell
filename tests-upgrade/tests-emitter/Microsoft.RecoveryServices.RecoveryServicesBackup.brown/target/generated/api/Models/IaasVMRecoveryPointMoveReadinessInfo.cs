// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Eligibility of RP to be moved to another tier</summary>
    public partial class IaasVMRecoveryPointMoveReadinessInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointMoveReadinessInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointMoveReadinessInfoInternal
    {

        /// <summary>Creates an new <see cref="IaasVMRecoveryPointMoveReadinessInfo" /> instance.</summary>
        public IaasVMRecoveryPointMoveReadinessInfo()
        {

        }
    }
    /// Eligibility of RP to be moved to another tier
    public partial interface IIaasVMRecoveryPointMoveReadinessInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointMoveReadinessInfo>
    {

    }
    /// Eligibility of RP to be moved to another tier
    internal partial interface IIaasVMRecoveryPointMoveReadinessInfoInternal

    {

    }
}