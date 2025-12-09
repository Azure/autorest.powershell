// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>List of WorkloadProtectableItem resources</summary>
    public partial class WorkloadProtectableItemResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResourceListInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceList"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceList __resourceList = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ResourceList();

        /// <summary>
        /// The URI to fetch the next page of resources, with each API call returning up to 200 resources per page. Use ListNext()
        /// to fetch the next page if the total number of resources exceeds 200.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string NextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceListInternal)__resourceList).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceListInternal)__resourceList).NextLink = value ?? null; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResource> _value;

        /// <summary>List of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceList), __resourceList);
            await eventListener.AssertObjectIsValid(nameof(__resourceList), __resourceList);
        }

        /// <summary>Creates an new <see cref="WorkloadProtectableItemResourceList" /> instance.</summary>
        public WorkloadProtectableItemResourceList()
        {

        }
    }
    /// List of WorkloadProtectableItem resources
    public partial interface IWorkloadProtectableItemResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceList
    {
        /// <summary>List of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of resources.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResource> Value { get; set; }

    }
    /// List of WorkloadProtectableItem resources
    internal partial interface IWorkloadProtectableItemResourceListInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceListInternal
    {
        /// <summary>List of resources.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadProtectableItemResource> Value { get; set; }

    }
}