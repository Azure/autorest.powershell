// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.PowerShell;

    /// <summary>A Gate controls the progression during a staged rollout, e.g. in an Update Run.</summary>
    [System.ComponentModel.TypeConverter(typeof(GatePropertiesTypeConverter))]
    public partial class GateProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="GateProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).Target = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).Target, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateTargetTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("GateType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).GateType = (string) content.GetValueForProperty("GateType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).GateType, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("TargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetUpdateRunProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetUpdateRunProperty = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties) content.GetValueForProperty("TargetUpdateRunProperty",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetUpdateRunProperty, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateTargetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpdateRunPropertyTiming"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyTiming = (string) content.GetValueForProperty("UpdateRunPropertyTiming",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyTiming, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateRunPropertyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyName = (string) content.GetValueForProperty("UpdateRunPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyName, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateRunPropertyStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyStage = (string) content.GetValueForProperty("UpdateRunPropertyStage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyStage, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateRunPropertyGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyGroup = (string) content.GetValueForProperty("UpdateRunPropertyGroup",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyGroup, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).Target = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateTarget) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).Target, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.GateTargetTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("GateType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).GateType = (string) content.GetValueForProperty("GateType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).GateType, global::System.Convert.ToString);
            }
            if (content.Contains("State"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).State = (string) content.GetValueForProperty("State",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).State, global::System.Convert.ToString);
            }
            if (content.Contains("TargetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetId = (string) content.GetValueForProperty("TargetId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetUpdateRunProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetUpdateRunProperty = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IUpdateRunGateTargetProperties) content.GetValueForProperty("TargetUpdateRunProperty",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).TargetUpdateRunProperty, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.UpdateRunGateTargetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpdateRunPropertyTiming"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyTiming = (string) content.GetValueForProperty("UpdateRunPropertyTiming",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyTiming, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateRunPropertyName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyName = (string) content.GetValueForProperty("UpdateRunPropertyName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyName, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateRunPropertyStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyStage = (string) content.GetValueForProperty("UpdateRunPropertyStage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyStage, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateRunPropertyGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyGroup = (string) content.GetValueForProperty("UpdateRunPropertyGroup",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGatePropertiesInternal)this).UpdateRunPropertyGroup, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A Gate controls the progression during a staged rollout, e.g. in an Update Run.
    [System.ComponentModel.TypeConverter(typeof(GatePropertiesTypeConverter))]
    public partial interface IGateProperties

    {

    }
}