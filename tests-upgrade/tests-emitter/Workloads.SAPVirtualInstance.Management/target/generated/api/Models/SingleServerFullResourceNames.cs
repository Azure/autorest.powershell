// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a single
    /// server SAP system.
    /// </summary>
    public partial class SingleServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNames"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNames __singleServerCustomResourceNames = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SingleServerCustomResourceNames();

        /// <summary>Internal Acessors for NamingPatternType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal.NamingPatternType { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal)__singleServerCustomResourceNames).NamingPatternType; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal)__singleServerCustomResourceNames).NamingPatternType = value ; }

        /// <summary>Internal Acessors for VirtualMachine</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerFullResourceNamesInternal.VirtualMachine { get => (this._virtualMachine = this._virtualMachine ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNames()); set { {_virtualMachine = value;} } }

        /// <summary>The naming pattern type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string NamingPatternType { get => "FullResourceName"; }

        /// <summary>Backing field for <see cref="VirtualMachine" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames _virtualMachine;

        /// <summary>The resource names object for virtual machine and related resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames VirtualMachine { get => (this._virtualMachine = this._virtualMachine ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.VirtualMachineResourceNames()); set => this._virtualMachine = value; }

        /// <summary>
        /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
        /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
        /// For application and cs layers, only 'default' volume is supported
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames VirtualMachineDataDiskName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).DataDiskName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).DataDiskName = value ?? null /* model class */; }

        /// <summary>
        /// The full name for virtual-machine's host (computer name). Currently, ACSS only supports host names which are less than
        /// or equal to 13 characters long. If this value is not provided, vmName will be used as host name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string VirtualMachineHostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).HostName = value ?? null; }

        /// <summary>
        /// The list of network interface name objects for the selected virtual machine. Currently, only one network interface is
        /// supported per virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> VirtualMachineNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).NetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).NetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>
        /// The full name for OS disk attached to the VM. If this value is not provided, it will be named by ARM as per its default
        /// naming standards (prefixed with vm name). There is only one OS disk attached per Virtual Machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string VirtualMachineOSDiskName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).OSDiskName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).OSDiskName = value ?? null; }

        /// <summary>
        /// The full name for virtual machine. The length of this field can be upto 64 characters. If name is not provided, service
        /// uses a default name based on the deployment type. For SingleServer, default name is {SID}vm. In case of HA-AvZone systems,
        /// default name will be {SID}{app/ascs/db}z{a/b}vm with an incrementor at the end in case of more than 1 vm per layer. For
        /// distributed and HA-AvSet systems, default name will be {SID}{app/ascs/db}vm with an incrementor at the end in case of
        /// more than 1 vm per layer.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inlined)]
        public string VirtualMachineVMName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).VMName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNamesInternal)VirtualMachine).VMName = value ?? null; }

        /// <summary>Creates an new <see cref="SingleServerFullResourceNames" /> instance.</summary>
        public SingleServerFullResourceNames()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__singleServerCustomResourceNames), __singleServerCustomResourceNames);
            await eventListener.AssertObjectIsValid(nameof(__singleServerCustomResourceNames), __singleServerCustomResourceNames);
        }
    }
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a single
    /// server SAP system.
    public partial interface ISingleServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNames
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
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames VirtualMachineDataDiskName { get; set; }
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
        string VirtualMachineHostName { get; set; }
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> VirtualMachineNetworkInterface { get; set; }
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
        string VirtualMachineOSDiskName { get; set; }
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
        string VirtualMachineVMName { get; set; }

    }
    /// The resource name object where the specified values will be full resource names of the corresponding resources in a single
    /// server SAP system.
    internal partial interface ISingleServerFullResourceNamesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal
    {
        /// <summary>The resource names object for virtual machine and related resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames VirtualMachine { get; set; }
        /// <summary>
        /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
        /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
        /// For application and cs layers, only 'default' volume is supported
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames VirtualMachineDataDiskName { get; set; }
        /// <summary>
        /// The full name for virtual-machine's host (computer name). Currently, ACSS only supports host names which are less than
        /// or equal to 13 characters long. If this value is not provided, vmName will be used as host name.
        /// </summary>
        string VirtualMachineHostName { get; set; }
        /// <summary>
        /// The list of network interface name objects for the selected virtual machine. Currently, only one network interface is
        /// supported per virtual machine.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.INetworkInterfaceResourceNames> VirtualMachineNetworkInterface { get; set; }
        /// <summary>
        /// The full name for OS disk attached to the VM. If this value is not provided, it will be named by ARM as per its default
        /// naming standards (prefixed with vm name). There is only one OS disk attached per Virtual Machine.
        /// </summary>
        string VirtualMachineOSDiskName { get; set; }
        /// <summary>
        /// The full name for virtual machine. The length of this field can be upto 64 characters. If name is not provided, service
        /// uses a default name based on the deployment type. For SingleServer, default name is {SID}vm. In case of HA-AvZone systems,
        /// default name will be {SID}{app/ascs/db}z{a/b}vm with an incrementor at the end in case of more than 1 vm per layer. For
        /// distributed and HA-AvSet systems, default name will be {SID}{app/ascs/db}vm with an incrementor at the end in case of
        /// more than 1 vm per layer.
        /// </summary>
        string VirtualMachineVMName { get; set; }

    }
}