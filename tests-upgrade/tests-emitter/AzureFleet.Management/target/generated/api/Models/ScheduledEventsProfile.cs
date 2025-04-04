// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Specifies Scheduled Event related configurations.</summary>
    public partial class ScheduledEventsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal
    {

        /// <summary>Internal Acessors for OSImageNotificationProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal.OSImageNotificationProfile { get => (this._oSImageNotificationProfile = this._oSImageNotificationProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.OSImageNotificationProfile()); set { {_oSImageNotificationProfile = value;} } }

        /// <summary>Internal Acessors for TerminateNotificationProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal.TerminateNotificationProfile { get => (this._terminateNotificationProfile = this._terminateNotificationProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.TerminateNotificationProfile()); set { {_terminateNotificationProfile = value;} } }

        /// <summary>Backing field for <see cref="OSImageNotificationProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile _oSImageNotificationProfile;

        /// <summary>Specifies OS Image Scheduled Event related configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile OSImageNotificationProfile { get => (this._oSImageNotificationProfile = this._oSImageNotificationProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.OSImageNotificationProfile()); set => this._oSImageNotificationProfile = value; }

        /// <summary>Specifies whether the OS Image Scheduled event is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? OSImageNotificationProfileEnable { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfileInternal)OSImageNotificationProfile).Enable; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfileInternal)OSImageNotificationProfile).Enable = value ?? default(bool); }

        /// <summary>
        /// Length of time a Virtual Machine being reimaged or having its OS upgraded will
        /// have to potentially approve the OS Image Scheduled Event before the event is
        /// auto approved (timed out). The configuration is specified in ISO 8601 format,
        /// and the value must not exceed 15 minutes (PT15M)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string OSImageNotificationProfileNotBeforeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfileInternal)OSImageNotificationProfile).NotBeforeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfileInternal)OSImageNotificationProfile).NotBeforeTimeout = value ?? null; }

        /// <summary>Backing field for <see cref="TerminateNotificationProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile _terminateNotificationProfile;

        /// <summary>Specifies Terminate Scheduled Event related configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile TerminateNotificationProfile { get => (this._terminateNotificationProfile = this._terminateNotificationProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.TerminateNotificationProfile()); set => this._terminateNotificationProfile = value; }

        /// <summary>Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? TerminateNotificationProfileEnable { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfileInternal)TerminateNotificationProfile).Enable; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfileInternal)TerminateNotificationProfile).Enable = value ?? default(bool); }

        /// <summary>
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string TerminateNotificationProfileNotBeforeTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfileInternal)TerminateNotificationProfile).NotBeforeTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfileInternal)TerminateNotificationProfile).NotBeforeTimeout = value ?? null; }

        /// <summary>Creates an new <see cref="ScheduledEventsProfile" /> instance.</summary>
        public ScheduledEventsProfile()
        {

        }
    }
    /// Specifies Scheduled Event related configurations.
    public partial interface IScheduledEventsProfile :
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
        bool? OSImageNotificationProfileEnable { get; set; }
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
        string OSImageNotificationProfileNotBeforeTimeout { get; set; }
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
        bool? TerminateNotificationProfileEnable { get; set; }
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
        string TerminateNotificationProfileNotBeforeTimeout { get; set; }

    }
    /// Specifies Scheduled Event related configurations.
    internal partial interface IScheduledEventsProfileInternal

    {
        /// <summary>Specifies OS Image Scheduled Event related configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile OSImageNotificationProfile { get; set; }
        /// <summary>Specifies whether the OS Image Scheduled event is enabled or disabled.</summary>
        bool? OSImageNotificationProfileEnable { get; set; }
        /// <summary>
        /// Length of time a Virtual Machine being reimaged or having its OS upgraded will
        /// have to potentially approve the OS Image Scheduled Event before the event is
        /// auto approved (timed out). The configuration is specified in ISO 8601 format,
        /// and the value must not exceed 15 minutes (PT15M)
        /// </summary>
        string OSImageNotificationProfileNotBeforeTimeout { get; set; }
        /// <summary>Specifies Terminate Scheduled Event related configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile TerminateNotificationProfile { get; set; }
        /// <summary>Specifies whether the Terminate Scheduled event is enabled or disabled.</summary>
        bool? TerminateNotificationProfileEnable { get; set; }
        /// <summary>
        /// Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601 format,
        /// the default value is 5 minutes (PT5M)
        /// </summary>
        string TerminateNotificationProfileNotBeforeTimeout { get; set; }

    }
}