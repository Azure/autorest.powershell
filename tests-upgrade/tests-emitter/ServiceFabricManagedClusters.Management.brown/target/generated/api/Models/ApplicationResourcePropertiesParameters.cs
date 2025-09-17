// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// List of application parameters with overridden values from their default values specified in the application manifest.
    /// </summary>
    public partial class ApplicationResourcePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationResourcePropertiesParametersInternal
    {

        /// <summary>Creates an new <see cref="ApplicationResourcePropertiesParameters" /> instance.</summary>
        public ApplicationResourcePropertiesParameters()
        {

        }
    }
    /// List of application parameters with overridden values from their default values specified in the application manifest.
    public partial interface IApplicationResourcePropertiesParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IAssociativeArray<string>
    {

    }
    /// List of application parameters with overridden values from their default values specified in the application manifest.
    internal partial interface IApplicationResourcePropertiesParametersInternal

    {

    }
}