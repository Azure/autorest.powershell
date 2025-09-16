// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
    /// much resource a node has.
    /// </summary>
    public partial class NodeTypePropertiesCapacities :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacities,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypePropertiesCapacitiesInternal
    {

        /// <summary>Creates an new <see cref="NodeTypePropertiesCapacities" /> instance.</summary>
        public NodeTypePropertiesCapacities()
        {

        }
    }
    /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
    /// much resource a node has.
    public partial interface INodeTypePropertiesCapacities :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IAssociativeArray<string>
    {

    }
    /// The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how
    /// much resource a node has.
    internal partial interface INodeTypePropertiesCapacitiesInternal

    {

    }
}