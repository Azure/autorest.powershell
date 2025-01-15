// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Describes the properties of an Azure Large Instance.</summary>
    public partial class AzureLargeInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AzureLargeInstanceId" /> property.</summary>
        private string _azureLargeInstanceId;

        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string AzureLargeInstanceId { get => this._azureLargeInstanceId; set => this._azureLargeInstanceId = value; }

        /// <summary>Backing field for <see cref="HardwareProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile _hardwareProfile;

        /// <summary>Specifies the hardware settings for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile HardwareProfile { get => (this._hardwareProfile = this._hardwareProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.HardwareProfile()); set => this._hardwareProfile = value; }

        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string HardwareProfileAzureLargeInstanceSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfileInternal)HardwareProfile).AzureLargeInstanceSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfileInternal)HardwareProfile).AzureLargeInstanceSize = value ?? null; }

        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string HardwareProfileHardwareType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfileInternal)HardwareProfile).HardwareType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfileInternal)HardwareProfile).HardwareType = value ?? null; }

        /// <summary>Backing field for <see cref="HwRevision" /> property.</summary>
        private string _hwRevision;

        /// <summary>Hardware revision of an Azure Large Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string HwRevision { get => this._hwRevision; set => this._hwRevision = value; }

        /// <summary>Internal Acessors for HardwareProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal.HardwareProfile { get => (this._hardwareProfile = this._hardwareProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.HardwareProfile()); set { {_hardwareProfile = value;} } }

        /// <summary>Internal Acessors for NetworkProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal.NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.NetworkProfile()); set { {_networkProfile = value;} } }

        /// <summary>Internal Acessors for OSProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal.OSProfile { get => (this._oSProfile = this._oSProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.OSProfile()); set { {_oSProfile = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for StorageProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstancePropertiesInternal.StorageProfile { get => (this._storageProfile = this._storageProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProfile()); set { {_storageProfile = value;} } }

        /// <summary>Backing field for <see cref="NetworkProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile _networkProfile;

        /// <summary>Specifies the network settings for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile NetworkProfile { get => (this._networkProfile = this._networkProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.NetworkProfile()); set => this._networkProfile = value; }

        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string NetworkProfileCircuitId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfileInternal)NetworkProfile).CircuitId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfileInternal)NetworkProfile).CircuitId = value ?? null; }

        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkProfileNetworkInterface { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfileInternal)NetworkProfile).NetworkInterface; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfileInternal)NetworkProfile).NetworkInterface = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="OSProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile _oSProfile;

        /// <summary>Specifies the operating system settings for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile OSProfile { get => (this._oSProfile = this._oSProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.OSProfile()); set => this._oSProfile = value; }

        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileComputerName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).ComputerName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).ComputerName = value ?? null; }

        /// <summary>This property allows you to specify the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileOstype { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).OSType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).OSType = value ?? null; }

        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileSshPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).SshPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).SshPublicKey = value ?? null; }

        /// <summary>Specifies version of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string OSProfileVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfileInternal)OSProfile).Version = value ?? null; }

        /// <summary>Backing field for <see cref="PowerState" /> property.</summary>
        private string _powerState;

        /// <summary>Resource power state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string PowerState { get => this._powerState; set => this._powerState = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>State of provisioning of the AzureLargeInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ProximityPlacementGroup" /> property.</summary>
        private string _proximityPlacementGroup;

        /// <summary>Resource proximity placement group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ProximityPlacementGroup { get => this._proximityPlacementGroup; set => this._proximityPlacementGroup = value; }

        /// <summary>Backing field for <see cref="StorageProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile _storageProfile;

        /// <summary>Specifies the storage settings for the Azure Large Instance disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile StorageProfile { get => (this._storageProfile = this._storageProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProfile()); set => this._storageProfile = value; }

        /// <summary>IP Address to connect to storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public string StorageProfileNfsIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfileInternal)StorageProfile).NfsIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfileInternal)StorageProfile).NfsIPAddress = value ?? null; }

        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> StorageProfileOSDisk { get => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfileInternal)StorageProfile).OSDisk; set => ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfileInternal)StorageProfile).OSDisk = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="AzureLargeInstanceProperties" /> instance.</summary>
        public AzureLargeInstanceProperties()
        {

        }
    }
    /// Describes the properties of an Azure Large Instance.
    public partial interface IAzureLargeInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Azure Large Instance unique ID.",
        SerializedName = @"azureLargeInstanceId",
        PossibleTypes = new [] { typeof(string) })]
        string AzureLargeInstanceId { get; set; }
        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the Azure Large Instance SKU.",
        SerializedName = @"azureLargeInstanceSize",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        string HardwareProfileAzureLargeInstanceSize { get; set; }
        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the hardware type (vendor and/or their product name)",
        SerializedName = @"hardwareType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareProfileHardwareType { get; set; }
        /// <summary>Hardware revision of an Azure Large Instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Hardware revision of an Azure Large Instance",
        SerializedName = @"hwRevision",
        PossibleTypes = new [] { typeof(string) })]
        string HwRevision { get; set; }
        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the circuit id for connecting to express route.",
        SerializedName = @"circuitId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkProfileCircuitId { get; set; }
        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the network interfaces for the Azure Large Instance.",
        SerializedName = @"networkInterfaces",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the host OS name of the Azure Large Instance.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileComputerName { get; set; }
        /// <summary>This property allows you to specify the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property allows you to specify the type of the OS.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileOstype { get; set; }
        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the SSH public key used to access the operating system.",
        SerializedName = @"sshPublicKey",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileSshPublicKey { get; set; }
        /// <summary>Specifies version of operating system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies version of operating system.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string OSProfileVersion { get; set; }
        /// <summary>Resource power state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource power state",
        SerializedName = @"powerState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("starting", "started", "stopping", "stopped", "restarting", "unknown")]
        string PowerState { get; set; }
        /// <summary>State of provisioning of the AzureLargeInstance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"State of provisioning of the AzureLargeInstance",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Migrating", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Resource proximity placement group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource proximity placement group",
        SerializedName = @"proximityPlacementGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ProximityPlacementGroup { get; set; }
        /// <summary>IP Address to connect to storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Address to connect to storage.",
        SerializedName = @"nfsIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StorageProfileNfsIPAddress { get; set; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies information about the operating system disk used by Azure Large
        Instance.",
        SerializedName = @"osDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> StorageProfileOSDisk { get; set; }

    }
    /// Describes the properties of an Azure Large Instance.
    internal partial interface IAzureLargeInstancePropertiesInternal

    {
        /// <summary>Specifies the Azure Large Instance unique ID.</summary>
        string AzureLargeInstanceId { get; set; }
        /// <summary>Specifies the hardware settings for the Azure Large Instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IHardwareProfile HardwareProfile { get; set; }
        /// <summary>Specifies the Azure Large Instance SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("S72m", "S144m", "S72", "S144", "S192", "S192m", "S192xm", "S96", "S112", "S224", "S224m", "S224om", "S224oo", "S224oom", "S224ooo", "S224se", "S384", "S384m", "S384xm", "S384xxm", "S448", "S448m", "S448om", "S448oo", "S448oom", "S448ooo", "S448se", "S576m", "S576xm", "S672", "S672m", "S672om", "S672oo", "S672oom", "S672ooo", "S768", "S768m", "S768xm", "S896", "S896m", "S896om", "S896oo", "S896oom", "S896ooo", "S960m")]
        string HardwareProfileAzureLargeInstanceSize { get; set; }
        /// <summary>Name of the hardware type (vendor and/or their product name)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Cisco_UCS", "HPE", "SDFLEX")]
        string HardwareProfileHardwareType { get; set; }
        /// <summary>Hardware revision of an Azure Large Instance</summary>
        string HwRevision { get; set; }
        /// <summary>Specifies the network settings for the Azure Large Instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.INetworkProfile NetworkProfile { get; set; }
        /// <summary>Specifies the circuit id for connecting to express route.</summary>
        string NetworkProfileCircuitId { get; set; }
        /// <summary>Specifies the network interfaces for the Azure Large Instance.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IIPAddress> NetworkProfileNetworkInterface { get; set; }
        /// <summary>Specifies the operating system settings for the Azure Large Instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IOSProfile OSProfile { get; set; }
        /// <summary>Specifies the host OS name of the Azure Large Instance.</summary>
        string OSProfileComputerName { get; set; }
        /// <summary>This property allows you to specify the type of the OS.</summary>
        string OSProfileOstype { get; set; }
        /// <summary>Specifies the SSH public key used to access the operating system.</summary>
        string OSProfileSshPublicKey { get; set; }
        /// <summary>Specifies version of operating system.</summary>
        string OSProfileVersion { get; set; }
        /// <summary>Resource power state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("starting", "started", "stopping", "stopped", "restarting", "unknown")]
        string PowerState { get; set; }
        /// <summary>State of provisioning of the AzureLargeInstance</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("Accepted", "Creating", "Updating", "Failed", "Succeeded", "Deleting", "Migrating", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Resource proximity placement group</summary>
        string ProximityPlacementGroup { get; set; }
        /// <summary>Specifies the storage settings for the Azure Large Instance disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProfile StorageProfile { get; set; }
        /// <summary>IP Address to connect to storage.</summary>
        string StorageProfileNfsIPAddress { get; set; }
        /// <summary>
        /// Specifies information about the operating system disk used by Azure Large
        /// Instance.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IDisk> StorageProfileOSDisk { get; set; }

    }
}