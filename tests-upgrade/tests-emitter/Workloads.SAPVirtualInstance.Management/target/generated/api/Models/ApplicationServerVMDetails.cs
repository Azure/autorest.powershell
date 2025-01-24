// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The Application Server VM Details.</summary>
    public partial class ApplicationServerVMDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetails,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetailsInternal
    {

        /// <summary>Internal Acessors for StorageDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetailsInternal.StorageDetail { get => this._storageDetail; set { {_storageDetail = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetailsInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Internal Acessors for VirtualMachineId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerVMDetailsInternal.VirtualMachineId { get => this._virtualMachineId; set { {_virtualMachineId = value;} } }

        /// <summary>Backing field for <see cref="StorageDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation> _storageDetail;

        /// <summary>
        /// Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation> StorageDetail { get => this._storageDetail; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Defines the type of application server VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Backing field for <see cref="VirtualMachineId" /> property.</summary>
        private string _virtualMachineId;

        /// <summary>The virtual machine id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string VirtualMachineId { get => this._virtualMachineId; }

        /// <summary>Creates an new <see cref="ApplicationServerVMDetails" /> instance.</summary>
        public ApplicationServerVMDetails()
        {

        }
    }
    /// The Application Server VM Details.
    public partial interface IApplicationServerVMDetails :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.",
        SerializedName = @"storageDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation> StorageDetail { get;  }
        /// <summary>Defines the type of application server VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Defines the type of application server VM.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Active", "Standby", "Unknown")]
        string Type { get;  }
        /// <summary>The virtual machine id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The virtual machine id.",
        SerializedName = @"virtualMachineId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualMachineId { get;  }

    }
    /// The Application Server VM Details.
    internal partial interface IApplicationServerVMDetailsInternal

    {
        /// <summary>
        /// Storage details of all the Storage Accounts attached to the App Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStorageInformation> StorageDetail { get; set; }
        /// <summary>Defines the type of application server VM.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("Active", "Standby", "Unknown")]
        string Type { get; set; }
        /// <summary>The virtual machine id.</summary>
        string VirtualMachineId { get; set; }

    }
}