// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>The template for adding optional properties.</summary>
    public partial class InformaticaServerlessRuntimeResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdateInternal
    {

        /// <summary>String KV pairs indicating Advanced custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties> AdvancedCustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).AdvancedCustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).AdvancedCustomProperty = value ?? null /* arrayOf */; }

        /// <summary>Application type of the Serverless Runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ApplicationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ApplicationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ApplicationType = value ?? null; }

        /// <summary>Compute units of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ComputeUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ComputeUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ComputeUnit = value ?? null; }

        /// <summary>description of the serverless runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).Description = value ?? null; }

        /// <summary>Serverless Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ExecutionTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ExecutionTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ExecutionTimeout = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimePropertiesCustomUpdate()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ServerlessRuntimeConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdateInternal.ServerlessRuntimeConfig { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeConfig; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeConfig = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ServerlessRuntimeNetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeNetworkProfileUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdateInternal.ServerlessRuntimeNetworkProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeNetworkProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeNetworkProfile = value ?? null /* model class */; }

        /// <summary>
        /// Internal Acessors for ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.INetworkInterfaceConfigurationUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdateInternal.ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeNetworkProfileNetworkInterfaceConfiguration = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ServerlessRuntimeUserContextProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeUserContextPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceUpdateInternal.ServerlessRuntimeUserContextProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeUserContextProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeUserContextProperty = value ?? null /* model class */; }

        /// <summary>Virtual network subnet resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).NetworkInterfaceConfigurationSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).NetworkInterfaceConfigurationSubnetId = value ?? null; }

        /// <summary>Virtual network resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).NetworkInterfaceConfigurationVnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).NetworkInterfaceConfigurationVnetId = value ?? null; }

        /// <summary>Virtual network resource guid</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string NetworkInterfaceConfigurationVnetResourceGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).NetworkInterfaceConfigurationVnetResourceGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).NetworkInterfaceConfigurationVnetResourceGuid = value ?? null; }

        /// <summary>Platform type of the Serverless Runtime.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string Platform { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).Platform; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).Platform = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate _property;

        /// <summary>
        /// Patchable PropertieInformaticaOrganizationPropertiesUpdates of the Organization observability resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimePropertiesCustomUpdate()); set => this._property = value; }

        /// <summary>Serverless account creation location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessAccountLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessAccountLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessAccountLocation = value ?? null; }

        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdiConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeConfigCdiConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeConfigCdiConfigProp = value ?? null /* arrayOf */; }

        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigCdieConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeConfigCdieConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeConfigCdieConfigProp = value ?? null /* arrayOf */; }

        /// <summary>Serverless Runtime Tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag> ServerlessRuntimeTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeTag = value ?? null /* arrayOf */; }

        /// <summary>User context token for OBO flow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessRuntimeUserContextPropertyUserContextToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeUserContextPropertyUserContextToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).ServerlessRuntimeUserContextPropertyUserContextToken = value ?? null; }

        /// <summary>Supplementary file location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string SupplementaryFileLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).SupplementaryFileLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdateInternal)Property).SupplementaryFileLocation = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="InformaticaServerlessRuntimeResourceUpdate" /> instance.
        /// </summary>
        public InformaticaServerlessRuntimeResourceUpdate()
        {

        }
    }
    /// The template for adding optional properties.
    public partial interface IInformaticaServerlessRuntimeResourceUpdate :
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
    /// The template for adding optional properties.
    internal partial interface IInformaticaServerlessRuntimeResourceUpdateInternal

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
        /// <summary>
        /// Patchable PropertieInformaticaOrganizationPropertiesUpdates of the Organization observability resource
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate Property { get; set; }
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