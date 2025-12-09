// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>The job properties.</summary>
    public partial class DpmJobExtendedInfoPropertyBag :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoPropertyBag,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoPropertyBagInternal
    {

        /// <summary>Creates an new <see cref="DpmJobExtendedInfoPropertyBag" /> instance.</summary>
        public DpmJobExtendedInfoPropertyBag()
        {

        }
    }
    /// The job properties.
    public partial interface IDpmJobExtendedInfoPropertyBag :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// The job properties.
    internal partial interface IDpmJobExtendedInfoPropertyBagInternal

    {

    }
}