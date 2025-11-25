// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>
    /// The requirements to validate customer address where the device needs to be shipped.
    /// </summary>
    public partial class ValidateAddress :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddress,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal,
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

        /// <summary>Internal Acessors for ShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal.ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddress()); set { {_shippingAddress = value;} } }

        /// <summary>Internal Acessors for TransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal.TransportPreference { get => (this._transportPreference = this._transportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferences()); set { {_transportPreference = value;} } }

        /// <summary>Internal Acessors for TransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidateAddressInternal.TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).IsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).IsUpdated = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="ShippingAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress _shippingAddress;

        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddress()); set => this._shippingAddress = value; }

        /// <summary>Name of the City.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).City = value ?? null; }

        /// <summary>Name of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).CompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).CompanyName = value ?? null; }

        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country = value ; }

        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressPostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).PostalCode = value ?? null; }

        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? ShippingAddressSkipAddressValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).SkipAddressValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).SkipAddressValidation = value ?? default(bool); }

        /// <summary>Name of the State or Province.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressStateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StateOrProvince = value ?? null; }

        /// <summary>Street Address line 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress1 = value ; }

        /// <summary>Street Address line 2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressStreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress2 = value ?? null; }

        /// <summary>Street Address line 3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressStreetAddress3 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress3; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress3 = value ?? null; }

        /// <summary>Tax Identification Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressTaxIdentificationNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).TaxIdentificationNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).TaxIdentificationNumber = value ?? null; }

        /// <summary>Type of address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).AddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).AddressType = value ?? null; }

        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressZipExtendedCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).ZipExtendedCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).ZipExtendedCode = value ?? null; }

        /// <summary>Backing field for <see cref="TransportPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences _transportPreference;

        /// <summary>Preferences related to the shipment logistics of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences TransportPreference { get => (this._transportPreference = this._transportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferences()); set => this._transportPreference = value; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).IsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).PreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).PreferredShipmentType = value ?? null; }

        /// <summary>Identifies the type of validation request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ValidationType { get => "ValidateAddress"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal)__validationInputRequest).ValidationType = "ValidateAddress"; }

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

        /// <summary>Creates an new <see cref="ValidateAddress" /> instance.</summary>
        public ValidateAddress()
        {
            this.__validationInputRequest.ValidationType = "ValidateAddress";
        }
    }
    /// The requirements to validate customer address where the device needs to be shipped.
    public partial interface IValidateAddress :
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
        /// <summary>Name of the City.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the City.",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressCity { get; set; }
        /// <summary>Name of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the company.",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressCompanyName { get; set; }
        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the Country.",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressCountry { get; set; }
        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Postal code.",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressPostalCode { get; set; }
        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to indicate if customer has chosen to skip default address validation",
        SerializedName = @"skipAddressValidation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ShippingAddressSkipAddressValidation { get; set; }
        /// <summary>Name of the State or Province.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the State or Province.",
        SerializedName = @"stateOrProvince",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressStateOrProvince { get; set; }
        /// <summary>Street Address line 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Street Address line 1.",
        SerializedName = @"streetAddress1",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressStreetAddress1 { get; set; }
        /// <summary>Street Address line 2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Street Address line 2.",
        SerializedName = @"streetAddress2",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressStreetAddress2 { get; set; }
        /// <summary>Street Address line 3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Street Address line 3.",
        SerializedName = @"streetAddress3",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressStreetAddress3 { get; set; }
        /// <summary>Tax Identification Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tax Identification Number",
        SerializedName = @"taxIdentificationNumber",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressTaxIdentificationNumber { get; set; }
        /// <summary>Type of address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of address.",
        SerializedName = @"addressType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Residential", "Commercial")]
        string ShippingAddressType { get; set; }
        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Extended Zip Code.",
        SerializedName = @"zipExtendedCode",
        PossibleTypes = new [] { typeof(string) })]
        string ShippingAddressZipExtendedCode { get; set; }
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
    /// The requirements to validate customer address where the device needs to be shipped.
    internal partial interface IValidateAddressInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IValidationInputRequestInternal
    {
        /// <summary>Device type to be used for the job.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string DeviceType { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string Model { get; set; }
        /// <summary>Shipping address of the customer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ShippingAddress { get; set; }
        /// <summary>Name of the City.</summary>
        string ShippingAddressCity { get; set; }
        /// <summary>Name of the company.</summary>
        string ShippingAddressCompanyName { get; set; }
        /// <summary>Name of the Country.</summary>
        string ShippingAddressCountry { get; set; }
        /// <summary>Postal code.</summary>
        string ShippingAddressPostalCode { get; set; }
        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        bool? ShippingAddressSkipAddressValidation { get; set; }
        /// <summary>Name of the State or Province.</summary>
        string ShippingAddressStateOrProvince { get; set; }
        /// <summary>Street Address line 1.</summary>
        string ShippingAddressStreetAddress1 { get; set; }
        /// <summary>Street Address line 2.</summary>
        string ShippingAddressStreetAddress2 { get; set; }
        /// <summary>Street Address line 3.</summary>
        string ShippingAddressStreetAddress3 { get; set; }
        /// <summary>Tax Identification Number</summary>
        string ShippingAddressTaxIdentificationNumber { get; set; }
        /// <summary>Type of address.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Residential", "Commercial")]
        string ShippingAddressType { get; set; }
        /// <summary>Extended Zip Code.</summary>
        string ShippingAddressZipExtendedCode { get; set; }
        /// <summary>Preferences related to the shipment logistics of the sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences TransportPreference { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? TransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string TransportPreferencePreferredShipmentType { get; set; }

    }
}