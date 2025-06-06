// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the asset endpoint profile status error properties.</summary>
    public partial class AssetEndpointProfileStatusError :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusError,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private int? _code;

        /// <summary>Error code for classification of errors (ex: 400, 404, 500, etc.).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public int? Code { get => this._code; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>
        /// Human readable helpful error message to provide additional context for error (ex: “targetAddress 'foo' is not a valid
        /// url”).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusErrorInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetEndpointProfileStatusErrorInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="AssetEndpointProfileStatusError" /> instance.</summary>
        public AssetEndpointProfileStatusError()
        {

        }
    }
    /// Defines the asset endpoint profile status error properties.
    public partial interface IAssetEndpointProfileStatusError :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Error code for classification of errors (ex: 400, 404, 500, etc.).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code for classification of errors (ex: 400, 404, 500, etc.).",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(int) })]
        int? Code { get;  }
        /// <summary>
        /// Human readable helpful error message to provide additional context for error (ex: “targetAddress 'foo' is not a valid
        /// url”).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Human readable helpful error message to provide additional context for error (ex: “targetAddress 'foo' is not a valid url”).",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Defines the asset endpoint profile status error properties.
    internal partial interface IAssetEndpointProfileStatusErrorInternal

    {
        /// <summary>Error code for classification of errors (ex: 400, 404, 500, etc.).</summary>
        int? Code { get; set; }
        /// <summary>
        /// Human readable helpful error message to provide additional context for error (ex: “targetAddress 'foo' is not a valid
        /// url”).
        /// </summary>
        string Message { get; set; }

    }
}