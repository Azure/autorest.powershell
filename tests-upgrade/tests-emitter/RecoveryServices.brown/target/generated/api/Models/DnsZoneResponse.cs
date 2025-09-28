// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>DNSZone information for Microsoft.RecoveryServices</summary>
    public partial class DnsZoneResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone __dnsZone = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.DnsZone();

        /// <summary>Backing field for <see cref="RequiredZoneName" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredZoneName;

        /// <summary>The private link resource Private link DNS zone names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredZoneName { get => this._requiredZoneName; set => this._requiredZoneName = value; }

        /// <summary>
        /// Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inherited)]
        public string SubResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneInternal)__dnsZone).SubResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneInternal)__dnsZone).SubResource = value ?? null; }

        /// <summary>Creates an new <see cref="DnsZoneResponse" /> instance.</summary>
        public DnsZoneResponse()
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
            await eventListener.AssertNotNull(nameof(__dnsZone), __dnsZone);
            await eventListener.AssertObjectIsValid(nameof(__dnsZone), __dnsZone);
        }
    }
    /// DNSZone information for Microsoft.RecoveryServices
    public partial interface IDnsZoneResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone
    {
        /// <summary>The private link resource Private link DNS zone names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link resource Private link DNS zone names.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
    /// DNSZone information for Microsoft.RecoveryServices
    internal partial interface IDnsZoneResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneInternal
    {
        /// <summary>The private link resource Private link DNS zone names.</summary>
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
}