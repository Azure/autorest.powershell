// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Fault Simulation Request for Start action.</summary>
    public partial class FaultSimulationContentWrapper :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentWrapper,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentWrapperInternal
    {

        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public global::System.DateTime? ConstraintExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).ConstraintExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).ConstraintExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentWrapperInternal.Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationContent()); set { {_parameter = value;} } }

        /// <summary>Internal Acessors for ParameterConstraint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentWrapperInternal.ParameterConstraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Constraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Constraint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ParameterFaultKind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentWrapperInternal.ParameterFaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).FaultKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).FaultKind = value ; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent _parameter;

        /// <summary>Parameters for Fault Simulation start action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Parameter { get => (this._parameter = this._parameter ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationContent()); set => this._parameter = value; }

        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string ParameterFaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).FaultKind; }

        /// <summary>Force the action to go through without any check on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public bool? ParameterForce { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Force; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)Parameter).Force = value ?? default(bool); }

        /// <summary>Creates an new <see cref="FaultSimulationContentWrapper" /> instance.</summary>
        public FaultSimulationContentWrapper()
        {

        }
    }
    /// Fault Simulation Request for Start action.
    public partial interface IFaultSimulationContentWrapper :
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
        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
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
    /// Fault Simulation Request for Start action.
    internal partial interface IFaultSimulationContentWrapperInternal

    {
        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        global::System.DateTime? ConstraintExpirationTime { get; set; }
        /// <summary>Parameters for Fault Simulation start action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent Parameter { get; set; }
        /// <summary>Constraints for Fault Simulation action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints ParameterConstraint { get; set; }
        /// <summary>The kind of fault to be simulated.</summary>
        string ParameterFaultKind { get; set; }
        /// <summary>Force the action to go through without any check on the cluster.</summary>
        bool? ParameterForce { get; set; }

    }
}