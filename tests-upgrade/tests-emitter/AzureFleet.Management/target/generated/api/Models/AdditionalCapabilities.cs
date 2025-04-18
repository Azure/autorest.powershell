// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>AdditionalCapabilities for VM.</summary>
    public partial class AdditionalCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilities,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IAdditionalCapabilitiesInternal
    {

        /// <summary>Backing field for <see cref="HibernationEnabled" /> property.</summary>
        private bool? _hibernationEnabled;

        /// <summary>The flag that enables or disables hibernation capability on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? HibernationEnabled { get => this._hibernationEnabled; set => this._hibernationEnabled = value; }

        /// <summary>Backing field for <see cref="UltraSsdEnabled" /> property.</summary>
        private bool? _ultraSsdEnabled;

        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account
        /// type on the VM or VMSS.
        /// Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only
        /// if this property is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? UltraSsdEnabled { get => this._ultraSsdEnabled; set => this._ultraSsdEnabled = value; }

        /// <summary>Creates an new <see cref="AdditionalCapabilities" /> instance.</summary>
        public AdditionalCapabilities()
        {

        }
    }
    /// AdditionalCapabilities for VM.
    public partial interface IAdditionalCapabilities :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>The flag that enables or disables hibernation capability on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The flag that enables or disables hibernation capability on the VM.",
        SerializedName = @"hibernationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HibernationEnabled { get; set; }
        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account
        /// type on the VM or VMSS.
        /// Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only
        /// if this property is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS.
        Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled.",
        SerializedName = @"ultraSSDEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UltraSsdEnabled { get; set; }

    }
    /// AdditionalCapabilities for VM.
    internal partial interface IAdditionalCapabilitiesInternal

    {
        /// <summary>The flag that enables or disables hibernation capability on the VM.</summary>
        bool? HibernationEnabled { get; set; }
        /// <summary>
        /// The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account
        /// type on the VM or VMSS.
        /// Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only
        /// if this property is enabled.
        /// </summary>
        bool? UltraSsdEnabled { get; set; }

    }
}