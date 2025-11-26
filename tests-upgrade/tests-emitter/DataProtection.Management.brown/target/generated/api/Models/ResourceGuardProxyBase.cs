// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>ResourceGuardProxyBase object, used in ResourceGuardProxyBaseResource</summary>
    public partial class ResourceGuardProxyBase :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardProxyBase,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardProxyBaseInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private string _lastUpdatedTime;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string LastUpdatedTime { get => this._lastUpdatedTime; set => this._lastUpdatedTime = value; }

        /// <summary>Backing field for <see cref="ResourceGuardOperationDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardOperationDetail> _resourceGuardOperationDetail;

        /// <summary>Array of ResourceGuardOperationDetail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardOperationDetail> ResourceGuardOperationDetail { get => this._resourceGuardOperationDetail; set => this._resourceGuardOperationDetail = value; }

        /// <summary>Backing field for <see cref="ResourceGuardResourceId" /> property.</summary>
        private string _resourceGuardResourceId;

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public string ResourceGuardResourceId { get => this._resourceGuardResourceId; set => this._resourceGuardResourceId = value; }

        /// <summary>Creates an new <see cref="ResourceGuardProxyBase" /> instance.</summary>
        public ResourceGuardProxyBase()
        {

        }
    }
    /// ResourceGuardProxyBase object, used in ResourceGuardProxyBaseResource
    public partial interface IResourceGuardProxyBase :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTime { get; set; }
        /// <summary>Array of ResourceGuardOperationDetail</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of ResourceGuardOperationDetail",
        SerializedName = @"resourceGuardOperationDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardOperationDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardOperationDetail> ResourceGuardOperationDetail { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"resourceGuardResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGuardResourceId { get; set; }

    }
    /// ResourceGuardProxyBase object, used in ResourceGuardProxyBaseResource
    internal partial interface IResourceGuardProxyBaseInternal

    {
        string Description { get; set; }

        string LastUpdatedTime { get; set; }
        /// <summary>Array of ResourceGuardOperationDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.IResourceGuardOperationDetail> ResourceGuardOperationDetail { get; set; }

        string ResourceGuardResourceId { get; set; }

    }
}