// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The properties of the Update Run that the Gate is targeting.</summary>
    public partial class UpdateRunGateTargetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private string _group;

        /// <summary>The Update Group of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Group { get => this._group; }

        /// <summary>Internal Acessors for Group</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal.Group { get => this._group; set { {_group = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Stage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal.Stage { get => this._stage; set { {_stage = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Stage" /> property.</summary>
        private string _stage;

        /// <summary>The Update Stage of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Stage { get => this._stage; }

        /// <summary>Backing field for <see cref="Timing" /> property.</summary>
        private string _timing;

        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Timing { get => this._timing; set => this._timing = value; }

        /// <summary>Creates an new <see cref="UpdateRunGateTargetProperties" /> instance.</summary>
        public UpdateRunGateTargetProperties()
        {

        }
    }
    /// The properties of the Update Run that the Gate is targeting.
    public partial interface IUpdateRunGateTargetProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The Update Group of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Update Group of the Update Run.",
        SerializedName = @"group",
        PossibleTypes = new [] { typeof(string) })]
        string Group { get;  }
        /// <summary>The name of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the Update Run.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>The Update Stage of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Update Stage of the Update Run.",
        SerializedName = @"stage",
        PossibleTypes = new [] { typeof(string) })]
        string Stage { get;  }
        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether the Gate is placed before or after the update itself.",
        SerializedName = @"timing",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Before", "After")]
        string Timing { get; set; }

    }
    /// The properties of the Update Run that the Gate is targeting.
    internal partial interface IUpdateRunGateTargetPropertiesInternal

    {
        /// <summary>The Update Group of the Update Run.</summary>
        string Group { get; set; }
        /// <summary>The name of the Update Run.</summary>
        string Name { get; set; }
        /// <summary>The Update Stage of the Update Run.</summary>
        string Stage { get; set; }
        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Before", "After")]
        string Timing { get; set; }

    }
}