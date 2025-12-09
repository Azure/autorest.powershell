// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>
    /// IaaS VM workload-specific restore with integrated rehydration of recovery point.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(IaasVMRestoreWithRehydrationRequestTypeConverter))]
    public partial class IaasVMRestoreWithRehydrationRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRestoreWithRehydrationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IaasVMRestoreWithRehydrationRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRestoreWithRehydrationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IaasVMRestoreWithRehydrationRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IaasVMRestoreWithRehydrationRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="IaasVMRestoreWithRehydrationRequest" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRestoreWithRehydrationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IaasVMRestoreWithRehydrationRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryPointRehydrationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo) content.GetValueForProperty("RecoveryPointRehydrationInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointRehydrationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EncryptionDetailEncryptionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailEncryptionEnabled = (bool?) content.GetValueForProperty("EncryptionDetailEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailEncryptionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionDetailKekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekUrl = (string) content.GetValueForProperty("EncryptionDetailKekUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailSecretKeyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyUrl = (string) content.GetValueForProperty("EncryptionDetailSecretKeyUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekVaultId = (string) content.GetValueForProperty("EncryptionDetailKekVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailSecretKeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyVaultId = (string) content.GetValueForProperty("EncryptionDetailSecretKeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityInfoIsSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoIsSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityInfoIsSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoIsSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityInfoManagedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoManagedIdentityResourceId = (string) content.GetValueForProperty("IdentityInfoManagedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoManagedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityBasedRestoreDetailObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailObjectType = (string) content.GetValueForProperty("IdentityBasedRestoreDetailObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityBasedRestoreDetailTargetStorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailTargetStorageAccountId = (string) content.GetValueForProperty("IdentityBasedRestoreDetailTargetStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailTargetStorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("SecuredVMDetailSecuredVmosdiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetailSecuredVmosdiskEncryptionSetId = (string) content.GetValueForProperty("SecuredVMDetailSecuredVmosdiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetailSecuredVmosdiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption = (string) content.GetValueForProperty("TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDiskNetworkAccessSettingTargetDiskAccessId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskAccessId = (string) content.GetValueForProperty("TargetDiskNetworkAccessSettingTargetDiskAccessId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskAccessId, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IEncryptionDetails) content.GetValueForProperty("EncryptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.EncryptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityInfo) content.GetValueForProperty("IdentityInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IdentityInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityBasedRestoreDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityBasedRestoreDetails) content.GetValueForProperty("IdentityBasedRestoreDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IdentityBasedRestoreDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuredVMDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISecuredVMDetails) content.GetValueForProperty("SecuredVMDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SecuredVMDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetDiskNetworkAccessSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetDiskNetworkAccessSettings) content.GetValueForProperty("TargetDiskNetworkAccessSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetDiskNetworkAccessSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryPointId = (string) content.GetValueForProperty("RecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryPointId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetVirtualMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetVirtualMachineId = (string) content.GetValueForProperty("TargetVirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetVirtualMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetResourceGroupId = (string) content.GetValueForProperty("TargetResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).StorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).VirtualNetworkId = (string) content.GetValueForProperty("VirtualNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).VirtualNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDomainNameId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDomainNameId = (string) content.GetValueForProperty("TargetDomainNameId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDomainNameId, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("AffinityGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).AffinityGroup = (string) content.GetValueForProperty("AffinityGroup",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).AffinityGroup, global::System.Convert.ToString);
            }
            if (content.Contains("CreateNewCloudService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).CreateNewCloudService = (bool?) content.GetValueForProperty("CreateNewCloudService",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).CreateNewCloudService, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OriginalStorageAccountOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).OriginalStorageAccountOption = (bool?) content.GetValueForProperty("OriginalStorageAccountOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).OriginalStorageAccountOption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RestoreDiskLunList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreDiskLunList = (System.Collections.Generic.List<int>) content.GetValueForProperty("RestoreDiskLunList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreDiskLunList, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("RestoreWithManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreWithManagedDisk = (bool?) content.GetValueForProperty("RestoreWithManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreWithManagedDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).DiskEncryptionSetId = (string) content.GetValueForProperty("DiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).DiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RecoveryPointRehydrationInfoRehydrationPriority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationPriority = (string) content.GetValueForProperty("RecoveryPointRehydrationInfoRehydrationPriority",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationPriority, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointRehydrationInfoRehydrationRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationRetentionDuration = (string) content.GetValueForProperty("RecoveryPointRehydrationInfoRehydrationRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationRetentionDuration, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRestoreWithRehydrationRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IaasVMRestoreWithRehydrationRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RecoveryPointRehydrationInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointRehydrationInfo) content.GetValueForProperty("RecoveryPointRehydrationInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointRehydrationInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EncryptionDetailEncryptionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailEncryptionEnabled = (bool?) content.GetValueForProperty("EncryptionDetailEncryptionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailEncryptionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionDetailKekUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekUrl = (string) content.GetValueForProperty("EncryptionDetailKekUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekUrl, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailSecretKeyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyUrl = (string) content.GetValueForProperty("EncryptionDetailSecretKeyUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailKekVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekVaultId = (string) content.GetValueForProperty("EncryptionDetailKekVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailKekVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetailSecretKeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyVaultId = (string) content.GetValueForProperty("EncryptionDetailSecretKeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetailSecretKeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityInfoIsSystemAssignedIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoIsSystemAssignedIdentity = (bool?) content.GetValueForProperty("IdentityInfoIsSystemAssignedIdentity",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoIsSystemAssignedIdentity, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IdentityInfoManagedIdentityResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoManagedIdentityResourceId = (string) content.GetValueForProperty("IdentityInfoManagedIdentityResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfoManagedIdentityResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityBasedRestoreDetailObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailObjectType = (string) content.GetValueForProperty("IdentityBasedRestoreDetailObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityBasedRestoreDetailTargetStorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailTargetStorageAccountId = (string) content.GetValueForProperty("IdentityBasedRestoreDetailTargetStorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetailTargetStorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("SecuredVMDetailSecuredVmosdiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetailSecuredVmosdiskEncryptionSetId = (string) content.GetValueForProperty("SecuredVMDetailSecuredVmosdiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetailSecuredVmosdiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption = (string) content.GetValueForProperty("TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskNetworkAccessOption, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDiskNetworkAccessSettingTargetDiskAccessId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskAccessId = (string) content.GetValueForProperty("TargetDiskNetworkAccessSettingTargetDiskAccessId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSettingTargetDiskAccessId, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IEncryptionDetails) content.GetValueForProperty("EncryptionDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).EncryptionDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.EncryptionDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityInfo) content.GetValueForProperty("IdentityInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IdentityInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityBasedRestoreDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIdentityBasedRestoreDetails) content.GetValueForProperty("IdentityBasedRestoreDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).IdentityBasedRestoreDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IdentityBasedRestoreDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecuredVMDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISecuredVMDetails) content.GetValueForProperty("SecuredVMDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SecuredVMDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SecuredVMDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetDiskNetworkAccessSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSetting = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetDiskNetworkAccessSettings) content.GetValueForProperty("TargetDiskNetworkAccessSetting",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDiskNetworkAccessSetting, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetDiskNetworkAccessSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryPointId = (string) content.GetValueForProperty("RecoveryPointId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryPointId, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RecoveryType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetVirtualMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetVirtualMachineId = (string) content.GetValueForProperty("TargetVirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetVirtualMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceGroupId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetResourceGroupId = (string) content.GetValueForProperty("TargetResourceGroupId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetResourceGroupId, global::System.Convert.ToString);
            }
            if (content.Contains("StorageAccountId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).StorageAccountId = (string) content.GetValueForProperty("StorageAccountId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).StorageAccountId, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).VirtualNetworkId = (string) content.GetValueForProperty("VirtualNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).VirtualNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SubnetId = (string) content.GetValueForProperty("SubnetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).SubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetDomainNameId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDomainNameId = (string) content.GetValueForProperty("TargetDomainNameId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).TargetDomainNameId, global::System.Convert.ToString);
            }
            if (content.Contains("Region"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Region = (string) content.GetValueForProperty("Region",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Region, global::System.Convert.ToString);
            }
            if (content.Contains("AffinityGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).AffinityGroup = (string) content.GetValueForProperty("AffinityGroup",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).AffinityGroup, global::System.Convert.ToString);
            }
            if (content.Contains("CreateNewCloudService"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).CreateNewCloudService = (bool?) content.GetValueForProperty("CreateNewCloudService",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).CreateNewCloudService, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OriginalStorageAccountOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).OriginalStorageAccountOption = (bool?) content.GetValueForProperty("OriginalStorageAccountOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).OriginalStorageAccountOption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RestoreDiskLunList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreDiskLunList = (System.Collections.Generic.List<int>) content.GetValueForProperty("RestoreDiskLunList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreDiskLunList, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("RestoreWithManagedDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreWithManagedDisk = (bool?) content.GetValueForProperty("RestoreWithManagedDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).RestoreWithManagedDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DiskEncryptionSetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).DiskEncryptionSetId = (string) content.GetValueForProperty("DiskEncryptionSetId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).DiskEncryptionSetId, global::System.Convert.ToString);
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreRequestInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RecoveryPointRehydrationInfoRehydrationPriority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationPriority = (string) content.GetValueForProperty("RecoveryPointRehydrationInfoRehydrationPriority",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationPriority, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointRehydrationInfoRehydrationRetentionDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationRetentionDuration = (string) content.GetValueForProperty("RecoveryPointRehydrationInfoRehydrationRetentionDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRestoreWithRehydrationRequestInternal)this).RecoveryPointRehydrationInfoRehydrationRetentionDuration, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// IaaS VM workload-specific restore with integrated rehydration of recovery point.
    [System.ComponentModel.TypeConverter(typeof(IaasVMRestoreWithRehydrationRequestTypeConverter))]
    public partial interface IIaasVMRestoreWithRehydrationRequest

    {

    }
}