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
    /// The result of a request to get container registry quota usages.
    /// </summary>
    public partial class RegistryUsageListResult
    {
        /// <summary>
        /// Initializes a new instance of the RegistryUsageListResult class.
        /// </summary>
        public RegistryUsageListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegistryUsageListResult class.
        /// </summary>
        /// <param name="value">The list of container registry quota
        /// usages.</param>
        public RegistryUsageListResult(System.Collections.Generic.IList<RegistryUsage> value = default(System.Collections.Generic.IList<RegistryUsage>))
        {
            this.Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of container registry quota usages.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<RegistryUsage> Value { get; set; }

    }
}
