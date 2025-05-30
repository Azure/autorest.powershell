// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the asset status error properties.</summary>
    public partial class AssetStatusError :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusError,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusErrorInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private int? _code;

        /// <summary>Error code for classification of errors (ex: 400, 404, 500, etc.).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public int? Code { get => this._code; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>
        /// Human readable helpful error message to provide additional context for error (ex: “capability Id 'foo' does not exist”).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusErrorInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAssetStatusErrorInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="AssetStatusError" /> instance.</summary>
        public AssetStatusError()
        {

        }
    }
    /// Defines the asset status error properties.
    public partial interface IAssetStatusError :
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
        /// Human readable helpful error message to provide additional context for error (ex: “capability Id 'foo' does not exist”).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Human readable helpful error message to provide additional context for error (ex: “capability Id 'foo' does not exist”).",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Defines the asset status error properties.
    internal partial interface IAssetStatusErrorInternal

    {
        /// <summary>Error code for classification of errors (ex: 400, 404, 500, etc.).</summary>
        int? Code { get; set; }
        /// <summary>
        /// Human readable helpful error message to provide additional context for error (ex: “capability Id 'foo' does not exist”).
        /// </summary>
        string Message { get; set; }

    }
}