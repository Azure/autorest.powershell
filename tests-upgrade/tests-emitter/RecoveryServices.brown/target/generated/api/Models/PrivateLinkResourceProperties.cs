// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Properties of the private link resource.</summary>
    public partial class PrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>
        /// e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081 (Backup) or f9ad6492-33d4-4690-9999-6bfd52a0d082 (SiteRecovery)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkResourcePropertiesInternal.GroupId { get => this._groupId; set { {_groupId = value;} } }

        /// <summary>Internal Acessors for RequiredMember</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkResourcePropertiesInternal.RequiredMember { get => this._requiredMember; set { {_requiredMember = value;} } }

        /// <summary>Internal Acessors for RequiredZoneName</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateLinkResourcePropertiesInternal.RequiredZoneName { get => this._requiredZoneName; set { {_requiredZoneName = value;} } }

        /// <summary>Backing field for <see cref="RequiredMember" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredMember;

        /// <summary>[backup-ecs1, backup-prot1, backup-prot1b, backup-prot1c, backup-id1]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredMember { get => this._requiredMember; }

        /// <summary>Backing field for <see cref="RequiredZoneName" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredZoneName;

        /// <summary>The private link resource Private link DNS zone name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredZoneName { get => this._requiredZoneName; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceProperties" /> instance.</summary>
        public PrivateLinkResourceProperties()
        {

        }
    }
    /// Properties of the private link resource.
    public partial interface IPrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081 (Backup) or f9ad6492-33d4-4690-9999-6bfd52a0d082 (SiteRecovery)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081 (Backup) or f9ad6492-33d4-4690-9999-6bfd52a0d082 (SiteRecovery)",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get;  }
        /// <summary>[backup-ecs1, backup-prot1, backup-prot1b, backup-prot1c, backup-id1]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"[backup-ecs1, backup-prot1, backup-prot1b, backup-prot1c, backup-id1]",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredMember { get;  }
        /// <summary>The private link resource Private link DNS zone name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The private link resource Private link DNS zone name.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredZoneName { get;  }

    }
    /// Properties of the private link resource.
    internal partial interface IPrivateLinkResourcePropertiesInternal

    {
        /// <summary>
        /// e.g. f9ad6492-33d4-4690-9999-6bfd52a0d081 (Backup) or f9ad6492-33d4-4690-9999-6bfd52a0d082 (SiteRecovery)
        /// </summary>
        string GroupId { get; set; }
        /// <summary>[backup-ecs1, backup-prot1, backup-prot1b, backup-prot1c, backup-id1]</summary>
        System.Collections.Generic.List<string> RequiredMember { get; set; }
        /// <summary>The private link resource Private link DNS zone name.</summary>
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
}