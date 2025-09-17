// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Parameters for Fault Simulation id.</summary>
    public partial class FaultSimulationIdContent :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationIdContent,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationIdContentInternal
    {

        /// <summary>Backing field for <see cref="SimulationId" /> property.</summary>
        private string _simulationId;

        /// <summary>unique identifier for the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SimulationId { get => this._simulationId; set => this._simulationId = value; }

        /// <summary>Creates an new <see cref="FaultSimulationIdContent" /> instance.</summary>
        public FaultSimulationIdContent()
        {

        }
    }
    /// Parameters for Fault Simulation id.
    public partial interface IFaultSimulationIdContent :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>unique identifier for the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"unique identifier for the fault simulation.",
        SerializedName = @"simulationId",
        PossibleTypes = new [] { typeof(string) })]
        string SimulationId { get; set; }

    }
    /// Parameters for Fault Simulation id.
    internal partial interface IFaultSimulationIdContentInternal

    {
        /// <summary>unique identifier for the fault simulation.</summary>
        string SimulationId { get; set; }

    }
}