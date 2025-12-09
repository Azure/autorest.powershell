// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Base for all lists of resources.</summary>
    public partial class ResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI to fetch the next page of resources, with each API call returning up to 200 resources per page. Use ListNext()
        /// to fetch the next page if the total number of resources exceeds 200.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Creates an new <see cref="ResourceList" /> instance.</summary>
        public ResourceList()
        {

        }
    }
    /// Base for all lists of resources.
    public partial interface IResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The URI to fetch the next page of resources, with each API call returning up to 200 resources per page. Use ListNext()
        /// to fetch the next page if the total number of resources exceeds 200.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URI to fetch the next page of resources, with each API call returning up to 200 resources per page. Use ListNext() to fetch the next page if the total number of resources exceeds 200.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

    }
    /// Base for all lists of resources.
    internal partial interface IResourceListInternal

    {
        /// <summary>
        /// The URI to fetch the next page of resources, with each API call returning up to 200 resources per page. Use ListNext()
        /// to fetch the next page if the total number of resources exceeds 200.
        /// </summary>
        string NextLink { get; set; }

    }
}