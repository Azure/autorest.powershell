// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>Elastic San update properties.</summary>
    public partial class ElasticSanUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AutoScaleProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScaleProperties _autoScaleProperty;

        /// <summary>Auto Scale Properties for Elastic San Appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScaleProperties AutoScaleProperty { get => (this._autoScaleProperty = this._autoScaleProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.AutoScaleProperties()); set => this._autoScaleProperty = value; }

        /// <summary>Backing field for <see cref="BaseSizeTiB" /> property.</summary>
        private long? _baseSizeTiB;

        /// <summary>Base size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public long? BaseSizeTiB { get => this._baseSizeTiB; set => this._baseSizeTiB = value; }

        /// <summary>Backing field for <see cref="ExtendedCapacitySizeTiB" /> property.</summary>
        private long? _extendedCapacitySizeTiB;

        /// <summary>Extended size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public long? ExtendedCapacitySizeTiB { get => this._extendedCapacitySizeTiB; set => this._extendedCapacitySizeTiB = value; }

        /// <summary>Internal Acessors for AutoScaleProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScaleProperties Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanUpdatePropertiesInternal.AutoScaleProperty { get => (this._autoScaleProperty = this._autoScaleProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.AutoScaleProperties()); set { {_autoScaleProperty = value;} } }

        /// <summary>Internal Acessors for AutoScalePropertyScaleUpProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IScaleUpProperties Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IElasticSanUpdatePropertiesInternal.AutoScalePropertyScaleUpProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpProperty = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>
        /// Allow or disallow public network access to ElasticSan Account. Value is optional but if passed in, must be 'Enabled' or
        /// 'Disabled'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Enable or Disable scale up setting on Elastic San Appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public string ScaleUpPropertyAutoScalePolicyEnforcement { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyAutoScalePolicyEnforcement; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyAutoScalePolicyEnforcement = value ?? null; }

        /// <summary>Maximum scale up size on Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? ScaleUpPropertyCapacityUnitScaleUpLimitTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyCapacityUnitScaleUpLimitTiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyCapacityUnitScaleUpLimitTiB = value ?? default(long); }

        /// <summary>Unit to increase Capacity Unit on Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? ScaleUpPropertyIncreaseCapacityUnitByTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyIncreaseCapacityUnitByTiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyIncreaseCapacityUnitByTiB = value ?? default(long); }

        /// <summary>Unused size on Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Inlined)]
        public long? ScaleUpPropertyUnusedSizeTiB { get => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyUnusedSizeTiB; set => ((Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScalePropertiesInternal)AutoScaleProperty).ScaleUpPropertyUnusedSizeTiB = value ?? default(long); }

        /// <summary>Creates an new <see cref="ElasticSanUpdateProperties" /> instance.</summary>
        public ElasticSanUpdateProperties()
        {

        }
    }
    /// Elastic San update properties.
    public partial interface IElasticSanUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>Base size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = false,
        Update = true,
        Description = @"Base size of the Elastic San appliance in TiB.",
        SerializedName = @"baseSizeTiB",
        PossibleTypes = new [] { typeof(long) })]
        long? BaseSizeTiB { get; set; }
        /// <summary>Extended size of the Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = false,
        Update = true,
        Description = @"Extended size of the Elastic San appliance in TiB.",
        SerializedName = @"extendedCapacitySizeTiB",
        PossibleTypes = new [] { typeof(long) })]
        long? ExtendedCapacitySizeTiB { get; set; }
        /// <summary>
        /// Allow or disallow public network access to ElasticSan Account. Value is optional but if passed in, must be 'Enabled' or
        /// 'Disabled'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Allow or disallow public network access to ElasticSan Account. Value is optional but if passed in, must be 'Enabled' or 'Disabled'.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Enable or Disable scale up setting on Elastic San Appliance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable or Disable scale up setting on Elastic San Appliance.",
        SerializedName = @"autoScalePolicyEnforcement",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("None", "Enabled", "Disabled")]
        string ScaleUpPropertyAutoScalePolicyEnforcement { get; set; }
        /// <summary>Maximum scale up size on Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum scale up size on Elastic San appliance in TiB.",
        SerializedName = @"capacityUnitScaleUpLimitTiB",
        PossibleTypes = new [] { typeof(long) })]
        long? ScaleUpPropertyCapacityUnitScaleUpLimitTiB { get; set; }
        /// <summary>Unit to increase Capacity Unit on Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unit to increase Capacity Unit on Elastic San appliance in TiB.",
        SerializedName = @"increaseCapacityUnitByTiB",
        PossibleTypes = new [] { typeof(long) })]
        long? ScaleUpPropertyIncreaseCapacityUnitByTiB { get; set; }
        /// <summary>Unused size on Elastic San appliance in TiB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Unused size on Elastic San appliance in TiB.",
        SerializedName = @"unusedSizeTiB",
        PossibleTypes = new [] { typeof(long) })]
        long? ScaleUpPropertyUnusedSizeTiB { get; set; }

    }
    /// Elastic San update properties.
    internal partial interface IElasticSanUpdatePropertiesInternal

    {
        /// <summary>Auto Scale Properties for Elastic San Appliance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IAutoScaleProperties AutoScaleProperty { get; set; }
        /// <summary>Scale up settings on Elastic San Appliance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.IScaleUpProperties AutoScalePropertyScaleUpProperty { get; set; }
        /// <summary>Base size of the Elastic San appliance in TiB.</summary>
        long? BaseSizeTiB { get; set; }
        /// <summary>Extended size of the Elastic San appliance in TiB.</summary>
        long? ExtendedCapacitySizeTiB { get; set; }
        /// <summary>
        /// Allow or disallow public network access to ElasticSan Account. Value is optional but if passed in, must be 'Enabled' or
        /// 'Disabled'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Enable or Disable scale up setting on Elastic San Appliance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PSArgumentCompleterAttribute("None", "Enabled", "Disabled")]
        string ScaleUpPropertyAutoScalePolicyEnforcement { get; set; }
        /// <summary>Maximum scale up size on Elastic San appliance in TiB.</summary>
        long? ScaleUpPropertyCapacityUnitScaleUpLimitTiB { get; set; }
        /// <summary>Unit to increase Capacity Unit on Elastic San appliance in TiB.</summary>
        long? ScaleUpPropertyIncreaseCapacityUnitByTiB { get; set; }
        /// <summary>Unused size on Elastic San appliance in TiB.</summary>
        long? ScaleUpPropertyUnusedSizeTiB { get; set; }

    }
}