// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the StandbyVirtualMachine.</summary>
    public partial class StandbyVirtualMachineResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResourcePropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachineResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="VirtualMachineResourceId" /> property.</summary>
        private string _virtualMachineResourceId;

        /// <summary>Resource id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string VirtualMachineResourceId { get => this._virtualMachineResourceId; set => this._virtualMachineResourceId = value; }

        /// <summary>Creates an new <see cref="StandbyVirtualMachineResourceProperties" /> instance.</summary>
        public StandbyVirtualMachineResourceProperties()
        {

        }
    }
    /// Details of the StandbyVirtualMachine.
    public partial interface IStandbyVirtualMachineResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get;  }
        /// <summary>Resource id of the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource id of the virtual machine.",
        SerializedName = @"virtualMachineResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualMachineResourceId { get; set; }

    }
    /// Details of the StandbyVirtualMachine.
    internal partial interface IStandbyVirtualMachineResourcePropertiesInternal

    {
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Resource id of the virtual machine.</summary>
        string VirtualMachineResourceId { get; set; }

    }
}