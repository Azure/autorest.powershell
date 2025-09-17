// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The properties of a skip operation containing multiple skip requests.</summary>
    public partial class SkipProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTarget> _target;

        /// <summary>The targets to skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTarget> Target { get => this._target; set => this._target = value; }

        /// <summary>Creates an new <see cref="SkipProperties" /> instance.</summary>
        public SkipProperties()
        {

        }
    }
    /// The properties of a skip operation containing multiple skip requests.
    public partial interface ISkipProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The targets to skip.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The targets to skip.",
        SerializedName = @"targets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTarget) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTarget> Target { get; set; }

    }
    /// The properties of a skip operation containing multiple skip requests.
    internal partial interface ISkipPropertiesInternal

    {
        /// <summary>The targets to skip.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ISkipTarget> Target { get; set; }

    }
}