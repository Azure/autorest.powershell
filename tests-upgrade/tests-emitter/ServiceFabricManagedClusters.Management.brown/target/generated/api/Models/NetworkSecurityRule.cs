// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a network security rule.</summary>
    public partial class NetworkSecurityRule :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRule,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.INetworkSecurityRuleInternal
    {

        /// <summary>Backing field for <see cref="Access" /> property.</summary>
        private string _access;

        /// <summary>The network traffic is allowed or denied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Access { get => this._access; set => this._access = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Network security rule description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DestinationAddressPrefix" /> property.</summary>
        private string _destinationAddressPrefix;

        /// <summary>
        /// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DestinationAddressPrefix { get => this._destinationAddressPrefix; set => this._destinationAddressPrefix = value; }

        /// <summary>Backing field for <see cref="DestinationAddressPrefixes" /> property.</summary>
        private System.Collections.Generic.List<string> _destinationAddressPrefixes;

        /// <summary>The destination address prefixes. CIDR or destination IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DestinationAddressPrefixes { get => this._destinationAddressPrefixes; set => this._destinationAddressPrefixes = value; }

        /// <summary>Backing field for <see cref="DestinationPortRange" /> property.</summary>
        private string _destinationPortRange;

        /// <summary>
        /// he destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string DestinationPortRange { get => this._destinationPortRange; set => this._destinationPortRange = value; }

        /// <summary>Backing field for <see cref="DestinationPortRanges" /> property.</summary>
        private System.Collections.Generic.List<string> _destinationPortRanges;

        /// <summary>The destination port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DestinationPortRanges { get => this._destinationPortRanges; set => this._destinationPortRanges = value; }

        /// <summary>Backing field for <see cref="Direction" /> property.</summary>
        private string _direction;

        /// <summary>Network security rule direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Direction { get => this._direction; set => this._direction = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Network security rule name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Priority" /> property.</summary>
        private int _priority;

        /// <summary>
        /// The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service
        /// Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower
        /// the priority number, the higher the priority of the rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int Priority { get => this._priority; set => this._priority = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>Network protocol this rule applies to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Backing field for <see cref="SourceAddressPrefix" /> property.</summary>
        private string _sourceAddressPrefix;

        /// <summary>
        /// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates
        /// from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SourceAddressPrefix { get => this._sourceAddressPrefix; set => this._sourceAddressPrefix = value; }

        /// <summary>Backing field for <see cref="SourceAddressPrefixes" /> property.</summary>
        private System.Collections.Generic.List<string> _sourceAddressPrefixes;

        /// <summary>The CIDR or source IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SourceAddressPrefixes { get => this._sourceAddressPrefixes; set => this._sourceAddressPrefixes = value; }

        /// <summary>Backing field for <see cref="SourcePortRange" /> property.</summary>
        private string _sourcePortRange;

        /// <summary>
        /// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string SourcePortRange { get => this._sourcePortRange; set => this._sourcePortRange = value; }

        /// <summary>Backing field for <see cref="SourcePortRanges" /> property.</summary>
        private System.Collections.Generic.List<string> _sourcePortRanges;

        /// <summary>The source port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SourcePortRanges { get => this._sourcePortRanges; set => this._sourcePortRanges = value; }

        /// <summary>Creates an new <see cref="NetworkSecurityRule" /> instance.</summary>
        public NetworkSecurityRule()
        {

        }
    }
    /// Describes a network security rule.
    public partial interface INetworkSecurityRule :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The network traffic is allowed or denied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The network traffic is allowed or denied.",
        SerializedName = @"access",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("allow", "deny")]
        string Access { get; set; }
        /// <summary>Network security rule description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network security rule description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.",
        SerializedName = @"destinationAddressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationAddressPrefix { get; set; }
        /// <summary>The destination address prefixes. CIDR or destination IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The destination address prefixes. CIDR or destination IP ranges.",
        SerializedName = @"destinationAddressPrefixes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DestinationAddressPrefixes { get; set; }
        /// <summary>
        /// he destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"he destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.",
        SerializedName = @"destinationPortRange",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationPortRange { get; set; }
        /// <summary>The destination port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The destination port ranges.",
        SerializedName = @"destinationPortRanges",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DestinationPortRanges { get; set; }
        /// <summary>Network security rule direction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network security rule direction.",
        SerializedName = @"direction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("inbound", "outbound")]
        string Direction { get; set; }
        /// <summary>Network security rule name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network security rule name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service
        /// Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower
        /// the priority number, the higher the priority of the rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower the priority number, the higher the priority of the rule.",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int Priority { get; set; }
        /// <summary>Network protocol this rule applies to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network protocol this rule applies to.",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("http", "https", "tcp", "udp", "icmp", "ah", "esp")]
        string Protocol { get; set; }
        /// <summary>
        /// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates
        /// from.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates from.",
        SerializedName = @"sourceAddressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string SourceAddressPrefix { get; set; }
        /// <summary>The CIDR or source IP ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The CIDR or source IP ranges.",
        SerializedName = @"sourceAddressPrefixes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SourceAddressPrefixes { get; set; }
        /// <summary>
        /// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.",
        SerializedName = @"sourcePortRange",
        PossibleTypes = new [] { typeof(string) })]
        string SourcePortRange { get; set; }
        /// <summary>The source port ranges.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The source port ranges.",
        SerializedName = @"sourcePortRanges",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SourcePortRanges { get; set; }

    }
    /// Describes a network security rule.
    internal partial interface INetworkSecurityRuleInternal

    {
        /// <summary>The network traffic is allowed or denied.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("allow", "deny")]
        string Access { get; set; }
        /// <summary>Network security rule description.</summary>
        string Description { get; set; }
        /// <summary>
        /// The destination address prefix. CIDR or destination IP range. Asterisk '*' can also be used to match all source IPs. Default
        /// tags such as 'VirtualNetwork', 'AzureLoadBalancer' and 'Internet' can also be used.
        /// </summary>
        string DestinationAddressPrefix { get; set; }
        /// <summary>The destination address prefixes. CIDR or destination IP ranges.</summary>
        System.Collections.Generic.List<string> DestinationAddressPrefixes { get; set; }
        /// <summary>
        /// he destination port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        string DestinationPortRange { get; set; }
        /// <summary>The destination port ranges.</summary>
        System.Collections.Generic.List<string> DestinationPortRanges { get; set; }
        /// <summary>Network security rule direction.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("inbound", "outbound")]
        string Direction { get; set; }
        /// <summary>Network security rule name.</summary>
        string Name { get; set; }
        /// <summary>
        /// The priority of the rule. The value can be in the range 1000 to 3000. Values outside this range are reserved for Service
        /// Fabric ManagerCluster Resource Provider. The priority number must be unique for each rule in the collection. The lower
        /// the priority number, the higher the priority of the rule.
        /// </summary>
        int Priority { get; set; }
        /// <summary>Network protocol this rule applies to.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("http", "https", "tcp", "udp", "icmp", "ah", "esp")]
        string Protocol { get; set; }
        /// <summary>
        /// The CIDR or source IP range. Asterisk '*' can also be used to match all source IPs. Default tags such as 'VirtualNetwork',
        /// 'AzureLoadBalancer' and 'Internet' can also be used. If this is an ingress rule, specifies where network traffic originates
        /// from.
        /// </summary>
        string SourceAddressPrefix { get; set; }
        /// <summary>The CIDR or source IP ranges.</summary>
        System.Collections.Generic.List<string> SourceAddressPrefixes { get; set; }
        /// <summary>
        /// The source port or range. Integer or range between 0 and 65535. Asterisk '*' can also be used to match all ports.
        /// </summary>
        string SourcePortRange { get; set; }
        /// <summary>The source port ranges.</summary>
        System.Collections.Generic.List<string> SourcePortRanges { get; set; }

    }
}