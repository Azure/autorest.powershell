// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Recovery point specific to PointInTime</summary>
    public partial class AzureWorkloadSqlPointInTimeRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlPointInTimeRecoveryPoint,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlPointInTimeRecoveryPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPoint"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPoint __azureWorkloadSqlRecoveryPoint = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSqlRecoveryPoint();

        /// <summary>
        /// Extended Info that provides data directory details. Will be populated in two cases:
        /// When a specific recovery point is accessed using GetRecoveryPoint
        /// Or when ListRecoveryPoints is called for Log RP only with ExtendedInfo query filter
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo ExtendedInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfo = value ?? null /* model class */; }

        /// <summary>List of data directory paths during restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> ExtendedInfoDataDirectoryPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfoDataDirectoryPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfoDataDirectoryPath = value ?? null /* arrayOf */; }

        /// <summary>UTC time at which data directory info was captured</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? ExtendedInfoDataDirectoryTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfoDataDirectoryTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfoDataDirectoryTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for RecoveryPointProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal.RecoveryPointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal.ExtendedInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ExtendedInfo = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadSQLPointInTimeRecoveryPoint"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).ObjectType = "AzureWorkloadSQLPointInTimeRecoveryPoint"; }

        /// <summary>Eligibility of RP to be moved to another tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo RecoveryPointMoveReadinessInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointMoveReadinessInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointMoveReadinessInfo = value ?? null /* model class */; }

        /// <summary>Properties of Recovery Point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties RecoveryPointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointProperty = value ?? null /* model class */; }

        /// <summary>Expiry time of Recovery Point in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointPropertyExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointPropertyExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointPropertyExpiryTime = value ?? null; }

        /// <summary>Bool to indicate whether RP is in soft delete state or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? RecoveryPointPropertyIsSoftDeleted { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointPropertyIsSoftDeleted; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointPropertyIsSoftDeleted = value ?? default(bool); }

        /// <summary>Rule name tagged on Recovery Point that governs life cycle</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointPropertyRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointPropertyRuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointPropertyRuleName = value ?? null; }

        /// <summary>Recovery point tier information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> RecoveryPointTierDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointTierDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointTierDetail = value ?? null /* arrayOf */; }

        /// <summary>UTC time at which recovery point was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? RecoveryPointTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).RecoveryPointTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Backing field for <see cref="TimeRange" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange> _timeRange;

        /// <summary>List of log ranges</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange> TimeRange { get => this._timeRange; set => this._timeRange = value; }

        /// <summary>Type of restore point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadSqlRecoveryPoint).Type = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="AzureWorkloadSqlPointInTimeRecoveryPoint" /> instance.
        /// </summary>
        public AzureWorkloadSqlPointInTimeRecoveryPoint()
        {
            this.__azureWorkloadSqlRecoveryPoint.ObjectType = "AzureWorkloadSQLPointInTimeRecoveryPoint";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadSqlRecoveryPoint), __azureWorkloadSqlRecoveryPoint);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadSqlRecoveryPoint), __azureWorkloadSqlRecoveryPoint);
        }
    }
    /// Recovery point specific to PointInTime
    public partial interface IAzureWorkloadSqlPointInTimeRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPoint
    {
        /// <summary>List of log ranges</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of log ranges",
        SerializedName = @"timeRanges",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange> TimeRange { get; set; }

    }
    /// Recovery point specific to PointInTime
    internal partial interface IAzureWorkloadSqlPointInTimeRecoveryPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal
    {
        /// <summary>List of log ranges</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange> TimeRange { get; set; }

    }
}