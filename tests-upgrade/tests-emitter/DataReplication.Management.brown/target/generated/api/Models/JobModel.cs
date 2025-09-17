// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Job model.</summary>
    public partial class JobModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModel,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProxyResource();

        /// <summary>Gets or sets the job activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ActivityId; }

        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AffectedObjectDetailDescription; }

        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AffectedObjectDetailType; }

        /// <summary>Gets or sets the list of allowed actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AllowedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AllowedAction; }

        /// <summary>Job model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomProperty = value ?? null /* model class */; }

        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomPropertyInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomPropertyInstanceType = value ?? null; }

        /// <summary>Gets or sets the friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).DisplayName; }

        /// <summary>Gets or sets the end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).EndTime; }

        /// <summary>Gets or sets the list of errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).Error; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Internal Acessors for ActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ActivityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ActivityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ActivityId = value ?? null; }

        /// <summary>Internal Acessors for AffectedObjectDetailDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AffectedObjectDetailDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AffectedObjectDetailDescription = value ?? null; }

        /// <summary>Internal Acessors for AffectedObjectDetailType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AffectedObjectDetailType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AffectedObjectDetailType = value ?? null; }

        /// <summary>Internal Acessors for AllowedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.AllowedAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AllowedAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).AllowedAction = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.CustomProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CustomPropertyAffectedObjectDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.CustomPropertyAffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomPropertyAffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).CustomPropertyAffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Error</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).Error = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectId = value ?? null; }

        /// <summary>Internal Acessors for ObjectInternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ObjectInternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectInternalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectInternalId = value ?? null; }

        /// <summary>Internal Acessors for ObjectInternalName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ObjectInternalName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectInternalName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectInternalName = value ?? null; }

        /// <summary>Internal Acessors for ObjectName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectName; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectName = value ?? null; }

        /// <summary>Internal Acessors for ObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectType = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.JobModelProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for ReplicationProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.ReplicationProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ReplicationProviderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ReplicationProviderId = value ?? null; }

        /// <summary>Internal Acessors for SourceFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.SourceFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).SourceFabricProviderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).SourceFabricProviderId = value ?? null; }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).State = value ?? null; }

        /// <summary>Internal Acessors for TargetFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.TargetFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).TargetFabricProviderId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).TargetFabricProviderId = value ?? null; }

        /// <summary>Internal Acessors for Task</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelInternal.Task { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).Task; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).Task = value ?? null /* arrayOf */; }

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

        /// <summary>Gets or sets the affected object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectId; }

        /// <summary>Gets or sets the affected object internal Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ObjectInternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectInternalId; }

        /// <summary>Gets or sets the affected object internal name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ObjectInternalName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectInternalName; }

        /// <summary>Gets or sets the affected object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ObjectName { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectName; }

        /// <summary>Gets or sets the object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ObjectType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ObjectType; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.JobModelProperties()); set => this._property = value; }

        /// <summary>Gets or sets the provisioning state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets or sets the replication provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string ReplicationProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).ReplicationProviderId; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Gets or sets the source fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string SourceFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).SourceFabricProviderId; }

        /// <summary>Gets or sets the start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).StartTime; }

        /// <summary>Gets or sets the job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).State; }

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

        /// <summary>Gets or sets the target fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string TargetFabricProviderId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).TargetFabricProviderId; }

        /// <summary>Gets or sets the list of tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> Task { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal)Property).Task; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="JobModel" /> instance.</summary>
        public JobModel()
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
    /// Job model.
    public partial interface IJobModel :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResource
    {
        /// <summary>Gets or sets the job activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the job activity id.",
        SerializedName = @"activityId",
        PossibleTypes = new [] { typeof(string) })]
        string ActivityId { get;  }
        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Description of the affected object details.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string AffectedObjectDetailDescription { get;  }
        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of the affected object details.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("object")]
        string AffectedObjectDetailType { get;  }
        /// <summary>Gets or sets the list of allowed actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of allowed actions on the job.",
        SerializedName = @"allowedActions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AllowedAction { get;  }
        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for JobModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the friendly display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Gets or sets the end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>Gets or sets the list of errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of errors.",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> Error { get;  }
        /// <summary>Gets or sets the affected object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the affected object Id.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get;  }
        /// <summary>Gets or sets the affected object internal Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the affected object internal Id.",
        SerializedName = @"objectInternalId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectInternalId { get;  }
        /// <summary>Gets or sets the affected object internal name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the affected object internal name.",
        SerializedName = @"objectInternalName",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectInternalName { get;  }
        /// <summary>Gets or sets the affected object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the affected object name.",
        SerializedName = @"objectName",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectName { get;  }
        /// <summary>Gets or sets the object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the object type.",
        SerializedName = @"objectType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("AvsDiskPool", "FabricAgent", "Fabric", "Policy", "ProtectedItem", "RecoveryPlan", "ReplicationExtension", "Vault")]
        string ObjectType { get;  }
        /// <summary>Gets or sets the provisioning state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the provisioning state of the job.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>Gets or sets the replication provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the replication provider.",
        SerializedName = @"replicationProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationProviderId { get;  }
        /// <summary>Gets or sets the source fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the source fabric provider.",
        SerializedName = @"sourceFabricProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceFabricProviderId { get;  }
        /// <summary>Gets or sets the start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>Gets or sets the job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the job state.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Pending", "Started", "Cancelling", "Succeeded", "Failed", "Cancelled", "CompletedWithInformation", "CompletedWithWarnings", "CompletedWithErrors")]
        string State { get;  }
        /// <summary>Gets or sets the target fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target fabric provider.",
        SerializedName = @"targetFabricProviderId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetFabricProviderId { get;  }
        /// <summary>Gets or sets the list of tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of tasks.",
        SerializedName = @"tasks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> Task { get;  }

    }
    /// Job model.
    internal partial interface IJobModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProxyResourceInternal
    {
        /// <summary>Gets or sets the job activity id.</summary>
        string ActivityId { get; set; }
        /// <summary>Description of the affected object details.</summary>
        string AffectedObjectDetailDescription { get; set; }
        /// <summary>Type of the affected object details.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("object")]
        string AffectedObjectDetailType { get; set; }
        /// <summary>Gets or sets the list of allowed actions on the job.</summary>
        System.Collections.Generic.List<string> AllowedAction { get; set; }
        /// <summary>Job model custom properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties CustomProperty { get; set; }
        /// <summary>Gets or sets any custom properties of the affected object.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails CustomPropertyAffectedObjectDetail { get; set; }
        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        string CustomPropertyInstanceType { get; set; }
        /// <summary>Gets or sets the friendly display name.</summary>
        string DisplayName { get; set; }
        /// <summary>Gets or sets the end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Gets or sets the list of errors.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> Error { get; set; }
        /// <summary>Gets or sets the affected object Id.</summary>
        string ObjectId { get; set; }
        /// <summary>Gets or sets the affected object internal Id.</summary>
        string ObjectInternalId { get; set; }
        /// <summary>Gets or sets the affected object internal name.</summary>
        string ObjectInternalName { get; set; }
        /// <summary>Gets or sets the affected object name.</summary>
        string ObjectName { get; set; }
        /// <summary>Gets or sets the object type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("AvsDiskPool", "FabricAgent", "Fabric", "Policy", "ProtectedItem", "RecoveryPlan", "ReplicationExtension", "Vault")]
        string ObjectType { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelProperties Property { get; set; }
        /// <summary>Gets or sets the provisioning state of the job.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Canceled", "Creating", "Deleting", "Deleted", "Failed", "Succeeded", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets the replication provider.</summary>
        string ReplicationProviderId { get; set; }
        /// <summary>Gets or sets the source fabric provider.</summary>
        string SourceFabricProviderId { get; set; }
        /// <summary>Gets or sets the start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Gets or sets the job state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("Pending", "Started", "Cancelling", "Succeeded", "Failed", "Cancelled", "CompletedWithInformation", "CompletedWithWarnings", "CompletedWithErrors")]
        string State { get; set; }
        /// <summary>Gets or sets the target fabric provider.</summary>
        string TargetFabricProviderId { get; set; }
        /// <summary>Gets or sets the list of tasks.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> Task { get; set; }

    }
}