// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create or Update Environment operation for a
    /// long-term environment.
    /// </summary>
    [Newtonsoft.Json.JsonObject("LongTerm")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class LongTermEnvironmentCreateOrUpdateParameters : EnvironmentCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LongTermEnvironmentCreateOrUpdateParameters class.
        /// </summary>
        public LongTermEnvironmentCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LongTermEnvironmentCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="location">The location of the resource.</param>
        /// <param name="sku">The sku determines the type of environment,
        /// either standard (S1 or S2) or long-term (L1). For standard
        /// environments the sku determines the capacity of the environment,
        /// the ingress rate, and the billing rate.</param>
        /// <param name="timeSeriesIdProperties">The list of event properties
        /// which will be used to define the environment's time series
        /// id.</param>
        /// <param name="storageConfiguration">The storage configuration
        /// provides the connection details that allows the Time Series
        /// Insights service to connect to the customer storage account that is
        /// used to store the environment's data.</param>
        /// <param name="dataRetention">ISO8601 timespan specifying the number
        /// of days the environment's events will be available for query from
        /// the warm store.</param>
        /// <param name="tags">Key-value pairs of additional properties for the
        /// resource.</param>
        public LongTermEnvironmentCreateOrUpdateParameters(string location, Sku sku, System.Collections.Generic.IList<TimeSeriesIdProperty> timeSeriesIdProperties, LongTermStorageConfigurationInput storageConfiguration, string tags = default(string), string dataRetention = default(string))
            : base(location, sku, tags)
        {
            this.TimeSeriesIdProperties = timeSeriesIdProperties;
            this.StorageConfiguration = storageConfiguration;
            this.DataRetention = dataRetention;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of event properties which will be used to
        /// define the environment's time series id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.timeSeriesIdProperties")]
        public System.Collections.Generic.IList<TimeSeriesIdProperty> TimeSeriesIdProperties { get; set; }

        /// <summary>
        /// Gets or sets the storage configuration provides the connection
        /// details that allows the Time Series Insights service to connect to
        /// the customer storage account that is used to store the
        /// environment's data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageConfiguration")]
        public LongTermStorageConfigurationInput StorageConfiguration { get; set; }

        /// <summary>
        /// Gets or sets ISO8601 timespan specifying the number of days the
        /// environment's events will be available for query from the warm
        /// store.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.warmStoreConfiguration.dataRetention")]
        public string DataRetention { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.TimeSeriesIdProperties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TimeSeriesIdProperties");
            }
            if (this.StorageConfiguration == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StorageConfiguration");
            }

            if (this.StorageConfiguration != null)
            {
                this.StorageConfiguration.Validate();
            }
        }
    }
}
