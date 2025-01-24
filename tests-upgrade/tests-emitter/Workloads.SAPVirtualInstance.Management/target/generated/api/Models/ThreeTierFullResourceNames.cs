// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a three
    /// tier SAP system.
    /// </summary>
    public partial class ThreeTierFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames __threeTierCustomResourceNames = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierCustomResourceNames();

        /// <summary>Backing field for <see cref="ApplicationServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames _applicationServer;

        /// <summary>
        /// The full resource names object for application layer resources. The number of entries in this list should be equal to
        /// the number VMs to be created for application layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames ApplicationServer { get => (this._applicationServer = this._applicationServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerFullResourceNames()); set => this._applicationServer = value; }

        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string ApplicationServerAvailabilitySetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNamesInternal)ApplicationServer).AvailabilitySetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNamesInternal)ApplicationServer).AvailabilitySetName = value ?? null; }

        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> ApplicationServerVirtualMachine { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNamesInternal)ApplicationServer).VirtualMachine; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNamesInternal)ApplicationServer).VirtualMachine = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="CentralServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNames _centralServer;

        /// <summary>The full resource names object for central server layer resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNames CentralServer { get => (this._centralServer = this._centralServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerFullResourceNames()); set => this._centralServer = value; }

        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-ASCS-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerAvailabilitySetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).AvailabilitySetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).AvailabilitySetName = value ?? null; }

        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> CentralServerLoadBalancerBackendPoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerBackendPoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerBackendPoolName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> CentralServerLoadBalancerFrontendIPConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerFrontendIPConfigurationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerFrontendIPConfigurationName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> CentralServerLoadBalancerHealthProbeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerHealthProbeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerHealthProbeName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string CentralServerLoadBalancerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancerName = value ?? null; }

        /// <summary>
        /// The list of names for all ASCS virtual machines to be deployed. The number of entries in this list should be equal to
        /// the number VMs to be created for ASCS layer. At maximum, there can be two virtual machines at this layer: ASCS and ERS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> CentralServerVirtualMachine { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).VirtualMachine; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).VirtualMachine = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="DatabaseServer" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames _databaseServer;

        /// <summary>
        /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
        /// number VMs to be created for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames DatabaseServer { get => (this._databaseServer = this._databaseServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNames()); set => this._databaseServer = value; }

        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerAvailabilitySetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).AvailabilitySetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).AvailabilitySetName = value ?? null; }

        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DatabaseServerLoadBalancerBackendPoolName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerBackendPoolName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerBackendPoolName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DatabaseServerLoadBalancerFrontendIPConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerFrontendIPConfigurationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerFrontendIPConfigurationName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DatabaseServerLoadBalancerHealthProbeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerHealthProbeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerHealthProbeName = value ?? null /* arrayOf */; }

        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string DatabaseServerLoadBalancerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancerName = value ?? null; }

        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> DatabaseServerVirtualMachine { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).VirtualMachine; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).VirtualMachine = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for NamingPatternType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal.NamingPatternType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)__threeTierCustomResourceNames).NamingPatternType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal)__threeTierCustomResourceNames).NamingPatternType = value; }

        /// <summary>Internal Acessors for ApplicationServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal.ApplicationServer { get => (this._applicationServer = this._applicationServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ApplicationServerFullResourceNames()); set { {_applicationServer = value;} } }

        /// <summary>Internal Acessors for CentralServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal.CentralServer { get => (this._centralServer = this._centralServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.CentralServerFullResourceNames()); set { {_centralServer = value;} } }

        /// <summary>Internal Acessors for CentralServerLoadBalancer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal.CentralServerLoadBalancer { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancer; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNamesInternal)CentralServer).LoadBalancer = value; }

        /// <summary>Internal Acessors for DatabaseServer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal.DatabaseServer { get => (this._databaseServer = this._databaseServer ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DatabaseServerFullResourceNames()); set { {_databaseServer = value;} } }

        /// <summary>Internal Acessors for DatabaseServerLoadBalancer</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal.DatabaseServerLoadBalancer { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancer; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNamesInternal)DatabaseServer).LoadBalancer = value; }

        /// <summary>Internal Acessors for SharedStorage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierFullResourceNamesInternal.SharedStorage { get => (this._sharedStorage = this._sharedStorage ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SharedStorageResourceNames()); set { {_sharedStorage = value;} } }

        /// <summary>The pattern type to be used for resource naming.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string NamingPatternType { get => "FullResourceName"; }

        /// <summary>Backing field for <see cref="SharedStorage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames _sharedStorage;

        /// <summary>The resource names object for shared storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames SharedStorage { get => (this._sharedStorage = this._sharedStorage ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SharedStorageResourceNames()); set => this._sharedStorage = value; }

        /// <summary>
        /// The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SharedStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNamesInternal)SharedStorage).SharedStorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNamesInternal)SharedStorage).SharedStorageAccountName = value ?? null; }

        /// <summary>
        /// The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string SharedStorageAccountPrivateEndPointName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNamesInternal)SharedStorage).SharedStorageAccountPrivateEndPointName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNamesInternal)SharedStorage).SharedStorageAccountPrivateEndPointName = value ?? null; }

        /// <summary>Creates an new <see cref="ThreeTierFullResourceNames" /> instance.</summary>
        public ThreeTierFullResourceNames()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__threeTierCustomResourceNames), __threeTierCustomResourceNames);
            await eventListener.AssertObjectIsValid(nameof(__threeTierCustomResourceNames), __threeTierCustomResourceNames);
        }
    }
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a three
    /// tier SAP system.
    public partial interface IThreeTierFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNames
    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.",
        SerializedName = @"availabilitySetName",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationServerAvailabilitySetName { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> ApplicationServerVirtualMachine { get; set; }
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-ASCS-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for availability set. In case name is not provided, it will be defaulted to {SID}-ASCS-AvSet.",
        SerializedName = @"availabilitySetName",
        PossibleTypes = new [] { typeof(string) })]
        string CentralServerAvailabilitySetName { get; set; }
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
        System.Collections.Generic.List<string> CentralServerLoadBalancerBackendPoolName { get; set; }
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
        System.Collections.Generic.List<string> CentralServerLoadBalancerFrontendIPConfigurationName { get; set; }
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
        System.Collections.Generic.List<string> CentralServerLoadBalancerHealthProbeName { get; set; }
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
        string CentralServerLoadBalancerName { get; set; }
        /// <summary>
        /// The list of names for all ASCS virtual machines to be deployed. The number of entries in this list should be equal to
        /// the number VMs to be created for ASCS layer. At maximum, there can be two virtual machines at this layer: ASCS and ERS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of names for all ASCS virtual machines to be deployed. The number of entries in this list should be equal to the number VMs to be created for ASCS layer. At maximum, there can be two virtual machines at this layer: ASCS and ERS.",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> CentralServerVirtualMachine { get; set; }
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
        string DatabaseServerAvailabilitySetName { get; set; }
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
        System.Collections.Generic.List<string> DatabaseServerLoadBalancerBackendPoolName { get; set; }
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
        System.Collections.Generic.List<string> DatabaseServerLoadBalancerFrontendIPConfigurationName { get; set; }
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
        System.Collections.Generic.List<string> DatabaseServerLoadBalancerHealthProbeName { get; set; }
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
        string DatabaseServerLoadBalancerName { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> DatabaseServerVirtualMachine { get; set; }
        /// <summary>
        /// The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.",
        SerializedName = @"sharedStorageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string SharedStorageAccountName { get; set; }
        /// <summary>
        /// The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe",
        SerializedName = @"sharedStorageAccountPrivateEndPointName",
        PossibleTypes = new [] { typeof(string) })]
        string SharedStorageAccountPrivateEndPointName { get; set; }

    }
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a three
    /// tier SAP system.
    internal partial interface IThreeTierFullResourceNamesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierCustomResourceNamesInternal
    {
        /// <summary>
        /// The full resource names object for application layer resources. The number of entries in this list should be equal to
        /// the number VMs to be created for application layer.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames ApplicationServer { get; set; }
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.
        /// </summary>
        string ApplicationServerAvailabilitySetName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> ApplicationServerVirtualMachine { get; set; }
        /// <summary>The full resource names object for central server layer resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ICentralServerFullResourceNames CentralServer { get; set; }
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-ASCS-AvSet.
        /// </summary>
        string CentralServerAvailabilitySetName { get; set; }
        /// <summary>The resource names object for load balancer and related resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames CentralServerLoadBalancer { get; set; }
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        System.Collections.Generic.List<string> CentralServerLoadBalancerBackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        System.Collections.Generic.List<string> CentralServerLoadBalancerFrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        System.Collections.Generic.List<string> CentralServerLoadBalancerHealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        string CentralServerLoadBalancerName { get; set; }
        /// <summary>
        /// The list of names for all ASCS virtual machines to be deployed. The number of entries in this list should be equal to
        /// the number VMs to be created for ASCS layer. At maximum, there can be two virtual machines at this layer: ASCS and ERS.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> CentralServerVirtualMachine { get; set; }
        /// <summary>
        /// The full resource names object for database layer resources. The number of entries in this list should be equal to the
        /// number VMs to be created for database layer.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDatabaseServerFullResourceNames DatabaseServer { get; set; }
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet.
        /// </summary>
        string DatabaseServerAvailabilitySetName { get; set; }
        /// <summary>The resource names object for load balancer and related resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerResourceNames DatabaseServerLoadBalancer { get; set; }
        /// <summary>
        /// The list of backend pool names. Currently, ACSS deploys only one backend pool and hence, size of this list should be 1
        /// </summary>
        System.Collections.Generic.List<string> DatabaseServerLoadBalancerBackendPoolName { get; set; }
        /// <summary>
        /// The list of frontend IP configuration names. If provided as input, size of this list should be 2 for cs layer and should
        /// be 1 for database layer.
        /// </summary>
        System.Collections.Generic.List<string> DatabaseServerLoadBalancerFrontendIPConfigurationName { get; set; }
        /// <summary>
        /// The list of health probe names. If provided as input, size of this list should be 2 for cs layer and should be 1 for database
        /// layer.
        /// </summary>
        System.Collections.Generic.List<string> DatabaseServerLoadBalancerHealthProbeName { get; set; }
        /// <summary>
        /// The full resource name for load balancer. If this value is not provided, load balancer will be name as {ASCS/DB}-loadBalancer.
        /// </summary>
        string DatabaseServerLoadBalancerName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> DatabaseServerVirtualMachine { get; set; }
        /// <summary>The resource names object for shared storage.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISharedStorageResourceNames SharedStorage { get; set; }
        /// <summary>
        /// The full name of the shared storage account. If it is not provided, it will be defaulted to {SID}nfs{guid of 15 chars}.
        /// </summary>
        string SharedStorageAccountName { get; set; }
        /// <summary>
        /// The full name of private end point for the shared storage account. If it is not provided, it will be defaulted to {storageAccountName}_pe
        /// </summary>
        string SharedStorageAccountPrivateEndPointName { get; set; }

    }
}