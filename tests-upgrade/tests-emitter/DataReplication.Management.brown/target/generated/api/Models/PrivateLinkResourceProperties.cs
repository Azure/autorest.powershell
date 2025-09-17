// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Represents private link resource properties.</summary>
    public partial class PrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>Gets or sets the group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; set => this._groupId = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateLinkResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets or sets the provisioning state of the private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RequiredMember" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredMember;

        /// <summary>
        /// Gets or sets the required member. This translates to how many Private IPs should be created for each privately linkable
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredMember { get => this._requiredMember; set => this._requiredMember = value; }

        /// <summary>Backing field for <see cref="RequiredZoneName" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredZoneName;

        /// <summary>Gets or sets the private DNS zone names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredZoneName { get => this._requiredZoneName; set => this._requiredZoneName = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceProperties" /> instance.</summary>
        public PrivateLinkResourceProperties()
        {

        }
    }
    /// Represents private link resource properties.
    public partial interface IPrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the group id.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get; set; }
        /// <summary>Gets or sets the provisioning state of the private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the private link resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>
        /// Gets or sets the required member. This translates to how many Private IPs should be created for each privately linkable
        /// resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the required member. This translates to how many Private IPs should be created for each privately linkable resource.",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredMember { get; set; }
        /// <summary>Gets or sets the private DNS zone names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the private DNS zone names.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
    /// Represents private link resource properties.
    internal partial interface IPrivateLinkResourcePropertiesInternal

    {
        /// <summary>Gets or sets the group id.</summary>
        string GroupId { get; set; }
        /// <summary>Gets or sets the provisioning state of the private link resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// Gets or sets the required member. This translates to how many Private IPs should be created for each privately linkable
        /// resource.
        /// </summary>
        System.Collections.Generic.List<string> RequiredMember { get; set; }
        /// <summary>Gets or sets the private DNS zone names.</summary>
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
}