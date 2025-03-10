// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Metadata Serverless Config Properties</summary>
    public partial class ServerlessConfigProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApplicationType" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> _applicationType;

        /// <summary>List of application types supported by informatica</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> ApplicationType { get => this._applicationType; set => this._applicationType = value; }

        /// <summary>Backing field for <see cref="ComputeUnit" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> _computeUnit;

        /// <summary>The list of compute units with possible array of values</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> ComputeUnit { get => this._computeUnit; set => this._computeUnit = value; }

        /// <summary>Backing field for <see cref="ExecutionTimeout" /> property.</summary>
        private string _executionTimeout;

        /// <summary>Serverless Runtime execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ExecutionTimeout { get => this._executionTimeout; set => this._executionTimeout = value; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private string _platform;

        /// <summary>Platform types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> _region;

        /// <summary>List of supported serverless informatica regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> Region { get => this._region; set => this._region = value; }

        /// <summary>Creates an new <see cref="ServerlessConfigProperties" /> instance.</summary>
        public ServerlessConfigProperties()
        {

        }
    }
    /// Metadata Serverless Config Properties
    public partial interface IServerlessConfigProperties :
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> ApplicationType { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> ComputeUnit { get; set; }
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
        string ExecutionTimeout { get; set; }
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
        string Platform { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> Region { get; set; }

    }
    /// Metadata Serverless Config Properties
    internal partial interface IServerlessConfigPropertiesInternal

    {
        /// <summary>List of application types supported by informatica</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata> ApplicationType { get; set; }
        /// <summary>The list of compute units with possible array of values</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata> ComputeUnit { get; set; }
        /// <summary>Serverless Runtime execution timeout</summary>
        string ExecutionTimeout { get; set; }
        /// <summary>Platform types</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Informatica.PSArgumentCompleterAttribute("AZURE")]
        string Platform { get; set; }
        /// <summary>List of supported serverless informatica regions</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata> Region { get; set; }

    }
}