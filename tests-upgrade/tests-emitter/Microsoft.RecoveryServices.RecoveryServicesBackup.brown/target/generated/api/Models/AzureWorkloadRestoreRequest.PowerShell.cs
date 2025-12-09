// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>AzureWorkload-specific restore.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureWorkloadRestoreRequestTypeConverter))]
    public partial class AzureWorkloadRestoreRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureWorkloadRestoreRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TargetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo) content.GetValueForProperty("TargetInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetRestoreInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserAssignedManagedIdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails) content.GetValueForProperty("UserAssignedManagedIdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotRestoreParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameter = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters) content.GetValueForProperty("SnapshotRestoreParameter",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameter, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotRestoreParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).PropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag) content.GetValueForProperty("PropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).PropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequestPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryMode = (string) content.GetValueForProperty("RecoveryMode",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryMode, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetResourceGroupName = (string) content.GetValueForProperty("TargetResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetVirtualMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetVirtualMachineId = (string) content.GetValueForProperty("TargetVirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetVirtualMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TargetInfoOverwriteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoOverwriteOption = (string) content.GetValueForProperty("TargetInfoOverwriteOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoOverwriteOption, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInfoContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoContainerId = (string) content.GetValueForProperty("TargetInfoContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInfoDatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoDatabaseName = (string) content.GetValueForProperty("TargetInfoDatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoDatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInfoTargetDirectoryForFileRestore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoTargetDirectoryForFileRestore = (string) content.GetValueForProperty("TargetInfoTargetDirectoryForFileRestore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoTargetDirectoryForFileRestore, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties) content.GetValueForProperty("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedIdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityArmId = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityArmId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityName = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityName, global::System.Convert.ToString);
            }
            if (content.Contains("SnapshotRestoreParameterSkipAttachAndMount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterSkipAttachAndMount = (bool?) content.GetValueForProperty("SnapshotRestoreParameterSkipAttachAndMount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterSkipAttachAndMount, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotRestoreParameterLogPointInTimeForDbRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterLogPointInTimeForDbRecovery = (string) content.GetValueForProperty("SnapshotRestoreParameterLogPointInTimeForDbRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterLogPointInTimeForDbRecovery, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyClientId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyClientId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyClientId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyPrincipalId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyPrincipalId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureWorkloadRestoreRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TargetInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ITargetRestoreInfo) content.GetValueForProperty("TargetInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.TargetRestoreInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserAssignedManagedIdentityDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetail = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedManagedIdentityDetails) content.GetValueForProperty("UserAssignedManagedIdentityDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetail, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedManagedIdentityDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("SnapshotRestoreParameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameter = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISnapshotRestoreParameters) content.GetValueForProperty("SnapshotRestoreParameter",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameter, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.SnapshotRestoreParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryType = (string) content.GetValueForProperty("RecoveryType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryType, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).PropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestPropertyBag) content.GetValueForProperty("PropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).PropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequestPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryMode = (string) content.GetValueForProperty("RecoveryMode",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).RecoveryMode, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetResourceGroupName = (string) content.GetValueForProperty("TargetResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetVirtualMachineId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetVirtualMachineId = (string) content.GetValueForProperty("TargetVirtualMachineId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetVirtualMachineId, global::System.Convert.ToString);
            }
            if (content.Contains("ObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType = (string) content.GetValueForProperty("ObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGuardOperationRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGuardOperationRequest",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IRestoreRequestInternal)this).ResourceGuardOperationRequest, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TargetInfoOverwriteOption"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoOverwriteOption = (string) content.GetValueForProperty("TargetInfoOverwriteOption",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoOverwriteOption, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInfoContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoContainerId = (string) content.GetValueForProperty("TargetInfoContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoContainerId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInfoDatabaseName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoDatabaseName = (string) content.GetValueForProperty("TargetInfoDatabaseName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoDatabaseName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInfoTargetDirectoryForFileRestore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoTargetDirectoryForFileRestore = (string) content.GetValueForProperty("TargetInfoTargetDirectoryForFileRestore",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).TargetInfoTargetDirectoryForFileRestore, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IUserAssignedIdentityProperties) content.GetValueForProperty("UserAssignedManagedIdentityDetailUserAssignedIdentityProperty",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailUserAssignedIdentityProperty, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.UserAssignedIdentityPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityArmId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityArmId = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityArmId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityArmId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedManagedIdentityDetailIdentityName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityName = (string) content.GetValueForProperty("UserAssignedManagedIdentityDetailIdentityName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedManagedIdentityDetailIdentityName, global::System.Convert.ToString);
            }
            if (content.Contains("SnapshotRestoreParameterSkipAttachAndMount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterSkipAttachAndMount = (bool?) content.GetValueForProperty("SnapshotRestoreParameterSkipAttachAndMount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterSkipAttachAndMount, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SnapshotRestoreParameterLogPointInTimeForDbRecovery"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterLogPointInTimeForDbRecovery = (string) content.GetValueForProperty("SnapshotRestoreParameterLogPointInTimeForDbRecovery",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).SnapshotRestoreParameterLogPointInTimeForDbRecovery, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyClientId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyClientId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyClientId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyClientId, global::System.Convert.ToString);
            }
            if (content.Contains("UserAssignedIdentityPropertyPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyPrincipalId = (string) content.GetValueForProperty("UserAssignedIdentityPropertyPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequestInternal)this).UserAssignedIdentityPropertyPrincipalId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureWorkloadRestoreRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureWorkloadRestoreRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureWorkloadRestoreRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureWorkloadRestoreRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureWorkloadRestoreRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureWorkloadRestoreRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// AzureWorkload-specific restore.
    [System.ComponentModel.TypeConverter(typeof(AzureWorkloadRestoreRequestTypeConverter))]
    public partial interface IAzureWorkloadRestoreRequest

    {

    }
}