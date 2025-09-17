// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a Subnet.</summary>
    public partial class Subnet :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnet,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubnetInternal
    {

        /// <summary>Backing field for <see cref="EnableIpv6" /> property.</summary>
        private bool? _enableIpv6;

        /// <summary>
        /// Indicates wether to enable Ipv6 or not. If not provided, it will take the same configuration as the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableIpv6 { get => this._enableIpv6; set => this._enableIpv6 = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NetworkSecurityGroupId" /> property.</summary>
        private string _networkSecurityGroupId;

        /// <summary>Full resource id for the network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string NetworkSecurityGroupId { get => this._networkSecurityGroupId; set => this._networkSecurityGroupId = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointNetworkPolicy" /> property.</summary>
        private string _privateEndpointNetworkPolicy;

        /// <summary>Enable or Disable apply network policies on private end point in the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PrivateEndpointNetworkPolicy { get => this._privateEndpointNetworkPolicy; set => this._privateEndpointNetworkPolicy = value; }

        /// <summary>Backing field for <see cref="PrivateLinkServiceNetworkPolicy" /> property.</summary>
        private string _privateLinkServiceNetworkPolicy;

        /// <summary>Enable or Disable apply network policies on private link service in the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PrivateLinkServiceNetworkPolicy { get => this._privateLinkServiceNetworkPolicy; set => this._privateLinkServiceNetworkPolicy = value; }

        /// <summary>Creates an new <see cref="Subnet" /> instance.</summary>
        public Subnet()
        {

        }
    }
    /// Describes a Subnet.
    public partial interface ISubnet :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Indicates wether to enable Ipv6 or not. If not provided, it will take the same configuration as the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates wether to enable Ipv6 or not. If not provided, it will take the same configuration as the cluster.",
        SerializedName = @"enableIpv6",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableIpv6 { get; set; }
        /// <summary>Subnet name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subnet name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Full resource id for the network security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Full resource id for the network security group.",
        SerializedName = @"networkSecurityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityGroupId { get; set; }
        /// <summary>Enable or Disable apply network policies on private end point in the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable or Disable apply network policies on private end point in the subnet.",
        SerializedName = @"privateEndpointNetworkPolicies",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("enabled", "disabled")]
        string PrivateEndpointNetworkPolicy { get; set; }
        /// <summary>Enable or Disable apply network policies on private link service in the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable or Disable apply network policies on private link service in the subnet.",
        SerializedName = @"privateLinkServiceNetworkPolicies",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("enabled", "disabled")]
        string PrivateLinkServiceNetworkPolicy { get; set; }

    }
    /// Describes a Subnet.
    internal partial interface ISubnetInternal

    {
        /// <summary>
        /// Indicates wether to enable Ipv6 or not. If not provided, it will take the same configuration as the cluster.
        /// </summary>
        bool? EnableIpv6 { get; set; }
        /// <summary>Subnet name.</summary>
        string Name { get; set; }
        /// <summary>Full resource id for the network security group.</summary>
        string NetworkSecurityGroupId { get; set; }
        /// <summary>Enable or Disable apply network policies on private end point in the subnet.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("enabled", "disabled")]
        string PrivateEndpointNetworkPolicy { get; set; }
        /// <summary>Enable or Disable apply network policies on private link service in the subnet.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("enabled", "disabled")]
        string PrivateLinkServiceNetworkPolicy { get; set; }

    }
}