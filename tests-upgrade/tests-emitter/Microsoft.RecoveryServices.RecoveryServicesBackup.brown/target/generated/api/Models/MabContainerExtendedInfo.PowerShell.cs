// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Additional information of the container.</summary>
    [System.ComponentModel.TypeConverter(typeof(MabContainerExtendedInfoTypeConverter))]
    public partial class MabContainerExtendedInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MabContainerExtendedInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MabContainerExtendedInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MabContainerExtendedInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MabContainerExtendedInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MabContainerExtendedInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("LastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BackupItemType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItemType = (string) content.GetValueForProperty("BackupItemType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItemType, global::System.Convert.ToString);
            }
            if (content.Contains("BackupItem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItem = (System.Collections.Generic.List<string>) content.GetValueForProperty("BackupItem",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItem, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabContainerExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MabContainerExtendedInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LastRefreshedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastRefreshedAt = (global::System.DateTime?) content.GetValueForProperty("LastRefreshedAt",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastRefreshedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("BackupItemType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItemType = (string) content.GetValueForProperty("BackupItemType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItemType, global::System.Convert.ToString);
            }
            if (content.Contains("BackupItem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItem = (System.Collections.Generic.List<string>) content.GetValueForProperty("BackupItem",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).BackupItem, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("PolicyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).PolicyName = (string) content.GetValueForProperty("PolicyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).PolicyName, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabContainerExtendedInfoInternal)this).LastBackupStatus, global::System.Convert.ToString);
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
    /// Additional information of the container.
    [System.ComponentModel.TypeConverter(typeof(MabContainerExtendedInfoTypeConverter))]
    public partial interface IMabContainerExtendedInfo

    {

    }
}