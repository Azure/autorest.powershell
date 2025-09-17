// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The properties of the AutoUpgradeProfile.</summary>
    public partial class AutoUpgradeProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeProfileStatus" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus _autoUpgradeProfileStatus;

        /// <summary>The status of the auto upgrade profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus AutoUpgradeProfileStatus { get => (this._autoUpgradeProfileStatus = this._autoUpgradeProfileStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileStatus()); set => this._autoUpgradeProfileStatus = value; }

        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string AutoUpgradeProfileStatusLastTriggerStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerStatus; }

        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AutoUpgradeProfileStatusLastTriggerUpgradeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerUpgradeVersion; }

        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public global::System.DateTime? AutoUpgradeProfileStatusLastTriggeredAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggeredAt; }

        /// <summary>Backing field for <see cref="Channel" /> property.</summary>
        private string _channel;

        /// <summary>Configures how auto-upgrade will be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Channel { get => this._channel; set => this._channel = value; }

        /// <summary>Backing field for <see cref="Disabled" /> property.</summary>
        private bool? _disabled;

        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public bool? Disabled { get => this._disabled; set => this._disabled = value; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastTriggerErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorAdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorCode; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastTriggerErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorDetail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorMessage; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastTriggerErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorTarget; }

        /// <summary>Backing field for <see cref="LongTermSupport" /> property.</summary>
        private bool? _longTermSupport;

        /// <summary>
        /// If upgrade channel is not TargetKubernetesVersion, this field must be False.
        /// If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
        /// (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
        /// By default, this is set to False.
        /// For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public bool? LongTermSupport { get => this._longTermSupport; set => this._longTermSupport = value; }

        /// <summary>Internal Acessors for AutoUpgradeProfileStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.AutoUpgradeProfileStatus { get => (this._autoUpgradeProfileStatus = this._autoUpgradeProfileStatus ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileStatus()); set { {_autoUpgradeProfileStatus = value;} } }

        /// <summary>Internal Acessors for AutoUpgradeProfileStatusLastTriggerError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.AutoUpgradeProfileStatusLastTriggerError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AutoUpgradeProfileStatusLastTriggerStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.AutoUpgradeProfileStatusLastTriggerStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerStatus = value ?? null; }

        /// <summary>Internal Acessors for AutoUpgradeProfileStatusLastTriggerUpgradeVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.AutoUpgradeProfileStatusLastTriggerUpgradeVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerUpgradeVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerUpgradeVersion = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AutoUpgradeProfileStatusLastTriggeredAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.AutoUpgradeProfileStatusLastTriggeredAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggeredAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggeredAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastTriggerErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.LastTriggerErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorAdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorAdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.LastTriggerErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorCode = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.LastTriggerErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastTriggerErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.LastTriggerErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorMessage = value ?? null; }

        /// <summary>Internal Acessors for LastTriggerErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.LastTriggerErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatusInternal)AutoUpgradeProfileStatus).LastTriggerErrorTarget = value ?? null; }

        /// <summary>Internal Acessors for NodeImageSelection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.NodeImageSelection { get => (this._nodeImageSelection = this._nodeImageSelection ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelection()); set { {_nodeImageSelection = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NodeImageSelection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection _nodeImageSelection;

        /// <summary>The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection NodeImageSelection { get => (this._nodeImageSelection = this._nodeImageSelection ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelection()); set => this._nodeImageSelection = value; }

        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string NodeImageSelectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelectionInternal)NodeImageSelection).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelectionInternal)NodeImageSelection).Type = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the AutoUpgradeProfile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="TargetKubernetesVersion" /> property.</summary>
        private string _targetKubernetesVersion;

        /// <summary>
        /// This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example,
        /// "1.30".
        /// By default, this is empty.
        /// If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
        /// If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string TargetKubernetesVersion { get => this._targetKubernetesVersion; set => this._targetKubernetesVersion = value; }

        /// <summary>Backing field for <see cref="UpdateStrategyId" /> property.</summary>
        private string _updateStrategyId;

        /// <summary>
        /// The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters
        /// which are members of the fleet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string UpdateStrategyId { get => this._updateStrategyId; set => this._updateStrategyId = value; }

        /// <summary>Creates an new <see cref="AutoUpgradeProfileProperties" /> instance.</summary>
        public AutoUpgradeProfileProperties()
        {

        }
    }
    /// The properties of the AutoUpgradeProfile.
    public partial interface IAutoUpgradeProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
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
        string AutoUpgradeProfileStatusLastTriggerStatus { get;  }
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
        System.Collections.Generic.List<string> AutoUpgradeProfileStatusLastTriggerUpgradeVersion { get;  }
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
        global::System.DateTime? AutoUpgradeProfileStatusLastTriggeredAt { get;  }
        /// <summary>Configures how auto-upgrade will be run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Configures how auto-upgrade will be run.",
        SerializedName = @"channel",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Stable", "Rapid", "NodeImage", "TargetKubernetesVersion")]
        string Channel { get; set; }
        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        By default, this is set to False.",
        SerializedName = @"disabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Disabled { get; set; }
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
        /// <summary>
        /// If upgrade channel is not TargetKubernetesVersion, this field must be False.
        /// If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
        /// (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
        /// By default, this is set to False.
        /// For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"  If upgrade channel is not TargetKubernetesVersion, this field must be False.
          If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
          (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
          By default, this is set to False.
          For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support",
        SerializedName = @"longTermSupport",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LongTermSupport { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The node image upgrade type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The provisioning state of the AutoUpgradeProfile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the AutoUpgradeProfile resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>
        /// This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example,
        /// "1.30".
        /// By default, this is empty.
        /// If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
        /// If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"  This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example, ""1.30"".
          By default, this is empty.
          If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
          If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.",
        SerializedName = @"targetKubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TargetKubernetesVersion { get; set; }
        /// <summary>
        /// The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters
        /// which are members of the fleet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters which are members of the fleet.",
        SerializedName = @"updateStrategyId",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateStrategyId { get; set; }

    }
    /// The properties of the AutoUpgradeProfile.
    internal partial interface IAutoUpgradeProfilePropertiesInternal

    {
        /// <summary>The status of the auto upgrade profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus AutoUpgradeProfileStatus { get; set; }
        /// <summary>The error details of the last trigger.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail AutoUpgradeProfileStatusLastTriggerError { get; set; }
        /// <summary>The status of the last AutoUpgrade trigger.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed")]
        string AutoUpgradeProfileStatusLastTriggerStatus { get; set; }
        /// <summary>The target Kubernetes version or node image versions of the last trigger.</summary>
        System.Collections.Generic.List<string> AutoUpgradeProfileStatusLastTriggerUpgradeVersion { get; set; }
        /// <summary>
        /// The UTC time of the last attempt to automatically create and start an UpdateRun as triggered by the release of new versions.
        /// </summary>
        global::System.DateTime? AutoUpgradeProfileStatusLastTriggeredAt { get; set; }
        /// <summary>Configures how auto-upgrade will be run.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Stable", "Rapid", "NodeImage", "TargetKubernetesVersion")]
        string Channel { get; set; }
        /// <summary>
        /// If set to False: the auto upgrade has effect - target managed clusters will be upgraded on schedule.
        /// If set to True: the auto upgrade has no effect - no upgrade will be run on the target managed clusters.
        /// This is a boolean and not an enum because enabled/disabled are all available states of the auto upgrade profile.
        /// By default, this is set to False.
        /// </summary>
        bool? Disabled { get; set; }
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
        /// <summary>
        /// If upgrade channel is not TargetKubernetesVersion, this field must be False.
        /// If set to True: Fleet auto upgrade will continue generate update runs for patches of minor versions earlier than N-2
        /// (where N is the latest supported minor version) if those minor versions support Long-Term Support (LTS).
        /// By default, this is set to False.
        /// For more information on AKS LTS, please see https://learn.microsoft.com/en-us/azure/aks/long-term-support
        /// </summary>
        bool? LongTermSupport { get; set; }
        /// <summary>The node image upgrade to be applied to the target clusters in auto upgrade.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection NodeImageSelection { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The provisioning state of the AutoUpgradeProfile resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// This is the target Kubernetes version for auto-upgrade. The format must be `{major version}.{minor version}`. For example,
        /// "1.30".
        /// By default, this is empty.
        /// If upgrade channel is set to TargetKubernetesVersion, this field must not be empty.
        /// If upgrade channel is Rapid, Stable or NodeImage, this field must be empty.
        /// </summary>
        string TargetKubernetesVersion { get; set; }
        /// <summary>
        /// The resource id of the UpdateStrategy resource to reference. If not specified, the auto upgrade will run on all clusters
        /// which are members of the fleet.
        /// </summary>
        string UpdateStrategyId { get; set; }

    }
}