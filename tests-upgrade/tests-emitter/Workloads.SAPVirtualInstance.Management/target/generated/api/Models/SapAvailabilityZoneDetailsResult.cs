// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The list of supported availability zone pairs which are part of SAP HA deployment.
    /// </summary>
    public partial class SapAvailabilityZoneDetailsResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZoneDetailsResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZoneDetailsResultInternal
    {

        /// <summary>Backing field for <see cref="AvailabilityZonePair" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePair> _availabilityZonePair;

        /// <summary>Gets the list of availability zone pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePair> AvailabilityZonePair { get => this._availabilityZonePair; set => this._availabilityZonePair = value; }

        /// <summary>Creates an new <see cref="SapAvailabilityZoneDetailsResult" /> instance.</summary>
        public SapAvailabilityZoneDetailsResult()
        {

        }
    }
    /// The list of supported availability zone pairs which are part of SAP HA deployment.
    public partial interface ISapAvailabilityZoneDetailsResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Gets the list of availability zone pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets the list of availability zone pairs.",
        SerializedName = @"availabilityZonePairs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePair) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePair> AvailabilityZonePair { get; set; }

    }
    /// The list of supported availability zone pairs which are part of SAP HA deployment.
    internal partial interface ISapAvailabilityZoneDetailsResultInternal

    {
        /// <summary>Gets the list of availability zone pairs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZonePair> AvailabilityZonePair { get; set; }

    }
}