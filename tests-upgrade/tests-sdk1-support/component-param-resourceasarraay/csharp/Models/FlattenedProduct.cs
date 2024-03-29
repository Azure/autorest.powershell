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

    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class FlattenedProduct : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FlattenedProduct class.
        /// </summary>
        public FlattenedProduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FlattenedProduct class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="type">Resource Type</param>
        /// <param name="location">Resource Location</param>
        /// <param name="name">Resource Name</param>
        public FlattenedProduct(string id = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string location = default(string), string name = default(string), string pname = default(string), int? lsize = default(int?), string provisioningState = default(string))
            : base(id, type, tags, location, name)
        {
            this.Pname = pname;
            this.Lsize = lsize;
            this.ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.pname")]
        public string Pname { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lsize")]
        public int? Lsize { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
