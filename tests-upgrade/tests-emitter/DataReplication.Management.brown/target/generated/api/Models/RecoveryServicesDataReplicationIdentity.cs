// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    public partial class RecoveryServicesDataReplicationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IRecoveryServicesDataReplicationIdentityInternal
    {

        /// <summary>Backing field for <see cref="DeploymentId" /> property.</summary>
        private string _deploymentId;

        /// <summary>Deployment Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string DeploymentId { get => this._deploymentId; set => this._deploymentId = value; }

        /// <summary>Backing field for <see cref="EmailConfigurationName" /> property.</summary>
        private string _emailConfigurationName;

        /// <summary>The email configuration name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string EmailConfigurationName { get => this._emailConfigurationName; set => this._emailConfigurationName = value; }

        /// <summary>Backing field for <see cref="EventName" /> property.</summary>
        private string _eventName;

        /// <summary>The event name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string EventName { get => this._eventName; set => this._eventName = value; }

        /// <summary>Backing field for <see cref="FabricAgentName" /> property.</summary>
        private string _fabricAgentName;

        /// <summary>The fabric agent name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricAgentName { get => this._fabricAgentName; set => this._fabricAgentName = value; }

        /// <summary>Backing field for <see cref="FabricName" /> property.</summary>
        private string _fabricName;

        /// <summary>The fabric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string FabricName { get => this._fabricName; set => this._fabricName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="JobName" /> property.</summary>
        private string _jobName;

        /// <summary>The job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string JobName { get => this._jobName; set => this._jobName = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The name of the Azure region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private string _operationId;

        /// <summary>The ID of an ongoing async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Backing field for <see cref="PolicyName" /> property.</summary>
        private string _policyName;

        /// <summary>The policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string PolicyName { get => this._policyName; set => this._policyName = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnectionName" /> property.</summary>
        private string _privateEndpointConnectionName;

        /// <summary>The private endpoint connection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string PrivateEndpointConnectionName { get => this._privateEndpointConnectionName; set => this._privateEndpointConnectionName = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnectionProxyName" /> property.</summary>
        private string _privateEndpointConnectionProxyName;

        /// <summary>The private endpoint connection proxy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string PrivateEndpointConnectionProxyName { get => this._privateEndpointConnectionProxyName; set => this._privateEndpointConnectionProxyName = value; }

        /// <summary>Backing field for <see cref="PrivateLinkResourceName" /> property.</summary>
        private string _privateLinkResourceName;

        /// <summary>The private link name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string PrivateLinkResourceName { get => this._privateLinkResourceName; set => this._privateLinkResourceName = value; }

        /// <summary>Backing field for <see cref="ProtectedItemName" /> property.</summary>
        private string _protectedItemName;

        /// <summary>The protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ProtectedItemName { get => this._protectedItemName; set => this._protectedItemName = value; }

        /// <summary>Backing field for <see cref="RecoveryPointName" /> property.</summary>
        private string _recoveryPointName;

        /// <summary>The recovery point name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string RecoveryPointName { get => this._recoveryPointName; set => this._recoveryPointName = value; }

        /// <summary>Backing field for <see cref="ReplicationExtensionName" /> property.</summary>
        private string _replicationExtensionName;

        /// <summary>The replication extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ReplicationExtensionName { get => this._replicationExtensionName; set => this._replicationExtensionName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="VaultName" /> property.</summary>
        private string _vaultName;

        /// <summary>The vault name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string VaultName { get => this._vaultName; set => this._vaultName = value; }

        /// <summary>Creates an new <see cref="RecoveryServicesDataReplicationIdentity" /> instance.</summary>
        public RecoveryServicesDataReplicationIdentity()
        {

        }
    }
    public partial interface IRecoveryServicesDataReplicationIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Deployment Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Deployment Id.",
        SerializedName = @"deploymentId",
        PossibleTypes = new [] { typeof(string) })]
        string DeploymentId { get; set; }
        /// <summary>The email configuration name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The email configuration name.",
        SerializedName = @"emailConfigurationName",
        PossibleTypes = new [] { typeof(string) })]
        string EmailConfigurationName { get; set; }
        /// <summary>The event name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The event name.",
        SerializedName = @"eventName",
        PossibleTypes = new [] { typeof(string) })]
        string EventName { get; set; }
        /// <summary>The fabric agent name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fabric agent name.",
        SerializedName = @"fabricAgentName",
        PossibleTypes = new [] { typeof(string) })]
        string FabricAgentName { get; set; }
        /// <summary>The fabric name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fabric name.",
        SerializedName = @"fabricName",
        PossibleTypes = new [] { typeof(string) })]
        string FabricName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The job name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The job name.",
        SerializedName = @"jobName",
        PossibleTypes = new [] { typeof(string) })]
        string JobName { get; set; }
        /// <summary>The name of the Azure region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of an ongoing async operation.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationId { get; set; }
        /// <summary>The policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The policy name.",
        SerializedName = @"policyName",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyName { get; set; }
        /// <summary>The private endpoint connection name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private endpoint connection name.",
        SerializedName = @"privateEndpointConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>The private endpoint connection proxy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private endpoint connection proxy name.",
        SerializedName = @"privateEndpointConnectionProxyName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointConnectionProxyName { get; set; }
        /// <summary>The private link name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The private link name.",
        SerializedName = @"privateLinkResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceName { get; set; }
        /// <summary>The protected item name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The protected item name.",
        SerializedName = @"protectedItemName",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectedItemName { get; set; }
        /// <summary>The recovery point name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The recovery point name.",
        SerializedName = @"recoveryPointName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPointName { get; set; }
        /// <summary>The replication extension name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The replication extension name.",
        SerializedName = @"replicationExtensionName",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationExtensionName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The vault name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The vault name.",
        SerializedName = @"vaultName",
        PossibleTypes = new [] { typeof(string) })]
        string VaultName { get; set; }

    }
    internal partial interface IRecoveryServicesDataReplicationIdentityInternal

    {
        /// <summary>Deployment Id.</summary>
        string DeploymentId { get; set; }
        /// <summary>The email configuration name.</summary>
        string EmailConfigurationName { get; set; }
        /// <summary>The event name.</summary>
        string EventName { get; set; }
        /// <summary>The fabric agent name.</summary>
        string FabricAgentName { get; set; }
        /// <summary>The fabric name.</summary>
        string FabricName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The job name.</summary>
        string JobName { get; set; }
        /// <summary>The name of the Azure region.</summary>
        string Location { get; set; }
        /// <summary>The ID of an ongoing async operation.</summary>
        string OperationId { get; set; }
        /// <summary>The policy name.</summary>
        string PolicyName { get; set; }
        /// <summary>The private endpoint connection name.</summary>
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>The private endpoint connection proxy name.</summary>
        string PrivateEndpointConnectionProxyName { get; set; }
        /// <summary>The private link name.</summary>
        string PrivateLinkResourceName { get; set; }
        /// <summary>The protected item name.</summary>
        string ProtectedItemName { get; set; }
        /// <summary>The recovery point name.</summary>
        string RecoveryPointName { get; set; }
        /// <summary>The replication extension name.</summary>
        string ReplicationExtensionName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The vault name.</summary>
        string VaultName { get; set; }

    }
}