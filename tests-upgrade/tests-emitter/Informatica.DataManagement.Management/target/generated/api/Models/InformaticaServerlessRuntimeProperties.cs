// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Serverless Runtime properties.</summary>
    public partial class InformaticaServerlessRuntimeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdvancedCustomProperty" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> _advancedCustomProperty;

        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get => this._advancedCustomProperty; set => this._advancedCustomProperty = value; }

        /// <summary>Backing field for <see cref="ApplicationType" /> property.</summary>
        private string _applicationType;

        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ApplicationType { get => this._applicationType; set => this._applicationType = value; }

        /// <summary>Backing field for <see cref="ComputeUnit" /> property.</summary>
        private string _computeUnit;

        /// <summary>Compute units of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ComputeUnit { get => this._computeUnit; set => this._computeUnit = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>description of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="ExecutionTimeout" /> property.</summary>
        private string _executionTimeout;

        /// <summary>Serverless Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ExecutionTimeout { get => this._executionTimeout; set => this._executionTimeout = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ServerlessRuntimeConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal.ServerlessRuntimeConfig { get => (this._serverlessRuntimeConfig = this._serverlessRuntimeConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigProperties()); set { {_serverlessRuntimeConfig = value;} } }

        /// <summary>Internal Acessors for ServerlessRuntimeNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal.ServerlessRuntimeNetworkProfile { get => (this._serverlessRuntimeNetworkProfile = this._serverlessRuntimeNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfile()); set { {_serverlessRuntimeNetworkProfile = value;} } }

        /// <summary>
        /// Internal Acessors for ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal.ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ServerlessRuntimeUserContextProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimePropertiesInternal.ServerlessRuntimeUserContextProperty { get => (this._serverlessRuntimeUserContextProperty = this._serverlessRuntimeUserContextProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextProperties()); set { {_serverlessRuntimeUserContextProperty = value;} } }

        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationSubnetId = value ?? null; }

        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetId = value ?? null; }

        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetResourceGuid = value ?? null; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private string _platform;

        /// <summary>Platform type of the Serverless Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ServerlessAccountLocation" /> property.</summary>
        private string _serverlessAccountLocation;

        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ServerlessAccountLocation { get => this._serverlessAccountLocation; set => this._serverlessAccountLocation = value; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties _serverlessRuntimeConfig;

        /// <summary>Serverless config properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties ServerlessRuntimeConfig { get => (this._serverlessRuntimeConfig = this._serverlessRuntimeConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigProperties()); set => this._serverlessRuntimeConfig = value; }

        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfig).CdiConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfig).CdiConfigProp = value ?? null /* arrayOf */; }

        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfig).CdieConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfig).CdieConfigProp = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeNetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile _serverlessRuntimeNetworkProfile;

        /// <summary>Informatica Serverless Network profile properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile ServerlessRuntimeNetworkProfile { get => (this._serverlessRuntimeNetworkProfile = this._serverlessRuntimeNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfile()); set => this._serverlessRuntimeNetworkProfile = value; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeTag" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> _serverlessRuntimeTag;

        /// <summary>Serverless Runtime Tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get => this._serverlessRuntimeTag; set => this._serverlessRuntimeTag = value; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeUserContextProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties _serverlessRuntimeUserContextProperty;

        /// <summary>Serverless runtime user context properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties ServerlessRuntimeUserContextProperty { get => (this._serverlessRuntimeUserContextProperty = this._serverlessRuntimeUserContextProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextProperties()); set => this._serverlessRuntimeUserContextProperty = value; }

        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessRuntimeUserContextPropertyUserContextToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesInternal)ServerlessRuntimeUserContextProperty).UserContextToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesInternal)ServerlessRuntimeUserContextProperty).UserContextToken = value ?? null; }

        /// <summary>Backing field for <see cref="SupplementaryFileLocation" /> property.</summary>
        private string _supplementaryFileLocation;

        /// <summary>Supplementary file location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string SupplementaryFileLocation { get => this._supplementaryFileLocation; set => this._supplementaryFileLocation = value; }

        /// <summary>Creates an new <see cref="InformaticaServerlessRuntimeProperties" /> instance.</summary>
        public InformaticaServerlessRuntimeProperties()
        {

        }
    }
    /// Serverless Runtime properties.
    public partial interface IInformaticaServerlessRuntimeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String KV pairs indicating Advanced custom properties.",
        SerializedName = @"advancedCustomProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get; set; }
        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Application type of the Serverless Runtime environment.",
        SerializedName = @"applicationType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("CDI", "CDIE")]
        string ApplicationType { get; set; }
        /// <summary>Compute units of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Compute units of the serverless runtime.",
        SerializedName = @"computeUnits",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeUnit { get; set; }
        /// <summary>description of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"description of the serverless runtime.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Serverless Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Execution timeout",
        SerializedName = @"executionTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string ExecutionTimeout { get; set; }
        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network subnet resource id",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationSubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource id",
        SerializedName = @"vnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationVnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual network resource guid",
        SerializedName = @"vnetResourceGuid",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceConfigurationVnetResourceGuid { get; set; }
        /// <summary>Platform type of the Serverless Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Platform type of the Serverless Runtime.",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string Platform { get; set; }
        /// <summary>Provisioning State of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get;  }
        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless account creation location",
        SerializedName = @"serverlessAccountLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessAccountLocation { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The List of Informatica Serverless Runtime CDI Config Properties.",
        SerializedName = @"cdiConfigProps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The List of Informatica Serverless Runtime CDIE Config Properties.",
        SerializedName = @"cdieConfigProps",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get; set; }
        /// <summary>Serverless Runtime Tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Runtime Tags",
        SerializedName = @"serverlessRuntimeTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get; set; }
        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User context token for OBO flow.",
        SerializedName = @"userContextToken",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessRuntimeUserContextPropertyUserContextToken { get; set; }
        /// <summary>Supplementary file location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supplementary file location.",
        SerializedName = @"supplementaryFileLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SupplementaryFileLocation { get; set; }

    }
    /// Serverless Runtime properties.
    internal partial interface IInformaticaServerlessRuntimePropertiesInternal

    {
        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get; set; }
        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("CDI", "CDIE")]
        string ApplicationType { get; set; }
        /// <summary>Compute units of the serverless runtime.</summary>
        string ComputeUnit { get; set; }
        /// <summary>description of the serverless runtime.</summary>
        string Description { get; set; }
        /// <summary>Serverless Execution timeout</summary>
        string ExecutionTimeout { get; set; }
        /// <summary>Virtual network subnet resource id</summary>
        string NetworkInterfaceConfigurationSubnetId { get; set; }
        /// <summary>Virtual network resource id</summary>
        string NetworkInterfaceConfigurationVnetId { get; set; }
        /// <summary>Virtual network resource guid</summary>
        string NetworkInterfaceConfigurationVnetResourceGuid { get; set; }
        /// <summary>Platform type of the Serverless Runtime.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string Platform { get; set; }
        /// <summary>Provisioning State of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Deleting", "Succeeded", "Failed", "Canceled", "Deleted", "NotSpecified")]
        string ProvisioningState { get; set; }
        /// <summary>Serverless account creation location</summary>
        string ServerlessAccountLocation { get; set; }
        /// <summary>Serverless config properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties ServerlessRuntimeConfig { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get; set; }
        /// <summary>Informatica Serverless Network profile properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfile ServerlessRuntimeNetworkProfile { get; set; }
        /// <summary>Network Interface Configuration Profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfiguration ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get; set; }
        /// <summary>Serverless Runtime Tags</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get; set; }
        /// <summary>Serverless runtime user context properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextProperties ServerlessRuntimeUserContextProperty { get; set; }
        /// <summary>User context token for OBO flow.</summary>
        string ServerlessRuntimeUserContextPropertyUserContextToken { get; set; }
        /// <summary>Supplementary file location.</summary>
        string SupplementaryFileLocation { get; set; }

    }
}