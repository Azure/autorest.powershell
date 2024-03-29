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
    /// Defines headers for customNamedRequestIdHead operation.
    /// </summary>
    public partial class HeaderCustomNamedRequestIdHeadHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HeaderCustomNamedRequestIdHeadHeaders class.
        /// </summary>
        public HeaderCustomNamedRequestIdHeadHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// HeaderCustomNamedRequestIdHeadHeaders class.
        /// </summary>
        /// <param name="fooRequestId">Gets the foo-request-id.</param>
        /// <param name="cooRequestId">Gets the coo-request-id.</param>
        /// <param name="dooRequestId">Gets the foo-request-id.</param>
        public HeaderCustomNamedRequestIdHeadHeaders(string fooRequestId = default(string), string cooRequestId = default(string), string dooRequestId = default(string))
        {
            this.FooRequestId = fooRequestId;
            this.CooRequestId = cooRequestId;
            this.DooRequestId = dooRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the foo-request-id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "foo-request-id")]
        public string FooRequestId { get; set; }

        /// <summary>
        /// Gets the coo-request-id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "coo-request-id")]
        public string CooRequestId { get; set; }

        /// <summary>
        /// Gets the foo-request-id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "doo-request-id")]
        public string DooRequestId { get; set; }

    }
}
