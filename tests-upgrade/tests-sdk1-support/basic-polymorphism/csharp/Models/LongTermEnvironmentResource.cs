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
    /// An environment is a set of time-series data available for query, and is
    /// the top level Azure Time Series Insights resource. LongTerm
    /// environments do not have set data retention limits.
    /// </summary>
    [Newtonsoft.Json.JsonObject("LongTerm")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class LongTermEnvironmentResource : EnvironmentResource
    {
        /// <summary>
        /// Initializes a new instance of the LongTermEnvironmentResource
        /// class.
        /// </summary>
        public LongTermEnvironmentResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LongTermEnvironmentResource
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
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
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: 'Accepted', 'Creating', 'Updating',
        /// 'Succeeded', 'Failed', 'Deleting'</param>
        /// <param name="creationTime">The time the resource was
        /// created.</param>
        /// <param name="dataAccessId">An id used to access the environment
        /// data, e.g. to query the environment's events or upload reference
        /// data for the environment.</param>
        /// <param name="dataAccessFqdn">The fully qualified domain name used
        /// to access the environment data, e.g. to query the environment's
        /// events or upload reference data for the environment.</param>
        /// <param name="status">An object that represents the status of the
        /// environment, and its internal state in the Time Series Insights
        /// service.</param>
        public LongTermEnvironmentResource(string location, Sku sku, System.Collections.Generic.IList<TimeSeriesIdProperty> timeSeriesIdProperties, LongTermStorageConfigurationOutput storageConfiguration, string dataRetention, string id = default(string), string name = default(string), string type = default(string), string tags = default(string), ProvisioningState? provisioningState = default(ProvisioningState?), System.DateTime? creationTime = default(System.DateTime?), string dataAccessId = default(string), string dataAccessFqdn = default(string), EnvironmentStatus status = default(EnvironmentStatus))
            : base(location, sku, id, name, type, tags)
        {
            this.ProvisioningState = provisioningState;
            this.CreationTime = creationTime;
            this.DataAccessId = dataAccessId;
            this.DataAccessFqdn = dataAccessFqdn;
            this.Status = status;
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
        /// Gets or sets provisioning state of the resource. Possible values
        /// include: 'Accepted', 'Creating', 'Updating', 'Succeeded', 'Failed',
        /// 'Deleting'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; set; }

        /// <summary>
        /// Gets the time the resource was created.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets an id used to access the environment data, e.g. to query the
        /// environment's events or upload reference data for the environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataAccessId")]
        public string DataAccessId { get; private set; }

        /// <summary>
        /// Gets the fully qualified domain name used to access the environment
        /// data, e.g. to query the environment's events or upload reference
        /// data for the environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataAccessFqdn")]
        public string DataAccessFqdn { get; private set; }

        /// <summary>
        /// Gets or sets an object that represents the status of the
        /// environment, and its internal state in the Time Series Insights
        /// service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.status")]
        public EnvironmentStatus Status { get; set; }

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
        public LongTermStorageConfigurationOutput StorageConfiguration { get; set; }

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
            if (this.DataRetention == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataRetention");
            }
            if (this.Status != null)
            {
                this.Status.Validate();
            }
            if (this.StorageConfiguration != null)
            {
                this.StorageConfiguration.Validate();
            }
        }
    }
}