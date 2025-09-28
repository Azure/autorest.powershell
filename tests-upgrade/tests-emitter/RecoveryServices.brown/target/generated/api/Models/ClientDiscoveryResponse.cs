// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Paged collection of ClientDiscoveryValueForSingleApi items</summary>
    public partial class ClientDiscoveryResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryResponse,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApi> _value;

        /// <summary>The ClientDiscoveryValueForSingleApi items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApi> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ClientDiscoveryResponse" /> instance.</summary>
        public ClientDiscoveryResponse()
        {

        }
    }
    /// Paged collection of ClientDiscoveryValueForSingleApi items
    public partial interface IClientDiscoveryResponse :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ClientDiscoveryValueForSingleApi items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ClientDiscoveryValueForSingleApi items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApi) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApi> Value { get; set; }

    }
    /// Paged collection of ClientDiscoveryValueForSingleApi items
    internal partial interface IClientDiscoveryResponseInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ClientDiscoveryValueForSingleApi items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApi> Value { get; set; }

    }
}