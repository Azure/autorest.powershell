// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.PowerShell;

    /// <summary>The properties of the AutoUpgradeProfile.</summary>
    [System.ComponentModel.TypeConverter(typeof(AutoUpgradeProfilePropertiesTypeConverter))]
    public partial class AutoUpgradeProfileProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AutoUpgradeProfileProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NodeImageSelection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelection = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection) content.GetValueForProperty("NodeImageSelection",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelection, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("AutoUpgradeProfileStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus) content.GetValueForProperty("AutoUpgradeProfileStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStrategyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).UpdateStrategyId = (string) content.GetValueForProperty("UpdateStrategyId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).UpdateStrategyId, global::System.Convert.ToString);
            }
            if (content.Contains("Channel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Channel = (string) content.GetValueForProperty("Channel",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Channel, global::System.Convert.ToString);
            }
            if (content.Contains("Disabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Disabled = (bool?) content.GetValueForProperty("Disabled",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Disabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TargetKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).TargetKubernetesVersion = (string) content.GetValueForProperty("TargetKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).TargetKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LongTermSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LongTermSupport = (bool?) content.GetValueForProperty("LongTermSupport",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LongTermSupport, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NodeImageSelectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelectionType = (string) content.GetValueForProperty("NodeImageSelectionType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelectionType, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggerError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggeredAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggeredAt = (global::System.DateTime?) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggeredAt",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggeredAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggerStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerStatus = (string) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggerStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerStatus, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggerUpgradeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerUpgradeVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggerUpgradeVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerUpgradeVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LastTriggerErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorCode = (string) content.GetValueForProperty("LastTriggerErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("LastTriggerErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorMessage = (string) content.GetValueForProperty("LastTriggerErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastTriggerErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorTarget = (string) content.GetValueForProperty("LastTriggerErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LastTriggerErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("LastTriggerErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastTriggerErrorAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorAdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("LastTriggerErrorAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorAdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AutoUpgradeProfileProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NodeImageSelection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelection = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeNodeImageSelection) content.GetValueForProperty("NodeImageSelection",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelection, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeNodeImageSelectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("AutoUpgradeProfileStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatus = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileStatus) content.GetValueForProperty("AutoUpgradeProfileStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatus, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStrategyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).UpdateStrategyId = (string) content.GetValueForProperty("UpdateStrategyId",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).UpdateStrategyId, global::System.Convert.ToString);
            }
            if (content.Contains("Channel"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Channel = (string) content.GetValueForProperty("Channel",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Channel, global::System.Convert.ToString);
            }
            if (content.Contains("Disabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Disabled = (bool?) content.GetValueForProperty("Disabled",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).Disabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TargetKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).TargetKubernetesVersion = (string) content.GetValueForProperty("TargetKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).TargetKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("LongTermSupport"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LongTermSupport = (bool?) content.GetValueForProperty("LongTermSupport",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LongTermSupport, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("NodeImageSelectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelectionType = (string) content.GetValueForProperty("NodeImageSelectionType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).NodeImageSelectionType, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerError = (Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggerError",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerError, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggeredAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggeredAt = (global::System.DateTime?) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggeredAt",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggeredAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggerStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerStatus = (string) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggerStatus",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerStatus, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpgradeProfileStatusLastTriggerUpgradeVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerUpgradeVersion = (System.Collections.Generic.List<string>) content.GetValueForProperty("AutoUpgradeProfileStatusLastTriggerUpgradeVersion",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).AutoUpgradeProfileStatusLastTriggerUpgradeVersion, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LastTriggerErrorCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorCode = (string) content.GetValueForProperty("LastTriggerErrorCode",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorCode, global::System.Convert.ToString);
            }
            if (content.Contains("LastTriggerErrorMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorMessage = (string) content.GetValueForProperty("LastTriggerErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorMessage, global::System.Convert.ToString);
            }
            if (content.Contains("LastTriggerErrorTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorTarget = (string) content.GetValueForProperty("LastTriggerErrorTarget",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LastTriggerErrorDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorDetail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>) content.GetValueForProperty("LastTriggerErrorDetail",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorDetail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastTriggerErrorAdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorAdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("LastTriggerErrorAdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfilePropertiesInternal)this).LastTriggerErrorAdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AutoUpgradeProfileProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.AutoUpgradeProfileProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AutoUpgradeProfileProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AutoUpgradeProfileProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AutoUpgradeProfileProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IAutoUpgradeProfileProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// The properties of the AutoUpgradeProfile.
    [System.ComponentModel.TypeConverter(typeof(AutoUpgradeProfilePropertiesTypeConverter))]
    public partial interface IAutoUpgradeProfileProperties

    {

    }
}