// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents a maintenance update parameter.</summary>
    public partial class MaintenanceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceUpdateInternal
    {

        /// <summary>The start time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? MaintenanceStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdateInternal)Property).MaintenanceStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdateInternal)Property).MaintenanceStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdate Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenancePropertiesForUpdate()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdate _property;

        /// <summary>The properties of a maintenance update parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenancePropertiesForUpdate()); set => this._property = value; }

        /// <summary>Creates an new <see cref="MaintenanceUpdate" /> instance.</summary>
        public MaintenanceUpdate()
        {

        }
    }
    /// Represents a maintenance update parameter.
    public partial interface IMaintenanceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The start time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The start time for a maintenance.",
        SerializedName = @"maintenanceStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MaintenanceStartTime { get; set; }

    }
    /// Represents a maintenance update parameter.
    internal partial interface IMaintenanceUpdateInternal

    {
        /// <summary>The start time for a maintenance.</summary>
        global::System.DateTime? MaintenanceStartTime { get; set; }
        /// <summary>The properties of a maintenance update parameter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdate Property { get; set; }

    }
}