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
    /// Parameters supplied to the Create or Update Event Source operation.
    /// </summary>
    [Newtonsoft.Json.JsonObject("EventSourceCreateOrUpdateParameters")]
    public partial class EventSourceCreateOrUpdateParameters : CreateOrUpdateTrackedResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EventSourceCreateOrUpdateParameters class.
        /// </summary>
        public EventSourceCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EventSourceCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">Key-value pairs of additional properties for the
        /// resource.</param>
        public EventSourceCreateOrUpdateParameters(string location, string tags = default(string))
            : base(location, tags)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
