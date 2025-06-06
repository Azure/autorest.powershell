// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// While retrieving VMSizes from CRS, Min = 0 (uint.MinValue) if not specified, Max = 4294967295 (uint.MaxValue) if not specified.
    /// This allows to filter VMAttributes on all available VMSizes.
    /// </summary>
    public partial class VMAttributeMinMaxInteger :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal
    {

        /// <summary>Backing field for <see cref="Max" /> property.</summary>
        private int? _max;

        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? Max { get => this._max; set => this._max = value; }

        /// <summary>Backing field for <see cref="Min" /> property.</summary>
        private int? _min;

        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? Min { get => this._min; set => this._min = value; }

        /// <summary>Creates an new <see cref="VMAttributeMinMaxInteger" /> instance.</summary>
        public VMAttributeMinMaxInteger()
        {

        }
    }
    /// While retrieving VMSizes from CRS, Min = 0 (uint.MinValue) if not specified, Max = 4294967295 (uint.MaxValue) if not specified.
    /// This allows to filter VMAttributes on all available VMSizes.
    public partial interface IVMAttributeMinMaxInteger :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? Max { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? Min { get; set; }

    }
    /// While retrieving VMSizes from CRS, Min = 0 (uint.MinValue) if not specified, Max = 4294967295 (uint.MaxValue) if not specified.
    /// This allows to filter VMAttributes on all available VMSizes.
    internal partial interface IVMAttributeMinMaxIntegerInternal

    {
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        int? Max { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        int? Min { get; set; }

    }
}