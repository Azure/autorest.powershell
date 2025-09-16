// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the frontend configurations for the node type.</summary>
    public partial class FrontendConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFrontendConfigurationInternal
    {

        /// <summary>
        /// Backing field for <see cref="ApplicationGatewayBackendAddressPoolId" /> property.
        /// </summary>
        private string _applicationGatewayBackendAddressPoolId;

        /// <summary>
        /// The resource Id of application gateway backend address pool. The format of the resource Id is '/subscriptions/<subscriptionId>/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/backendAddressPools/{backendAddressPoolName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ApplicationGatewayBackendAddressPoolId { get => this._applicationGatewayBackendAddressPoolId; set => this._applicationGatewayBackendAddressPoolId = value; }

        /// <summary>Backing field for <see cref="IPAddressType" /> property.</summary>
        private string _iPAddressType;

        /// <summary>
        /// The IP address type of this frontend configuration. If omitted the default value is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string IPAddressType { get => this._iPAddressType; set => this._iPAddressType = value; }

        /// <summary>Backing field for <see cref="LoadBalancerBackendAddressPoolId" /> property.</summary>
        private string _loadBalancerBackendAddressPoolId;

        /// <summary>
        /// The resource Id of the Load Balancer backend address pool that the VM instances of the node type are associated with.
        /// The format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string LoadBalancerBackendAddressPoolId { get => this._loadBalancerBackendAddressPoolId; set => this._loadBalancerBackendAddressPoolId = value; }

        /// <summary>Backing field for <see cref="LoadBalancerInboundNatPoolId" /> property.</summary>
        private string _loadBalancerInboundNatPoolId;

        /// <summary>
        /// The resource Id of the Load Balancer inbound NAT pool that the VM instances of the node type are associated with. The
        /// format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatPools/{inboundNatPoolName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string LoadBalancerInboundNatPoolId { get => this._loadBalancerInboundNatPoolId; set => this._loadBalancerInboundNatPoolId = value; }

        /// <summary>Creates an new <see cref="FrontendConfiguration" /> instance.</summary>
        public FrontendConfiguration()
        {

        }
    }
    /// Describes the frontend configurations for the node type.
    public partial interface IFrontendConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The resource Id of application gateway backend address pool. The format of the resource Id is '/subscriptions/<subscriptionId>/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/backendAddressPools/{backendAddressPoolName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource Id of application gateway backend address pool. The format of the resource Id is '/subscriptions/<subscriptionId>/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/backendAddressPools/{backendAddressPoolName}'.",
        SerializedName = @"applicationGatewayBackendAddressPoolId",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationGatewayBackendAddressPoolId { get; set; }
        /// <summary>
        /// The IP address type of this frontend configuration. If omitted the default value is IPv4.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The IP address type of this frontend configuration. If omitted the default value is IPv4.",
        SerializedName = @"ipAddressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string IPAddressType { get; set; }
        /// <summary>
        /// The resource Id of the Load Balancer backend address pool that the VM instances of the node type are associated with.
        /// The format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource Id of the Load Balancer backend address pool that the VM instances of the node type are associated with. The format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}'.",
        SerializedName = @"loadBalancerBackendAddressPoolId",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerBackendAddressPoolId { get; set; }
        /// <summary>
        /// The resource Id of the Load Balancer inbound NAT pool that the VM instances of the node type are associated with. The
        /// format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatPools/{inboundNatPoolName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource Id of the Load Balancer inbound NAT pool that the VM instances of the node type are associated with. The format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatPools/{inboundNatPoolName}'.",
        SerializedName = @"loadBalancerInboundNatPoolId",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerInboundNatPoolId { get; set; }

    }
    /// Describes the frontend configurations for the node type.
    internal partial interface IFrontendConfigurationInternal

    {
        /// <summary>
        /// The resource Id of application gateway backend address pool. The format of the resource Id is '/subscriptions/<subscriptionId>/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/applicationGateways/{applicationGatewayName}/backendAddressPools/{backendAddressPoolName}'.
        /// </summary>
        string ApplicationGatewayBackendAddressPoolId { get; set; }
        /// <summary>
        /// The IP address type of this frontend configuration. If omitted the default value is IPv4.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string IPAddressType { get; set; }
        /// <summary>
        /// The resource Id of the Load Balancer backend address pool that the VM instances of the node type are associated with.
        /// The format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/backendAddressPools/{backendAddressPoolName}'.
        /// </summary>
        string LoadBalancerBackendAddressPoolId { get; set; }
        /// <summary>
        /// The resource Id of the Load Balancer inbound NAT pool that the VM instances of the node type are associated with. The
        /// format of the resource Id is '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/inboundNatPools/{inboundNatPoolName}'.
        /// </summary>
        string LoadBalancerInboundNatPoolId { get; set; }

    }
}