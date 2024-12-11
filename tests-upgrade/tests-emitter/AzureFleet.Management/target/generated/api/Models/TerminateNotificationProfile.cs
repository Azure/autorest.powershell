// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies Terminate Scheduled Event related configurations.</summary>
    public partial class TerminateNotificationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfileInternal
    {

        /// <summary>Backing field for <see cref="Enable" /> property.</summary>
        private bool? _enable;

        /// <summary>Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? Enable { get => this._enable; set => this._enable = value; }

        /// <summary>Backing field for <see cref="NotBeforeTimeout" /> property.</summary>
        private string _notBeforeTimeout;

        /// <summary>
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string NotBeforeTimeout { get => this._notBeforeTimeout; set => this._notBeforeTimeout = value; }

        /// <summary>Creates an new <see cref="TerminateNotificationProfile" /> instance.</summary>
        public TerminateNotificationProfile()
        {

        }
    }
    /// Specifies Terminate Scheduled Event related configurations.
    public partial interface ITerminateNotificationProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the Terminate Scheduled event is enabled or disabled.",
        SerializedName = @"enable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enable { get; set; }
        /// <summary>
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Configurable length of time a Virtual Machine being deleted will have to
        potentially approve the Terminate Scheduled Event before the event is auto
        approved (timed out). The configuration must be specified in ISO 8601 format,
        the default value is 5 minutes (PT5M)",
        SerializedName = @"notBeforeTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string NotBeforeTimeout { get; set; }

    }
    /// Specifies Terminate Scheduled Event related configurations.
    internal partial interface ITerminateNotificationProfileInternal

    {
        /// <summary>Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
        bool? Enable { get; set; }
        /// <summary>
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </summary>
        string NotBeforeTimeout { get; set; }

    }
}