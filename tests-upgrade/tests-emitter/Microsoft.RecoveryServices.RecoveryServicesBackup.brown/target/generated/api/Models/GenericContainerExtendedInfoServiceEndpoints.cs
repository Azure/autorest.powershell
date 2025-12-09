// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure Backup Service Endpoints for the container</summary>
    public partial class GenericContainerExtendedInfoServiceEndpoints :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerExtendedInfoServiceEndpoints,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IGenericContainerExtendedInfoServiceEndpointsInternal
    {

        /// <summary>
        /// Creates an new <see cref="GenericContainerExtendedInfoServiceEndpoints" /> instance.
        /// </summary>
        public GenericContainerExtendedInfoServiceEndpoints()
        {

        }
    }
    /// Azure Backup Service Endpoints for the container
    public partial interface IGenericContainerExtendedInfoServiceEndpoints :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IAssociativeArray<string>
    {

    }
    /// Azure Backup Service Endpoints for the container
    internal partial interface IGenericContainerExtendedInfoServiceEndpointsInternal

    {

    }
}