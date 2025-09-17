// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>The properties of the UpdateRun.</summary>
    public partial class UpdateRunProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal
    {

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).AdditionalInfo; }

        /// <summary>Backing field for <see cref="AutoUpgradeProfileId" /> property.</summary>
        private string _autoUpgradeProfileId;

        /// <summary>AutoUpgradeProfileId is the id of an auto upgrade profile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string AutoUpgradeProfileId { get => this._autoUpgradeProfileId; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Code; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Detail; }

        /// <summary>Backing field for <see cref="ManagedClusterUpdate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdate _managedClusterUpdate;

        /// <summary>
        /// The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be modified until the run is started.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdate ManagedClusterUpdate { get => (this._managedClusterUpdate = this._managedClusterUpdate ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedClusterUpdate()); set => this._managedClusterUpdate = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AutoUpgradeProfileId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.AutoUpgradeProfileId { get => this._autoUpgradeProfileId; set { {_autoUpgradeProfileId = value;} } }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Code = value ?? null; }

        /// <summary>Internal Acessors for Detail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Detail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ManagedClusterUpdate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdate Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.ManagedClusterUpdate { get => (this._managedClusterUpdate = this._managedClusterUpdate ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ManagedClusterUpdate()); set { {_managedClusterUpdate = value;} } }

        /// <summary>Internal Acessors for ManagedClusterUpdateNodeImageSelection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.ManagedClusterUpdateNodeImageSelection { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).NodeImageSelection; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).NodeImageSelection = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ManagedClusterUpdateUpgrade</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.ManagedClusterUpdateUpgrade { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).Upgrade; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).Upgrade = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Message = value ?? null; }

        /// <summary>Internal Acessors for NodeImageSelectionSelectedNodeImageVersion</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.NodeImageSelectionSelectedNodeImageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).NodeImageSelectionSelectedNodeImageVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).NodeImageSelectionSelectedNodeImageVersion = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusCompletedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.StatusCompletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusCompletedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusCompletedTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for StatusError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.StatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusNodeImageSelection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.StatusNodeImageSelection { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).NodeImageSelection; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).NodeImageSelection = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusStage</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStageStatus> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.StatusStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Stage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Stage = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for StatusStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.StatusStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for StatusState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.StatusState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusState = value ?? null; }

        /// <summary>Internal Acessors for Strategy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategy Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.Strategy { get => (this._strategy = this._strategy ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunStrategy()); set { {_strategy = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Target = value ?? null; }

        /// <summary>Internal Acessors for UpdateStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunPropertiesInternal.UpdateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Status = value ?? null /* model class */; }

        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionCustomNodeImageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).NodeImageSelectionCustomNodeImageVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).NodeImageSelectionCustomNodeImageVersion = value ?? null /* arrayOf */; }

        /// <summary>The image versions to upgrade the nodes to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionSelectedNodeImageVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).NodeImageSelectionSelectedNodeImageVersion; }

        /// <summary>The node image upgrade type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string NodeImageSelectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).NodeImageSelectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).NodeImageSelectionType = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the UpdateRun resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatus _status;

        /// <summary>The status of the UpdateRun.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunStatus()); }

        /// <summary>The time the operation or group was completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusCompletedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusCompletedTime; }

        /// <summary>
        /// The stages composing an update run. Stages are run sequentially withing an UpdateRun.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStageStatus> StatusStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Stage; }

        /// <summary>The time the operation or group was started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public global::System.DateTime? StatusStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusStartTime; }

        /// <summary>The State of the operation or group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).StatusState; }

        /// <summary>Backing field for <see cref="Strategy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategy _strategy;

        /// <summary>
        /// The strategy defines the order in which the clusters will be updated.
        /// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single
        /// UpdateGroup targeting all members.
        /// The strategy of the UpdateRun can be modified until the run is started.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategy Strategy { get => (this._strategy = this._strategy ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunStrategy()); set => this._strategy = value; }

        /// <summary>The list of stages that compose this update run. Min size: 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> StrategyStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategyInternal)Strategy).Stage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategyInternal)Strategy).Stage = value ?? null /* arrayOf */; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatusInternal)Status).Target; }

        /// <summary>Backing field for <see cref="UpdateStrategyId" /> property.</summary>
        private string _updateStrategyId;

        /// <summary>
        /// The resource id of the FleetUpdateStrategy resource to reference.
        /// When creating a new run, there are three ways to define a strategy for the run:
        /// 1. Define a new strategy in place: Set the "strategy" field.
        /// 2. Use an existing strategy: Set the "updateStrategyId" field. (since 2023-08-15-preview)
        /// 3. Use the default strategy to update all the members one by one: Leave both "updateStrategyId" and "strategy" unset.
        /// (since 2023-08-15-preview)
        /// Setting both "updateStrategyId" and "strategy" is invalid.
        /// UpdateRuns created by "updateStrategyId" snapshot the referenced UpdateStrategy at the time of creation and store it in
        /// the "strategy" field.
        /// Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
        /// UpdateRunStrategy changes can be made directly on the "strategy" field before launching the UpdateRun.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string UpdateStrategyId { get => this._updateStrategyId; set => this._updateStrategyId = value; }

        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpgradeKubernetesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).UpgradeKubernetesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).UpgradeKubernetesVersion = value ?? null; }

        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpgradeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).UpgradeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdateInternal)ManagedClusterUpdate).UpgradeType = value ; }

        /// <summary>Creates an new <see cref="UpdateRunProperties" /> instance.</summary>
        public UpdateRunProperties()
        {

        }
    }
    /// The properties of the UpdateRun.
    public partial interface IUpdateRunProperties :
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get;  }
        /// <summary>AutoUpgradeProfileId is the id of an auto upgrade profile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"AutoUpgradeProfileId is the id of an auto upgrade profile resource.",
        SerializedName = @"autoUpgradeProfileId",
        PossibleTypes = new [] { typeof(string) })]
        string AutoUpgradeProfileId { get;  }
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
        string Code { get;  }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get;  }
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
        string Message { get;  }
        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise, it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.",
        SerializedName = @"customNodeImageVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionCustomNodeImageVersion { get; set; }
        /// <summary>The image versions to upgrade the nodes to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The image versions to upgrade the nodes to.",
        SerializedName = @"selectedNodeImageVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionSelectedNodeImageVersion { get;  }
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
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent", "Custom")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The provisioning state of the UpdateRun resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the UpdateRun resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>The time the operation or group was completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The time the operation or group was completed.",
        SerializedName = @"completedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusCompletedTime { get;  }
        /// <summary>
        /// The stages composing an update run. Stages are run sequentially withing an UpdateRun.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The stages composing an update run. Stages are run sequentially withing an UpdateRun.",
        SerializedName = @"stages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStageStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStageStatus> StatusStage { get;  }
        /// <summary>The time the operation or group was started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The time the operation or group was started.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StatusStartTime { get;  }
        /// <summary>The State of the operation or group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The State of the operation or group.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("NotStarted", "Running", "Stopping", "Stopped", "Skipped", "Failed", "Pending", "Completed")]
        string StatusState { get;  }
        /// <summary>The list of stages that compose this update run. Min size: 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of stages that compose this update run. Min size: 1.",
        SerializedName = @"stages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> StrategyStage { get; set; }
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
        string Target { get;  }
        /// <summary>
        /// The resource id of the FleetUpdateStrategy resource to reference.
        /// When creating a new run, there are three ways to define a strategy for the run:
        /// 1. Define a new strategy in place: Set the "strategy" field.
        /// 2. Use an existing strategy: Set the "updateStrategyId" field. (since 2023-08-15-preview)
        /// 3. Use the default strategy to update all the members one by one: Leave both "updateStrategyId" and "strategy" unset.
        /// (since 2023-08-15-preview)
        /// Setting both "updateStrategyId" and "strategy" is invalid.
        /// UpdateRuns created by "updateStrategyId" snapshot the referenced UpdateStrategy at the time of creation and store it in
        /// the "strategy" field.
        /// Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
        /// UpdateRunStrategy changes can be made directly on the "strategy" field before launching the UpdateRun.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the FleetUpdateStrategy resource to reference.

        When creating a new run, there are three ways to define a strategy for the run:
        1. Define a new strategy in place: Set the ""strategy"" field.
        2. Use an existing strategy: Set the ""updateStrategyId"" field. (since 2023-08-15-preview)
        3. Use the default strategy to update all the members one by one: Leave both ""updateStrategyId"" and ""strategy"" unset. (since 2023-08-15-preview)

        Setting both ""updateStrategyId"" and ""strategy"" is invalid.

        UpdateRuns created by ""updateStrategyId"" snapshot the referenced UpdateStrategy at the time of creation and store it in the ""strategy"" field.
        Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
        UpdateRunStrategy changes can be made directly on the ""strategy"" field before launching the UpdateRun.",
        SerializedName = @"updateStrategyId",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateStrategyId { get; set; }
        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Kubernetes version to upgrade the member clusters to.",
        SerializedName = @"kubernetesVersion",
        PossibleTypes = new [] { typeof(string) })]
        string UpgradeKubernetesVersion { get; set; }
        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ManagedClusterUpgradeType is the type of upgrade to be applied.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Full", "NodeImageOnly", "ControlPlaneOnly")]
        string UpgradeType { get; set; }

    }
    /// The properties of the UpdateRun.
    internal partial interface IUpdateRunPropertiesInternal

    {
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> AdditionalInfo { get; set; }
        /// <summary>AutoUpgradeProfileId is the id of an auto upgrade profile resource.</summary>
        string AutoUpgradeProfileId { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Detail { get; set; }
        /// <summary>
        /// The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be modified until the run is started.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpdate ManagedClusterUpdate { get; set; }
        /// <summary>The node image upgrade to be applied to the target nodes in update run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelection ManagedClusterUpdateNodeImageSelection { get; set; }
        /// <summary>The upgrade to apply to the ManagedClusters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IManagedClusterUpgradeSpec ManagedClusterUpdateUpgrade { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>
        /// Custom node image versions to upgrade the nodes to. This field is required if node image selection type is Custom. Otherwise,
        /// it must be empty. For each node image family (e.g., 'AKSUbuntu-1804gen2containerd'), this field can contain at most one
        /// version (e.g., only one of 'AKSUbuntu-1804gen2containerd-2023.01.12' or 'AKSUbuntu-1804gen2containerd-2023.02.12', not
        /// both). If the nodes belong to a family without a matching image version in this field, they are not upgraded.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionCustomNodeImageVersion { get; set; }
        /// <summary>The image versions to upgrade the nodes to.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageVersion> NodeImageSelectionSelectedNodeImageVersion { get; set; }
        /// <summary>The node image upgrade type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Latest", "Consistent", "Custom")]
        string NodeImageSelectionType { get; set; }
        /// <summary>The provisioning state of the UpdateRun resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>The status of the UpdateRun.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStatus Status { get; set; }
        /// <summary>The time the operation or group was completed.</summary>
        global::System.DateTime? StatusCompletedTime { get; set; }
        /// <summary>The error details when a failure is encountered.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusError { get; set; }
        /// <summary>
        /// The node image upgrade specs for the update run. It is only set in update run when `NodeImageSelection.type` is `Consistent`.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.INodeImageSelectionStatus StatusNodeImageSelection { get; set; }
        /// <summary>
        /// The stages composing an update run. Stages are run sequentially withing an UpdateRun.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStageStatus> StatusStage { get; set; }
        /// <summary>The time the operation or group was started.</summary>
        global::System.DateTime? StatusStartTime { get; set; }
        /// <summary>The State of the operation or group.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("NotStarted", "Running", "Stopping", "Stopped", "Skipped", "Failed", "Pending", "Completed")]
        string StatusState { get; set; }
        /// <summary>
        /// The strategy defines the order in which the clusters will be updated.
        /// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single
        /// UpdateGroup targeting all members.
        /// The strategy of the UpdateRun can be modified until the run is started.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunStrategy Strategy { get; set; }
        /// <summary>The list of stages that compose this update run. Min size: 1.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStage> StrategyStage { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }
        /// <summary>The status of the UpdateRun.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateStatus UpdateStatus { get; set; }
        /// <summary>
        /// The resource id of the FleetUpdateStrategy resource to reference.
        /// When creating a new run, there are three ways to define a strategy for the run:
        /// 1. Define a new strategy in place: Set the "strategy" field.
        /// 2. Use an existing strategy: Set the "updateStrategyId" field. (since 2023-08-15-preview)
        /// 3. Use the default strategy to update all the members one by one: Leave both "updateStrategyId" and "strategy" unset.
        /// (since 2023-08-15-preview)
        /// Setting both "updateStrategyId" and "strategy" is invalid.
        /// UpdateRuns created by "updateStrategyId" snapshot the referenced UpdateStrategy at the time of creation and store it in
        /// the "strategy" field.
        /// Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
        /// UpdateRunStrategy changes can be made directly on the "strategy" field before launching the UpdateRun.
        /// </summary>
        string UpdateStrategyId { get; set; }
        /// <summary>The Kubernetes version to upgrade the member clusters to.</summary>
        string UpgradeKubernetesVersion { get; set; }
        /// <summary>ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Full", "NodeImageOnly", "ControlPlaneOnly")]
        string UpgradeType { get; set; }

    }
}