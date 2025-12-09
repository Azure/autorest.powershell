// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>
    /// Workload specific recovery point, specifically encapsulates full/diff recovery point
    /// </summary>
    public partial class AzureWorkloadRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPoint,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPoint"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPoint __recoveryPoint = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPoint();

        /// <summary>Internal Acessors for RecoveryPointProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointInternal.RecoveryPointProperty { get => (this._recoveryPointProperty = this._recoveryPointProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointProperties()); set { {_recoveryPointProperty = value;} } }

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string ObjectType { get => "AzureWorkloadRecoveryPoint"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)__recoveryPoint).ObjectType = "AzureWorkloadRecoveryPoint"; }

        /// <summary>Backing field for <see cref="RecoveryPointMoveReadinessInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo _recoveryPointMoveReadinessInfo;

        /// <summary>Eligibility of RP to be moved to another tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo RecoveryPointMoveReadinessInfo { get => (this._recoveryPointMoveReadinessInfo = this._recoveryPointMoveReadinessInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRecoveryPointMoveReadinessInfo()); set => this._recoveryPointMoveReadinessInfo = value; }

        /// <summary>Backing field for <see cref="RecoveryPointProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties _recoveryPointProperty;

        /// <summary>Properties of Recovery Point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties RecoveryPointProperty { get => (this._recoveryPointProperty = this._recoveryPointProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointProperties()); set => this._recoveryPointProperty = value; }

        /// <summary>Expiry time of Recovery Point in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RecoveryPointPropertyExpiryTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointPropertiesInternal)RecoveryPointProperty).ExpiryTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointPropertiesInternal)RecoveryPointProperty).ExpiryTime = value ?? null; }

        /// <summary>Bool to indicate whether RP is in soft delete state or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public bool? RecoveryPointPropertyIsSoftDeleted { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointPropertiesInternal)RecoveryPointProperty).IsSoftDeleted; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointPropertiesInternal)RecoveryPointProperty).IsSoftDeleted = value ?? default(bool); }

        /// <summary>Rule name tagged on Recovery Point that governs life cycle</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string RecoveryPointPropertyRuleName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointPropertiesInternal)RecoveryPointProperty).RuleName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointPropertiesInternal)RecoveryPointProperty).RuleName = value ?? null; }

        /// <summary>Backing field for <see cref="RecoveryPointTierDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> _recoveryPointTierDetail;

        /// <summary>Recovery point tier information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> RecoveryPointTierDetail { get => this._recoveryPointTierDetail; set => this._recoveryPointTierDetail = value; }

        /// <summary>Backing field for <see cref="RecoveryPointTimeInUtc" /> property.</summary>
        private global::System.DateTime? _recoveryPointTimeInUtc;

        /// <summary>UTC time at which recovery point was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public global::System.DateTime? RecoveryPointTimeInUtc { get => this._recoveryPointTimeInUtc; set => this._recoveryPointTimeInUtc = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of restore point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="AzureWorkloadRecoveryPoint" /> instance.</summary>
        public AzureWorkloadRecoveryPoint()
        {
            this.__recoveryPoint.ObjectType = "AzureWorkloadRecoveryPoint";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__recoveryPoint), __recoveryPoint);
            await eventListener.AssertObjectIsValid(nameof(__recoveryPoint), __recoveryPoint);
        }
    }
    /// Workload specific recovery point, specifically encapsulates full/diff recovery point
    public partial interface IAzureWorkloadRecoveryPoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPoint
    {
        /// <summary>Eligibility of RP to be moved to another tier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Eligibility of RP to be moved to another tier",
        SerializedName = @"recoveryPointMoveReadinessInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo RecoveryPointMoveReadinessInfo { get; set; }
        /// <summary>Expiry time of Recovery Point in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Expiry time of Recovery Point in UTC.",
        SerializedName = @"expiryTime",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointPropertyExpiryTime { get; set; }
        /// <summary>Bool to indicate whether RP is in soft delete state or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Bool to indicate whether RP is in soft delete state or not",
        SerializedName = @"isSoftDeleted",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RecoveryPointPropertyIsSoftDeleted { get; set; }
        /// <summary>Rule name tagged on Recovery Point that governs life cycle</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rule name tagged on Recovery Point that governs life cycle",
        SerializedName = @"ruleName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointPropertyRuleName { get; set; }
        /// <summary>Recovery point tier information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Recovery point tier information.",
        SerializedName = @"recoveryPointTierDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> RecoveryPointTierDetail { get; set; }
        /// <summary>UTC time at which recovery point was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UTC time at which recovery point was created",
        SerializedName = @"recoveryPointTimeInUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RecoveryPointTimeInUtc { get; set; }
        /// <summary>Type of restore point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of restore point",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Full", "Log", "Differential", "Incremental", "SnapshotFull", "SnapshotCopyOnlyFull")]
        string Type { get; set; }

    }
    /// Workload specific recovery point, specifically encapsulates full/diff recovery point
    internal partial interface IAzureWorkloadRecoveryPointInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal
    {
        /// <summary>Eligibility of RP to be moved to another tier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRecoveryPointMoveReadinessInfo RecoveryPointMoveReadinessInfo { get; set; }
        /// <summary>Properties of Recovery Point</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties RecoveryPointProperty { get; set; }
        /// <summary>Expiry time of Recovery Point in UTC.</summary>
        string RecoveryPointPropertyExpiryTime { get; set; }
        /// <summary>Bool to indicate whether RP is in soft delete state or not</summary>
        bool? RecoveryPointPropertyIsSoftDeleted { get; set; }
        /// <summary>Rule name tagged on Recovery Point that governs life cycle</summary>
        string RecoveryPointPropertyRuleName { get; set; }
        /// <summary>Recovery point tier information.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2> RecoveryPointTierDetail { get; set; }
        /// <summary>UTC time at which recovery point was created</summary>
        global::System.DateTime? RecoveryPointTimeInUtc { get; set; }
        /// <summary>Type of restore point</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PSArgumentCompleterAttribute("Invalid", "Full", "Log", "Differential", "Incremental", "SnapshotFull", "SnapshotCopyOnlyFull")]
        string Type { get; set; }

    }
}