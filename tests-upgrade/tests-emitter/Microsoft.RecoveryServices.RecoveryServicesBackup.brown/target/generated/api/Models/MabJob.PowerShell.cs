// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>MAB workload-specific job.</summary>
    [System.ComponentModel.TypeConverter(typeof(MabJobTypeConverter))]
    public partial class MabJob
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJob" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJob DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MabJob(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJob" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJob DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MabJob(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MabJob" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MabJob" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJob FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MabJob(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Duration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).Duration = (global::System.TimeSpan?) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).Duration, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("ActionsInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ActionsInfo = (System.Collections.Generic.List<string>) content.GetValueForProperty("ActionsInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ActionsInfo, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MabServerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerName = (string) content.GetValueForProperty("MabServerName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerName, global::System.Convert.ToString);
            }
            if (content.Contains("MabServerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerType = (string) content.GetValueForProperty("MabServerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerType, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).WorkloadType = (string) content.GetValueForProperty("WorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).WorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabErrorInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("EntityFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EntityFriendlyName = (string) content.GetValueForProperty("EntityFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EntityFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("Operation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Operation, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ActivityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).ActivityId = (string) content.GetValueForProperty("ActivityId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).ActivityId, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoTasksList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoTasksList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails>) content.GetValueForProperty("ExtendedInfoTasksList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoTasksList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobTaskDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExtendedInfoPropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoPropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag) content.GetValueForProperty("ExtendedInfoPropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoPropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobExtendedInfoPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedInfoDynamicErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoDynamicErrorMessage = (string) content.GetValueForProperty("ExtendedInfoDynamicErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoDynamicErrorMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MabJob(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfo = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfo) content.GetValueForProperty("ExtendedInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfo, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobExtendedInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Duration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).Duration = (global::System.TimeSpan?) content.GetValueForProperty("Duration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).Duration, (v) => v is global::System.TimeSpan _v ? _v : global::System.Xml.XmlConvert.ToTimeSpan( v.ToString() ));
            }
            if (content.Contains("ActionsInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ActionsInfo = (System.Collections.Generic.List<string>) content.GetValueForProperty("ActionsInfo",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ActionsInfo, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("MabServerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerName = (string) content.GetValueForProperty("MabServerName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerName, global::System.Convert.ToString);
            }
            if (content.Contains("MabServerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerType = (string) content.GetValueForProperty("MabServerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).MabServerType, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).WorkloadType = (string) content.GetValueForProperty("WorkloadType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).WorkloadType, global::System.Convert.ToString);
            }
            if (content.Contains("ErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo>) content.GetValueForProperty("ErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabErrorInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabErrorInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("EntityFriendlyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EntityFriendlyName = (string) content.GetValueForProperty("EntityFriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EntityFriendlyName, global::System.Convert.ToString);
            }
            if (content.Contains("BackupManagementType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).BackupManagementType = (string) content.GetValueForProperty("BackupManagementType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).BackupManagementType, global::System.Convert.ToString);
            }
            if (content.Contains("Operation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Operation, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ActivityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).ActivityId = (string) content.GetValueForProperty("ActivityId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).ActivityId, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IJobInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedInfoTasksList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoTasksList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails>) content.GetValueForProperty("ExtendedInfoTasksList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoTasksList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobTaskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobTaskDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExtendedInfoPropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoPropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobExtendedInfoPropertyBag) content.GetValueForProperty("ExtendedInfoPropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoPropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.MabJobExtendedInfoPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedInfoDynamicErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoDynamicErrorMessage = (string) content.GetValueForProperty("ExtendedInfoDynamicErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IMabJobInternal)this).ExtendedInfoDynamicErrorMessage, global::System.Convert.ToString);
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
    /// MAB workload-specific job.
    [System.ComponentModel.TypeConverter(typeof(MabJobTypeConverter))]
    public partial interface IMabJob

    {

    }
}