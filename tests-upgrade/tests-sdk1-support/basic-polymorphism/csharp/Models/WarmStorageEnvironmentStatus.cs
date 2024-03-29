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
    /// An object that represents the status of warm storage on an environment.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class WarmStorageEnvironmentStatus
    {
        /// <summary>
        /// Initializes a new instance of the WarmStorageEnvironmentStatus
        /// class.
        /// </summary>
        public WarmStorageEnvironmentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WarmStorageEnvironmentStatus
        /// class.
        /// </summary>
        /// <param name="state">This string represents the state of warm
        /// storage properties usage. It can be "Ok", "Error", "Unknown".
        /// Possible values include: 'Ok', 'Error', 'Unknown'</param>
        /// <param name="currentCount">A value that represents the number of
        /// properties used by the environment for S1/S2 SKU and number of
        /// properties used by Warm Store for PAYG SKU</param>
        /// <param name="maxCount">A value that represents the maximum number
        /// of properties used allowed by the environment for S1/S2 SKU and
        /// maximum number of properties allowed by Warm Store for PAYG
        /// SKU.</param>
        public WarmStorageEnvironmentStatus(WarmStoragePropertiesState? state = default(WarmStoragePropertiesState?), int? currentCount = default(int?), int? maxCount = default(int?))
        {
            this.State = state;
            this.CurrentCount = currentCount;
            this.MaxCount = maxCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this string represents the state of warm storage
        /// properties usage. It can be "Ok", "Error", "Unknown". Possible
        /// values include: 'Ok', 'Error', 'Unknown'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "propertiesUsage.state")]
        public WarmStoragePropertiesState? State {get; private set; }

        /// <summary>
        /// Gets or sets a value that represents the number of properties used
        /// by the environment for S1/S2 SKU and number of properties used by
        /// Warm Store for PAYG SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "propertiesUsage.stateDetails.currentCount")]
        public int? CurrentCount {get; private set; }

        /// <summary>
        /// Gets or sets a value that represents the maximum number of
        /// properties used allowed by the environment for S1/S2 SKU and
        /// maximum number of properties allowed by Warm Store for PAYG SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "propertiesUsage.stateDetails.maxCount")]
        public int? MaxCount {get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.CurrentCount != null)
            {
                if (this.CurrentCount > 10)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "CurrentCount", 10);
                }
                if (this.CurrentCount < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "CurrentCount", 1);
                }
            }
            if (this.MaxCount != null)
            {
                if (this.MaxCount > 10)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "MaxCount", 10);
                }
                if (this.MaxCount < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "MaxCount", 1);
                }
            }
        }
    }
}
