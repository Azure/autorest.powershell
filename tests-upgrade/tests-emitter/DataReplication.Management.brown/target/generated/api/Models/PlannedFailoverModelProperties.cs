// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Planned failover model properties.</summary>
    public partial class PlannedFailoverModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CustomProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties _customProperty;

        /// <summary>Planned failover model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties()); set => this._customProperty = value; }

        /// <summary>Discriminator property for PlannedFailoverModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomPropertiesInternal)CustomProperty).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomPropertiesInternal)CustomProperty).InstanceType = value ; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelPropertiesInternal.CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.PlannedFailoverModelCustomProperties()); set { {_customProperty = value;} } }

        /// <summary>Creates an new <see cref="PlannedFailoverModelProperties" /> instance.</summary>
        public PlannedFailoverModelProperties()
        {

        }
    }
    /// Planned failover model properties.
    public partial interface IPlannedFailoverModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Discriminator property for PlannedFailoverModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for PlannedFailoverModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }

    }
    /// Planned failover model properties.
    internal partial interface IPlannedFailoverModelPropertiesInternal

    {
        /// <summary>Planned failover model custom properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPlannedFailoverModelCustomProperties CustomProperty { get; set; }
        /// <summary>Discriminator property for PlannedFailoverModelCustomProperties.</summary>
        string CustomPropertyInstanceType { get; set; }

    }
}