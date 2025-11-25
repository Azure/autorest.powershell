// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>Job details for update.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateJobDetailsTypeConverter))]
    public partial class UpdateJobDetails
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateJobDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateJobDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateJobDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UpdateJobDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateJobDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails) content.GetValueForProperty("ReverseShippingDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Preference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Preference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences) content.GetValueForProperty("Preference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Preference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey) content.GetValueForProperty("KeyEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKeyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnToCustomerPackageDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails) content.GetValueForProperty("ReturnToCustomerPackageDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContactDetailEmailList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailEmailList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ContactDetailEmailList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailEmailList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactDetailNotificationPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailNotificationPreference = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>) content.GetValueForProperty("ContactDetailNotificationPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailNotificationPreference, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.NotificationPreferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ReverseShippingDetailShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferenceTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferenceEncryptionPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceEncryptionPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences) content.GetValueForProperty("PreferenceEncryptionPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceEncryptionPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.EncryptionPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties) content.GetValueForProperty("KeyEncryptionKeyIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyKekType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekType = (string) content.GetValueForProperty("KeyEncryptionKeyKekType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekType, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsContactName = (string) content.GetValueForProperty("ContactDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhone = (string) content.GetValueForProperty("ContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhoneExtension = (string) content.GetValueForProperty("ContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsMobile = (string) content.GetValueForProperty("ContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress1 = (string) content.GetValueForProperty("StreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress2 = (string) content.GetValueForProperty("StreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress3 = (string) content.GetValueForProperty("StreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("StateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StateOrProvince = (string) content.GetValueForProperty("StateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ZipExtendedCode = (string) content.GetValueForProperty("ZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("SkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).SkipAddressValidation = (bool?) content.GetValueForProperty("SkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).SkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TaxIdentificationNumber = (string) content.GetValueForProperty("TaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo) content.GetValueForProperty("ReverseShippingDetailContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetailIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailIsUpdated = (bool?) content.GetValueForProperty("ReverseShippingDetailIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("PreferenceReverseTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceReverseTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceReverseTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceReverseTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferencePreferredDataCenterRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferencePreferredDataCenterRegion = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferencePreferredDataCenterRegion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferencePreferredDataCenterRegion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PreferenceStorageAccountAccessTierPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferenceStorageAccountAccessTierPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EncryptionPreferenceDoubleEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption = (string) content.GetValueForProperty("EncryptionPreferenceDoubleEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionPreferenceHardwareEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption = (string) content.GetValueForProperty("EncryptionPreferenceHardwareEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekUrl = (string) content.GetValueForProperty("KeyEncryptionKeyKekUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId = (string) content.GetValueForProperty("KeyEncryptionKeyKekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnToCustomerPackageDetailCarrierAccountNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierAccountNumber = (System.Security.SecureString) content.GetValueForProperty("ReturnToCustomerPackageDetailCarrierAccountNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierAccountNumber, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("ReturnToCustomerPackageDetailCarrierName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierName = (string) content.GetValueForProperty("ReturnToCustomerPackageDetailCarrierName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierName, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnToCustomerPackageDetailTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailTrackingId = (string) content.GetValueForProperty("ReturnToCustomerPackageDetailTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactName = (string) content.GetValueForProperty("ReverseShippingDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ReverseShippingDetailsShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("TransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("TransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseTransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("ReverseTransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseTransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("ReverseTransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityPropertyUserAssigned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyUserAssigned = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties) content.GetValueForProperty("IdentityPropertyUserAssigned",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyUserAssigned, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UserAssignedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyType = (string) content.GetValueForProperty("IdentityPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).UserAssignedResourceId = (string) content.GetValueForProperty("UserAssignedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).UserAssignedResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateJobDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails) content.GetValueForProperty("ReverseShippingDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Preference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Preference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences) content.GetValueForProperty("Preference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Preference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey) content.GetValueForProperty("KeyEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKeyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnToCustomerPackageDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails) content.GetValueForProperty("ReturnToCustomerPackageDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContactDetailEmailList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailEmailList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ContactDetailEmailList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailEmailList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactDetailNotificationPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailNotificationPreference = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>) content.GetValueForProperty("ContactDetailNotificationPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailNotificationPreference, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.NotificationPreferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ReverseShippingDetailShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferenceTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferenceEncryptionPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceEncryptionPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences) content.GetValueForProperty("PreferenceEncryptionPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceEncryptionPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.EncryptionPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties) content.GetValueForProperty("KeyEncryptionKeyIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyKekType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekType = (string) content.GetValueForProperty("KeyEncryptionKeyKekType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekType, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsContactName = (string) content.GetValueForProperty("ContactDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhone = (string) content.GetValueForProperty("ContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhoneExtension = (string) content.GetValueForProperty("ContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsMobile = (string) content.GetValueForProperty("ContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress1 = (string) content.GetValueForProperty("StreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress2 = (string) content.GetValueForProperty("StreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress3 = (string) content.GetValueForProperty("StreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("StateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StateOrProvince = (string) content.GetValueForProperty("StateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).StateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ZipExtendedCode = (string) content.GetValueForProperty("ZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("SkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).SkipAddressValidation = (bool?) content.GetValueForProperty("SkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).SkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TaxIdentificationNumber = (string) content.GetValueForProperty("TaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo) content.GetValueForProperty("ReverseShippingDetailContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetailIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailIsUpdated = (bool?) content.GetValueForProperty("ReverseShippingDetailIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("PreferenceReverseTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceReverseTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceReverseTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceReverseTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferencePreferredDataCenterRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferencePreferredDataCenterRegion = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferencePreferredDataCenterRegion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferencePreferredDataCenterRegion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PreferenceStorageAccountAccessTierPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferenceStorageAccountAccessTierPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EncryptionPreferenceDoubleEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption = (string) content.GetValueForProperty("EncryptionPreferenceDoubleEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionPreferenceHardwareEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption = (string) content.GetValueForProperty("EncryptionPreferenceHardwareEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekUrl = (string) content.GetValueForProperty("KeyEncryptionKeyKekUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId = (string) content.GetValueForProperty("KeyEncryptionKeyKekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnToCustomerPackageDetailCarrierAccountNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierAccountNumber = (System.Security.SecureString) content.GetValueForProperty("ReturnToCustomerPackageDetailCarrierAccountNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierAccountNumber, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("ReturnToCustomerPackageDetailCarrierName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierName = (string) content.GetValueForProperty("ReturnToCustomerPackageDetailCarrierName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailCarrierName, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnToCustomerPackageDetailTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailTrackingId = (string) content.GetValueForProperty("ReturnToCustomerPackageDetailTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReturnToCustomerPackageDetailTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactName = (string) content.GetValueForProperty("ReverseShippingDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ReverseShippingDetailsShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("TransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("TransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).TransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseTransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("ReverseTransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseTransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("ReverseTransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityPropertyUserAssigned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyUserAssigned = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties) content.GetValueForProperty("IdentityPropertyUserAssigned",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyUserAssigned, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UserAssignedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyType = (string) content.GetValueForProperty("IdentityPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).IdentityPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).UserAssignedResourceId = (string) content.GetValueForProperty("UserAssignedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetailsInternal)this).UserAssignedResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Job details for update.
    [System.ComponentModel.TypeConverter(typeof(UpdateJobDetailsTypeConverter))]
    public partial interface IUpdateJobDetails

    {

    }
}