// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Capabilities properties in response</summary>
    public partial class CapabilitiesResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DnsZone" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse> _dnsZone;

        /// <summary>Array of DNSZoneResponse</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse> DnsZone { get => this._dnsZone; set => this._dnsZone = value; }

        /// <summary>Creates an new <see cref="CapabilitiesResponseProperties" /> instance.</summary>
        public CapabilitiesResponseProperties()
        {

        }
    }
    /// Capabilities properties in response
    public partial interface ICapabilitiesResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Array of DNSZoneResponse</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of DNSZoneResponse",
        SerializedName = @"dnsZones",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse> DnsZone { get; set; }

    }
    /// Capabilities properties in response
    internal partial interface ICapabilitiesResponsePropertiesInternal

    {
        /// <summary>Array of DNSZoneResponse</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse> DnsZone { get; set; }

    }
}