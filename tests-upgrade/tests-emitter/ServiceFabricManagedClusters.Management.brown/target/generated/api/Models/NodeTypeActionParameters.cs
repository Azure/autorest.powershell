// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Parameters for Node type action. If nodes are not specified on the parameters, the operation will be performed in all
    /// nodes of the node type one upgrade domain at a time.
    /// </summary>
    public partial class NodeTypeActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeActionParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeActionParametersInternal
    {

        /// <summary>Backing field for <see cref="Force" /> property.</summary>
        private bool? _force;

        /// <summary>Force the action to go through.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? Force { get => this._force; set => this._force = value; }

        /// <summary>Backing field for <see cref="Node" /> property.</summary>
        private System.Collections.Generic.List<string> _node;

        /// <summary>List of node names from the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Node { get => this._node; set => this._node = value; }

        /// <summary>Backing field for <see cref="UpdateType" /> property.</summary>
        private string _updateType;

        /// <summary>Specifies the way the operation will be performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string UpdateType { get => this._updateType; set => this._updateType = value; }

        /// <summary>Creates an new <see cref="NodeTypeActionParameters" /> instance.</summary>
        public NodeTypeActionParameters()
        {

        }
    }
    /// Parameters for Node type action. If nodes are not specified on the parameters, the operation will be performed in all
    /// nodes of the node type one upgrade domain at a time.
    public partial interface INodeTypeActionParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Force the action to go through.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Force the action to go through.",
        SerializedName = @"force",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Force { get; set; }
        /// <summary>List of node names from the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of node names from the node type.",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Node { get; set; }
        /// <summary>Specifies the way the operation will be performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the way the operation will be performed.",
        SerializedName = @"updateType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Default", "ByUpgradeDomain")]
        string UpdateType { get; set; }

    }
    /// Parameters for Node type action. If nodes are not specified on the parameters, the operation will be performed in all
    /// nodes of the node type one upgrade domain at a time.
    internal partial interface INodeTypeActionParametersInternal

    {
        /// <summary>Force the action to go through.</summary>
        bool? Force { get; set; }
        /// <summary>List of node names from the node type.</summary>
        System.Collections.Generic.List<string> Node { get; set; }
        /// <summary>Specifies the way the operation will be performed.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Default", "ByUpgradeDomain")]
        string UpdateType { get; set; }

    }
}