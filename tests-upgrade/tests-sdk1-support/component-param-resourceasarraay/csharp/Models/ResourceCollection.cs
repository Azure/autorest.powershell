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

    public partial class ResourceCollection
    {
        /// <summary>
        /// Initializes a new instance of the ResourceCollection class.
        /// </summary>
        public ResourceCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceCollection class.
        /// </summary>
        public ResourceCollection(FlattenedProduct productresource = default(FlattenedProduct), System.Collections.Generic.IList<FlattenedProduct> arrayofresources = default(System.Collections.Generic.IList<FlattenedProduct>), System.Collections.Generic.IDictionary<string, FlattenedProduct> dictionaryofresources = default(System.Collections.Generic.IDictionary<string, FlattenedProduct>))
        {
            this.Productresource = productresource;
            this.Arrayofresources = arrayofresources;
            this.Dictionaryofresources = dictionaryofresources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "productresource")]
        public FlattenedProduct Productresource { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "arrayofresources")]
        public System.Collections.Generic.IList<FlattenedProduct> Arrayofresources { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dictionaryofresources")]
        public System.Collections.Generic.IDictionary<string, FlattenedProduct> Dictionaryofresources { get; set; }

    }
}
