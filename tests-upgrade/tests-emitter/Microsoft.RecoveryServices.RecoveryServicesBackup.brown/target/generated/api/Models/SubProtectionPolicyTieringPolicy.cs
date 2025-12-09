// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// Tiering policy to automatically move RPs to another tier.
    /// Key is Target Tier, defined in RecoveryPointTierType enum.
    /// Tiering policy specifies the criteria to move RP to the target tier.
    /// </summary>
    public partial class SubProtectionPolicyTieringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISubProtectionPolicyTieringPolicyInternal
    {

        /// <summary>Creates an new <see cref="SubProtectionPolicyTieringPolicy" /> instance.</summary>
        public SubProtectionPolicyTieringPolicy()
        {

        }
    }
    /// Tiering policy to automatically move RPs to another tier.
    /// Key is Target Tier, defined in RecoveryPointTierType enum.
    /// Tiering policy specifies the criteria to move RP to the target tier.
    public partial interface ISubProtectionPolicyTieringPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITieringPolicy>
    {

    }
    /// Tiering policy to automatically move RPs to another tier.
    /// Key is Target Tier, defined in RecoveryPointTierType enum.
    /// Tiering policy specifies the criteria to move RP to the target tier.
    internal partial interface ISubProtectionPolicyTieringPolicyInternal

    {

    }
}