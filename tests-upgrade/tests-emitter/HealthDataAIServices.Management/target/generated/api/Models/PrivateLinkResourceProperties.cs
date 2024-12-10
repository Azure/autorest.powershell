// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>Properties of a private link resource.</summary>
    public partial class PrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>The private link resource group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResourcePropertiesInternal.GroupId { get => this._groupId; set { {_groupId = value;} } }

        /// <summary>Internal Acessors for RequiredMember</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResourcePropertiesInternal.RequiredMember { get => this._requiredMember; set { {_requiredMember = value;} } }

        /// <summary>Backing field for <see cref="RequiredMember" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredMember;

        /// <summary>The private link resource required member names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredMember { get => this._requiredMember; }

        /// <summary>Backing field for <see cref="RequiredZoneName" /> property.</summary>
        private System.Collections.Generic.List<string> _requiredZoneName;

        /// <summary>The private link resource private link DNS zone name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> RequiredZoneName { get => this._requiredZoneName; set => this._requiredZoneName = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceProperties" /> instance.</summary>
        public PrivateLinkResourceProperties()
        {

        }
    }
    /// Properties of a private link resource.
    public partial interface IPrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
    {
        /// <summary>The private link resource group id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The private link resource group id.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get;  }
        /// <summary>The private link resource required member names.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The private link resource required member names.",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredMember { get;  }
        /// <summary>The private link resource private link DNS zone name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link resource private link DNS zone name.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
    /// Properties of a private link resource.
    internal partial interface IPrivateLinkResourcePropertiesInternal

    {
        /// <summary>The private link resource group id.</summary>
        string GroupId { get; set; }
        /// <summary>The private link resource required member names.</summary>
        System.Collections.Generic.List<string> RequiredMember { get; set; }
        /// <summary>The private link resource private link DNS zone name.</summary>
        System.Collections.Generic.List<string> RequiredZoneName { get; set; }

    }
}