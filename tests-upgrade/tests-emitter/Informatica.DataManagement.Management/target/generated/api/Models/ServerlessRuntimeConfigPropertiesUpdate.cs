// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>The template for adding optional properties.</summary>
    public partial class ServerlessRuntimeConfigPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigPropertiesUpdateInternal
    {

        /// <summary>Backing field for <see cref="CdiConfigProp" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> _cdiConfigProp;

        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> CdiConfigProp { get => this._cdiConfigProp; set => this._cdiConfigProp = value; }

        /// <summary>Backing field for <see cref="CdieConfigProp" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> _cdieConfigProp;

        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> CdieConfigProp { get => this._cdieConfigProp; set => this._cdieConfigProp = value; }

        /// <summary>Creates an new <see cref="ServerlessRuntimeConfigPropertiesUpdate" /> instance.</summary>
        public ServerlessRuntimeConfigPropertiesUpdate()
        {

        }
    }
    /// The template for adding optional properties.
    public partial interface IServerlessRuntimeConfigPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> CdiConfigProp { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> CdieConfigProp { get; set; }

    }
    /// The template for adding optional properties.
    internal partial interface IServerlessRuntimeConfigPropertiesUpdateInternal

    {
        /// <summary>The List of Informatica Serverless Runtime CDI Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> CdiConfigProp { get; set; }
        /// <summary>The List of Informatica Serverless Runtime CDIE Config Properties.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps> CdieConfigProp { get; set; }

    }
}