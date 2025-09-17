// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.PowerShell;

    /// <summary>The current billing term of the SaaS Subscription.</summary>
    [System.ComponentModel.TypeConverter(typeof(SubscriptionTermTypeConverter))]
    public partial class SubscriptionTerm
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTerm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SubscriptionTerm(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTerm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SubscriptionTerm(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SubscriptionTerm" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SubscriptionTerm" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTerm FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTerm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SubscriptionTerm(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).TermUnit = (string) content.GetValueForProperty("TermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).TermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("StartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).StartDate = (global::System.DateTime?) content.GetValueForProperty("StartDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).StartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).EndDate = (global::System.DateTime?) content.GetValueForProperty("EndDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).EndDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.SubscriptionTerm"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SubscriptionTerm(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TermUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).TermUnit = (string) content.GetValueForProperty("TermUnit",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).TermUnit, global::System.Convert.ToString);
            }
            if (content.Contains("StartDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).StartDate = (global::System.DateTime?) content.GetValueForProperty("StartDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).StartDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).EndDate = (global::System.DateTime?) content.GetValueForProperty("EndDate",((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISubscriptionTermInternal)this).EndDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The current billing term of the SaaS Subscription.
    [System.ComponentModel.TypeConverter(typeof(SubscriptionTermTypeConverter))]
    public partial interface ISubscriptionTerm

    {

    }
}