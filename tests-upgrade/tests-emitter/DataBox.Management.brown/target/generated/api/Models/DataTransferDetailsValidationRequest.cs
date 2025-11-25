// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request to validate export and import data details.</summary>
    public partial class DataTransferDetailsValidationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataTransferDetailsValidationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataTransferDetailsValidationRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest __validationInputRequest = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidationInputRequest();

        /// <summary>Backing field for <see cref="DataExportDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> _dataExportDetail;

        /// <summary>List of DataTransfer details to be used to export data from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get => this._dataExportDetail; set => this._dataExportDetail = value; }

        /// <summary>Backing field for <see cref="DataImportDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> _dataImportDetail;

        /// <summary>List of DataTransfer details to be used to import data to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get => this._dataImportDetail; set => this._dataImportDetail = value; }

        /// <summary>Backing field for <see cref="DeviceType" /> property.</summary>
        private string _deviceType;

        /// <summary>Device type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DeviceType { get => this._deviceType; set => this._deviceType = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="TransferType" /> property.</summary>
        private string _transferType;

        /// <summary>Type of the transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string TransferType { get => this._transferType; set => this._transferType = value; }

        /// <summary>Identifies the type of validation request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ValidationType { get => "ValidateDataTransferDetails"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)__validationInputRequest).ValidationType = "ValidateDataTransferDetails"; }

        /// <summary>Creates an new <see cref="DataTransferDetailsValidationRequest" /> instance.</summary>
        public DataTransferDetailsValidationRequest()
        {
            this.__validationInputRequest.ValidationType = "ValidateDataTransferDetails";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__validationInputRequest), __validationInputRequest);
            await eventListener.AssertObjectIsValid(nameof(__validationInputRequest), __validationInputRequest);
        }
    }
    /// Request to validate export and import data details.
    public partial interface IDataTransferDetailsValidationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest
    {
        /// <summary>List of DataTransfer details to be used to export data from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of DataTransfer details to be used to export data from azure.",
        SerializedName = @"dataExportDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get; set; }
        /// <summary>List of DataTransfer details to be used to import data to azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of DataTransfer details to be used to import data to azure.",
        SerializedName = @"dataImportDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get; set; }
        /// <summary>Device type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device type.",
        SerializedName = @"deviceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceType { get; set; }
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
        /// <summary>Type of the transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the transfer.",
        SerializedName = @"transferType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ImportToAzure", "ExportFromAzure")]
        string TransferType { get; set; }

    }
    /// Request to validate export and import data details.
    internal partial interface IDataTransferDetailsValidationRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal
    {
        /// <summary>List of DataTransfer details to be used to export data from azure.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get; set; }
        /// <summary>List of DataTransfer details to be used to import data to azure.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get; set; }
        /// <summary>Device type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceType { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string Model { get; set; }
        /// <summary>Type of the transfer.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ImportToAzure", "ExportFromAzure")]
        string TransferType { get; set; }

    }
}