// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Test failover job model custom properties.</summary>
    public partial class TestFailoverJobModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITestFailoverJobModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITestFailoverJobModelCustomPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties __jobModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.JobModelCustomProperties();

        /// <summary>Gets or sets any custom properties of the affected object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails AffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetailDescription; }

        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetailType; }

        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string InstanceType { get => "TestFailoverJobDetails"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).InstanceType = "TestFailoverJobDetails"; }

        /// <summary>Internal Acessors for AffectedObjectDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal.AffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for AffectedObjectDetailDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal.AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetailDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetailDescription = value ?? null; }

        /// <summary>Internal Acessors for AffectedObjectDetailType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal.AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetailType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)__jobModelCustomProperties).AffectedObjectDetailType = value ?? null; }

        /// <summary>Internal Acessors for ProtectedItemDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFailoverProtectedItemProperties> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITestFailoverJobModelCustomPropertiesInternal.ProtectedItemDetail { get => this._protectedItemDetail; set { {_protectedItemDetail = value;} } }

        /// <summary>Backing field for <see cref="ProtectedItemDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFailoverProtectedItemProperties> _protectedItemDetail;

        /// <summary>Gets or sets the test VM details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFailoverProtectedItemProperties> ProtectedItemDetail { get => this._protectedItemDetail; }

        /// <summary>Creates an new <see cref="TestFailoverJobModelCustomProperties" /> instance.</summary>
        public TestFailoverJobModelCustomProperties()
        {
            this.__jobModelCustomProperties.InstanceType = "TestFailoverJobDetails";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobModelCustomProperties), __jobModelCustomProperties);
            await eventListener.AssertObjectIsValid(nameof(__jobModelCustomProperties), __jobModelCustomProperties);
        }
    }
    /// Test failover job model custom properties.
    public partial interface ITestFailoverJobModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties
    {
        /// <summary>Gets or sets the test VM details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the test VM details.",
        SerializedName = @"protectedItemDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFailoverProtectedItemProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFailoverProtectedItemProperties> ProtectedItemDetail { get;  }

    }
    /// Test failover job model custom properties.
    internal partial interface ITestFailoverJobModelCustomPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal
    {
        /// <summary>Gets or sets the test VM details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFailoverProtectedItemProperties> ProtectedItemDetail { get; set; }

    }
}