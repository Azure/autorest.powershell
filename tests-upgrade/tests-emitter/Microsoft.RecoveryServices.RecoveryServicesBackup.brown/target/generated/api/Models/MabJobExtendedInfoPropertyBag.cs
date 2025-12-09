// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>The job properties.</summary>
    public partial class MabJobExtendedInfoPropertyBag :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBagInternal
    {

        /// <summary>Creates an new <see cref="MabJobExtendedInfoPropertyBag" /> instance.</summary>
        public MabJobExtendedInfoPropertyBag()
        {

        }
    }
    /// The job properties.
    public partial interface IMabJobExtendedInfoPropertyBag :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// The job properties.
    internal partial interface IMabJobExtendedInfoPropertyBagInternal

    {

    }
}