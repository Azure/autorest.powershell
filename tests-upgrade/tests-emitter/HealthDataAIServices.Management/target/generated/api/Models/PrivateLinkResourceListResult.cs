// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Extensions;

    /// <summary>The response of a PrivateLinkResource list operation.</summary>
    public partial class PrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResource> _value;

        /// <summary>The PrivateLinkResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceListResult" /> instance.</summary>
        public PrivateLinkResourceListResult()
        {

        }
    }
    /// The response of a PrivateLinkResource list operation.
    public partial interface IPrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The PrivateLinkResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The PrivateLinkResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResource> Value { get; set; }

    }
    /// The response of a PrivateLinkResource list operation.
    internal partial interface IPrivateLinkResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The PrivateLinkResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.HealthDataAIServices.Models.IPrivateLinkResource> Value { get; set; }

    }
}