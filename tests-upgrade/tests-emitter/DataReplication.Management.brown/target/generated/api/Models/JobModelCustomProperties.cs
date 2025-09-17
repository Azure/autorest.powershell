// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Job model custom properties.</summary>
    public partial class JobModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AffectedObjectDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails _affectedObjectDetail;

        /// <summary>Gets or sets any custom properties of the affected object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails AffectedObjectDetail { get => (this._affectedObjectDetail = this._affectedObjectDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AffectedObjectDetails()); }

        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal)AffectedObjectDetail).Description; }

        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal)AffectedObjectDetail).Type; }

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Internal Acessors for AffectedObjectDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal.AffectedObjectDetail { get => (this._affectedObjectDetail = this._affectedObjectDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.AffectedObjectDetails()); set { {_affectedObjectDetail = value;} } }

        /// <summary>Internal Acessors for AffectedObjectDetailDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal.AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal)AffectedObjectDetail).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal)AffectedObjectDetail).Description = value ?? null; }

        /// <summary>Internal Acessors for AffectedObjectDetailType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal.AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal)AffectedObjectDetail).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetailsInternal)AffectedObjectDetail).Type = value ?? null; }

        /// <summary>Creates an new <see cref="JobModelCustomProperties" /> instance.</summary>
        public JobModelCustomProperties()
        {

        }
    }
    /// Job model custom properties.
    public partial interface IJobModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Description of the affected object details.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string AffectedObjectDetailDescription { get;  }
        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of the affected object details.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("object")]
        string AffectedObjectDetailType { get;  }
        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for JobModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Job model custom properties.
    internal partial interface IJobModelCustomPropertiesInternal

    {
        /// <summary>Gets or sets any custom properties of the affected object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails AffectedObjectDetail { get; set; }
        /// <summary>Description of the affected object details.</summary>
        string AffectedObjectDetailDescription { get; set; }
        /// <summary>Type of the affected object details.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("object")]
        string AffectedObjectDetailType { get; set; }
        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        string InstanceType { get; set; }

    }
}