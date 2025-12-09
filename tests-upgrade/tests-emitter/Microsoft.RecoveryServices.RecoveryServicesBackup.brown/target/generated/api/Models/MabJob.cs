// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>MAB workload-specific job.</summary>
    public partial class MabJob :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJob,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob __job = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Job();

        /// <summary>Backing field for <see cref="ActionsInfo" /> property.</summary>
        private System.Collections.Generic.List<string> _actionsInfo;

        /// <summary>The state/actions applicable on jobs like cancel/retry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ActionsInfo { get => this._actionsInfo; set => this._actionsInfo = value; }

        /// <summary>ActivityId of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).ActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).ActivityId = value ?? null; }

        /// <summary>Backup management type to execute the current job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).BackupManagementType = value ?? null; }

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private global::System.TimeSpan? _duration;

        /// <summary>Time taken by job to run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.TimeSpan? Duration { get => this._duration; set => this._duration = value; }

        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Friendly name of the entity on which the current job is executing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EntityFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EntityFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EntityFriendlyName = value ?? null; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo> _errorDetail;

        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo> ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Backing field for <see cref="ExtendedInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfo _extendedInfo;

        /// <summary>Additional information on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfo ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobExtendedInfo()); set => this._extendedInfo = value; }

        /// <summary>Non localized error message specific to this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoDynamicErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoInternal)ExtendedInfo).DynamicErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoInternal)ExtendedInfo).DynamicErrorMessage = value ?? null; }

        /// <summary>The job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoInternal)ExtendedInfo).PropertyBag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoInternal)ExtendedInfo).PropertyBag = value ?? null /* model class */; }

        /// <summary>List of tasks for this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails> ExtendedInfoTasksList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoInternal)ExtendedInfo).TasksList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoInternal)ExtendedInfo).TasksList = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="MabServerName" /> property.</summary>
        private string _mabServerName;

        /// <summary>Name of server protecting the DS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string MabServerName { get => this._mabServerName; set => this._mabServerName = value; }

        /// <summary>Backing field for <see cref="MabServerType" /> property.</summary>
        private string _mabServerType;

        /// <summary>Server type of MAB container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string MabServerType { get => this._mabServerType; set => this._mabServerType = value; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal.ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobExtendedInfo()); set { {_extendedInfo = value;} } }

        /// <summary>The operation name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Operation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Operation = value ?? null; }

        /// <summary>The start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Job status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Status = value ?? null; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => "MabJob"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Type = "MabJob"; }

        /// <summary>Backing field for <see cref="WorkloadType" /> property.</summary>
        private string _workloadType;

        /// <summary>Workload type of backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string WorkloadType { get => this._workloadType; set => this._workloadType = value; }

        /// <summary>Creates an new <see cref="MabJob" /> instance.</summary>
        public MabJob()
        {
            this.__job.Type = "MabJob";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__job), __job);
            await eventListener.AssertObjectIsValid(nameof(__job), __job);
        }
    }
    /// MAB workload-specific job.
    public partial interface IMabJob :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob
    {
        /// <summary>The state/actions applicable on jobs like cancel/retry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The state/actions applicable on jobs like cancel/retry.",
        SerializedName = @"actionsInfo",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Cancellable", "Retriable")]
        System.Collections.Generic.List<string> ActionsInfo { get; set; }
        /// <summary>Time taken by job to run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time taken by job to run.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? Duration { get; set; }
        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The errors.",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo> ErrorDetail { get; set; }
        /// <summary>Non localized error message specific to this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Non localized error message specific to this job.",
        SerializedName = @"dynamicErrorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedInfoDynamicErrorMessage { get; set; }
        /// <summary>The job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The job properties.",
        SerializedName = @"propertyBag",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get; set; }
        /// <summary>List of tasks for this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of tasks for this job.",
        SerializedName = @"tasksList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails> ExtendedInfoTasksList { get; set; }
        /// <summary>Name of server protecting the DS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of server protecting the DS.",
        SerializedName = @"mabServerName",
        PossibleTypes = new [] { typeof(string) })]
        string MabServerName { get; set; }
        /// <summary>Server type of MAB container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Server type of MAB container.",
        SerializedName = @"mabServerType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Unknown", "IaasVMContainer", "IaasVMServiceContainer", "DPMContainer", "AzureBackupServerContainer", "MABContainer", "Cluster", "AzureSqlContainer", "Windows", "VCenter", "VMAppContainer", "SQLAGWorkLoadContainer", "StorageContainer", "GenericContainer")]
        string MabServerType { get; set; }
        /// <summary>Workload type of backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Workload type of backup item.",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkloadType { get; set; }

    }
    /// MAB workload-specific job.
    internal partial interface IMabJobInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal
    {
        /// <summary>The state/actions applicable on jobs like cancel/retry.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Cancellable", "Retriable")]
        System.Collections.Generic.List<string> ActionsInfo { get; set; }
        /// <summary>Time taken by job to run.</summary>
        global::System.TimeSpan? Duration { get; set; }
        /// <summary>The errors.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo> ErrorDetail { get; set; }
        /// <summary>Additional information on the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfo ExtendedInfo { get; set; }
        /// <summary>Non localized error message specific to this job.</summary>
        string ExtendedInfoDynamicErrorMessage { get; set; }
        /// <summary>The job properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get; set; }
        /// <summary>List of tasks for this job.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails> ExtendedInfoTasksList { get; set; }
        /// <summary>Name of server protecting the DS.</summary>
        string MabServerName { get; set; }
        /// <summary>Server type of MAB container.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Unknown", "IaasVMContainer", "IaasVMServiceContainer", "DPMContainer", "AzureBackupServerContainer", "MABContainer", "Cluster", "AzureSqlContainer", "Windows", "VCenter", "VMAppContainer", "SQLAGWorkLoadContainer", "StorageContainer", "GenericContainer")]
        string MabServerType { get; set; }
        /// <summary>Workload type of backup item.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "VM", "FileFolder", "AzureSqlDb", "SQLDB", "Exchange", "Sharepoint", "VMwareVM", "SystemState", "Client", "GenericDataSource", "SQLDataBase", "AzureFileShare", "SAPHanaDatabase", "SAPAseDatabase", "SAPHanaDBInstance")]
        string WorkloadType { get; set; }

    }
}