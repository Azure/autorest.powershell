// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Capabilities response for Microsoft.RecoveryServices</summary>
    public partial class CapabilitiesResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase __resourceCapabilitiesBase = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCapabilitiesBase();

        /// <summary>Array of DNSZoneResponse</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse> DnsZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponsePropertiesInternal)Property).DnsZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponsePropertiesInternal)Property).DnsZone = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CapabilitiesResponseProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseProperties _property;

        /// <summary>Capabilities properties in response</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CapabilitiesResponseProperties()); set => this._property = value; }

        /// <summary>Describes the Resource type: Microsoft.RecoveryServices/Vaults</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal)__resourceCapabilitiesBase).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal)__resourceCapabilitiesBase).Type = value ; }

        /// <summary>Creates an new <see cref="CapabilitiesResponse" /> instance.</summary>
        public CapabilitiesResponse()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceCapabilitiesBase), __resourceCapabilitiesBase);
            await eventListener.AssertObjectIsValid(nameof(__resourceCapabilitiesBase), __resourceCapabilitiesBase);
        }
    }
    /// Capabilities response for Microsoft.RecoveryServices
    public partial interface ICapabilitiesResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase
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
    /// Capabilities response for Microsoft.RecoveryServices
    internal partial interface ICapabilitiesResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal
    {
        /// <summary>Array of DNSZoneResponse</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse> DnsZone { get; set; }
        /// <summary>Capabilities properties in response</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesResponseProperties Property { get; set; }

    }
}