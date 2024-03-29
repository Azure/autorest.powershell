// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using System.Linq;

    /// <summary>
    /// The definition of Azure Monitoring metric.
    /// </summary>
    public partial class OperationMetricSpecificationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationMetricSpecificationDefinition class.
        /// </summary>
        public OperationMetricSpecificationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationMetricSpecificationDefinition class.
        /// </summary>
        /// <param name="name">Metric name.</param>
        /// <param name="displayName">Metric display name.</param>
        /// <param name="displayDescription">Metric description.</param>
        /// <param name="unit">Metric unit.</param>
        /// <param name="aggregationType">Metric aggregation type.</param>
        /// <param name="internalMetricName">Internal metric name.</param>
        public OperationMetricSpecificationDefinition(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), string internalMetricName = default(string))
        {
            this.Name = name;
            this.DisplayName = displayName;
            this.DisplayDescription = displayDescription;
            this.Unit = unit;
            this.AggregationType = aggregationType;
            this.InternalMetricName = internalMetricName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets metric name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets metric display name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets metric description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets metric unit.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets metric aggregation type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets internal metric name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "internalMetricName")]
        public string InternalMetricName { get; set; }

    }
}
