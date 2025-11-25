// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Configuration response specific to a region.</summary>
    public partial class RegionConfigurationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal
    {

        /// <summary>Backing field for <see cref="DatacenterAddressResponse" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse _datacenterAddressResponse;

        /// <summary>Datacenter address for given sku in a region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse DatacenterAddressResponse { get => (this._datacenterAddressResponse = this._datacenterAddressResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponse()); }

        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressResponseDataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).DataCenterAzureLocation; }

        /// <summary>Data center address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressResponseDatacenterAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).DatacenterAddressType; }

        /// <summary>List of supported carriers for return shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DatacenterAddressResponseSupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).SupportedCarriersForReturnShipment; }

        /// <summary>Backing field for <see cref="DeviceCapabilityResponse" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponse _deviceCapabilityResponse;

        /// <summary>Device capabilities available for a given sku in a region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponse DeviceCapabilityResponse { get => (this._deviceCapabilityResponse = this._deviceCapabilityResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceCapabilityResponse()); }

        /// <summary>List of device capabilities available for a given region and a given sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> DeviceCapabilityResponseDeviceCapabilityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponseInternal)DeviceCapabilityResponse).DeviceCapabilityDetail; }

        /// <summary>Internal Acessors for DatacenterAddressResponse</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.DatacenterAddressResponse { get => (this._datacenterAddressResponse = this._datacenterAddressResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponse()); set { {_datacenterAddressResponse = value;} } }

        /// <summary>Internal Acessors for DatacenterAddressResponseDataCenterAzureLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.DatacenterAddressResponseDataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).DataCenterAzureLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).DataCenterAzureLocation = value ?? null; }

        /// <summary>Internal Acessors for DatacenterAddressResponseDatacenterAddressType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.DatacenterAddressResponseDatacenterAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).DatacenterAddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).DatacenterAddressType = value ?? null; }

        /// <summary>
        /// Internal Acessors for DatacenterAddressResponseSupportedCarriersForReturnShipment
        /// </summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.DatacenterAddressResponseSupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).SupportedCarriersForReturnShipment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddressResponse).SupportedCarriersForReturnShipment = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DeviceCapabilityResponse</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponse Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.DeviceCapabilityResponse { get => (this._deviceCapabilityResponse = this._deviceCapabilityResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceCapabilityResponse()); set { {_deviceCapabilityResponse = value;} } }

        /// <summary>Internal Acessors for DeviceCapabilityResponseDeviceCapabilityDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.DeviceCapabilityResponseDeviceCapabilityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponseInternal)DeviceCapabilityResponse).DeviceCapabilityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponseInternal)DeviceCapabilityResponse).DeviceCapabilityDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ScheduleAvailabilityResponse</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponse Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.ScheduleAvailabilityResponse { get => (this._scheduleAvailabilityResponse = this._scheduleAvailabilityResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityResponse()); set { {_scheduleAvailabilityResponse = value;} } }

        /// <summary>Internal Acessors for ScheduleAvailabilityResponseAvailableDate</summary>
        System.Collections.Generic.List<global::System.DateTime> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.ScheduleAvailabilityResponseAvailableDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponseInternal)ScheduleAvailabilityResponse).AvailableDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponseInternal)ScheduleAvailabilityResponse).AvailableDate = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for TransportAvailabilityResponse</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponse Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.TransportAvailabilityResponse { get => (this._transportAvailabilityResponse = this._transportAvailabilityResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportAvailabilityResponse()); set { {_transportAvailabilityResponse = value;} } }

        /// <summary>Internal Acessors for TransportAvailabilityResponseTransportAvailabilityDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IRegionConfigurationResponseInternal.TransportAvailabilityResponseTransportAvailabilityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponseInternal)TransportAvailabilityResponse).TransportAvailabilityDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponseInternal)TransportAvailabilityResponse).TransportAvailabilityDetail = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ScheduleAvailabilityResponse" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponse _scheduleAvailabilityResponse;

        /// <summary>Schedule availability for given sku in a region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponse ScheduleAvailabilityResponse { get => (this._scheduleAvailabilityResponse = this._scheduleAvailabilityResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ScheduleAvailabilityResponse()); }

        /// <summary>List of dates available to schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<global::System.DateTime> ScheduleAvailabilityResponseAvailableDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponseInternal)ScheduleAvailabilityResponse).AvailableDate; }

        /// <summary>Backing field for <see cref="TransportAvailabilityResponse" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponse _transportAvailabilityResponse;

        /// <summary>Transport options available for given sku in a region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponse TransportAvailabilityResponse { get => (this._transportAvailabilityResponse = this._transportAvailabilityResponse ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportAvailabilityResponse()); }

        /// <summary>List of transport availability details for given region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetails> TransportAvailabilityResponseTransportAvailabilityDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponseInternal)TransportAvailabilityResponse).TransportAvailabilityDetail; }

        /// <summary>Creates an new <see cref="RegionConfigurationResponse" /> instance.</summary>
        public RegionConfigurationResponse()
        {

        }
    }
    /// Configuration response specific to a region.
    public partial interface IRegionConfigurationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure Location where the Data Center serves primarily.",
        SerializedName = @"dataCenterAzureLocation",
        PossibleTypes = new [] { typeof(string) })]
        string DatacenterAddressResponseDataCenterAzureLocation { get;  }
        /// <summary>Data center address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Data center address type",
        SerializedName = @"datacenterAddressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DatacenterAddressLocation", "DatacenterAddressInstruction")]
        string DatacenterAddressResponseDatacenterAddressType { get;  }
        /// <summary>List of supported carriers for return shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of supported carriers for return shipment.",
        SerializedName = @"supportedCarriersForReturnShipment",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DatacenterAddressResponseSupportedCarriersForReturnShipment { get;  }
        /// <summary>List of device capabilities available for a given region and a given sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of device capabilities available for a given region and a given sku",
        SerializedName = @"deviceCapabilityDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> DeviceCapabilityResponseDeviceCapabilityDetail { get;  }
        /// <summary>List of dates available to schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of dates available to schedule",
        SerializedName = @"availableDates",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        System.Collections.Generic.List<global::System.DateTime> ScheduleAvailabilityResponseAvailableDate { get;  }
        /// <summary>List of transport availability details for given region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of transport availability details for given region",
        SerializedName = @"transportAvailabilityDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetails> TransportAvailabilityResponseTransportAvailabilityDetail { get;  }

    }
    /// Configuration response specific to a region.
    internal partial interface IRegionConfigurationResponseInternal

    {
        /// <summary>Datacenter address for given sku in a region.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse DatacenterAddressResponse { get; set; }
        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        string DatacenterAddressResponseDataCenterAzureLocation { get; set; }
        /// <summary>Data center address type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DatacenterAddressLocation", "DatacenterAddressInstruction")]
        string DatacenterAddressResponseDatacenterAddressType { get; set; }
        /// <summary>List of supported carriers for return shipment.</summary>
        System.Collections.Generic.List<string> DatacenterAddressResponseSupportedCarriersForReturnShipment { get; set; }
        /// <summary>Device capabilities available for a given sku in a region.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityResponse DeviceCapabilityResponse { get; set; }
        /// <summary>List of device capabilities available for a given region and a given sku</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceCapabilityDetails> DeviceCapabilityResponseDeviceCapabilityDetail { get; set; }
        /// <summary>Schedule availability for given sku in a region.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityResponse ScheduleAvailabilityResponse { get; set; }
        /// <summary>List of dates available to schedule</summary>
        System.Collections.Generic.List<global::System.DateTime> ScheduleAvailabilityResponseAvailableDate { get; set; }
        /// <summary>Transport options available for given sku in a region.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityResponse TransportAvailabilityResponse { get; set; }
        /// <summary>List of transport availability details for given region</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportAvailabilityDetails> TransportAvailabilityResponseTransportAvailabilityDetail { get; set; }

    }
}