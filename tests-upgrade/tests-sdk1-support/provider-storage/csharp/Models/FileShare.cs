// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the file share, including Id, resource name, resource
    /// type, Etag.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class FileShare : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the FileShare class.
        /// </summary>
        public FileShare()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileShare class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="lastModifiedTime">Returns the date and time the share
        /// was last modified.</param>
        /// <param name="metadata">A name-value pair to associate with the
        /// share as metadata.</param>
        /// <param name="shareQuota">The maximum size of the share, in
        /// gigabytes. Must be greater than 0, and less than or equal to 5TB
        /// (5120). For Large File Shares, the maximum size is 102400.</param>
        /// <param name="enabledProtocols">The authentication protocol that is
        /// used for the file share. Can only be specified when creating a
        /// share. Possible values include: 'SMB', 'NFS'</param>
        /// <param name="rootSquash">The property is for NFS share only. The
        /// default is NoRootSquash. Possible values include: 'NoRootSquash',
        /// 'RootSquash', 'AllSquash'</param>
        /// <param name="version">The version of the share.</param>
        /// <param name="deleted">Indicates whether the share was
        /// deleted.</param>
        /// <param name="deletedTime">The deleted time if the share was
        /// deleted.</param>
        /// <param name="remainingRetentionDays">Remaining retention days for
        /// share that was soft deleted.</param>
        /// <param name="accessTier">Access tier for specific share. GpV2
        /// account can choose between TransactionOptimized (default), Hot, and
        /// Cool. FileStorage account can choose Premium. Possible values
        /// include: 'TransactionOptimized', 'Hot', 'Cool', 'Premium'</param>
        /// <param name="accessTierChangeTime">Indicates the last modification
        /// time for share access tier.</param>
        /// <param name="accessTierStatus">Indicates if there is a pending
        /// transition for access tier.</param>
        /// <param name="shareUsageBytes">The approximate size of the data
        /// stored on the share. Note that this value may not include all
        /// recently created or recently resized files.</param>
        /// <param name="leaseStatus">The lease status of the share. Possible
        /// values include: 'Locked', 'Unlocked'</param>
        /// <param name="leaseState">Lease state of the share. Possible values
        /// include: 'Available', 'Leased', 'Expired', 'Breaking',
        /// 'Broken'</param>
        /// <param name="leaseDuration">Specifies whether the lease on a share
        /// is of infinite or fixed duration, only when the share is leased.
        /// Possible values include: 'Infinite', 'Fixed'</param>
        /// <param name="signedIdentifiers">List of stored access policies
        /// specified on the share.</param>
        /// <param name="snapshotTime">Creation time of share snapshot returned
        /// in the response of list shares with expand param
        /// "snapshots".</param>
        public FileShare(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), System.Collections.Generic.IDictionary<string, string> metadata = default(System.Collections.Generic.IDictionary<string, string>), int? shareQuota = default(int?), string enabledProtocols = default(string), string version = default(string), System.DateTime? deletedTime = default(System.DateTime?), string leaseStatus = default(string), string leaseState = default(string), string leaseDuration = default(string), System.Collections.Generic.IList<SignedIdentifier> signedIdentifiers = default(System.Collections.Generic.IList<SignedIdentifier>), System.DateTime? snapshotTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string rootSquash = default(string), bool? deleted = default(bool?), int? remainingRetentionDays = default(int?), string accessTier = default(string), System.DateTime? accessTierChangeTime = default(System.DateTime?), string accessTierStatus = default(string), long? shareUsageBytes = default(long?))
            : base(id, name, type, etag)
        {
            this.LastModifiedTime = lastModifiedTime;
            this.Metadata = metadata;
            this.ShareQuota = shareQuota;
            this.EnabledProtocols = enabledProtocols;
            this.RootSquash = rootSquash;
            this.Version = version;
            this.Deleted = deleted;
            this.DeletedTime = deletedTime;
            this.RemainingRetentionDays = remainingRetentionDays;
            this.AccessTier = accessTier;
            this.AccessTierChangeTime = accessTierChangeTime;
            this.AccessTierStatus = accessTierStatus;
            this.ShareUsageBytes = shareUsageBytes;
            this.LeaseStatus = leaseStatus;
            this.LeaseState = leaseState;
            this.LeaseDuration = leaseDuration;
            this.SignedIdentifiers = signedIdentifiers;
            this.SnapshotTime = snapshotTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets returns the date and time the share was last modified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets or sets a name-value pair to associate with the share as
        /// metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.metadata")]
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the maximum size of the share, in gigabytes. Must be
        /// greater than 0, and less than or equal to 5TB (5120). For Large
        /// File Shares, the maximum size is 102400.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shareQuota")]
        public int? ShareQuota { get; set; }

        /// <summary>
        /// Gets or sets the authentication protocol that is used for the file
        /// share. Can only be specified when creating a share. Possible values
        /// include: 'SMB', 'NFS'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.enabledProtocols")]
        public string EnabledProtocols { get; set; }

        /// <summary>
        /// Gets or sets the property is for NFS share only. The default is
        /// NoRootSquash. Possible values include: 'NoRootSquash',
        /// 'RootSquash', 'AllSquash'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.rootSquash")]
        public string RootSquash { get; set; }

        /// <summary>
        /// Gets the version of the share.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets indicates whether the share was deleted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.deleted")]
        public bool? Deleted { get; private set; }

        /// <summary>
        /// Gets the deleted time if the share was deleted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.deletedTime")]
        public System.DateTime? DeletedTime { get; private set; }

        /// <summary>
        /// Gets remaining retention days for share that was soft deleted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.remainingRetentionDays")]
        public int? RemainingRetentionDays { get; private set; }

        /// <summary>
        /// Gets or sets access tier for specific share. GpV2 account can
        /// choose between TransactionOptimized (default), Hot, and Cool.
        /// FileStorage account can choose Premium. Possible values include:
        /// 'TransactionOptimized', 'Hot', 'Cool', 'Premium'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accessTier")]
        public string AccessTier { get; set; }

        /// <summary>
        /// Gets indicates the last modification time for share access tier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accessTierChangeTime")]
        public System.DateTime? AccessTierChangeTime { get; private set; }

        /// <summary>
        /// Gets indicates if there is a pending transition for access tier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accessTierStatus")]
        public string AccessTierStatus { get; private set; }

        /// <summary>
        /// Gets the approximate size of the data stored on the share. Note
        /// that this value may not include all recently created or recently
        /// resized files.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.shareUsageBytes")]
        public long? ShareUsageBytes { get; private set; }

        /// <summary>
        /// Gets the lease status of the share. Possible values include:
        /// 'Locked', 'Unlocked'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.leaseStatus")]
        public string LeaseStatus { get; private set; }

        /// <summary>
        /// Gets lease state of the share. Possible values include:
        /// 'Available', 'Leased', 'Expired', 'Breaking', 'Broken'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.leaseState")]
        public string LeaseState { get; private set; }

        /// <summary>
        /// Gets specifies whether the lease on a share is of infinite or fixed
        /// duration, only when the share is leased. Possible values include:
        /// 'Infinite', 'Fixed'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.leaseDuration")]
        public string LeaseDuration { get; private set; }

        /// <summary>
        /// Gets or sets list of stored access policies specified on the share.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.signedIdentifiers")]
        public System.Collections.Generic.IList<SignedIdentifier> SignedIdentifiers { get; set; }

        /// <summary>
        /// Gets creation time of share snapshot returned in the response of
        /// list shares with expand param "snapshots".
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.snapshotTime")]
        public System.DateTime? SnapshotTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ShareQuota != null)
            {
                if (this.ShareQuota > 102400)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "ShareQuota", 102400);
                }
                if (this.ShareQuota < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "ShareQuota", 1);
                }
            }
        }
    }
}
