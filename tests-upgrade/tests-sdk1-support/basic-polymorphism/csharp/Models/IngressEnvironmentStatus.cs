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
    /// An object that represents the status of ingress on an environment.
    /// </summary>
    public partial class IngressEnvironmentStatus
    {
        /// <summary>
        /// Initializes a new instance of the IngressEnvironmentStatus class.
        /// </summary>
        public IngressEnvironmentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IngressEnvironmentStatus class.
        /// </summary>
        /// <param name="state">This string represents the state of ingress
        /// operations on an environment. It can be "Disabled", "Ready",
        /// "Running", "Paused" or "Unknown". Possible values include:
        /// 'Disabled', 'Ready', 'Running', 'Paused', 'Unknown'</param>
        /// <param name="stateDetails">An object that contains the details
        /// about an environment's state.</param>
        public IngressEnvironmentStatus(IngressState? state = default(IngressState?), EnvironmentStateDetails stateDetails = default(EnvironmentStateDetails))
        {
            this.State = state;
            this.StateDetails = stateDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this string represents the state of ingress operations
        /// on an environment. It can be "Disabled", "Ready", "Running",
        /// "Paused" or "Unknown". Possible values include: 'Disabled',
        /// 'Ready', 'Running', 'Paused', 'Unknown'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public IngressState? State { get; set; }

        /// <summary>
        /// Gets or sets an object that contains the details about an
        /// environment's state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateDetails")]
        public EnvironmentStateDetails StateDetails {get; private set; }

    }
}
