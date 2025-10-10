// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>
    /// A container holding only the Tags for a resource, allowing the user to update the tags on a Provisioning Service instance.
    /// </summary>
    public partial class TagsResource :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResource,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResourceInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResourceTags _tag;

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.TagsResourceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="TagsResource" /> instance.</summary>
        public TagsResource()
        {

        }
    }
    /// A container holding only the Tags for a resource, allowing the user to update the tags on a Provisioning Service instance.
    public partial interface ITagsResource :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResourceTags Tag { get; set; }

    }
    /// A container holding only the Tags for a resource, allowing the user to update the tags on a Provisioning Service instance.
    internal partial interface ITagsResourceInternal

    {
        /// <summary>Resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ITagsResourceTags Tag { get; set; }

    }
}