// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>DNSZone information</summary>
    public partial class DnsZone :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZone,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IDnsZoneInternal
    {

        /// <summary>Backing field for <see cref="SubResource" /> property.</summary>
        private string _subResource;

        /// <summary>
        /// Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string SubResource { get => this._subResource; set => this._subResource = value; }

        /// <summary>Creates an new <see cref="DnsZone" /> instance.</summary>
        public DnsZone()
        {

        }
    }
    /// DNSZone information
    public partial interface IDnsZone :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery",
        SerializedName = @"subResource",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("AzureBackup", "AzureBackup_secondary", "AzureSiteRecovery")]
        string SubResource { get; set; }

    }
    /// DNSZone information
    internal partial interface IDnsZoneInternal

    {
        /// <summary>
        /// Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("AzureBackup", "AzureBackup_secondary", "AzureSiteRecovery")]
        string SubResource { get; set; }

    }
}