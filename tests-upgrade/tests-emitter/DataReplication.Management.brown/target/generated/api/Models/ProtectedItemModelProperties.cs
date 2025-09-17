// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Protected item model properties.</summary>
    public partial class ProtectedItemModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowedJob" /> property.</summary>
        private System.Collections.Generic.List<string> _allowedJob;

        /// <summary>Gets or sets the allowed scenarios on the protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AllowedJob { get => this._allowedJob; }

        /// <summary>Backing field for <see cref="CorrelationId" /> property.</summary>
        private string _correlationId;

        /// <summary>Gets or sets the protected item correlation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string CorrelationId { get => this._correlationId; }

        /// <summary>Backing field for <see cref="CurrentJob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties _currentJob;

        /// <summary>Gets or sets the current scenario.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties CurrentJob { get => (this._currentJob = this._currentJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).DisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).EndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).Id; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).Name; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).ScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).StartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).State; }

        /// <summary>Backing field for <see cref="CustomProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties _customProperty;

        /// <summary>Protected item model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties()); set => this._customProperty = value; }

        /// <summary>Discriminator property for ProtectedItemModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesInternal)CustomProperty).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesInternal)CustomProperty).InstanceType = value ; }

        /// <summary>Backing field for <see cref="FabricAgentId" /> property.</summary>
        private string _fabricAgentId;

        /// <summary>Gets or sets the fabric agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricAgentId { get => this._fabricAgentId; }

        /// <summary>Backing field for <see cref="FabricId" /> property.</summary>
        private string _fabricId;

        /// <summary>Gets or sets the fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricId { get => this._fabricId; }

        /// <summary>Backing field for <see cref="FabricObjectId" /> property.</summary>
        private string _fabricObjectId;

        /// <summary>Gets or sets the fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricObjectId { get => this._fabricObjectId; }

        /// <summary>Backing field for <see cref="FabricObjectName" /> property.</summary>
        private string _fabricObjectName;

        /// <summary>Gets or sets the fabric object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricObjectName { get => this._fabricObjectName; }

        /// <summary>Backing field for <see cref="HealthError" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> _healthError;

        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get => this._healthError; }

        /// <summary>Backing field for <see cref="LastFailedEnableProtectionJob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties _lastFailedEnableProtectionJob;

        /// <summary>Gets or sets the last failed enabled protection job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties LastFailedEnableProtectionJob { get => (this._lastFailedEnableProtectionJob = this._lastFailedEnableProtectionJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).DisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedEnableProtectionJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).EndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).Id; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).Name; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).ScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedEnableProtectionJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).StartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).State; }

        /// <summary>Backing field for <see cref="LastFailedPlannedFailoverJob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties _lastFailedPlannedFailoverJob;

        /// <summary>Gets or sets the last failed planned failover job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties LastFailedPlannedFailoverJob { get => (this._lastFailedPlannedFailoverJob = this._lastFailedPlannedFailoverJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).DisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedPlannedFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).EndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).Id; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).Name; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).ScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedPlannedFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).StartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).State; }

        /// <summary>Backing field for <see cref="LastSuccessfulPlannedFailoverTime" /> property.</summary>
        private global::System.DateTime? _lastSuccessfulPlannedFailoverTime;

        /// <summary>Gets or sets the Last successful planned failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public global::System.DateTime? LastSuccessfulPlannedFailoverTime { get => this._lastSuccessfulPlannedFailoverTime; }

        /// <summary>Backing field for <see cref="LastSuccessfulTestFailoverTime" /> property.</summary>
        private global::System.DateTime? _lastSuccessfulTestFailoverTime;

        /// <summary>Gets or sets the Last successful test failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public global::System.DateTime? LastSuccessfulTestFailoverTime { get => this._lastSuccessfulTestFailoverTime; }

        /// <summary>Backing field for <see cref="LastSuccessfulUnplannedFailoverTime" /> property.</summary>
        private global::System.DateTime? _lastSuccessfulUnplannedFailoverTime;

        /// <summary>Gets or sets the Last successful unplanned failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public global::System.DateTime? LastSuccessfulUnplannedFailoverTime { get => this._lastSuccessfulUnplannedFailoverTime; }

        /// <summary>Backing field for <see cref="LastTestFailoverJob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties _lastTestFailoverJob;

        /// <summary>Gets or sets the last test failover job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties LastTestFailoverJob { get => (this._lastTestFailoverJob = this._lastTestFailoverJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).DisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastTestFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).EndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).Id; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).Name; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).ScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastTestFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).StartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).State; }

        /// <summary>Internal Acessors for AllowedJob</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.AllowedJob { get => this._allowedJob; set { {_allowedJob = value;} } }

        /// <summary>Internal Acessors for CorrelationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CorrelationId { get => this._correlationId; set { {_correlationId = value;} } }

        /// <summary>Internal Acessors for CurrentJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJob { get => (this._currentJob = this._currentJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); set { {_currentJob = value;} } }

        /// <summary>Internal Acessors for CurrentJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for CurrentJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).Id = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).Name = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).ScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).ScenarioName = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for CurrentJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CurrentJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)CurrentJob).State = value ?? null; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties()); set { {_customProperty = value;} } }

        /// <summary>Internal Acessors for FabricAgentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.FabricAgentId { get => this._fabricAgentId; set { {_fabricAgentId = value;} } }

        /// <summary>Internal Acessors for FabricId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.FabricId { get => this._fabricId; set { {_fabricId = value;} } }

        /// <summary>Internal Acessors for FabricObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.FabricObjectId { get => this._fabricObjectId; set { {_fabricObjectId = value;} } }

        /// <summary>Internal Acessors for FabricObjectName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.FabricObjectName { get => this._fabricObjectName; set { {_fabricObjectName = value;} } }

        /// <summary>Internal Acessors for HealthError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.HealthError { get => this._healthError; set { {_healthError = value;} } }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJob { get => (this._lastFailedEnableProtectionJob = this._lastFailedEnableProtectionJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); set { {_lastFailedEnableProtectionJob = value;} } }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).Id = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).Name = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).ScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).ScenarioName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedEnableProtectionJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedEnableProtectionJob).State = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJob { get => (this._lastFailedPlannedFailoverJob = this._lastFailedPlannedFailoverJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); set { {_lastFailedPlannedFailoverJob = value;} } }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).Id = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).Name = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).ScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).ScenarioName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastFailedPlannedFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastFailedPlannedFailoverJob).State = value ?? null; }

        /// <summary>Internal Acessors for LastSuccessfulPlannedFailoverTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastSuccessfulPlannedFailoverTime { get => this._lastSuccessfulPlannedFailoverTime; set { {_lastSuccessfulPlannedFailoverTime = value;} } }

        /// <summary>Internal Acessors for LastSuccessfulTestFailoverTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastSuccessfulTestFailoverTime { get => this._lastSuccessfulTestFailoverTime; set { {_lastSuccessfulTestFailoverTime = value;} } }

        /// <summary>Internal Acessors for LastSuccessfulUnplannedFailoverTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastSuccessfulUnplannedFailoverTime { get => this._lastSuccessfulUnplannedFailoverTime; set { {_lastSuccessfulUnplannedFailoverTime = value;} } }

        /// <summary>Internal Acessors for LastTestFailoverJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJob { get => (this._lastTestFailoverJob = this._lastTestFailoverJob ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemJobProperties()); set { {_lastTestFailoverJob = value;} } }

        /// <summary>Internal Acessors for LastTestFailoverJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastTestFailoverJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).Id = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).Name = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).ScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).ScenarioName = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastTestFailoverJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.LastTestFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobPropertiesInternal)LastTestFailoverJob).State = value ?? null; }

        /// <summary>Internal Acessors for ProtectionState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.ProtectionState { get => this._protectionState; set { {_protectionState = value;} } }

        /// <summary>Internal Acessors for ProtectionStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.ProtectionStateDescription { get => this._protectionStateDescription; set { {_protectionStateDescription = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ReplicationHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.ReplicationHealth { get => this._replicationHealth; set { {_replicationHealth = value;} } }

        /// <summary>Internal Acessors for ResyncRequired</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.ResyncRequired { get => this._resyncRequired; set { {_resyncRequired = value;} } }

        /// <summary>Internal Acessors for ResynchronizationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.ResynchronizationState { get => this._resynchronizationState; set { {_resynchronizationState = value;} } }

        /// <summary>Internal Acessors for SourceFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.SourceFabricProviderId { get => this._sourceFabricProviderId; set { {_sourceFabricProviderId = value;} } }

        /// <summary>Internal Acessors for TargetFabricAgentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.TargetFabricAgentId { get => this._targetFabricAgentId; set { {_targetFabricAgentId = value;} } }

        /// <summary>Internal Acessors for TargetFabricId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.TargetFabricId { get => this._targetFabricId; set { {_targetFabricId = value;} } }

        /// <summary>Internal Acessors for TargetFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.TargetFabricProviderId { get => this._targetFabricProviderId; set { {_targetFabricProviderId = value;} } }

        /// <summary>Internal Acessors for TestFailoverState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.TestFailoverState { get => this._testFailoverState; set { {_testFailoverState = value;} } }

        /// <summary>Internal Acessors for TestFailoverStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal.TestFailoverStateDescription { get => this._testFailoverStateDescription; set { {_testFailoverStateDescription = value;} } }

        /// <summary>Backing field for <see cref="PolicyName" /> property.</summary>
        private string _policyName;

        /// <summary>Gets or sets the policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string PolicyName { get => this._policyName; set => this._policyName = value; }

        /// <summary>Backing field for <see cref="ProtectionState" /> property.</summary>
        private string _protectionState;

        /// <summary>Gets or sets the protection state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProtectionState { get => this._protectionState; }

        /// <summary>Backing field for <see cref="ProtectionStateDescription" /> property.</summary>
        private string _protectionStateDescription;

        /// <summary>Gets or sets the protection state description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProtectionStateDescription { get => this._protectionStateDescription; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets or sets the provisioning state of the fabric agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ReplicationExtensionName" /> property.</summary>
        private string _replicationExtensionName;

        /// <summary>Gets or sets the replication extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ReplicationExtensionName { get => this._replicationExtensionName; set => this._replicationExtensionName = value; }

        /// <summary>Backing field for <see cref="ReplicationHealth" /> property.</summary>
        private string _replicationHealth;

        /// <summary>Gets or sets protected item replication health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ReplicationHealth { get => this._replicationHealth; }

        /// <summary>Backing field for <see cref="ResyncRequired" /> property.</summary>
        private bool? _resyncRequired;

        /// <summary>Gets or sets a value indicating whether resynchronization is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool? ResyncRequired { get => this._resyncRequired; }

        /// <summary>Backing field for <see cref="ResynchronizationState" /> property.</summary>
        private string _resynchronizationState;

        /// <summary>Gets or sets the resynchronization state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResynchronizationState { get => this._resynchronizationState; }

        /// <summary>Backing field for <see cref="SourceFabricProviderId" /> property.</summary>
        private string _sourceFabricProviderId;

        /// <summary>Gets or sets the source fabric provider Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string SourceFabricProviderId { get => this._sourceFabricProviderId; }

        /// <summary>Backing field for <see cref="TargetFabricAgentId" /> property.</summary>
        private string _targetFabricAgentId;

        /// <summary>Gets or sets the target fabric agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TargetFabricAgentId { get => this._targetFabricAgentId; }

        /// <summary>Backing field for <see cref="TargetFabricId" /> property.</summary>
        private string _targetFabricId;

        /// <summary>Gets or sets the target fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TargetFabricId { get => this._targetFabricId; }

        /// <summary>Backing field for <see cref="TargetFabricProviderId" /> property.</summary>
        private string _targetFabricProviderId;

        /// <summary>Gets or sets the target fabric provider Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TargetFabricProviderId { get => this._targetFabricProviderId; }

        /// <summary>Backing field for <see cref="TestFailoverState" /> property.</summary>
        private string _testFailoverState;

        /// <summary>Gets or sets the test failover state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TestFailoverState { get => this._testFailoverState; }

        /// <summary>Backing field for <see cref="TestFailoverStateDescription" /> property.</summary>
        private string _testFailoverStateDescription;

        /// <summary>Gets or sets the Test failover state description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TestFailoverStateDescription { get => this._testFailoverStateDescription; }

        /// <summary>Creates an new <see cref="ProtectedItemModelProperties" /> instance.</summary>
        public ProtectedItemModelProperties()
        {

        }
    }
    /// Protected item model properties.
    public partial interface IProtectedItemModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the allowed scenarios on the protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the allowed scenarios on the protected item.",
        SerializedName = @"allowedJobs",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AllowedJob { get;  }
        /// <summary>Gets or sets the protected item correlation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the protected item correlation Id.",
        SerializedName = @"correlationId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationId { get;  }
        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the job friendly display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentJobDisplayName { get;  }
        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets end time of the job.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CurrentJobEndTime { get;  }
        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentJobId { get;  }
        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentJobName { get;  }
        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets protection scenario name.",
        SerializedName = @"scenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentJobScenarioName { get;  }
        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets start time of the job.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CurrentJobStartTime { get;  }
        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentJobState { get;  }
        /// <summary>Discriminator property for ProtectedItemModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for ProtectedItemModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the fabric agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric agent Id.",
        SerializedName = @"fabricAgentId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricAgentId { get;  }
        /// <summary>Gets or sets the fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric Id.",
        SerializedName = @"fabricId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricId { get;  }
        /// <summary>Gets or sets the fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric object Id.",
        SerializedName = @"fabricObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectId { get;  }
        /// <summary>Gets or sets the fabric object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the fabric object name.",
        SerializedName = @"fabricObjectName",
        PossibleTypes = new [] { typeof(string) })]
        string FabricObjectName { get;  }
        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of health errors.",
        SerializedName = @"healthErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get;  }
        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the job friendly display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedEnableProtectionJobDisplayName { get;  }
        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets end time of the job.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastFailedEnableProtectionJobEndTime { get;  }
        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedEnableProtectionJobId { get;  }
        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedEnableProtectionJobName { get;  }
        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets protection scenario name.",
        SerializedName = @"scenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedEnableProtectionJobScenarioName { get;  }
        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets start time of the job.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastFailedEnableProtectionJobStartTime { get;  }
        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedEnableProtectionJobState { get;  }
        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the job friendly display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedPlannedFailoverJobDisplayName { get;  }
        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets end time of the job.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastFailedPlannedFailoverJobEndTime { get;  }
        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedPlannedFailoverJobId { get;  }
        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedPlannedFailoverJobName { get;  }
        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets protection scenario name.",
        SerializedName = @"scenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedPlannedFailoverJobScenarioName { get;  }
        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets start time of the job.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastFailedPlannedFailoverJobStartTime { get;  }
        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string LastFailedPlannedFailoverJobState { get;  }
        /// <summary>Gets or sets the Last successful planned failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the Last successful planned failover time.",
        SerializedName = @"lastSuccessfulPlannedFailoverTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastSuccessfulPlannedFailoverTime { get;  }
        /// <summary>Gets or sets the Last successful test failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the Last successful test failover time.",
        SerializedName = @"lastSuccessfulTestFailoverTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastSuccessfulTestFailoverTime { get;  }
        /// <summary>Gets or sets the Last successful unplanned failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the Last successful unplanned failover time.",
        SerializedName = @"lastSuccessfulUnplannedFailoverTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastSuccessfulUnplannedFailoverTime { get;  }
        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the job friendly display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string LastTestFailoverJobDisplayName { get;  }
        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets end time of the job.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastTestFailoverJobEndTime { get;  }
        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LastTestFailoverJobId { get;  }
        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string LastTestFailoverJobName { get;  }
        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets protection scenario name.",
        SerializedName = @"scenarioName",
        PossibleTypes = new [] { typeof(string) })]
        string LastTestFailoverJobScenarioName { get;  }
        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets start time of the job.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastTestFailoverJobStartTime { get;  }
        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets job state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string LastTestFailoverJobState { get;  }
        /// <summary>Gets or sets the policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the policy name.",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyName { get; set; }
        /// <summary>Gets or sets the protection state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the protection state.",
        SerializedName = @"protectionState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("UnprotectedStatesBegin", "EnablingProtection", "EnablingFailed", "DisablingProtection", "MarkedForDeletion", "DisablingFailed", "UnprotectedStatesEnd", "InitialReplicationStatesBegin", "InitialReplicationInProgress", "InitialReplicationCompletedOnPrimary", "InitialReplicationCompletedOnRecovery", "InitialReplicationFailed", "InitialReplicationStatesEnd", "ProtectedStatesBegin", "Protected", "ProtectedStatesEnd", "PlannedFailoverTransitionStatesBegin", "PlannedFailoverInitiated", "PlannedFailoverCompleting", "PlannedFailoverCompleted", "PlannedFailoverFailed", "PlannedFailoverCompletionFailed", "PlannedFailoverTransitionStatesEnd", "UnplannedFailoverTransitionStatesBegin", "UnplannedFailoverInitiated", "UnplannedFailoverCompleting", "UnplannedFailoverCompleted", "UnplannedFailoverFailed", "UnplannedFailoverCompletionFailed", "UnplannedFailoverTransitionStatesEnd", "CommitFailoverStatesBegin", "CommitFailoverInProgressOnPrimary", "CommitFailoverInProgressOnRecovery", "CommitFailoverCompleted", "CommitFailoverFailedOnPrimary", "CommitFailoverFailedOnRecovery", "CommitFailoverStatesEnd", "CancelFailoverStatesBegin", "CancelFailoverInProgressOnPrimary", "CancelFailoverInProgressOnRecovery", "CancelFailoverFailedOnPrimary", "CancelFailoverFailedOnRecovery", "CancelFailoverStatesEnd", "ChangeRecoveryPointStatesBegin", "ChangeRecoveryPointInitiated", "ChangeRecoveryPointCompleted", "ChangeRecoveryPointFailed", "ChangeRecoveryPointStatesEnd", "ReprotectStatesBegin", "ReprotectInitiated", "ReprotectFailed", "ReprotectStatesEnd")]
        string ProtectionState { get;  }
        /// <summary>Gets or sets the protection state description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the protection state description.",
        SerializedName = @"protectionStateDescription",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionStateDescription { get;  }
        /// <summary>Gets or sets the provisioning state of the fabric agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the fabric agent.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>Gets or sets the replication extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the replication extension name.",
        SerializedName = @"replicationExtensionName",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationExtensionName { get; set; }
        /// <summary>Gets or sets protected item replication health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets protected item replication health.",
        SerializedName = @"replicationHealth",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Normal", "Warning", "Critical")]
        string ReplicationHealth { get;  }
        /// <summary>Gets or sets a value indicating whether resynchronization is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets a value indicating whether resynchronization is required or not.",
        SerializedName = @"resyncRequired",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ResyncRequired { get;  }
        /// <summary>Gets or sets the resynchronization state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the resynchronization state.",
        SerializedName = @"resynchronizationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("None", "ResynchronizationInitiated", "ResynchronizationCompleted", "ResynchronizationFailed")]
        string ResynchronizationState { get;  }
        /// <summary>Gets or sets the source fabric provider Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the source fabric provider Id.",
        SerializedName = @"sourceFabricProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceFabricProviderId { get;  }
        /// <summary>Gets or sets the target fabric agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target fabric agent Id.",
        SerializedName = @"targetFabricAgentId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetFabricAgentId { get;  }
        /// <summary>Gets or sets the target fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target fabric Id.",
        SerializedName = @"targetFabricId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetFabricId { get;  }
        /// <summary>Gets or sets the target fabric provider Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target fabric provider Id.",
        SerializedName = @"targetFabricProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetFabricProviderId { get;  }
        /// <summary>Gets or sets the test failover state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the test failover state.",
        SerializedName = @"testFailoverState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("None", "TestFailoverInitiated", "TestFailoverCompleting", "TestFailoverCompleted", "TestFailoverFailed", "TestFailoverCompletionFailed", "TestFailoverCleanupInitiated", "TestFailoverCleanupCompleting", "MarkedForDeletion")]
        string TestFailoverState { get;  }
        /// <summary>Gets or sets the Test failover state description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the Test failover state description.",
        SerializedName = @"testFailoverStateDescription",
        PossibleTypes = new [] { typeof(string) })]
        string TestFailoverStateDescription { get;  }

    }
    /// Protected item model properties.
    internal partial interface IProtectedItemModelPropertiesInternal

    {
        /// <summary>Gets or sets the allowed scenarios on the protected item.</summary>
        System.Collections.Generic.List<string> AllowedJob { get; set; }
        /// <summary>Gets or sets the protected item correlation Id.</summary>
        string CorrelationId { get; set; }
        /// <summary>Gets or sets the current scenario.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties CurrentJob { get; set; }
        /// <summary>Gets or sets the job friendly display name.</summary>
        string CurrentJobDisplayName { get; set; }
        /// <summary>Gets or sets end time of the job.</summary>
        global::System.DateTime? CurrentJobEndTime { get; set; }
        /// <summary>Gets or sets job Id.</summary>
        string CurrentJobId { get; set; }
        /// <summary>Gets or sets job name.</summary>
        string CurrentJobName { get; set; }
        /// <summary>Gets or sets protection scenario name.</summary>
        string CurrentJobScenarioName { get; set; }
        /// <summary>Gets or sets start time of the job.</summary>
        global::System.DateTime? CurrentJobStartTime { get; set; }
        /// <summary>Gets or sets job state.</summary>
        string CurrentJobState { get; set; }
        /// <summary>Protected item model custom properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties CustomProperty { get; set; }
        /// <summary>Discriminator property for ProtectedItemModelCustomProperties.</summary>
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the fabric agent Id.</summary>
        string FabricAgentId { get; set; }
        /// <summary>Gets or sets the fabric Id.</summary>
        string FabricId { get; set; }
        /// <summary>Gets or sets the fabric object Id.</summary>
        string FabricObjectId { get; set; }
        /// <summary>Gets or sets the fabric object name.</summary>
        string FabricObjectName { get; set; }
        /// <summary>Gets or sets the list of health errors.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get; set; }
        /// <summary>Gets or sets the last failed enabled protection job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties LastFailedEnableProtectionJob { get; set; }
        /// <summary>Gets or sets the job friendly display name.</summary>
        string LastFailedEnableProtectionJobDisplayName { get; set; }
        /// <summary>Gets or sets end time of the job.</summary>
        global::System.DateTime? LastFailedEnableProtectionJobEndTime { get; set; }
        /// <summary>Gets or sets job Id.</summary>
        string LastFailedEnableProtectionJobId { get; set; }
        /// <summary>Gets or sets job name.</summary>
        string LastFailedEnableProtectionJobName { get; set; }
        /// <summary>Gets or sets protection scenario name.</summary>
        string LastFailedEnableProtectionJobScenarioName { get; set; }
        /// <summary>Gets or sets start time of the job.</summary>
        global::System.DateTime? LastFailedEnableProtectionJobStartTime { get; set; }
        /// <summary>Gets or sets job state.</summary>
        string LastFailedEnableProtectionJobState { get; set; }
        /// <summary>Gets or sets the last failed planned failover job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties LastFailedPlannedFailoverJob { get; set; }
        /// <summary>Gets or sets the job friendly display name.</summary>
        string LastFailedPlannedFailoverJobDisplayName { get; set; }
        /// <summary>Gets or sets end time of the job.</summary>
        global::System.DateTime? LastFailedPlannedFailoverJobEndTime { get; set; }
        /// <summary>Gets or sets job Id.</summary>
        string LastFailedPlannedFailoverJobId { get; set; }
        /// <summary>Gets or sets job name.</summary>
        string LastFailedPlannedFailoverJobName { get; set; }
        /// <summary>Gets or sets protection scenario name.</summary>
        string LastFailedPlannedFailoverJobScenarioName { get; set; }
        /// <summary>Gets or sets start time of the job.</summary>
        global::System.DateTime? LastFailedPlannedFailoverJobStartTime { get; set; }
        /// <summary>Gets or sets job state.</summary>
        string LastFailedPlannedFailoverJobState { get; set; }
        /// <summary>Gets or sets the Last successful planned failover time.</summary>
        global::System.DateTime? LastSuccessfulPlannedFailoverTime { get; set; }
        /// <summary>Gets or sets the Last successful test failover time.</summary>
        global::System.DateTime? LastSuccessfulTestFailoverTime { get; set; }
        /// <summary>Gets or sets the Last successful unplanned failover time.</summary>
        global::System.DateTime? LastSuccessfulUnplannedFailoverTime { get; set; }
        /// <summary>Gets or sets the last test failover job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties LastTestFailoverJob { get; set; }
        /// <summary>Gets or sets the job friendly display name.</summary>
        string LastTestFailoverJobDisplayName { get; set; }
        /// <summary>Gets or sets end time of the job.</summary>
        global::System.DateTime? LastTestFailoverJobEndTime { get; set; }
        /// <summary>Gets or sets job Id.</summary>
        string LastTestFailoverJobId { get; set; }
        /// <summary>Gets or sets job name.</summary>
        string LastTestFailoverJobName { get; set; }
        /// <summary>Gets or sets protection scenario name.</summary>
        string LastTestFailoverJobScenarioName { get; set; }
        /// <summary>Gets or sets start time of the job.</summary>
        global::System.DateTime? LastTestFailoverJobStartTime { get; set; }
        /// <summary>Gets or sets job state.</summary>
        string LastTestFailoverJobState { get; set; }
        /// <summary>Gets or sets the policy name.</summary>
        string PolicyName { get; set; }
        /// <summary>Gets or sets the protection state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("UnprotectedStatesBegin", "EnablingProtection", "EnablingFailed", "DisablingProtection", "MarkedForDeletion", "DisablingFailed", "UnprotectedStatesEnd", "InitialReplicationStatesBegin", "InitialReplicationInProgress", "InitialReplicationCompletedOnPrimary", "InitialReplicationCompletedOnRecovery", "InitialReplicationFailed", "InitialReplicationStatesEnd", "ProtectedStatesBegin", "Protected", "ProtectedStatesEnd", "PlannedFailoverTransitionStatesBegin", "PlannedFailoverInitiated", "PlannedFailoverCompleting", "PlannedFailoverCompleted", "PlannedFailoverFailed", "PlannedFailoverCompletionFailed", "PlannedFailoverTransitionStatesEnd", "UnplannedFailoverTransitionStatesBegin", "UnplannedFailoverInitiated", "UnplannedFailoverCompleting", "UnplannedFailoverCompleted", "UnplannedFailoverFailed", "UnplannedFailoverCompletionFailed", "UnplannedFailoverTransitionStatesEnd", "CommitFailoverStatesBegin", "CommitFailoverInProgressOnPrimary", "CommitFailoverInProgressOnRecovery", "CommitFailoverCompleted", "CommitFailoverFailedOnPrimary", "CommitFailoverFailedOnRecovery", "CommitFailoverStatesEnd", "CancelFailoverStatesBegin", "CancelFailoverInProgressOnPrimary", "CancelFailoverInProgressOnRecovery", "CancelFailoverFailedOnPrimary", "CancelFailoverFailedOnRecovery", "CancelFailoverStatesEnd", "ChangeRecoveryPointStatesBegin", "ChangeRecoveryPointInitiated", "ChangeRecoveryPointCompleted", "ChangeRecoveryPointFailed", "ChangeRecoveryPointStatesEnd", "ReprotectStatesBegin", "ReprotectInitiated", "ReprotectFailed", "ReprotectStatesEnd")]
        string ProtectionState { get; set; }
        /// <summary>Gets or sets the protection state description.</summary>
        string ProtectionStateDescription { get; set; }
        /// <summary>Gets or sets the provisioning state of the fabric agent.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets the replication extension name.</summary>
        string ReplicationExtensionName { get; set; }
        /// <summary>Gets or sets protected item replication health.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Normal", "Warning", "Critical")]
        string ReplicationHealth { get; set; }
        /// <summary>Gets or sets a value indicating whether resynchronization is required or not.</summary>
        bool? ResyncRequired { get; set; }
        /// <summary>Gets or sets the resynchronization state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("None", "ResynchronizationInitiated", "ResynchronizationCompleted", "ResynchronizationFailed")]
        string ResynchronizationState { get; set; }
        /// <summary>Gets or sets the source fabric provider Id.</summary>
        string SourceFabricProviderId { get; set; }
        /// <summary>Gets or sets the target fabric agent Id.</summary>
        string TargetFabricAgentId { get; set; }
        /// <summary>Gets or sets the target fabric Id.</summary>
        string TargetFabricId { get; set; }
        /// <summary>Gets or sets the target fabric provider Id.</summary>
        string TargetFabricProviderId { get; set; }
        /// <summary>Gets or sets the test failover state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("None", "TestFailoverInitiated", "TestFailoverCompleting", "TestFailoverCompleted", "TestFailoverFailed", "TestFailoverCompletionFailed", "TestFailoverCleanupInitiated", "TestFailoverCleanupCompleting", "MarkedForDeletion")]
        string TestFailoverState { get; set; }
        /// <summary>Gets or sets the Test failover state description.</summary>
        string TestFailoverStateDescription { get; set; }

    }
}