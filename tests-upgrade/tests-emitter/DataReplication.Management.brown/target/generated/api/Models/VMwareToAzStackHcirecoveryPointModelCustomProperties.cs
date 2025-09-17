// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>VMware to AzStackHCI recovery point model custom properties.</summary>
    public partial class VMwareToAzStackHcirecoveryPointModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcirecoveryPointModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcirecoveryPointModelCustomPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryPointModelCustomProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryPointModelCustomProperties __recoveryPointModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.RecoveryPointModelCustomProperties();

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private System.Collections.Generic.List<string> _diskId;

        /// <summary>Gets or sets the list of the disk Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> DiskId { get => this._diskId; }

        /// <summary>Discriminator property for RecoveryPointModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string InstanceType { get => "VMwareToAzStackHCIRecoveryPointModelCustomProperties"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryPointModelCustomPropertiesInternal)__recoveryPointModelCustomProperties).InstanceType = "VMwareToAzStackHCIRecoveryPointModelCustomProperties"; }

        /// <summary>Internal Acessors for DiskId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcirecoveryPointModelCustomPropertiesInternal.DiskId { get => this._diskId; set { {_diskId = value;} } }

        /// <summary>
        /// Creates an new <see cref="VMwareToAzStackHcirecoveryPointModelCustomProperties" /> instance.
        /// </summary>
        public VMwareToAzStackHcirecoveryPointModelCustomProperties()
        {
            this.__recoveryPointModelCustomProperties.InstanceType = "VMwareToAzStackHCIRecoveryPointModelCustomProperties";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__recoveryPointModelCustomProperties), __recoveryPointModelCustomProperties);
            await eventListener.AssertObjectIsValid(nameof(__recoveryPointModelCustomProperties), __recoveryPointModelCustomProperties);
        }
    }
    /// VMware to AzStackHCI recovery point model custom properties.
    public partial interface IVMwareToAzStackHcirecoveryPointModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryPointModelCustomProperties
    {
        /// <summary>Gets or sets the list of the disk Ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of the disk Ids.",
        SerializedName = @"diskIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DiskId { get;  }

    }
    /// VMware to AzStackHCI recovery point model custom properties.
    internal partial interface IVMwareToAzStackHcirecoveryPointModelCustomPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryPointModelCustomPropertiesInternal
    {
        /// <summary>Gets or sets the list of the disk Ids.</summary>
        System.Collections.Generic.List<string> DiskId { get; set; }

    }
}