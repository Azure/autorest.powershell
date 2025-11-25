// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.PowerShell;

    /// <summary>DataBox Disk Job Details.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataBoxDiskJobDetailsTypeConverter))]
    public partial class DataBoxDiskJobDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataBoxDiskJobDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PreferredDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).PreferredDisk = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsPreferredDisks) content.GetValueForProperty("PreferredDisk",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).PreferredDisk, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetailsPreferredDisksTypeConverter.ConvertFrom);
            }
            if (content.Contains("CopyProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).CopyProgress = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgress>) content.GetValueForProperty("CopyProgress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).CopyProgress, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgress>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskCopyProgressTypeConverter.ConvertFrom));
            }
            if (content.Contains("GranularCopyProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyProgress = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgress>) content.GetValueForProperty("GranularCopyProgress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyProgress, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgress>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskGranularCopyProgressTypeConverter.ConvertFrom));
            }
            if (content.Contains("GranularCopyLogDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyLogDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyLogDetails>) content.GetValueForProperty("GranularCopyLogDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyLogDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyLogDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskGranularCopyLogDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DisksAndSizeDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).DisksAndSizeDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsDisksAndSizeDetails) content.GetValueForProperty("DisksAndSizeDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).DisksAndSizeDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetailsDisksAndSizeDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Passkey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).Passkey = (string) content.GetValueForProperty("Passkey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).Passkey, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailEmailList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailEmailList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ContactDetailEmailList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailEmailList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactDetailNotificationPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailNotificationPreference = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>) content.GetValueForProperty("ContactDetailNotificationPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailNotificationPreference, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.NotificationPreferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("PreferenceTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferenceEncryptionPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceEncryptionPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences) content.GetValueForProperty("PreferenceEncryptionPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceEncryptionPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.EncryptionPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetailShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ReverseShippingDetailShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties) content.GetValueForProperty("KeyEncryptionKeyIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyKekType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekType = (string) content.GetValueForProperty("KeyEncryptionKeyKekType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekType, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsContactName = (string) content.GetValueForProperty("ContactDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhone = (string) content.GetValueForProperty("ContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhoneExtension = (string) content.GetValueForProperty("ContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsMobile = (string) content.GetValueForProperty("ContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress1 = (string) content.GetValueForProperty("StreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress2 = (string) content.GetValueForProperty("StreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress3 = (string) content.GetValueForProperty("StreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("StateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StateOrProvince = (string) content.GetValueForProperty("StateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ZipExtendedCode = (string) content.GetValueForProperty("ZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("SkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).SkipAddressValidation = (bool?) content.GetValueForProperty("SkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).SkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TaxIdentificationNumber = (string) content.GetValueForProperty("TaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryPackageTrackingUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingUrl = (string) content.GetValueForProperty("DeliveryPackageTrackingUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingUrl, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryPackageCarrierName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageCarrierName = (string) content.GetValueForProperty("DeliveryPackageCarrierName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageCarrierName, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryPackageTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingId = (string) content.GetValueForProperty("DeliveryPackageTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnPackageTrackingUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingUrl = (string) content.GetValueForProperty("ReturnPackageTrackingUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnPackageCarrierName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageCarrierName = (string) content.GetValueForProperty("ReturnPackageCarrierName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageCarrierName, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnPackageTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingId = (string) content.GetValueForProperty("ReturnPackageTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("PreferenceReverseTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceReverseTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceReverseTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceReverseTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferencePreferredDataCenterRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferencePreferredDataCenterRegion = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferencePreferredDataCenterRegion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferencePreferredDataCenterRegion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PreferenceStorageAccountAccessTierPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferenceStorageAccountAccessTierPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EncryptionPreferenceDoubleEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption = (string) content.GetValueForProperty("EncryptionPreferenceDoubleEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionPreferenceHardwareEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption = (string) content.GetValueForProperty("EncryptionPreferenceHardwareEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo) content.GetValueForProperty("ReverseShippingDetailContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetailIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailIsUpdated = (bool?) content.GetValueForProperty("ReverseShippingDetailIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceErasureDetailDeviceErasureStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailDeviceErasureStatus = (string) content.GetValueForProperty("DeviceErasureDetailDeviceErasureStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailDeviceErasureStatus, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceErasureDetailErasureOrDestructionCertificateSasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailErasureOrDestructionCertificateSasKey = (string) content.GetValueForProperty("DeviceErasureDetailErasureOrDestructionCertificateSasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailErasureOrDestructionCertificateSasKey, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceErasureDetailSecureErasureCertificateSasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailSecureErasureCertificateSasKey = (string) content.GetValueForProperty("DeviceErasureDetailSecureErasureCertificateSasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailSecureErasureCertificateSasKey, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekUrl = (string) content.GetValueForProperty("KeyEncryptionKeyKekUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId = (string) content.GetValueForProperty("KeyEncryptionKeyKekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("LastMitigationActionOnJobActionDateTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobActionDateTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("LastMitigationActionOnJobActionDateTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobActionDateTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastMitigationActionOnJobIsPerformedByCustomer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobIsPerformedByCustomer = (bool?) content.GetValueForProperty("LastMitigationActionOnJobIsPerformedByCustomer",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobIsPerformedByCustomer, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastMitigationActionOnJobCustomerResolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobCustomerResolution = (string) content.GetValueForProperty("LastMitigationActionOnJobCustomerResolution",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobCustomerResolution, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressType = (string) content.GetValueForProperty("DatacenterAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressSupportedCarriersForReturnShipment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressSupportedCarriersForReturnShipment = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatacenterAddressSupportedCarriersForReturnShipment",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressSupportedCarriersForReturnShipment, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatacenterAddressDataCenterAzureLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressDataCenterAzureLocation = (string) content.GetValueForProperty("DatacenterAddressDataCenterAzureLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressDataCenterAzureLocation, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("TransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("TransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseTransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("ReverseTransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseTransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("ReverseTransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactName = (string) content.GetValueForProperty("ReverseShippingDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ReverseShippingDetailsShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPropertyUserAssigned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyUserAssigned = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties) content.GetValueForProperty("IdentityPropertyUserAssigned",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyUserAssigned, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UserAssignedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyType = (string) content.GetValueForProperty("IdentityPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).UserAssignedResourceId = (string) content.GetValueForProperty("UserAssignedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).UserAssignedResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeliveryPackage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackage = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails) content.GetValueForProperty("DeliveryPackage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackage, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnPackage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackage = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails) content.GetValueForProperty("ReturnPackage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackage, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Preference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Preference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences) content.GetValueForProperty("Preference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Preference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails) content.GetValueForProperty("ReverseShippingDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceErasureDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails) content.GetValueForProperty("DeviceErasureDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceErasureDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey) content.GetValueForProperty("KeyEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKeyTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastMitigationActionOnJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJob = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob) content.GetValueForProperty("LastMitigationActionOnJob",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJob, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.LastMitigationActionOnJobTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatacenterAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse) content.GetValueForProperty("DatacenterAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponseTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).JobStage = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages>) content.GetValueForProperty("JobStage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).JobStage, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobStagesTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataImportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataImportDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails>) content.GetValueForProperty("DataImportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataImportDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataImportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataExportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataExportDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails>) content.GetValueForProperty("DataExportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataExportDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataExportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("CopyLogDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CopyLogDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails>) content.GetValueForProperty("CopyLogDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CopyLogDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyLogDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReverseShipmentLabelSasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShipmentLabelSasKey = (string) content.GetValueForProperty("ReverseShipmentLabelSasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShipmentLabelSasKey, global::System.Convert.ToString);
            }
            if (content.Contains("ChainOfCustodySasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ChainOfCustodySasKey = (string) content.GetValueForProperty("ChainOfCustodySasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ChainOfCustodySasKey, global::System.Convert.ToString);
            }
            if (content.Contains("ExpectedDataSizeInTeraByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ExpectedDataSizeInTeraByte = (int?) content.GetValueForProperty("ExpectedDataSizeInTeraByte",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ExpectedDataSizeInTeraByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Action = (System.Collections.Generic.List<string>) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Action, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DataCenterCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataCenterCode = (string) content.GetValueForProperty("DataCenterCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataCenterCode, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataBoxDiskJobDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PreferredDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).PreferredDisk = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsPreferredDisks) content.GetValueForProperty("PreferredDisk",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).PreferredDisk, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetailsPreferredDisksTypeConverter.ConvertFrom);
            }
            if (content.Contains("CopyProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).CopyProgress = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgress>) content.GetValueForProperty("CopyProgress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).CopyProgress, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskCopyProgress>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskCopyProgressTypeConverter.ConvertFrom));
            }
            if (content.Contains("GranularCopyProgress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyProgress = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgress>) content.GetValueForProperty("GranularCopyProgress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyProgress, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyProgress>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskGranularCopyProgressTypeConverter.ConvertFrom));
            }
            if (content.Contains("GranularCopyLogDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyLogDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyLogDetails>) content.GetValueForProperty("GranularCopyLogDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).GranularCopyLogDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskGranularCopyLogDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskGranularCopyLogDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DisksAndSizeDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).DisksAndSizeDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsDisksAndSizeDetails) content.GetValueForProperty("DisksAndSizeDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).DisksAndSizeDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetailsDisksAndSizeDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Passkey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).Passkey = (string) content.GetValueForProperty("Passkey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetailsInternal)this).Passkey, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailEmailList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailEmailList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ContactDetailEmailList",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailEmailList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ContactDetailNotificationPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailNotificationPreference = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>) content.GetValueForProperty("ContactDetailNotificationPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailNotificationPreference, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.NotificationPreferenceTypeConverter.ConvertFrom));
            }
            if (content.Contains("ShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddressType = (string) content.GetValueForProperty("ShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("PreferenceTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferenceEncryptionPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceEncryptionPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences) content.GetValueForProperty("PreferenceEncryptionPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceEncryptionPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.EncryptionPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetailShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ReverseShippingDetailShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties) content.GetValueForProperty("KeyEncryptionKeyIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKeyKekType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekType = (string) content.GetValueForProperty("KeyEncryptionKeyKekType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekType, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsContactName = (string) content.GetValueForProperty("ContactDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhone = (string) content.GetValueForProperty("ContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhoneExtension = (string) content.GetValueForProperty("ContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsMobile = (string) content.GetValueForProperty("ContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress1 = (string) content.GetValueForProperty("StreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress2 = (string) content.GetValueForProperty("StreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("StreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress3 = (string) content.GetValueForProperty("StreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("City"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).City = (string) content.GetValueForProperty("City",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).City, global::System.Convert.ToString);
            }
            if (content.Contains("StateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StateOrProvince = (string) content.GetValueForProperty("StateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).StateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("Country"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Country = (string) content.GetValueForProperty("Country",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Country, global::System.Convert.ToString);
            }
            if (content.Contains("PostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PostalCode = (string) content.GetValueForProperty("PostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ZipExtendedCode = (string) content.GetValueForProperty("ZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("SkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).SkipAddressValidation = (bool?) content.GetValueForProperty("SkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).SkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TaxIdentificationNumber = (string) content.GetValueForProperty("TaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryPackageTrackingUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingUrl = (string) content.GetValueForProperty("DeliveryPackageTrackingUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingUrl, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryPackageCarrierName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageCarrierName = (string) content.GetValueForProperty("DeliveryPackageCarrierName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageCarrierName, global::System.Convert.ToString);
            }
            if (content.Contains("DeliveryPackageTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingId = (string) content.GetValueForProperty("DeliveryPackageTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackageTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnPackageTrackingUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingUrl = (string) content.GetValueForProperty("ReturnPackageTrackingUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingUrl, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnPackageCarrierName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageCarrierName = (string) content.GetValueForProperty("ReturnPackageCarrierName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageCarrierName, global::System.Convert.ToString);
            }
            if (content.Contains("ReturnPackageTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingId = (string) content.GetValueForProperty("ReturnPackageTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackageTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("PreferenceReverseTransportPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceReverseTransportPreference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences) content.GetValueForProperty("PreferenceReverseTransportPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceReverseTransportPreference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PreferencePreferredDataCenterRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferencePreferredDataCenterRegion = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferencePreferredDataCenterRegion",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferencePreferredDataCenterRegion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PreferenceStorageAccountAccessTierPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference = (System.Collections.Generic.List<string>) content.GetValueForProperty("PreferenceStorageAccountAccessTierPreference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).PreferenceStorageAccountAccessTierPreference, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EncryptionPreferenceDoubleEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption = (string) content.GetValueForProperty("EncryptionPreferenceDoubleEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceDoubleEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionPreferenceHardwareEncryption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption = (string) content.GetValueForProperty("EncryptionPreferenceHardwareEncryption",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).EncryptionPreferenceHardwareEncryption, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo) content.GetValueForProperty("ReverseShippingDetailContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetailIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailIsUpdated = (bool?) content.GetValueForProperty("ReverseShippingDetailIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceErasureDetailDeviceErasureStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailDeviceErasureStatus = (string) content.GetValueForProperty("DeviceErasureDetailDeviceErasureStatus",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailDeviceErasureStatus, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceErasureDetailErasureOrDestructionCertificateSasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailErasureOrDestructionCertificateSasKey = (string) content.GetValueForProperty("DeviceErasureDetailErasureOrDestructionCertificateSasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailErasureOrDestructionCertificateSasKey, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceErasureDetailSecureErasureCertificateSasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailSecureErasureCertificateSasKey = (string) content.GetValueForProperty("DeviceErasureDetailSecureErasureCertificateSasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetailSecureErasureCertificateSasKey, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekUrl = (string) content.GetValueForProperty("KeyEncryptionKeyKekUrl",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KeyEncryptionKeyKekVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId = (string) content.GetValueForProperty("KeyEncryptionKeyKekVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKeyKekVaultResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("LastMitigationActionOnJobActionDateTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobActionDateTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("LastMitigationActionOnJobActionDateTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobActionDateTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastMitigationActionOnJobIsPerformedByCustomer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobIsPerformedByCustomer = (bool?) content.GetValueForProperty("LastMitigationActionOnJobIsPerformedByCustomer",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobIsPerformedByCustomer, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastMitigationActionOnJobCustomerResolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobCustomerResolution = (string) content.GetValueForProperty("LastMitigationActionOnJobCustomerResolution",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJobCustomerResolution, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressType = (string) content.GetValueForProperty("DatacenterAddressType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressType, global::System.Convert.ToString);
            }
            if (content.Contains("DatacenterAddressSupportedCarriersForReturnShipment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressSupportedCarriersForReturnShipment = (System.Collections.Generic.List<string>) content.GetValueForProperty("DatacenterAddressSupportedCarriersForReturnShipment",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressSupportedCarriersForReturnShipment, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DatacenterAddressDataCenterAzureLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressDataCenterAzureLocation = (string) content.GetValueForProperty("DatacenterAddressDataCenterAzureLocation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddressDataCenterAzureLocation, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("TransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("TransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("TransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).TransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseTransportPreferencePreferredShipmentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType = (string) content.GetValueForProperty("ReverseTransportPreferencePreferredShipmentType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferencePreferredShipmentType, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseTransportPreferenceIsUpdated"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated = (bool?) content.GetValueForProperty("ReverseTransportPreferenceIsUpdated",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseTransportPreferenceIsUpdated, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsContactName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactName = (string) content.GetValueForProperty("ReverseShippingDetailsContactName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhone",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhone, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsPhoneExtension"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsPhoneExtension",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsPhoneExtension, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsContactDetailsMobile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile = (string) content.GetValueForProperty("ReverseShippingDetailsContactDetailsMobile",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsContactDetailsMobile, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress1"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress1",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress1, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress2",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress2, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStreetAddress3"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3 = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStreetAddress3",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStreetAddress3, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCity",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCity, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressStateOrProvince"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressStateOrProvince",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressStateOrProvince, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCountry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCountry",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCountry, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressPostalCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressPostalCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressPostalCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressZipExtendedCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressZipExtendedCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressZipExtendedCode, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressCompanyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressCompanyName",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressCompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressSkipAddressValidation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation = (bool?) content.GetValueForProperty("ReverseShippingDetailsShippingAddressSkipAddressValidation",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressSkipAddressValidation, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ReverseShippingDetailsShippingAddressTaxIdentificationNumber"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber = (string) content.GetValueForProperty("ReverseShippingDetailsShippingAddressTaxIdentificationNumber",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetailsShippingAddressTaxIdentificationNumber, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPropertyUserAssigned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyUserAssigned = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties) content.GetValueForProperty("IdentityPropertyUserAssigned",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyUserAssigned, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UserAssignedPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPropertyType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyType = (string) content.GetValueForProperty("IdentityPropertyType",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).IdentityPropertyType, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).UserAssignedResourceId = (string) content.GetValueForProperty("UserAssignedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).UserAssignedResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeliveryPackage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackage = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails) content.GetValueForProperty("DeliveryPackage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeliveryPackage, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReturnPackage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackage = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails) content.GetValueForProperty("ReturnPackage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReturnPackage, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Preference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Preference = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences) content.GetValueForProperty("Preference",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Preference, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PreferencesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReverseShippingDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails) content.GetValueForProperty("ReverseShippingDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShippingDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("DeviceErasureDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetail = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails) content.GetValueForProperty("DeviceErasureDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DeviceErasureDetail, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceErasureDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyEncryptionKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKey = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey) content.GetValueForProperty("KeyEncryptionKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).KeyEncryptionKey, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKeyTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastMitigationActionOnJob"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJob = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob) content.GetValueForProperty("LastMitigationActionOnJob",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).LastMitigationActionOnJob, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.LastMitigationActionOnJobTypeConverter.ConvertFrom);
            }
            if (content.Contains("DatacenterAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddress = (Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse) content.GetValueForProperty("DatacenterAddress",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DatacenterAddress, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponseTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).JobStage = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages>) content.GetValueForProperty("JobStage",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).JobStage, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobStagesTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataImportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataImportDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails>) content.GetValueForProperty("DataImportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataImportDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataImportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("DataExportDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataExportDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails>) content.GetValueForProperty("DataExportDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataExportDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataExportDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("CopyLogDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CopyLogDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails>) content.GetValueForProperty("CopyLogDetail",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).CopyLogDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.CopyLogDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ReverseShipmentLabelSasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShipmentLabelSasKey = (string) content.GetValueForProperty("ReverseShipmentLabelSasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ReverseShipmentLabelSasKey, global::System.Convert.ToString);
            }
            if (content.Contains("ChainOfCustodySasKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ChainOfCustodySasKey = (string) content.GetValueForProperty("ChainOfCustodySasKey",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ChainOfCustodySasKey, global::System.Convert.ToString);
            }
            if (content.Contains("ExpectedDataSizeInTeraByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ExpectedDataSizeInTeraByte = (int?) content.GetValueForProperty("ExpectedDataSizeInTeraByte",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).ExpectedDataSizeInTeraByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Action = (System.Collections.Generic.List<string>) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).Action, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DataCenterCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataCenterCode = (string) content.GetValueForProperty("DataCenterCode",((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)this).DataCenterCode, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataBoxDiskJobDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxDiskJobDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataBoxDiskJobDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataBoxDiskJobDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataBoxDiskJobDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxDiskJobDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Json.JsonNode.Parse(jsonText));

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
    }
    /// DataBox Disk Job Details.
    [System.ComponentModel.TypeConverter(typeof(DataBoxDiskJobDetailsTypeConverter))]
    public partial interface IDataBoxDiskJobDetails

    {

    }
}