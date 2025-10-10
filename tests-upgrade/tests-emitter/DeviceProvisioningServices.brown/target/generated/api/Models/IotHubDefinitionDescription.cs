// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Description of the IoT hub.</summary>
    public partial class IotHubDefinitionDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescriptionInternal
    {

        /// <summary>Backing field for <see cref="AllocationWeight" /> property.</summary>
        private int? _allocationWeight;

        /// <summary>weight to apply for a given iot h.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public int? AllocationWeight { get => this._allocationWeight; set => this._allocationWeight = value; }

        /// <summary>Backing field for <see cref="ApplyAllocationPolicy" /> property.</summary>
        private bool? _applyAllocationPolicy;

        /// <summary>flag for applying allocationPolicy or not for a given iot hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public bool? ApplyAllocationPolicy { get => this._applyAllocationPolicy; set => this._applyAllocationPolicy = value; }

        /// <summary>Backing field for <see cref="ConnectionString" /> property.</summary>
        private string _connectionString;

        /// <summary>Connection string of the IoT hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string ConnectionString { get => this._connectionString; set => this._connectionString = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>ARM region of the IoT hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescriptionInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Host name of the IoT hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="IotHubDefinitionDescription" /> instance.</summary>
        public IotHubDefinitionDescription()
        {

        }
    }
    /// Description of the IoT hub.
    public partial interface IIotHubDefinitionDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>weight to apply for a given iot h.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"weight to apply for a given iot h.",
        SerializedName = @"allocationWeight",
        PossibleTypes = new [] { typeof(int) })]
        int? AllocationWeight { get; set; }
        /// <summary>flag for applying allocationPolicy or not for a given iot hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"flag for applying allocationPolicy or not for a given iot hub.",
        SerializedName = @"applyAllocationPolicy",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ApplyAllocationPolicy { get; set; }
        /// <summary>Connection string of the IoT hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Connection string of the IoT hub.",
        SerializedName = @"connectionString",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionString { get; set; }
        /// <summary>ARM region of the IoT hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM region of the IoT hub.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Host name of the IoT hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Host name of the IoT hub.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Description of the IoT hub.
    internal partial interface IIotHubDefinitionDescriptionInternal

    {
        /// <summary>weight to apply for a given iot h.</summary>
        int? AllocationWeight { get; set; }
        /// <summary>flag for applying allocationPolicy or not for a given iot hub.</summary>
        bool? ApplyAllocationPolicy { get; set; }
        /// <summary>Connection string of the IoT hub.</summary>
        string ConnectionString { get; set; }
        /// <summary>ARM region of the IoT hub.</summary>
        string Location { get; set; }
        /// <summary>Host name of the IoT hub.</summary>
        string Name { get; set; }

    }
}