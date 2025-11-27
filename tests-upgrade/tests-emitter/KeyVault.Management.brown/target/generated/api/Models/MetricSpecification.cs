// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>Metric specification of operation.</summary>
    public partial class MetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IMetricSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IMetricSpecificationInternal
    {

        /// <summary>Backing field for <see cref="AggregationType" /> property.</summary>
        private string _aggregationType;

        /// <summary>
        /// The metric aggregation type. Possible values include: 'Average', 'Count', 'Total'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string AggregationType { get => this._aggregationType; set => this._aggregationType = value; }

        /// <summary>Backing field for <see cref="Dimension" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDimensionProperties> _dimension;

        /// <summary>The dimensions of metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDimensionProperties> Dimension { get => this._dimension; set => this._dimension = value; }

        /// <summary>Backing field for <see cref="DisplayDescription" /> property.</summary>
        private string _displayDescription;

        /// <summary>Display description of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string DisplayDescription { get => this._displayDescription; set => this._displayDescription = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="FillGapWithZero" /> property.</summary>
        private bool? _fillGapWithZero;

        /// <summary>Property to specify whether to fill gap with zero.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public bool? FillGapWithZero { get => this._fillGapWithZero; set => this._fillGapWithZero = value; }

        /// <summary>Backing field for <see cref="InternalMetricName" /> property.</summary>
        private string _internalMetricName;

        /// <summary>The internal metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string InternalMetricName { get => this._internalMetricName; set => this._internalMetricName = value; }

        /// <summary>Backing field for <see cref="LockAggregationType" /> property.</summary>
        private string _lockAggregationType;

        /// <summary>The metric lock aggregation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string LockAggregationType { get => this._lockAggregationType; set => this._lockAggregationType = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="SupportedAggregationType" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedAggregationType;

        /// <summary>The supported aggregation types for the metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedAggregationType { get => this._supportedAggregationType; set => this._supportedAggregationType = value; }

        /// <summary>Backing field for <see cref="SupportedTimeGrainType" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedTimeGrainType;

        /// <summary>The supported time grain types for the metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedTimeGrainType { get => this._supportedTimeGrainType; set => this._supportedTimeGrainType = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>The metric unit. Possible values include: 'Bytes', 'Count', 'Milliseconds'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="MetricSpecification" /> instance.</summary>
        public MetricSpecification()
        {

        }
    }
    /// Metric specification of operation.
    public partial interface IMetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The metric aggregation type. Possible values include: 'Average', 'Count', 'Total'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The metric aggregation type. Possible values include: 'Average', 'Count', 'Total'.",
        SerializedName = @"aggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string AggregationType { get; set; }
        /// <summary>The dimensions of metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The dimensions of metric",
        SerializedName = @"dimensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDimensionProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDimensionProperties> Dimension { get; set; }
        /// <summary>Display description of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Display description of metric specification.",
        SerializedName = @"displayDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Display name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Display name of metric specification.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Property to specify whether to fill gap with zero.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Property to specify whether to fill gap with zero.",
        SerializedName = @"fillGapWithZero",
        PossibleTypes = new [] { typeof(bool) })]
        bool? FillGapWithZero { get; set; }
        /// <summary>The internal metric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The internal metric name.",
        SerializedName = @"internalMetricName",
        PossibleTypes = new [] { typeof(string) })]
        string InternalMetricName { get; set; }
        /// <summary>The metric lock aggregation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The metric lock aggregation type.",
        SerializedName = @"lockAggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string LockAggregationType { get; set; }
        /// <summary>Name of metric specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of metric specification.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The supported aggregation types for the metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The supported aggregation types for the metrics.",
        SerializedName = @"supportedAggregationTypes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedAggregationType { get; set; }
        /// <summary>The supported time grain types for the metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The supported time grain types for the metrics.",
        SerializedName = @"supportedTimeGrainTypes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedTimeGrainType { get; set; }
        /// <summary>The metric unit. Possible values include: 'Bytes', 'Count', 'Milliseconds'.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The metric unit. Possible values include: 'Bytes', 'Count', 'Milliseconds'.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// Metric specification of operation.
    internal partial interface IMetricSpecificationInternal

    {
        /// <summary>
        /// The metric aggregation type. Possible values include: 'Average', 'Count', 'Total'.
        /// </summary>
        string AggregationType { get; set; }
        /// <summary>The dimensions of metric</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IDimensionProperties> Dimension { get; set; }
        /// <summary>Display description of metric specification.</summary>
        string DisplayDescription { get; set; }
        /// <summary>Display name of metric specification.</summary>
        string DisplayName { get; set; }
        /// <summary>Property to specify whether to fill gap with zero.</summary>
        bool? FillGapWithZero { get; set; }
        /// <summary>The internal metric name.</summary>
        string InternalMetricName { get; set; }
        /// <summary>The metric lock aggregation type.</summary>
        string LockAggregationType { get; set; }
        /// <summary>Name of metric specification.</summary>
        string Name { get; set; }
        /// <summary>The supported aggregation types for the metrics.</summary>
        System.Collections.Generic.List<string> SupportedAggregationType { get; set; }
        /// <summary>The supported time grain types for the metrics.</summary>
        System.Collections.Generic.List<string> SupportedTimeGrainType { get; set; }
        /// <summary>The metric unit. Possible values include: 'Bytes', 'Count', 'Milliseconds'.</summary>
        string Unit { get; set; }

    }
}