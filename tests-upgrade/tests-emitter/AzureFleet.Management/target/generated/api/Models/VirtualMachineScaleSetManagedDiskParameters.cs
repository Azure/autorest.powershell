// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes the parameters of a ScaleSet managed disk.</summary>
    public partial class VirtualMachineScaleSetManagedDiskParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionSet" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters _diskEncryptionSet;

        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed
        /// disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters DiskEncryptionSet { get => (this._diskEncryptionSet = this._diskEncryptionSet ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParameters()); set => this._diskEncryptionSet = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParametersInternal)DiskEncryptionSet).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParametersInternal)DiskEncryptionSet).Id = value ?? null; }

        /// <summary>Internal Acessors for DiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal.DiskEncryptionSet { get => (this._diskEncryptionSet = this._diskEncryptionSet ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiskEncryptionSetParameters()); set { {_diskEncryptionSet = value;} } }

        /// <summary>Internal Acessors for SecurityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal.SecurityProfile { get => (this._securityProfile = this._securityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfile()); set { {_securityProfile = value;} } }

        /// <summary>Internal Acessors for SecurityProfileDiskEncryptionSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetManagedDiskParametersInternal.SecurityProfileDiskEncryptionSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal)SecurityProfile).DiskEncryptionSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal)SecurityProfile).DiskEncryptionSet = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="SecurityProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile _securityProfile;

        /// <summary>Specifies the security profile for the managed disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile SecurityProfile { get => (this._securityProfile = this._securityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMDiskSecurityProfile()); set => this._securityProfile = value; }

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SecurityProfileDiskEncryptionSetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal)SecurityProfile).DiskEncryptionSetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal)SecurityProfile).DiskEncryptionSetId = value ?? null; }

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. It is set to
        /// DiskWithVMGuestState for encryption of the managed disk along with VMGuestState
        /// blob, VMGuestStateOnly for encryption of just the VMGuestState blob, and
        /// NonPersistedTPM for not persisting firmware state in the VMGuestState blob..
        /// **Note:** It can be set for only Confidential VMs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public string SecurityProfileSecurityEncryptionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal)SecurityProfile).SecurityEncryptionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfileInternal)SecurityProfile).SecurityEncryptionType = value ?? null; }

        /// <summary>Backing field for <see cref="StorageAccountType" /> property.</summary>
        private string _storageAccountType;

        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        /// only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string StorageAccountType { get => this._storageAccountType; set => this._storageAccountType = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineScaleSetManagedDiskParameters" /> instance.
        /// </summary>
        public VirtualMachineScaleSetManagedDiskParameters()
        {

        }
    }
    /// Describes the parameters of a ScaleSet managed disk.
    public partial interface IVirtualMachineScaleSetManagedDiskParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
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
        string StorageAccountType { get; set; }

    }
    /// Describes the parameters of a ScaleSet managed disk.
    internal partial interface IVirtualMachineScaleSetManagedDiskParametersInternal

    {
        /// <summary>
        /// Specifies the customer managed disk encryption set resource id for the managed
        /// disk.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters DiskEncryptionSet { get; set; }
        /// <summary>Resource Id</summary>
        string Id { get; set; }
        /// <summary>Specifies the security profile for the managed disk.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMDiskSecurityProfile SecurityProfile { get; set; }
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
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can
        /// only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS", "Premium_ZRS", "StandardSSD_ZRS", "PremiumV2_LRS")]
        string StorageAccountType { get; set; }

    }
}