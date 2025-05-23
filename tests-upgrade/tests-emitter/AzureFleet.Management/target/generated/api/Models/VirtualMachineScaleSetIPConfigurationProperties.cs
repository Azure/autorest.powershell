// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes a virtual machine scale set network profile's IP configuration
    /// properties.
    /// </summary>
    public partial class VirtualMachineScaleSetIPConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGatewayBackendAddressPool" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> _applicationGatewayBackendAddressPool;

        /// <summary>
        /// Specifies an array of references to backend address pools of application
        /// gateways. A scale set can reference backend address pools of multiple
        /// application gateways. Multiple scale sets cannot use the same application
        /// gateway.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> ApplicationGatewayBackendAddressPool { get => this._applicationGatewayBackendAddressPool; set => this._applicationGatewayBackendAddressPool = value; }

        /// <summary>Backing field for <see cref="ApplicationSecurityGroup" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> _applicationSecurityGroup;

        /// <summary>Specifies an array of references to application security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> ApplicationSecurityGroup { get => this._applicationSecurityGroup; set => this._applicationSecurityGroup = value; }

        /// <summary>Specify what happens to the public IP when the VM is deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DeleteOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DeleteOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DeleteOption = value ?? null; }

        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DnsSettingDomainNameLabel { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DnsSettingDomainNameLabel; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DnsSettingDomainNameLabel = value ?? null; }

        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DnsSettingDomainNameLabelScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DnsSettingDomainNameLabelScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DnsSettingDomainNameLabelScope = value ?? null; }

        /// <summary>The list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> IPTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).IPTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).IPTag = value ?? null /* arrayOf */; }

        /// <summary>The idle timeout of the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? IdleTimeoutInMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).IdleTimeoutInMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).IdleTimeoutInMinute = value ?? default(int); }

        /// <summary>Backing field for <see cref="LoadBalancerBackendAddressPool" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> _loadBalancerBackendAddressPool;

        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A
        /// scale set can reference backend address pools of one public and one internal
        /// load balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> LoadBalancerBackendAddressPool { get => this._loadBalancerBackendAddressPool; set => this._loadBalancerBackendAddressPool = value; }

        /// <summary>Backing field for <see cref="LoadBalancerInboundNatPool" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> _loadBalancerInboundNatPool;

        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A
        /// scale set can reference inbound nat pools of one public and one internal load
        /// balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> LoadBalancerInboundNatPool { get => this._loadBalancerInboundNatPool; set => this._loadBalancerInboundNatPool = value; }

        /// <summary>Internal Acessors for DnsSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal.DnsSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DnsSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).DnsSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PublicIPAddressConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal.PublicIPAddressConfiguration { get => (this._publicIPAddressConfiguration = this._publicIPAddressConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfiguration()); set { {_publicIPAddressConfiguration = value;} } }

        /// <summary>Internal Acessors for PublicIPAddressConfigurationProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal.PublicIPAddressConfigurationProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Property = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PublicIPAddressConfigurationSku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPublicIPAddressSku Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal.PublicIPAddressConfigurationSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Sku = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PublicIPPrefix</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal.PublicIPPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPPrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPPrefix = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiEntityReference Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPConfigurationPropertiesInternal.Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ApiEntityReference()); set { {_subnet = value;} } }

        /// <summary>Backing field for <see cref="Primary" /> property.</summary>
        private bool? _primary;

        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more
        /// than 1 network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Primary { get => this._primary; set => this._primary = value; }

        /// <summary>Backing field for <see cref="PrivateIPAddressVersion" /> property.</summary>
        private string _privateIPAddressVersion;

        /// <summary>
        /// Available from Api-Version 2017-03-30 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string PrivateIPAddressVersion { get => this._privateIPAddressVersion; set => this._privateIPAddressVersion = value; }

        /// <summary>Backing field for <see cref="PublicIPAddressConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration _publicIPAddressConfiguration;

        /// <summary>The publicIPAddressConfiguration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration PublicIPAddressConfiguration { get => (this._publicIPAddressConfiguration = this._publicIPAddressConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfiguration()); set => this._publicIPAddressConfiguration = value; }

        /// <summary>The publicIP address configuration name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PublicIPAddressConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).Name = value ?? null; }

        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PublicIPAddressVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPAddressVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPAddressVersion = value ?? null; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string PublicIPPrefixId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPPrefixId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).PublicIPPrefixId = value ?? null; }

        /// <summary>Specify public IP sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).SkuName = value ?? null; }

        /// <summary>Specify public IP sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SkuTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).SkuTier; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationInternal)PublicIPAddressConfiguration).SkuTier = value ?? null; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiEntityReference _subnet;

        /// <summary>Specifies the identifier of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiEntityReference Subnet { get => (this._subnet = this._subnet ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ApiEntityReference()); set => this._subnet = value; }

        /// <summary>
        /// The ARM resource id in the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiEntityReferenceInternal)Subnet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiEntityReferenceInternal)Subnet).Id = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetIPConfigurationProperties" /> instance.
        /// </summary>
        public VirtualMachineScaleSetIPConfigurationProperties()
        {

        }
    }
    /// Describes a virtual machine scale set network profile's IP configuration
    /// properties.
    public partial interface IVirtualMachineScaleSetIPConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies an array of references to backend address pools of application
        /// gateways. A scale set can reference backend address pools of multiple
        /// application gateways. Multiple scale sets cannot use the same application
        /// gateway.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to backend address pools of application
        gateways. A scale set can reference backend address pools of multiple
        application gateways. Multiple scale sets cannot use the same application
        gateway.",
        SerializedName = @"applicationGatewayBackendAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> ApplicationGatewayBackendAddressPool { get; set; }
        /// <summary>Specifies an array of references to application security group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to application security group.",
        SerializedName = @"applicationSecurityGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> ApplicationSecurityGroup { get; set; }
        /// <summary>Specify what happens to the public IP when the VM is deleted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify what happens to the public IP when the VM is deleted",
        SerializedName = @"deleteOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Domain name label.The concatenation of the domain name label and vm index
        will be the domain name labels of the PublicIPAddress resources that will be
        created",
        SerializedName = @"domainNameLabel",
        PossibleTypes = new [] { typeof(string) })]
        string DnsSettingDomainNameLabel { get; set; }
        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Domain name label scope.The concatenation of the hashed domain name label
        that generated according to the policy from domain name label scope and vm
        index will be the domain name labels of the PublicIPAddress resources that will
        be created",
        SerializedName = @"domainNameLabelScope",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string DnsSettingDomainNameLabelScope { get; set; }
        /// <summary>The list of IP tags associated with the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of IP tags associated with the public IP address.",
        SerializedName = @"ipTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> IPTag { get; set; }
        /// <summary>The idle timeout of the public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The idle timeout of the public IP address.",
        SerializedName = @"idleTimeoutInMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? IdleTimeoutInMinute { get; set; }
        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A
        /// scale set can reference backend address pools of one public and one internal
        /// load balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to backend address pools of load balancers. A
        scale set can reference backend address pools of one public and one internal
        load balancer. Multiple scale sets cannot use the same basic sku load balancer.",
        SerializedName = @"loadBalancerBackendAddressPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> LoadBalancerBackendAddressPool { get; set; }
        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A
        /// scale set can reference inbound nat pools of one public and one internal load
        /// balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies an array of references to inbound Nat pools of the load balancers. A
        scale set can reference inbound nat pools of one public and one internal load
        balancer. Multiple scale sets cannot use the same basic sku load balancer.",
        SerializedName = @"loadBalancerInboundNatPools",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> LoadBalancerInboundNatPool { get; set; }
        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more
        /// than 1 network interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the primary network interface in case the virtual machine has more
        than 1 network interface.",
        SerializedName = @"primary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Primary { get; set; }
        /// <summary>
        /// Available from Api-Version 2017-03-30 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Available from Api-Version 2017-03-30 onwards, it represents whether the
        specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.  Possible
        values are: 'IPv4' and 'IPv6'.",
        SerializedName = @"privateIPAddressVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PrivateIPAddressVersion { get; set; }
        /// <summary>The publicIP address configuration name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The publicIP address configuration name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPAddressConfigurationName { get; set; }
        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Available from Api-Version 2019-07-01 onwards, it represents whether the
        specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        values are: 'IPv4' and 'IPv6'.",
        SerializedName = @"publicIPAddressVersion",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressVersion { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPPrefixId { get; set; }
        /// <summary>Specify public IP sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify public IP sku name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Basic", "Standard")]
        string SkuName { get; set; }
        /// <summary>Specify public IP sku tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specify public IP sku tier",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Regional", "Global")]
        string SkuTier { get; set; }
        /// <summary>
        /// The ARM resource id in the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM resource id in the form of
        /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }

    }
    /// Describes a virtual machine scale set network profile's IP configuration
    /// properties.
    internal partial interface IVirtualMachineScaleSetIPConfigurationPropertiesInternal

    {
        /// <summary>
        /// Specifies an array of references to backend address pools of application
        /// gateways. A scale set can reference backend address pools of multiple
        /// application gateways. Multiple scale sets cannot use the same application
        /// gateway.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> ApplicationGatewayBackendAddressPool { get; set; }
        /// <summary>Specifies an array of references to application security group.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> ApplicationSecurityGroup { get; set; }
        /// <summary>Specify what happens to the public IP when the VM is deleted</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>The dns settings to be applied on the publicIP addresses .</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSetting { get; set; }
        /// <summary>
        /// The Domain name label.The concatenation of the domain name label and vm index
        /// will be the domain name labels of the PublicIPAddress resources that will be
        /// created
        /// </summary>
        string DnsSettingDomainNameLabel { get; set; }
        /// <summary>
        /// The Domain name label scope.The concatenation of the hashed domain name label
        /// that generated according to the policy from domain name label scope and vm
        /// index will be the domain name labels of the PublicIPAddress resources that will
        /// be created
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("TenantReuse", "SubscriptionReuse", "ResourceGroupReuse", "NoReuse")]
        string DnsSettingDomainNameLabelScope { get; set; }
        /// <summary>The list of IP tags associated with the public IP address.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag> IPTag { get; set; }
        /// <summary>The idle timeout of the public IP address.</summary>
        int? IdleTimeoutInMinute { get; set; }
        /// <summary>
        /// Specifies an array of references to backend address pools of load balancers. A
        /// scale set can reference backend address pools of one public and one internal
        /// load balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> LoadBalancerBackendAddressPool { get; set; }
        /// <summary>
        /// Specifies an array of references to inbound Nat pools of the load balancers. A
        /// scale set can reference inbound nat pools of one public and one internal load
        /// balancer. Multiple scale sets cannot use the same basic sku load balancer.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource> LoadBalancerInboundNatPool { get; set; }
        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more
        /// than 1 network interface.
        /// </summary>
        bool? Primary { get; set; }
        /// <summary>
        /// Available from Api-Version 2017-03-30 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PrivateIPAddressVersion { get; set; }
        /// <summary>The publicIPAddressConfiguration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfiguration PublicIPAddressConfiguration { get; set; }
        /// <summary>The publicIP address configuration name.</summary>
        string PublicIPAddressConfigurationName { get; set; }
        /// <summary>
        /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
        /// configuration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties PublicIPAddressConfigurationProperty { get; set; }
        /// <summary>
        /// Describes the public IP Sku. It can only be set with OrchestrationMode as
        /// Flexible.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IPublicIPAddressSku PublicIPAddressConfigurationSku { get; set; }
        /// <summary>
        /// Available from Api-Version 2019-07-01 onwards, it represents whether the
        /// specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible
        /// values are: 'IPv4' and 'IPv6'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("IPv4", "IPv6")]
        string PublicIPAddressVersion { get; set; }
        /// <summary>The PublicIPPrefix from which to allocate publicIP addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISubResource PublicIPPrefix { get; set; }
        /// <summary>Resource Id</summary>
        string PublicIPPrefixId { get; set; }
        /// <summary>Specify public IP sku name</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Basic", "Standard")]
        string SkuName { get; set; }
        /// <summary>Specify public IP sku tier</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Regional", "Global")]
        string SkuTier { get; set; }
        /// <summary>Specifies the identifier of the subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IApiEntityReference Subnet { get; set; }
        /// <summary>
        /// The ARM resource id in the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string SubnetId { get; set; }

    }
}