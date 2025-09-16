// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Provides information about NAT configuration on the default public Load Balancer for the node type.
    /// </summary>
    public partial class NodeTypeNatConfig :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfig,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INodeTypeNatConfigInternal
    {

        /// <summary>Backing field for <see cref="BackendPort" /> property.</summary>
        private int? _backendPort;

        /// <summary>The internal port for the NAT configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? BackendPort { get => this._backendPort; set => this._backendPort = value; }

        /// <summary>Backing field for <see cref="FrontendPortRangeEnd" /> property.</summary>
        private int? _frontendPortRangeEnd;

        /// <summary>The port range end for the external endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? FrontendPortRangeEnd { get => this._frontendPortRangeEnd; set => this._frontendPortRangeEnd = value; }

        /// <summary>Backing field for <see cref="FrontendPortRangeStart" /> property.</summary>
        private int? _frontendPortRangeStart;

        /// <summary>The port range start for the external endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? FrontendPortRangeStart { get => this._frontendPortRangeStart; set => this._frontendPortRangeStart = value; }

        /// <summary>Creates an new <see cref="NodeTypeNatConfig" /> instance.</summary>
        public NodeTypeNatConfig()
        {

        }
    }
    /// Provides information about NAT configuration on the default public Load Balancer for the node type.
    public partial interface INodeTypeNatConfig :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The internal port for the NAT configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The internal port for the NAT configuration.",
        SerializedName = @"backendPort",
        PossibleTypes = new [] { typeof(int) })]
        int? BackendPort { get; set; }
        /// <summary>The port range end for the external endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port range end for the external endpoint.",
        SerializedName = @"frontendPortRangeEnd",
        PossibleTypes = new [] { typeof(int) })]
        int? FrontendPortRangeEnd { get; set; }
        /// <summary>The port range start for the external endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port range start for the external endpoint.",
        SerializedName = @"frontendPortRangeStart",
        PossibleTypes = new [] { typeof(int) })]
        int? FrontendPortRangeStart { get; set; }

    }
    /// Provides information about NAT configuration on the default public Load Balancer for the node type.
    internal partial interface INodeTypeNatConfigInternal

    {
        /// <summary>The internal port for the NAT configuration.</summary>
        int? BackendPort { get; set; }
        /// <summary>The port range end for the external endpoint.</summary>
        int? FrontendPortRangeEnd { get; set; }
        /// <summary>The port range start for the external endpoint.</summary>
        int? FrontendPortRangeStart { get; set; }

    }
}