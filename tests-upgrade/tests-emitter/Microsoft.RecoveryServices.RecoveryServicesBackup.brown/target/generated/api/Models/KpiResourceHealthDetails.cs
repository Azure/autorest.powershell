// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>KPI Resource Health Details</summary>
    public partial class KpiResourceHealthDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKpiResourceHealthDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKpiResourceHealthDetailsInternal
    {

        /// <summary>Backing field for <see cref="ResourceHealthDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails> _resourceHealthDetail;

        /// <summary>Resource Health Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails> ResourceHealthDetail { get => this._resourceHealthDetail; set => this._resourceHealthDetail = value; }

        /// <summary>Backing field for <see cref="ResourceHealthStatus" /> property.</summary>
        private string _resourceHealthStatus;

        /// <summary>Resource Health Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ResourceHealthStatus { get => this._resourceHealthStatus; set => this._resourceHealthStatus = value; }

        /// <summary>Creates an new <see cref="KpiResourceHealthDetails" /> instance.</summary>
        public KpiResourceHealthDetails()
        {

        }
    }
    /// KPI Resource Health Details
    public partial interface IKpiResourceHealthDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Resource Health Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Health Status",
        SerializedName = @"resourceHealthDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails> ResourceHealthDetail { get; set; }
        /// <summary>Resource Health Status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Health Status",
        SerializedName = @"resourceHealthStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Healthy", "TransientDegraded", "PersistentDegraded", "TransientUnhealthy", "PersistentUnhealthy", "Invalid")]
        string ResourceHealthStatus { get; set; }

    }
    /// KPI Resource Health Details
    internal partial interface IKpiResourceHealthDetailsInternal

    {
        /// <summary>Resource Health Status</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IResourceHealthDetails> ResourceHealthDetail { get; set; }
        /// <summary>Resource Health Status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Healthy", "TransientDegraded", "PersistentDegraded", "TransientUnhealthy", "PersistentUnhealthy", "Invalid")]
        string ResourceHealthStatus { get; set; }

    }
}