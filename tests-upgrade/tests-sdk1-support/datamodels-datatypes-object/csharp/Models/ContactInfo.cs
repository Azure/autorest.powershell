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

    public partial class ContactInfo
    {
        /// <summary>
        /// Initializes a new instance of the ContactInfo class.
        /// </summary>
        public ContactInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContactInfo class.
        /// </summary>
        public ContactInfo(string email = default(string), string phone = default(string))
        {
            this.Email = email;
            this.Phone = phone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

    }
}
