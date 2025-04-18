// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Contains the IP tag associated with the public IP address.</summary>
    public partial class VirtualMachineScaleSetIPTag :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTagInternal
    {

        /// <summary>Backing field for <see cref="IPTagType" /> property.</summary>
        private string _iPTagType;

        /// <summary>IP tag type. Example: FirstPartyUsage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string IPTagType { get => this._iPTagType; set => this._iPTagType = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string _tag;

        /// <summary>IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetIPTag" /> instance.</summary>
        public VirtualMachineScaleSetIPTag()
        {

        }
    }
    /// Contains the IP tag associated with the public IP address.
    public partial interface IVirtualMachineScaleSetIPTag :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>IP tag type. Example: FirstPartyUsage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP tag type. Example: FirstPartyUsage.",
        SerializedName = @"ipTagType",
        PossibleTypes = new [] { typeof(string) })]
        string IPTagType { get; set; }
        /// <summary>IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP tag associated with the public IP. Example: SQL, Storage etc.",
        SerializedName = @"tag",
        PossibleTypes = new [] { typeof(string) })]
        string Tag { get; set; }

    }
    /// Contains the IP tag associated with the public IP address.
    internal partial interface IVirtualMachineScaleSetIPTagInternal

    {
        /// <summary>IP tag type. Example: FirstPartyUsage.</summary>
        string IPTagType { get; set; }
        /// <summary>IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
        string Tag { get; set; }

    }
}