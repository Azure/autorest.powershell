// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The settings to enable AAD authentication on the cluster.</summary>
    public partial class AzureActiveDirectory :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectory,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAzureActiveDirectoryInternal
    {

        /// <summary>Backing field for <see cref="ClientApplication" /> property.</summary>
        private string _clientApplication;

        /// <summary>Azure active directory client application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClientApplication { get => this._clientApplication; set => this._clientApplication = value; }

        /// <summary>Backing field for <see cref="ClusterApplication" /> property.</summary>
        private string _clusterApplication;

        /// <summary>Azure active directory cluster application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ClusterApplication { get => this._clusterApplication; set => this._clusterApplication = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Azure active directory tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="AzureActiveDirectory" /> instance.</summary>
        public AzureActiveDirectory()
        {

        }
    }
    /// The settings to enable AAD authentication on the cluster.
    public partial interface IAzureActiveDirectory :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Azure active directory client application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure active directory client application id.",
        SerializedName = @"clientApplication",
        PossibleTypes = new [] { typeof(string) })]
        string ClientApplication { get; set; }
        /// <summary>Azure active directory cluster application id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure active directory cluster application id.",
        SerializedName = @"clusterApplication",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterApplication { get; set; }
        /// <summary>Azure active directory tenant id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure active directory tenant id.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// The settings to enable AAD authentication on the cluster.
    internal partial interface IAzureActiveDirectoryInternal

    {
        /// <summary>Azure active directory client application id.</summary>
        string ClientApplication { get; set; }
        /// <summary>Azure active directory cluster application id.</summary>
        string ClusterApplication { get; set; }
        /// <summary>Azure active directory tenant id.</summary>
        string TenantId { get; set; }

    }
}