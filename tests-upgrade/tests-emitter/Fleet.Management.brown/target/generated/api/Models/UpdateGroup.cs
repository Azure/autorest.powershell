// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>A group to be updated.</summary>
    public partial class UpdateGroup :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroup,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateGroupInternal
    {

        /// <summary>Backing field for <see cref="AfterGate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> _afterGate;

        /// <summary>A list of Gates that will be created after this Group is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> AfterGate { get => this._afterGate; set => this._afterGate = value; }

        /// <summary>Backing field for <see cref="BeforeGate" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> _beforeGate;

        /// <summary>A list of Gates that will be created before this Group is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> BeforeGate { get => this._beforeGate; set => this._beforeGate = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// Name of the group.
        /// It must match a group name of an existing fleet member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="UpdateGroup" /> instance.</summary>
        public UpdateGroup()
        {

        }
    }
    /// A group to be updated.
    public partial interface IUpdateGroup :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>A list of Gates that will be created after this Group is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of Gates that will be created after this Group is executed.",
        SerializedName = @"afterGates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> AfterGate { get; set; }
        /// <summary>A list of Gates that will be created before this Group is executed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of Gates that will be created before this Group is executed.",
        SerializedName = @"beforeGates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> BeforeGate { get; set; }
        /// <summary>
        /// Name of the group.
        /// It must match a group name of an existing fleet member.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the group.
        It must match a group name of an existing fleet member. ",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// A group to be updated.
    internal partial interface IUpdateGroupInternal

    {
        /// <summary>A list of Gates that will be created after this Group is executed.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> AfterGate { get; set; }
        /// <summary>A list of Gates that will be created before this Group is executed.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration> BeforeGate { get; set; }
        /// <summary>
        /// Name of the group.
        /// It must match a group name of an existing fleet member.
        /// </summary>
        string Name { get; set; }

    }
}