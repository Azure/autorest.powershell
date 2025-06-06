// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set storage profile.</summary>
    public partial class VirtualMachineScaleSetStorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal
    {

        /// <summary>Backing field for <see cref="DataDisk" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk> _dataDisk;

        /// <summary>
        /// Specifies the parameters that are used to add data disks to the virtual
        /// machines in the scale set. For more information about disks, see [About disks
        /// and VHDs for Azure virtual
        /// machines](https://learn.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk> DataDisk { get => this._dataDisk; set => this._dataDisk = value; }

        /// <summary>Specifies the ephemeral disk settings for operating system disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string DiffDiskSettingOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiffDiskSettingOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiffDiskSettingOption = value ?? null; }

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
        public string DiffDiskSettingPlacement { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiffDiskSettingPlacement; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiffDiskSettingPlacement = value ?? null; }

        /// <summary>Backing field for <see cref="DiskControllerType" /> property.</summary>
        private string _diskControllerType;

        /// <summary>
        /// Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DiskControllerType { get => this._diskControllerType; set => this._diskControllerType = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Id = value ?? null; }

        /// <summary>Backing field for <see cref="ImageReference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference _imageReference;

        /// <summary>
        /// Specifies information about the image to use. You can specify information about
        /// platform images, marketplace images, or virtual machine images. This element is
        /// required when you want to use a platform image, marketplace image, or virtual
        /// machine image, but is not used in other creation operations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference ImageReference { get => (this._imageReference = this._imageReference ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ImageReference()); set => this._imageReference = value; }

        /// <summary>
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceCommunityGalleryImageId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).CommunityGalleryImageId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).CommunityGalleryImageId = value ?? null; }

        /// <summary>
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).ExactVersion; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Id = value ?? null; }

        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Offer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Offer = value ?? null; }

        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferencePublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Publisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Publisher = value ?? null; }

        /// <summary>
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceSharedGalleryImageId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).SharedGalleryImageId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).SharedGalleryImageId = value ?? null; }

        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Sku = value ?? null; }

        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageReferenceVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).Version = value ?? null; }

        /// <summary>Specifies the virtual hard disk's uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ImageUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ImageUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ImageUri = value ?? null; }

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        /// only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string ManagedDiskStorageAccountType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDiskStorageAccountType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDiskStorageAccountType = value ?? null; }

        /// <summary>Internal Acessors for ImageReference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.ImageReference { get => (this._imageReference = this._imageReference ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ImageReference()); set { {_imageReference = value;} } }

        /// <summary>Internal Acessors for ImageReferenceExactVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.ImageReferenceExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).ExactVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReferenceInternal)ImageReference).ExactVersion = value ?? null; }

        /// <summary>Internal Acessors for ManagedDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.ManagedDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ManagedDiskSecurityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.ManagedDiskSecurityProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDiskSecurityProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDiskSecurityProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for OSDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.OSDisk { get => (this._oSDisk = this._oSDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDisk()); set { {_oSDisk = value;} } }

        /// <summary>Internal Acessors for OSDiskDiffDiskSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.OSDiskDiffDiskSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiffDiskSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiffDiskSetting = value ?? null /* model class */; }

        /// <summary>Internal Acessors for OSDiskImage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.OSDiskImage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Image; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Image = value ?? null /* model class */; }

        /// <summary>Internal Acessors for OSDiskManagedDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.OSDiskManagedDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).ManagedDisk = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecurityProfileDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetStorageProfileInternal.SecurityProfileDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).SecurityProfileDiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).SecurityProfileDiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="OSDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk _oSDisk;

        /// <summary>
        /// Specifies information about the operating system disk used by the virtual
        /// machines in the scale set. For more information about disks, see [About disks
        /// and VHDs for Azure virtual
        /// machines](https://learn.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk OSDisk { get => (this._oSDisk = this._oSDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSDisk()); set => this._oSDisk = value; }

        /// <summary>
        /// Specifies the caching requirements. Possible values are: **None,**
        /// **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        /// storage. ReadOnly for Premium storage.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string OSDiskCaching { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Caching; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Caching = value ?? null; }

        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created. The only
        /// allowed value is: **FromImage.** This value is used when you are using an image
        /// to create the virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a marketplace
        /// image, you also use the plan element previously described.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string OSDiskCreateOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).CreateOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).CreateOption = value ?? null; }

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
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string OSDiskDeleteOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DeleteOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DeleteOption = value ?? null; }

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string OSDiskName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).Name = value ?? null; }

        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the
        /// disk if creating a VM from user-image or a specialized VHD. Possible values
        /// are: **Windows,** **Linux.**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string OSDiskOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).OSType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).OSType = value ?? null; }

        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'
        /// is the number of bytes x 1024^3 for the disk and the value cannot
        /// be larger than 1023.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? OSDiskSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiskSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).DiskSizeGb = value ?? default(int); }

        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for
        /// the scale set.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> OSDiskVhdContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).VhdContainer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).VhdContainer = value ?? null /* arrayOf */; }

        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public bool? OSDiskWriteAcceleratorEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).WriteAcceleratorEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).WriteAcceleratorEnabled = value ?? default(bool); }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SecurityProfileDiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).SecurityProfileDiskEncryptionSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).SecurityProfileDiskEncryptionSetId = value ?? null; }

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SecurityProfileSecurityEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).SecurityProfileSecurityEncryptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDiskInternal)OSDisk).SecurityProfileSecurityEncryptionType = value ?? null; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetStorageProfile" /> instance.</summary>
        public VirtualMachineScaleSetStorageProfile()
        {

        }
    }
    /// Describes a virtual machine scale set storage profile.
    public partial interface IVirtualMachineScaleSetStorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the parameters that are used to add data disks to the virtual
        /// machines in the scale set. For more information about disks, see [About disks
        /// and VHDs for Azure virtual
        /// machines](https://learn.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the parameters that are used to add data disks to the virtual
        machines in the scale set. For more information about disks, see [About disks
        and VHDs for Azure virtual
        machines](https://learn.microsoft.com/azure/virtual-machines/managed-disks-overview).",
        SerializedName = @"dataDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk> DataDisk { get; set; }
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
        /// Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01",
        SerializedName = @"diskControllerType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("SCSI", "NVMe")]
        string DiskControllerType { get; set; }
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
        /// <summary>
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specified the community gallery image unique id for vm deployment. This can be
        fetched from community gallery image GET call.",
        SerializedName = @"communityGalleryImageId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceCommunityGalleryImageId { get; set; }
        /// <summary>
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Specifies in decimal numbers, the version of platform image or marketplace
        image used to create the virtual machine. This readonly field differs from 'version',
        only if the value specified in 'version' field is 'latest'.",
        SerializedName = @"exactVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceExactVersion { get;  }
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
        string ImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the offer of the platform image or marketplace image used to create
        the virtual machine.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image publisher.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferencePublisher { get; set; }
        /// <summary>
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specified the shared gallery image unique id for vm deployment. This can be
        fetched from shared gallery image GET call.",
        SerializedName = @"sharedGalleryImageId",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceSharedGalleryImageId { get; set; }
        /// <summary>The image SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The image SKU.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the version of the platform image or marketplace image used to create
        the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        version of an image available at deploy time. Even if you use 'latest', the VM
        image will not automatically update after deploy time even if a new version
        becomes available. Please do not use field 'version' for gallery image
        deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        version of gallery image, just set
        '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        in the 'id' field without version input.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ImageReferenceVersion { get; set; }
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
        string OSDiskCaching { get; set; }
        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created. The only
        /// allowed value is: **FromImage.** This value is used when you are using an image
        /// to create the virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a marketplace
        /// image, you also use the plan element previously described.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
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
        string OSDiskCreateOption { get; set; }
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
        string OSDiskDeleteOption { get; set; }
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
        string OSDiskName { get; set; }
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
        string OSDiskOstype { get; set; }
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
        int? OSDiskSizeGb { get; set; }
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
        System.Collections.Generic.List<string> OSDiskVhdContainer { get; set; }
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
        bool? OSDiskWriteAcceleratorEnabled { get; set; }
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

    }
    /// Describes a virtual machine scale set storage profile.
    internal partial interface IVirtualMachineScaleSetStorageProfileInternal

    {
        /// <summary>
        /// Specifies the parameters that are used to add data disks to the virtual
        /// machines in the scale set. For more information about disks, see [About disks
        /// and VHDs for Azure virtual
        /// machines](https://learn.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk> DataDisk { get; set; }
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
        /// Specifies the disk controller type configured for the virtual machines in the scale set. Minimum api-version: 2022-08-01
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("SCSI", "NVMe")]
        string DiskControllerType { get; set; }
        /// <summary>Resource Id</summary>
        string Id { get; set; }
        /// <summary>
        /// Specifies information about the image to use. You can specify information about
        /// platform images, marketplace images, or virtual machine images. This element is
        /// required when you want to use a platform image, marketplace image, or virtual
        /// machine image, but is not used in other creation operations.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IImageReference ImageReference { get; set; }
        /// <summary>
        /// Specified the community gallery image unique id for vm deployment. This can be
        /// fetched from community gallery image GET call.
        /// </summary>
        string ImageReferenceCommunityGalleryImageId { get; set; }
        /// <summary>
        /// Specifies in decimal numbers, the version of platform image or marketplace
        /// image used to create the virtual machine. This readonly field differs from 'version',
        /// only if the value specified in 'version' field is 'latest'.
        /// </summary>
        string ImageReferenceExactVersion { get; set; }
        /// <summary>Resource Id</summary>
        string ImageReferenceId { get; set; }
        /// <summary>
        /// Specifies the offer of the platform image or marketplace image used to create
        /// the virtual machine.
        /// </summary>
        string ImageReferenceOffer { get; set; }
        /// <summary>The image publisher.</summary>
        string ImageReferencePublisher { get; set; }
        /// <summary>
        /// Specified the shared gallery image unique id for vm deployment. This can be
        /// fetched from shared gallery image GET call.
        /// </summary>
        string ImageReferenceSharedGalleryImageId { get; set; }
        /// <summary>The image SKU.</summary>
        string ImageReferenceSku { get; set; }
        /// <summary>
        /// Specifies the version of the platform image or marketplace image used to create
        /// the virtual machine. The allowed formats are Major.Minor.Build or 'latest'.
        /// Major, Minor, and Build are decimal numbers. Specify 'latest' to use the latest
        /// version of an image available at deploy time. Even if you use 'latest', the VM
        /// image will not automatically update after deploy time even if a new version
        /// becomes available. Please do not use field 'version' for gallery image
        /// deployment, gallery image should always use 'id' field for deployment, to use 'latest'
        /// version of gallery image, just set
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/images/{imageName}'
        /// in the 'id' field without version input.
        /// </summary>
        string ImageReferenceVersion { get; set; }
        /// <summary>Specifies the virtual hard disk's uri.</summary>
        string ImageUri { get; set; }
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
        /// <summary>
        /// Specifies information about the operating system disk used by the virtual
        /// machines in the scale set. For more information about disks, see [About disks
        /// and VHDs for Azure virtual
        /// machines](https://learn.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSDisk OSDisk { get; set; }
        /// <summary>
        /// Specifies the caching requirements. Possible values are: **None,**
        /// **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        /// storage. ReadOnly for Premium storage.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "ReadOnly", "ReadWrite")]
        string OSDiskCaching { get; set; }
        /// <summary>
        /// Specifies how the virtual machines in the scale set should be created. The only
        /// allowed value is: **FromImage.** This value is used when you are using an image
        /// to create the virtual machine. If you are using a platform image, you also use
        /// the imageReference element described above. If you are using a marketplace
        /// image, you also use the plan element previously described.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("FromImage", "Empty", "Attach", "Copy", "Restore")]
        string OSDiskCreateOption { get; set; }
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
        string OSDiskDeleteOption { get; set; }
        /// <summary>
        /// Specifies the ephemeral disk Settings for the operating system disk used by the
        /// virtual machine scale set.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiffDiskSettings OSDiskDiffDiskSetting { get; set; }
        /// <summary>Specifies information about the unmanaged user image to base the scale set on.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualHardDisk OSDiskImage { get; set; }
        /// <summary>The managed disk parameters.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters OSDiskManagedDisk { get; set; }
        /// <summary>The disk name.</summary>
        string OSDiskName { get; set; }
        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the
        /// disk if creating a VM from user-image or a specialized VHD. Possible values
        /// are: **Windows,** **Linux.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Windows", "Linux")]
        string OSDiskOstype { get; set; }
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property 'diskSizeGB'
        /// is the number of bytes x 1024^3 for the disk and the value cannot
        /// be larger than 1023.
        /// </summary>
        int? OSDiskSizeGb { get; set; }
        /// <summary>
        /// Specifies the container urls that are used to store operating system disks for
        /// the scale set.
        /// </summary>
        System.Collections.Generic.List<string> OSDiskVhdContainer { get; set; }
        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        bool? OSDiskWriteAcceleratorEnabled { get; set; }
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

    }
}