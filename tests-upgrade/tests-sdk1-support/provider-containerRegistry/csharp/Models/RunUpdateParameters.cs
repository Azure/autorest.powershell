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
    /// The set of run properties that can be updated.
    /// </summary>
    public partial class RunUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the RunUpdateParameters class.
        /// </summary>
        public RunUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunUpdateParameters class.
        /// </summary>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled or not.</param>
        public RunUpdateParameters(bool? isArchiveEnabled = default(bool?))
        {
            this.IsArchiveEnabled = isArchiveEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value that indicates whether archiving is enabled
        /// or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isArchiveEnabled")]
        public bool? IsArchiveEnabled { get; set; }

    }
}
