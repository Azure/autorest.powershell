// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes the policy to be used for placement of a Service Fabric service.</summary>
    public partial class ServicePlacementPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicyInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The type of placement policy for a service fabric service. Following are the possible values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ServicePlacementPolicy" /> instance.</summary>
        public ServicePlacementPolicy()
        {

        }
    }
    /// Describes the policy to be used for placement of a Service Fabric service.
    public partial interface IServicePlacementPolicy :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The type of placement policy for a service fabric service. Following are the possible values.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of placement policy for a service fabric service. Following are the possible values.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("InvalidDomain", "RequiredDomain", "PreferredPrimaryDomain", "RequiredDomainDistribution", "NonPartiallyPlaceService")]
        string Type { get; set; }

    }
    /// Describes the policy to be used for placement of a Service Fabric service.
    internal partial interface IServicePlacementPolicyInternal

    {
        /// <summary>
        /// The type of placement policy for a service fabric service. Following are the possible values.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PSArgumentCompleterAttribute("InvalidDomain", "RequiredDomain", "PreferredPrimaryDomain", "RequiredDomainDistribution", "NonPartiallyPlaceService")]
        string Type { get; set; }

    }
}