// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Managed identity properties.</summary>
    public partial class IdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal
    {

        /// <summary>Internal Acessors for UserAssigned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal.UserAssigned { get => (this._userAssigned = this._userAssigned ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UserAssignedProperties()); set { {_userAssigned = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="UserAssigned" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties _userAssigned;

        /// <summary>User assigned identity properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties UserAssigned { get => (this._userAssigned = this._userAssigned ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UserAssignedProperties()); set => this._userAssigned = value; }

        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string UserAssignedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedPropertiesInternal)UserAssigned).ResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedPropertiesInternal)UserAssigned).ResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="IdentityProperties" /> instance.</summary>
        public IdentityProperties()
        {

        }
    }
    /// Managed identity properties.
    public partial interface IIdentityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed service identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Arm resource id for user assigned identity to be used to fetch MSI token.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedResourceId { get; set; }

    }
    /// Managed identity properties.
    internal partial interface IIdentityPropertiesInternal

    {
        /// <summary>Managed service identity type.</summary>
        string Type { get; set; }
        /// <summary>User assigned identity properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties UserAssigned { get; set; }
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        string UserAssignedResourceId { get; set; }

    }
}