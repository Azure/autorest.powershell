// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>VMwareToAzStackHCI NIC properties.</summary>
    public partial class VMwareToAzStackHcinicInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInput,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInputInternal
    {

        /// <summary>Backing field for <see cref="IsMacMigrationEnabled" /> property.</summary>
        private bool? _isMacMigrationEnabled;

        /// <summary>Gets or sets a value indicating whether mac address migration is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool? IsMacMigrationEnabled { get => this._isMacMigrationEnabled; set => this._isMacMigrationEnabled = value; }

        /// <summary>Backing field for <see cref="IsStaticIPMigrationEnabled" /> property.</summary>
        private bool? _isStaticIPMigrationEnabled;

        /// <summary>Gets or sets a value indicating whether static ip migration is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool? IsStaticIPMigrationEnabled { get => this._isStaticIPMigrationEnabled; set => this._isStaticIPMigrationEnabled = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>Gets or sets the NIC label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Label { get => this._label; set => this._label = value; }

        /// <summary>Internal Acessors for NetworkName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInputInternal.NetworkName { get => this._networkName; set { {_networkName = value;} } }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>Gets or sets the network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>Gets or sets the NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; set => this._nicId = value; }

        /// <summary>Backing field for <see cref="SelectionTypeForFailover" /> property.</summary>
        private string _selectionTypeForFailover;

        /// <summary>Gets or sets the selection type of the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string SelectionTypeForFailover { get => this._selectionTypeForFailover; set => this._selectionTypeForFailover = value; }

        /// <summary>Backing field for <see cref="TargetNetworkId" /> property.</summary>
        private string _targetNetworkId;

        /// <summary>Gets or sets the target network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TargetNetworkId { get => this._targetNetworkId; set => this._targetNetworkId = value; }

        /// <summary>Backing field for <see cref="TestNetworkId" /> property.</summary>
        private string _testNetworkId;

        /// <summary>Gets or sets the target test network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TestNetworkId { get => this._testNetworkId; set => this._testNetworkId = value; }

        /// <summary>Creates an new <see cref="VMwareToAzStackHcinicInput" /> instance.</summary>
        public VMwareToAzStackHcinicInput()
        {

        }
    }
    /// VMwareToAzStackHCI NIC properties.
    public partial interface IVMwareToAzStackHcinicInput :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets a value indicating whether mac address migration is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets a value indicating whether mac address migration is enabled.",
        SerializedName = @"isMacMigrationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsMacMigrationEnabled { get; set; }
        /// <summary>Gets or sets a value indicating whether static ip migration is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets a value indicating whether static ip migration is enabled.",
        SerializedName = @"isStaticIpMigrationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsStaticIPMigrationEnabled { get; set; }
        /// <summary>Gets or sets the NIC label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the NIC label.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get; set; }
        /// <summary>Gets or sets the network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the network name.",
        SerializedName = @"networkName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get;  }
        /// <summary>Gets or sets the NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the NIC Id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get; set; }
        /// <summary>Gets or sets the selection type of the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the selection type of the NIC.",
        SerializedName = @"selectionTypeForFailover",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("NotSelected", "SelectedByUser", "SelectedByDefault", "SelectedByUserOverride")]
        string SelectionTypeForFailover { get; set; }
        /// <summary>Gets or sets the target network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the target network Id within AzStackHCI Cluster.",
        SerializedName = @"targetNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNetworkId { get; set; }
        /// <summary>Gets or sets the target test network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the target test network Id within AzStackHCI Cluster.",
        SerializedName = @"testNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TestNetworkId { get; set; }

    }
    /// VMwareToAzStackHCI NIC properties.
    internal partial interface IVMwareToAzStackHcinicInputInternal

    {
        /// <summary>Gets or sets a value indicating whether mac address migration is enabled.</summary>
        bool? IsMacMigrationEnabled { get; set; }
        /// <summary>Gets or sets a value indicating whether static ip migration is enabled.</summary>
        bool? IsStaticIPMigrationEnabled { get; set; }
        /// <summary>Gets or sets the NIC label.</summary>
        string Label { get; set; }
        /// <summary>Gets or sets the network name.</summary>
        string NetworkName { get; set; }
        /// <summary>Gets or sets the NIC Id.</summary>
        string NicId { get; set; }
        /// <summary>Gets or sets the selection type of the NIC.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("NotSelected", "SelectedByUser", "SelectedByDefault", "SelectedByUserOverride")]
        string SelectionTypeForFailover { get; set; }
        /// <summary>Gets or sets the target network Id within AzStackHCI Cluster.</summary>
        string TargetNetworkId { get; set; }
        /// <summary>Gets or sets the target test network Id within AzStackHCI Cluster.</summary>
        string TestNetworkId { get; set; }

    }
}