// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifications about a VM Size. This will also contain the corresponding rank and weight in future.
    /// </summary>
    public partial class VMSizeProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMSizeProfileInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The Sku name (e.g. 'Standard_DS1_v2')</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Rank" /> property.</summary>
        private int? _rank;

        /// <summary>
        /// The rank of the VM size. This is used with 'RegularPriorityAllocationStrategy.Prioritized'
        /// The lower the number, the higher the priority. Starting with 0.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? Rank { get => this._rank; set => this._rank = value; }

        /// <summary>Creates an new <see cref="VMSizeProfile" /> instance.</summary>
        public VMSizeProfile()
        {

        }
    }
    /// Specifications about a VM Size. This will also contain the corresponding rank and weight in future.
    public partial interface IVMSizeProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The Sku name (e.g. 'Standard_DS1_v2')</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Sku name (e.g. 'Standard_DS1_v2')",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The rank of the VM size. This is used with 'RegularPriorityAllocationStrategy.Prioritized'
        /// The lower the number, the higher the priority. Starting with 0.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The rank of the VM size. This is used with 'RegularPriorityAllocationStrategy.Prioritized'
        The lower the number, the higher the priority. Starting with 0.",
        SerializedName = @"rank",
        PossibleTypes = new [] { typeof(int) })]
        int? Rank { get; set; }

    }
    /// Specifications about a VM Size. This will also contain the corresponding rank and weight in future.
    internal partial interface IVMSizeProfileInternal

    {
        /// <summary>The Sku name (e.g. 'Standard_DS1_v2')</summary>
        string Name { get; set; }
        /// <summary>
        /// The rank of the VM size. This is used with 'RegularPriorityAllocationStrategy.Prioritized'
        /// The lower the number, the higher the priority. Starting with 0.
        /// </summary>
        int? Rank { get; set; }

    }
}