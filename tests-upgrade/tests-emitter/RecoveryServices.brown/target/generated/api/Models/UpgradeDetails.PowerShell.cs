// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.PowerShell;

    /// <summary>Details for upgrading vault.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpgradeDetailsTypeConverter))]
    public partial class UpgradeDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpgradeDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpgradeDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpgradeDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UpgradeDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpgradeDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("StartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).StartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("StartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).StartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdatedTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).LastUpdatedTimeUtc = (global::System.DateTime?) content.GetValueForProperty("LastUpdatedTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).LastUpdatedTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).EndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("EndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).EndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("TriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).TriggerType = (string) content.GetValueForProperty("TriggerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).TriggerType, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).UpgradedResourceId = (string) content.GetValueForProperty("UpgradedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).UpgradedResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PreviousResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).PreviousResourceId = (string) content.GetValueForProperty("PreviousResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).PreviousResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpgradeDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("OperationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).OperationId = (string) content.GetValueForProperty("OperationId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).OperationId, global::System.Convert.ToString);
            }
            if (content.Contains("StartTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).StartTimeUtc = (global::System.DateTime?) content.GetValueForProperty("StartTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).StartTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastUpdatedTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).LastUpdatedTimeUtc = (global::System.DateTime?) content.GetValueForProperty("LastUpdatedTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).LastUpdatedTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTimeUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).EndTimeUtc = (global::System.DateTime?) content.GetValueForProperty("EndTimeUtc",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).EndTimeUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Status = (string) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("TriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).TriggerType = (string) content.GetValueForProperty("TriggerType",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).TriggerType, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradedResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).UpgradedResourceId = (string) content.GetValueForProperty("UpgradedResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).UpgradedResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("PreviousResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).PreviousResourceId = (string) content.GetValueForProperty("PreviousResourceId",((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IUpgradeDetailsInternal)this).PreviousResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Details for upgrading vault.
    [System.ComponentModel.TypeConverter(typeof(UpgradeDetailsTypeConverter))]
    public partial interface IUpgradeDetails

    {

    }
}