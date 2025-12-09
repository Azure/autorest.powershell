// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>IaaS VM workload specific backup copy.</summary>
    [System.ComponentModel.TypeConverter(typeof(IaasVMRecoveryPointTypeConverter))]
    public partial class IaasVMRecoveryPoint
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPoint" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPoint DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IaasVMRecoveryPoint(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPoint" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPoint DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IaasVMRecoveryPoint(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IaasVMRecoveryPoint" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IaasVMRecoveryPoint" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPoint FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IaasVMRecoveryPoint(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KeyAndSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecret = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKeyAndSecretDetails) content.GetValueForProperty("KeyAndSecret",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecret, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.KeyAndSecretDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointDiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointDiskConfiguration) content.GetValueForProperty("RecoveryPointDiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointDiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties) content.GetValueForProperty("RecoveryPointProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointType = (string) content.GetValueForProperty("RecoveryPointType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("RecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecoveryPointAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointAdditionalInfo = (string) content.GetValueForProperty("RecoveryPointAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointAdditionalInfo, global::System.Convert.ToString);
            }
            if (content.Contains("SourceVMStorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SourceVMStorageType = (string) content.GetValueForProperty("SourceVMStorageType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SourceVMStorageType, global::System.Convert.ToString);
            }
            if (content.Contains("IsSourceVMEncrypted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsSourceVMEncrypted = (bool?) content.GetValueForProperty("IsSourceVMEncrypted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsSourceVMEncrypted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsInstantIlrSessionActive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsInstantIlrSessionActive = (bool?) content.GetValueForProperty("IsInstantIlrSessionActive",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsInstantIlrSessionActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RecoveryPointTierDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTierDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>) content.GetValueForProperty("RecoveryPointTierDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTierDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointTierInformationV2TypeConverter.ConvertFrom));
            }
            if (content.Contains("IsManagedVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsManagedVirtualMachine = (bool?) content.GetValueForProperty("IsManagedVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsManagedVirtualMachine, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualMachineSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).VirtualMachineSize = (string) content.GetValueForProperty("VirtualMachineSize",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).VirtualMachineSize, global::System.Convert.ToString);
            }
            if (content.Contains("OriginalStorageAccountOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OriginalStorageAccountOption = (bool?) content.GetValueForProperty("OriginalStorageAccountOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OriginalStorageAccountOption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RecoveryPointMoveReadinessInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointMoveReadinessInfo) content.GetValueForProperty("RecoveryPointMoveReadinessInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRecoveryPointMoveReadinessInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SecurityType = (string) content.GetValueForProperty("SecurityType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SecurityType, global::System.Convert.ToString);
            }
            if (content.Contains("IsPrivateAccessEnabledOnAnyDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsPrivateAccessEnabledOnAnyDisk = (bool?) content.GetValueForProperty("IsPrivateAccessEnabledOnAnyDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsPrivateAccessEnabledOnAnyDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("KeyAndSecretKekDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretKekDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKekDetails) content.GetValueForProperty("KeyAndSecretKekDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretKekDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.KekDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyAndSecretBekDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretBekDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBekDetails) content.GetValueForProperty("KeyAndSecretBekDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretBekDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BekDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyAndSecretEncryptionMechanism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretEncryptionMechanism = (string) content.GetValueForProperty("KeyAndSecretEncryptionMechanism",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretEncryptionMechanism, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup = (int?) content.GetValueForProperty("RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM = (int?) content.GetValueForProperty("RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointDiskConfigurationIncludedDiskList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationIncludedDiskList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>) content.GetValueForProperty("RecoveryPointDiskConfigurationIncludedDiskList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationIncludedDiskList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DiskInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryPointDiskConfigurationExcludedDiskList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationExcludedDiskList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>) content.GetValueForProperty("RecoveryPointDiskConfigurationExcludedDiskList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationExcludedDiskList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DiskInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryPointPropertyExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime = (string) content.GetValueForProperty("RecoveryPointPropertyExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyRuleName = (string) content.GetValueForProperty("RecoveryPointPropertyRuleName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyIsSoftDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted = (bool?) content.GetValueForProperty("RecoveryPointPropertyIsSoftDeleted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("KekDetailKeyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyUrl = (string) content.GetValueForProperty("KekDetailKeyUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KekDetailKeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyVaultId = (string) content.GetValueForProperty("KekDetailKeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("KekDetailKeyBackupData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyBackupData = (string) content.GetValueForProperty("KekDetailKeyBackupData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyBackupData, global::System.Convert.ToString);
            }
            if (content.Contains("BekDetailSecretUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretUrl = (string) content.GetValueForProperty("BekDetailSecretUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretUrl, global::System.Convert.ToString);
            }
            if (content.Contains("BekDetailSecretVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretVaultId = (string) content.GetValueForProperty("BekDetailSecretVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("BekDetailSecretData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretData = (string) content.GetValueForProperty("BekDetailSecretData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretData, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRecoveryPoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IaasVMRecoveryPoint(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("KeyAndSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecret = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKeyAndSecretDetails) content.GetValueForProperty("KeyAndSecret",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecret, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.KeyAndSecretDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointDiskConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointDiskConfiguration) content.GetValueForProperty("RecoveryPointDiskConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfiguration, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointDiskConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointProperties) content.GetValueForProperty("RecoveryPointProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryPointType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointType = (string) content.GetValueForProperty("RecoveryPointType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTime = (global::System.DateTime?) content.GetValueForProperty("RecoveryPointTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("RecoveryPointAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointAdditionalInfo = (string) content.GetValueForProperty("RecoveryPointAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointAdditionalInfo, global::System.Convert.ToString);
            }
            if (content.Contains("SourceVMStorageType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SourceVMStorageType = (string) content.GetValueForProperty("SourceVMStorageType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SourceVMStorageType, global::System.Convert.ToString);
            }
            if (content.Contains("IsSourceVMEncrypted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsSourceVMEncrypted = (bool?) content.GetValueForProperty("IsSourceVMEncrypted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsSourceVMEncrypted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsInstantIlrSessionActive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsInstantIlrSessionActive = (bool?) content.GetValueForProperty("IsInstantIlrSessionActive",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsInstantIlrSessionActive, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("RecoveryPointTierDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTierDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>) content.GetValueForProperty("RecoveryPointTierDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointTierDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointTierInformationV2>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.RecoveryPointTierInformationV2TypeConverter.ConvertFrom));
            }
            if (content.Contains("IsManagedVirtualMachine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsManagedVirtualMachine = (bool?) content.GetValueForProperty("IsManagedVirtualMachine",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsManagedVirtualMachine, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualMachineSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).VirtualMachineSize = (string) content.GetValueForProperty("VirtualMachineSize",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).VirtualMachineSize, global::System.Convert.ToString);
            }
            if (content.Contains("OriginalStorageAccountOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OriginalStorageAccountOption = (bool?) content.GetValueForProperty("OriginalStorageAccountOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OriginalStorageAccountOption, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("RecoveryPointMoveReadinessInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointMoveReadinessInfo) content.GetValueForProperty("RecoveryPointMoveReadinessInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointMoveReadinessInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IaasVMRecoveryPointMoveReadinessInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("SecurityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SecurityType = (string) content.GetValueForProperty("SecurityType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).SecurityType, global::System.Convert.ToString);
            }
            if (content.Contains("IsPrivateAccessEnabledOnAnyDisk"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsPrivateAccessEnabledOnAnyDisk = (bool?) content.GetValueForProperty("IsPrivateAccessEnabledOnAnyDisk",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).IsPrivateAccessEnabledOnAnyDisk, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRecoveryPointInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("KeyAndSecretKekDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretKekDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IKekDetails) content.GetValueForProperty("KeyAndSecretKekDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretKekDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.KekDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyAndSecretBekDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretBekDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IBekDetails) content.GetValueForProperty("KeyAndSecretBekDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretBekDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.BekDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("KeyAndSecretEncryptionMechanism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretEncryptionMechanism = (string) content.GetValueForProperty("KeyAndSecretEncryptionMechanism",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KeyAndSecretEncryptionMechanism, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup = (int?) content.GetValueForProperty("RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksIncludedInBackup, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM = (int?) content.GetValueForProperty("RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationNumberOfDisksAttachedToVM, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RecoveryPointDiskConfigurationIncludedDiskList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationIncludedDiskList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>) content.GetValueForProperty("RecoveryPointDiskConfigurationIncludedDiskList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationIncludedDiskList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DiskInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryPointDiskConfigurationExcludedDiskList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationExcludedDiskList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>) content.GetValueForProperty("RecoveryPointDiskConfigurationExcludedDiskList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointDiskConfigurationExcludedDiskList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IDiskInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.DiskInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("RecoveryPointPropertyExpiryTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime = (string) content.GetValueForProperty("RecoveryPointPropertyExpiryTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyExpiryTime, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyRuleName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyRuleName = (string) content.GetValueForProperty("RecoveryPointPropertyRuleName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyRuleName, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryPointPropertyIsSoftDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted = (bool?) content.GetValueForProperty("RecoveryPointPropertyIsSoftDeleted",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).RecoveryPointPropertyIsSoftDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("KekDetailKeyUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyUrl = (string) content.GetValueForProperty("KekDetailKeyUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyUrl, global::System.Convert.ToString);
            }
            if (content.Contains("KekDetailKeyVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyVaultId = (string) content.GetValueForProperty("KekDetailKeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("KekDetailKeyBackupData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyBackupData = (string) content.GetValueForProperty("KekDetailKeyBackupData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).KekDetailKeyBackupData, global::System.Convert.ToString);
            }
            if (content.Contains("BekDetailSecretUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretUrl = (string) content.GetValueForProperty("BekDetailSecretUrl",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretUrl, global::System.Convert.ToString);
            }
            if (content.Contains("BekDetailSecretVaultId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretVaultId = (string) content.GetValueForProperty("BekDetailSecretVaultId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretVaultId, global::System.Convert.ToString);
            }
            if (content.Contains("BekDetailSecretData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretData = (string) content.GetValueForProperty("BekDetailSecretData",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IIaasVMRecoveryPointInternal)this).BekDetailSecretData, global::System.Convert.ToString);
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
    /// IaaS VM workload specific backup copy.
    [System.ComponentModel.TypeConverter(typeof(IaasVMRecoveryPointTypeConverter))]
    public partial interface IIaasVMRecoveryPoint

    {

    }
}