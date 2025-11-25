// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Datacenter address for given storage location.</summary>
    public partial class DatacenterAddressLocationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse __datacenterAddressResponse = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponse();

        /// <summary>Backing field for <see cref="AdditionalShippingInformation" /> property.</summary>
        private string _additionalShippingInformation;

        /// <summary>Special instruction for shipping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string AdditionalShippingInformation { get => this._additionalShippingInformation; }

        /// <summary>Backing field for <see cref="AddressType" /> property.</summary>
        private string _addressType;

        /// <summary>Address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string AddressType { get => this._addressType; }

        /// <summary>Backing field for <see cref="City" /> property.</summary>
        private string _city;

        /// <summary>City name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string City { get => this._city; }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private string _company;

        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Company { get => this._company; }

        /// <summary>Backing field for <see cref="ContactPersonName" /> property.</summary>
        private string _contactPersonName;

        /// <summary>Contact person name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ContactPersonName { get => this._contactPersonName; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>name of the country</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Country { get => this._country; }

        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DataCenterAzureLocation; }

        /// <summary>Data center address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DatacenterAddressType { get => "DatacenterAddressLocation"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DatacenterAddressType = "DatacenterAddressLocation"; }

        /// <summary>Internal Acessors for AdditionalShippingInformation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.AdditionalShippingInformation { get => this._additionalShippingInformation; set { {_additionalShippingInformation = value;} } }

        /// <summary>Internal Acessors for AddressType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.AddressType { get => this._addressType; set { {_addressType = value;} } }

        /// <summary>Internal Acessors for City</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.City { get => this._city; set { {_city = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Company { get => this._company; set { {_company = value;} } }

        /// <summary>Internal Acessors for ContactPersonName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.ContactPersonName { get => this._contactPersonName; set { {_contactPersonName = value;} } }

        /// <summary>Internal Acessors for Country</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Country { get => this._country; set { {_country = value;} } }

        /// <summary>Internal Acessors for Phone</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Phone { get => this._phone; set { {_phone = value;} } }

        /// <summary>Internal Acessors for PhoneExtension</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.PhoneExtension { get => this._phoneExtension; set { {_phoneExtension = value;} } }

        /// <summary>Internal Acessors for State</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for Street1</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Street1 { get => this._street1; set { {_street1 = value;} } }

        /// <summary>Internal Acessors for Street2</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Street2 { get => this._street2; set { {_street2 = value;} } }

        /// <summary>Internal Acessors for Street3</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Street3 { get => this._street3; set { {_street3 = value;} } }

        /// <summary>Internal Acessors for Zip</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressLocationResponseInternal.Zip { get => this._zip; set { {_zip = value;} } }

        /// <summary>Internal Acessors for DataCenterAzureLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal.DataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DataCenterAzureLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DataCenterAzureLocation = value ?? null; }

        /// <summary>Internal Acessors for SupportedCarriersForReturnShipment</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal.SupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).SupportedCarriersForReturnShipment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).SupportedCarriersForReturnShipment = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Phone" /> property.</summary>
        private string _phone;

        /// <summary>Phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Phone { get => this._phone; }

        /// <summary>Backing field for <see cref="PhoneExtension" /> property.</summary>
        private string _phoneExtension;

        /// <summary>Phone extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string PhoneExtension { get => this._phoneExtension; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>name of the state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string State { get => this._state; }

        /// <summary>Backing field for <see cref="Street1" /> property.</summary>
        private string _street1;

        /// <summary>Street address line 1</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Street1 { get => this._street1; }

        /// <summary>Backing field for <see cref="Street2" /> property.</summary>
        private string _street2;

        /// <summary>Street address line 2</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Street2 { get => this._street2; }

        /// <summary>Backing field for <see cref="Street3" /> property.</summary>
        private string _street3;

        /// <summary>Street address line 3</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Street3 { get => this._street3; }

        /// <summary>List of supported carriers for return shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> SupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).SupportedCarriersForReturnShipment; }

        /// <summary>Backing field for <see cref="Zip" /> property.</summary>
        private string _zip;

        /// <summary>Zip code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Zip { get => this._zip; }

        /// <summary>Creates an new <see cref="DatacenterAddressLocationResponse" /> instance.</summary>
        public DatacenterAddressLocationResponse()
        {
            this.__datacenterAddressResponse.DatacenterAddressType = "DatacenterAddressLocation";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__datacenterAddressResponse), __datacenterAddressResponse);
            await eventListener.AssertObjectIsValid(nameof(__datacenterAddressResponse), __datacenterAddressResponse);
        }
    }
    /// Datacenter address for given storage location.
    public partial interface IDatacenterAddressLocationResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse
    {
        /// <summary>Special instruction for shipping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Special instruction for shipping",
        SerializedName = @"additionalShippingInformation",
        PossibleTypes = new [] { typeof(string) })]
        string AdditionalShippingInformation { get;  }
        /// <summary>Address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Address type",
        SerializedName = @"addressType",
        PossibleTypes = new [] { typeof(string) })]
        string AddressType { get;  }
        /// <summary>City name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"City name",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string City { get;  }
        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Company name",
        SerializedName = @"company",
        PossibleTypes = new [] { typeof(string) })]
        string Company { get;  }
        /// <summary>Contact person name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Contact person name",
        SerializedName = @"contactPersonName",
        PossibleTypes = new [] { typeof(string) })]
        string ContactPersonName { get;  }
        /// <summary>name of the country</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"name of the country",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get;  }
        /// <summary>Phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Phone number",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string Phone { get;  }
        /// <summary>Phone extension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Phone extension",
        SerializedName = @"phoneExtension",
        PossibleTypes = new [] { typeof(string) })]
        string PhoneExtension { get;  }
        /// <summary>name of the state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"name of the state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get;  }
        /// <summary>Street address line 1</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Street address line 1",
        SerializedName = @"street1",
        PossibleTypes = new [] { typeof(string) })]
        string Street1 { get;  }
        /// <summary>Street address line 2</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Street address line 2",
        SerializedName = @"street2",
        PossibleTypes = new [] { typeof(string) })]
        string Street2 { get;  }
        /// <summary>Street address line 3</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Street address line 3",
        SerializedName = @"street3",
        PossibleTypes = new [] { typeof(string) })]
        string Street3 { get;  }
        /// <summary>Zip code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Zip code",
        SerializedName = @"zip",
        PossibleTypes = new [] { typeof(string) })]
        string Zip { get;  }

    }
    /// Datacenter address for given storage location.
    internal partial interface IDatacenterAddressLocationResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal
    {
        /// <summary>Special instruction for shipping</summary>
        string AdditionalShippingInformation { get; set; }
        /// <summary>Address type</summary>
        string AddressType { get; set; }
        /// <summary>City name</summary>
        string City { get; set; }
        /// <summary>Company name</summary>
        string Company { get; set; }
        /// <summary>Contact person name</summary>
        string ContactPersonName { get; set; }
        /// <summary>name of the country</summary>
        string Country { get; set; }
        /// <summary>Phone number</summary>
        string Phone { get; set; }
        /// <summary>Phone extension</summary>
        string PhoneExtension { get; set; }
        /// <summary>name of the state</summary>
        string State { get; set; }
        /// <summary>Street address line 1</summary>
        string Street1 { get; set; }
        /// <summary>Street address line 2</summary>
        string Street2 { get; set; }
        /// <summary>Street address line 3</summary>
        string Street3 { get; set; }
        /// <summary>Zip code</summary>
        string Zip { get; set; }

    }
}