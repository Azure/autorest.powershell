// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>DPM workload-specific job object.</summary>
    public partial class DpmJob :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJob,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob __job = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Job();

        /// <summary>Backing field for <see cref="ActionsInfo" /> property.</summary>
        private System.Collections.Generic.List<string> _actionsInfo;

        /// <summary>The state/actions applicable on this job like cancel/retry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ActionsInfo { get => this._actionsInfo; set => this._actionsInfo = value; }

        /// <summary>ActivityId of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).ActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).ActivityId = value ?? null; }

        /// <summary>Backup management type to execute the current job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string BackupManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).BackupManagementType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).BackupManagementType = value ?? null; }

        /// <summary>Backing field for <see cref="ContainerName" /> property.</summary>
        private string _containerName;

        /// <summary>Name of cluster/server protecting current backup item, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ContainerName { get => this._containerName; set => this._containerName = value; }

        /// <summary>Backing field for <see cref="ContainerType" /> property.</summary>
        private string _containerType;

        /// <summary>Type of container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string ContainerType { get => this._containerType; set => this._containerType = value; }

        /// <summary>Backing field for <see cref="DpmServerName" /> property.</summary>
        private string _dpmServerName;

        /// <summary>DPM server name managing the backup item or backup job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string DpmServerName { get => this._dpmServerName; set => this._dpmServerName = value; }

        /// <summary>Backing field for <see cref="Duration" /> property.</summary>
        private global::System.TimeSpan? _duration;

        /// <summary>Time elapsed for job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.TimeSpan? Duration { get => this._duration; set => this._duration = value; }

        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Friendly name of the entity on which the current job is executing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EntityFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EntityFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EntityFriendlyName = value ?? null; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfo> _errorDetail;

        /// <summary>The errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfo> ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Backing field for <see cref="ExtendedInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfo _extendedInfo;

        /// <summary>Additional information for this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfo ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmJobExtendedInfo()); set => this._extendedInfo = value; }

        /// <summary>Non localized error message on job execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ExtendedInfoDynamicErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoInternal)ExtendedInfo).DynamicErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoInternal)ExtendedInfo).DynamicErrorMessage = value ?? null; }

        /// <summary>The job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoInternal)ExtendedInfo).PropertyBag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoInternal)ExtendedInfo).PropertyBag = value ?? null /* model class */; }

        /// <summary>List of tasks associated with this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobTaskDetails> ExtendedInfoTasksList { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoInternal)ExtendedInfo).TasksList; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoInternal)ExtendedInfo).TasksList = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobInternal.ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DpmJobExtendedInfo()); set { {_extendedInfo = value;} } }

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
        public string Type { get => "DpmJob"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Type = "DpmJob"; }

        /// <summary>Backing field for <see cref="WorkloadType" /> property.</summary>
        private string _workloadType;

        /// <summary>Type of backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string WorkloadType { get => this._workloadType; set => this._workloadType = value; }

        /// <summary>Creates an new <see cref="DpmJob" /> instance.</summary>
        public DpmJob()
        {
            this.__job.Type = "DpmJob";
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
    /// DPM workload-specific job object.
    public partial interface IDpmJob :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob
    {
        /// <summary>The state/actions applicable on this job like cancel/retry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The state/actions applicable on this job like cancel/retry.",
        SerializedName = @"actionsInfo",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Cancellable", "Retriable")]
        System.Collections.Generic.List<string> ActionsInfo { get; set; }
        /// <summary>Name of cluster/server protecting current backup item, if any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of cluster/server protecting current backup item, if any.",
        SerializedName = @"containerName",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerName { get; set; }
        /// <summary>Type of container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of container.",
        SerializedName = @"containerType",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerType { get; set; }
        /// <summary>DPM server name managing the backup item or backup job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DPM server name managing the backup item or backup job.",
        SerializedName = @"dpmServerName",
        PossibleTypes = new [] { typeof(string) })]
        string DpmServerName { get; set; }
        /// <summary>Time elapsed for job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time elapsed for job.",
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfo> ErrorDetail { get; set; }
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoPropertyBag) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get; set; }
        /// <summary>List of tasks associated with this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of tasks associated with this job.",
        SerializedName = @"tasksList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobTaskDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobTaskDetails> ExtendedInfoTasksList { get; set; }
        /// <summary>Type of backup item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of backup item.",
        SerializedName = @"workloadType",
        PossibleTypes = new [] { typeof(string) })]
        string WorkloadType { get; set; }

    }
    /// DPM workload-specific job object.
    internal partial interface IDpmJobInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal
    {
        /// <summary>The state/actions applicable on this job like cancel/retry.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Cancellable", "Retriable")]
        System.Collections.Generic.List<string> ActionsInfo { get; set; }
        /// <summary>Name of cluster/server protecting current backup item, if any.</summary>
        string ContainerName { get; set; }
        /// <summary>Type of container.</summary>
        string ContainerType { get; set; }
        /// <summary>DPM server name managing the backup item or backup job.</summary>
        string DpmServerName { get; set; }
        /// <summary>Time elapsed for job.</summary>
        global::System.TimeSpan? Duration { get; set; }
        /// <summary>The errors.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmErrorInfo> ErrorDetail { get; set; }
        /// <summary>Additional information for this job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfo ExtendedInfo { get; set; }
        /// <summary>Non localized error message on job execution.</summary>
        string ExtendedInfoDynamicErrorMessage { get; set; }
        /// <summary>The job properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get; set; }
        /// <summary>List of tasks associated with this job.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDpmJobTaskDetails> ExtendedInfoTasksList { get; set; }
        /// <summary>Type of backup item.</summary>
        string WorkloadType { get; set; }

    }
}