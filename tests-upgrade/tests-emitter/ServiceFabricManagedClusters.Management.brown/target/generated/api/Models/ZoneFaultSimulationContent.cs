// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Parameters for Zone Fault Simulation action.</summary>
    public partial class ZoneFaultSimulationContent :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContent,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContentInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent __faultSimulationContent = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationContent();

        /// <summary>Constraints for Fault Simulation action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Constraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).Constraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).Constraint = value ?? null /* model class */; }

        /// <summary>
        /// The absolute expiration timestamp (UTC) after which this fault simulation should be stopped if it's still active.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public global::System.DateTime? ConstraintExpirationTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).ConstraintExpirationTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).ConstraintExpirationTime = value ?? default(global::System.DateTime); }

        /// <summary>The kind of fault to be simulated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public string FaultKind { get => "Zone"; }

        /// <summary>Force the action to go through without any check on the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inherited)]
        public bool? Force { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).Force; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).Force = value ?? default(bool); }

        /// <summary>Internal Acessors for Constraint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal.Constraint { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).Constraint; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).Constraint = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FaultKind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal.FaultKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).FaultKind; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)__faultSimulationContent).FaultKind = value ; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private System.Collections.Generic.List<string> _zone;

        /// <summary>Indicates the zones of the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Zone { get => this._zone; set => this._zone = value; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__faultSimulationContent), __faultSimulationContent);
            await eventListener.AssertObjectIsValid(nameof(__faultSimulationContent), __faultSimulationContent);
        }

        /// <summary>Creates an new <see cref="ZoneFaultSimulationContent" /> instance.</summary>
        public ZoneFaultSimulationContent()
        {

        }
    }
    /// Parameters for Zone Fault Simulation action.
    public partial interface IZoneFaultSimulationContent :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContent
    {
        /// <summary>Indicates the zones of the fault simulation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the zones of the fault simulation.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Zone { get; set; }

    }
    /// Parameters for Zone Fault Simulation action.
    internal partial interface IZoneFaultSimulationContentInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal
    {
        /// <summary>Indicates the zones of the fault simulation.</summary>
        System.Collections.Generic.List<string> Zone { get; set; }

    }
}