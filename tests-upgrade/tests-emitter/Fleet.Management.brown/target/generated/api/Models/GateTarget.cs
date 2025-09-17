// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>
    /// The target that the Gate is controlling, e.g. an Update Run. Exactly one of the properties objects will be set.
    /// </summary>
    public partial class GateTarget :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The resource id that the Gate is controlling the rollout of.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for UpdateRunProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal.UpdateRunProperty { get => (this._updateRunProperty = this._updateRunProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateTargetProperties()); set { {_updateRunProperty = value;} } }

        /// <summary>Internal Acessors for UpdateRunPropertyGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal.UpdateRunPropertyGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Group; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Group = value ?? null; }

        /// <summary>Internal Acessors for UpdateRunPropertyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal.UpdateRunPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Name = value ?? null; }

        /// <summary>Internal Acessors for UpdateRunPropertyStage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTargetInternal.UpdateRunPropertyStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Stage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Stage = value ?? null; }

        /// <summary>Backing field for <see cref="UpdateRunProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties _updateRunProperty;

        /// <summary>The properties of the Update Run that the Gate is targeting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties UpdateRunProperty { get => (this._updateRunProperty = this._updateRunProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateTargetProperties()); set => this._updateRunProperty = value; }

        /// <summary>The Update Group of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Group; }

        /// <summary>The name of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Name; }

        /// <summary>The Update Stage of the Update Run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Stage; }

        /// <summary>Whether the Gate is placed before or after the update itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string UpdateRunPropertyTiming { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Timing; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetPropertiesInternal)UpdateRunProperty).Timing = value ?? null; }

        /// <summary>Creates an new <see cref="GateTarget" /> instance.</summary>
        public GateTarget()
        {

        }
    }
    /// The target that the Gate is controlling, e.g. an Update Run. Exactly one of the properties objects will be set.
    public partial interface IGateTarget :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
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
        string Id { get; set; }
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
    /// The target that the Gate is controlling, e.g. an Update Run. Exactly one of the properties objects will be set.
    internal partial interface IGateTargetInternal

    {
        /// <summary>The resource id that the Gate is controlling the rollout of.</summary>
        string Id { get; set; }
        /// <summary>The properties of the Update Run that the Gate is targeting.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties UpdateRunProperty { get; set; }
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