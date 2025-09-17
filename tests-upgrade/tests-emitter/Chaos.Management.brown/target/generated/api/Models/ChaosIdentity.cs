// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    public partial class ChaosIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IChaosIdentityInternal
    {

        /// <summary>Backing field for <see cref="CapabilityName" /> property.</summary>
        private string _capabilityName;

        /// <summary>String that represents a Capability resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string CapabilityName { get => this._capabilityName; set => this._capabilityName = value; }

        /// <summary>Backing field for <see cref="CapabilityTypeName" /> property.</summary>
        private string _capabilityTypeName;

        /// <summary>String that represents a Capability Type resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string CapabilityTypeName { get => this._capabilityTypeName; set => this._capabilityTypeName = value; }

        /// <summary>Backing field for <see cref="ExecutionId" /> property.</summary>
        private string _executionId;

        /// <summary>GUID that represents a Experiment execution detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ExecutionId { get => this._executionId; set => this._executionId = value; }

        /// <summary>Backing field for <see cref="ExperimentName" /> property.</summary>
        private string _experimentName;

        /// <summary>String that represents a Experiment resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ExperimentName { get => this._experimentName; set => this._experimentName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The name of the Azure region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>The ID of an ongoing async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="ParentProviderNamespace" /> property.</summary>
        private string _parentProviderNamespace;

        /// <summary>The parent resource provider namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ParentProviderNamespace { get => this._parentProviderNamespace; set => this._parentProviderNamespace = value; }

        /// <summary>Backing field for <see cref="ParentResourceName" /> property.</summary>
        private string _parentResourceName;

        /// <summary>The parent resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ParentResourceName { get => this._parentResourceName; set => this._parentResourceName = value; }

        /// <summary>Backing field for <see cref="ParentResourceType" /> property.</summary>
        private string _parentResourceType;

        /// <summary>The parent resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ParentResourceType { get => this._parentResourceType; set => this._parentResourceType = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="TargetName" /> property.</summary>
        private string _targetName;

        /// <summary>String that represents a Target resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string TargetName { get => this._targetName; set => this._targetName = value; }

        /// <summary>Backing field for <see cref="TargetTypeName" /> property.</summary>
        private string _targetTypeName;

        /// <summary>String that represents a Target Type resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string TargetTypeName { get => this._targetTypeName; set => this._targetTypeName = value; }

        /// <summary>Creates an new <see cref="ChaosIdentity" /> instance.</summary>
        public ChaosIdentity()
        {

        }
    }
    public partial interface IChaosIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable
    {
        /// <summary>String that represents a Capability resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a Capability resource name.",
        SerializedName = @"capabilityName",
        PossibleTypes = new [] { typeof(string) })]
        string CapabilityName { get; set; }
        /// <summary>String that represents a Capability Type resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a Capability Type resource name.",
        SerializedName = @"capabilityTypeName",
        PossibleTypes = new [] { typeof(string) })]
        string CapabilityTypeName { get; set; }
        /// <summary>GUID that represents a Experiment execution detail.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"GUID that represents a Experiment execution detail.",
        SerializedName = @"executionId",
        PossibleTypes = new [] { typeof(string) })]
        string ExecutionId { get; set; }
        /// <summary>String that represents a Experiment resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a Experiment resource name.",
        SerializedName = @"experimentName",
        PossibleTypes = new [] { typeof(string) })]
        string ExperimentName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the Azure region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Azure region.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The ID of an ongoing async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of an ongoing async operation.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>The parent resource provider namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The parent resource provider namespace.",
        SerializedName = @"parentProviderNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ParentProviderNamespace { get; set; }
        /// <summary>The parent resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The parent resource name.",
        SerializedName = @"parentResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ParentResourceName { get; set; }
        /// <summary>The parent resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The parent resource type.",
        SerializedName = @"parentResourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ParentResourceType { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>String that represents a Target resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a Target resource name.",
        SerializedName = @"targetName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetName { get; set; }
        /// <summary>String that represents a Target Type resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"String that represents a Target Type resource name.",
        SerializedName = @"targetTypeName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetTypeName { get; set; }

    }
    internal partial interface IChaosIdentityInternal

    {
        /// <summary>String that represents a Capability resource name.</summary>
        string CapabilityName { get; set; }
        /// <summary>String that represents a Capability Type resource name.</summary>
        string CapabilityTypeName { get; set; }
        /// <summary>GUID that represents a Experiment execution detail.</summary>
        string ExecutionId { get; set; }
        /// <summary>String that represents a Experiment resource name.</summary>
        string ExperimentName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the Azure region.</summary>
        string Location { get; set; }
        /// <summary>The ID of an ongoing async operation.</summary>
        string OperationId { get; set; }
        /// <summary>The parent resource provider namespace.</summary>
        string ParentProviderNamespace { get; set; }
        /// <summary>The parent resource name.</summary>
        string ParentResourceName { get; set; }
        /// <summary>The parent resource type.</summary>
        string ParentResourceType { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>String that represents a Target resource name.</summary>
        string TargetName { get; set; }
        /// <summary>String that represents a Target Type resource name.</summary>
        string TargetTypeName { get; set; }

    }
}