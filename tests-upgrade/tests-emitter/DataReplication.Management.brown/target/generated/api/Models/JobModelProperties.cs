// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Job model properties.</summary>
    public partial class JobModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ActivityId" /> property.</summary>
        private string _activityId;

        /// <summary>Gets or sets the job activity id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ActivityId { get => this._activityId; }

        /// <summary>Description of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetailDescription; }

        /// <summary>Type of the affected object details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetailType; }

        /// <summary>Backing field for <see cref="AllowedAction" /> property.</summary>
        private System.Collections.Generic.List<string> _allowedAction;

        /// <summary>Gets or sets the list of allowed actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AllowedAction { get => this._allowedAction; }

        /// <summary>Backing field for <see cref="CustomProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties _customProperty;

        /// <summary>Job model custom properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.JobModelCustomProperties()); set => this._customProperty = value; }

        /// <summary>Discriminator property for JobModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).InstanceType = value ; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Gets or sets the friendly display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>Gets or sets the end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> _error;

        /// <summary>Gets or sets the list of errors.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> Error { get => this._error; }

        /// <summary>Internal Acessors for ActivityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ActivityId { get => this._activityId; set { {_activityId = value;} } }

        /// <summary>Internal Acessors for AffectedObjectDetailDescription</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.AffectedObjectDetailDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetailDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetailDescription = value ?? null; }

        /// <summary>Internal Acessors for AffectedObjectDetailType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.AffectedObjectDetailType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetailType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetailType = value ?? null; }

        /// <summary>Internal Acessors for AllowedAction</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.AllowedAction { get => this._allowedAction; set { {_allowedAction = value;} } }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.JobModelCustomProperties()); set { {_customProperty = value;} } }

        /// <summary>Internal Acessors for CustomPropertyAffectedObjectDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IAffectedObjectDetails Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.CustomPropertyAffectedObjectDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelCustomPropertiesInternal)CustomProperty).AffectedObjectDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for EndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.EndTime { get => this._endTime; set { {_endTime = value;} } }

        /// <summary>Internal Acessors for Error</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IErrorModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.Error { get => this._error; set { {_error = value;} } }

        /// <summary>Internal Acessors for ObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ObjectId { get => this._objectId; set { {_objectId = value;} } }

        /// <summary>Internal Acessors for ObjectInternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ObjectInternalId { get => this._objectInternalId; set { {_objectInternalId = value;} } }

        /// <summary>Internal Acessors for ObjectInternalName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ObjectInternalName { get => this._objectInternalName; set { {_objectInternalName = value;} } }

        /// <summary>Internal Acessors for ObjectName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ObjectName { get => this._objectName; set { {_objectName = value;} } }

        /// <summary>Internal Acessors for ObjectType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ObjectType { get => this._objectType; set { {_objectType = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ReplicationProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.ReplicationProviderId { get => this._replicationProviderId; set { {_replicationProviderId = value;} } }

        /// <summary>Internal Acessors for SourceFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.SourceFabricProviderId { get => this._sourceFabricProviderId; set { {_sourceFabricProviderId = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.StartTime { get => this._startTime; set { {_startTime = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for TargetFabricProviderId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.TargetFabricProviderId { get => this._targetFabricProviderId; set { {_targetFabricProviderId = value;} } }

        /// <summary>Internal Acessors for Task</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IJobModelPropertiesInternal.Task { get => this._task; set { {_task = value;} } }

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>Gets or sets the affected object Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; }

        /// <summary>Backing field for <see cref="ObjectInternalId" /> property.</summary>
        private string _objectInternalId;

        /// <summary>Gets or sets the affected object internal Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ObjectInternalId { get => this._objectInternalId; }

        /// <summary>Backing field for <see cref="ObjectInternalName" /> property.</summary>
        private string _objectInternalName;

        /// <summary>Gets or sets the affected object internal name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ObjectInternalName { get => this._objectInternalName; }

        /// <summary>Backing field for <see cref="ObjectName" /> property.</summary>
        private string _objectName;

        /// <summary>Gets or sets the affected object name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ObjectName { get => this._objectName; }

        /// <summary>Backing field for <see cref="ObjectType" /> property.</summary>
        private string _objectType;

        /// <summary>Gets or sets the object type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ObjectType { get => this._objectType; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets or sets the provisioning state of the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ReplicationProviderId" /> property.</summary>
        private string _replicationProviderId;

        /// <summary>Gets or sets the replication provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ReplicationProviderId { get => this._replicationProviderId; }

        /// <summary>Backing field for <see cref="SourceFabricProviderId" /> property.</summary>
        private string _sourceFabricProviderId;

        /// <summary>Gets or sets the source fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string SourceFabricProviderId { get => this._sourceFabricProviderId; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>Gets or sets the start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>Gets or sets the job state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string State { get => this._state; }

        /// <summary>Backing field for <see cref="TargetFabricProviderId" /> property.</summary>
        private string _targetFabricProviderId;

        /// <summary>Gets or sets the target fabric provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TargetFabricProviderId { get => this._targetFabricProviderId; }

        /// <summary>Backing field for <see cref="Task" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> _task;

        /// <summary>Gets or sets the list of tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModel> Task { get => this._task; }

        /// <summary>Creates an new <see cref="JobModelProperties" /> instance.</summary>
        public JobModelProperties()
        {

        }
    }
    /// Job model properties.
    public partial interface IJobModelProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
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
        Required = true,
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
    /// Job model properties.
    internal partial interface IJobModelPropertiesInternal

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