// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>Agent profile for the Fleet hub.</summary>
    public partial class AgentProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAgentProfileInternal
    {

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private string _vMSize;

        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>Creates an new <see cref="AgentProfile" /> instance.</summary>
        public AgentProfile()
        {

        }
    }
    /// Agent profile for the Fleet hub.
    public partial interface IAgentProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be generated and used.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The virtual machine size of the Fleet hub.",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VMSize { get; set; }

    }
    /// Agent profile for the Fleet hub.
    internal partial interface IAgentProfileInternal

    {
        /// <summary>
        /// The ID of the subnet which the Fleet hub node will join on startup. If this is not specified, a vnet and subnet will be
        /// generated and used.
        /// </summary>
        string SubnetId { get; set; }
        /// <summary>The virtual machine size of the Fleet hub.</summary>
        string VMSize { get; set; }

    }
}