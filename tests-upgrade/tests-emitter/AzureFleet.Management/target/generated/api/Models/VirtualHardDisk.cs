// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes the uri of a disk.</summary>
    public partial class VirtualHardDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDiskInternal
    {

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>Specifies the virtual hard disk's uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="VirtualHardDisk" /> instance.</summary>
        public VirtualHardDisk()
        {

        }
    }
    /// Describes the uri of a disk.
    public partial interface IVirtualHardDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the virtual hard disk's uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the virtual hard disk's uri.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Describes the uri of a disk.
    internal partial interface IVirtualHardDiskInternal

    {
        /// <summary>Specifies the virtual hard disk's uri.</summary>
        string Uri { get; set; }

    }
}