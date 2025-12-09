// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of a maintenance resource.</summary>
    public partial class MaintenanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal
    {

        /// <summary>Backing field for <see cref="MaintenanceAvailableScheduleMaxTime" /> property.</summary>
        private global::System.DateTime? _maintenanceAvailableScheduleMaxTime;

        /// <summary>The max time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceAvailableScheduleMaxTime { get => this._maintenanceAvailableScheduleMaxTime; }

        /// <summary>Backing field for <see cref="MaintenanceAvailableScheduleMinTime" /> property.</summary>
        private global::System.DateTime? _maintenanceAvailableScheduleMinTime;

        /// <summary>The min time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceAvailableScheduleMinTime { get => this._maintenanceAvailableScheduleMinTime; }

        /// <summary>Backing field for <see cref="MaintenanceDescription" /> property.</summary>
        private string _maintenanceDescription;

        /// <summary>The maintenance description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string MaintenanceDescription { get => this._maintenanceDescription; }

        /// <summary>Backing field for <see cref="MaintenanceEndTime" /> property.</summary>
        private global::System.DateTime? _maintenanceEndTime;

        /// <summary>The end time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceEndTime { get => this._maintenanceEndTime; }

        /// <summary>Backing field for <see cref="MaintenanceExecutionEndTime" /> property.</summary>
        private global::System.DateTime? _maintenanceExecutionEndTime;

        /// <summary>The end time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceExecutionEndTime { get => this._maintenanceExecutionEndTime; }

        /// <summary>Backing field for <see cref="MaintenanceExecutionStartTime" /> property.</summary>
        private global::System.DateTime? _maintenanceExecutionStartTime;

        /// <summary>The start time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceExecutionStartTime { get => this._maintenanceExecutionStartTime; }

        /// <summary>Backing field for <see cref="MaintenanceStartTime" /> property.</summary>
        private global::System.DateTime? _maintenanceStartTime;

        /// <summary>The start time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? MaintenanceStartTime { get => this._maintenanceStartTime; set => this._maintenanceStartTime = value; }

        /// <summary>Backing field for <see cref="MaintenanceState" /> property.</summary>
        private string _maintenanceState;

        /// <summary>A string describes the maintenance status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string MaintenanceState { get => this._maintenanceState; }

        /// <summary>Backing field for <see cref="MaintenanceTitle" /> property.</summary>
        private string _maintenanceTitle;

        /// <summary>The maintenance title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string MaintenanceTitle { get => this._maintenanceTitle; }

        /// <summary>Backing field for <see cref="MaintenanceType" /> property.</summary>
        private string _maintenanceType;

        /// <summary>A string defines maintenance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string MaintenanceType { get => this._maintenanceType; }

        /// <summary>Internal Acessors for MaintenanceAvailableScheduleMaxTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceAvailableScheduleMaxTime { get => this._maintenanceAvailableScheduleMaxTime; set { {_maintenanceAvailableScheduleMaxTime = value;} } }

        /// <summary>Internal Acessors for MaintenanceAvailableScheduleMinTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceAvailableScheduleMinTime { get => this._maintenanceAvailableScheduleMinTime; set { {_maintenanceAvailableScheduleMinTime = value;} } }

        /// <summary>Internal Acessors for MaintenanceDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceDescription { get => this._maintenanceDescription; set { {_maintenanceDescription = value;} } }

        /// <summary>Internal Acessors for MaintenanceEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceEndTime { get => this._maintenanceEndTime; set { {_maintenanceEndTime = value;} } }

        /// <summary>Internal Acessors for MaintenanceExecutionEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceExecutionEndTime { get => this._maintenanceExecutionEndTime; set { {_maintenanceExecutionEndTime = value;} } }

        /// <summary>Internal Acessors for MaintenanceExecutionStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceExecutionStartTime { get => this._maintenanceExecutionStartTime; set { {_maintenanceExecutionStartTime = value;} } }

        /// <summary>Internal Acessors for MaintenanceState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceState { get => this._maintenanceState; set { {_maintenanceState = value;} } }

        /// <summary>Internal Acessors for MaintenanceTitle</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceTitle { get => this._maintenanceTitle; set { {_maintenanceTitle = value;} } }

        /// <summary>Internal Acessors for MaintenanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.MaintenanceType { get => this._maintenanceType; set { {_maintenanceType = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the Maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="MaintenanceProperties" /> instance.</summary>
        public MaintenanceProperties()
        {

        }
    }
    /// The properties of a maintenance resource.
    public partial interface IMaintenanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The max time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The max time the maintenance can be rescheduled.",
        SerializedName = @"maintenanceAvailableScheduleMaxTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MaintenanceAvailableScheduleMaxTime { get;  }
        /// <summary>The min time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The min time the maintenance can be rescheduled.",
        SerializedName = @"maintenanceAvailableScheduleMinTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MaintenanceAvailableScheduleMinTime { get;  }
        /// <summary>The maintenance description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The maintenance description.",
        SerializedName = @"maintenanceDescription",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceDescription { get;  }
        /// <summary>The end time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The end time for a maintenance.",
        SerializedName = @"maintenanceEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MaintenanceEndTime { get;  }
        /// <summary>The end time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The end time for a maintenance execution.",
        SerializedName = @"maintenanceExecutionEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MaintenanceExecutionEndTime { get;  }
        /// <summary>The start time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The start time for a maintenance execution.",
        SerializedName = @"maintenanceExecutionStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? MaintenanceExecutionStartTime { get;  }
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
        /// <summary>A string describes the maintenance status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A string describes the maintenance status",
        SerializedName = @"maintenanceState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Scheduled", "ReScheduled", "InPreparation", "Processing", "Completed", "Canceled")]
        string MaintenanceState { get;  }
        /// <summary>The maintenance title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The maintenance title.",
        SerializedName = @"maintenanceTitle",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceTitle { get;  }
        /// <summary>A string defines maintenance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A string defines maintenance type.",
        SerializedName = @"maintenanceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("RoutineMaintenance", "MinorVersionUpgrade", "SecurityPatches", "HotFixes")]
        string MaintenanceType { get;  }
        /// <summary>Provisioning state of the Maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the Maintenance.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get;  }

    }
    /// The properties of a maintenance resource.
    internal partial interface IMaintenancePropertiesInternal

    {
        /// <summary>The max time the maintenance can be rescheduled.</summary>
        global::System.DateTime? MaintenanceAvailableScheduleMaxTime { get; set; }
        /// <summary>The min time the maintenance can be rescheduled.</summary>
        global::System.DateTime? MaintenanceAvailableScheduleMinTime { get; set; }
        /// <summary>The maintenance description.</summary>
        string MaintenanceDescription { get; set; }
        /// <summary>The end time for a maintenance.</summary>
        global::System.DateTime? MaintenanceEndTime { get; set; }
        /// <summary>The end time for a maintenance execution.</summary>
        global::System.DateTime? MaintenanceExecutionEndTime { get; set; }
        /// <summary>The start time for a maintenance execution.</summary>
        global::System.DateTime? MaintenanceExecutionStartTime { get; set; }
        /// <summary>The start time for a maintenance.</summary>
        global::System.DateTime? MaintenanceStartTime { get; set; }
        /// <summary>A string describes the maintenance status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Scheduled", "ReScheduled", "InPreparation", "Processing", "Completed", "Canceled")]
        string MaintenanceState { get; set; }
        /// <summary>The maintenance title.</summary>
        string MaintenanceTitle { get; set; }
        /// <summary>A string defines maintenance type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("RoutineMaintenance", "MinorVersionUpgrade", "SecurityPatches", "HotFixes")]
        string MaintenanceType { get; set; }
        /// <summary>Provisioning state of the Maintenance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get; set; }

    }
}