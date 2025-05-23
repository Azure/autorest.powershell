// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set operating system disk.</summary>
    public partial class VirtualMachineScaleSetOSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal
    {

        /// <summary>Backing field for <see cref="Caching" /> property.</summary>
        private string _caching;

        /// <summary>
        /// Specifies the caching requirements. Possible values are: **None,**
        /// **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        /// storage. ReadOnly for Premium storage.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Caching { get => this._caching; set => this._caching = value; }

        /// <summary>Backing field for <see cref="CreateOption" /> property.</summary>
        private string _createOption;

        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created. The only
        /// allowed value is: **FromImage.** This value is used when you are using an image
        /// to create the virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a marketplace
        /// image, you also use the plan element previously described.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string CreateOption { get => this._createOption; set => this._createOption = value; }

        /// <summary>Backing field for <see cref="DeleteOption" /> property.</summary>
        private string _deleteOption;

        /// <summary>
        /// Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion
        /// (This feature is available for VMSS with Flexible OrchestrationMode only).
        /// <br><br> Possible values: <br><br> **Delete** If this value is used, the OS
        /// disk is deleted when VMSS Flex VM is deleted.<br><br> **Detach** If this value
        /// is used, the OS disk is retained after VMSS Flex VM is deleted. <br><br> The
        /// default value is set to **Delete**. For an Ephemeral OS Disk, the default value
        /// is set to **Delete**. User cannot change the delete option for Ephemeral OS
        /// Disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DeleteOption { get => this._deleteOption; set => this._deleteOption = value; }

        /// <summary>Backing field for <see cref="DiffDiskSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings _diffDiskSetting;

        /// <summary>
        /// Specifies the ephemeral disk Settings for the operating system disk used by the
        /// virtual machine scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings DiffDiskSetting { get => (this._diffDiskSetting = this._diffDiskSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiffDiskSettings()); set => this._diffDiskSetting = value; }

        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DiffDiskSettingOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettingsInternal)DiffDiskSetting).Option; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettingsInternal)DiffDiskSetting).Option = value ?? null; }

        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk. Possible
        /// values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        /// **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        /// is used. Refer to the VM size documentation for Windows VM at
        /// https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        /// https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        /// sizes exposes a cache disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DiffDiskSettingPlacement { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettingsInternal)DiffDiskSetting).Placement; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettingsInternal)DiffDiskSetting).Placement = value ?? null; }

        /// <summary>Backing field for <see cref="DiskSizeGb" /> property.</summary>
        private int? _diskSizeGb;

        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'
        /// is the number of bytes x 1024^3 for the disk and the value cannot
        /// be larger than 1023.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? DiskSizeGb { get => this._diskSizeGb; set => this._diskSizeGb = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).Id = value ?? null; }

        /// <summary>Backing field for <see cref="Image" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk _image;

        /// <summary>Specifies information about the unmanaged user image to base the scale set on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk Image { get => (this._image = this._image ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualHardDisk()); set => this._image = value; }

        /// <summary>Specifies the virtual hard disk's uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDiskInternal)Image).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDiskInternal)Image).Uri = value ?? null; }

        /// <summary>Backing field for <see cref="ManagedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters _managedDisk;

        /// <summary>The managed disk parameters.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters ManagedDisk { get => (this._managedDisk = this._managedDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParameters()); set => this._managedDisk = value; }

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        /// only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ManagedDiskStorageAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).StorageAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).StorageAccountType = value ?? null; }

        /// <summary>Internal Acessors for DiffDiskSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal.DiffDiskSetting { get => (this._diffDiskSetting = this._diffDiskSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiffDiskSettings()); set { {_diffDiskSetting = value;} } }

        /// <summary>Internal Acessors for Image</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal.Image { get => (this._image = this._image ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualHardDisk()); set { {_image = value;} } }

        /// <summary>Internal Acessors for ManagedDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal.ManagedDisk { get => (this._managedDisk = this._managedDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParameters()); set { {_managedDisk = value;} } }

        /// <summary>Internal Acessors for ManagedDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal.ManagedDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).DiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).DiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ManagedDiskSecurityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal.ManagedDiskSecurityProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecurityProfileDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal.SecurityProfileDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileDiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileDiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the
        /// disk if creating a VM from user-image or a specialized VHD. Possible values
        /// are: **Windows,** **Linux.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SecurityProfileDiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileDiskEncryptionSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileDiskEncryptionSetId = value ?? null; }

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SecurityProfileSecurityEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileSecurityEncryptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileSecurityEncryptionType = value ?? null; }

        /// <summary>Backing field for <see cref="VhdContainer" /> property.</summary>
        private System.Collections.Generic.List<string> _vhdContainer;

        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for
        /// the scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> VhdContainer { get => this._vhdContainer; set => this._vhdContainer = value; }

        /// <summary>Backing field for <see cref="WriteAcceleratorEnabled" /> property.</summary>
        private bool? _writeAcceleratorEnabled;

        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? WriteAcceleratorEnabled { get => this._writeAcceleratorEnabled; set => this._writeAcceleratorEnabled = value; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetOSDisk" /> instance.</summary>
        public VirtualMachineScaleSetOSDisk()
        {

        }
    }
    /// Describes a virtual machine scale set operating system disk.
    public partial interface IVirtualMachineScaleSetOSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the caching requirements. Possible values are: **None,**
        /// **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        /// storage. ReadOnly for Premium storage.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the caching requirements. Possible values are: **None,**
        **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        storage. ReadOnly for Premium storage.**",
        SerializedName = @"caching",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "ReadOnly", "ReadWrite")]
        string Caching { get; set; }
        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created. The only
        /// allowed value is: **FromImage.** This value is used when you are using an image
        /// to create the virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a marketplace
        /// image, you also use the plan element previously described.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies how the virtual machines in the scale set should be created. The only
        allowed value is: **FromImage.** This value is used when you are using an image
        to create the virtual machine. If you are using a platform image, you also use
        the imageReference element described above. If you are using a marketplace
        image, you  also use the plan element previously described.",
        SerializedName = @"createOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("FromImage", "Empty", "Attach", "Copy", "Restore")]
        string CreateOption { get; set; }
        /// <summary>
        /// Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion
        /// (This feature is available for VMSS with Flexible OrchestrationMode only).
        /// <br><br> Possible values: <br><br> **Delete** If this value is used, the OS
        /// disk is deleted when VMSS Flex VM is deleted.<br><br> **Detach** If this value
        /// is used, the OS disk is retained after VMSS Flex VM is deleted. <br><br> The
        /// default value is set to **Delete**. For an Ephemeral OS Disk, the default value
        /// is set to **Delete**. User cannot change the delete option for Ephemeral OS
        /// Disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion
        (This feature is available for VMSS with Flexible OrchestrationMode only).
        <br><br> Possible values: <br><br> **Delete** If this value is used, the OS
        disk is deleted when VMSS Flex VM is deleted.<br><br> **Detach** If this value
        is used, the OS disk is retained after VMSS Flex VM is deleted. <br><br> The
        default value is set to **Delete**. For an Ephemeral OS Disk, the default value
        is set to **Delete**. User cannot change the delete option for Ephemeral OS
        Disk.",
        SerializedName = @"deleteOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ephemeral disk settings for operating system disk.",
        SerializedName = @"option",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Local")]
        string DiffDiskSettingOption { get; set; }
        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk. Possible
        /// values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        /// **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        /// is used. Refer to the VM size documentation for Windows VM at
        /// https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        /// https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        /// sizes exposes a cache disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the ephemeral disk placement for operating system disk. Possible
        values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        is used. Refer to the VM size documentation for Windows VM at
        https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        sizes exposes a cache disk.",
        SerializedName = @"placement",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("CacheDisk", "ResourceDisk", "NvmeDisk")]
        string DiffDiskSettingPlacement { get; set; }
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'
        /// is the number of bytes x 1024^3 for the disk and the value cannot
        /// be larger than 1023.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the size of an empty data disk in gigabytes. This element can be used
        to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'
        is the number of bytes x 1024^3 for the disk and the value cannot
        be larger than 1023.",
        SerializedName = @"diskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? DiskSizeGb { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
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
        string ImageUri { get; set; }
        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        /// only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        only be used with data disks, it cannot be used with OS Disk.",
        SerializedName = @"storageAccountType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string ManagedDiskStorageAccountType { get; set; }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The disk name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the
        /// disk if creating a VM from user-image or a specialized VHD. Possible values
        /// are: **Windows,** **Linux.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property allows you to specify the type of the OS that is included in the
        disk if creating a VM from user-image or a specialized VHD. Possible values
        are: **Windows,** **Linux.**",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSType { get; set; }
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SecurityProfileDiskEncryptionSetId { get; set; }
        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the EncryptionType of the managed disk. It is set to
        DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        **Note:** It can be set for only Confidential VMs.",
        SerializedName = @"securityEncryptionType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("VMGuestStateOnly", "DiskWithVMGuestState", "NonPersistedTPM")]
        string SecurityProfileSecurityEncryptionType { get; set; }
        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for
        /// the scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the container urls that are used to store operating system disks for
        the scale set.",
        SerializedName = @"vhdContainers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> VhdContainer { get; set; }
        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether writeAccelerator should be enabled or disabled on the disk.",
        SerializedName = @"writeAcceleratorEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WriteAcceleratorEnabled { get; set; }

    }
    /// Describes a virtual machine scale set operating system disk.
    internal partial interface IVirtualMachineScaleSetOSDiskInternal

    {
        /// <summary>
        /// Specifies the caching requirements. Possible values are: **None,**
        /// **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        /// storage. ReadOnly for Premium storage.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "ReadOnly", "ReadWrite")]
        string Caching { get; set; }
        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created. The only
        /// allowed value is: **FromImage.** This value is used when you are using an image
        /// to create the virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a marketplace
        /// image, you also use the plan element previously described.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("FromImage", "Empty", "Attach", "Copy", "Restore")]
        string CreateOption { get; set; }
        /// <summary>
        /// Specifies whether OS Disk should be deleted or detached upon VMSS Flex deletion
        /// (This feature is available for VMSS with Flexible OrchestrationMode only).
        /// <br><br> Possible values: <br><br> **Delete** If this value is used, the OS
        /// disk is deleted when VMSS Flex VM is deleted.<br><br> **Detach** If this value
        /// is used, the OS disk is retained after VMSS Flex VM is deleted. <br><br> The
        /// default value is set to **Delete**. For an Ephemeral OS Disk, the default value
        /// is set to **Delete**. User cannot change the delete option for Ephemeral OS
        /// Disk.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>
        /// Specifies the ephemeral disk Settings for the operating system disk used by the
        /// virtual machine scale set.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings DiffDiskSetting { get; set; }
        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Local")]
        string DiffDiskSettingOption { get; set; }
        /// <summary>
        /// Specifies the ephemeral disk placement for operating system disk. Possible
        /// values are: **CacheDisk,** **ResourceDisk.** The defaulting behavior is:
        /// **CacheDisk** if one is configured for the VM size otherwise **ResourceDisk**
        /// is used. Refer to the VM size documentation for Windows VM at
        /// https://learn.microsoft.com/azure/virtual-machines/windows/sizes and Linux VM at
        /// https://learn.microsoft.com/azure/virtual-machines/linux/sizes to check which VM
        /// sizes exposes a cache disk.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("CacheDisk", "ResourceDisk", "NvmeDisk")]
        string DiffDiskSettingPlacement { get; set; }
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'
        /// is the number of bytes x 1024^3 for the disk and the value cannot
        /// be larger than 1023.
        /// </summary>
        int? DiskSizeGb { get; set; }
        /// <summary>Resource Id</summary>
        string Id { get; set; }
        /// <summary>Specifies information about the unmanaged user image to base the scale set on.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk Image { get; set; }
        /// <summary>Specifies the virtual hard disk's uri.</summary>
        string ImageUri { get; set; }
        /// <summary>The managed disk parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters ManagedDisk { get; set; }
        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed
        /// disk.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters ManagedDiskEncryptionSet { get; set; }
        /// <summary>Specifies the security profile for the managed disk.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile ManagedDiskSecurityProfile { get; set; }
        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        /// only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string ManagedDiskStorageAccountType { get; set; }
        /// <summary>The disk name.</summary>
        string Name { get; set; }
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the
        /// disk if creating a VM from user-image or a specialized VHD. Possible values
        /// are: **Windows,** **Linux.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSType { get; set; }
        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed
        /// disk that is used for Customer Managed Key encrypted ConfidentialVM OS Disk and
        /// VMGuest blob.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters SecurityProfileDiskEncryptionSet { get; set; }
        /// <summary>Resource Id</summary>
        string SecurityProfileDiskEncryptionSetId { get; set; }
        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("VMGuestStateOnly", "DiskWithVMGuestState", "NonPersistedTPM")]
        string SecurityProfileSecurityEncryptionType { get; set; }
        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for
        /// the scale set.
        /// </summary>
        System.Collections.Generic.List<string> VhdContainer { get; set; }
        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        bool? WriteAcceleratorEnabled { get; set; }

    }
}