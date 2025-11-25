// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job Resource.</summary>
    public partial class JobResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TrackedResource();

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).AdditionalInfo; }

        /// <summary>Flag to indicate if all devices associated with the job are lost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? AllDevicesLost { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).AllDevicesLost; }

        /// <summary>Reason for cancellation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CancellationReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).CancellationReason; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Code; }

        /// <summary>Name of the stage where delay might be present.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DelayedStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DelayedStage; }

        /// <summary>Scheduled date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public global::System.DateTime? DeliveryInfoScheduledDateTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DeliveryInfoScheduledDateTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DeliveryInfoScheduledDateTime = value ?? default(global::System.DateTime); }

        /// <summary>Delivery type of Job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DeliveryType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DeliveryType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DeliveryType = value ?? null; }

        /// <summary>Details of a job run. This field will only be sent for expand details filter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Detail = value ?? null /* model class */; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ErrorDetail; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity _identity;

        /// <summary>Msi identity of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentity()); set => this._identity = value; }

        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).PrincipalId; }

        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).TenantId; }

        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Describes whether the job is cancellable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IsCancellable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsCancellable; }

        /// <summary>Flag to indicate cancellation of scheduled job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IsCancellableWithoutFee { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsCancellableWithoutFee; }

        /// <summary>Describes whether the job is deletable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IsDeletable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsDeletable; }

        /// <summary>Is Prepare To Ship Enabled on this job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IsPrepareToShipEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsPrepareToShipEnabled; }

        /// <summary>Describes whether the shipping address is editable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? IsShippingAddressEditable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsShippingAddressEditable; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Message; }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).AdditionalInfo = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for AllDevicesLost</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.AllDevicesLost { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).AllDevicesLost; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).AllDevicesLost = value ?? default(bool); }

        /// <summary>Internal Acessors for CancellationReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.CancellationReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).CancellationReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).CancellationReason = value ?? null; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>Internal Acessors for DelayedStage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.DelayedStage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DelayedStage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DelayedStage = value ?? null; }

        /// <summary>Internal Acessors for DeliveryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDeliveryInfo Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.DeliveryInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DeliveryInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).DeliveryInfo = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Error = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ErrorDetail</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.ErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ErrorDetail = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ResourceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).PrincipalId = value ?? null; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityInternal)Identity).TenantId = value ?? null; }

        /// <summary>Internal Acessors for IsCancellable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IsCancellable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsCancellable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsCancellable = value ?? default(bool); }

        /// <summary>Internal Acessors for IsCancellableWithoutFee</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IsCancellableWithoutFee { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsCancellableWithoutFee; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsCancellableWithoutFee = value ?? default(bool); }

        /// <summary>Internal Acessors for IsDeletable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IsDeletable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsDeletable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsDeletable = value ?? default(bool); }

        /// <summary>Internal Acessors for IsPrepareToShipEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IsPrepareToShipEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsPrepareToShipEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsPrepareToShipEnabled = value ?? default(bool); }

        /// <summary>Internal Acessors for IsShippingAddressEditable</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.IsShippingAddressEditable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsShippingAddressEditable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).IsShippingAddressEditable = value ?? default(bool); }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ReverseShippingDetailsUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.ReverseShippingDetailsUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ReverseShippingDetailsUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ReverseShippingDetailsUpdate = value ?? null; }

        /// <summary>Internal Acessors for ReverseTransportPreferenceUpdate</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.ReverseTransportPreferenceUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ReverseTransportPreferenceUpdate; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ReverseTransportPreferenceUpdate = value ?? null; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for StartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Status = value ?? null; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobResourceInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Target = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobProperties _property;

        /// <summary>Properties of a job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.JobProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>The Editable status for Reverse Shipping Address and Contact Info</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseShippingDetailsUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ReverseShippingDetailsUpdate; }

        /// <summary>The Editable status for Reverse Transport preferences</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseTransportPreferenceUpdate { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).ReverseTransportPreferenceUpdate; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku _sku;

        /// <summary>The sku type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Sku()); set => this._sku = value; }

        /// <summary>The display name of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).DisplayName = value ?? null; }

        /// <summary>The sku family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Family = value ?? null; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Model = value ?? null; }

        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Name = value ; }

        /// <summary>Time at which the job was started in UTC ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).StartTime; }

        /// <summary>Name of the stage which is in progress.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Status; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).Target; }

        /// <summary>Type of the data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransferType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).TransferType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobPropertiesInternal)Property).TransferType = value ; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="JobResource" /> instance.</summary>
        public JobResource()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Job Resource.
    public partial interface IJobResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResource
    {
        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets additional error info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get;  }
        /// <summary>Flag to indicate if all devices associated with the job are lost.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Flag to indicate if all devices associated with the job are lost.",
        SerializedName = @"allDevicesLost",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllDevicesLost { get;  }
        /// <summary>Reason for cancellation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Reason for cancellation.",
        SerializedName = @"cancellationReason",
        PossibleTypes = new [] { typeof(string) })]
        string CancellationReason { get;  }
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Name of the stage where delay might be present.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the stage where delay might be present.",
        SerializedName = @"delayedStage",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DeviceOrdered", "DevicePrepared", "Dispatched", "Delivered", "PickedUp", "AtAzureDC", "DataCopy", "Completed", "CompletedWithErrors", "Cancelled", "Failed_IssueReportedAtCustomer", "Failed_IssueDetectedAtAzureDC", "Aborted", "CompletedWithWarnings", "ReadyToDispatchFromAzureDC", "ReadyToReceiveAtAzureDC", "Created", "ShippedToAzureDC", "AwaitingShipmentDetails", "PreparingToShipFromAzureDC", "ShippedToCustomer")]
        string DelayedStage { get;  }
        /// <summary>Scheduled date time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Scheduled date time.",
        SerializedName = @"scheduledDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? DeliveryInfoScheduledDateTime { get; set; }
        /// <summary>Delivery type of Job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Delivery type of Job.",
        SerializedName = @"deliveryType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NonScheduled", "Scheduled")]
        string DeliveryType { get; set; }
        /// <summary>Details of a job run. This field will only be sent for expand details filter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of a job run. This field will only be sent for expand details filter.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails Detail { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets details for the error.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> ErrorDetail { get;  }
        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Service Principal Id backing the Msi",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Home Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Assigned Identities",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Describes whether the job is cancellable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Describes whether the job is cancellable or not.",
        SerializedName = @"isCancellable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsCancellable { get;  }
        /// <summary>Flag to indicate cancellation of scheduled job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Flag to indicate cancellation of scheduled job.",
        SerializedName = @"isCancellableWithoutFee",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsCancellableWithoutFee { get;  }
        /// <summary>Describes whether the job is deletable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Describes whether the job is deletable or not.",
        SerializedName = @"isDeletable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDeletable { get;  }
        /// <summary>Is Prepare To Ship Enabled on this job</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Is Prepare To Ship Enabled on this job",
        SerializedName = @"isPrepareToShipEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPrepareToShipEnabled { get;  }
        /// <summary>Describes whether the shipping address is editable or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Describes whether the shipping address is editable or not.",
        SerializedName = @"isShippingAddressEditable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsShippingAddressEditable { get;  }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message parsed from the body of the http error response.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The Editable status for Reverse Shipping Address and Contact Info</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Editable status for Reverse Shipping Address and Contact Info",
        SerializedName = @"reverseShippingDetailsUpdate",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled", "NotSupported")]
        string ReverseShippingDetailsUpdate { get;  }
        /// <summary>The Editable status for Reverse Transport preferences</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Editable status for Reverse Transport preferences",
        SerializedName = @"reverseTransportPreferenceUpdate",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled", "NotSupported")]
        string ReverseTransportPreferenceUpdate { get;  }
        /// <summary>The display name of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The display name of the sku.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string SkuDisplayName { get; set; }
        /// <summary>The sku family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku family.",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string SkuFamily { get; set; }
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
        string SkuModel { get; set; }
        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }
        /// <summary>Time at which the job was started in UTC ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Time at which the job was started in UTC ISO 8601 format.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get;  }
        /// <summary>Name of the stage which is in progress.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the stage which is in progress.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DeviceOrdered", "DevicePrepared", "Dispatched", "Delivered", "PickedUp", "AtAzureDC", "DataCopy", "Completed", "CompletedWithErrors", "Cancelled", "Failed_IssueReportedAtCustomer", "Failed_IssueDetectedAtAzureDC", "Aborted", "CompletedWithWarnings", "ReadyToDispatchFromAzureDC", "ReadyToReceiveAtAzureDC", "Created", "ShippedToAzureDC", "AwaitingShipmentDetails", "PreparingToShipFromAzureDC", "ShippedToCustomer")]
        string Status { get;  }
        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the target of the error.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }
        /// <summary>Type of the data transfer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the data transfer.",
        SerializedName = @"transferType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ImportToAzure", "ExportFromAzure")]
        string TransferType { get; set; }

    }
    /// Job Resource.
    internal partial interface IJobResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITrackedResourceInternal
    {
        /// <summary>Gets or sets additional error info.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IAdditionalErrorInfo1> AdditionalInfo { get; set; }
        /// <summary>Flag to indicate if all devices associated with the job are lost.</summary>
        bool? AllDevicesLost { get; set; }
        /// <summary>Reason for cancellation.</summary>
        string CancellationReason { get; set; }
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>Name of the stage where delay might be present.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DeviceOrdered", "DevicePrepared", "Dispatched", "Delivered", "PickedUp", "AtAzureDC", "DataCopy", "Completed", "CompletedWithErrors", "Cancelled", "Failed_IssueReportedAtCustomer", "Failed_IssueDetectedAtAzureDC", "Aborted", "CompletedWithWarnings", "ReadyToDispatchFromAzureDC", "ReadyToReceiveAtAzureDC", "Created", "ShippedToAzureDC", "AwaitingShipmentDetails", "PreparingToShipFromAzureDC", "ShippedToCustomer")]
        string DelayedStage { get; set; }
        /// <summary>Delivery Info of Job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDeliveryInfo DeliveryInfo { get; set; }
        /// <summary>Scheduled date time.</summary>
        global::System.DateTime? DeliveryInfoScheduledDateTime { get; set; }
        /// <summary>Delivery type of Job.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("NonScheduled", "Scheduled")]
        string DeliveryType { get; set; }
        /// <summary>Details of a job run. This field will only be sent for expand details filter.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobDetails Detail { get; set; }
        /// <summary>Top level error for the job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError Error { get; set; }
        /// <summary>Gets or sets details for the error.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ICloudError> ErrorDetail { get; set; }
        /// <summary>Msi identity of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentity Identity { get; set; }
        /// <summary>Service Principal Id backing the Msi</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>Home Tenant Id</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Identity type</summary>
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Describes whether the job is cancellable or not.</summary>
        bool? IsCancellable { get; set; }
        /// <summary>Flag to indicate cancellation of scheduled job.</summary>
        bool? IsCancellableWithoutFee { get; set; }
        /// <summary>Describes whether the job is deletable or not.</summary>
        bool? IsDeletable { get; set; }
        /// <summary>Is Prepare To Ship Enabled on this job</summary>
        bool? IsPrepareToShipEnabled { get; set; }
        /// <summary>Describes whether the shipping address is editable or not.</summary>
        bool? IsShippingAddressEditable { get; set; }
        /// <summary>The error message parsed from the body of the http error response.</summary>
        string Message { get; set; }
        /// <summary>Properties of a job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IJobProperties Property { get; set; }
        /// <summary>The Editable status for Reverse Shipping Address and Contact Info</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled", "NotSupported")]
        string ReverseShippingDetailsUpdate { get; set; }
        /// <summary>The Editable status for Reverse Transport preferences</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled", "NotSupported")]
        string ReverseTransportPreferenceUpdate { get; set; }
        /// <summary>The sku type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku Sku { get; set; }
        /// <summary>The display name of the sku.</summary>
        string SkuDisplayName { get; set; }
        /// <summary>The sku family.</summary>
        string SkuFamily { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string SkuModel { get; set; }
        /// <summary>The sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }
        /// <summary>Time at which the job was started in UTC ISO 8601 format.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>Name of the stage which is in progress.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DeviceOrdered", "DevicePrepared", "Dispatched", "Delivered", "PickedUp", "AtAzureDC", "DataCopy", "Completed", "CompletedWithErrors", "Cancelled", "Failed_IssueReportedAtCustomer", "Failed_IssueDetectedAtAzureDC", "Aborted", "CompletedWithWarnings", "ReadyToDispatchFromAzureDC", "ReadyToReceiveAtAzureDC", "Created", "ShippedToAzureDC", "AwaitingShipmentDetails", "PreparingToShipFromAzureDC", "ShippedToCustomer")]
        string Status { get; set; }
        /// <summary>Gets or sets the target of the error.</summary>
        string Target { get; set; }
        /// <summary>Type of the data transfer.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("ImportToAzure", "ExportFromAzure")]
        string TransferType { get; set; }

    }
}