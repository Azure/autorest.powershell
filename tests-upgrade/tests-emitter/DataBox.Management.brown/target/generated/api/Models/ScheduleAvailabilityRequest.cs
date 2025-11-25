// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request body to get the availability for scheduling orders.</summary>
    public partial class ScheduleAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IScheduleAvailabilityRequestInternal
    {

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Country in which storage location should be supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="SkuName" /> property.</summary>
        private string _skuName;

        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string SkuName { get => this._skuName; set => this._skuName = value; }

        /// <summary>Backing field for <see cref="StorageLocation" /> property.</summary>
        private string _storageLocation;

        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string StorageLocation { get => this._storageLocation; set => this._storageLocation = value; }

        /// <summary>Creates an new <see cref="ScheduleAvailabilityRequest" /> instance.</summary>
        public ScheduleAvailabilityRequest()
        {

        }
    }
    /// Request body to get the availability for scheduling orders.
    public partial interface IScheduleAvailabilityRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
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
        string Country { get; set; }
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
        string Model { get; set; }
        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sku Name for which the order is to be scheduled.",
        SerializedName = @"skuName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01",
        SerializedName = @"storageLocation",
        PossibleTypes = new [] { typeof(string) })]
        string StorageLocation { get; set; }

    }
    /// Request body to get the availability for scheduling orders.
    internal partial interface IScheduleAvailabilityRequestInternal

    {
        /// <summary>Country in which storage location should be supported.</summary>
        string Country { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string Model { get; set; }
        /// <summary>Sku Name for which the order is to be scheduled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }
        /// <summary>
        /// Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01
        /// </summary>
        string StorageLocation { get; set; }

    }
}