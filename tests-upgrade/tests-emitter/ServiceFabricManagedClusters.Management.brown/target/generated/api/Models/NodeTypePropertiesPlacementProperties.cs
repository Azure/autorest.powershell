// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
    /// should run.
    /// </summary>
    public partial class NodeTypePropertiesPlacementProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesPlacementPropertiesInternal
    {

        /// <summary>Creates an new <see cref="NodeTypePropertiesPlacementProperties" /> instance.</summary>
        public NodeTypePropertiesPlacementProperties()
        {

        }
    }
    /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
    /// should run.
    public partial interface INodeTypePropertiesPlacementProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IAssociativeArray<string>
    {

    }
    /// The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload)
    /// should run.
    internal partial interface INodeTypePropertiesPlacementPropertiesInternal

    {

    }
}