// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Reverse Shipping Address and contact details for a job.</summary>
    public partial class ReverseShippingDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal
    {

        /// <summary>Backing field for <see cref="ContactDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo _contactDetail;

        /// <summary>Contact Info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo ContactDetail { get => (this._contactDetail = this._contactDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfo()); set => this._contactDetail = value; }

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailContactName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).ContactName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).ContactName = value ?? null; }

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailMobile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).Mobile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).Mobile = value ?? null; }

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).Phone = value ?? null; }

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailPhoneExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).PhoneExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfoInternal)ContactDetail).PhoneExtension = value ?? null; }

        /// <summary>Backing field for <see cref="IsUpdated" /> property.</summary>
        private bool? _isUpdated;

        /// <summary>
        /// A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        /// Read only field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? IsUpdated { get => this._isUpdated; }

        /// <summary>Internal Acessors for ContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal.ContactDetail { get => (this._contactDetail = this._contactDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfo()); set { {_contactDetail = value;} } }

        /// <summary>Internal Acessors for IsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal.IsUpdated { get => this._isUpdated; set { {_isUpdated = value;} } }

        /// <summary>Internal Acessors for ShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal.ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddress()); set { {_shippingAddress = value;} } }

        /// <summary>Backing field for <see cref="ShippingAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress _shippingAddress;

        /// <summary>Shipping address where customer wishes to receive the device.</summary>
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
        public string ShippingAddressCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country = value ?? null; }

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
        public string ShippingAddressStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress1 = value ?? null; }

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

        /// <summary>Creates an new <see cref="ReverseShippingDetails" /> instance.</summary>
        public ReverseShippingDetails()
        {

        }
    }
    /// Reverse Shipping Address and contact details for a job.
    public partial interface IReverseShippingDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Contact name of the person.",
        SerializedName = @"contactName",
        PossibleTypes = new [] { typeof(string) })]
        string ContactDetailContactName { get; set; }
        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Mobile number of the contact person.",
        SerializedName = @"mobile",
        PossibleTypes = new [] { typeof(string) })]
        string ContactDetailMobile { get; set; }
        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Phone number of the contact person.",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string ContactDetailPhone { get; set; }
        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Phone extension number of the contact person.",
        SerializedName = @"phoneExtension",
        PossibleTypes = new [] { typeof(string) })]
        string ContactDetailPhoneExtension { get; set; }
        /// <summary>
        /// A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        /// Read only field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        Read only field",
        SerializedName = @"isUpdated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsUpdated { get;  }
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
        Required = false,
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
        Required = false,
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

    }
    /// Reverse Shipping Address and contact details for a job.
    internal partial interface IReverseShippingDetailsInternal

    {
        /// <summary>Contact Info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo ContactDetail { get; set; }
        /// <summary>Contact name of the person.</summary>
        string ContactDetailContactName { get; set; }
        /// <summary>Mobile number of the contact person.</summary>
        string ContactDetailMobile { get; set; }
        /// <summary>Phone number of the contact person.</summary>
        string ContactDetailPhone { get; set; }
        /// <summary>Phone extension number of the contact person.</summary>
        string ContactDetailPhoneExtension { get; set; }
        /// <summary>
        /// A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        /// Read only field
        /// </summary>
        bool? IsUpdated { get; set; }
        /// <summary>Shipping address where customer wishes to receive the device.</summary>
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

    }
}