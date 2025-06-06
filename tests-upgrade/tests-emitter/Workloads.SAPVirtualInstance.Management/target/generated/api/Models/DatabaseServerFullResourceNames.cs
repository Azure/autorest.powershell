// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    /// </summary>
    public partial class DatabaseServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="AvailabilitySetName" /> property.</summary>
        private string _availabilitySetName;

        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AvailabilitySetName { get => this._availabilitySetName; set => this._availabilitySetName = value; }

        /// <summary>Backing field for <see cref="LoadBalancer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames _loadBalancer;

        /// <summary>The resource names object for load balancer and related resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames LoadBalancer { get => (this._loadBalancer = this._loadBalancer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNames()); set => this._loadBalancer = value; }

        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> LoadBalancerBackendPoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).BackendPoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).BackendPoolName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> LoadBalancerFrontendIPConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).FrontendIPConfigurationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).FrontendIPConfigurationName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> LoadBalancerHealthProbeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).HealthProbeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).HealthProbeName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string LoadBalancerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).LoadBalancerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNamesInternal)LoadBalancer).LoadBalancerName = value ?? null; }

        /// <summary>Internal Acessors for LoadBalancer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal.LoadBalancer { get => (this._loadBalancer = this._loadBalancer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.LoadBalancerResourceNames()); set { {_loadBalancer = value;} } }

        /// <summary>Backing field for <see cref="VirtualMachine" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> _virtualMachine;

        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> VirtualMachine { get => this._virtualMachine; set => this._virtualMachine = value; }

        /// <summary>Creates an new <see cref="DatabaseServerFullResourceNames" /> instance.</summary>
        public DatabaseServerFullResourceNames()
        {

        }
    }
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    public partial interface IDatabaseServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.",
        SerializedName = @"availabilitySetName",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilitySetName { get; set; }
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
        System.Collections.Generic.List<string> LoadBalancerBackendPoolName { get; set; }
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
        System.Collections.Generic.List<string> LoadBalancerFrontendIPConfigurationName { get; set; }
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
        System.Collections.Generic.List<string> LoadBalancerHealthProbeName { get; set; }
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
        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of virtual machine naming details.",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> VirtualMachine { get; set; }

    }
    /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
    /// number VMs to be created for database layer.
    internal partial interface IDatabaseServerFullResourceNamesInternal

    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        string AvailabilitySetName { get; set; }
        /// <summary>The resource names object for load balancer and related resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames LoadBalancer { get; set; }
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        System.Collections.Generic.List<string> LoadBalancerBackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        System.Collections.Generic.List<string> LoadBalancerFrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        System.Collections.Generic.List<string> LoadBalancerHealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        string LoadBalancerName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> VirtualMachine { get; set; }

    }
}