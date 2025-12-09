// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Job properties.</summary>
    public partial class VaultJobExtendedInfoPropertyBag :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBagInternal
    {

        /// <summary>Creates an new <see cref="VaultJobExtendedInfoPropertyBag" /> instance.</summary>
        public VaultJobExtendedInfoPropertyBag()
        {

        }
    }
    /// Job properties.
    public partial interface IVaultJobExtendedInfoPropertyBag :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Job properties.
    internal partial interface IVaultJobExtendedInfoPropertyBagInternal

    {

    }
}