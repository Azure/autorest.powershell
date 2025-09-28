// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Input to get capabilities information for Microsoft.RecoveryServices</summary>
    public partial class ResourceCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilities,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase __resourceCapabilitiesBase = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ResourceCapabilitiesBase();

        /// <summary>Array of DNSZone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone> DnsZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesPropertiesInternal)Property).DnsZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesPropertiesInternal)Property).DnsZone = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CapabilitiesProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesProperties _property;

        /// <summary>Capabilities information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.CapabilitiesProperties()); set => this._property = value; }

        /// <summary>Describes the Resource type: Microsoft.RecoveryServices/Vaults</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal)__resourceCapabilitiesBase).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal)__resourceCapabilitiesBase).Type = value ; }

        /// <summary>Creates an new <see cref="ResourceCapabilities" /> instance.</summary>
        public ResourceCapabilities()
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
    /// Input to get capabilities information for Microsoft.RecoveryServices
    public partial interface IResourceCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBase
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
    /// Input to get capabilities information for Microsoft.RecoveryServices
    internal partial interface IResourceCapabilitiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IResourceCapabilitiesBaseInternal
    {
        /// <summary>Array of DNSZone</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone> DnsZone { get; set; }
        /// <summary>Capabilities information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ICapabilitiesProperties Property { get; set; }

    }
}