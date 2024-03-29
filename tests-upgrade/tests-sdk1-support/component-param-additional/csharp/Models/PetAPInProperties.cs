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

    public partial class PetAPInProperties
    {
        /// <summary>
        /// Initializes a new instance of the PetAPInProperties class.
        /// </summary>
        public PetAPInProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PetAPInProperties class.
        /// </summary>
        public PetAPInProperties(int id, string name = default(string), bool? status = default(bool?), System.Collections.Generic.IDictionary<string, double?> additionalProperties = default(System.Collections.Generic.IDictionary<string, double?>))
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.AdditionalProperties = additionalProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public bool? Status { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "additionalProperties")]
        public System.Collections.Generic.IDictionary<string, double?> AdditionalProperties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
