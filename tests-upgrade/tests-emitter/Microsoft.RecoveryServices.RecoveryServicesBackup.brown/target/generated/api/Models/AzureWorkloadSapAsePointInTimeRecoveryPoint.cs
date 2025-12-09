// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Recovery point specific to PointInTime in SAPAse</summary>
    public partial class AzureWorkloadSapAsePointInTimeRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapAsePointInTimeRecoveryPoint,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadSapAsePointInTimeRecoveryPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPoint"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPoint __azureWorkloadPointInTimeRecoveryPoint = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadPointInTimeRecoveryPoint();

        /// <summary>Internal Acessors for RecoveryPointProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal.RecoveryPointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointProperty = value ?? null /* model class */; }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadSAPAsePointInTimeRecoveryPoint"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).ObjectType = "AzureWorkloadSAPAsePointInTimeRecoveryPoint"; }

        /// <summary>Eligibility of RP to be moved to another tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo RecoveryPointMoveReadinessInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointMoveReadinessInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointMoveReadinessInfo = value ?? null /* model class */; }

        /// <summary>Properties of Recovery Point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties RecoveryPointProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointProperty = value ?? null /* model class */; }

        /// <summary>Expiry time of Recovery Point in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointPropertyExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointPropertyExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointPropertyExpiryTime = value ?? null; }

        /// <summary>Bool to indicate whether RP is in soft delete state or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public bool? RecoveryPointPropertyIsSoftDeleted { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointPropertyIsSoftDeleted; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointPropertyIsSoftDeleted = value ?? default(bool); }

        /// <summary>Rule name tagged on Recovery Point that governs life cycle</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string RecoveryPointPropertyRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointPropertyRuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointPropertyRuleName = value ?? null; }

        /// <summary>Recovery point tier information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> RecoveryPointTierDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointTierDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointTierDetail = value ?? null /* arrayOf */; }

        /// <summary>UTC time at which recovery point was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public global::System.DateTime? RecoveryPointTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).RecoveryPointTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>List of log ranges</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IPointInTimeRange> TimeRange { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).TimeRange; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).TimeRange = value ?? null /* arrayOf */; }

        /// <summary>Type of restore point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal)__azureWorkloadPointInTimeRecoveryPoint).Type = value ?? null; }

        /// <summary>
        /// Creates an new <see cref="AzureWorkloadSapAsePointInTimeRecoveryPoint" /> instance.
        /// </summary>
        public AzureWorkloadSapAsePointInTimeRecoveryPoint()
        {
            this.__azureWorkloadPointInTimeRecoveryPoint.ObjectType = "AzureWorkloadSAPAsePointInTimeRecoveryPoint";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__azureWorkloadPointInTimeRecoveryPoint), __azureWorkloadPointInTimeRecoveryPoint);
            await eventListener.AssertObjectIsValid(nameof(__azureWorkloadPointInTimeRecoveryPoint), __azureWorkloadPointInTimeRecoveryPoint);
        }
    }
    /// Recovery point specific to PointInTime in SAPAse
    public partial interface IAzureWorkloadSapAsePointInTimeRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPoint
    {

    }
    /// Recovery point specific to PointInTime in SAPAse
    internal partial interface IAzureWorkloadSapAsePointInTimeRecoveryPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadPointInTimeRecoveryPointInternal
    {

    }
}