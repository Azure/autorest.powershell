// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Parameters for Fault Simulation action.</summary>
    public partial class FaultSimulationContent :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal
    {

        /// <summary>Backing field for <see cref="Constraint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints _constraint;

        /// <summary>Constraints for Fault Simulation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Constraint { get => (this._constraint = this._constraint ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationConstraints()); set => this._constraint = value; }

        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public global::System.DateTime? ConstraintExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraintsInternal)Constraint).ExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraintsInternal)Constraint).ExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="FaultKind" /> property.</summary>
        private string _faultKind= @"Zone";

        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string FaultKind { get => this._faultKind; }

        /// <summary>Backing field for <see cref="Force" /> property.</summary>
        private bool? _force;

        /// <summary>Force the action to go through without any check on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? Force { get => this._force; set => this._force = value; }

        /// <summary>Internal Acessors for Constraint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal.Constraint { get => (this._constraint = this._constraint ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationConstraints()); set { {_constraint = value;} } }

        /// <summary>Internal Acessors for FaultKind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal.FaultKind { get => this._faultKind; set { {_faultKind = value;} } }

        /// <summary>Creates an new <see cref="FaultSimulationContent" /> instance.</summary>
        public FaultSimulationContent()
        {

        }
    }
    /// Parameters for Fault Simulation action.
    public partial interface IFaultSimulationContent :
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
        string FaultKind { get;  }
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
        bool? Force { get; set; }

    }
    /// Parameters for Fault Simulation action.
    internal partial interface IFaultSimulationContentInternal

    {
        /// <summary>Constraints for Fault Simulation action.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Constraint { get; set; }
        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        global::System.DateTime? ConstraintExpirationTime { get; set; }
        /// <summary>The kind of fault to be simulated.</summary>
        string FaultKind { get; set; }
        /// <summary>Force the action to go through without any check on the cluster.</summary>
        bool? Force { get; set; }

    }
}