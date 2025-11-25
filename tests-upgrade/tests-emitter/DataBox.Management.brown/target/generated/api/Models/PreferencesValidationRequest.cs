// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Request to validate preference of transport and data center.</summary>
    public partial class PreferencesValidationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest __validationInputRequest = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ValidationInputRequest();

        /// <summary>Backing field for <see cref="DeviceType" /> property.</summary>
        private string _deviceType;

        /// <summary>Device type to be used for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DeviceType { get => this._deviceType; set => this._deviceType = value; }

        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceDoubleEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceDoubleEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceDoubleEncryption = value ?? null; }

        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceHardwareEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceHardwareEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceHardwareEncryption = value ?? null; }

        /// <summary>Internal Acessors for Preference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal.Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Preferences()); set { {_preference = value;} } }

        /// <summary>Internal Acessors for PreferenceEncryptionPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal.PreferenceEncryptionPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceReverseTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal.PreferenceReverseTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal.PreferenceTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseTransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal.ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for TransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesValidationRequestInternal.TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="Preference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences _preference;

        /// <summary>Preference of transport and data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Preferences()); set => this._preference = value; }

        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreferencePreferredDataCenterRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).PreferredDataCenterRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).PreferredDataCenterRegion = value ?? null /* arrayOf */; }

        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreferenceStorageAccountAccessTierPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).StorageAccountAccessTierPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).StorageAccountAccessTierPreference = value ?? null /* arrayOf */; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseTransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferencePreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferencePreferredShipmentType = value ?? null; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferencePreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferencePreferredShipmentType = value ?? null; }

        /// <summary>Identifies the type of validation request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ValidationType { get => "ValidatePreferences"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)__validationInputRequest).ValidationType = "ValidatePreferences"; }

        /// <summary>Creates an new <see cref="PreferencesValidationRequest" /> instance.</summary>
        public PreferencesValidationRequest()
        {
            this.__validationInputRequest.ValidationType = "ValidatePreferences";
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
    /// Request to validate preference of transport and data center.
    public partial interface IPreferencesValidationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequest
    {
        /// <summary>Device type to be used for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device type to be used for the job.",
        SerializedName = @"deviceType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceType { get; set; }
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines secondary layer of software-based encryption enablement.",
        SerializedName = @"doubleEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceDoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines Hardware level encryption (Only for disk)",
        SerializedName = @"hardwareEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceHardwareEncryption { get; set; }
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
        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Preferred data center region.",
        SerializedName = @"preferredDataCenterRegion",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> PreferencePreferredDataCenterRegion { get; set; }
        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Preferences related to the Access Tier of storage accounts.",
        SerializedName = @"storageAccountAccessTierPreferences",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Archive")]
        System.Collections.Generic.List<string> PreferenceStorageAccountAccessTierPreference { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Read only property which indicates whether transport preferences has been updated or not after device is prepared.",
        SerializedName = @"isUpdated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReverseTransportPreferenceIsUpdated { get;  }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates Shipment Logistics type that the customer preferred.",
        SerializedName = @"preferredShipmentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ReverseTransportPreferencePreferredShipmentType { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Read only property which indicates whether transport preferences has been updated or not after device is prepared.",
        SerializedName = @"isUpdated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TransportPreferenceIsUpdated { get;  }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates Shipment Logistics type that the customer preferred.",
        SerializedName = @"preferredShipmentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string TransportPreferencePreferredShipmentType { get; set; }

    }
    /// Request to validate preference of transport and data center.
    internal partial interface IPreferencesValidationRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal
    {
        /// <summary>Device type to be used for the job.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceType { get; set; }
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceDoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceHardwareEncryption { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string Model { get; set; }
        /// <summary>Preference of transport and data center.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Preference { get; set; }
        /// <summary>Preferences related to the Encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences PreferenceEncryptionPreference { get; set; }
        /// <summary>Preferred data center region.</summary>
        System.Collections.Generic.List<string> PreferencePreferredDataCenterRegion { get; set; }
        /// <summary>Optional Preferences related to the reverse shipment logistics of the sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences PreferenceReverseTransportPreference { get; set; }
        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Archive")]
        System.Collections.Generic.List<string> PreferenceStorageAccountAccessTierPreference { get; set; }
        /// <summary>Preferences related to the shipment logistics of the sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences PreferenceTransportPreference { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? ReverseTransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ReverseTransportPreferencePreferredShipmentType { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? TransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string TransportPreferencePreferredShipmentType { get; set; }

    }
}