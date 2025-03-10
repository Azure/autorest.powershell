// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    public partial class StandbyPoolIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyPoolIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyPoolIdentityInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="RuntimeView" /> property.</summary>
        private string _runtimeView;

        /// <summary>
        /// The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime
        /// view of the pool, otherwise the request will fail with NotFound exception.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string RuntimeView { get => this._runtimeView; set => this._runtimeView = value; }

        /// <summary>Backing field for <see cref="StandbyContainerGroupPoolName" /> property.</summary>
        private string _standbyContainerGroupPoolName;

        /// <summary>Name of the standby container group pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string StandbyContainerGroupPoolName { get => this._standbyContainerGroupPoolName; set => this._standbyContainerGroupPoolName = value; }

        /// <summary>Backing field for <see cref="StandbyVirtualMachineName" /> property.</summary>
        private string _standbyVirtualMachineName;

        /// <summary>Name of the standby virtual machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string StandbyVirtualMachineName { get => this._standbyVirtualMachineName; set => this._standbyVirtualMachineName = value; }

        /// <summary>Backing field for <see cref="StandbyVirtualMachinePoolName" /> property.</summary>
        private string _standbyVirtualMachinePoolName;

        /// <summary>Name of the standby virtual machine pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string StandbyVirtualMachinePoolName { get => this._standbyVirtualMachinePoolName; set => this._standbyVirtualMachinePoolName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="StandbyPoolIdentity" /> instance.</summary>
        public StandbyPoolIdentity()
        {

        }
    }
    public partial interface IStandbyPoolIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime
        /// view of the pool, otherwise the request will fail with NotFound exception.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime view of the pool, otherwise the request will fail with NotFound exception.",
        SerializedName = @"runtimeView",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimeView { get; set; }
        /// <summary>Name of the standby container group pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the standby container group pool",
        SerializedName = @"standbyContainerGroupPoolName",
        PossibleTypes = new [] { typeof(string) })]
        string StandbyContainerGroupPoolName { get; set; }
        /// <summary>Name of the standby virtual machine</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the standby virtual machine",
        SerializedName = @"standbyVirtualMachineName",
        PossibleTypes = new [] { typeof(string) })]
        string StandbyVirtualMachineName { get; set; }
        /// <summary>Name of the standby virtual machine pool</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the standby virtual machine pool",
        SerializedName = @"standbyVirtualMachinePoolName",
        PossibleTypes = new [] { typeof(string) })]
        string StandbyVirtualMachinePoolName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IStandbyPoolIdentityInternal

    {
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The unique identifier for the runtime view. The input string should be the word 'latest', which will get the latest runtime
        /// view of the pool, otherwise the request will fail with NotFound exception.
        /// </summary>
        string RuntimeView { get; set; }
        /// <summary>Name of the standby container group pool</summary>
        string StandbyContainerGroupPoolName { get; set; }
        /// <summary>Name of the standby virtual machine</summary>
        string StandbyVirtualMachineName { get; set; }
        /// <summary>Name of the standby virtual machine pool</summary>
        string StandbyVirtualMachinePoolName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}