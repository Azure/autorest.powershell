// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>Properties of a Gate that can be patched.</summary>
    public partial class GatePatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The state of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="GatePatchProperties" /> instance.</summary>
        public GatePatchProperties()
        {

        }
    }
    /// Properties of a Gate that can be patched.
    public partial interface IGatePatchProperties :
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
    /// Properties of a Gate that can be patched.
    internal partial interface IGatePatchPropertiesInternal

    {
        /// <summary>The state of the Gate.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Pending", "Skipped", "Completed")]
        string State { get; set; }

    }
}