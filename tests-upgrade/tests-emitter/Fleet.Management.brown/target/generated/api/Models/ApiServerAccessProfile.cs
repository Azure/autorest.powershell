// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>Access profile for the Fleet hub API server.</summary>
    public partial class ApiServerAccessProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IApiServerAccessProfileInternal
    {

        /// <summary>Backing field for <see cref="EnablePrivateCluster" /> property.</summary>
        private bool? _enablePrivateCluster;

        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public bool? EnablePrivateCluster { get => this._enablePrivateCluster; set => this._enablePrivateCluster = value; }

        /// <summary>Backing field for <see cref="EnableVnetIntegration" /> property.</summary>
        private bool? _enableVnetIntegration;

        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public bool? EnableVnetIntegration { get => this._enableVnetIntegration; set => this._enableVnetIntegration = value; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Creates an new <see cref="ApiServerAccessProfile" /> instance.</summary>
        public ApiServerAccessProfile()
        {

        }
    }
    /// Access profile for the Fleet hub API server.
    public partial interface IApiServerAccessProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to create the Fleet hub as a private cluster or not.",
        SerializedName = @"enablePrivateCluster",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether to enable apiserver vnet integration for the Fleet hub or not.",
        SerializedName = @"enableVnetIntegration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }

    }
    /// Access profile for the Fleet hub API server.
    internal partial interface IApiServerAccessProfileInternal

    {
        /// <summary>Whether to create the Fleet hub as a private cluster or not.</summary>
        bool? EnablePrivateCluster { get; set; }
        /// <summary>Whether to enable apiserver vnet integration for the Fleet hub or not.</summary>
        bool? EnableVnetIntegration { get; set; }
        /// <summary>
        /// The subnet to be used when apiserver vnet integration is enabled. It is required when creating a new Fleet with BYO vnet.
        /// </summary>
        string SubnetId { get; set; }

    }
}