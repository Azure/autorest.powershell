// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.PowerShell;

    /// <summary>
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(StandbyVirtualMachinePoolRuntimeViewResourcePropertiesTypeConverter))]
    public partial class StandbyVirtualMachinePoolRuntimeViewResourceProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolRuntimeViewResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StandbyVirtualMachinePoolRuntimeViewResourceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolRuntimeViewResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StandbyVirtualMachinePoolRuntimeViewResourceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StandbyVirtualMachinePoolRuntimeViewResourceProperties" />, deserializing the content
        /// from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="StandbyVirtualMachinePoolRuntimeViewResourceProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolRuntimeViewResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StandbyVirtualMachinePoolRuntimeViewResourceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.PoolStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Prediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Prediction = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction) content.GetValueForProperty("Prediction",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Prediction, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolPredictionTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceCountSummary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).InstanceCountSummary = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary>) content.GetValueForProperty("InstanceCountSummary",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).InstanceCountSummary, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.VirtualMachineInstanceCountSummaryTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StatusCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusCode = (string) content.GetValueForProperty("StatusCode",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusCode, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PredictionForecastValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastValue = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues) content.GetValueForProperty("PredictionForecastValue",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastValue, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolForecastValuesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PredictionForecastStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastStartTime = (global::System.DateTime?) content.GetValueForProperty("PredictionForecastStartTime",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PredictionForecastInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastInfo = (string) content.GetValueForProperty("PredictionForecastInfo",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastInfo, global::System.Convert.ToString);
            }
            if (content.Contains("ForecastValueInstancesRequestedCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ForecastValueInstancesRequestedCount = (System.Collections.Generic.List<long>) content.GetValueForProperty("ForecastValueInstancesRequestedCount",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ForecastValueInstancesRequestedCount, __y => TypeConverterExtensions.SelectToList<long>(__y, (__w)=> (long) global::System.Convert.ChangeType(__w, typeof(long))));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolRuntimeViewResourceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StandbyVirtualMachinePoolRuntimeViewResourceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.PoolStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("Prediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Prediction = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolPrediction) content.GetValueForProperty("Prediction",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).Prediction, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolPredictionTypeConverter.ConvertFrom);
            }
            if (content.Contains("InstanceCountSummary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).InstanceCountSummary = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary>) content.GetValueForProperty("InstanceCountSummary",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).InstanceCountSummary, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IVirtualMachineInstanceCountSummary>(__y, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.VirtualMachineInstanceCountSummaryTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("StatusCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusCode = (string) content.GetValueForProperty("StatusCode",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusCode, global::System.Convert.ToString);
            }
            if (content.Contains("StatusMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusMessage = (string) content.GetValueForProperty("StatusMessage",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).StatusMessage, global::System.Convert.ToString);
            }
            if (content.Contains("PredictionForecastValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastValue = (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolForecastValues) content.GetValueForProperty("PredictionForecastValue",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastValue, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolForecastValuesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PredictionForecastStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastStartTime = (global::System.DateTime?) content.GetValueForProperty("PredictionForecastStartTime",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("PredictionForecastInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastInfo = (string) content.GetValueForProperty("PredictionForecastInfo",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).PredictionForecastInfo, global::System.Convert.ToString);
            }
            if (content.Contains("ForecastValueInstancesRequestedCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ForecastValueInstancesRequestedCount = (System.Collections.Generic.List<long>) content.GetValueForProperty("ForecastValueInstancesRequestedCount",((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolRuntimeViewResourcePropertiesInternal)this).ForecastValueInstancesRequestedCount, __y => TypeConverterExtensions.SelectToList<long>(__y, (__w)=> (long) global::System.Convert.ChangeType(__w, typeof(long))));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Contains information about a standby pool as last known by the StandbyPool resource provider.
    [System.ComponentModel.TypeConverter(typeof(StandbyVirtualMachinePoolRuntimeViewResourcePropertiesTypeConverter))]
    public partial interface IStandbyVirtualMachinePoolRuntimeViewResourceProperties

    {

    }
}