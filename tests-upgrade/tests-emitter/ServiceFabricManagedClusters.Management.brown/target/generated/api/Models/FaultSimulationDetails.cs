// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Details for Fault Simulation.</summary>
    public partial class FaultSimulationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetails,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal
    {

        /// <summary>Backing field for <see cref="ClusterId" /> property.</summary>
        private string _clusterId;

        /// <summary>unique identifier for the cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterId { get => this._clusterId; set => this._clusterId = value; }

        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public global::System.DateTime? ConstraintExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).ConstraintExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).ConstraintExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationContent()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterConstraint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal.ParameterConstraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Constraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Constraint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ParameterFaultKind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal.ParameterFaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).FaultKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).FaultKind = value ?? null; }

        /// <summary>Backing field for <see cref="NodeTypeFaultSimulation" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> _nodeTypeFaultSimulation;

        /// <summary>List of node type simulations associated with the cluster fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> NodeTypeFaultSimulation { get => this._nodeTypeFaultSimulation; set => this._nodeTypeFaultSimulation = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>unique identifier for the operation associated with the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent _parameter;

        /// <summary>Fault simulation parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationContent()); set => this._parameter = value; }

        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ParameterFaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).FaultKind; }

        /// <summary>Force the action to go through without any check on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ParameterForce { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Force; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Force = value ?? default(bool); }

        /// <summary>Creates an new <see cref="FaultSimulationDetails" /> instance.</summary>
        public FaultSimulationDetails()
        {

        }
    }
    /// Details for Fault Simulation.
    public partial interface IFaultSimulationDetails :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>unique identifier for the cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"unique identifier for the cluster resource.",
        SerializedName = @"clusterId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterId { get; set; }
        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.",
        SerializedName = @"expirationTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ConstraintExpirationTime { get; set; }
        /// <summary>List of node type simulations associated with the cluster fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of node type simulations associated with the cluster fault simulation.",
        SerializedName = @"nodeTypeFaultSimulation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> NodeTypeFaultSimulation { get; set; }
        /// <summary>unique identifier for the operation associated with the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"unique identifier for the operation associated with the fault simulation.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The kind of fault to be simulated.",
        SerializedName = @"faultKind",
        PossibleTypes = new [] { typeof(string) })]
        string ParameterFaultKind { get;  }
        /// <summary>Force the action to go through without any check on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Force the action to go through without any check on the cluster.",
        SerializedName = @"force",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ParameterForce { get; set; }

    }
    /// Details for Fault Simulation.
    internal partial interface IFaultSimulationDetailsInternal

    {
        /// <summary>unique identifier for the cluster resource.</summary>
        string ClusterId { get; set; }
        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        global::System.DateTime? ConstraintExpirationTime { get; set; }
        /// <summary>List of node type simulations associated with the cluster fault simulation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> NodeTypeFaultSimulation { get; set; }
        /// <summary>unique identifier for the operation associated with the fault simulation.</summary>
        string OperationId { get; set; }
        /// <summary>Fault simulation parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Parameter { get; set; }
        /// <summary>Constraints for Fault Simulation action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints ParameterConstraint { get; set; }
        /// <summary>The kind of fault to be simulated.</summary>
        string ParameterFaultKind { get; set; }
        /// <summary>Force the action to go through without any check on the cluster.</summary>
        bool? ParameterForce { get; set; }

    }
}