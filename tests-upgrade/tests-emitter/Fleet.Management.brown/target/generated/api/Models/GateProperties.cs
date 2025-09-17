// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>A Gate controls the progression during a staged rollout, e.g. in an Update Run.</summary>
    public partial class GateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The human-readable display name of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="GateType" /> property.</summary>
        private string _gateType= @"Approval";

        /// <summary>The type of the Gate determines how it is completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string GateType { get => this._gateType; }

        /// <summary>Internal Acessors for GateType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.GateType { get => this._gateType; set { {_gateType = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.Target { get => (this._target = this._target ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateTarget()); set { {_target = value;} } }

        /// <summary>Internal Acessors for TargetUpdateRunProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.TargetUpdateRunProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for UpdateRunPropertyGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.UpdateRunPropertyGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyGroup = value ?? null; }

        /// <summary>Internal Acessors for UpdateRunPropertyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.UpdateRunPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyName = value ?? null; }

        /// <summary>Internal Acessors for UpdateRunPropertyStage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal.UpdateRunPropertyStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyStage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyStage = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state of the Gate resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The state of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget _target;

        /// <summary>The target that the Gate is controlling, e.g. an Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget Target { get => (this._target = this._target ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateTarget()); set => this._target = value; }

        /// <summary>The resource id that the Gate is controlling the rollout of.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string TargetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).Id = value ?? null; }

        /// <summary>The Update Group of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyGroup; }

        /// <summary>The name of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyName; }

        /// <summary>The Update Stage of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyStage; }

        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyTiming { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyTiming; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal)Target).UpdateRunPropertyTiming = value ?? null; }

        /// <summary>Creates an new <see cref="GateProperties" /> instance.</summary>
        public GateProperties()
        {

        }
    }
    /// A Gate controls the progression during a staged rollout, e.g. in an Update Run.
    public partial interface IGateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The human-readable display name of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The human-readable display name of the Gate.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The type of the Gate determines how it is completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The type of the Gate determines how it is completed.",
        SerializedName = @"gateType",
        PossibleTypes = new [] { typeof(string) })]
        string GateType { get;  }
        /// <summary>The provisioning state of the Gate resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state of the Gate resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>The state of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The state of the Gate.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Pending", "Skipped", "Completed")]
        string State { get; set; }
        /// <summary>The resource id that the Gate is controlling the rollout of.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The resource id that the Gate is controlling the rollout of.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string TargetId { get; set; }
        /// <summary>The Update Group of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Update Group of the Update Run.",
        SerializedName = @"group",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateRunPropertyGroup { get;  }
        /// <summary>The name of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the Update Run.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateRunPropertyName { get;  }
        /// <summary>The Update Stage of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Update Stage of the Update Run.",
        SerializedName = @"stage",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateRunPropertyStage { get;  }
        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Whether the Gate is placed before or after the update itself.",
        SerializedName = @"timing",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Before", "After")]
        string UpdateRunPropertyTiming { get; set; }

    }
    /// A Gate controls the progression during a staged rollout, e.g. in an Update Run.
    internal partial interface IGatePropertiesInternal

    {
        /// <summary>The human-readable display name of the Gate.</summary>
        string DisplayName { get; set; }
        /// <summary>The type of the Gate determines how it is completed.</summary>
        string GateType { get; set; }
        /// <summary>The provisioning state of the Gate resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>The state of the Gate.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Pending", "Skipped", "Completed")]
        string State { get; set; }
        /// <summary>The target that the Gate is controlling, e.g. an Update Run.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget Target { get; set; }
        /// <summary>The resource id that the Gate is controlling the rollout of.</summary>
        string TargetId { get; set; }
        /// <summary>The properties of the Update Run that the Gate is targeting.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties TargetUpdateRunProperty { get; set; }
        /// <summary>The Update Group of the Update Run.</summary>
        string UpdateRunPropertyGroup { get; set; }
        /// <summary>The name of the Update Run.</summary>
        string UpdateRunPropertyName { get; set; }
        /// <summary>The Update Stage of the Update Run.</summary>
        string UpdateRunPropertyStage { get; set; }
        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Before", "After")]
        string UpdateRunPropertyTiming { get; set; }

    }
}