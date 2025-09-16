// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes Az Resiliency status of Base resources</summary>
    public partial class ResourceAzStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatus,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatusInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string _detail;

        /// <summary>Zone resiliency status details for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="IsZoneResilient" /> property.</summary>
        private bool? _isZoneResilient;

        /// <summary>VM Size name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsZoneResilient { get => this._isZoneResilient; }

        /// <summary>Internal Acessors for Detail</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatusInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Internal Acessors for IsZoneResilient</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatusInternal.IsZoneResilient { get => this._isZoneResilient; set { {_isZoneResilient = value;} } }

        /// <summary>Internal Acessors for ResourceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatusInternal.ResourceName { get => this._resourceName; set { {_resourceName = value;} } }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IResourceAzStatusInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Backing field for <see cref="ResourceName" /> property.</summary>
        private string _resourceName;

        /// <summary>VM Size properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ResourceName { get => this._resourceName; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>VM Size id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Creates an new <see cref="ResourceAzStatus" /> instance.</summary>
        public ResourceAzStatus()
        {

        }
    }
    /// Describes Az Resiliency status of Base resources
    public partial interface IResourceAzStatus :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Zone resiliency status details for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Zone resiliency status details for the resource.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get;  }
        /// <summary>VM Size name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"VM Size name.",
        SerializedName = @"isZoneResilient",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsZoneResilient { get;  }
        /// <summary>VM Size properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"VM Size properties.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceName { get;  }
        /// <summary>VM Size id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"VM Size id.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }

    }
    /// Describes Az Resiliency status of Base resources
    internal partial interface IResourceAzStatusInternal

    {
        /// <summary>Zone resiliency status details for the resource.</summary>
        string Detail { get; set; }
        /// <summary>VM Size name.</summary>
        bool? IsZoneResilient { get; set; }
        /// <summary>VM Size properties.</summary>
        string ResourceName { get; set; }
        /// <summary>VM Size id.</summary>
        string ResourceType { get; set; }

    }
}