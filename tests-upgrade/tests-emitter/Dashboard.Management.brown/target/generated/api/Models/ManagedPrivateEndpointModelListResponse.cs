// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The list of managed private endpoints of a grafana resource</summary>
    public partial class ManagedPrivateEndpointModelListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModelListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel> _value;

        /// <summary>The ManagedPrivateEndpointModel items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ManagedPrivateEndpointModelListResponse" /> instance.</summary>
        public ManagedPrivateEndpointModelListResponse()
        {

        }
    }
    /// The list of managed private endpoints of a grafana resource
    public partial interface IManagedPrivateEndpointModelListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ManagedPrivateEndpointModel items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ManagedPrivateEndpointModel items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel> Value { get; set; }

    }
    /// The list of managed private endpoints of a grafana resource
    internal partial interface IManagedPrivateEndpointModelListResponseInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ManagedPrivateEndpointModel items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointModel> Value { get; set; }

    }
}