// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>HyperV to AzStackHCI planned failover model custom properties.</summary>
    public partial class HyperVToAzStackHciplannedFailoverModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciplannedFailoverModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciplannedFailoverModelCustomPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties __plannedFailoverModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties();

        /// <summary>Discriminator property for PlannedFailoverModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string InstanceType { get => "HyperVToAzStackHCI"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomPropertiesInternal)__plannedFailoverModelCustomProperties).InstanceType = "HyperVToAzStackHCI"; }

        /// <summary>Backing field for <see cref="ShutdownSourceVM" /> property.</summary>
        private bool _shutdownSourceVM;

        /// <summary>Gets or sets a value indicating whether VM needs to be shut down.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool ShutdownSourceVM { get => this._shutdownSourceVM; set => this._shutdownSourceVM = value; }

        /// <summary>
        /// Creates an new <see cref="HyperVToAzStackHciplannedFailoverModelCustomProperties" /> instance.
        /// </summary>
        public HyperVToAzStackHciplannedFailoverModelCustomProperties()
        {
            this.__plannedFailoverModelCustomProperties.InstanceType = "HyperVToAzStackHCI";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__plannedFailoverModelCustomProperties), __plannedFailoverModelCustomProperties);
            await eventListener.AssertObjectIsValid(nameof(__plannedFailoverModelCustomProperties), __plannedFailoverModelCustomProperties);
        }
    }
    /// HyperV to AzStackHCI planned failover model custom properties.
    public partial interface IHyperVToAzStackHciplannedFailoverModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties
    {
        /// <summary>Gets or sets a value indicating whether VM needs to be shut down.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets a value indicating whether VM needs to be shut down.",
        SerializedName = @"shutdownSourceVM",
        PossibleTypes = new [] { typeof(bool) })]
        bool ShutdownSourceVM { get; set; }

    }
    /// HyperV to AzStackHCI planned failover model custom properties.
    internal partial interface IHyperVToAzStackHciplannedFailoverModelCustomPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomPropertiesInternal
    {
        /// <summary>Gets or sets a value indicating whether VM needs to be shut down.</summary>
        bool ShutdownSourceVM { get; set; }

    }
}