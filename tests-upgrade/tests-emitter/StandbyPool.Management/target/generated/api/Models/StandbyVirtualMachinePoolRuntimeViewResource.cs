// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>
    /// Contains information about a standby virtual machine pool as last known by the StandbyPool resource provider.
    /// </summary>
    public partial class StandbyVirtualMachinePoolRuntimeViewResource :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResource,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider.
        /// If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        /// Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)Property).InstanceCountSummary; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>Internal Acessors for InstanceCountSummary</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceInternal.InstanceCountSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)Property).InstanceCountSummary; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)Property).InstanceCountSummary = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolRuntimeViewResourceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolRuntimeViewResourceProperties()); set => this._property = value; }

        /// <summary>Displays the provisioning state of the standby pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>
        /// Creates an new <see cref="StandbyVirtualMachinePoolRuntimeViewResource" /> instance.
        /// </summary>
        public StandbyVirtualMachinePoolRuntimeViewResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Contains information about a standby virtual machine pool as last known by the StandbyPool resource provider.
    public partial interface IStandbyVirtualMachinePoolRuntimeViewResource :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResource
    {
        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider.
        /// If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        /// Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
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
    /// Contains information about a standby virtual machine pool as last known by the StandbyPool resource provider.
    internal partial interface IStandbyVirtualMachinePoolRuntimeViewResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IProxyResourceInternal
    {
        /// <summary>
        /// A list containing the counts of virtual machines in each possible power state for each zone if enabled, as known by the
        /// StandbyPool resource provider.
        /// If zones are not enabled on the attached VMSS, the list will contain a single entry with null zone values.
        /// Note: any updates to pool resources outside of StandbyPoolRP (i.e deleting a VM through portal) are not reflected here.
        /// Note: any resources in the Running state may still be installing extensions / not fully provisioned.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary> InstanceCountSummary { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties Property { get; set; }
        /// <summary>Displays the provisioning state of the standby pool</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }

    }
}