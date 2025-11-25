// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The available skus operation response.</summary>
    public partial class AvailableSkusResult :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAvailableSkusResult,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAvailableSkusResultInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAvailableSkusResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>[Placeholder] Description for nextLink property</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation> _value;

        /// <summary>[Placeholder] Description for page model</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation> Value { get => this._value; }

        /// <summary>Creates an new <see cref="AvailableSkusResult" /> instance.</summary>
        public AvailableSkusResult()
        {

        }
    }
    /// The available skus operation response.
    public partial interface IAvailableSkusResult :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>[Placeholder] Description for nextLink property</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"[Placeholder] Description for nextLink property",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>[Placeholder] Description for page model</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"[Placeholder] Description for page model",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation> Value { get;  }

    }
    /// The available skus operation response.
    internal partial interface IAvailableSkusResultInternal

    {
        /// <summary>[Placeholder] Description for nextLink property</summary>
        string NextLink { get; set; }
        /// <summary>[Placeholder] Description for page model</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation> Value { get; set; }

    }
}