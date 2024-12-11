// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies OS Image Scheduled Event related configurations.</summary>
    public partial class OSImageNotificationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfileInternal
    {

        /// <summary>Backing field for <see cref="Enable" /> property.</summary>
        private bool? _enable;

        /// <summary>Specifies whether the OS Image Scheduled event is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Enable { get => this._enable; set => this._enable = value; }

        /// <summary>Backing field for <see cref="NotBeforeTimeout" /> property.</summary>
        private string _notBeforeTimeout;

        /// <summary>
        /// Length of time a Virtual Machine being reimaged or having its OS upgraded will
        /// have to potentially approve the OS Image Scheduled Event before the event is
        /// auto approved (timed out). The configuration is specified in ISO 8601 format,
        /// and the value must not exceed 15 minutes (PT15M)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string NotBeforeTimeout { get => this._notBeforeTimeout; set => this._notBeforeTimeout = value; }

        /// <summary>Creates an new <see cref="OSImageNotificationProfile" /> instance.</summary>
        public OSImageNotificationProfile()
        {

        }
    }
    /// Specifies OS Image Scheduled Event related configurations.
    public partial interface IOSImageNotificationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specifies whether the OS Image Scheduled event is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the OS Image Scheduled event is enabled or disabled.",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enable { get; set; }
        /// <summary>
        /// Length of time a Virtual Machine being reimaged or having its OS upgraded will
        /// have to potentially approve the OS Image Scheduled Event before the event is
        /// auto approved (timed out). The configuration is specified in ISO 8601 format,
        /// and the value must not exceed 15 minutes (PT15M)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Length of time a Virtual Machine being reimaged or having its OS upgraded will
        have to potentially approve the OS Image Scheduled Event before the event is
        auto approved (timed out). The configuration is specified in ISO 8601 format,
        and the value must not exceed 15 minutes (PT15M)",
        SerializedName = @"notBeforeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string NotBeforeTimeout { get; set; }

    }
    /// Specifies OS Image Scheduled Event related configurations.
    internal partial interface IOSImageNotificationProfileInternal

    {
        /// <summary>Specifies whether the OS Image Scheduled event is enabled or disabled.</summary>
        bool? Enable { get; set; }
        /// <summary>
        /// Length of time a Virtual Machine being reimaged or having its OS upgraded will
        /// have to potentially approve the OS Image Scheduled Event before the event is
        /// auto approved (timed out). The configuration is specified in ISO 8601 format,
        /// and the value must not exceed 15 minutes (PT15M)
        /// </summary>
        string NotBeforeTimeout { get; set; }

    }
}