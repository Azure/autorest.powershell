// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>VMwareToAzStackHCI NIC properties.</summary>
    public partial class VMwareToAzStackHciprotectedNicProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal
    {

        /// <summary>Backing field for <see cref="IsPrimaryNic" /> property.</summary>
        private bool? _isPrimaryNic;

        /// <summary>Gets or sets a value indicating whether this is the primary NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool? IsPrimaryNic { get => this._isPrimaryNic; set => this._isPrimaryNic = value; }

        /// <summary>Backing field for <see cref="Label" /> property.</summary>
        private string _label;

        /// <summary>Gets or sets the NIC label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Label { get => this._label; }

        /// <summary>Backing field for <see cref="MacAddress" /> property.</summary>
        private string _macAddress;

        /// <summary>Gets or sets the NIC mac address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string MacAddress { get => this._macAddress; }

        /// <summary>Internal Acessors for Label</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.Label { get => this._label; set { {_label = value;} } }

        /// <summary>Internal Acessors for MacAddress</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.MacAddress { get => this._macAddress; set { {_macAddress = value;} } }

        /// <summary>Internal Acessors for NetworkName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.NetworkName { get => this._networkName; set { {_networkName = value;} } }

        /// <summary>Internal Acessors for NicId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.NicId { get => this._nicId; set { {_nicId = value;} } }

        /// <summary>Internal Acessors for SelectionTypeForFailover</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.SelectionTypeForFailover { get => this._selectionTypeForFailover; set { {_selectionTypeForFailover = value;} } }

        /// <summary>Internal Acessors for TargetNetworkId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.TargetNetworkId { get => this._targetNetworkId; set { {_targetNetworkId = value;} } }

        /// <summary>Internal Acessors for TestNetworkId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedNicPropertiesInternal.TestNetworkId { get => this._testNetworkId; set { {_testNetworkId = value;} } }

        /// <summary>Backing field for <see cref="NetworkName" /> property.</summary>
        private string _networkName;

        /// <summary>Gets or sets the network name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string NetworkName { get => this._networkName; }

        /// <summary>Backing field for <see cref="NicId" /> property.</summary>
        private string _nicId;

        /// <summary>Gets or sets the NIC Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string NicId { get => this._nicId; }

        /// <summary>Backing field for <see cref="SelectionTypeForFailover" /> property.</summary>
        private string _selectionTypeForFailover;

        /// <summary>Gets or sets the selection type of the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string SelectionTypeForFailover { get => this._selectionTypeForFailover; }

        /// <summary>Backing field for <see cref="TargetNetworkId" /> property.</summary>
        private string _targetNetworkId;

        /// <summary>Gets or sets the target network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TargetNetworkId { get => this._targetNetworkId; }

        /// <summary>Backing field for <see cref="TestNetworkId" /> property.</summary>
        private string _testNetworkId;

        /// <summary>Gets or sets the target test network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string TestNetworkId { get => this._testNetworkId; }

        /// <summary>
        /// Creates an new <see cref="VMwareToAzStackHciprotectedNicProperties" /> instance.
        /// </summary>
        public VMwareToAzStackHciprotectedNicProperties()
        {

        }
    }
    /// VMwareToAzStackHCI NIC properties.
    public partial interface IVMwareToAzStackHciprotectedNicProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets a value indicating whether this is the primary NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets a value indicating whether this is the primary NIC.",
        SerializedName = @"isPrimaryNic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPrimaryNic { get; set; }
        /// <summary>Gets or sets the NIC label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the NIC label.",
        SerializedName = @"label",
        PossibleTypes = new [] { typeof(string) })]
        string Label { get;  }
        /// <summary>Gets or sets the NIC mac address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the NIC mac address.",
        SerializedName = @"macAddress",
        PossibleTypes = new [] { typeof(string) })]
        string MacAddress { get;  }
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
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the NIC Id.",
        SerializedName = @"nicId",
        PossibleTypes = new [] { typeof(string) })]
        string NicId { get;  }
        /// <summary>Gets or sets the selection type of the NIC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the selection type of the NIC.",
        SerializedName = @"selectionTypeForFailover",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PSArgumentCompleterAttribute("NotSelected", "SelectedByUser", "SelectedByDefault", "SelectedByUserOverride")]
        string SelectionTypeForFailover { get;  }
        /// <summary>Gets or sets the target network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target network Id within AzStackHCI Cluster.",
        SerializedName = @"targetNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetNetworkId { get;  }
        /// <summary>Gets or sets the target test network Id within AzStackHCI Cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target test network Id within AzStackHCI Cluster.",
        SerializedName = @"testNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TestNetworkId { get;  }

    }
    /// VMwareToAzStackHCI NIC properties.
    internal partial interface IVMwareToAzStackHciprotectedNicPropertiesInternal

    {
        /// <summary>Gets or sets a value indicating whether this is the primary NIC.</summary>
        bool? IsPrimaryNic { get; set; }
        /// <summary>Gets or sets the NIC label.</summary>
        string Label { get; set; }
        /// <summary>Gets or sets the NIC mac address.</summary>
        string MacAddress { get; set; }
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