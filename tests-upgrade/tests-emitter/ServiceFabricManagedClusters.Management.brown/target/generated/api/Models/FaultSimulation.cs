// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Fault simulation object with status.</summary>
    public partial class FaultSimulation :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulation,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationInternal
    {

        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public global::System.DateTime? ConstraintExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ConstraintExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ConstraintExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetails _detail;

        /// <summary>Fault simulation details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetails Detail { get => (this._detail = this._detail ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationDetails()); set => this._detail = value; }

        /// <summary>unique identifier for the cluster resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DetailClusterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ClusterId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ClusterId = value ?? null; }

        /// <summary>List of node type simulations associated with the cluster fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> DetailNodeTypeFaultSimulation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).NodeTypeFaultSimulation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).NodeTypeFaultSimulation = value ?? null /* arrayOf */; }

        /// <summary>unique identifier for the operation associated with the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).OperationId = value ?? null; }

        /// <summary>Fault simulation parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent DetailParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).Parameter = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The end time of the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetails Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationInternal.Detail { get => (this._detail = this._detail ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationDetails()); set { {_detail = value;} } }

        /// <summary>Internal Acessors for DetailParameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationInternal.DetailParameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).Parameter = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ParameterConstraint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationInternal.ParameterConstraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterConstraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterConstraint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ParameterFaultKind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationInternal.ParameterFaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterFaultKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterFaultKind = value ?? null; }

        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ParameterFaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterFaultKind; }

        /// <summary>Force the action to go through without any check on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ParameterForce { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterForce; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetailsInternal)Detail).ParameterForce = value ?? default(bool); }

        /// <summary>Backing field for <see cref="SimulationId" /> property.</summary>
        private string _simulationId;

        /// <summary>unique identifier for the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SimulationId { get => this._simulationId; set => this._simulationId = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time of the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Fault simulation status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="FaultSimulation" /> instance.</summary>
        public FaultSimulation()
        {

        }
    }
    /// Fault simulation object with status.
    public partial interface IFaultSimulation :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
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
        string DetailClusterId { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> DetailNodeTypeFaultSimulation { get; set; }
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
        string DetailOperationId { get; set; }
        /// <summary>The end time of the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The end time of the fault simulation.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
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
        /// <summary>unique identifier for the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"unique identifier for the fault simulation.",
        SerializedName = @"simulationId",
        PossibleTypes = new [] { typeof(string) })]
        string SimulationId { get; set; }
        /// <summary>The start time of the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The start time of the fault simulation.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
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
    /// Fault simulation object with status.
    internal partial interface IFaultSimulationInternal

    {
        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        global::System.DateTime? ConstraintExpirationTime { get; set; }
        /// <summary>Fault simulation details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationDetails Detail { get; set; }
        /// <summary>unique identifier for the cluster resource.</summary>
        string DetailClusterId { get; set; }
        /// <summary>List of node type simulations associated with the cluster fault simulation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeFaultSimulation> DetailNodeTypeFaultSimulation { get; set; }
        /// <summary>unique identifier for the operation associated with the fault simulation.</summary>
        string DetailOperationId { get; set; }
        /// <summary>Fault simulation parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent DetailParameter { get; set; }
        /// <summary>The end time of the fault simulation.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Constraints for Fault Simulation action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints ParameterConstraint { get; set; }
        /// <summary>The kind of fault to be simulated.</summary>
        string ParameterFaultKind { get; set; }
        /// <summary>Force the action to go through without any check on the cluster.</summary>
        bool? ParameterForce { get; set; }
        /// <summary>unique identifier for the fault simulation.</summary>
        string SimulationId { get; set; }
        /// <summary>The start time of the fault simulation.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Fault simulation status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("Starting", "Active", "Stopping", "Done", "StartFailed", "StopFailed")]
        string Status { get; set; }

    }
}