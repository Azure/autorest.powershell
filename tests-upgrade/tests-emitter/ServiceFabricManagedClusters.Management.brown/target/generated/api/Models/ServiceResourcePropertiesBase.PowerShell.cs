// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>The common service resource properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServiceResourcePropertiesBaseTypeConverter))]
    public partial class ServiceResourcePropertiesBase
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServiceResourcePropertiesBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServiceResourcePropertiesBase(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServiceResourcePropertiesBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ServiceResourcePropertiesBase" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServiceResourcePropertiesBase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PlacementConstraint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).PlacementConstraint = (string) content.GetValueForProperty("PlacementConstraint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).PlacementConstraint, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).CorrelationScheme = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>) content.GetValueForProperty("CorrelationScheme",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).CorrelationScheme, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceCorrelationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceLoadMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServiceLoadMetric = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>) content.GetValueForProperty("ServiceLoadMetric",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServiceLoadMetric, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceLoadMetricTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServicePlacementPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServicePlacementPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>) content.GetValueForProperty("ServicePlacementPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServicePlacementPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServicePlacementPolicyTypeConverter.ConvertFrom));
            }
            if (content.Contains("DefaultMoveCost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).DefaultMoveCost = (string) content.GetValueForProperty("DefaultMoveCost",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).DefaultMoveCost, global::System.Convert.ToString);
            }
            if (content.Contains("ScalingPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ScalingPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>) content.GetValueForProperty("ScalingPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ScalingPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ScalingPolicyTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceResourcePropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServiceResourcePropertiesBase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("PlacementConstraint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).PlacementConstraint = (string) content.GetValueForProperty("PlacementConstraint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).PlacementConstraint, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationScheme"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).CorrelationScheme = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>) content.GetValueForProperty("CorrelationScheme",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).CorrelationScheme, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceCorrelation>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceCorrelationTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServiceLoadMetric"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServiceLoadMetric = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>) content.GetValueForProperty("ServiceLoadMetric",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServiceLoadMetric, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceLoadMetric>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServiceLoadMetricTypeConverter.ConvertFrom));
            }
            if (content.Contains("ServicePlacementPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServicePlacementPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>) content.GetValueForProperty("ServicePlacementPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ServicePlacementPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServicePlacementPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ServicePlacementPolicyTypeConverter.ConvertFrom));
            }
            if (content.Contains("DefaultMoveCost"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).DefaultMoveCost = (string) content.GetValueForProperty("DefaultMoveCost",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).DefaultMoveCost, global::System.Convert.ToString);
            }
            if (content.Contains("ScalingPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ScalingPolicy = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>) content.GetValueForProperty("ScalingPolicy",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IServiceResourcePropertiesBaseInternal)this).ScalingPolicy, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IScalingPolicy>(__y, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ScalingPolicyTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The common service resource properties.
    [System.ComponentModel.TypeConverter(typeof(ServiceResourcePropertiesBaseTypeConverter))]
    public partial interface IServiceResourcePropertiesBase

    {

    }
}