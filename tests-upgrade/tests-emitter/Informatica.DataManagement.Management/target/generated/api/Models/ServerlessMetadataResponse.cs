// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Serverless Runtime environment Metadata response.</summary>
    public partial class ServerlessMetadataResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal
    {

        /// <summary>Internal Acessors for ServerlessConfigProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal.ServerlessConfigProperty { get => (this._serverlessConfigProperty = this._serverlessConfigProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessConfigProperties()); set { {_serverlessConfigProperty = value;} } }

        /// <summary>Internal Acessors for ServerlessRuntimeConfigProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal.ServerlessRuntimeConfigProperty { get => (this._serverlessRuntimeConfigProperty = this._serverlessRuntimeConfigProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigProperties()); set { {_serverlessRuntimeConfigProperty = value;} } }

        /// <summary>Backing field for <see cref="ServerlessConfigProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties _serverlessConfigProperty;

        /// <summary>serverless config properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties ServerlessConfigProperty { get => (this._serverlessConfigProperty = this._serverlessConfigProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessConfigProperties()); set => this._serverlessConfigProperty = value; }

        /// <summary>List of application types supported by informatica</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> ServerlessConfigPropertyApplicationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).ApplicationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).ApplicationType = value ?? null /* arrayOf */; }

        /// <summary>The list of compute units with possible array of values</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> ServerlessConfigPropertyComputeUnit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).ComputeUnit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).ComputeUnit = value ?? null /* arrayOf */; }

        /// <summary>Serverless Runtime execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyExecutionTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).ExecutionTimeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).ExecutionTimeout = value ?? null; }

        /// <summary>Platform types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public string ServerlessConfigPropertyPlatform { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).Platform; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).Platform = value ?? null; }

        /// <summary>List of supported serverless informatica regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> ServerlessConfigPropertyRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).Region; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal)ServerlessConfigProperty).Region = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ServerlessRuntimeConfigProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties _serverlessRuntimeConfigProperty;

        /// <summary>serverless runtime config properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties ServerlessRuntimeConfigProperty { get => (this._serverlessRuntimeConfigProperty = this._serverlessRuntimeConfigProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigProperties()); set => this._serverlessRuntimeConfigProperty = value; }

        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigPropertyCdiConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfigProperty).CdiConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfigProperty).CdiConfigProp = value ?? null /* arrayOf */; }

        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigPropertyCdieConfigProp { get => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfigProperty).CdieConfigProp; set => ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesInternal)ServerlessRuntimeConfigProperty).CdieConfigProp = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>type of the runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ServerlessMetadataResponse" /> instance.</summary>
        public ServerlessMetadataResponse()
        {

        }
    }
    /// Serverless Runtime environment Metadata response.
    public partial interface IServerlessMetadataResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>List of application types supported by informatica</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of application types supported by informatica",
        SerializedName = @"applicationTypes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> ServerlessConfigPropertyApplicationType { get; set; }
        /// <summary>The list of compute units with possible array of values</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of compute units with possible array of values",
        SerializedName = @"computeUnits",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> ServerlessConfigPropertyComputeUnit { get; set; }
        /// <summary>Serverless Runtime execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Runtime execution timeout",
        SerializedName = @"executionTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessConfigPropertyExecutionTimeout { get; set; }
        /// <summary>Platform types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Platform types",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string ServerlessConfigPropertyPlatform { get; set; }
        /// <summary>List of supported serverless informatica regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of supported serverless informatica regions",
        SerializedName = @"regions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> ServerlessConfigPropertyRegion { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigPropertyCdiConfigProp { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigPropertyCdieConfigProp { get; set; }
        /// <summary>type of the runtime environment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"type of the runtime environment.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("SERVERLESS")]
        string Type { get; set; }

    }
    /// Serverless Runtime environment Metadata response.
    internal partial interface IServerlessMetadataResponseInternal

    {
        /// <summary>serverless config properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties ServerlessConfigProperty { get; set; }
        /// <summary>List of application types supported by informatica</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> ServerlessConfigPropertyApplicationType { get; set; }
        /// <summary>The list of compute units with possible array of values</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> ServerlessConfigPropertyComputeUnit { get; set; }
        /// <summary>Serverless Runtime execution timeout</summary>
        string ServerlessConfigPropertyExecutionTimeout { get; set; }
        /// <summary>Platform types</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string ServerlessConfigPropertyPlatform { get; set; }
        /// <summary>List of supported serverless informatica regions</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> ServerlessConfigPropertyRegion { get; set; }
        /// <summary>serverless runtime config properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties ServerlessRuntimeConfigProperty { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigPropertyCdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> ServerlessRuntimeConfigPropertyCdieConfigProp { get; set; }
        /// <summary>type of the runtime environment.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("SERVERLESS")]
        string Type { get; set; }

    }
}