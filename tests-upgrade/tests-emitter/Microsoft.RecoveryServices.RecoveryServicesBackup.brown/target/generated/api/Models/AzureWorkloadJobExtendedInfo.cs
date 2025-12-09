// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Azure VM workload-specific additional information for job.</summary>
    public partial class AzureWorkloadJobExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfo,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfoInternal
    {

        /// <summary>Backing field for <see cref="DynamicErrorMessage" /> property.</summary>
        private string _dynamicErrorMessage;

        /// <summary>Non localized error message on job execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string DynamicErrorMessage { get => this._dynamicErrorMessage; set => this._dynamicErrorMessage = value; }

        /// <summary>Backing field for <see cref="PropertyBag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfoPropertyBag _propertyBag;

        /// <summary>Job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfoPropertyBag PropertyBag { get => (this._propertyBag = this._propertyBag ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadJobExtendedInfoPropertyBag()); set => this._propertyBag = value; }

        /// <summary>Backing field for <see cref="TasksList" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobTaskDetails> _tasksList;

        /// <summary>List of tasks for this job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobTaskDetails> TasksList { get => this._tasksList; set => this._tasksList = value; }

        /// <summary>Creates an new <see cref="AzureWorkloadJobExtendedInfo" /> instance.</summary>
        public AzureWorkloadJobExtendedInfo()
        {

        }
    }
    /// Azure VM workload-specific additional information for job.
    public partial interface IAzureWorkloadJobExtendedInfo :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Non localized error message on job execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Non localized error message on job execution.",
        SerializedName = @"dynamicErrorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string DynamicErrorMessage { get; set; }
        /// <summary>Job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Job properties.",
        SerializedName = @"propertyBag",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfoPropertyBag) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfoPropertyBag PropertyBag { get; set; }
        /// <summary>List of tasks for this job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of tasks for this job",
        SerializedName = @"tasksList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobTaskDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobTaskDetails> TasksList { get; set; }

    }
    /// Azure VM workload-specific additional information for job.
    internal partial interface IAzureWorkloadJobExtendedInfoInternal

    {
        /// <summary>Non localized error message on job execution.</summary>
        string DynamicErrorMessage { get; set; }
        /// <summary>Job properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobExtendedInfoPropertyBag PropertyBag { get; set; }
        /// <summary>List of tasks for this job</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadJobTaskDetails> TasksList { get; set; }

    }
}