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
    /// The parameters used to regenerate the login credential.
    /// </summary>
    public partial class RegenerateCredentialParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateCredentialParameters
        /// class.
        /// </summary>
        public RegenerateCredentialParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegenerateCredentialParameters
        /// class.
        /// </summary>
        /// <param name="name">Specifies name of the password which should be
        /// regenerated -- password or password2. Possible values include:
        /// 'password', 'password2'</param>
        public RegenerateCredentialParameters(PasswordName name)
        {
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies name of the password which should be
        /// regenerated -- password or password2. Possible values include:
        /// 'password', 'password2'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public PasswordName Name { get; set; }

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
