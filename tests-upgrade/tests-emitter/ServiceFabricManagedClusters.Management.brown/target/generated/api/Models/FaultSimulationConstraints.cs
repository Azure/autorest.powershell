// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Constraints for Fault Simulation action.</summary>
    public partial class FaultSimulationConstraints :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraintsInternal
    {

        /// <summary>Backing field for <see cref="ExpirationTime" /> property.</summary>
        private global::System.DateTime? _expirationTime;

        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? ExpirationTime { get => this._expirationTime; set => this._expirationTime = value; }

        /// <summary>Creates an new <see cref="FaultSimulationConstraints" /> instance.</summary>
        public FaultSimulationConstraints()
        {

        }
    }
    /// Constraints for Fault Simulation action.
    public partial interface IFaultSimulationConstraints :
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
        global::System.DateTime? ExpirationTime { get; set; }

    }
    /// Constraints for Fault Simulation action.
    internal partial interface IFaultSimulationConstraintsInternal

    {
        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        global::System.DateTime? ExpirationTime { get; set; }

    }
}