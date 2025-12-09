// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// SQL specific recoverypoint, specifically encapsulates full/diff recoverypoint along with extended info
    /// </summary>
    public partial class AzureWorkloadSqlRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPoint,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPoint"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPoint __azureWorkloadRecoveryPoint = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRecoveryPoint();

        /// <summary>Backing field for <see cref="ExtendedInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo _extendedInfo;

        /// <summary>
        /// Extended Info that provides data directory details. Will be populated in two cases:
        /// When a specific recovery point is accessed using GetRecoveryPoint
        /// Or when ListRecoveryPoints is called for Log RP only with ExtendedInfo query filter
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSqlRecoveryPointExtendedInfo()); set => this._extendedInfo = value; }

        /// <summary>List of data directory paths during restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> ExtendedInfoDataDirectoryPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfoInternal)ExtendedInfo).DataDirectoryPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfoInternal)ExtendedInfo).DataDirectoryPath = value ?? null /* arrayOf */; }

        /// <summary>UTC time at which data directory info was captured</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExtendedInfoDataDirectoryTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfoInternal)ExtendedInfo).DataDirectoryTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfoInternal)ExtendedInfo).DataDirectoryTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for RecoveryPointProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal.RecoveryPointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ExtendedInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointInternal.ExtendedInfo { get => (this._extendedInfo = this._extendedInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadSqlRecoveryPointExtendedInfo()); set { {_extendedInfo = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadSQLRecoveryPoint"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)__azureWorkloadRecoveryPoint).ObjectType = "AzureWorkloadSQLRecoveryPoint"; }

        /// <summary>Eligibility of RP to be moved to another tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo RecoveryPointMoveReadinessInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointMoveReadinessInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointMoveReadinessInfo = value ?? null /* model class */; }

        /// <summary>Properties of Recovery Point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties RecoveryPointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointProperty = value ?? null /* model class */; }

        /// <summary>Expiry time of Recovery Point in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointPropertyExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointPropertyExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointPropertyExpiryTime = value ?? null; }

        /// <summary>Bool to indicate whether RP is in soft delete state or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? RecoveryPointPropertyIsSoftDeleted { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointPropertyIsSoftDeleted; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointPropertyIsSoftDeleted = value ?? default(bool); }

        /// <summary>Rule name tagged on Recovery Point that governs life cycle</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointPropertyRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointPropertyRuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointPropertyRuleName = value ?? null; }

        /// <summary>Recovery point tier information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> RecoveryPointTierDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointTierDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointTierDetail = value ?? null /* arrayOf */; }

        /// <summary>UTC time at which recovery point was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? RecoveryPointTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).RecoveryPointTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Type of restore point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadRecoveryPoint).Type = value ?? null; }

        /// <summary>Creates an new <see cref="AzureWorkloadSqlRecoveryPoint" /> instance.</summary>
        public AzureWorkloadSqlRecoveryPoint()
        {
            this.__azureWorkloadRecoveryPoint.ObjectType = "AzureWorkloadSQLRecoveryPoint";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadRecoveryPoint), __azureWorkloadRecoveryPoint);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadRecoveryPoint), __azureWorkloadRecoveryPoint);
        }
    }
    /// SQL specific recoverypoint, specifically encapsulates full/diff recoverypoint along with extended info
    public partial interface IAzureWorkloadSqlRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPoint
    {
        /// <summary>List of data directory paths during restore operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of data directory paths during restore operation.",
        SerializedName = @"dataDirectoryPaths",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> ExtendedInfoDataDirectoryPath { get; set; }
        /// <summary>UTC time at which data directory info was captured</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UTC time at which data directory info was captured",
        SerializedName = @"dataDirectoryTimeInUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExtendedInfoDataDirectoryTimeInUtc { get; set; }

    }
    /// SQL specific recoverypoint, specifically encapsulates full/diff recoverypoint along with extended info
    internal partial interface IAzureWorkloadSqlRecoveryPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal
    {
        /// <summary>
        /// Extended Info that provides data directory details. Will be populated in two cases:
        /// When a specific recovery point is accessed using GetRecoveryPoint
        /// Or when ListRecoveryPoints is called for Log RP only with ExtendedInfo query filter
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSqlRecoveryPointExtendedInfo ExtendedInfo { get; set; }
        /// <summary>List of data directory paths during restore operation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISqlDataDirectory> ExtendedInfoDataDirectoryPath { get; set; }
        /// <summary>UTC time at which data directory info was captured</summary>
        global::System.DateTime? ExtendedInfoDataDirectoryTimeInUtc { get; set; }

    }
}