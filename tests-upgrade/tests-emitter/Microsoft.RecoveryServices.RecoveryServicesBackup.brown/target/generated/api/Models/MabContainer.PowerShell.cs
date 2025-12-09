// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Container with items backed up using MAB backup engine.</summary>
    [System.ComponentModel.TypeConverter(typeof(MabContainerTypeConverter))]
    public partial class MabContainer
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainer" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainer DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MabContainer(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainer" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainer DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MabContainer(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MabContainer" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MabContainer" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainer FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MabContainer(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("CanReRegister"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).CanReRegister = (bool?) content.GetValueForProperty("CanReRegister",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).CanReRegister, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerId = (long?) content.GetValueForProperty("ContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ProtectedItemCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ProtectedItemCount = (long?) content.GetValueForProperty("ProtectedItemCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ProtectedItemCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).AgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("HealthDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).HealthDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerHealthDetails>) content.GetValueForProperty("HealthDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).HealthDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerHealthDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerHealthDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ContainerHealthState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerHealthState = (string) content.GetValueForProperty("ContainerHealthState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerHealthState, global::System.Convert.ToString);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus = (string) content.GetValueForProperty("RegistrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("HealthStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType = (string) content.GetValueForProperty("ContainerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectableObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType = (string) content.GetValueForProperty("ProtectableObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoLastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoLastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoBackupItemType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItemType = (string) content.GetValueForProperty("ExtendedInfoBackupItemType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItemType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoBackupItem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItem = (System.Collections.Generic.List<string>) content.GetValueForProperty("ExtendedInfoBackupItem",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItem, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtendedInfoPolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoPolicyName = (string) content.GetValueForProperty("ExtendedInfoPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoPolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoLastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastBackupStatus = (string) content.GetValueForProperty("ExtendedInfoLastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastBackupStatus, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainer"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MabContainer(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ExtendedInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("CanReRegister"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).CanReRegister = (bool?) content.GetValueForProperty("CanReRegister",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).CanReRegister, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ContainerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerId = (long?) content.GetValueForProperty("ContainerId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ProtectedItemCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ProtectedItemCount = (long?) content.GetValueForProperty("ProtectedItemCount",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ProtectedItemCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("AgentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).AgentVersion = (string) content.GetValueForProperty("AgentVersion",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).AgentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("HealthDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).HealthDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerHealthDetails>) content.GetValueForProperty("HealthDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).HealthDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerHealthDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerHealthDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ContainerHealthState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerHealthState = (string) content.GetValueForProperty("ContainerHealthState",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ContainerHealthState, global::System.Convert.ToString);
            }
            if (content.Contains("FriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).FriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("RegistrationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus = (string) content.GetValueForProperty("RegistrationStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).RegistrationStatus, global::System.Convert.ToString);
            }
            if (content.Contains("HealthStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus = (string) content.GetValueForProperty("HealthStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).HealthStatus, global::System.Convert.ToString);
            }
            if (content.Contains("ContainerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType = (string) content.GetValueForProperty("ContainerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ContainerType, global::System.Convert.ToString);
            }
            if (content.Contains("ProtectableObjectType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType = (string) content.GetValueForProperty("ProtectableObjectType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IProtectionContainerInternal)this).ProtectableObjectType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoLastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("ExtendedInfoLastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExtendedInfoBackupItemType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItemType = (string) content.GetValueForProperty("ExtendedInfoBackupItemType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItemType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoBackupItem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItem = (System.Collections.Generic.List<string>) content.GetValueForProperty("ExtendedInfoBackupItem",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoBackupItem, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ExtendedInfoPolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoPolicyName = (string) content.GetValueForProperty("ExtendedInfoPolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoPolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoLastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastBackupStatus = (string) content.GetValueForProperty("ExtendedInfoLastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerInternal)this).ExtendedInfoLastBackupStatus, global::System.Convert.ToString);
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
    /// Container with items backed up using MAB backup engine.
    [System.ComponentModel.TypeConverter(typeof(MabContainerTypeConverter))]
    public partial interface IMabContainer

    {

    }
}