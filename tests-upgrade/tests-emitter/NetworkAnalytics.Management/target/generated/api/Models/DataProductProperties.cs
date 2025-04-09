// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The data product properties.</summary>
    public partial class DataProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AvailableMinorVersion" /> property.</summary>
        private System.Collections.Generic.List<string> _availableMinorVersion;

        /// <summary>List of available minor versions of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AvailableMinorVersion { get => this._availableMinorVersion; }

        /// <summary>Backing field for <see cref="ConsumptionEndpoint" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties _consumptionEndpoint;

        /// <summary>Resource links which exposed to the customer to query the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties ConsumptionEndpoint { get => (this._consumptionEndpoint = this._consumptionEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsProperties()); }

        /// <summary>Resource Id of file access endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointFileAccessResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).FileAccessResourceId; }

        /// <summary>Url to consume file type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointFileAccessUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).FileAccessUrl; }

        /// <summary>Resource Id of ingestion endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointIngestionResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).IngestionResourceId; }

        /// <summary>Ingestion url to upload the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointIngestionUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).IngestionUrl; }

        /// <summary>Resource Id of query endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointQueryResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).QueryResourceId; }

        /// <summary>Url to consume the processed data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ConsumptionEndpointQueryUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).QueryUrl; }

        /// <summary>Backing field for <see cref="CurrentMinorVersion" /> property.</summary>
        private string _currentMinorVersion;

        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string CurrentMinorVersion { get => this._currentMinorVersion; set => this._currentMinorVersion = value; }

        /// <summary>Backing field for <see cref="CustomerEncryptionKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails _customerEncryptionKey;

        /// <summary>Customer managed encryption key details for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails CustomerEncryptionKey { get => (this._customerEncryptionKey = this._customerEncryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetails()); set => this._customerEncryptionKey = value; }

        /// <summary>The name of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerEncryptionKeyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetailsInternal)CustomerEncryptionKey).KeyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetailsInternal)CustomerEncryptionKey).KeyName = value ?? null; }

        /// <summary>The Uri of the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerEncryptionKeyVaultUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetailsInternal)CustomerEncryptionKey).KeyVaultUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetailsInternal)CustomerEncryptionKey).KeyVaultUri = value ?? null; }

        /// <summary>The version of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string CustomerEncryptionKeyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetailsInternal)CustomerEncryptionKey).KeyVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetailsInternal)CustomerEncryptionKey).KeyVersion = value ?? null; }

        /// <summary>Backing field for <see cref="CustomerManagedKeyEncryptionEnabled" /> property.</summary>
        private string _customerManagedKeyEncryptionEnabled;

        /// <summary>Flag to enable customer managed key encryption for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string CustomerManagedKeyEncryptionEnabled { get => this._customerManagedKeyEncryptionEnabled; set => this._customerManagedKeyEncryptionEnabled = value; }

        /// <summary>Backing field for <see cref="Documentation" /> property.</summary>
        private string _documentation;

        /// <summary>Documentation link for the data product based on definition file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Documentation { get => this._documentation; }

        /// <summary>Backing field for <see cref="KeyVaultUrl" /> property.</summary>
        private string _keyVaultUrl;

        /// <summary>Key vault url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string KeyVaultUrl { get => this._keyVaultUrl; }

        /// <summary>Backing field for <see cref="MajorVersion" /> property.</summary>
        private string _majorVersion;

        /// <summary>Major version of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string MajorVersion { get => this._majorVersion; set => this._majorVersion = value; }

        /// <summary>Backing field for <see cref="ManagedResourceGroupConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration _managedResourceGroupConfiguration;

        /// <summary>Managed resource group configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get => (this._managedResourceGroupConfiguration = this._managedResourceGroupConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedResourceGroupConfiguration()); set => this._managedResourceGroupConfiguration = value; }

        /// <summary>Managed Resource Group location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupConfigurationLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfigurationInternal)ManagedResourceGroupConfiguration).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfigurationInternal)ManagedResourceGroupConfiguration).Location = value ?? null; }

        /// <summary>Name of managed resource group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupConfigurationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfigurationInternal)ManagedResourceGroupConfiguration).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfigurationInternal)ManagedResourceGroupConfiguration).Name = value ?? null; }

        /// <summary>Internal Acessors for AvailableMinorVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.AvailableMinorVersion { get => this._availableMinorVersion; set { {_availableMinorVersion = value;} } }

        /// <summary>Internal Acessors for ConsumptionEndpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpoint { get => (this._consumptionEndpoint = this._consumptionEndpoint ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsProperties()); set { {_consumptionEndpoint = value;} } }

        /// <summary>Internal Acessors for ConsumptionEndpointFileAccessResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpointFileAccessResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).FileAccessResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).FileAccessResourceId = value; }

        /// <summary>Internal Acessors for ConsumptionEndpointFileAccessUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpointFileAccessUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).FileAccessUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).FileAccessUrl = value; }

        /// <summary>Internal Acessors for ConsumptionEndpointIngestionResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpointIngestionResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).IngestionResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).IngestionResourceId = value; }

        /// <summary>Internal Acessors for ConsumptionEndpointIngestionUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpointIngestionUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).IngestionUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).IngestionUrl = value; }

        /// <summary>Internal Acessors for ConsumptionEndpointQueryResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpointQueryResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).QueryResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).QueryResourceId = value; }

        /// <summary>Internal Acessors for ConsumptionEndpointQueryUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ConsumptionEndpointQueryUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).QueryUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal)ConsumptionEndpoint).QueryUrl = value; }

        /// <summary>Internal Acessors for CustomerEncryptionKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.CustomerEncryptionKey { get => (this._customerEncryptionKey = this._customerEncryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetails()); set { {_customerEncryptionKey = value;} } }

        /// <summary>Internal Acessors for Documentation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.Documentation { get => this._documentation; set { {_documentation = value;} } }

        /// <summary>Internal Acessors for KeyVaultUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.KeyVaultUrl { get => this._keyVaultUrl; set { {_keyVaultUrl = value;} } }

        /// <summary>Internal Acessors for ManagedResourceGroupConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ManagedResourceGroupConfiguration { get => (this._managedResourceGroupConfiguration = this._managedResourceGroupConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ManagedResourceGroupConfiguration()); set { {_managedResourceGroupConfiguration = value;} } }

        /// <summary>Internal Acessors for Networkacl</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.Networkacl { get => (this._networkacl = this._networkacl ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAcls()); set { {_networkacl = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductPropertiesInternal.ResourceGuid { get => this._resourceGuid; set { {_resourceGuid = value;} } }

        /// <summary>Backing field for <see cref="Networkacl" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls _networkacl;

        /// <summary>Network rule set for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls Networkacl { get => (this._networkacl = this._networkacl ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAcls()); set => this._networkacl = value; }

        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> NetworkaclAllowedQueryIPRangeList { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).AllowedQueryIPRangeList; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).AllowedQueryIPRangeList = value ?? null /* arrayOf */; }

        /// <summary>Default Action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string NetworkaclDefaultAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).DefaultAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).DefaultAction = value ?? null; }

        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> NetworkaclIPRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).IPRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).IPRule = value ?? null /* arrayOf */; }

        /// <summary>Virtual Network Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> NetworkaclVirtualNetworkRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).VirtualNetworkRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal)Networkacl).VirtualNetworkRule = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private System.Collections.Generic.List<string> _owner;

        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Owner { get => this._owner; set => this._owner = value; }

        /// <summary>Backing field for <see cref="PrivateLinksEnabled" /> property.</summary>
        private string _privateLinksEnabled;

        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PrivateLinksEnabled { get => this._privateLinksEnabled; set => this._privateLinksEnabled = value; }

        /// <summary>Backing field for <see cref="Product" /> property.</summary>
        private string _product;

        /// <summary>Product name of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Product { get => this._product; set => this._product = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicNetworkAccess" /> property.</summary>
        private string _publicNetworkAccess;

        /// <summary>Flag to enable or disable public access of data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PublicNetworkAccess { get => this._publicNetworkAccess; set => this._publicNetworkAccess = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>Data product publisher name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="PurviewAccount" /> property.</summary>
        private string _purviewAccount;

        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PurviewAccount { get => this._purviewAccount; set => this._purviewAccount = value; }

        /// <summary>Backing field for <see cref="PurviewCollection" /> property.</summary>
        private string _purviewCollection;

        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PurviewCollection { get => this._purviewCollection; set => this._purviewCollection = value; }

        /// <summary>Backing field for <see cref="Redundancy" /> property.</summary>
        private string _redundancy;

        /// <summary>Flag to enable or disable redundancy for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Redundancy { get => this._redundancy; set => this._redundancy = value; }

        /// <summary>Backing field for <see cref="ResourceGuid" /> property.</summary>
        private string _resourceGuid;

        /// <summary>The resource GUID property of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string ResourceGuid { get => this._resourceGuid; }

        /// <summary>Creates an new <see cref="DataProductProperties" /> instance.</summary>
        public DataProductProperties()
        {

        }
    }
    /// The data product properties.
    public partial interface IDataProductProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>List of available minor versions of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of available minor versions of the data product resource.",
        SerializedName = @"availableMinorVersions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AvailableMinorVersion { get;  }
        /// <summary>Resource Id of file access endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of file access endpoint.",
        SerializedName = @"fileAccessResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointFileAccessResourceId { get;  }
        /// <summary>Url to consume file type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to consume file type.",
        SerializedName = @"fileAccessUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointFileAccessUrl { get;  }
        /// <summary>Resource Id of ingestion endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of ingestion endpoint.",
        SerializedName = @"ingestionResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointIngestionResourceId { get;  }
        /// <summary>Ingestion url to upload the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Ingestion url to upload the data.",
        SerializedName = @"ingestionUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointIngestionUrl { get;  }
        /// <summary>Resource Id of query endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of query endpoint.",
        SerializedName = @"queryResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointQueryResourceId { get;  }
        /// <summary>Url to consume the processed data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to consume the processed data.",
        SerializedName = @"queryUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumptionEndpointQueryUrl { get;  }
        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = false,
        Update = true,
        Description = @"Current configured minor version of the data product resource.",
        SerializedName = @"currentMinorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentMinorVersion { get; set; }
        /// <summary>The name of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The name of the key vault key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerEncryptionKeyName { get; set; }
        /// <summary>The Uri of the key vault.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The Uri of the key vault.",
        SerializedName = @"keyVaultUri",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerEncryptionKeyVaultUri { get; set; }
        /// <summary>The version of the key vault key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The version of the key vault key.",
        SerializedName = @"keyVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CustomerEncryptionKeyVersion { get; set; }
        /// <summary>Flag to enable customer managed key encryption for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Flag to enable customer managed key encryption for data product.",
        SerializedName = @"customerManagedKeyEncryptionEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string CustomerManagedKeyEncryptionEnabled { get; set; }
        /// <summary>Documentation link for the data product based on definition file.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Documentation link for the data product based on definition file.",
        SerializedName = @"documentation",
        PossibleTypes = new [] { typeof(string) })]
        string Documentation { get;  }
        /// <summary>Key vault url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Key vault url.",
        SerializedName = @"keyVaultUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultUrl { get;  }
        /// <summary>Major version of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Major version of data product.",
        SerializedName = @"majorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MajorVersion { get; set; }
        /// <summary>Managed Resource Group location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Managed Resource Group location",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupConfigurationLocation { get; set; }
        /// <summary>Name of managed resource group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = false,
        Create = true,
        Update = false,
        Description = @"Name of managed resource group",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupConfigurationName { get; set; }
        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.",
        SerializedName = @"allowedQueryIpRangeList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> NetworkaclAllowedQueryIPRangeList { get; set; }
        /// <summary>Default Action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Default Action",
        SerializedName = @"defaultAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Allow", "Deny")]
        string NetworkaclDefaultAction { get; set; }
        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"IP rule with specific IP or IP range in CIDR format.",
        SerializedName = @"ipRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> NetworkaclIPRule { get; set; }
        /// <summary>Virtual Network Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Virtual Network Rule",
        SerializedName = @"virtualNetworkRule",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> NetworkaclVirtualNetworkRule { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of name or email associated with data product resource deployment.",
        SerializedName = @"owners",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to enable or disable private link for data product resource.",
        SerializedName = @"privateLinksEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Product name of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Product name of data product.",
        SerializedName = @"product",
        PossibleTypes = new [] { typeof(string) })]
        string Product { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Latest provisioning state  of data product.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Flag to enable or disable public access of data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Flag to enable or disable public access of data product resource.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Data product publisher name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Data product publisher name.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview account url for data product to connect to.",
        SerializedName = @"purviewAccount",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview collection url for data product to connect to.",
        SerializedName = @"purviewCollection",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewCollection { get; set; }
        /// <summary>Flag to enable or disable redundancy for data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Flag to enable or disable redundancy for data product.",
        SerializedName = @"redundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Redundancy { get; set; }
        /// <summary>The resource GUID property of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource GUID property of the data product resource.",
        SerializedName = @"resourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuid { get;  }

    }
    /// The data product properties.
    internal partial interface IDataProductPropertiesInternal

    {
        /// <summary>List of available minor versions of the data product resource.</summary>
        System.Collections.Generic.List<string> AvailableMinorVersion { get; set; }
        /// <summary>Resource links which exposed to the customer to query the data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties ConsumptionEndpoint { get; set; }
        /// <summary>Resource Id of file access endpoint.</summary>
        string ConsumptionEndpointFileAccessResourceId { get; set; }
        /// <summary>Url to consume file type.</summary>
        string ConsumptionEndpointFileAccessUrl { get; set; }
        /// <summary>Resource Id of ingestion endpoint.</summary>
        string ConsumptionEndpointIngestionResourceId { get; set; }
        /// <summary>Ingestion url to upload the data.</summary>
        string ConsumptionEndpointIngestionUrl { get; set; }
        /// <summary>Resource Id of query endpoint.</summary>
        string ConsumptionEndpointQueryResourceId { get; set; }
        /// <summary>Url to consume the processed data.</summary>
        string ConsumptionEndpointQueryUrl { get; set; }
        /// <summary>Current configured minor version of the data product resource.</summary>
        string CurrentMinorVersion { get; set; }
        /// <summary>Customer managed encryption key details for data product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IEncryptionKeyDetails CustomerEncryptionKey { get; set; }
        /// <summary>The name of the key vault key.</summary>
        string CustomerEncryptionKeyName { get; set; }
        /// <summary>The Uri of the key vault.</summary>
        string CustomerEncryptionKeyVaultUri { get; set; }
        /// <summary>The version of the key vault key.</summary>
        string CustomerEncryptionKeyVersion { get; set; }
        /// <summary>Flag to enable customer managed key encryption for data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string CustomerManagedKeyEncryptionEnabled { get; set; }
        /// <summary>Documentation link for the data product based on definition file.</summary>
        string Documentation { get; set; }
        /// <summary>Key vault url.</summary>
        string KeyVaultUrl { get; set; }
        /// <summary>Major version of data product.</summary>
        string MajorVersion { get; set; }
        /// <summary>Managed resource group configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary>Managed Resource Group location</summary>
        string ManagedResourceGroupConfigurationLocation { get; set; }
        /// <summary>Name of managed resource group</summary>
        string ManagedResourceGroupConfigurationName { get; set; }
        /// <summary>Network rule set for data product.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls Networkacl { get; set; }
        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        System.Collections.Generic.List<string> NetworkaclAllowedQueryIPRangeList { get; set; }
        /// <summary>Default Action</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Allow", "Deny")]
        string NetworkaclDefaultAction { get; set; }
        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> NetworkaclIPRule { get; set; }
        /// <summary>Virtual Network Rule</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> NetworkaclVirtualNetworkRule { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Product name of data product.</summary>
        string Product { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Flag to enable or disable public access of data product resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Data product publisher name.</summary>
        string Publisher { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        string PurviewCollection { get; set; }
        /// <summary>Flag to enable or disable redundancy for data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string Redundancy { get; set; }
        /// <summary>The resource GUID property of the data product resource.</summary>
        string ResourceGuid { get; set; }

    }
}