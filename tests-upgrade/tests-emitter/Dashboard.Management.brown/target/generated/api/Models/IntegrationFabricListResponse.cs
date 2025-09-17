// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Paged collection of IntegrationFabric items</summary>
    public partial class IntegrationFabricListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabricListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabric> _value;

        /// <summary>The IntegrationFabric items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabric> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="IntegrationFabricListResponse" /> instance.</summary>
        public IntegrationFabricListResponse()
        {

        }
    }
    /// Paged collection of IntegrationFabric items
    public partial interface IIntegrationFabricListResponse :
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
        /// <summary>The IntegrationFabric items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The IntegrationFabric items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabric) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabric> Value { get; set; }

    }
    /// Paged collection of IntegrationFabric items
    internal partial interface IIntegrationFabricListResponseInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The IntegrationFabric items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IIntegrationFabric> Value { get; set; }

    }
}