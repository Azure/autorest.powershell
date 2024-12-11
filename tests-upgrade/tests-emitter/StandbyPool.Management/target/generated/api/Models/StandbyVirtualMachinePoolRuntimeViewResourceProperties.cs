// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    /// </summary>
    public partial class StandbyVirtualMachinePoolRuntimeViewResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="InstanceCountSummary" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> _instanceCountSummary;

        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider.
        /// If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        /// Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get => this._instanceCountSummary; }

        /// <summary>Internal Acessors for InstanceCountSummary</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.InstanceCountSummary { get => this._instanceCountSummary; set { {_instanceCountSummary = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Creates an new <see cref="StandbyVirtualMachinePoolRuntimeViewResourceProperties" /> instance.
        /// </summary>
        public StandbyVirtualMachinePoolRuntimeViewResourceProperties()
        {

        }
    }
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    public partial interface IStandbyVirtualMachinePoolRuntimeViewResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider.
        /// If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        /// Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the StandbyPool resource provider.
        If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        Note: any resources in the Running state may still be installing extensions / not fully provisioned.",
        SerializedName = @"instanceCountSummary",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get;  }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the provisioning state of the standby pool",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get;  }

    }
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    internal partial interface IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal

    {
        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider.
        /// If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        /// Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get; set; }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }

    }
}