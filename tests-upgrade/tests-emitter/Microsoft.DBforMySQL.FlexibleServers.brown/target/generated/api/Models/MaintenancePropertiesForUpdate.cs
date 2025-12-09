// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of a maintenance update parameter.</summary>
    public partial class MaintenancePropertiesForUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesForUpdateInternal
    {

        /// <summary>Backing field for <see cref="MaintenanceStartTime" /> property.</summary>
        private global::System.DateTime? _maintenanceStartTime;

        /// <summary>The start time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceStartTime { get => this._maintenanceStartTime; set => this._maintenanceStartTime = value; }

        /// <summary>Creates an new <see cref="MaintenancePropertiesForUpdate" /> instance.</summary>
        public MaintenancePropertiesForUpdate()
        {

        }
    }
    /// The properties of a maintenance update parameter.
    public partial interface IMaintenancePropertiesForUpdate :
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
    /// The properties of a maintenance update parameter.
    internal partial interface IMaintenancePropertiesForUpdateInternal

    {
        /// <summary>The start time for a maintenance.</summary>
        global::System.DateTime? MaintenanceStartTime { get; set; }

    }
}