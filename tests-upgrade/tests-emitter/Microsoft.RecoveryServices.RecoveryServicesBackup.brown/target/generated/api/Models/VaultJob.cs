// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Vault level Job</summary>
    public partial class VaultJob :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJob,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob __job = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.Job();

        /// <summary>Backing field for <see cref="ActionsInfo" /> property.</summary>
        private System.Collections.Generic.List<string> _actionsInfo;

        /// <summary>Gets or sets the state/actions applicable on this job like cancel/retry.</summary>
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

        /// <summary>Time elapsed during the execution of this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.TimeSpan? Duration { get => this._duration; set => this._duration = value; }

        /// <summary>The end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Friendly name of the entity on which the current job is executing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string EntityFriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EntityFriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).EntityFriendlyName = value ?? null; }

        /// <summary>Backing field for <see cref="ErrorDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfo> _errorDetail;

        /// <summary>Error details on execution of this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfo> ErrorDetail { get => this._errorDetail; set => this._errorDetail = value; }

        /// <summary>Backing field for <see cref="ExtendedInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfo _extendedInfo;

        /// <summary>Additional information about the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfo ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.VaultJobExtendedInfo()); set => this._extendedInfo = value; }

        /// <summary>Job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoInternal)ExtendedInfo).PropertyBag; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoInternal)ExtendedInfo).PropertyBag = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobInternal.ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.VaultJobExtendedInfo()); set { {_extendedInfo = value;} } }

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
        public string Type { get => "VaultJob"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)__job).Type = "VaultJob"; }

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

        /// <summary>Creates an new <see cref="VaultJob" /> instance.</summary>
        public VaultJob()
        {
            this.__job.Type = "VaultJob";
        }
    }
    /// Vault level Job
    public partial interface IVaultJob :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJob
    {
        /// <summary>Gets or sets the state/actions applicable on this job like cancel/retry.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the state/actions applicable on this job like cancel/retry.",
        SerializedName = @"actionsInfo",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Cancellable", "Retriable")]
        System.Collections.Generic.List<string> ActionsInfo { get; set; }
        /// <summary>Time elapsed during the execution of this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Time elapsed during the execution of this job.",
        SerializedName = @"duration",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? Duration { get; set; }
        /// <summary>Error details on execution of this job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Error details on execution of this job.",
        SerializedName = @"errorDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfo> ErrorDetail { get; set; }
        /// <summary>Job properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Job properties.",
        SerializedName = @"propertyBag",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get; set; }

    }
    /// Vault level Job
    internal partial interface IVaultJobInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal
    {
        /// <summary>Gets or sets the state/actions applicable on this job like cancel/retry.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Cancellable", "Retriable")]
        System.Collections.Generic.List<string> ActionsInfo { get; set; }
        /// <summary>Time elapsed during the execution of this job.</summary>
        global::System.TimeSpan? Duration { get; set; }
        /// <summary>Error details on execution of this job.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobErrorInfo> ErrorDetail { get; set; }
        /// <summary>Additional information about the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfo ExtendedInfo { get; set; }
        /// <summary>Job properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IVaultJobExtendedInfoPropertyBag ExtendedInfoPropertyBag { get; set; }

    }
}