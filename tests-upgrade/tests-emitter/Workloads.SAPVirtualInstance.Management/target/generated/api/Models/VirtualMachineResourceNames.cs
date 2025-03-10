// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The resource names object for virtual machine and related resources.</summary>
    public partial class VirtualMachineResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="DataDiskName" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames _dataDiskName;

        /// <summary>
        /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
        /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
        /// For application and cs layers, only 'default' volume is supported
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames DataDiskName { get => (this._dataDiskName = this._dataDiskName ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DataDiskNames()); set => this._dataDiskName = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>
        /// The full name for virtual-machine's host (computer name). Currently, ACSS only supports host names which are less than
        /// or equal to 13 characters long. If this value is not provided, vmName will be used as host name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="NetworkInterface" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> _networkInterface;

        /// <summary>
        /// The list of network interface name objects for the selected virtual machine. Currently, only one network interface is
        /// supported per virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> NetworkInterface { get => this._networkInterface; set => this._networkInterface = value; }

        /// <summary>Backing field for <see cref="OSDiskName" /> property.</summary>
        private string _oSDiskName;

        /// <summary>
        /// The full name for OS disk attached to the VM. If this value is not provided, it will be named by ARM as per its default
        /// naming standards (prefixed with vm name). There is only one OS disk attached per Virtual Machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string OSDiskName { get => this._oSDiskName; set => this._oSDiskName = value; }

        /// <summary>Backing field for <see cref="VMName" /> property.</summary>
        private string _vMName;

        /// <summary>
        /// The full name for virtual machine. The length of this field can be upto 64 characters. If name is not provided, service
        /// uses a default name based on the deployment type. For SingleServer, default name is {SID}vm. In case of HA-AvZone systems,
        /// default name will be {SID}{app/ascs/db}z{a/b}vm with an incrementor at the end in case of more than 1 vm per layer. For
        /// distributed and HA-AvSet systems, default name will be {SID}{app/ascs/db}vm with an incrementor at the end in case of
        /// more than 1 vm per layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string VMName { get => this._vMName; set => this._vMName = value; }

        /// <summary>Creates an new <see cref="VirtualMachineResourceNames" /> instance.</summary>
        public VirtualMachineResourceNames()
        {

        }
    }
    /// The resource names object for virtual machine and related resources.
    public partial interface IVirtualMachineResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
        /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
        /// For application and cs layers, only 'default' volume is supported
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup']. For application and cs layers, only 'default' volume is supported",
        SerializedName = @"dataDiskNames",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames) })]
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames DataDiskName { get; set; }
        /// <summary>
        /// The full name for virtual-machine's host (computer name). Currently, ACSS only supports host names which are less than
        /// or equal to 13 characters long. If this value is not provided, vmName will be used as host name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for virtual-machine's host (computer name). Currently, ACSS only supports host names which are less than or equal to 13 characters long. If this value is not provided, vmName will be used as host name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>
        /// The list of network interface name objects for the selected virtual machine. Currently, only one network interface is
        /// supported per virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of network interface name objects for the selected virtual machine. Currently, only one network interface is supported per virtual machine.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> NetworkInterface { get; set; }
        /// <summary>
        /// The full name for OS disk attached to the VM. If this value is not provided, it will be named by ARM as per its default
        /// naming standards (prefixed with vm name). There is only one OS disk attached per Virtual Machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for OS disk attached to the VM. If this value is not provided, it will be named by ARM as per its default naming standards (prefixed with vm name). There is only one OS disk attached per Virtual Machine.",
        SerializedName = @"osDiskName",
        PossibleTypes = new [] { typeof(string) })]
        string OSDiskName { get; set; }
        /// <summary>
        /// The full name for virtual machine. The length of this field can be upto 64 characters. If name is not provided, service
        /// uses a default name based on the deployment type. For SingleServer, default name is {SID}vm. In case of HA-AvZone systems,
        /// default name will be {SID}{app/ascs/db}z{a/b}vm with an incrementor at the end in case of more than 1 vm per layer. For
        /// distributed and HA-AvSet systems, default name will be {SID}{app/ascs/db}vm with an incrementor at the end in case of
        /// more than 1 vm per layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for virtual machine. The length of this field can be upto 64 characters. If name is not provided, service uses a default name based on the deployment type. For SingleServer, default name is {SID}vm. In case of HA-AvZone systems, default name will be {SID}{app/ascs/db}z{a/b}vm with an incrementor at the end in case of more than 1 vm per layer. For distributed and HA-AvSet systems, default name will be {SID}{app/ascs/db}vm with an incrementor at the end in case of more than 1 vm per layer.",
        SerializedName = @"vmName",
        PossibleTypes = new [] { typeof(string) })]
        string VMName { get; set; }

    }
    /// The resource names object for virtual machine and related resources.
    internal partial interface IVirtualMachineResourceNamesInternal

    {
        /// <summary>
        /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
        /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
        /// For application and cs layers, only 'default' volume is supported
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames DataDiskName { get; set; }
        /// <summary>
        /// The full name for virtual-machine's host (computer name). Currently, ACSS only supports host names which are less than
        /// or equal to 13 characters long. If this value is not provided, vmName will be used as host name.
        /// </summary>
        string HostName { get; set; }
        /// <summary>
        /// The list of network interface name objects for the selected virtual machine. Currently, only one network interface is
        /// supported per virtual machine.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> NetworkInterface { get; set; }
        /// <summary>
        /// The full name for OS disk attached to the VM. If this value is not provided, it will be named by ARM as per its default
        /// naming standards (prefixed with vm name). There is only one OS disk attached per Virtual Machine.
        /// </summary>
        string OSDiskName { get; set; }
        /// <summary>
        /// The full name for virtual machine. The length of this field can be upto 64 characters. If name is not provided, service
        /// uses a default name based on the deployment type. For SingleServer, default name is {SID}vm. In case of HA-AvZone systems,
        /// default name will be {SID}{app/ascs/db}z{a/b}vm with an incrementor at the end in case of more than 1 vm per layer. For
        /// distributed and HA-AvSet systems, default name will be {SID}{app/ascs/db}vm with an incrementor at the end in case of
        /// more than 1 vm per layer.
        /// </summary>
        string VMName { get; set; }

    }
}