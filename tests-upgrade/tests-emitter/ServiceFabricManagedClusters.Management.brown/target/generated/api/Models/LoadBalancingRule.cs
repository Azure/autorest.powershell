// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a load balancing rule.</summary>
    public partial class LoadBalancingRule :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRuleInternal
    {

        /// <summary>Backing field for <see cref="BackendPort" /> property.</summary>
        private int _backendPort;

        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int BackendPort { get => this._backendPort; set => this._backendPort = value; }

        /// <summary>Backing field for <see cref="FrontendPort" /> property.</summary>
        private int _frontendPort;

        /// <summary>
        /// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values
        /// are between 1 and 65534.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int FrontendPort { get => this._frontendPort; set => this._frontendPort = value; }

        /// <summary>Backing field for <see cref="LoadDistribution" /> property.</summary>
        private string _loadDistribution;

        /// <summary>The load distribution policy for this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string LoadDistribution { get => this._loadDistribution; set => this._loadDistribution = value; }

        /// <summary>Backing field for <see cref="ProbePort" /> property.</summary>
        private int? _probePort;

        /// <summary>
        /// The prob port used by the load balancing rule. Acceptable values are between 1 and 65535.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? ProbePort { get => this._probePort; set => this._probePort = value; }

        /// <summary>Backing field for <see cref="ProbeProtocol" /> property.</summary>
        private string _probeProtocol;

        /// <summary>the reference to the load balancer probe used by the load balancing rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProbeProtocol { get => this._probeProtocol; set => this._probeProtocol = value; }

        /// <summary>Backing field for <see cref="ProbeRequestPath" /> property.</summary>
        private string _probeRequestPath;

        /// <summary>The probe request path. Only supported for HTTP/HTTPS probes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ProbeRequestPath { get => this._probeRequestPath; set => this._probeRequestPath = value; }

        /// <summary>Backing field for <see cref="Protocol" /> property.</summary>
        private string _protocol;

        /// <summary>The reference to the transport protocol used by the load balancing rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Protocol { get => this._protocol; set => this._protocol = value; }

        /// <summary>Creates an new <see cref="LoadBalancingRule" /> instance.</summary>
        public LoadBalancingRule()
        {

        }
    }
    /// Describes a load balancing rule.
    public partial interface ILoadBalancingRule :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.",
        SerializedName = @"backendPort",
        PossibleTypes = new [] { typeof(int) })]
        int BackendPort { get; set; }
        /// <summary>
        /// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values
        /// are between 1 and 65534.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values are between 1 and 65534.",
        SerializedName = @"frontendPort",
        PossibleTypes = new [] { typeof(int) })]
        int FrontendPort { get; set; }
        /// <summary>The load distribution policy for this rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The load distribution policy for this rule.",
        SerializedName = @"loadDistribution",
        PossibleTypes = new [] { typeof(string) })]
        string LoadDistribution { get; set; }
        /// <summary>
        /// The prob port used by the load balancing rule. Acceptable values are between 1 and 65535.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The prob port used by the load balancing rule. Acceptable values are between 1 and 65535.",
        SerializedName = @"probePort",
        PossibleTypes = new [] { typeof(int) })]
        int? ProbePort { get; set; }
        /// <summary>the reference to the load balancer probe used by the load balancing rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the reference to the load balancer probe used by the load balancing rule.",
        SerializedName = @"probeProtocol",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("tcp", "http", "https")]
        string ProbeProtocol { get; set; }
        /// <summary>The probe request path. Only supported for HTTP/HTTPS probes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The probe request path. Only supported for HTTP/HTTPS probes.",
        SerializedName = @"probeRequestPath",
        PossibleTypes = new [] { typeof(string) })]
        string ProbeRequestPath { get; set; }
        /// <summary>The reference to the transport protocol used by the load balancing rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The reference to the transport protocol used by the load balancing rule.",
        SerializedName = @"protocol",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("tcp", "udp")]
        string Protocol { get; set; }

    }
    /// Describes a load balancing rule.
    internal partial interface ILoadBalancingRuleInternal

    {
        /// <summary>
        /// The port used for internal connections on the endpoint. Acceptable values are between 1 and 65535.
        /// </summary>
        int BackendPort { get; set; }
        /// <summary>
        /// The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values
        /// are between 1 and 65534.
        /// </summary>
        int FrontendPort { get; set; }
        /// <summary>The load distribution policy for this rule.</summary>
        string LoadDistribution { get; set; }
        /// <summary>
        /// The prob port used by the load balancing rule. Acceptable values are between 1 and 65535.
        /// </summary>
        int? ProbePort { get; set; }
        /// <summary>the reference to the load balancer probe used by the load balancing rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("tcp", "http", "https")]
        string ProbeProtocol { get; set; }
        /// <summary>The probe request path. Only supported for HTTP/HTTPS probes.</summary>
        string ProbeRequestPath { get; set; }
        /// <summary>The reference to the transport protocol used by the load balancing rule.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("tcp", "udp")]
        string Protocol { get; set; }

    }
}