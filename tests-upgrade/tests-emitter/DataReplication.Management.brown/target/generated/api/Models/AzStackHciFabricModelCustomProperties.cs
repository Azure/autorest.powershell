// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>AzStackHCI fabric model custom properties.</summary>
    public partial class AzStackHciFabricModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties __fabricModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricModelCustomProperties();

        /// <summary>Backing field for <see cref="ApplianceName" /> property.</summary>
        private System.Collections.Generic.List<string> _applianceName;

        /// <summary>Gets or sets the Appliance name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ApplianceName { get => this._applianceName; }

        /// <summary>Backing field for <see cref="AzStackHciSiteId" /> property.</summary>
        private string _azStackHciSiteId;

        /// <summary>Gets or sets the ARM Id of the AzStackHCI site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string AzStackHciSiteId { get => this._azStackHciSiteId; set => this._azStackHciSiteId = value; }

        /// <summary>Backing field for <see cref="Cluster" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties _cluster;

        /// <summary>AzStackHCI cluster properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties Cluster { get => (this._cluster = this._cluster ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties()); set => this._cluster = value; }

        /// <summary>Gets or sets the AzStackHCICluster FQDN name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ClusterName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).ClusterName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).ClusterName = value ; }

        /// <summary>Gets or sets the AzStackHCICluster resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ClusterResourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).ResourceName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).ResourceName = value ; }

        /// <summary>Gets or sets the Storage account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ClusterStorageAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).StorageAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).StorageAccountName = value ; }

        /// <summary>Gets or sets the list of AzStackHCICluster Storage Container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> ClusterStorageContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).StorageContainer; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterPropertiesInternal)Cluster).StorageContainer = value ; }

        /// <summary>Backing field for <see cref="FabricContainerId" /> property.</summary>
        private string _fabricContainerId;

        /// <summary>Gets or sets the fabric container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricContainerId { get => this._fabricContainerId; }

        /// <summary>Backing field for <see cref="FabricResourceId" /> property.</summary>
        private string _fabricResourceId;

        /// <summary>Gets or sets the fabric resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricResourceId { get => this._fabricResourceId; }

        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string InstanceType { get => "AzStackHCI"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal)__fabricModelCustomProperties).InstanceType = "AzStackHCI"; }

        /// <summary>Internal Acessors for ApplianceName</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal.ApplianceName { get => this._applianceName; set { {_applianceName = value;} } }

        /// <summary>Internal Acessors for Cluster</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal.Cluster { get => (this._cluster = this._cluster ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AzStackHciClusterProperties()); set { {_cluster = value;} } }

        /// <summary>Internal Acessors for FabricContainerId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal.FabricContainerId { get => this._fabricContainerId; set { {_fabricContainerId = value;} } }

        /// <summary>Internal Acessors for FabricResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal.FabricResourceId { get => this._fabricResourceId; set { {_fabricResourceId = value;} } }

        /// <summary>Internal Acessors for MigrationHubUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciFabricModelCustomPropertiesInternal.MigrationHubUri { get => this._migrationHubUri; set { {_migrationHubUri = value;} } }

        /// <summary>Backing field for <see cref="MigrationHubUri" /> property.</summary>
        private string _migrationHubUri;

        /// <summary>Gets or sets the migration hub Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string MigrationHubUri { get => this._migrationHubUri; }

        /// <summary>Backing field for <see cref="MigrationSolutionId" /> property.</summary>
        private string _migrationSolutionId;

        /// <summary>Gets or sets the Migration solution ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string MigrationSolutionId { get => this._migrationSolutionId; set => this._migrationSolutionId = value; }

        /// <summary>Creates an new <see cref="AzStackHciFabricModelCustomProperties" /> instance.</summary>
        public AzStackHciFabricModelCustomProperties()
        {
            this.__fabricModelCustomProperties.InstanceType = "AzStackHCI";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fabricModelCustomProperties), __fabricModelCustomProperties);
            await eventListener.AssertObjectIsValid(nameof(__fabricModelCustomProperties), __fabricModelCustomProperties);
        }
    }
    /// AzStackHCI fabric model custom properties.
    public partial interface IAzStackHciFabricModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomProperties
    {
        /// <summary>Gets or sets the Appliance name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the Appliance name.",
        SerializedName = @"applianceName",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ApplianceName { get;  }
        /// <summary>Gets or sets the ARM Id of the AzStackHCI site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the ARM Id of the AzStackHCI site.",
        SerializedName = @"azStackHciSiteId",
        PossibleTypes = new [] { typeof(string) })]
        string AzStackHciSiteId { get; set; }
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
        string ClusterResourceName { get; set; }
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
        string ClusterStorageAccountName { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> ClusterStorageContainer { get; set; }
        /// <summary>Gets or sets the fabric container Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric container Id.",
        SerializedName = @"fabricContainerId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricContainerId { get;  }
        /// <summary>Gets or sets the fabric resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric resource Id.",
        SerializedName = @"fabricResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricResourceId { get;  }
        /// <summary>Gets or sets the migration hub Uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the migration hub Uri.",
        SerializedName = @"migrationHubUri",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationHubUri { get;  }
        /// <summary>Gets or sets the Migration solution ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Migration solution ARM Id.",
        SerializedName = @"migrationSolutionId",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationSolutionId { get; set; }

    }
    /// AzStackHCI fabric model custom properties.
    internal partial interface IAzStackHciFabricModelCustomPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricModelCustomPropertiesInternal
    {
        /// <summary>Gets or sets the Appliance name.</summary>
        System.Collections.Generic.List<string> ApplianceName { get; set; }
        /// <summary>Gets or sets the ARM Id of the AzStackHCI site.</summary>
        string AzStackHciSiteId { get; set; }
        /// <summary>AzStackHCI cluster properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAzStackHciClusterProperties Cluster { get; set; }
        /// <summary>Gets or sets the AzStackHCICluster FQDN name.</summary>
        string ClusterName { get; set; }
        /// <summary>Gets or sets the AzStackHCICluster resource name.</summary>
        string ClusterResourceName { get; set; }
        /// <summary>Gets or sets the Storage account name.</summary>
        string ClusterStorageAccountName { get; set; }
        /// <summary>Gets or sets the list of AzStackHCICluster Storage Container.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IStorageContainerProperties> ClusterStorageContainer { get; set; }
        /// <summary>Gets or sets the fabric container Id.</summary>
        string FabricContainerId { get; set; }
        /// <summary>Gets or sets the fabric resource Id.</summary>
        string FabricResourceId { get; set; }
        /// <summary>Gets or sets the migration hub Uri.</summary>
        string MigrationHubUri { get; set; }
        /// <summary>Gets or sets the Migration solution ARM Id.</summary>
        string MigrationSolutionId { get; set; }

    }
}