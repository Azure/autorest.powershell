// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job details for update.</summary>
    public partial class UpdateJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal
    {

        /// <summary>Name of the City.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string City { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).City = value ?? null; }

        /// <summary>Name of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).CompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).CompanyName = value ?? null; }

        /// <summary>Backing field for <see cref="ContactDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails _contactDetail;

        /// <summary>Contact details for notification and shipping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails ContactDetail { get => (this._contactDetail = this._contactDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetails()); set => this._contactDetail = value; }

        /// <summary>List of Email-ids to be notified about job progress.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ContactDetailEmailList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).EmailList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).EmailList = value ?? null /* arrayOf */; }

        /// <summary>Notification preference for a job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference> ContactDetailNotificationPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).NotificationPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).NotificationPreference = value ?? null /* arrayOf */; }

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsContactName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).ContactName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).ContactName = value ?? null; }

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsMobile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Mobile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Mobile = value ?? null; }

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Phone = value ?? null; }

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsPhoneExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).PhoneExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).PhoneExtension = value ?? null; }

        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country = value ?? null; }

        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceDoubleEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceDoubleEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceDoubleEncryption = value ?? null; }

        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceHardwareEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceHardwareEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceHardwareEncryption = value ?? null; }

        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPropertyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyType = value ?? null; }

        /// <summary>Backing field for <see cref="KeyEncryptionKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey _keyEncryptionKey;

        /// <summary>Key encryption key for the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey KeyEncryptionKey { get => (this._keyEncryptionKey = this._keyEncryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKey()); set => this._keyEncryptionKey = value; }

        /// <summary>Type of encryption key used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyKekType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).KekType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).KekType = value ?? null; }

        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyKekUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).KekUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).KekUrl = value ?? null; }

        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string KeyEncryptionKeyKekVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).KekVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).KekVaultResourceId = value ?? null; }

        /// <summary>Internal Acessors for ContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ContactDetail { get => (this._contactDetail = this._contactDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetails()); set { {_contactDetail = value;} } }

        /// <summary>Internal Acessors for IdentityPropertyUserAssigned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.IdentityPropertyUserAssigned { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyUserAssigned; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyUserAssigned = value ?? null /* model class */; }

        /// <summary>Internal Acessors for KeyEncryptionKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.KeyEncryptionKey { get => (this._keyEncryptionKey = this._keyEncryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKey()); set { {_keyEncryptionKey = value;} } }

        /// <summary>Internal Acessors for KeyEncryptionKeyIdentityProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.KeyEncryptionKeyIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Preference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Preferences()); set { {_preference = value;} } }

        /// <summary>Internal Acessors for PreferenceEncryptionPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.PreferenceEncryptionPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceReverseTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.PreferenceReverseTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.PreferenceTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReturnToCustomerPackageDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ReturnToCustomerPackageDetail { get => (this._returnToCustomerPackageDetail = this._returnToCustomerPackageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierDetails()); set { {_returnToCustomerPackageDetail = value;} } }

        /// <summary>Internal Acessors for ReverseShippingDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ReverseShippingDetail { get => (this._reverseShippingDetail = this._reverseShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails()); set { {_reverseShippingDetail = value;} } }

        /// <summary>Internal Acessors for ReverseShippingDetailContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ReverseShippingDetailContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseShippingDetailIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ReverseShippingDetailIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).IsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).IsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for ReverseShippingDetailShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ReverseShippingDetailShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddress = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseTransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for ShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddress()); set { {_shippingAddress = value;} } }

        /// <summary>Internal Acessors for TransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal.TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string PostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).PostalCode = value ?? null; }

        /// <summary>Backing field for <see cref="Preference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences _preference;

        /// <summary>Preferences related to the order</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Preferences()); set => this._preference = value; }

        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreferencePreferredDataCenterRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).PreferredDataCenterRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).PreferredDataCenterRegion = value ?? null /* arrayOf */; }

        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreferenceStorageAccountAccessTierPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).StorageAccountAccessTierPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).StorageAccountAccessTierPreference = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ReturnToCustomerPackageDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails _returnToCustomerPackageDetail;

        /// <summary>Return package details of job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails ReturnToCustomerPackageDetail { get => (this._returnToCustomerPackageDetail = this._returnToCustomerPackageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierDetails()); set => this._returnToCustomerPackageDetail = value; }

        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Security.SecureString ReturnToCustomerPackageDetailCarrierAccountNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal)ReturnToCustomerPackageDetail).CarrierAccountNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal)ReturnToCustomerPackageDetail).CarrierAccountNumber = value ?? null; }

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReturnToCustomerPackageDetailCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal)ReturnToCustomerPackageDetail).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal)ReturnToCustomerPackageDetail).CarrierName = value ?? null; }

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReturnToCustomerPackageDetailTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal)ReturnToCustomerPackageDetail).TrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetailsInternal)ReturnToCustomerPackageDetail).TrackingId = value ?? null; }

        /// <summary>Backing field for <see cref="ReverseShippingDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails _reverseShippingDetail;

        /// <summary>Reverse Shipping Address and contact details for a job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails ReverseShippingDetail { get => (this._reverseShippingDetail = this._reverseShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails()); set => this._reverseShippingDetail = value; }

        /// <summary>
        /// A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        /// Read only field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? ReverseShippingDetailIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).IsUpdated; }

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsContactDetailsMobile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailMobile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailMobile = value ?? null; }

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsContactDetailsPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailPhone = value ?? null; }

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsContactDetailsPhoneExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailPhoneExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailPhoneExtension = value ?? null; }

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsContactName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailContactName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetailContactName = value ?? null; }

        /// <summary>Name of the City.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressCity = value ?? null; }

        /// <summary>Name of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressCompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressCompanyName = value ?? null; }

        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressCountry; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressCountry = value ?? null; }

        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressPostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressPostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressPostalCode = value ?? null; }

        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? ReverseShippingDetailsShippingAddressSkipAddressValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressSkipAddressValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressSkipAddressValidation = value ?? default(bool); }

        /// <summary>Name of the State or Province.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressStateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStateOrProvince = value ?? null; }

        /// <summary>Street Address line 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStreetAddress1 = value ?? null; }

        /// <summary>Street Address line 2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressStreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStreetAddress2 = value ?? null; }

        /// <summary>Street Address line 3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressStreetAddress3 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStreetAddress3; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressStreetAddress3 = value ?? null; }

        /// <summary>Tax Identification Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressTaxIdentificationNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressTaxIdentificationNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressTaxIdentificationNumber = value ?? null; }

        /// <summary>Type of address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressType = value ?? null; }

        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsShippingAddressZipExtendedCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressZipExtendedCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddressZipExtendedCode = value ?? null; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseTransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferencePreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferencePreferredShipmentType = value ?? null; }

        /// <summary>Backing field for <see cref="ShippingAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress _shippingAddress;

        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddress()); set => this._shippingAddress = value; }

        /// <summary>Type of address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ShippingAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).AddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).AddressType = value ?? null; }

        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? SkipAddressValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).SkipAddressValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).SkipAddressValidation = value ?? default(bool); }

        /// <summary>Name of the State or Province.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string StateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StateOrProvince = value ?? null; }

        /// <summary>Street Address line 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string StreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress1 = value ?? null; }

        /// <summary>Street Address line 2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string StreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress2 = value ?? null; }

        /// <summary>Street Address line 3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string StreetAddress3 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress3; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).StreetAddress3 = value ?? null; }

        /// <summary>Tax Identification Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TaxIdentificationNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).TaxIdentificationNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).TaxIdentificationNumber = value ?? null; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferencePreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferencePreferredShipmentType = value ?? null; }

        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string UserAssignedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).UserAssignedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).UserAssignedResourceId = value ?? null; }

        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ZipExtendedCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).ZipExtendedCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).ZipExtendedCode = value ?? null; }

        /// <summary>Creates an new <see cref="UpdateJobDetails" /> instance.</summary>
        public UpdateJobDetails()
        {

        }
    }
    /// Job details for update.
    public partial interface IUpdateJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
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
        string City { get; set; }
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
        string CompanyName { get; set; }
        /// <summary>List of Email-ids to be notified about job progress.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Email-ids to be notified about job progress.",
        SerializedName = @"emailList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ContactDetailEmailList { get; set; }
        /// <summary>Notification preference for a job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Notification preference for a job stage.",
        SerializedName = @"notificationPreference",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference> ContactDetailNotificationPreference { get; set; }
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
        string ContactDetailsContactName { get; set; }
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
        string ContactDetailsMobile { get; set; }
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
        string ContactDetailsPhone { get; set; }
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
        string ContactDetailsPhoneExtension { get; set; }
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
        string Country { get; set; }
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
        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed service identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPropertyType { get; set; }
        /// <summary>Type of encryption key used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of encryption key used for key encryption.",
        SerializedName = @"kekType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("MicrosoftManaged", "CustomerManaged")]
        string KeyEncryptionKeyKekType { get; set; }
        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Key encryption key. It is required in case of Customer managed KekType.",
        SerializedName = @"kekUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyKekUrl { get; set; }
        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Kek vault resource id. It is required in case of Customer managed KekType.",
        SerializedName = @"kekVaultResourceID",
        PossibleTypes = new [] { typeof(string) })]
        string KeyEncryptionKeyKekVaultResourceId { get; set; }
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
        string PostalCode { get; set; }
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
        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Carrier Account Number of customer for customer disk.",
        SerializedName = @"carrierAccountNumber",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString ReturnToCustomerPackageDetailCarrierAccountNumber { get; set; }
        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the carrier.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnToCustomerPackageDetailCarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tracking Id of shipment.",
        SerializedName = @"trackingId",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnToCustomerPackageDetailTrackingId { get; set; }
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
        bool? ReverseShippingDetailIsUpdated { get;  }
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
        string ReverseShippingDetailsContactDetailsMobile { get; set; }
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
        string ReverseShippingDetailsContactDetailsPhone { get; set; }
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
        string ReverseShippingDetailsContactDetailsPhoneExtension { get; set; }
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
        string ReverseShippingDetailsContactName { get; set; }
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
        string ReverseShippingDetailsShippingAddressCity { get; set; }
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
        string ReverseShippingDetailsShippingAddressCompanyName { get; set; }
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
        string ReverseShippingDetailsShippingAddressCountry { get; set; }
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
        string ReverseShippingDetailsShippingAddressPostalCode { get; set; }
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
        bool? ReverseShippingDetailsShippingAddressSkipAddressValidation { get; set; }
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
        string ReverseShippingDetailsShippingAddressStateOrProvince { get; set; }
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
        string ReverseShippingDetailsShippingAddressStreetAddress1 { get; set; }
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
        string ReverseShippingDetailsShippingAddressStreetAddress2 { get; set; }
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
        string ReverseShippingDetailsShippingAddressStreetAddress3 { get; set; }
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
        string ReverseShippingDetailsShippingAddressTaxIdentificationNumber { get; set; }
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
        string ReverseShippingDetailsShippingAddressType { get; set; }
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
        string ReverseShippingDetailsShippingAddressZipExtendedCode { get; set; }
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
        bool? SkipAddressValidation { get; set; }
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
        string StateOrProvince { get; set; }
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
        string StreetAddress1 { get; set; }
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
        string StreetAddress2 { get; set; }
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
        string StreetAddress3 { get; set; }
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
        string TaxIdentificationNumber { get; set; }
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
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Arm resource id for user assigned identity to be used to fetch MSI token.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedResourceId { get; set; }
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
        string ZipExtendedCode { get; set; }

    }
    /// Job details for update.
    internal partial interface IUpdateJobDetailsInternal

    {
        /// <summary>Name of the City.</summary>
        string City { get; set; }
        /// <summary>Name of the company.</summary>
        string CompanyName { get; set; }
        /// <summary>Contact details for notification and shipping.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails ContactDetail { get; set; }
        /// <summary>List of Email-ids to be notified about job progress.</summary>
        System.Collections.Generic.List<string> ContactDetailEmailList { get; set; }
        /// <summary>Notification preference for a job stage.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference> ContactDetailNotificationPreference { get; set; }
        /// <summary>Contact name of the person.</summary>
        string ContactDetailsContactName { get; set; }
        /// <summary>Mobile number of the contact person.</summary>
        string ContactDetailsMobile { get; set; }
        /// <summary>Phone number of the contact person.</summary>
        string ContactDetailsPhone { get; set; }
        /// <summary>Phone extension number of the contact person.</summary>
        string ContactDetailsPhoneExtension { get; set; }
        /// <summary>Name of the Country.</summary>
        string Country { get; set; }
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceDoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceHardwareEncryption { get; set; }
        /// <summary>Managed service identity type.</summary>
        string IdentityPropertyType { get; set; }
        /// <summary>User assigned identity properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties IdentityPropertyUserAssigned { get; set; }
        /// <summary>Key encryption key for the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey KeyEncryptionKey { get; set; }
        /// <summary>Managed identity properties used for key encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties KeyEncryptionKeyIdentityProperty { get; set; }
        /// <summary>Type of encryption key used for key encryption.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("MicrosoftManaged", "CustomerManaged")]
        string KeyEncryptionKeyKekType { get; set; }
        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        string KeyEncryptionKeyKekUrl { get; set; }
        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        string KeyEncryptionKeyKekVaultResourceId { get; set; }
        /// <summary>Postal code.</summary>
        string PostalCode { get; set; }
        /// <summary>Preferences related to the order</summary>
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
        /// <summary>Return package details of job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails ReturnToCustomerPackageDetail { get; set; }
        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        System.Security.SecureString ReturnToCustomerPackageDetailCarrierAccountNumber { get; set; }
        /// <summary>Name of the carrier.</summary>
        string ReturnToCustomerPackageDetailCarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        string ReturnToCustomerPackageDetailTrackingId { get; set; }
        /// <summary>Reverse Shipping Address and contact details for a job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails ReverseShippingDetail { get; set; }
        /// <summary>Contact Info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo ReverseShippingDetailContactDetail { get; set; }
        /// <summary>
        /// A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        /// Read only field
        /// </summary>
        bool? ReverseShippingDetailIsUpdated { get; set; }
        /// <summary>Shipping address where customer wishes to receive the device.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ReverseShippingDetailShippingAddress { get; set; }
        /// <summary>Mobile number of the contact person.</summary>
        string ReverseShippingDetailsContactDetailsMobile { get; set; }
        /// <summary>Phone number of the contact person.</summary>
        string ReverseShippingDetailsContactDetailsPhone { get; set; }
        /// <summary>Phone extension number of the contact person.</summary>
        string ReverseShippingDetailsContactDetailsPhoneExtension { get; set; }
        /// <summary>Contact name of the person.</summary>
        string ReverseShippingDetailsContactName { get; set; }
        /// <summary>Name of the City.</summary>
        string ReverseShippingDetailsShippingAddressCity { get; set; }
        /// <summary>Name of the company.</summary>
        string ReverseShippingDetailsShippingAddressCompanyName { get; set; }
        /// <summary>Name of the Country.</summary>
        string ReverseShippingDetailsShippingAddressCountry { get; set; }
        /// <summary>Postal code.</summary>
        string ReverseShippingDetailsShippingAddressPostalCode { get; set; }
        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        bool? ReverseShippingDetailsShippingAddressSkipAddressValidation { get; set; }
        /// <summary>Name of the State or Province.</summary>
        string ReverseShippingDetailsShippingAddressStateOrProvince { get; set; }
        /// <summary>Street Address line 1.</summary>
        string ReverseShippingDetailsShippingAddressStreetAddress1 { get; set; }
        /// <summary>Street Address line 2.</summary>
        string ReverseShippingDetailsShippingAddressStreetAddress2 { get; set; }
        /// <summary>Street Address line 3.</summary>
        string ReverseShippingDetailsShippingAddressStreetAddress3 { get; set; }
        /// <summary>Tax Identification Number</summary>
        string ReverseShippingDetailsShippingAddressTaxIdentificationNumber { get; set; }
        /// <summary>Type of address.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Residential", "Commercial")]
        string ReverseShippingDetailsShippingAddressType { get; set; }
        /// <summary>Extended Zip Code.</summary>
        string ReverseShippingDetailsShippingAddressZipExtendedCode { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? ReverseTransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ReverseTransportPreferencePreferredShipmentType { get; set; }
        /// <summary>Shipping address of the customer.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ShippingAddress { get; set; }
        /// <summary>Type of address.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Residential", "Commercial")]
        string ShippingAddressType { get; set; }
        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        bool? SkipAddressValidation { get; set; }
        /// <summary>Name of the State or Province.</summary>
        string StateOrProvince { get; set; }
        /// <summary>Street Address line 1.</summary>
        string StreetAddress1 { get; set; }
        /// <summary>Street Address line 2.</summary>
        string StreetAddress2 { get; set; }
        /// <summary>Street Address line 3.</summary>
        string StreetAddress3 { get; set; }
        /// <summary>Tax Identification Number</summary>
        string TaxIdentificationNumber { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? TransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string TransportPreferencePreferredShipmentType { get; set; }
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        string UserAssignedResourceId { get; set; }
        /// <summary>Extended Zip Code.</summary>
        string ZipExtendedCode { get; set; }

    }
}