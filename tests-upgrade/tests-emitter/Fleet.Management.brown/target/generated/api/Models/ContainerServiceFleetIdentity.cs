// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    public partial class ContainerServiceFleetIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IContainerServiceFleetIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IContainerServiceFleetIdentityInternal
    {

        /// <summary>Backing field for <see cref="AutoUpgradeProfileName" /> property.</summary>
        private string _autoUpgradeProfileName;

        /// <summary>The name of the AutoUpgradeProfile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string AutoUpgradeProfileName { get => this._autoUpgradeProfileName; set => this._autoUpgradeProfileName = value; }

        /// <summary>Backing field for <see cref="FleetMemberName" /> property.</summary>
        private string _fleetMemberName;

        /// <summary>The name of the Fleet member resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string FleetMemberName { get => this._fleetMemberName; set => this._fleetMemberName = value; }

        /// <summary>Backing field for <see cref="FleetName" /> property.</summary>
        private string _fleetName;

        /// <summary>The name of the Fleet resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string FleetName { get => this._fleetName; set => this._fleetName = value; }

        /// <summary>Backing field for <see cref="GateName" /> property.</summary>
        private string _gateName;

        /// <summary>The name of the Gate resource, a GUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string GateName { get => this._gateName; set => this._gateName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="UpdateRunName" /> property.</summary>
        private string _updateRunName;

        /// <summary>The name of the UpdateRun resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string UpdateRunName { get => this._updateRunName; set => this._updateRunName = value; }

        /// <summary>Backing field for <see cref="UpdateStrategyName" /> property.</summary>
        private string _updateStrategyName;

        /// <summary>The name of the UpdateStrategy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string UpdateStrategyName { get => this._updateStrategyName; set => this._updateStrategyName = value; }

        /// <summary>Creates an new <see cref="ContainerServiceFleetIdentity" /> instance.</summary>
        public ContainerServiceFleetIdentity()
        {

        }
    }
    public partial interface IContainerServiceFleetIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The name of the AutoUpgradeProfile resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the AutoUpgradeProfile resource.",
        SerializedName = @"autoUpgradeProfileName",
        PossibleTypes = new [] { typeof(string) })]
        string AutoUpgradeProfileName { get; set; }
        /// <summary>The name of the Fleet member resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Fleet member resource.",
        SerializedName = @"fleetMemberName",
        PossibleTypes = new [] { typeof(string) })]
        string FleetMemberName { get; set; }
        /// <summary>The name of the Fleet resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Fleet resource.",
        SerializedName = @"fleetName",
        PossibleTypes = new [] { typeof(string) })]
        string FleetName { get; set; }
        /// <summary>The name of the Gate resource, a GUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Gate resource, a GUID.",
        SerializedName = @"gateName",
        PossibleTypes = new [] { typeof(string) })]
        string GateName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
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
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The name of the UpdateRun resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the UpdateRun resource.",
        SerializedName = @"updateRunName",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateRunName { get; set; }
        /// <summary>The name of the UpdateStrategy resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the UpdateStrategy resource.",
        SerializedName = @"updateStrategyName",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateStrategyName { get; set; }

    }
    internal partial interface IContainerServiceFleetIdentityInternal

    {
        /// <summary>The name of the AutoUpgradeProfile resource.</summary>
        string AutoUpgradeProfileName { get; set; }
        /// <summary>The name of the Fleet member resource.</summary>
        string FleetMemberName { get; set; }
        /// <summary>The name of the Fleet resource.</summary>
        string FleetName { get; set; }
        /// <summary>The name of the Gate resource, a GUID.</summary>
        string GateName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The name of the UpdateRun resource.</summary>
        string UpdateRunName { get; set; }
        /// <summary>The name of the UpdateStrategy resource.</summary>
        string UpdateStrategyName { get; set; }

    }
}