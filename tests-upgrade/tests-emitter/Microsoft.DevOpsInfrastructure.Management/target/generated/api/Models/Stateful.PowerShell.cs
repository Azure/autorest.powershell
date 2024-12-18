// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.PowerShell;

    /// <summary>
    /// Stateful profile meaning that the machines will be returned to the pool after running a job.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(StatefulTypeConverter))]
    public partial class Stateful
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Stateful"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStateful" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStateful DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Stateful(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Stateful"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStateful" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStateful DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Stateful(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Stateful" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Stateful" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStateful FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Stateful"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Stateful(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("MaxAgentLifetime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).MaxAgentLifetime = (string) content.GetValueForProperty("MaxAgentLifetime",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).MaxAgentLifetime, global::System.Convert.ToString);
            }
            if (content.Contains("GracePeriodTimeSpan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).GracePeriodTimeSpan = (string) content.GetValueForProperty("GracePeriodTimeSpan",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).GracePeriodTimeSpan, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionProfileKind = (string) content.GetValueForProperty("ResourcePredictionProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionsProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionsProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile) content.GetValueForProperty("ResourcePredictionsProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionsProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourcePrediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePrediction = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) content.GetValueForProperty("ResourcePrediction",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePrediction, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.Stateful"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Stateful(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Kind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).Kind, global::System.Convert.ToString);
            }
            if (content.Contains("MaxAgentLifetime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).MaxAgentLifetime = (string) content.GetValueForProperty("MaxAgentLifetime",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).MaxAgentLifetime, global::System.Convert.ToString);
            }
            if (content.Contains("GracePeriodTimeSpan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).GracePeriodTimeSpan = (string) content.GetValueForProperty("GracePeriodTimeSpan",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IStatefulInternal)this).GracePeriodTimeSpan, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionProfileKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionProfileKind = (string) content.GetValueForProperty("ResourcePredictionProfileKind",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionProfileKind, global::System.Convert.ToString);
            }
            if (content.Contains("ResourcePredictionsProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionsProfile = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile) content.GetValueForProperty("ResourcePredictionsProfile",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePredictionsProfile, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourcePrediction"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePrediction = (Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictions) content.GetValueForProperty("ResourcePrediction",((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAgentProfileInternal)this).ResourcePrediction, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Stateful profile meaning that the machines will be returned to the pool after running a job.
    [System.ComponentModel.TypeConverter(typeof(StatefulTypeConverter))]
    public partial interface IStateful

    {

    }
}