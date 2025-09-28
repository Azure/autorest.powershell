// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Capabilities information</summary>
    public partial class CapabilitiesProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DnsZone" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone> _dnsZone;

        /// <summary>Array of DNSZone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone> DnsZone { get => this._dnsZone; set => this._dnsZone = value; }

        /// <summary>Creates an new <see cref="CapabilitiesProperties" /> instance.</summary>
        public CapabilitiesProperties()
        {

        }
    }
    /// Capabilities information
    public partial interface ICapabilitiesProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Array of DNSZone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of DNSZone",
        SerializedName = @"dnsZones",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone> DnsZone { get; set; }

    }
    /// Capabilities information
    internal partial interface ICapabilitiesPropertiesInternal

    {
        /// <summary>Array of DNSZone</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone> DnsZone { get; set; }

    }
}