// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The full resource names object for application layer resources. The number of entries in this list should be equal to
    /// the number VMs to be created for application layer.
    /// </summary>
    public partial class ApplicationServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IApplicationServerFullResourceNamesInternal
    {

        /// <summary>Backing field for <see cref="AvailabilitySetName" /> property.</summary>
        private string _availabilitySetName;

        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AvailabilitySetName { get => this._availabilitySetName; set => this._availabilitySetName = value; }

        /// <summary>Backing field for <see cref="VirtualMachine" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> _virtualMachine;

        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> VirtualMachine { get => this._virtualMachine; set => this._virtualMachine = value; }

        /// <summary>Creates an new <see cref="ApplicationServerFullResourceNames" /> instance.</summary>
        public ApplicationServerFullResourceNames()
        {

        }
    }
    /// The full resource names object for application layer resources. The number of entries in this list should be equal to
    /// the number VMs to be created for application layer.
    public partial interface IApplicationServerFullResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.",
        SerializedName = @"availabilitySetName",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilitySetName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of virtual machine naming details.",
        SerializedName = @"virtualMachines",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> VirtualMachine { get; set; }

    }
    /// The full resource names object for application layer resources. The number of entries in this list should be equal to
    /// the number VMs to be created for application layer.
    internal partial interface IApplicationServerFullResourceNamesInternal

    {
        /// <summary>
        /// The full name for availability set. In case name is not provided, it will be defaulted to {SID}-App-AvSet.
        /// </summary>
        string AvailabilitySetName { get; set; }
        /// <summary>The list of virtual machine naming details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IVirtualMachineResourceNames> VirtualMachine { get; set; }

    }
}