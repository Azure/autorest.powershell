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
    /// The storage configuration provides the connection details that allows
    /// the Time Series Insights service to connect to the customer storage
    /// account that is used to store the environment's data.
    /// </summary>
    public partial class LongTermStorageConfigurationInput
    {
        /// <summary>
        /// Initializes a new instance of the LongTermStorageConfigurationInput
        /// class.
        /// </summary>
        public LongTermStorageConfigurationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LongTermStorageConfigurationInput
        /// class.
        /// </summary>
        /// <param name="accountName">The name of the storage account that will
        /// hold the environment's long term data.</param>
        /// <param name="managementKey">The value of the management key that
        /// grants the Time Series Insights service write access to the storage
        /// account. This property is not shown in environment
        /// responses.</param>
        public LongTermStorageConfigurationInput(string accountName, string managementKey)
        {
            this.AccountName = accountName;
            this.ManagementKey = managementKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the storage account that will hold the
        /// environment's long term data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the value of the management key that grants the Time
        /// Series Insights service write access to the storage account. This
        /// property is not shown in environment responses.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "managementKey")]
        public string ManagementKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.AccountName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AccountName");
            }
            if (this.ManagementKey == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "ManagementKey");
            }
        }
    }
}