// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.PowerShell;

    /// <summary>The type used for update operations of the FileSystemResource.</summary>
    [System.ComponentModel.TypeConverter(typeof(FileSystemResourceUpdateTypeConverter))]
    public partial class FileSystemResourceUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FileSystemResourceUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FileSystemResourceUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FileSystemResourceUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DelegatedSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).DelegatedSubnetId = (string) content.GetValueForProperty("DelegatedSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).DelegatedSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPlanId = (string) content.GetValueForProperty("MarketplaceDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailOfferId = (string) content.GetValueForProperty("MarketplaceDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPublisherId = (string) content.GetValueForProperty("MarketplaceDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailTermUnit = (string) content.GetValueForProperty("MarketplaceDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetailEmail = (string) content.GetValueForProperty("UserDetailEmail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetailEmail, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FileSystemResourceUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IManagedServiceIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ManagedServiceIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.FileSystemResourceUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.ITags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.TagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails) content.GetValueForProperty("MarketplaceDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetail = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails) content.GetValueForProperty("UserDetail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetail, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityUserAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityUserAssignedIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserAssignedIdentities) content.GetValueForProperty("IdentityUserAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).IdentityUserAssignedIdentity, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserAssignedIdentitiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("DelegatedSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).DelegatedSubnetId = (string) content.GetValueForProperty("DelegatedSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).DelegatedSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPlanId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPlanId = (string) content.GetValueForProperty("MarketplaceDetailPlanId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPlanId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailOfferId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailOfferId = (string) content.GetValueForProperty("MarketplaceDetailOfferId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailOfferId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailPublisherId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPublisherId = (string) content.GetValueForProperty("MarketplaceDetailPublisherId",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailPublisherId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailTermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailTermUnit = (string) content.GetValueForProperty("MarketplaceDetailTermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailTermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceDetailMarketplaceSubscriptionStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus = (string) content.GetValueForProperty("MarketplaceDetailMarketplaceSubscriptionStatus",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).MarketplaceDetailMarketplaceSubscriptionStatus, global::System.Convert.ToString);
            }
            if (content.Contains("UserDetailEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetailEmail = (string) content.GetValueForProperty("UserDetailEmail",((Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdateInternal)this).UserDetailEmail, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FileSystemResourceUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FileSystemResourceUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The type used for update operations of the FileSystemResource.
    [System.ComponentModel.TypeConverter(typeof(FileSystemResourceUpdateTypeConverter))]
    public partial interface IFileSystemResourceUpdate

    {

    }
}