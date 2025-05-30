// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Device insight report.</summary>
    public partial class DeviceInsight :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInsight,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceInsightInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Event description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DeviceId" /> property.</summary>
        private string _deviceId;

        /// <summary>Device ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceId { get => this._deviceId; set => this._deviceId = value; }

        /// <summary>Backing field for <see cref="EndTimestampUtc" /> property.</summary>
        private global::System.DateTime _endTimestampUtc;

        /// <summary>Event end timestamp</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime EndTimestampUtc { get => this._endTimestampUtc; set => this._endTimestampUtc = value; }

        /// <summary>Backing field for <see cref="EventCategory" /> property.</summary>
        private string _eventCategory;

        /// <summary>Event category</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string EventCategory { get => this._eventCategory; set => this._eventCategory = value; }

        /// <summary>Backing field for <see cref="EventClass" /> property.</summary>
        private string _eventClass;

        /// <summary>Event class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string EventClass { get => this._eventClass; set => this._eventClass = value; }

        /// <summary>Backing field for <see cref="EventCount" /> property.</summary>
        private int _eventCount;

        /// <summary>Event count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public int EventCount { get => this._eventCount; set => this._eventCount = value; }

        /// <summary>Backing field for <see cref="EventType" /> property.</summary>
        private string _eventType;

        /// <summary>Event type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string EventType { get => this._eventType; set => this._eventType = value; }

        /// <summary>Backing field for <see cref="StartTimestampUtc" /> property.</summary>
        private global::System.DateTime _startTimestampUtc;

        /// <summary>Event start timestamp</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public global::System.DateTime StartTimestampUtc { get => this._startTimestampUtc; set => this._startTimestampUtc = value; }

        /// <summary>Creates an new <see cref="DeviceInsight" /> instance.</summary>
        public DeviceInsight()
        {

        }
    }
    /// Device insight report.
    public partial interface IDeviceInsight :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Event description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event description",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Device ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device ID",
        SerializedName = @"deviceId",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceId { get; set; }
        /// <summary>Event end timestamp</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event end timestamp",
        SerializedName = @"endTimestampUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime EndTimestampUtc { get; set; }
        /// <summary>Event category</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event category",
        SerializedName = @"eventCategory",
        PossibleTypes = new [] { typeof(string) })]
        string EventCategory { get; set; }
        /// <summary>Event class</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event class",
        SerializedName = @"eventClass",
        PossibleTypes = new [] { typeof(string) })]
        string EventClass { get; set; }
        /// <summary>Event count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event count",
        SerializedName = @"eventCount",
        PossibleTypes = new [] { typeof(int) })]
        int EventCount { get; set; }
        /// <summary>Event type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event type",
        SerializedName = @"eventType",
        PossibleTypes = new [] { typeof(string) })]
        string EventType { get; set; }
        /// <summary>Event start timestamp</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Event start timestamp",
        SerializedName = @"startTimestampUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTimestampUtc { get; set; }

    }
    /// Device insight report.
    internal partial interface IDeviceInsightInternal

    {
        /// <summary>Event description</summary>
        string Description { get; set; }
        /// <summary>Device ID</summary>
        string DeviceId { get; set; }
        /// <summary>Event end timestamp</summary>
        global::System.DateTime EndTimestampUtc { get; set; }
        /// <summary>Event category</summary>
        string EventCategory { get; set; }
        /// <summary>Event class</summary>
        string EventClass { get; set; }
        /// <summary>Event count</summary>
        int EventCount { get; set; }
        /// <summary>Event type</summary>
        string EventType { get; set; }
        /// <summary>Event start timestamp</summary>
        global::System.DateTime StartTimestampUtc { get; set; }

    }
}