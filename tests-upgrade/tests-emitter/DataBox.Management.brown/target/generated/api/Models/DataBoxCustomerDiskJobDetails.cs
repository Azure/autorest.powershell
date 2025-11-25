// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Customer disk job details.</summary>
    public partial class DataBoxCustomerDiskJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetails,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails __jobDetails = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobDetails();

        /// <summary>Available actions on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Action; }

        /// <summary>Shared access key to download the chain of custody logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ChainOfCustodySasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ChainOfCustodySasKey; }

        /// <summary>Name of the City.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string City { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).City = value ?? null; }

        /// <summary>Name of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string CompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).CompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).CompanyName = value ?? null; }

        /// <summary>Contact details for notification and shipping.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails ContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetail = value ?? null /* model class */; }

        /// <summary>List of Email-ids to be notified about job progress.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ContactDetailEmailList { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailEmailList; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailEmailList = value ; }

        /// <summary>Notification preference for a job stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.INotificationPreference> ContactDetailNotificationPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailNotificationPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailNotificationPreference = value ?? null /* arrayOf */; }

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ContactDetailsContactName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsContactName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsContactName = value ; }

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ContactDetailsMobile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsMobile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsMobile = value ?? null; }

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ContactDetailsPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsPhone = value ; }

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ContactDetailsPhoneExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsPhoneExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetailsPhoneExtension = value ?? null; }

        /// <summary>List of copy log details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> CopyLogDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).CopyLogDetail; }

        /// <summary>Backing field for <see cref="CopyProgress" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress> _copyProgress;

        /// <summary>Copy progress per disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress> CopyProgress { get => this._copyProgress; }

        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Country { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Country; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Country = value ?? null; }

        /// <summary>DataCenter code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DataCenterCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataCenterCode; }

        /// <summary>Details of the data to be exported from azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataExportDetails> DataExportDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataExportDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataExportDetail = value ?? null /* arrayOf */; }

        /// <summary>Details of the data to be imported into azure.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataImportDetails> DataImportDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataImportDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataImportDetail = value ?? null /* arrayOf */; }

        /// <summary>Datacenter address to ship to, for the given sku and storage location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse DatacenterAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddress = value ?? null /* model class */; }

        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DatacenterAddressDataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressDataCenterAzureLocation; }

        /// <summary>List of supported carriers for return shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> DatacenterAddressSupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressSupportedCarriersForReturnShipment; }

        /// <summary>Data center address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DatacenterAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressType; }

        /// <summary>Backing field for <see cref="DeliverToDcPackageDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfo _deliverToDcPackageDetail;

        /// <summary>Delivery package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfo DeliverToDcPackageDetail { get => (this._deliverToDcPackageDetail = this._deliverToDcPackageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierInfo()); }

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeliverToDcPackageDetailCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfoInternal)DeliverToDcPackageDetail).CarrierName; }

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeliverToDcPackageDetailTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfoInternal)DeliverToDcPackageDetail).TrackingId; }

        /// <summary>Delivery package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails DeliveryPackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackage = value ?? null /* model class */; }

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DeliveryPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageCarrierName; }

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DeliveryPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageTrackingId; }

        /// <summary>Url where shipment can be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DeliveryPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageTrackingUrl; }

        /// <summary>Holds device data erasure details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails DeviceErasureDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetail = value ?? null /* model class */; }

        /// <summary>Holds the device erasure completion status</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DeviceErasureDetailDeviceErasureStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailDeviceErasureStatus; }

        /// <summary>Shared access key to download cleanup or destruction certificate for device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DeviceErasureDetailErasureOrDestructionCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailErasureOrDestructionCertificateSasKey; }

        /// <summary>Shared access key to download secure erasure certificate for the device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DeviceErasureDetailSecureErasureCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailSecureErasureCertificateSasKey; }

        /// <summary>Backing field for <see cref="EnableManifestBackup" /> property.</summary>
        private bool? _enableManifestBackup;

        /// <summary>Flag to indicate if disk manifest should be backed-up in the Storage Account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? EnableManifestBackup { get => this._enableManifestBackup; set => this._enableManifestBackup = value; }

        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string EncryptionPreferenceDoubleEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).EncryptionPreferenceDoubleEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).EncryptionPreferenceDoubleEncryption = value ?? null; }

        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string EncryptionPreferenceHardwareEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).EncryptionPreferenceHardwareEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).EncryptionPreferenceHardwareEncryption = value ?? null; }

        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public int? ExpectedDataSizeInTeraByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ExpectedDataSizeInTeraByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ExpectedDataSizeInTeraByte = value ?? default(int); }

        /// <summary>Backing field for <see cref="ExportDiskDetailsCollection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsExportDiskDetailsCollection _exportDiskDetailsCollection;

        /// <summary>Contains the map of disk serial number to the disk details for export jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsExportDiskDetailsCollection ExportDiskDetailsCollection { get => (this._exportDiskDetailsCollection = this._exportDiskDetailsCollection ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxCustomerDiskJobDetailsExportDiskDetailsCollection()); }

        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string IdentityPropertyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).IdentityPropertyType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).IdentityPropertyType = value ?? null; }

        /// <summary>User assigned identity properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties IdentityPropertyUserAssigned { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).IdentityPropertyUserAssigned; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).IdentityPropertyUserAssigned = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="ImportDiskDetailsCollection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection _importDiskDetailsCollection;

        /// <summary>Contains the map of disk serial number to the disk details for import jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection ImportDiskDetailsCollection { get => (this._importDiskDetailsCollection = this._importDiskDetailsCollection ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxCustomerDiskJobDetailsImportDiskDetailsCollection()); set => this._importDiskDetailsCollection = value; }

        /// <summary>List of stages that run in the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> JobStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).JobStage; }

        /// <summary>Details about which key encryption type is being used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey KeyEncryptionKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKey = value ?? null /* model class */; }

        /// <summary>Managed identity properties used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties KeyEncryptionKeyIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyIdentityProperty = value ?? null /* model class */; }

        /// <summary>Type of encryption key used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string KeyEncryptionKeyKekType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyKekType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyKekType = value ?? null; }

        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string KeyEncryptionKeyKekUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyKekUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyKekUrl = value ?? null; }

        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string KeyEncryptionKeyKekVaultResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyKekVaultResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyKekVaultResourceId = value ?? null; }

        /// <summary>Last mitigation action performed on the job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob LastMitigationActionOnJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJob = value ?? null /* model class */; }

        /// <summary>Action performed date time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public global::System.DateTime? LastMitigationActionOnJobActionDateTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobActionDateTimeInUtc; }

        /// <summary>Resolution code provided by customer</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string LastMitigationActionOnJobCustomerResolution { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobCustomerResolution; }

        /// <summary>
        /// Action performed by customer,
        /// possibility is that mitigation might happen by customer or service or by ops
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? LastMitigationActionOnJobIsPerformedByCustomer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobIsPerformedByCustomer; }

        /// <summary>Internal Acessors for CopyProgress</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal.CopyProgress { get => this._copyProgress; set { {_copyProgress = value;} } }

        /// <summary>Internal Acessors for DeliverToDcPackageDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfo Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal.DeliverToDcPackageDetail { get => (this._deliverToDcPackageDetail = this._deliverToDcPackageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierInfo()); set { {_deliverToDcPackageDetail = value;} } }

        /// <summary>Internal Acessors for DeliverToDcPackageDetailCarrierName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal.DeliverToDcPackageDetailCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfoInternal)DeliverToDcPackageDetail).CarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfoInternal)DeliverToDcPackageDetail).CarrierName = value ?? null; }

        /// <summary>Internal Acessors for DeliverToDcPackageDetailTrackingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal.DeliverToDcPackageDetailTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfoInternal)DeliverToDcPackageDetail).TrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfoInternal)DeliverToDcPackageDetail).TrackingId = value ?? null; }

        /// <summary>Internal Acessors for ExportDiskDetailsCollection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsExportDiskDetailsCollection Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal.ExportDiskDetailsCollection { get => (this._exportDiskDetailsCollection = this._exportDiskDetailsCollection ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DataBoxCustomerDiskJobDetailsExportDiskDetailsCollection()); set { {_exportDiskDetailsCollection = value;} } }

        /// <summary>Internal Acessors for ReturnToCustomerPackageDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsInternal.ReturnToCustomerPackageDetail { get => (this._returnToCustomerPackageDetail = this._returnToCustomerPackageDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PackageCarrierDetails()); set { {_returnToCustomerPackageDetail = value;} } }

        /// <summary>Internal Acessors for Action</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Action = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for ChainOfCustodySasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ChainOfCustodySasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ChainOfCustodySasKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ChainOfCustodySasKey = value ?? null; }

        /// <summary>Internal Acessors for ContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ContactDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CopyLogDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICopyLogDetails> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.CopyLogDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).CopyLogDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).CopyLogDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DataCenterCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DataCenterCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataCenterCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DataCenterCode = value ?? null; }

        /// <summary>Internal Acessors for DatacenterAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddress = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DatacenterAddressDataCenterAzureLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddressDataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressDataCenterAzureLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressDataCenterAzureLocation = value ?? null; }

        /// <summary>Internal Acessors for DatacenterAddressSupportedCarriersForReturnShipment</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddressSupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressSupportedCarriersForReturnShipment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressSupportedCarriersForReturnShipment = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DatacenterAddressType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DatacenterAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DatacenterAddressType = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackage = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DeliveryPackageCarrierName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageCarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageCarrierName = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackageTrackingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageTrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageTrackingId = value ?? null; }

        /// <summary>Internal Acessors for DeliveryPackageTrackingUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeliveryPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageTrackingUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeliveryPackageTrackingUrl = value ?? null; }

        /// <summary>Internal Acessors for DeviceErasureDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDeviceErasureDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for DeviceErasureDetailDeviceErasureStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetailDeviceErasureStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailDeviceErasureStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailDeviceErasureStatus = value ?? null; }

        /// <summary>Internal Acessors for DeviceErasureDetailErasureOrDestructionCertificateSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetailErasureOrDestructionCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailErasureOrDestructionCertificateSasKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailErasureOrDestructionCertificateSasKey = value ?? null; }

        /// <summary>Internal Acessors for DeviceErasureDetailSecureErasureCertificateSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.DeviceErasureDetailSecureErasureCertificateSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailSecureErasureCertificateSasKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).DeviceErasureDetailSecureErasureCertificateSasKey = value ?? null; }

        /// <summary>Internal Acessors for IdentityPropertyUserAssigned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.IdentityPropertyUserAssigned { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).IdentityPropertyUserAssigned; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).IdentityPropertyUserAssigned = value ?? null /* model class */; }

        /// <summary>Internal Acessors for JobStage</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobStages> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.JobStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).JobStage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).JobStage = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for KeyEncryptionKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.KeyEncryptionKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKey = value ?? null /* model class */; }

        /// <summary>Internal Acessors for KeyEncryptionKeyIdentityProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.KeyEncryptionKeyIdentityProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyIdentityProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).KeyEncryptionKeyIdentityProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LastMitigationActionOnJob</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ILastMitigationActionOnJob Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJob { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJob; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJob = value ?? null /* model class */; }

        /// <summary>Internal Acessors for LastMitigationActionOnJobActionDateTimeInUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJobActionDateTimeInUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobActionDateTimeInUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobActionDateTimeInUtc = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for LastMitigationActionOnJobCustomerResolution</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJobCustomerResolution { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobCustomerResolution; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobCustomerResolution = value ?? null; }

        /// <summary>Internal Acessors for LastMitigationActionOnJobIsPerformedByCustomer</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.LastMitigationActionOnJobIsPerformedByCustomer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobIsPerformedByCustomer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).LastMitigationActionOnJobIsPerformedByCustomer = value ?? default(bool); }

        /// <summary>Internal Acessors for Preference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.Preference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Preference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Preference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceEncryptionPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.PreferenceEncryptionPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceEncryptionPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceEncryptionPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceReverseTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.PreferenceReverseTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceReverseTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceReverseTransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for PreferenceTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.PreferenceTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceTransportPreference = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReturnPackage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackage = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReturnPackageCarrierName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageCarrierName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageCarrierName = value ?? null; }

        /// <summary>Internal Acessors for ReturnPackageTrackingId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageTrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageTrackingId = value ?? null; }

        /// <summary>Internal Acessors for ReturnPackageTrackingUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReturnPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageTrackingUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageTrackingUrl = value ?? null; }

        /// <summary>Internal Acessors for ReverseShipmentLabelSasKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShipmentLabelSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShipmentLabelSasKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShipmentLabelSasKey = value ?? null; }

        /// <summary>Internal Acessors for ReverseShippingDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseShippingDetailContactDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetailContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailContactDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseShippingDetailIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetailIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailIsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for ReverseShippingDetailShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseShippingDetailShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailShippingAddress = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ReverseTransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseTransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseTransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for ShippingAddress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.ShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ShippingAddress = value ?? null /* model class */; }

        /// <summary>Internal Acessors for TransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal.TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TransportPreferenceIsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TransportPreferenceIsUpdated = value ?? default(bool); }

        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string PostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PostalCode = value ?? null; }

        /// <summary>Preferences for the order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences Preference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Preference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Preference = value ?? null /* model class */; }

        /// <summary>Preferences related to the Encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences PreferenceEncryptionPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceEncryptionPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceEncryptionPreference = value ?? null /* model class */; }

        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> PreferencePreferredDataCenterRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferencePreferredDataCenterRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferencePreferredDataCenterRegion = value ?? null /* arrayOf */; }

        /// <summary>Optional Preferences related to the reverse shipment logistics of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences PreferenceReverseTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceReverseTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceReverseTransportPreference = value ?? null /* model class */; }

        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> PreferenceStorageAccountAccessTierPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceStorageAccountAccessTierPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceStorageAccountAccessTierPreference = value ?? null /* arrayOf */; }

        /// <summary>Preferences related to the shipment logistics of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences PreferenceTransportPreference { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceTransportPreference; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).PreferenceTransportPreference = value ?? null /* model class */; }

        /// <summary>Return package shipping details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageShippingDetails ReturnPackage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackage = value ?? null /* model class */; }

        /// <summary>Name of the carrier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReturnPackageCarrierName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageCarrierName; }

        /// <summary>Tracking Id of shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReturnPackageTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageTrackingId; }

        /// <summary>Url where shipment can be tracked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReturnPackageTrackingUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReturnPackageTrackingUrl; }

        /// <summary>Backing field for <see cref="ReturnToCustomerPackageDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails _returnToCustomerPackageDetail;

        /// <summary>Return package shipping details.</summary>
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

        /// <summary>Shared access key to download the return shipment label</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShipmentLabelSasKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShipmentLabelSasKey; }

        /// <summary>Optional Reverse Shipping details for order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IReverseShippingDetails ReverseShippingDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetail = value ?? null /* model class */; }

        /// <summary>Contact Info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IContactInfo ReverseShippingDetailContactDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailContactDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailContactDetail = value ?? null /* model class */; }

        /// <summary>
        /// A flag to indicate whether Reverse Shipping details are updated or not after device has been prepared.
        /// Read only field
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? ReverseShippingDetailIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailIsUpdated; }

        /// <summary>Shipping address where customer wishes to receive the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ReverseShippingDetailShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailShippingAddress = value ?? null /* model class */; }

        /// <summary>Mobile number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsContactDetailsMobile { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactDetailsMobile; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactDetailsMobile = value ?? null; }

        /// <summary>Phone number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsContactDetailsPhone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactDetailsPhone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactDetailsPhone = value ?? null; }

        /// <summary>Phone extension number of the contact person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsContactDetailsPhoneExtension { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactDetailsPhoneExtension; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactDetailsPhoneExtension = value ?? null; }

        /// <summary>Contact name of the person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsContactName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsContactName = value ?? null; }

        /// <summary>Name of the City.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressCity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressCity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressCity = value ?? null; }

        /// <summary>Name of the company.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressCompanyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressCompanyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressCompanyName = value ?? null; }

        /// <summary>Name of the Country.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressCountry { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressCountry; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressCountry = value ?? null; }

        /// <summary>Postal code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressPostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressPostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressPostalCode = value ?? null; }

        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? ReverseShippingDetailsShippingAddressSkipAddressValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressSkipAddressValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressSkipAddressValidation = value ?? default(bool); }

        /// <summary>Name of the State or Province.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressStateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStateOrProvince = value ?? null; }

        /// <summary>Street Address line 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressStreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStreetAddress1 = value ?? null; }

        /// <summary>Street Address line 2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressStreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStreetAddress2 = value ?? null; }

        /// <summary>Street Address line 3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressStreetAddress3 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStreetAddress3; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressStreetAddress3 = value ?? null; }

        /// <summary>Tax Identification Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressTaxIdentificationNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressTaxIdentificationNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressTaxIdentificationNumber = value ?? null; }

        /// <summary>Type of address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressType = value ?? null; }

        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseShippingDetailsShippingAddressZipExtendedCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressZipExtendedCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseShippingDetailsShippingAddressZipExtendedCode = value ?? null; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseTransportPreferenceIsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ReverseTransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseTransportPreferencePreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ReverseTransportPreferencePreferredShipmentType = value ?? null; }

        /// <summary>Shipping address of the customer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IShippingAddress ShippingAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ShippingAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ShippingAddress = value ?? null /* model class */; }

        /// <summary>Type of address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ShippingAddressType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ShippingAddressType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ShippingAddressType = value ?? null; }

        /// <summary>Flag to indicate if customer has chosen to skip default address validation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? SkipAddressValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).SkipAddressValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).SkipAddressValidation = value ?? default(bool); }

        /// <summary>Name of the State or Province.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StateOrProvince = value ?? null; }

        /// <summary>Street Address line 1.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StreetAddress1 = value ?? null; }

        /// <summary>Street Address line 2.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StreetAddress2 = value ?? null; }

        /// <summary>Street Address line 3.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string StreetAddress3 { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StreetAddress3; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).StreetAddress3 = value ?? null; }

        /// <summary>Tax Identification Number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string TaxIdentificationNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TaxIdentificationNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TaxIdentificationNumber = value ?? null; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public bool? TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TransportPreferenceIsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string TransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TransportPreferencePreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).TransportPreferencePreferredShipmentType = value ?? null; }

        /// <summary>Indicates the type of job details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Type { get => "DataBoxCustomerDisk"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).Type = "DataBoxCustomerDisk"; }

        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string UserAssignedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).UserAssignedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).UserAssignedResourceId = value ?? null; }

        /// <summary>Extended Zip Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string ZipExtendedCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ZipExtendedCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal)__jobDetails).ZipExtendedCode = value ?? null; }

        /// <summary>Creates an new <see cref="DataBoxCustomerDiskJobDetails" /> instance.</summary>
        public DataBoxCustomerDiskJobDetails()
        {
            this.__jobDetails.Type = "DataBoxCustomerDisk";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobDetails), __jobDetails);
            await eventListener.AssertObjectIsValid(nameof(__jobDetails), __jobDetails);
        }
    }
    /// Customer disk job details.
    public partial interface IDataBoxCustomerDiskJobDetails :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails
    {
        /// <summary>Copy progress per disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Copy progress per disk.",
        SerializedName = @"copyProgress",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress> CopyProgress { get;  }
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
        string DeliverToDcPackageDetailCarrierName { get;  }
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
        string DeliverToDcPackageDetailTrackingId { get;  }
        /// <summary>Flag to indicate if disk manifest should be backed-up in the Storage Account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to indicate if disk manifest should be backed-up in the Storage Account.",
        SerializedName = @"enableManifestBackup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableManifestBackup { get; set; }
        /// <summary>Contains the map of disk serial number to the disk details for export jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Contains the map of disk serial number to the disk details for export jobs.",
        SerializedName = @"exportDiskDetailsCollection",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsExportDiskDetailsCollection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsExportDiskDetailsCollection ExportDiskDetailsCollection { get;  }
        /// <summary>Contains the map of disk serial number to the disk details for import jobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Contains the map of disk serial number to the disk details for import jobs.",
        SerializedName = @"importDiskDetailsCollection",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection ImportDiskDetailsCollection { get; set; }
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

    }
    /// Customer disk job details.
    internal partial interface IDataBoxCustomerDiskJobDetailsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetailsInternal
    {
        /// <summary>Copy progress per disk.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskCopyProgress> CopyProgress { get; set; }
        /// <summary>Delivery package shipping details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierInfo DeliverToDcPackageDetail { get; set; }
        /// <summary>Name of the carrier.</summary>
        string DeliverToDcPackageDetailCarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        string DeliverToDcPackageDetailTrackingId { get; set; }
        /// <summary>Flag to indicate if disk manifest should be backed-up in the Storage Account.</summary>
        bool? EnableManifestBackup { get; set; }
        /// <summary>Contains the map of disk serial number to the disk details for export jobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsExportDiskDetailsCollection ExportDiskDetailsCollection { get; set; }
        /// <summary>Contains the map of disk serial number to the disk details for import jobs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataBoxCustomerDiskJobDetailsImportDiskDetailsCollection ImportDiskDetailsCollection { get; set; }
        /// <summary>Return package shipping details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPackageCarrierDetails ReturnToCustomerPackageDetail { get; set; }
        /// <summary>Carrier Account Number of customer for customer disk.</summary>
        System.Security.SecureString ReturnToCustomerPackageDetailCarrierAccountNumber { get; set; }
        /// <summary>Name of the carrier.</summary>
        string ReturnToCustomerPackageDetailCarrierName { get; set; }
        /// <summary>Tracking Id of shipment.</summary>
        string ReturnToCustomerPackageDetailTrackingId { get; set; }

    }
}