// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>AzStackHCI cluster properties.</summary>
    public partial class AzStackHciClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>Gets or sets the AzStackHCICluster FQDN name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>Backing field for <see cref="ResourceName" /> property.</summary>
        private string _resourceName;

        /// <summary>Gets or sets the AzStackHCICluster resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResourceName { get => this._resourceName; set => this._resourceName = value; }

        /// <summary>Backing field for <see cref="StorageAccountName" /> property.</summary>
        private string _storageAccountName;

        /// <summary>Gets or sets the Storage account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string StorageAccountName { get => this._storageAccountName; set => this._storageAccountName = value; }

        /// <summary>Backing field for <see cref="StorageContainer" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> _storageContainer;

        /// <summary>Gets or sets the list of AzStackHCICluster Storage Container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> StorageContainer { get => this._storageContainer; set => this._storageContainer = value; }

        /// <summary>Creates an new <see cref="AzStackHciClusterProperties" /> instance.</summary>
        public AzStackHciClusterProperties()
        {

        }
    }
    /// AzStackHCI cluster properties.
    public partial interface IAzStackHciClusterProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the AzStackHCICluster FQDN name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the AzStackHCICluster FQDN name.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>Gets or sets the AzStackHCICluster resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the AzStackHCICluster resource name.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceName { get; set; }
        /// <summary>Gets or sets the Storage account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Storage account name.",
        SerializedName = @"storageAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountName { get; set; }
        /// <summary>Gets or sets the list of AzStackHCICluster Storage Container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of AzStackHCICluster Storage Container.",
        SerializedName = @"storageContainers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> StorageContainer { get; set; }

    }
    /// AzStackHCI cluster properties.
    internal partial interface IAzStackHciClusterPropertiesInternal

    {
        /// <summary>Gets or sets the AzStackHCICluster FQDN name.</summary>
        string ClusterName { get; set; }
        /// <summary>Gets or sets the AzStackHCICluster resource name.</summary>
        string ResourceName { get; set; }
        /// <summary>Gets or sets the Storage account name.</summary>
        string StorageAccountName { get; set; }
        /// <summary>Gets or sets the list of AzStackHCICluster Storage Container.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> StorageContainer { get; set; }

    }
}