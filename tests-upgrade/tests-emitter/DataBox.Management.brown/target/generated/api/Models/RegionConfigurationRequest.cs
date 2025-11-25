// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request body to get the configuration for the region.</summary>
    public partial class RegionConfigurationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal
    {

        /// <summary>Backing field for <see cref="DatacenterAddressRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequest _datacenterAddressRequest;

        /// <summary>Request body to get the datacenter address for given sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequest DatacenterAddressRequest { get => (this._datacenterAddressRequest = this._datacenterAddressRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressRequest()); set => this._datacenterAddressRequest = value; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressRequestModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequestInternal)DatacenterAddressRequest).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequestInternal)DatacenterAddressRequest).Model = value ?? null; }

        /// <summary>Sku Name for which the data center address requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressRequestSkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequestInternal)DatacenterAddressRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequestInternal)DatacenterAddressRequest).SkuName = value ?? null; }

        /// <summary>
        /// Storage location. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressRequestStorageLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequestInternal)DatacenterAddressRequest).StorageLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequestInternal)DatacenterAddressRequest).StorageLocation = value ?? null; }

        /// <summary>Backing field for <see cref="DeviceCapabilityRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest _deviceCapabilityRequest;

        /// <summary>Request body to get the device capabilities for a given sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest DeviceCapabilityRequest { get => (this._deviceCapabilityRequest = this._deviceCapabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceCapabilityRequest()); set => this._deviceCapabilityRequest = value; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeviceCapabilityRequestModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequestInternal)DeviceCapabilityRequest).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequestInternal)DeviceCapabilityRequest).Model = value ?? null; }

        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeviceCapabilityRequestSkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequestInternal)DeviceCapabilityRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequestInternal)DeviceCapabilityRequest).SkuName = value ?? null; }

        /// <summary>Internal Acessors for DatacenterAddressRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequest Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal.DatacenterAddressRequest { get => (this._datacenterAddressRequest = this._datacenterAddressRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressRequest()); set { {_datacenterAddressRequest = value;} } }

        /// <summary>Internal Acessors for DeviceCapabilityRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal.DeviceCapabilityRequest { get => (this._deviceCapabilityRequest = this._deviceCapabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceCapabilityRequest()); set { {_deviceCapabilityRequest = value;} } }

        /// <summary>Internal Acessors for ScheduleAvailabilityRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal.ScheduleAvailabilityRequest { get => (this._scheduleAvailabilityRequest = this._scheduleAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityRequest()); set { {_scheduleAvailabilityRequest = value;} } }

        /// <summary>Internal Acessors for TransportAvailabilityRequest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequest Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationRequestInternal.TransportAvailabilityRequest { get => (this._transportAvailabilityRequest = this._transportAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportAvailabilityRequest()); set { {_transportAvailabilityRequest = value;} } }

        /// <summary>Backing field for <see cref="ScheduleAvailabilityRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest _scheduleAvailabilityRequest;

        /// <summary>Request body to get the availability for scheduling orders.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest ScheduleAvailabilityRequest { get => (this._scheduleAvailabilityRequest = this._scheduleAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityRequest()); set => this._scheduleAvailabilityRequest = value; }

        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ScheduleAvailabilityRequestCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).Country = value ?? null; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ScheduleAvailabilityRequestModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).Model = value ?? null; }

        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ScheduleAvailabilityRequestSkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).SkuName = value ?? null; }

        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ScheduleAvailabilityRequestStorageLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).StorageLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal)ScheduleAvailabilityRequest).StorageLocation = value ?? null; }

        /// <summary>Backing field for <see cref="TransportAvailabilityRequest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequest _transportAvailabilityRequest;

        /// <summary>Request body to get the transport availability for given sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequest TransportAvailabilityRequest { get => (this._transportAvailabilityRequest = this._transportAvailabilityRequest ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportAvailabilityRequest()); set => this._transportAvailabilityRequest = value; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransportAvailabilityRequestModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequestInternal)TransportAvailabilityRequest).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequestInternal)TransportAvailabilityRequest).Model = value ?? null; }

        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransportAvailabilityRequestSkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequestInternal)TransportAvailabilityRequest).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequestInternal)TransportAvailabilityRequest).SkuName = value ?? null; }

        /// <summary>Creates an new <see cref="RegionConfigurationRequest" /> instance.</summary>
        public RegionConfigurationRequest()
        {

        }
    }
    /// Request body to get the configuration for the region.
    public partial interface IRegionConfigurationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string DatacenterAddressRequestModel { get; set; }
        /// <summary>Sku Name for which the data center address requested.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sku Name for which the data center address requested.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DatacenterAddressRequestSkuName { get; set; }
        /// <summary>
        /// Storage location. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage location. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01",
        SerializedName = @"storageLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DatacenterAddressRequestStorageLocation { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string DeviceCapabilityRequestModel { get; set; }
        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the device.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceCapabilityRequestSkuName { get; set; }
        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Country in which storage location should be supported.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleAvailabilityRequestCountry { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string ScheduleAvailabilityRequestModel { get; set; }
        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sku Name for which the order is to be scheduled.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string ScheduleAvailabilityRequestSkuName { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01",
        SerializedName = @"storageLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleAvailabilityRequestStorageLocation { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string TransportAvailabilityRequestModel { get; set; }
        /// <summary>Type of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the device.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string TransportAvailabilityRequestSkuName { get; set; }

    }
    /// Request body to get the configuration for the region.
    internal partial interface IRegionConfigurationRequestInternal

    {
        /// <summary>Request body to get the datacenter address for given sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressRequest DatacenterAddressRequest { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string DatacenterAddressRequestModel { get; set; }
        /// <summary>Sku Name for which the data center address requested.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DatacenterAddressRequestSkuName { get; set; }
        /// <summary>
        /// Storage location. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        string DatacenterAddressRequestStorageLocation { get; set; }
        /// <summary>Request body to get the device capabilities for a given sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityRequest DeviceCapabilityRequest { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string DeviceCapabilityRequestModel { get; set; }
        /// <summary>Type of the device.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceCapabilityRequestSkuName { get; set; }
        /// <summary>Request body to get the availability for scheduling orders.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest ScheduleAvailabilityRequest { get; set; }
        /// <summary>Country in which storage location should be supported.</summary>
        string ScheduleAvailabilityRequestCountry { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string ScheduleAvailabilityRequestModel { get; set; }
        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string ScheduleAvailabilityRequestSkuName { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        string ScheduleAvailabilityRequestStorageLocation { get; set; }
        /// <summary>Request body to get the transport availability for given sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityRequest TransportAvailabilityRequest { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string TransportAvailabilityRequestModel { get; set; }
        /// <summary>Type of the device.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string TransportAvailabilityRequestSkuName { get; set; }

    }
}