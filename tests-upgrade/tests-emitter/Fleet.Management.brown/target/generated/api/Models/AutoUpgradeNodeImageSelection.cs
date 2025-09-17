// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
    public partial class AutoUpgradeNodeImageSelection :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelectionInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="AutoUpgradeNodeImageSelection" /> instance.</summary>
        public AutoUpgradeNodeImageSelection()
        {

        }
    }
    /// The node image upgrade to be applied to the target clusters in auto upgrade.
    public partial interface IAutoUpgradeNodeImageSelection :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The node image upgrade type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent")]
        string Type { get; set; }

    }
    /// The node image upgrade to be applied to the target clusters in auto upgrade.
    internal partial interface IAutoUpgradeNodeImageSelectionInternal

    {
        /// <summary>The node image upgrade type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent")]
        string Type { get; set; }

    }
}