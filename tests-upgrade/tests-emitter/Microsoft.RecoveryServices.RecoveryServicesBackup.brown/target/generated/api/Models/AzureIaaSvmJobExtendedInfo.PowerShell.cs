// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.PowerShell;

    /// <summary>Azure IaaS VM workload-specific additional information for job.</summary>
    [System.ComponentModel.TypeConverter(typeof(AzureIaaSvmJobExtendedInfoTypeConverter))]
    public partial class AzureIaaSvmJobExtendedInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureIaaSvmJobExtendedInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TasksList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).TasksList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobTaskDetails>) content.GetValueForProperty("TasksList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).TasksList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobTaskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobTaskDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).PropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoPropertyBag) content.GetValueForProperty("PropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).PropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfoPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("InternalPropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).InternalPropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternalPropertyBag) content.GetValueForProperty("InternalPropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).InternalPropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfoInternalPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).ProgressPercentage = (double?) content.GetValueForProperty("ProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).ProgressPercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("EstimatedRemainingDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).EstimatedRemainingDuration = (string) content.GetValueForProperty("EstimatedRemainingDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).EstimatedRemainingDuration, global::System.Convert.ToString);
            }
            if (content.Contains("DynamicErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).DynamicErrorMessage = (string) content.GetValueForProperty("DynamicErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).DynamicErrorMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureIaaSvmJobExtendedInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TasksList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).TasksList = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobTaskDetails>) content.GetValueForProperty("TasksList",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).TasksList, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobTaskDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobTaskDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("PropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).PropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoPropertyBag) content.GetValueForProperty("PropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).PropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfoPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("InternalPropertyBag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).InternalPropertyBag = (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternalPropertyBag) content.GetValueForProperty("InternalPropertyBag",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).InternalPropertyBag, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfoInternalPropertyBagTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProgressPercentage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).ProgressPercentage = (double?) content.GetValueForProperty("ProgressPercentage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).ProgressPercentage, (__y)=> (double) global::System.Convert.ChangeType(__y, typeof(double)));
            }
            if (content.Contains("EstimatedRemainingDuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).EstimatedRemainingDuration = (string) content.GetValueForProperty("EstimatedRemainingDuration",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).EstimatedRemainingDuration, global::System.Convert.ToString);
            }
            if (content.Contains("DynamicErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).DynamicErrorMessage = (string) content.GetValueForProperty("DynamicErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfoInternal)this).DynamicErrorMessage, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureIaaSvmJobExtendedInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.AzureIaaSvmJobExtendedInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfo"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureIaaSvmJobExtendedInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureIaaSvmJobExtendedInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureIaaSvmJobExtendedInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureIaaSvmJobExtendedInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Azure IaaS VM workload-specific additional information for job.
    [System.ComponentModel.TypeConverter(typeof(AzureIaaSvmJobExtendedInfoTypeConverter))]
    public partial interface IAzureIaaSvmJobExtendedInfo

    {

    }
}