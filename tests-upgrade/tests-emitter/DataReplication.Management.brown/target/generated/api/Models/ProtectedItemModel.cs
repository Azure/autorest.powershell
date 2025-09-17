// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Protected item model.</summary>
    public partial class ProtectedItemModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModel,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProxyResource();

        /// <summary>Gets or sets the allowed scenarios on the protected item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AllowedJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).AllowedJob; }

        /// <summary>Gets or sets the protected item correlation Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CorrelationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CorrelationId; }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobDisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobEndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobId; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobName; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobStartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CurrentJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobState; }

        /// <summary>Protected item model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CustomProperty = value ?? null /* model class */; }

        /// <summary>Discriminator property for ProtectedItemModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CustomPropertyInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CustomPropertyInstanceType = value ?? null; }

        /// <summary>Gets or sets the fabric agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string FabricAgentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricAgentId; }

        /// <summary>Gets or sets the fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string FabricId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricId; }

        /// <summary>Gets or sets the fabric object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string FabricObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricObjectId; }

        /// <summary>Gets or sets the fabric object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string FabricObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricObjectName; }

        /// <summary>Gets or sets the list of health errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> HealthError { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).HealthError; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobDisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedEnableProtectionJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobEndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobId; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobName; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedEnableProtectionJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobStartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedEnableProtectionJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobState; }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobDisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedPlannedFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobEndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobId; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobName; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastFailedPlannedFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobStartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastFailedPlannedFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobState; }

        /// <summary>Gets or sets the Last successful planned failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastSuccessfulPlannedFailoverTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulPlannedFailoverTime; }

        /// <summary>Gets or sets the Last successful test failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastSuccessfulTestFailoverTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulTestFailoverTime; }

        /// <summary>Gets or sets the Last successful unplanned failover time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastSuccessfulUnplannedFailoverTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulUnplannedFailoverTime; }

        /// <summary>Gets or sets the job friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobDisplayName; }

        /// <summary>Gets or sets end time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastTestFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobEndTime; }

        /// <summary>Gets or sets job Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobId; }

        /// <summary>Gets or sets job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobName; }

        /// <summary>Gets or sets protection scenario name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobScenarioName; }

        /// <summary>Gets or sets start time of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastTestFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobStartTime; }

        /// <summary>Gets or sets job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string LastTestFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobState; }

        /// <summary>Internal Acessors for AllowedJob</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.AllowedJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).AllowedJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).AllowedJob = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for CorrelationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CorrelationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CorrelationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CorrelationId = value ?? null; }

        /// <summary>Internal Acessors for CurrentJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJob = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CurrentJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobDisplayName = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for CurrentJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobId = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobName = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobScenarioName = value ?? null; }

        /// <summary>Internal Acessors for CurrentJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for CurrentJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CurrentJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CurrentJobState = value ?? null; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).CustomProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for FabricAgentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.FabricAgentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricAgentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricAgentId = value ?? null; }

        /// <summary>Internal Acessors for FabricId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.FabricId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricId = value ?? null; }

        /// <summary>Internal Acessors for FabricObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.FabricObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricObjectId = value ?? null; }

        /// <summary>Internal Acessors for FabricObjectName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.FabricObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricObjectName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).FabricObjectName = value ?? null; }

        /// <summary>Internal Acessors for HealthError</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHealthErrorModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.HealthError { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).HealthError; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).HealthError = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJob = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobDisplayName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobId = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobScenarioName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedEnableProtectionJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedEnableProtectionJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedEnableProtectionJobState = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJob = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobDisplayName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobId = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobScenarioName = value ?? null; }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastFailedPlannedFailoverJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastFailedPlannedFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastFailedPlannedFailoverJobState = value ?? null; }

        /// <summary>Internal Acessors for LastSuccessfulPlannedFailoverTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastSuccessfulPlannedFailoverTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulPlannedFailoverTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulPlannedFailoverTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastSuccessfulTestFailoverTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastSuccessfulTestFailoverTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulTestFailoverTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulTestFailoverTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastSuccessfulUnplannedFailoverTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastSuccessfulUnplannedFailoverTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulUnplannedFailoverTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastSuccessfulUnplannedFailoverTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastTestFailoverJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemJobProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJob = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LastTestFailoverJobDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobDisplayName = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastTestFailoverJobId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobId = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobName = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobScenarioName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobScenarioName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobScenarioName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobScenarioName = value ?? null; }

        /// <summary>Internal Acessors for LastTestFailoverJobStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastTestFailoverJobState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.LastTestFailoverJobState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).LastTestFailoverJobState = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProtectionState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProtectionState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProtectionState = value ?? null; }

        /// <summary>Internal Acessors for ProtectionStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.ProtectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProtectionStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProtectionStateDescription = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ReplicationHealth</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.ReplicationHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ReplicationHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ReplicationHealth = value ?? null; }

        /// <summary>Internal Acessors for ResyncRequired</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.ResyncRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ResyncRequired; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ResyncRequired = value ?? default(bool); }

        /// <summary>Internal Acessors for ResynchronizationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.ResynchronizationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ResynchronizationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ResynchronizationState = value ?? null; }

        /// <summary>Internal Acessors for SourceFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.SourceFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).SourceFabricProviderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).SourceFabricProviderId = value ?? null; }

        /// <summary>Internal Acessors for TargetFabricAgentId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.TargetFabricAgentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricAgentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricAgentId = value ?? null; }

        /// <summary>Internal Acessors for TargetFabricId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.TargetFabricId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricId = value ?? null; }

        /// <summary>Internal Acessors for TargetFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.TargetFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricProviderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricProviderId = value ?? null; }

        /// <summary>Internal Acessors for TestFailoverState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.TestFailoverState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TestFailoverState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TestFailoverState = value ?? null; }

        /// <summary>Internal Acessors for TestFailoverStateDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelInternal.TestFailoverStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TestFailoverStateDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TestFailoverStateDescription = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Gets or sets the policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string PolicyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).PolicyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).PolicyName = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelProperties()); set => this._property = value; }

        /// <summary>Gets or sets the protection state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ProtectionState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProtectionState; }

        /// <summary>Gets or sets the protection state description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ProtectionStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProtectionStateDescription; }

        /// <summary>Gets or sets the provisioning state of the fabric agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets or sets the replication extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ReplicationExtensionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ReplicationExtensionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ReplicationExtensionName = value ?? null; }

        /// <summary>Gets or sets protected item replication health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ReplicationHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ReplicationHealth; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Gets or sets a value indicating whether resynchronization is required or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public bool? ResyncRequired { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ResyncRequired; }

        /// <summary>Gets or sets the resynchronization state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ResynchronizationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).ResynchronizationState; }

        /// <summary>Gets or sets the source fabric provider Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string SourceFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).SourceFabricProviderId; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>Gets or sets the target fabric agent Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string TargetFabricAgentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricAgentId; }

        /// <summary>Gets or sets the target fabric Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string TargetFabricId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricId; }

        /// <summary>Gets or sets the target fabric provider Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string TargetFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TargetFabricProviderId; }

        /// <summary>Gets or sets the test failover state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string TestFailoverState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TestFailoverState; }

        /// <summary>Gets or sets the Test failover state description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string TestFailoverStateDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesInternal)Property).TestFailoverStateDescription; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="ProtectedItemModel" /> instance.</summary>
        public ProtectedItemModel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Protected item model.
    public partial interface IProtectedItemModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource
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
        Required = false,
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
        Required = false,
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
        Required = false,
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
    /// Protected item model.
    internal partial interface IProtectedItemModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResourceInternal
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
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelProperties Property { get; set; }
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