// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP Availability Zone Pair.</summary>
    public partial class SapAvailabilityZonePair :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePair,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePairInternal
    {

        /// <summary>Backing field for <see cref="ZoneA" /> property.</summary>
        private long? _zoneA;

        /// <summary>The zone A.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? ZoneA { get => this._zoneA; set => this._zoneA = value; }

        /// <summary>Backing field for <see cref="ZoneB" /> property.</summary>
        private long? _zoneB;

        /// <summary>The zone B.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long? ZoneB { get => this._zoneB; set => this._zoneB = value; }

        /// <summary>Creates an new <see cref="SapAvailabilityZonePair" /> instance.</summary>
        public SapAvailabilityZonePair()
        {

        }
    }
    /// The SAP Availability Zone Pair.
    public partial interface ISapAvailabilityZonePair :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The zone A.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The zone A.",
        SerializedName = @"zoneA",
        PossibleTypes = new [] { typeof(long) })]
        long? ZoneA { get; set; }
        /// <summary>The zone B.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The zone B.",
        SerializedName = @"zoneB",
        PossibleTypes = new [] { typeof(long) })]
        long? ZoneB { get; set; }

    }
    /// The SAP Availability Zone Pair.
    internal partial interface ISapAvailabilityZonePairInternal

    {
        /// <summary>The zone A.</summary>
        long? ZoneA { get; set; }
        /// <summary>The zone B.</summary>
        long? ZoneB { get; set; }

    }
}