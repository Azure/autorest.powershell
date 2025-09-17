// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Specifies an IP configuration of the network interface.</summary>
    public partial class IPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGatewayBackendAddressPool" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> _applicationGatewayBackendAddressPool;

        /// <summary>
        /// Specifies an array of references to backend address pools of application gateways. A node type can reference backend address
        /// pools of multiple application gateways. Multiple node types cannot use the same application gateway.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> ApplicationGatewayBackendAddressPool { get => this._applicationGatewayBackendAddressPool; set => this._applicationGatewayBackendAddressPool = value; }

        /// <summary>Backing field for <see cref="LoadBalancerBackendAddressPool" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> _loadBalancerBackendAddressPool;

        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A node type can reference backend address
        /// pools of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> LoadBalancerBackendAddressPool { get => this._loadBalancerBackendAddressPool; set => this._loadBalancerBackendAddressPool = value; }

        /// <summary>Backing field for <see cref="LoadBalancerInboundNatPool" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> _loadBalancerInboundNatPool;

        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A node type can reference inbound nat pools
        /// of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> LoadBalancerInboundNatPool { get => this._loadBalancerInboundNatPool; set => this._loadBalancerInboundNatPool = value; }

        /// <summary>Internal Acessors for PublicIPAddressConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal.PublicIPAddressConfiguration { get => (this._publicIPAddressConfiguration = this._publicIPAddressConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PublicIPAddressConfiguration()); set { {_publicIPAddressConfiguration = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfigurationInternal.Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource()); set { {_subnet = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PrivateIPAddressVersion" /> property.</summary>
        private string _privateIPAddressVersion;

        /// <summary>
        /// Specifies whether the IP configuration's private IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PrivateIPAddressVersion { get => this._privateIPAddressVersion; set => this._privateIPAddressVersion = value; }

        /// <summary>Backing field for <see cref="PublicIPAddressConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration _publicIPAddressConfiguration;

        /// <summary>The public IP address configuration of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration PublicIPAddressConfiguration { get => (this._publicIPAddressConfiguration = this._publicIPAddressConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PublicIPAddressConfiguration()); set => this._publicIPAddressConfiguration = value; }

        /// <summary>Specifies the list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> PublicIPAddressConfigurationIptag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).IPTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).IPTag = value ?? null /* arrayOf */; }

        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string PublicIPAddressConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Name = value ?? null; }

        /// <summary>
        /// Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string PublicIPAddressConfigurationPublicIpaddressVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPAddressVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPAddressVersion = value ?? null; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource _subnet;

        /// <summary>Specifies the subnet of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource()); set => this._subnet = value; }

        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResourceInternal)Subnet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResourceInternal)Subnet).Id = value ?? null; }

        /// <summary>Creates an new <see cref="IPConfiguration" /> instance.</summary>
        public IPConfiguration()
        {

        }
    }
    /// Specifies an IP configuration of the network interface.
    public partial interface IIPConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies an array of references to backend address pools of application gateways. A node type can reference backend address
        /// pools of multiple application gateways. Multiple node types cannot use the same application gateway.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to backend address pools of application gateways. A node type can reference backend address pools of multiple application gateways. Multiple node types cannot use the same application gateway.",
        SerializedName = @"applicationGatewayBackendAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> ApplicationGatewayBackendAddressPool { get; set; }
        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A node type can reference backend address
        /// pools of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to backend address pools of load balancers. A node type can reference backend address pools of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.",
        SerializedName = @"loadBalancerBackendAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> LoadBalancerBackendAddressPool { get; set; }
        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A node type can reference inbound nat pools
        /// of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to inbound Nat pools of the load balancers. A node type can reference inbound nat pools of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.",
        SerializedName = @"loadBalancerInboundNatPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> LoadBalancerInboundNatPool { get; set; }
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
        /// <summary>
        /// Specifies whether the IP configuration's private IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the IP configuration's private IP is IPv4 or IPv6. Default is IPv4.",
        SerializedName = @"privateIPAddressVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PrivateIPAddressVersion { get; set; }
        /// <summary>Specifies the list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the list of IP tags associated with the public IP address.",
        SerializedName = @"ipTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> PublicIPAddressConfigurationIptag { get; set; }
        /// <summary>Name of the network interface.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the network interface.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPAddressConfigurationName { get; set; }
        /// <summary>
        /// Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.",
        SerializedName = @"publicIPAddressVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressConfigurationPublicIpaddressVersion { get; set; }
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
        string SubnetId { get; set; }

    }
    /// Specifies an IP configuration of the network interface.
    internal partial interface IIPConfigurationInternal

    {
        /// <summary>
        /// Specifies an array of references to backend address pools of application gateways. A node type can reference backend address
        /// pools of multiple application gateways. Multiple node types cannot use the same application gateway.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> ApplicationGatewayBackendAddressPool { get; set; }
        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A node type can reference backend address
        /// pools of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> LoadBalancerBackendAddressPool { get; set; }
        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A node type can reference inbound nat pools
        /// of one public and one internal load balancer. Multiple node types cannot use the same basic sku load balancer.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource> LoadBalancerInboundNatPool { get; set; }
        /// <summary>Name of the network interface.</summary>
        string Name { get; set; }
        /// <summary>
        /// Specifies whether the IP configuration's private IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PrivateIPAddressVersion { get; set; }
        /// <summary>The public IP address configuration of the network interface.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IPublicIPAddressConfiguration PublicIPAddressConfiguration { get; set; }
        /// <summary>Specifies the list of IP tags associated with the public IP address.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag> PublicIPAddressConfigurationIptag { get; set; }
        /// <summary>Name of the network interface.</summary>
        string PublicIPAddressConfigurationName { get; set; }
        /// <summary>
        /// Specifies whether the IP configuration's public IP is IPv4 or IPv6. Default is IPv4.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressConfigurationPublicIpaddressVersion { get; set; }
        /// <summary>Specifies the subnet of the network interface.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource Subnet { get; set; }
        /// <summary>Azure resource identifier.</summary>
        string SubnetId { get; set; }

    }
}