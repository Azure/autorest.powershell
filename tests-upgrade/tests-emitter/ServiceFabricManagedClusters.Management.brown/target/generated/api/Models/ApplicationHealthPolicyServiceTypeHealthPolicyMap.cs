// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// The map with service type health policy per service type name. The map is empty by default.
    /// </summary>
    public partial class ApplicationHealthPolicyServiceTypeHealthPolicyMap :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMap,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationHealthPolicyServiceTypeHealthPolicyMapInternal
    {

        /// <summary>
        /// Creates an new <see cref="ApplicationHealthPolicyServiceTypeHealthPolicyMap" /> instance.
        /// </summary>
        public ApplicationHealthPolicyServiceTypeHealthPolicyMap()
        {

        }
    }
    /// The map with service type health policy per service type name. The map is empty by default.
    public partial interface IApplicationHealthPolicyServiceTypeHealthPolicyMap :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceTypeHealthPolicy>
    {

    }
    /// The map with service type health policy per service type name. The map is empty by default.
    internal partial interface IApplicationHealthPolicyServiceTypeHealthPolicyMapInternal

    {

    }
}