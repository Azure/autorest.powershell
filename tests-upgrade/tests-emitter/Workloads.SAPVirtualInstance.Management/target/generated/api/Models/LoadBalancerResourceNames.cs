// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The resource names object for load balancer and related resources.</summary>
    public partial class LoadBalancerResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="BackendPoolName" /> property.</summary>
        private System.Collections.Generic.List<string> _backendPoolName;

        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> BackendPoolName { get => this._backendPoolName; set => this._backendPoolName = value; }

        /// <summary>Backing field for <see cref="FrontendIPConfigurationName" /> property.</summary>
        private System.Collections.Generic.List<string> _frontendIPConfigurationName;

        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> FrontendIPConfigurationName { get => this._frontendIPConfigurationName; set => this._frontendIPConfigurationName = value; }

        /// <summary>Backing field for <see cref="HealthProbeName" /> property.</summary>
        private System.Collections.Generic.List<string> _healthProbeName;

        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> HealthProbeName { get => this._healthProbeName; set => this._healthProbeName = value; }

        /// <summary>Backing field for <see cref="LoadBalancerName" /> property.</summary>
        private string _loadBalancerName;

        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string LoadBalancerName { get => this._loadBalancerName; set => this._loadBalancerName = value; }

        /// <summary>Creates an new <see cref="LoadBalancerResourceNames" /> instance.</summary>
        public LoadBalancerResourceNames()
        {

        }
    }
    /// The resource names object for load balancer and related resources.
    public partial interface ILoadBalancerResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1",
        SerializedName = @"backendPoolNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> BackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer.",
        SerializedName = @"frontendIpConfigurationNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> FrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database layer.",
        SerializedName = @"healthProbeNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> HealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.",
        SerializedName = @"loadBalancerName",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerName { get; set; }

    }
    /// The resource names object for load balancer and related resources.
    internal partial interface ILoadBalancerResourceNamesInternal

    {
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        System.Collections.Generic.List<string> BackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        System.Collections.Generic.List<string> FrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        System.Collections.Generic.List<string> HealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        string LoadBalancerName { get; set; }

    }
}