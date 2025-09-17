// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>Patch a Gate resource.</summary>
    public partial class GatePatch :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatch,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GatePatchProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchProperties _property;

        /// <summary>Properties of a Gate that can be patched.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GatePatchProperties()); set => this._property = value; }

        /// <summary>The state of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchPropertiesInternal)Property).State = value ; }

        /// <summary>Creates an new <see cref="GatePatch" /> instance.</summary>
        public GatePatch()
        {

        }
    }
    /// Patch a Gate resource.
    public partial interface IGatePatch :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The state of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The state of the Gate.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Pending", "Skipped", "Completed")]
        string State { get; set; }

    }
    /// Patch a Gate resource.
    internal partial interface IGatePatchInternal

    {
        /// <summary>Properties of a Gate that can be patched.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchProperties Property { get; set; }
        /// <summary>The state of the Gate.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Pending", "Skipped", "Completed")]
        string State { get; set; }

    }
}