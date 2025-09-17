// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Describes the result of the request to list Managed VM Sizes for Service Fabric Managed Clusters.
    /// </summary>
    public partial class ManagedAzResiliencyStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedAzResiliencyStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedAzResiliencyStatusInternal
    {

        /// <summary>Backing field for <see cref="BaseResourceStatus" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatus> _baseResourceStatus;

        /// <summary>List of Managed VM Sizes for Service Fabric Managed Clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatus> BaseResourceStatus { get => this._baseResourceStatus; set => this._baseResourceStatus = value; }

        /// <summary>Backing field for <see cref="IsClusterZoneResilient" /> property.</summary>
        private bool? _isClusterZoneResilient;

        /// <summary>URL to get the next set of Managed VM Sizes if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsClusterZoneResilient { get => this._isClusterZoneResilient; }

        /// <summary>Internal Acessors for IsClusterZoneResilient</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IManagedAzResiliencyStatusInternal.IsClusterZoneResilient { get => this._isClusterZoneResilient; set { {_isClusterZoneResilient = value;} } }

        /// <summary>Creates an new <see cref="ManagedAzResiliencyStatus" /> instance.</summary>
        public ManagedAzResiliencyStatus()
        {

        }
    }
    /// Describes the result of the request to list Managed VM Sizes for Service Fabric Managed Clusters.
    public partial interface IManagedAzResiliencyStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>List of Managed VM Sizes for Service Fabric Managed Clusters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Managed VM Sizes for Service Fabric Managed Clusters.",
        SerializedName = @"baseResourceStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatus> BaseResourceStatus { get; set; }
        /// <summary>URL to get the next set of Managed VM Sizes if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"URL to get the next set of Managed VM Sizes if there are any.",
        SerializedName = @"isClusterZoneResilient",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsClusterZoneResilient { get;  }

    }
    /// Describes the result of the request to list Managed VM Sizes for Service Fabric Managed Clusters.
    internal partial interface IManagedAzResiliencyStatusInternal

    {
        /// <summary>List of Managed VM Sizes for Service Fabric Managed Clusters.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatus> BaseResourceStatus { get; set; }
        /// <summary>URL to get the next set of Managed VM Sizes if there are any.</summary>
        bool? IsClusterZoneResilient { get; set; }

    }
}