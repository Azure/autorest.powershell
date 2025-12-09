// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Represents a maintenance.</summary>
    public partial class Maintenance :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenance,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ProxyResource();

        /// <summary>The max time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? AvailableScheduleMaxTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceAvailableScheduleMaxTime; }

        /// <summary>The min time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? AvailableScheduleMinTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceAvailableScheduleMinTime; }

        /// <summary>The maintenance description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceDescription; }

        /// <summary>The end time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceEndTime; }

        /// <summary>The end time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExecutionEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceExecutionEndTime; }

        /// <summary>The start time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? ExecutionStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceExecutionStartTime; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>A string defines maintenance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string MaintenanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceType; }

        /// <summary>Internal Acessors for AvailableScheduleMaxTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.AvailableScheduleMaxTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceAvailableScheduleMaxTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceAvailableScheduleMaxTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for AvailableScheduleMinTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.AvailableScheduleMinTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceAvailableScheduleMinTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceAvailableScheduleMinTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceDescription = value ?? null; }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ExecutionEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.ExecutionEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceExecutionEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceExecutionEndTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for ExecutionStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.ExecutionStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceExecutionStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceExecutionStartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for MaintenanceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.MaintenanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceType = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceProperties Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenanceProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.State { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceState; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceState = value ?? null; }

        /// <summary>Internal Acessors for Title</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceInternal.Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceTitle; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceTitle = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceProperties _property;

        /// <summary>The properties of a maintenance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.MaintenanceProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the Maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The start time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceStartTime = value ?? default(global::System.DateTime); }

        /// <summary>A string describes the maintenance status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceState; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>The maintenance title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenancePropertiesInternal)Property).MaintenanceTitle; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="Maintenance" /> instance.</summary>
        public Maintenance()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Represents a maintenance.
    public partial interface IMaintenance :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IProxyResource
    {
        /// <summary>The max time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The max time the maintenance can be rescheduled.",
        SerializedName = @"maintenanceAvailableScheduleMaxTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AvailableScheduleMaxTime { get;  }
        /// <summary>The min time the maintenance can be rescheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The min time the maintenance can be rescheduled.",
        SerializedName = @"maintenanceAvailableScheduleMinTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AvailableScheduleMinTime { get;  }
        /// <summary>The maintenance description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The maintenance description.",
        SerializedName = @"maintenanceDescription",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The end time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The end time for a maintenance.",
        SerializedName = @"maintenanceEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get;  }
        /// <summary>The end time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The end time for a maintenance execution.",
        SerializedName = @"maintenanceExecutionEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExecutionEndTime { get;  }
        /// <summary>The start time for a maintenance execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The start time for a maintenance execution.",
        SerializedName = @"maintenanceExecutionStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ExecutionStartTime { get;  }
        /// <summary>A string defines maintenance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A string defines maintenance type.",
        SerializedName = @"maintenanceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("RoutineMaintenance", "MinorVersionUpgrade", "SecurityPatches", "HotFixes")]
        string MaintenanceType { get;  }
        /// <summary>Provisioning state of the Maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the Maintenance.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get;  }
        /// <summary>The start time for a maintenance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The start time for a maintenance.",
        SerializedName = @"maintenanceStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>A string describes the maintenance status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A string describes the maintenance status",
        SerializedName = @"maintenanceState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Scheduled", "ReScheduled", "InPreparation", "Processing", "Completed", "Canceled")]
        string State { get;  }
        /// <summary>The maintenance title.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The maintenance title.",
        SerializedName = @"maintenanceTitle",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get;  }

    }
    /// Represents a maintenance.
    internal partial interface IMaintenanceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IProxyResourceInternal
    {
        /// <summary>The max time the maintenance can be rescheduled.</summary>
        global::System.DateTime? AvailableScheduleMaxTime { get; set; }
        /// <summary>The min time the maintenance can be rescheduled.</summary>
        global::System.DateTime? AvailableScheduleMinTime { get; set; }
        /// <summary>The maintenance description.</summary>
        string Description { get; set; }
        /// <summary>The end time for a maintenance.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>The end time for a maintenance execution.</summary>
        global::System.DateTime? ExecutionEndTime { get; set; }
        /// <summary>The start time for a maintenance execution.</summary>
        global::System.DateTime? ExecutionStartTime { get; set; }
        /// <summary>A string defines maintenance type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("RoutineMaintenance", "MinorVersionUpgrade", "SecurityPatches", "HotFixes")]
        string MaintenanceType { get; set; }
        /// <summary>The properties of a maintenance</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IMaintenanceProperties Property { get; set; }
        /// <summary>Provisioning state of the Maintenance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Succeeded", "Creating", "Deleting", "Failed")]
        string ProvisioningState { get; set; }
        /// <summary>The start time for a maintenance.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>A string describes the maintenance status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Scheduled", "ReScheduled", "InPreparation", "Processing", "Completed", "Canceled")]
        string State { get; set; }
        /// <summary>The maintenance title.</summary>
        string Title { get; set; }

    }
}