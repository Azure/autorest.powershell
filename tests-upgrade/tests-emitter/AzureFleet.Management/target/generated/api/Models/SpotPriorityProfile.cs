// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Configuration Options for Spot instances in Compute Fleet.</summary>
    public partial class SpotPriorityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISpotPriorityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISpotPriorityProfileInternal
    {

        /// <summary>Backing field for <see cref="AllocationStrategy" /> property.</summary>
        private string _allocationStrategy;

        /// <summary>
        /// Allocation strategy to follow when determining the VM sizes distribution for Spot VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AllocationStrategy { get => this._allocationStrategy; set => this._allocationStrategy = value; }

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private int? _capacity;

        /// <summary>Total capacity to achieve. It is currently in terms of number of VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Backing field for <see cref="EvictionPolicy" /> property.</summary>
        private string _evictionPolicy;

        /// <summary>Eviction Policy to follow when evicting Spot VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string EvictionPolicy { get => this._evictionPolicy; set => this._evictionPolicy = value; }

        /// <summary>Backing field for <see cref="Maintain" /> property.</summary>
        private bool? _maintain;

        /// <summary>
        /// Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.
        /// If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)
        /// or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint)
        /// in order to achieve the desired capacity.
        /// Maintain is enabled by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Maintain { get => this._maintain; set => this._maintain = value; }

        /// <summary>Backing field for <see cref="MaxPricePerVM" /> property.</summary>
        private float? _maxPricePerVM;

        /// <summary>Price per hour of each Spot VM will never exceed this.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public float? MaxPricePerVM { get => this._maxPricePerVM; set => this._maxPricePerVM = value; }

        /// <summary>Backing field for <see cref="MinCapacity" /> property.</summary>
        private int? _minCapacity;

        /// <summary>
        /// Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject
        /// the request in the sync path itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? MinCapacity { get => this._minCapacity; set => this._minCapacity = value; }

        /// <summary>Creates an new <see cref="SpotPriorityProfile" /> instance.</summary>
        public SpotPriorityProfile()
        {

        }
    }
    /// Configuration Options for Spot instances in Compute Fleet.
    public partial interface ISpotPriorityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Allocation strategy to follow when determining the VM sizes distribution for Spot VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Allocation strategy to follow when determining the VM sizes distribution for Spot VMs.",
        SerializedName = @"allocationStrategy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("PriceCapacityOptimized", "LowestPrice", "CapacityOptimized")]
        string AllocationStrategy { get; set; }
        /// <summary>Total capacity to achieve. It is currently in terms of number of VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Total capacity to achieve. It is currently in terms of number of VMs.",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? Capacity { get; set; }
        /// <summary>Eviction Policy to follow when evicting Spot VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Eviction Policy to follow when evicting Spot VMs.",
        SerializedName = @"evictionPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Deallocate")]
        string EvictionPolicy { get; set; }
        /// <summary>
        /// Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.
        /// If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)
        /// or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint)
        /// in order to achieve the desired capacity.
        /// Maintain is enabled by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.
        If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)
        or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint) in order to achieve the desired capacity.
        Maintain is enabled by default.",
        SerializedName = @"maintain",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Maintain { get; set; }
        /// <summary>Price per hour of each Spot VM will never exceed this.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Price per hour of each Spot VM will never exceed this.",
        SerializedName = @"maxPricePerVM",
        PossibleTypes = new [] { typeof(float) })]
        float? MaxPricePerVM { get; set; }
        /// <summary>
        /// Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject
        /// the request in the sync path itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum capacity to achieve which cannot be updated. If we will not be able to ""guarantee"" minimum capacity, we will reject the request in the sync path itself.",
        SerializedName = @"minCapacity",
        PossibleTypes = new [] { typeof(int) })]
        int? MinCapacity { get; set; }

    }
    /// Configuration Options for Spot instances in Compute Fleet.
    internal partial interface ISpotPriorityProfileInternal

    {
        /// <summary>
        /// Allocation strategy to follow when determining the VM sizes distribution for Spot VMs.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("PriceCapacityOptimized", "LowestPrice", "CapacityOptimized")]
        string AllocationStrategy { get; set; }
        /// <summary>Total capacity to achieve. It is currently in terms of number of VMs.</summary>
        int? Capacity { get; set; }
        /// <summary>Eviction Policy to follow when evicting Spot VMs.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Deallocate")]
        string EvictionPolicy { get; set; }
        /// <summary>
        /// Flag to enable/disable continuous goal seeking for the desired capacity and restoration of evicted Spot VMs.
        /// If maintain is enabled, AzureFleetRP will use all VM sizes in vmSizesProfile to create new VMs (if VMs are evicted deleted)
        /// or update existing VMs with new VM sizes (if VMs are evicted deallocated or failed to allocate due to capacity constraint)
        /// in order to achieve the desired capacity.
        /// Maintain is enabled by default.
        /// </summary>
        bool? Maintain { get; set; }
        /// <summary>Price per hour of each Spot VM will never exceed this.</summary>
        float? MaxPricePerVM { get; set; }
        /// <summary>
        /// Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject
        /// the request in the sync path itself.
        /// </summary>
        int? MinCapacity { get; set; }

    }
}