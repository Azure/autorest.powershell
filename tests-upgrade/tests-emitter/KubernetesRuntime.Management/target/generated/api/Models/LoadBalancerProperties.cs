// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    /// <summary>Details of the LoadBalancer.</summary>
    public partial class LoadBalancerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ILoadBalancerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ILoadBalancerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Address" /> property.</summary>
        private System.Collections.Generic.List<string> _address;

        /// <summary>IP Range</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Address { get => this._address; set => this._address = value; }

        /// <summary>Backing field for <see cref="AdvertiseMode" /> property.</summary>
        private string _advertiseMode;

        /// <summary>Advertise Mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string AdvertiseMode { get => this._advertiseMode; set => this._advertiseMode = value; }

        /// <summary>Backing field for <see cref="BgpPeer" /> property.</summary>
        private System.Collections.Generic.List<string> _bgpPeer;

        /// <summary>
        /// The list of BGP peers it should advertise to. Null or empty means to advertise to all peers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> BgpPeer { get => this._bgpPeer; set => this._bgpPeer = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ILoadBalancerPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Resource provision state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ServiceSelector" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelector _serviceSelector;

        /// <summary>
        /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
        /// with label "a=b", then please specify {"a": "b"} in the field.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelector ServiceSelector { get => (this._serviceSelector = this._serviceSelector ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ServiceSelector()); set => this._serviceSelector = value; }

        /// <summary>Creates an new <see cref="LoadBalancerProperties" /> instance.</summary>
        public LoadBalancerProperties()
        {

        }
    }
    /// Details of the LoadBalancer.
    public partial interface ILoadBalancerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.IJsonSerializable
    {
        /// <summary>IP Range</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Range",
        SerializedName = @"addresses",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Address { get; set; }
        /// <summary>Advertise Mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Advertise Mode",
        SerializedName = @"advertiseMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("ARP", "BGP", "Both")]
        string AdvertiseMode { get; set; }
        /// <summary>
        /// The list of BGP peers it should advertise to. Null or empty means to advertise to all peers.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of BGP peers it should advertise to. Null or empty means to advertise to all peers.",
        SerializedName = @"bgpPeers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BgpPeer { get; set; }
        /// <summary>Resource provision state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource provision state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>
        /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
        /// with label "a=b", then please specify {"a": "b"} in the field.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services with label ""a=b"", then please specify {""a"": ""b""} in the field.",
        SerializedName = @"serviceSelector",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelector) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelector ServiceSelector { get; set; }

    }
    /// Details of the LoadBalancer.
    internal partial interface ILoadBalancerPropertiesInternal

    {
        /// <summary>IP Range</summary>
        System.Collections.Generic.List<string> Address { get; set; }
        /// <summary>Advertise Mode</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("ARP", "BGP", "Both")]
        string AdvertiseMode { get; set; }
        /// <summary>
        /// The list of BGP peers it should advertise to. Null or empty means to advertise to all peers.
        /// </summary>
        System.Collections.Generic.List<string> BgpPeer { get; set; }
        /// <summary>Resource provision state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// A dynamic label mapping to select related services. For instance, if you want to create a load balancer only for services
        /// with label "a=b", then please specify {"a": "b"} in the field.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IServiceSelector ServiceSelector { get; set; }

    }
}