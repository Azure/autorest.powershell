// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Node type fault simulation object with status.</summary>
    public partial class NodeTypeFaultSimulation :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulationInternal
    {

        /// <summary>Backing field for <see cref="NodeTypeName" /> property.</summary>
        private string _nodeTypeName;

        /// <summary>Node type name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string NodeTypeName { get => this._nodeTypeName; set => this._nodeTypeName = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>Current or latest asynchronous operation identifier on the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="OperationStatus" /> property.</summary>
        private string _operationStatus;

        /// <summary>Current or latest asynchronous operation status on the node type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string OperationStatus { get => this._operationStatus; set => this._operationStatus = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Fault simulation status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="NodeTypeFaultSimulation" /> instance.</summary>
        public NodeTypeFaultSimulation()
        {

        }
    }
    /// Node type fault simulation object with status.
    public partial interface INodeTypeFaultSimulation :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Node type name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Node type name.",
        SerializedName = @"nodeTypeName",
        PossibleTypes = new [] { typeof(string) })]
        string NodeTypeName { get; set; }
        /// <summary>Current or latest asynchronous operation identifier on the node type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current or latest asynchronous operation identifier on the node type.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>Current or latest asynchronous operation status on the node type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current or latest asynchronous operation status on the node type",
        SerializedName = @"operationStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Created", "Started", "Succeeded", "Failed", "Aborted", "Canceled")]
        string OperationStatus { get; set; }
        /// <summary>Fault simulation status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fault simulation status",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Starting", "Active", "Stopping", "Done", "StartFailed", "StopFailed")]
        string Status { get; set; }

    }
    /// Node type fault simulation object with status.
    internal partial interface INodeTypeFaultSimulationInternal

    {
        /// <summary>Node type name.</summary>
        string NodeTypeName { get; set; }
        /// <summary>Current or latest asynchronous operation identifier on the node type.</summary>
        string OperationId { get; set; }
        /// <summary>Current or latest asynchronous operation status on the node type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Created", "Started", "Succeeded", "Failed", "Aborted", "Canceled")]
        string OperationStatus { get; set; }
        /// <summary>Fault simulation status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Starting", "Active", "Stopping", "Done", "StartFailed", "StopFailed")]
        string Status { get; set; }

    }
}