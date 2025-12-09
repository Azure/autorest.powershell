// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Maintenance window of a server.</summary>
    public partial class MaintenanceWindow :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindow,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceWindowInternal
    {

        /// <summary>Backing field for <see cref="BatchOfMaintenance" /> property.</summary>
        private string _batchOfMaintenance;

        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BatchOfMaintenance { get => this._batchOfMaintenance; set => this._batchOfMaintenance = value; }

        /// <summary>Backing field for <see cref="CustomWindow" /> property.</summary>
        private string _customWindow;

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string CustomWindow { get => this._customWindow; set => this._customWindow = value; }

        /// <summary>Backing field for <see cref="DayOfWeek" /> property.</summary>
        private int? _dayOfWeek;

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? DayOfWeek { get => this._dayOfWeek; set => this._dayOfWeek = value; }

        /// <summary>Backing field for <see cref="StartHour" /> property.</summary>
        private int? _startHour;

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? StartHour { get => this._startHour; set => this._startHour = value; }

        /// <summary>Backing field for <see cref="StartMinute" /> property.</summary>
        private int? _startMinute;

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? StartMinute { get => this._startMinute; set => this._startMinute = value; }

        /// <summary>Creates an new <see cref="MaintenanceWindow" /> instance.</summary>
        public MaintenanceWindow()
        {

        }
    }
    /// Maintenance window of a server.
    public partial interface IMaintenanceWindow :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The batch of maintenance when enabled the custom managed maintenance window of a server.",
        SerializedName = @"batchOfMaintenance",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "Batch1", "Batch2")]
        string BatchOfMaintenance { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"indicates whether custom window is enabled or disabled",
        SerializedName = @"customWindow",
        PossibleTypes = new [] { typeof(string) })]
        string CustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"day of week for maintenance window",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(int) })]
        int? DayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"start hour for maintenance window",
        SerializedName = @"startHour",
        PossibleTypes = new [] { typeof(int) })]
        int? StartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"start minute for maintenance window",
        SerializedName = @"startMinute",
        PossibleTypes = new [] { typeof(int) })]
        int? StartMinute { get; set; }

    }
    /// Maintenance window of a server.
    internal partial interface IMaintenanceWindowInternal

    {
        /// <summary>
        /// The batch of maintenance when enabled the custom managed maintenance window of a server.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Default", "Batch1", "Batch2")]
        string BatchOfMaintenance { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        string CustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        int? DayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        int? StartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        int? StartMinute { get; set; }

    }
}