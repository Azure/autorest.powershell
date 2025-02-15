// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>VMAttributes using double values.</summary>
    public partial class VMAttributeMinMaxDouble :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal
    {

        /// <summary>Backing field for <see cref="Max" /> property.</summary>
        private double? _max;

        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public double? Max { get => this._max; set => this._max = value; }

        /// <summary>Backing field for <see cref="Min" /> property.</summary>
        private double? _min;

        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public double? Min { get => this._min; set => this._min = value; }

        /// <summary>Creates an new <see cref="VMAttributeMinMaxDouble" /> instance.</summary>
        public VMAttributeMinMaxDouble()
        {

        }
    }
    /// VMAttributes using double values.
    public partial interface IVMAttributeMinMaxDouble :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum value. Double.MaxValue(1.7976931348623157E+308)",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(double) })]
        double? Max { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum value. default 0. Double.MinValue()",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(double) })]
        double? Min { get; set; }

    }
    /// VMAttributes using double values.
    internal partial interface IVMAttributeMinMaxDoubleInternal

    {
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        double? Max { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        double? Min { get; set; }

    }
}