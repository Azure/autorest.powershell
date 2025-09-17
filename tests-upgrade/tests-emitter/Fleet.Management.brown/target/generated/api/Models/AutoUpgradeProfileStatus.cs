// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>AutoUpgradeProfileStatus is the status of an auto upgrade profile.</summary>
    public partial class AutoUpgradeProfileStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal
    {

        /// <summary>Backing field for <see cref="LastTriggerError" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail _lastTriggerError;

        /// <summary>The error details of the last trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail LastTriggerError { get => (this._lastTriggerError = this._lastTriggerError ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetail()); }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Detail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Message; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Target; }

        /// <summary>Backing field for <see cref="LastTriggerStatus" /> property.</summary>
        private string _lastTriggerStatus;

        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string LastTriggerStatus { get => this._lastTriggerStatus; }

        /// <summary>Backing field for <see cref="LastTriggerUpgradeVersion" /> property.</summary>
        private System.Collections.Generic.List<string> _lastTriggerUpgradeVersion;

        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> LastTriggerUpgradeVersion { get => this._lastTriggerUpgradeVersion; }

        /// <summary>Backing field for <see cref="LastTriggeredAt" /> property.</summary>
        private global::System.DateTime? _lastTriggeredAt;

        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public global::System.DateTime? LastTriggeredAt { get => this._lastTriggeredAt; }

        /// <summary>Internal Acessors for LastTriggerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerError { get => (this._lastTriggerError = this._lastTriggerError ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetail()); set { {_lastTriggerError = value;} } }

        /// <summary>Internal Acessors for LastTriggerErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Code = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Message = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetailInternal)LastTriggerError).Target = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerStatus { get => this._lastTriggerStatus; set { {_lastTriggerStatus = value;} } }

        /// <summary>Internal Acessors for LastTriggerUpgradeVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggerUpgradeVersion { get => this._lastTriggerUpgradeVersion; set { {_lastTriggerUpgradeVersion = value;} } }

        /// <summary>Internal Acessors for LastTriggeredAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal.LastTriggeredAt { get => this._lastTriggeredAt; set { {_lastTriggeredAt = value;} } }

        /// <summary>Creates an new <see cref="AutoUpgradeProfileStatus" /> instance.</summary>
        public AutoUpgradeProfileStatus()
        {

        }
    }
    /// AutoUpgradeProfileStatus is the status of an auto upgrade profile.
    public partial interface IAutoUpgradeProfileStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string LastTriggerErrorCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string LastTriggerErrorMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string LastTriggerErrorTarget { get;  }
        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last AutoUpgrade trigger.",
        SerializedName = @"lastTriggerStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string LastTriggerStatus { get;  }
        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The target Kubernetes version or node image versions of the last trigger.",
        SerializedName = @"lastTriggerUpgradeVersions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> LastTriggerUpgradeVersion { get;  }
        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.",
        SerializedName = @"lastTriggeredAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastTriggeredAt { get;  }

    }
    /// AutoUpgradeProfileStatus is the status of an auto upgrade profile.
    internal partial interface IAutoUpgradeProfileStatusInternal

    {
        /// <summary>The error details of the last trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail LastTriggerError { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string LastTriggerErrorCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get; set; }
        /// <summary>The error message.</summary>
        string LastTriggerErrorMessage { get; set; }
        /// <summary>The error target.</summary>
        string LastTriggerErrorTarget { get; set; }
        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string LastTriggerStatus { get; set; }
        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        System.Collections.Generic.List<string> LastTriggerUpgradeVersion { get; set; }
        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        global::System.DateTime? LastTriggeredAt { get; set; }

    }
}