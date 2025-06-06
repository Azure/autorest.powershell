// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Informatica CDI Configuration Properties.</summary>
    public partial class CdiConfigProps :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigPropsInternal
    {

        /// <summary>Backing field for <see cref="ApplicationConfig" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationConfigs> _applicationConfig;

        /// <summary>ApplicationConfigs of the CDI or CDIE.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationConfigs> ApplicationConfig { get => this._applicationConfig; set => this._applicationConfig = value; }

        /// <summary>Backing field for <see cref="EngineName" /> property.</summary>
        private string _engineName;

        /// <summary>EngineName of the application config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string EngineName { get => this._engineName; set => this._engineName = value; }

        /// <summary>Backing field for <see cref="EngineVersion" /> property.</summary>
        private string _engineVersion;

        /// <summary>EngineVersion of the application config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string EngineVersion { get => this._engineVersion; set => this._engineVersion = value; }

        /// <summary>Creates an new <see cref="CdiConfigProps" /> instance.</summary>
        public CdiConfigProps()
        {

        }
    }
    /// Informatica CDI Configuration Properties.
    public partial interface ICdiConfigProps :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>ApplicationConfigs of the CDI or CDIE.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ApplicationConfigs of the CDI or CDIE.",
        SerializedName = @"applicationConfigs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationConfigs) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationConfigs> ApplicationConfig { get; set; }
        /// <summary>EngineName of the application config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"EngineName of the application config.",
        SerializedName = @"engineName",
        PossibleTypes = new [] { typeof(string) })]
        string EngineName { get; set; }
        /// <summary>EngineVersion of the application config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"EngineVersion of the application config.",
        SerializedName = @"engineVersion",
        PossibleTypes = new [] { typeof(string) })]
        string EngineVersion { get; set; }

    }
    /// Informatica CDI Configuration Properties.
    internal partial interface ICdiConfigPropsInternal

    {
        /// <summary>ApplicationConfigs of the CDI or CDIE.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationConfigs> ApplicationConfig { get; set; }
        /// <summary>EngineName of the application config.</summary>
        string EngineName { get; set; }
        /// <summary>EngineVersion of the application config.</summary>
        string EngineVersion { get; set; }

    }
}