// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// Loosely coupled (type, value) associations (example - parent of a protected item)
    /// </summary>
    public partial class GenericProtectedItemSourceAssociations :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericProtectedItemSourceAssociations,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericProtectedItemSourceAssociationsInternal
    {

        /// <summary>Creates an new <see cref="GenericProtectedItemSourceAssociations" /> instance.</summary>
        public GenericProtectedItemSourceAssociations()
        {

        }
    }
    /// Loosely coupled (type, value) associations (example - parent of a protected item)
    public partial interface IGenericProtectedItemSourceAssociations :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Loosely coupled (type, value) associations (example - parent of a protected item)
    internal partial interface IGenericProtectedItemSourceAssociationsInternal

    {

    }
}