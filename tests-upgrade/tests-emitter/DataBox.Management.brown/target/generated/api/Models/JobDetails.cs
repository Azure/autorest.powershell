// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job details.</summary>
    public partial class JobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private System.Collections.Generic.List<string> _action;

        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Action { get => this._action; }

        /// <summary>Backing field for <see cref="ChainOfCustodySasKey" /> property.</summary>
        private string _chainOfCustodySasKey;

        /// <summary>Shared access key to download the chain of custody logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ChainOfCustodySasKey { get => this._chainOfCustodySasKey; }

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
        public System.Collections.Generic.List<string> ContactDetailEmailList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).EmailList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).EmailList = value ; }

        /// <summary>Notification preference for a job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference> ContactDetailNotificationPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).NotificationPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).NotificationPreference = value ?? null /* arrayOf */; }

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsContactName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).ContactName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).ContactName = value ; }

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsMobile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Mobile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Mobile = value ?? null; }

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).Phone = value ; }

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ContactDetailsPhoneExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).PhoneExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetailsInternal)ContactDetail).PhoneExtension = value ?? null; }

        /// <summary>Backing field for <see cref="CopyLogDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> _copyLogDetail;

        /// <summary>List of copy log details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> CopyLogDetail { get => this._copyLogDetail; }

        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).Country = value ?? null; }

        /// <summary>Backing field for <see cref="DataCenterCode" /> property.</summary>
        private string _dataCenterCode;

        /// <summary>DataCenter code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DataCenterCode { get => this._dataCenterCode; }

        /// <summary>Backing field for <see cref="DataExportDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> _dataExportDetail;

        /// <summary>Details of the data to be exported from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get => this._dataExportDetail; set => this._dataExportDetail = value; }

        /// <summary>Backing field for <see cref="DataImportDetail" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> _dataImportDetail;

        /// <summary>Details of the data to be imported into azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get => this._dataImportDetail; set => this._dataImportDetail = value; }

        /// <summary>Backing field for <see cref="DatacenterAddress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse _datacenterAddress;

        /// <summary>Datacenter address to ship to, for the given sku and storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse DatacenterAddress { get => (this._datacenterAddress = this._datacenterAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponse()); }

        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressDataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).DataCenterAzureLocation; }

        /// <summary>List of supported carriers for return shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DatacenterAddressSupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).SupportedCarriersForReturnShipment; }

        /// <summary>Data center address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DatacenterAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).DatacenterAddressType; }

        /// <summary>Backing field for <see cref="DeliveryPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails _deliveryPackage;

        /// <summary>Delivery package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails DeliveryPackage { get => (this._deliveryPackage = this._deliveryPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetails()); }

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeliveryPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).CarrierName; }

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeliveryPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).TrackingId; }

        /// <summary>Url where shipment can be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeliveryPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).TrackingUrl; }

        /// <summary>Backing field for <see cref="DeviceErasureDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails _deviceErasureDetail;

        /// <summary>Holds device data erasure details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails DeviceErasureDetail { get => (this._deviceErasureDetail = this._deviceErasureDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceErasureDetails()); }

        /// <summary>Holds the device erasure completion status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeviceErasureDetailDeviceErasureStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).DeviceErasureStatus; }

        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeviceErasureDetailErasureOrDestructionCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).ErasureOrDestructionCertificateSasKey; }

        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeviceErasureDetailSecureErasureCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).SecureErasureCertificateSasKey; }

        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceDoubleEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceDoubleEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceDoubleEncryption = value ?? null; }

        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceHardwareEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceHardwareEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreferenceHardwareEncryption = value ?? null; }

        /// <summary>Backing field for <see cref="ExpectedDataSizeInTeraByte" /> property.</summary>
        private int? _expectedDataSizeInTeraByte;

        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public int? ExpectedDataSizeInTeraByte { get => this._expectedDataSizeInTeraByte; set => this._expectedDataSizeInTeraByte = value; }

        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPropertyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyType = value ?? null; }

        /// <summary>Backing field for <see cref="JobStage" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> _jobStage;

        /// <summary>List of stages that run in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> JobStage { get => this._jobStage; }

        /// <summary>Backing field for <see cref="KeyEncryptionKey" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey _keyEncryptionKey;

        /// <summary>Details about which key encryption type is being used.</summary>
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

        /// <summary>Backing field for <see cref="LastMitigationActionOnJob" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob _lastMitigationActionOnJob;

        /// <summary>Last mitigation action performed on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob LastMitigationActionOnJob { get => (this._lastMitigationActionOnJob = this._lastMitigationActionOnJob ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.LastMitigationActionOnJob()); }

        /// <summary>Action performed date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public global::System.DateTime? LastMitigationActionOnJobActionDateTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).ActionDateTimeInUtc; }

        /// <summary>Resolution code provided by customer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string LastMitigationActionOnJobCustomerResolution { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).CustomerResolution; }

        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? LastMitigationActionOnJobIsPerformedByCustomer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).IsPerformedByCustomer; }

        /// <summary>Internal Acessors for Action</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.Action { get => this._action; set { {_action = value;} } }

        /// <summary>Internal Acessors for ChainOfCustodySasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ChainOfCustodySasKey { get => this._chainOfCustodySasKey; set { {_chainOfCustodySasKey = value;} } }

        /// <summary>Internal Acessors for ContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ContactDetail { get => (this._contactDetail = this._contactDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ContactDetails()); set { {_contactDetail = value;} } }

        /// <summary>Internal Acessors for CopyLogDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.CopyLogDetail { get => this._copyLogDetail; set { {_copyLogDetail = value;} } }

        /// <summary>Internal Acessors for DataCenterCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DataCenterCode { get => this._dataCenterCode; set { {_dataCenterCode = value;} } }

        /// <summary>Internal Acessors for DatacenterAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddress { get => (this._datacenterAddress = this._datacenterAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponse()); set { {_datacenterAddress = value;} } }

        /// <summary>Internal Acessors for DatacenterAddressDataCenterAzureLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddressDataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).DataCenterAzureLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).DataCenterAzureLocation = value ?? null; }

        /// <summary>Internal Acessors for DatacenterAddressSupportedCarriersForReturnShipment</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddressSupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).SupportedCarriersForReturnShipment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).SupportedCarriersForReturnShipment = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DatacenterAddressType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).DatacenterAddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)DatacenterAddress).DatacenterAddressType = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackage { get => (this._deliveryPackage = this._deliveryPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetails()); set { {_deliveryPackage = value;} } }

        /// <summary>Internal Acessors for DeliveryPackageCarrierName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).CarrierName = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackageTrackingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).TrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).TrackingId = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackageTrackingUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).TrackingUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)DeliveryPackage).TrackingUrl = value ?? null; }

        /// <summary>Internal Acessors for DeviceErasureDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetail { get => (this._deviceErasureDetail = this._deviceErasureDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DeviceErasureDetails()); set { {_deviceErasureDetail = value;} } }

        /// <summary>Internal Acessors for DeviceErasureDetailDeviceErasureStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetailDeviceErasureStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).DeviceErasureStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).DeviceErasureStatus = value ?? null; }

        /// <summary>Internal Acessors for DeviceErasureDetailErasureOrDestructionCertificateSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetailErasureOrDestructionCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).ErasureOrDestructionCertificateSasKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).ErasureOrDestructionCertificateSasKey = value ?? null; }

        /// <summary>Internal Acessors for DeviceErasureDetailSecureErasureCertificateSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetailSecureErasureCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).SecureErasureCertificateSasKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetailsInternal)DeviceErasureDetail).SecureErasureCertificateSasKey = value ?? null; }

        /// <summary>Internal Acessors for IdentityPropertyUserAssigned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.IdentityPropertyUserAssigned { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyUserAssigned; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityPropertyUserAssigned = value ?? null /* model class */; }

        /// <summary>Internal Acessors for JobStage</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.JobStage { get => this._jobStage; set { {_jobStage = value;} } }

        /// <summary>Internal Acessors for KeyEncryptionKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.KeyEncryptionKey { get => (this._keyEncryptionKey = this._keyEncryptionKey ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.KeyEncryptionKey()); set { {_keyEncryptionKey = value;} } }

        /// <summary>Internal Acessors for KeyEncryptionKeyIdentityProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.KeyEncryptionKeyIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).IdentityProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LastMitigationActionOnJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJob { get => (this._lastMitigationActionOnJob = this._lastMitigationActionOnJob ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.LastMitigationActionOnJob()); set { {_lastMitigationActionOnJob = value;} } }

        /// <summary>Internal Acessors for LastMitigationActionOnJobActionDateTimeInUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJobActionDateTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).ActionDateTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).ActionDateTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastMitigationActionOnJobCustomerResolution</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJobCustomerResolution { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).CustomerResolution; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).CustomerResolution = value ?? null; }

        /// <summary>Internal Acessors for LastMitigationActionOnJobIsPerformedByCustomer</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJobIsPerformedByCustomer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).IsPerformedByCustomer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJobInternal)LastMitigationActionOnJob).IsPerformedByCustomer = value ?? default(bool); }

        /// <summary>Internal Acessors for Preference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Preferences()); set { {_preference = value;} } }

        /// <summary>Internal Acessors for PreferenceEncryptionPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.PreferenceEncryptionPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).EncryptionPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceReverseTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.PreferenceReverseTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.PreferenceTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReturnPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackage { get => (this._returnPackage = this._returnPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetails()); set { {_returnPackage = value;} } }

        /// <summary>Internal Acessors for ReturnPackageCarrierName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).CarrierName = value ?? null; }

        /// <summary>Internal Acessors for ReturnPackageTrackingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).TrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).TrackingId = value ?? null; }

        /// <summary>Internal Acessors for ReturnPackageTrackingUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).TrackingUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).TrackingUrl = value ?? null; }

        /// <summary>Internal Acessors for ReverseShipmentLabelSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShipmentLabelSasKey { get => this._reverseShipmentLabelSasKey; set { {_reverseShipmentLabelSasKey = value;} } }

        /// <summary>Internal Acessors for ReverseShippingDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetail { get => (this._reverseShippingDetail = this._reverseShippingDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ReverseShippingDetails()); set { {_reverseShippingDetail = value;} } }

        /// <summary>Internal Acessors for ReverseShippingDetailContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetailContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ContactDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseShippingDetailIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetailIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).IsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).IsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for ReverseShippingDetailShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetailShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetailsInternal)ReverseShippingDetail).ShippingAddress = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseTransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).ReverseTransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for ShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ShippingAddress { get => (this._shippingAddress = this._shippingAddress ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ShippingAddress()); set { {_shippingAddress = value;} } }

        /// <summary>Internal Acessors for TransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).TransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string PostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).PostalCode = value ?? null; }

        /// <summary>Backing field for <see cref="Preference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences _preference;

        /// <summary>Preferences for the order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Preference { get => (this._preference = this._preference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Preferences()); set => this._preference = value; }

        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreferencePreferredDataCenterRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).PreferredDataCenterRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).PreferredDataCenterRegion = value ?? null /* arrayOf */; }

        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> PreferenceStorageAccountAccessTierPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).StorageAccountAccessTierPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal)Preference).StorageAccountAccessTierPreference = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ReturnPackage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails _returnPackage;

        /// <summary>Return package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails ReturnPackage { get => (this._returnPackage = this._returnPackage ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageShippingDetails()); }

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReturnPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).CarrierName; }

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReturnPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).TrackingId; }

        /// <summary>Url where shipment can be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReturnPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetailsInternal)ReturnPackage).TrackingUrl; }

        /// <summary>Backing field for <see cref="ReverseShipmentLabelSasKey" /> property.</summary>
        private string _reverseShipmentLabelSasKey;

        /// <summary>Shared access key to download the return shipment label</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ReverseShipmentLabelSasKey { get => this._reverseShipmentLabelSasKey; }

        /// <summary>Backing field for <see cref="ReverseShippingDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails _reverseShippingDetail;

        /// <summary>Optional Reverse Shipping details for order.</summary>
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

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string UserAssignedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).UserAssignedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal)KeyEncryptionKey).UserAssignedResourceId = value ?? null; }

        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ZipExtendedCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).ZipExtendedCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddressInternal)ShippingAddress).ZipExtendedCode = value ?? null; }

        /// <summary>Creates an new <see cref="JobDetails" /> instance.</summary>
        public JobDetails()
        {

        }
    }
    /// Job details.
    public partial interface IJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Available actions on the job.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        System.Collections.Generic.List<string> Action { get;  }
        /// <summary>Shared access key to download the chain of custody logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Shared access key to download the chain of custody logs",
        SerializedName = @"chainOfCustodySasKey",
        PossibleTypes = new [] { typeof(string) })]
        string ChainOfCustodySasKey { get;  }
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
        Required = true,
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
        Required = true,
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
        Required = true,
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
        /// <summary>List of copy log details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of copy log details.",
        SerializedName = @"copyLogDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> CopyLogDetail { get;  }
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
        /// <summary>DataCenter code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"DataCenter code.",
        SerializedName = @"dataCenterCode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Invalid", "BY2", "BY1", "ORK70", "AM2", "AMS20", "BY21", "BY24", "MWH01", "AMS06", "SSE90", "SYD03", "SYD23", "CBR20", "YTO20", "CWL20", "LON24", "BOM01", "BL20", "BL7", "SEL20", "TYO01", "BN1", "SN5", "CYS04", "TYO22", "YTO21", "YQB20", "FRA22", "MAA01", "CPQ02", "CPQ20", "SIN20", "HKG20", "SG2", "MEL23", "SEL21", "OSA20", "SHA03", "BJB", "JNB22", "JNB21", "MNZ21", "SN8", "AUH20", "ZRH20", "PUS20", "AdHoc", "CH1", "DSM05", "DUB07", "PNQ01", "SVG20", "OSA02", "OSA22", "PAR22", "BN7", "SN6", "BJS20", "BL24", "IDC5", "TYO23", "NTG20", "DXB23", "DSM11", "AMS25", "CPQ21", "OSA23")]
        string DataCenterCode { get;  }
        /// <summary>Details of the data to be exported from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of the data to be exported from azure.",
        SerializedName = @"dataExportDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get; set; }
        /// <summary>Details of the data to be imported into azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of the data to be imported into azure.",
        SerializedName = @"dataImportDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get; set; }
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
        string DatacenterAddressDataCenterAzureLocation { get;  }
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
        System.Collections.Generic.List<string> DatacenterAddressSupportedCarriersForReturnShipment { get;  }
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
        string DatacenterAddressType { get;  }
        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the carrier.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryPackageCarrierName { get;  }
        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Tracking Id of shipment.",
        SerializedName = @"trackingId",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryPackageTrackingId { get;  }
        /// <summary>Url where shipment can be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url where shipment can be tracked.",
        SerializedName = @"trackingUrl",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryPackageTrackingUrl { get;  }
        /// <summary>Holds the device erasure completion status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Holds the device erasure completion status",
        SerializedName = @"deviceErasureStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling", "SucceededWithErrors", "WaitingForCustomerAction", "SucceededWithWarnings", "WaitingForCustomerActionForKek", "WaitingForCustomerActionForCleanUp", "CustomerActionPerformedForCleanUp", "CustomerActionPerformed")]
        string DeviceErasureDetailDeviceErasureStatus { get;  }
        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Shared access key to download cleanup or destruction certificate for device",
        SerializedName = @"erasureOrDestructionCertificateSasKey",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceErasureDetailErasureOrDestructionCertificateSasKey { get;  }
        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Shared access key to download secure erasure certificate for the device",
        SerializedName = @"secureErasureCertificateSasKey",
        PossibleTypes = new [] { typeof(string) })]
        string DeviceErasureDetailSecureErasureCertificateSasKey { get;  }
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
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The expected size of the data, which needs to be transferred in this job, in terabytes.",
        SerializedName = @"expectedDataSizeInTeraBytes",
        PossibleTypes = new [] { typeof(int) })]
        int? ExpectedDataSizeInTeraByte { get; set; }
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
        /// <summary>List of stages that run in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of stages that run in the job.",
        SerializedName = @"jobStages",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> JobStage { get;  }
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
        /// <summary>Action performed date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Action performed date time",
        SerializedName = @"actionDateTimeInUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastMitigationActionOnJobActionDateTimeInUtc { get;  }
        /// <summary>Resolution code provided by customer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resolution code provided by customer",
        SerializedName = @"customerResolution",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        string LastMitigationActionOnJobCustomerResolution { get;  }
        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Action performed by customer,
        possibility is that mitigation might happen by customer or service or by ops",
        SerializedName = @"isPerformedByCustomer",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LastMitigationActionOnJobIsPerformedByCustomer { get;  }
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
        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the carrier.",
        SerializedName = @"carrierName",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnPackageCarrierName { get;  }
        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Tracking Id of shipment.",
        SerializedName = @"trackingId",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnPackageTrackingId { get;  }
        /// <summary>Url where shipment can be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url where shipment can be tracked.",
        SerializedName = @"trackingUrl",
        PossibleTypes = new [] { typeof(string) })]
        string ReturnPackageTrackingUrl { get;  }
        /// <summary>Shared access key to download the return shipment label</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Shared access key to download the return shipment label",
        SerializedName = @"reverseShipmentLabelSasKey",
        PossibleTypes = new [] { typeof(string) })]
        string ReverseShipmentLabelSasKey { get;  }
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
        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates the type of job details.",
        SerializedName = @"jobDetailsType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string Type { get; set; }
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
    /// Job details.
    internal partial interface IJobDetailsInternal

    {
        /// <summary>Available actions on the job.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        System.Collections.Generic.List<string> Action { get; set; }
        /// <summary>Shared access key to download the chain of custody logs</summary>
        string ChainOfCustodySasKey { get; set; }
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
        /// <summary>List of copy log details.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> CopyLogDetail { get; set; }
        /// <summary>Name of the Country.</summary>
        string Country { get; set; }
        /// <summary>DataCenter code.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Invalid", "BY2", "BY1", "ORK70", "AM2", "AMS20", "BY21", "BY24", "MWH01", "AMS06", "SSE90", "SYD03", "SYD23", "CBR20", "YTO20", "CWL20", "LON24", "BOM01", "BL20", "BL7", "SEL20", "TYO01", "BN1", "SN5", "CYS04", "TYO22", "YTO21", "YQB20", "FRA22", "MAA01", "CPQ02", "CPQ20", "SIN20", "HKG20", "SG2", "MEL23", "SEL21", "OSA20", "SHA03", "BJB", "JNB22", "JNB21", "MNZ21", "SN8", "AUH20", "ZRH20", "PUS20", "AdHoc", "CH1", "DSM05", "DUB07", "PNQ01", "SVG20", "OSA02", "OSA22", "PAR22", "BN7", "SN6", "BJS20", "BL24", "IDC5", "TYO23", "NTG20", "DXB23", "DSM11", "AMS25", "CPQ21", "OSA23")]
        string DataCenterCode { get; set; }
        /// <summary>Details of the data to be exported from azure.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get; set; }
        /// <summary>Details of the data to be imported into azure.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get; set; }
        /// <summary>Datacenter address to ship to, for the given sku and storage location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse DatacenterAddress { get; set; }
        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        string DatacenterAddressDataCenterAzureLocation { get; set; }
        /// <summary>List of supported carriers for return shipment.</summary>
        System.Collections.Generic.List<string> DatacenterAddressSupportedCarriersForReturnShipment { get; set; }
        /// <summary>Data center address type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DatacenterAddressLocation", "DatacenterAddressInstruction")]
        string DatacenterAddressType { get; set; }
        /// <summary>Delivery package shipping details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails DeliveryPackage { get; set; }
        /// <summary>Name of the carrier.</summary>
        string DeliveryPackageCarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        string DeliveryPackageTrackingId { get; set; }
        /// <summary>Url where shipment can be tracked.</summary>
        string DeliveryPackageTrackingUrl { get; set; }
        /// <summary>Holds device data erasure details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails DeviceErasureDetail { get; set; }
        /// <summary>Holds the device erasure completion status</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling", "SucceededWithErrors", "WaitingForCustomerAction", "SucceededWithWarnings", "WaitingForCustomerActionForKek", "WaitingForCustomerActionForCleanUp", "CustomerActionPerformedForCleanUp", "CustomerActionPerformed")]
        string DeviceErasureDetailDeviceErasureStatus { get; set; }
        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        string DeviceErasureDetailErasureOrDestructionCertificateSasKey { get; set; }
        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        string DeviceErasureDetailSecureErasureCertificateSasKey { get; set; }
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceDoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceHardwareEncryption { get; set; }
        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        int? ExpectedDataSizeInTeraByte { get; set; }
        /// <summary>Managed service identity type.</summary>
        string IdentityPropertyType { get; set; }
        /// <summary>User assigned identity properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties IdentityPropertyUserAssigned { get; set; }
        /// <summary>List of stages that run in the job.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> JobStage { get; set; }
        /// <summary>Details about which key encryption type is being used.</summary>
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
        /// <summary>Last mitigation action performed on the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob LastMitigationActionOnJob { get; set; }
        /// <summary>Action performed date time</summary>
        global::System.DateTime? LastMitigationActionOnJobActionDateTimeInUtc { get; set; }
        /// <summary>Resolution code provided by customer</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "MoveToCleanUpDevice", "Resume", "Restart", "ReachOutToOperation")]
        string LastMitigationActionOnJobCustomerResolution { get; set; }
        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        bool? LastMitigationActionOnJobIsPerformedByCustomer { get; set; }
        /// <summary>Postal code.</summary>
        string PostalCode { get; set; }
        /// <summary>Preferences for the order.</summary>
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
        /// <summary>Return package shipping details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails ReturnPackage { get; set; }
        /// <summary>Name of the carrier.</summary>
        string ReturnPackageCarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        string ReturnPackageTrackingId { get; set; }
        /// <summary>Url where shipment can be tracked.</summary>
        string ReturnPackageTrackingUrl { get; set; }
        /// <summary>Shared access key to download the return shipment label</summary>
        string ReverseShipmentLabelSasKey { get; set; }
        /// <summary>Optional Reverse Shipping details for order.</summary>
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
        /// <summary>Indicates the type of job details.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string Type { get; set; }
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        string UserAssignedResourceId { get; set; }
        /// <summary>Extended Zip Code.</summary>
        string ZipExtendedCode { get; set; }

    }
}