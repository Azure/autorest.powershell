// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>The recommended configuration for a three tier SAP system.</summary>
    [System.ComponentModel.TypeConverter(typeof(ThreeTierRecommendationResultTypeConverter))]
    public partial class ThreeTierRecommendationResult
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierRecommendationResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ThreeTierRecommendationResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierRecommendationResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResult"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResult DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ThreeTierRecommendationResult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ThreeTierRecommendationResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ThreeTierRecommendationResult" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierRecommendationResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ThreeTierRecommendationResult(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DbVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DbVMSku = (string) content.GetValueForProperty("DbVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DbVMSku, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DatabaseInstanceCount = (long?) content.GetValueForProperty("DatabaseInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DatabaseInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CentralServerVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerVMSku = (string) content.GetValueForProperty("CentralServerVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerVMSku, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerInstanceCount = (long?) content.GetValueForProperty("CentralServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ApplicationServerVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerVMSku = (string) content.GetValueForProperty("ApplicationServerVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerVMSku, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerInstanceCount = (long?) content.GetValueForProperty("ApplicationServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ThreeTierRecommendationResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ThreeTierRecommendationResult(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DbVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DbVMSku = (string) content.GetValueForProperty("DbVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DbVMSku, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DatabaseInstanceCount = (long?) content.GetValueForProperty("DatabaseInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).DatabaseInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CentralServerVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerVMSku = (string) content.GetValueForProperty("CentralServerVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerVMSku, global::System.Convert.ToString);
            }
            if (content.Contains("CentralServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerInstanceCount = (long?) content.GetValueForProperty("CentralServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).CentralServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ApplicationServerVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerVMSku = (string) content.GetValueForProperty("ApplicationServerVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerVMSku, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationServerInstanceCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerInstanceCount = (long?) content.GetValueForProperty("ApplicationServerInstanceCount",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IThreeTierRecommendationResultInternal)this).ApplicationServerInstanceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The recommended configuration for a three tier SAP system.
    [System.ComponentModel.TypeConverter(typeof(ThreeTierRecommendationResultTypeConverter))]
    public partial interface IThreeTierRecommendationResult

    {

    }
}