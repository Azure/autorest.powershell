// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    /// </summary>
    public partial class FleetMemberProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClusterResourceId" /> property.</summary>
        private string _clusterResourceId;

        /// <summary>
        /// The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ClusterResourceId { get => this._clusterResourceId; set => this._clusterResourceId = value; }

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private string _group;

        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Group { get => this._group; set => this._group = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels _label;

        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels Label { get => (this._label = this._label ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberPropertiesLabels()); set => this._label = value; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorAdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorCode; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorDetail; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorMessage; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorTarget; }

        /// <summary>Internal Acessors for LastOperationErrorAdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.LastOperationErrorAdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorAdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorAdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.LastOperationErrorCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorCode = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.LastOperationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for LastOperationErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.LastOperationErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorMessage = value ?? null; }

        /// <summary>Internal Acessors for LastOperationErrorTarget</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.LastOperationErrorTarget { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorTarget; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationErrorTarget = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberStatus()); set { {_status = value;} } }

        /// <summary>Internal Acessors for StatusLastOperationError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.StatusLastOperationError { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationError; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationError = value ?? null /* model class */; }

        /// <summary>Internal Acessors for StatusLastOperationId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesInternal.StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationId = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus _status;

        /// <summary>Status information of the last operation for fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus Status { get => (this._status = this._status ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.FleetMemberStatus()); }

        /// <summary>The last operation ID for the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Inlined)]
        public string StatusLastOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatusInternal)Status).LastOperationId; }

        /// <summary>Creates an new <see cref="FleetMemberProperties" /> instance.</summary>
        public FleetMemberProperties()
        {

        }
    }
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    public partial interface IFleetMemberProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.",
        SerializedName = @"clusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterResourceId { get; set; }
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The group this member belongs to for multi-cluster update management.",
        SerializedName = @"group",
        PossibleTypes = new [] { typeof(string) })]
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The labels for the fleet member.",
        SerializedName = @"labels",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels Label { get; set; }
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorCode { get;  }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get;  }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorMessage { get;  }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string LastOperationErrorTarget { get;  }
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Joining", "Leaving", "Updating")]
        string ProvisioningState { get;  }
        /// <summary>The last operation ID for the fleet member</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The last operation ID for the fleet member",
        SerializedName = @"lastOperationId",
        PossibleTypes = new [] { typeof(string) })]
        string StatusLastOperationId { get;  }

    }
    /// A member of the Fleet. It contains a reference to an existing Kubernetes cluster on Azure.
    internal partial interface IFleetMemberPropertiesInternal

    {
        /// <summary>
        /// The ARM resource id of the cluster that joins the Fleet. Must be a valid Azure resource id. e.g.: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{clusterName}'.
        /// </summary>
        string ClusterResourceId { get; set; }
        /// <summary>The group this member belongs to for multi-cluster update management.</summary>
        string Group { get; set; }
        /// <summary>The labels for the fleet member.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberPropertiesLabels Label { get; set; }
        /// <summary>The error additional info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo> LastOperationErrorAdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string LastOperationErrorCode { get; set; }
        /// <summary>The error details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail> LastOperationErrorDetail { get; set; }
        /// <summary>The error message.</summary>
        string LastOperationErrorMessage { get; set; }
        /// <summary>The error target.</summary>
        string LastOperationErrorTarget { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Joining", "Leaving", "Updating")]
        string ProvisioningState { get; set; }
        /// <summary>Status information of the last operation for fleet member.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IFleetMemberStatus Status { get; set; }
        /// <summary>The last operation error of the fleet member</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail StatusLastOperationError { get; set; }
        /// <summary>The last operation ID for the fleet member</summary>
        string StatusLastOperationId { get; set; }

    }
}