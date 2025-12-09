// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Health details of different KPIs</summary>
    public partial class AzureVMWorkloadProtectedItemKpisHealths :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealths,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMWorkloadProtectedItemKpisHealthsInternal
    {

        /// <summary>Creates an new <see cref="AzureVMWorkloadProtectedItemKpisHealths" /> instance.</summary>
        public AzureVMWorkloadProtectedItemKpisHealths()
        {

        }
    }
    /// Health details of different KPIs
    public partial interface IAzureVMWorkloadProtectedItemKpisHealths :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKpiResourceHealthDetails>
    {

    }
    /// Health details of different KPIs
    internal partial interface IAzureVMWorkloadProtectedItemKpisHealthsInternal

    {

    }
}