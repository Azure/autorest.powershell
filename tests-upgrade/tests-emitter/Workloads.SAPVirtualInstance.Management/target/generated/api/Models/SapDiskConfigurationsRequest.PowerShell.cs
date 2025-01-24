// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell;

    /// <summary>The SAP request to get list of disk configurations.</summary>
    [System.ComponentModel.TypeConverter(typeof(SapDiskConfigurationsRequestTypeConverter))]
    public partial class SapDiskConfigurationsRequest
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDiskConfigurationsRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequest DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SapDiskConfigurationsRequest(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDiskConfigurationsRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequest"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequest DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SapDiskConfigurationsRequest(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SapDiskConfigurationsRequest" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SapDiskConfigurationsRequest" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequest FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDiskConfigurationsRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SapDiskConfigurationsRequest(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AppLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).AppLocation = (string) content.GetValueForProperty("AppLocation",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).AppLocation, global::System.Convert.ToString);
            }
            if (content.Contains("Environment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("SapProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).SapProduct = (string) content.GetValueForProperty("SapProduct",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).SapProduct, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("DbVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DbVMSku = (string) content.GetValueForProperty("DbVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DbVMSku, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapDiskConfigurationsRequest"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SapDiskConfigurationsRequest(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AppLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).AppLocation = (string) content.GetValueForProperty("AppLocation",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).AppLocation, global::System.Convert.ToString);
            }
            if (content.Contains("Environment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).Environment = (string) content.GetValueForProperty("Environment",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).Environment, global::System.Convert.ToString);
            }
            if (content.Contains("SapProduct"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).SapProduct = (string) content.GetValueForProperty("SapProduct",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).SapProduct, global::System.Convert.ToString);
            }
            if (content.Contains("DatabaseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DatabaseType = (string) content.GetValueForProperty("DatabaseType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DatabaseType, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DeploymentType = (string) content.GetValueForProperty("DeploymentType",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DeploymentType, global::System.Convert.ToString);
            }
            if (content.Contains("DbVMSku"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DbVMSku = (string) content.GetValueForProperty("DbVMSku",((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsRequestInternal)this).DbVMSku, global::System.Convert.ToString);
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
    /// The SAP request to get list of disk configurations.
    [System.ComponentModel.TypeConverter(typeof(SapDiskConfigurationsRequestTypeConverter))]
    public partial interface ISapDiskConfigurationsRequest

    {

    }
}