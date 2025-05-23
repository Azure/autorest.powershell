// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Request of the action to list device groups for a catalog.</summary>
    public partial class ListDeviceGroupsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IListDeviceGroupsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IListDeviceGroupsRequestInternal
    {

        /// <summary>Backing field for <see cref="DeviceGroupName" /> property.</summary>
        private string _deviceGroupName;

        /// <summary>Device Group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public string DeviceGroupName { get => this._deviceGroupName; set => this._deviceGroupName = value; }

        /// <summary>Creates an new <see cref="ListDeviceGroupsRequest" /> instance.</summary>
        public ListDeviceGroupsRequest()
        {

        }
    }
    /// Request of the action to list device groups for a catalog.
    public partial interface IListDeviceGroupsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>Device Group name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device Group name.",
        SerializedName = @"deviceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceGroupName { get; set; }

    }
    /// Request of the action to list device groups for a catalog.
    internal partial interface IListDeviceGroupsRequestInternal

    {
        /// <summary>Device Group name.</summary>
        string DeviceGroupName { get; set; }

    }
}