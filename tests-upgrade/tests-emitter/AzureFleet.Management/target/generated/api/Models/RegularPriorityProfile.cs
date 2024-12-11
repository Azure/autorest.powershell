// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Configuration Options for Regular instances in Compute Fleet.</summary>
    public partial class RegularPriorityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IRegularPriorityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IRegularPriorityProfileInternal
    {

        /// <summary>Backing field for <see cref="AllocationStrategy" /> property.</summary>
        private string _allocationStrategy;

        /// <summary>
        /// Allocation strategy to follow when determining the VM sizes distribution for Regular VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AllocationStrategy { get => this._allocationStrategy; set => this._allocationStrategy = value; }

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private int? _capacity;

        /// <summary>Total capacity to achieve. It is currently in terms of number of VMs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Backing field for <see cref="MinCapacity" /> property.</summary>
        private int? _minCapacity;

        /// <summary>
        /// Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject
        /// the request in the sync path itself.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? MinCapacity { get => this._minCapacity; set => this._minCapacity = value; }

        /// <summary>Creates an new <see cref="RegularPriorityProfile" /> instance.</summary>
        public RegularPriorityProfile()
        {

        }
    }
    /// Configuration Options for Regular instances in Compute Fleet.
    public partial interface IRegularPriorityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Allocation strategy to follow when determining the VM sizes distribution for Regular VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Allocation strategy to follow when determining the VM sizes distribution for Regular VMs.",
        SerializedName = @"allocationStrategy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("LowestPrice", "Prioritized")]
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
    /// Configuration Options for Regular instances in Compute Fleet.
    internal partial interface IRegularPriorityProfileInternal

    {
        /// <summary>
        /// Allocation strategy to follow when determining the VM sizes distribution for Regular VMs.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("LowestPrice", "Prioritized")]
        string AllocationStrategy { get; set; }
        /// <summary>Total capacity to achieve. It is currently in terms of number of VMs.</summary>
        int? Capacity { get; set; }
        /// <summary>
        /// Minimum capacity to achieve which cannot be updated. If we will not be able to "guarantee" minimum capacity, we will reject
        /// the request in the sync path itself.
        /// </summary>
        int? MinCapacity { get; set; }

    }
}