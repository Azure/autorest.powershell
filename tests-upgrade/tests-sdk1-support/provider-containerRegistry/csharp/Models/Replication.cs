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
    /// An object that represents a replication for a container registry.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Replication : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Replication class.
        /// </summary>
        public Replication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Replication class.
        /// </summary>
        /// <param name="location">The location of the resource. This cannot be
        /// changed after the resource is created.</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// replication at the time the operation was called. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="status">The status of the replication at the time the
        /// operation was called.</param>
        public Replication(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string provisioningState = default(string), Status status = default(Status))
            : base(location, id, name, type, tags)
        {
            this.ProvisioningState = provisioningState;
            this.Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the replication at the time the
        /// operation was called. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the replication at the time the operation was
        /// called.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.status")]
        public Status Status { get; private set; }

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
