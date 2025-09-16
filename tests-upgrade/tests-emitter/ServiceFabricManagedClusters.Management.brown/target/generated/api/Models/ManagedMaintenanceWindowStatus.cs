// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the maintenance window status of the Service Fabric Managed Cluster.</summary>
    public partial class ManagedMaintenanceWindowStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal
    {

        /// <summary>Backing field for <see cref="CanApplyUpdate" /> property.</summary>
        private bool? _canApplyUpdate;

        /// <summary>If updates can be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? CanApplyUpdate { get => this._canApplyUpdate; }

        /// <summary>Backing field for <see cref="IsRegionReady" /> property.</summary>
        private bool? _isRegionReady;

        /// <summary>Indicates if the region is ready to configure maintenance windows.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsRegionReady { get => this._isRegionReady; }

        /// <summary>Backing field for <see cref="IsWindowActive" /> property.</summary>
        private bool? _isWindowActive;

        /// <summary>If maintenance window is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsWindowActive { get => this._isWindowActive; }

        /// <summary>Backing field for <see cref="IsWindowEnabled" /> property.</summary>
        private bool? _isWindowEnabled;

        /// <summary>If maintenance window is enabled on this cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsWindowEnabled { get => this._isWindowEnabled; }

        /// <summary>Backing field for <see cref="LastWindowEndTimeUtc" /> property.</summary>
        private global::System.DateTime? _lastWindowEndTimeUtc;

        /// <summary>Last window end time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? LastWindowEndTimeUtc { get => this._lastWindowEndTimeUtc; }

        /// <summary>Backing field for <see cref="LastWindowStartTimeUtc" /> property.</summary>
        private global::System.DateTime? _lastWindowStartTimeUtc;

        /// <summary>Last window start time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? LastWindowStartTimeUtc { get => this._lastWindowStartTimeUtc; }

        /// <summary>Backing field for <see cref="LastWindowStatusUpdateAtUtc" /> property.</summary>
        private global::System.DateTime? _lastWindowStatusUpdateAtUtc;

        /// <summary>Last window update time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public global::System.DateTime? LastWindowStatusUpdateAtUtc { get => this._lastWindowStatusUpdateAtUtc; }

        /// <summary>Internal Acessors for CanApplyUpdate</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.CanApplyUpdate { get => this._canApplyUpdate; set { {_canApplyUpdate = value;} } }

        /// <summary>Internal Acessors for IsRegionReady</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.IsRegionReady { get => this._isRegionReady; set { {_isRegionReady = value;} } }

        /// <summary>Internal Acessors for IsWindowActive</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.IsWindowActive { get => this._isWindowActive; set { {_isWindowActive = value;} } }

        /// <summary>Internal Acessors for IsWindowEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.IsWindowEnabled { get => this._isWindowEnabled; set { {_isWindowEnabled = value;} } }

        /// <summary>Internal Acessors for LastWindowEndTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.LastWindowEndTimeUtc { get => this._lastWindowEndTimeUtc; set { {_lastWindowEndTimeUtc = value;} } }

        /// <summary>Internal Acessors for LastWindowStartTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.LastWindowStartTimeUtc { get => this._lastWindowStartTimeUtc; set { {_lastWindowStartTimeUtc = value;} } }

        /// <summary>Internal Acessors for LastWindowStatusUpdateAtUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedMaintenanceWindowStatusInternal.LastWindowStatusUpdateAtUtc { get => this._lastWindowStatusUpdateAtUtc; set { {_lastWindowStatusUpdateAtUtc = value;} } }

        /// <summary>Creates an new <see cref="ManagedMaintenanceWindowStatus" /> instance.</summary>
        public ManagedMaintenanceWindowStatus()
        {

        }
    }
    /// Describes the maintenance window status of the Service Fabric Managed Cluster.
    public partial interface IManagedMaintenanceWindowStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>If updates can be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If updates can be applied.",
        SerializedName = @"canApplyUpdates",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CanApplyUpdate { get;  }
        /// <summary>Indicates if the region is ready to configure maintenance windows.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates if the region is ready to configure maintenance windows.",
        SerializedName = @"isRegionReady",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsRegionReady { get;  }
        /// <summary>If maintenance window is active.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If maintenance window is active.",
        SerializedName = @"isWindowActive",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsWindowActive { get;  }
        /// <summary>If maintenance window is enabled on this cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If maintenance window is enabled on this cluster.",
        SerializedName = @"isWindowEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsWindowEnabled { get;  }
        /// <summary>Last window end time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last window end time in UTC.",
        SerializedName = @"lastWindowEndTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastWindowEndTimeUtc { get;  }
        /// <summary>Last window start time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last window start time in UTC.",
        SerializedName = @"lastWindowStartTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastWindowStartTimeUtc { get;  }
        /// <summary>Last window update time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Last window update time in UTC.",
        SerializedName = @"lastWindowStatusUpdateAtUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastWindowStatusUpdateAtUtc { get;  }

    }
    /// Describes the maintenance window status of the Service Fabric Managed Cluster.
    internal partial interface IManagedMaintenanceWindowStatusInternal

    {
        /// <summary>If updates can be applied.</summary>
        bool? CanApplyUpdate { get; set; }
        /// <summary>Indicates if the region is ready to configure maintenance windows.</summary>
        bool? IsRegionReady { get; set; }
        /// <summary>If maintenance window is active.</summary>
        bool? IsWindowActive { get; set; }
        /// <summary>If maintenance window is enabled on this cluster.</summary>
        bool? IsWindowEnabled { get; set; }
        /// <summary>Last window end time in UTC.</summary>
        global::System.DateTime? LastWindowEndTimeUtc { get; set; }
        /// <summary>Last window start time in UTC.</summary>
        global::System.DateTime? LastWindowStartTimeUtc { get; set; }
        /// <summary>Last window update time in UTC.</summary>
        global::System.DateTime? LastWindowStatusUpdateAtUtc { get; set; }

    }
}