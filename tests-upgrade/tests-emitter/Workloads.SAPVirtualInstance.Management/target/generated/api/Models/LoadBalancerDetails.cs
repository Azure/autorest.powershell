// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The Load Balancer details such as Load Balancer ID.</summary>
    public partial class LoadBalancerDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetails,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ILoadBalancerDetailsInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Creates an new <see cref="LoadBalancerDetails" /> instance.</summary>
        public LoadBalancerDetails()
        {

        }
    }
    /// The Load Balancer details such as Load Balancer ID.
    public partial interface ILoadBalancerDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Fully qualified resource ID for the load balancer.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }

    }
    /// The Load Balancer details such as Load Balancer ID.
    internal partial interface ILoadBalancerDetailsInternal

    {
        /// <summary>Fully qualified resource ID for the load balancer.</summary>
        string Id { get; set; }

    }
}