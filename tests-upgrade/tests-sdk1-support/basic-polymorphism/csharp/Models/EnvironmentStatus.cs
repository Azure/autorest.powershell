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
    /// An object that represents the status of the environment, and its
    /// internal state in the Time Series Insights service.
    /// </summary>
    public partial class EnvironmentStatus
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentStatus class.
        /// </summary>
        public EnvironmentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentStatus class.
        /// </summary>
        /// <param name="ingress">An object that represents the status of
        /// ingress on an environment.</param>
        /// <param name="warmStorage">An object that represents the status of
        /// warm storage on an environment.</param>
        public EnvironmentStatus(IngressEnvironmentStatus ingress = default(IngressEnvironmentStatus), WarmStorageEnvironmentStatus warmStorage = default(WarmStorageEnvironmentStatus))
        {
            this.Ingress = ingress;
            this.WarmStorage = warmStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an object that represents the status of ingress on an
        /// environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ingress")]
        public IngressEnvironmentStatus Ingress {get; private set; }

        /// <summary>
        /// Gets or sets an object that represents the status of warm storage
        /// on an environment.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "warmStorage")]
        public WarmStorageEnvironmentStatus WarmStorage {get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.WarmStorage != null)
            {
                this.WarmStorage.Validate();
            }
        }
    }
}
