// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.PowerShell;

    /// <summary>Serverless Runtime environment Metadata response.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServerlessMetadataResponseTypeConverter))]
    public partial class ServerlessMetadataResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessMetadataResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerlessMetadataResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessMetadataResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerlessMetadataResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerlessMetadataResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ServerlessMetadataResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessMetadataResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerlessMetadataResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ServerlessConfigProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties) content.GetValueForProperty("ServerlessConfigProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerlessRuntimeConfigProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties) content.GetValueForProperty("ServerlessRuntimeConfigProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyApplicationType = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata>) content.GetValueForProperty("ServerlessConfigPropertyApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyApplicationType, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ApplicationTypeMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessConfigPropertyComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyComputeUnit = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata>) content.GetValueForProperty("ServerlessConfigPropertyComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyComputeUnit, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ComputeUnitsMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessConfigPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyRegion = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata>) content.GetValueForProperty("ServerlessConfigPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyRegion, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.RegionsMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessConfigPropertyPlatform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyPlatform = (string) content.GetValueForProperty("ServerlessConfigPropertyPlatform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyPlatform, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyExecutionTimeout = (string) content.GetValueForProperty("ServerlessConfigPropertyExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeConfigPropertyCdiConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdiConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigPropertyCdiConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdiConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeConfigPropertyCdieConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdieConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigPropertyCdieConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdieConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessMetadataResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerlessMetadataResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ServerlessConfigProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessConfigProperties) content.GetValueForProperty("ServerlessConfigProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ServerlessRuntimeConfigProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigProperty = (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeConfigProperties) content.GetValueForProperty("ServerlessRuntimeConfigProperty",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigProperty, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyApplicationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyApplicationType = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata>) content.GetValueForProperty("ServerlessConfigPropertyApplicationType",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyApplicationType, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IApplicationTypeMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ApplicationTypeMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessConfigPropertyComputeUnit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyComputeUnit = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata>) content.GetValueForProperty("ServerlessConfigPropertyComputeUnit",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyComputeUnit, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IComputeUnitsMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ComputeUnitsMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessConfigPropertyRegion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyRegion = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata>) content.GetValueForProperty("ServerlessConfigPropertyRegion",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyRegion, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IRegionsMetadata>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.RegionsMetadataTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessConfigPropertyPlatform"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyPlatform = (string) content.GetValueForProperty("ServerlessConfigPropertyPlatform",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyPlatform, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessConfigPropertyExecutionTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyExecutionTimeout = (string) content.GetValueForProperty("ServerlessConfigPropertyExecutionTimeout",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessConfigPropertyExecutionTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("ServerlessRuntimeConfigPropertyCdiConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdiConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigPropertyCdiConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdiConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServerlessRuntimeConfigPropertyCdieConfigProp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdieConfigProp = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>) content.GetValueForProperty("ServerlessRuntimeConfigPropertyCdieConfigProp",((Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessMetadataResponseInternal)this).ServerlessRuntimeConfigPropertyCdieConfigProp, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICdiConfigProps>(__y, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.CdiConfigPropsTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Serverless Runtime environment Metadata response.
    [System.ComponentModel.TypeConverter(typeof(ServerlessMetadataResponseTypeConverter))]
    public partial interface IServerlessMetadataResponse

    {

    }
}