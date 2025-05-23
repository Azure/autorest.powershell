// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Patchable Properties of the Informatica Serverless Runtime resource</summary>
    public partial class ServerlessRuntimePropertiesCustomUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal
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

        /// <summary>Internal Acessors for ServerlessRuntimeConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal.ServerlessRuntimeConfig { get => (this._serverlessRuntimeConfig = this._serverlessRuntimeConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesUpdate()); set { {_serverlessRuntimeConfig = value;} } }

        /// <summary>Internal Acessors for ServerlessRuntimeNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal.ServerlessRuntimeNetworkProfile { get => (this._serverlessRuntimeNetworkProfile = this._serverlessRuntimeNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfileUpdate()); set { {_serverlessRuntimeNetworkProfile = value;} } }

        /// <summary>
        /// Internal Acessors for ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal.ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ServerlessRuntimeUserContextProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal.ServerlessRuntimeUserContextProperty { get => (this._serverlessRuntimeUserContextProperty = this._serverlessRuntimeUserContextProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextPropertiesUpdate()); set { {_serverlessRuntimeUserContextProperty = value;} } }

        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationSubnetId = value ?? null; }

        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetId = value ?? null; }

        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdateInternal)ServerlessRuntimeNetworkProfile).NetworkInterfaceConfigurationVnetResourceGuid = value ?? null; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private string _platform;

        /// <summary>Platform type of the Serverless Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="ServerlessAccountLocation" /> property.</summary>
        private string _serverlessAccountLocation;

        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ServerlessAccountLocation { get => this._serverlessAccountLocation; set => this._serverlessAccountLocation = value; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate _serverlessRuntimeConfig;

        /// <summary>Serverless config properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate ServerlessRuntimeConfig { get => (this._serverlessRuntimeConfig = this._serverlessRuntimeConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesUpdate()); set => this._serverlessRuntimeConfig = value; }

        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdateInternal)ServerlessRuntimeConfig).CdiConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdateInternal)ServerlessRuntimeConfig).CdiConfigProp = value ?? null /* arrayOf */; }

        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdateInternal)ServerlessRuntimeConfig).CdieConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdateInternal)ServerlessRuntimeConfig).CdieConfigProp = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeNetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdate _serverlessRuntimeNetworkProfile;

        /// <summary>Informatica Serverless Network profile properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdate ServerlessRuntimeNetworkProfile { get => (this._serverlessRuntimeNetworkProfile = this._serverlessRuntimeNetworkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfileUpdate()); set => this._serverlessRuntimeNetworkProfile = value; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeTag" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> _serverlessRuntimeTag;

        /// <summary>Serverless Runtime Tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get => this._serverlessRuntimeTag; set => this._serverlessRuntimeTag = value; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeUserContextProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdate _serverlessRuntimeUserContextProperty;

        /// <summary>Serverless runtime user context properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdate ServerlessRuntimeUserContextProperty { get => (this._serverlessRuntimeUserContextProperty = this._serverlessRuntimeUserContextProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextPropertiesUpdate()); set => this._serverlessRuntimeUserContextProperty = value; }

        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessRuntimeUserContextPropertyUserContextToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdateInternal)ServerlessRuntimeUserContextProperty).UserContextToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdateInternal)ServerlessRuntimeUserContextProperty).UserContextToken = value ?? null; }

        /// <summary>Backing field for <see cref="SupplementaryFileLocation" /> property.</summary>
        private string _supplementaryFileLocation;

        /// <summary>Supplementary file location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string SupplementaryFileLocation { get => this._supplementaryFileLocation; set => this._supplementaryFileLocation = value; }

        /// <summary>Creates an new <see cref="ServerlessRuntimePropertiesCustomUpdate" /> instance.</summary>
        public ServerlessRuntimePropertiesCustomUpdate()
        {

        }
    }
    /// Patchable Properties of the Informatica Serverless Runtime resource
    public partial interface IServerlessRuntimePropertiesCustomUpdate :
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
        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
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
    /// Patchable Properties of the Informatica Serverless Runtime resource
    internal partial interface IServerlessRuntimePropertiesCustomUpdateInternal

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
        /// <summary>Serverless account creation location</summary>
        string ServerlessAccountLocation { get; set; }
        /// <summary>Serverless config properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate ServerlessRuntimeConfig { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get; set; }
        /// <summary>Informatica Serverless Network profile properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdate ServerlessRuntimeNetworkProfile { get; set; }
        /// <summary>Network Interface Configuration Profile Update</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get; set; }
        /// <summary>Serverless Runtime Tags</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get; set; }
        /// <summary>Serverless runtime user context properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdate ServerlessRuntimeUserContextProperty { get; set; }
        /// <summary>User context token for OBO flow.</summary>
        string ServerlessRuntimeUserContextPropertyUserContextToken { get; set; }
        /// <summary>Supplementary file location.</summary>
        string SupplementaryFileLocation { get; set; }

    }
}