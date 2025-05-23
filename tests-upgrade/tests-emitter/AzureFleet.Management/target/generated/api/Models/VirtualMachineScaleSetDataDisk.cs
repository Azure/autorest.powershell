// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set data disk.</summary>
    public partial class VirtualMachineScaleSetDataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal
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

        /// <summary>The create option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string CreateOption { get => this._createOption; set => this._createOption = value; }

        /// <summary>Backing field for <see cref="DeleteOption" /> property.</summary>
        private string _deleteOption;

        /// <summary>
        /// Specifies whether data disk should be deleted or detached upon VMSS Flex
        /// deletion (This feature is available for VMSS with Flexible OrchestrationMode
        /// only).<br><br> Possible values: <br><br> **Delete** If this value is used, the
        /// data disk is deleted when the VMSS Flex VM is deleted.<br><br> **Detach** If
        /// this value is used, the data disk is retained after VMSS Flex VM is
        /// deleted.<br><br> The default value is set to **Delete**.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string DeleteOption { get => this._deleteOption; set => this._deleteOption = value; }

        /// <summary>Backing field for <see cref="DiskIopsReadWrite" /> property.</summary>
        private long? _diskIopsReadWrite;

        /// <summary>
        /// Specifies the Read-Write IOPS for the managed disk. Should be used only when
        /// StorageAccountType is UltraSSD_LRS. If not specified, a default value would be
        /// assigned based on diskSizeGB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public long? DiskIopsReadWrite { get => this._diskIopsReadWrite; set => this._diskIopsReadWrite = value; }

        /// <summary>Backing field for <see cref="DiskMBpsReadWrite" /> property.</summary>
        private long? _diskMBpsReadWrite;

        /// <summary>
        /// Specifies the bandwidth in MB per second for the managed disk. Should be used
        /// only when StorageAccountType is UltraSSD_LRS. If not specified, a default value
        /// would be assigned based on diskSizeGB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public long? DiskMBpsReadWrite { get => this._diskMBpsReadWrite; set => this._diskMBpsReadWrite = value; }

        /// <summary>Backing field for <see cref="DiskSizeGb" /> property.</summary>
        private int? _diskSizeGb;

        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property
        /// diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be
        /// larger than 1023.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? DiskSizeGb { get => this._diskSizeGb; set => this._diskSizeGb = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).Id = value ?? null; }

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int _lun;

        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int Lun { get => this._lun; set => this._lun = value; }

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

        /// <summary>Internal Acessors for ManagedDisk</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal.ManagedDisk { get => (this._managedDisk = this._managedDisk ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetManagedDiskParameters()); set { {_managedDisk = value;} } }

        /// <summary>Internal Acessors for ManagedDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal.ManagedDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).DiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).DiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ManagedDiskSecurityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal.ManagedDiskSecurityProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SecurityProfileDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetDataDiskInternal.SecurityProfileDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileDiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal)ManagedDisk).SecurityProfileDiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

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

        /// <summary>Backing field for <see cref="WriteAcceleratorEnabled" /> property.</summary>
        private bool? _writeAcceleratorEnabled;

        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? WriteAcceleratorEnabled { get => this._writeAcceleratorEnabled; set => this._writeAcceleratorEnabled = value; }

        /// <summary>Creates an new <see cref="VirtualMachineScaleSetDataDisk" /> instance.</summary>
        public VirtualMachineScaleSetDataDisk()
        {

        }
    }
    /// Describes a virtual machine scale set data disk.
    public partial interface IVirtualMachineScaleSetDataDisk :
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
        /// <summary>The create option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The create option.",
        SerializedName = @"createOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("FromImage", "Empty", "Attach", "Copy", "Restore")]
        string CreateOption { get; set; }
        /// <summary>
        /// Specifies whether data disk should be deleted or detached upon VMSS Flex
        /// deletion (This feature is available for VMSS with Flexible OrchestrationMode
        /// only).<br><br> Possible values: <br><br> **Delete** If this value is used, the
        /// data disk is deleted when the VMSS Flex VM is deleted.<br><br> **Detach** If
        /// this value is used, the data disk is retained after VMSS Flex VM is
        /// deleted.<br><br> The default value is set to **Delete**.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether data disk should be deleted or detached upon VMSS Flex
        deletion (This feature is available for VMSS with Flexible OrchestrationMode
        only).<br><br> Possible values: <br><br> **Delete** If this value is used, the
        data disk is deleted when the VMSS Flex VM is deleted.<br><br> **Detach** If
        this value is used, the data disk is retained after VMSS Flex VM is
        deleted.<br><br> The default value is set to **Delete**.",
        SerializedName = @"deleteOption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>
        /// Specifies the Read-Write IOPS for the managed disk. Should be used only when
        /// StorageAccountType is UltraSSD_LRS. If not specified, a default value would be
        /// assigned based on diskSizeGB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Read-Write IOPS for the managed disk. Should be used only when
        StorageAccountType is UltraSSD_LRS. If not specified, a default value would be
        assigned based on diskSizeGB.",
        SerializedName = @"diskIOPSReadWrite",
        PossibleTypes = new [] { typeof(long) })]
        long? DiskIopsReadWrite { get; set; }
        /// <summary>
        /// Specifies the bandwidth in MB per second for the managed disk. Should be used
        /// only when StorageAccountType is UltraSSD_LRS. If not specified, a default value
        /// would be assigned based on diskSizeGB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the bandwidth in MB per second for the managed disk. Should be used
        only when StorageAccountType is UltraSSD_LRS. If not specified, a default value
        would be assigned based on diskSizeGB.",
        SerializedName = @"diskMBpsReadWrite",
        PossibleTypes = new [] { typeof(long) })]
        long? DiskMBpsReadWrite { get; set; }
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property
        /// diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be
        /// larger than 1023.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the size of an empty data disk in gigabytes. This element can be used
        to overwrite the size of the disk in a virtual machine image. The property
        diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be
        larger than 1023.",
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
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the logical unit number of the data disk. This value is used to
        identify data disks within the VM and therefore must be unique for each data
        disk attached to a VM.",
        SerializedName = @"lun",
        PossibleTypes = new [] { typeof(int) })]
        int Lun { get; set; }
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
    /// Describes a virtual machine scale set data disk.
    internal partial interface IVirtualMachineScaleSetDataDiskInternal

    {
        /// <summary>
        /// Specifies the caching requirements. Possible values are: **None,**
        /// **ReadOnly,** **ReadWrite.** The default values are: **None for Standard
        /// storage. ReadOnly for Premium storage.**
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("None", "ReadOnly", "ReadWrite")]
        string Caching { get; set; }
        /// <summary>The create option.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("FromImage", "Empty", "Attach", "Copy", "Restore")]
        string CreateOption { get; set; }
        /// <summary>
        /// Specifies whether data disk should be deleted or detached upon VMSS Flex
        /// deletion (This feature is available for VMSS with Flexible OrchestrationMode
        /// only).<br><br> Possible values: <br><br> **Delete** If this value is used, the
        /// data disk is deleted when the VMSS Flex VM is deleted.<br><br> **Detach** If
        /// this value is used, the data disk is retained after VMSS Flex VM is
        /// deleted.<br><br> The default value is set to **Delete**.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Delete", "Detach")]
        string DeleteOption { get; set; }
        /// <summary>
        /// Specifies the Read-Write IOPS for the managed disk. Should be used only when
        /// StorageAccountType is UltraSSD_LRS. If not specified, a default value would be
        /// assigned based on diskSizeGB.
        /// </summary>
        long? DiskIopsReadWrite { get; set; }
        /// <summary>
        /// Specifies the bandwidth in MB per second for the managed disk. Should be used
        /// only when StorageAccountType is UltraSSD_LRS. If not specified, a default value
        /// would be assigned based on diskSizeGB.
        /// </summary>
        long? DiskMBpsReadWrite { get; set; }
        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used
        /// to overwrite the size of the disk in a virtual machine image. The property
        /// diskSizeGB is the number of bytes x 1024^3 for the disk and the value cannot be
        /// larger than 1023.
        /// </summary>
        int? DiskSizeGb { get; set; }
        /// <summary>Resource Id</summary>
        string Id { get; set; }
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to
        /// identify data disks within the VM and therefore must be unique for each data
        /// disk attached to a VM.
        /// </summary>
        int Lun { get; set; }
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
        /// <summary>Specifies whether writeAccelerator should be enabled or disabled on the disk.</summary>
        bool? WriteAcceleratorEnabled { get; set; }

    }
}