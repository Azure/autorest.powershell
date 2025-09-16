// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Specifies the settings for a network interface to attach to the node type.</summary>
    public partial class AdditionalNetworkInterfaceConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfigurationInternal
    {

        /// <summary>Backing field for <see cref="DscpConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource _dscpConfiguration;

        /// <summary>Specifies the DSCP configuration to apply to the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource DscpConfiguration { get => (this._dscpConfiguration = this._dscpConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource()); set => this._dscpConfiguration = value; }

        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DscpConfigurationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResourceInternal)DscpConfiguration).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResourceInternal)DscpConfiguration).Id = value ?? null; }

        /// <summary>Backing field for <see cref="EnableAcceleratedNetworking" /> property.</summary>
        private bool? _enableAcceleratedNetworking;

        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableAcceleratedNetworking { get => this._enableAcceleratedNetworking; set => this._enableAcceleratedNetworking = value; }

        /// <summary>Backing field for <see cref="IPConfiguration" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration> _iPConfiguration;

        /// <summary>Specifies the IP configurations of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration> IPConfiguration { get => this._iPConfiguration; set => this._iPConfiguration = value; }

        /// <summary>Internal Acessors for DscpConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAdditionalNetworkInterfaceConfigurationInternal.DscpConfiguration { get => (this._dscpConfiguration = this._dscpConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource()); set { {_dscpConfiguration = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="AdditionalNetworkInterfaceConfiguration" /> instance.</summary>
        public AdditionalNetworkInterfaceConfiguration()
        {

        }
    }
    /// Specifies the settings for a network interface to attach to the node type.
    public partial interface IAdditionalNetworkInterfaceConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string DscpConfigurationId { get; set; }
        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the network interface is accelerated networking-enabled.",
        SerializedName = @"enableAcceleratedNetworking",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAcceleratedNetworking { get; set; }
        /// <summary>Specifies the IP configurations of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the IP configurations of the network interface.",
        SerializedName = @"ipConfigurations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration> IPConfiguration { get; set; }
        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the network interface.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Specifies the settings for a network interface to attach to the node type.
    internal partial interface IAdditionalNetworkInterfaceConfigurationInternal

    {
        /// <summary>Specifies the DSCP configuration to apply to the network interface.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource DscpConfiguration { get; set; }
        /// <summary>Azure resource identifier.</summary>
        string DscpConfigurationId { get; set; }
        /// <summary>Specifies whether the network interface is accelerated networking-enabled.</summary>
        bool? EnableAcceleratedNetworking { get; set; }
        /// <summary>Specifies the IP configurations of the network interface.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration> IPConfiguration { get; set; }
        /// <summary>Name of the network interface.</summary>
        string Name { get; set; }

    }
}