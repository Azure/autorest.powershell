// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The response of a ResourceDetailsObject list operation.</summary>
    public partial class ResourceDetailsObjectListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObjectListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObject> _value;

        /// <summary>The ResourceDetailsObject items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObject> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceDetailsObjectListResult" /> instance.</summary>
        public ResourceDetailsObjectListResult()
        {

        }
    }
    /// The response of a ResourceDetailsObject list operation.
    public partial interface IResourceDetailsObjectListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ResourceDetailsObject items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ResourceDetailsObject items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObject) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObject> Value { get; set; }

    }
    /// The response of a ResourceDetailsObject list operation.
    internal partial interface IResourceDetailsObjectListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ResourceDetailsObject items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceDetailsObject> Value { get; set; }

    }
}