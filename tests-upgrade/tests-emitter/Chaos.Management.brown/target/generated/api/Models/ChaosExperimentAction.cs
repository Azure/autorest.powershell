// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents the base action model. 9 total per experiment.</summary>
    public partial class ChaosExperimentAction :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentAction,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosExperimentActionInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>String that represents a Capability URN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Chaos experiment action discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ChaosExperimentAction" /> instance.</summary>
        public ChaosExperimentAction()
        {

        }
    }
    /// Model that represents the base action model. 9 total per experiment.
    public partial interface IChaosExperimentAction :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>String that represents a Capability URN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a Capability URN.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Chaos experiment action discriminator type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Chaos experiment action discriminator type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Chaos.PSArgumentCompleterAttribute("delay", "discrete", "continuous")]
        string Type { get; set; }

    }
    /// Model that represents the base action model. 9 total per experiment.
    internal partial interface IChaosExperimentActionInternal

    {
        /// <summary>String that represents a Capability URN.</summary>
        string Name { get; set; }
        /// <summary>Chaos experiment action discriminator type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Chaos.PSArgumentCompleterAttribute("delay", "discrete", "continuous")]
        string Type { get; set; }

    }
}