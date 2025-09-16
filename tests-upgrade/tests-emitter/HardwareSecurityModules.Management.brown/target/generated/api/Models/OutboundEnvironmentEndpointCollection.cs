// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>Collection of OutboundEnvironmentEndpoint</summary>
    public partial class OutboundEnvironmentEndpointCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollection,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpointCollectionInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpoint> _value;

        /// <summary>The OutboundEnvironmentEndpoint items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpoint> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OutboundEnvironmentEndpointCollection" /> instance.</summary>
        public OutboundEnvironmentEndpointCollection()
        {

        }
    }
    /// Collection of OutboundEnvironmentEndpoint
    public partial interface IOutboundEnvironmentEndpointCollection :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The OutboundEnvironmentEndpoint items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The OutboundEnvironmentEndpoint items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpoint) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpoint> Value { get; set; }

    }
    /// Collection of OutboundEnvironmentEndpoint
    internal partial interface IOutboundEnvironmentEndpointCollectionInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The OutboundEnvironmentEndpoint items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IOutboundEnvironmentEndpoint> Value { get; set; }

    }
}