// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.PowerShell;

    /// <summary>Parameters for Zone Fault Simulation action.</summary>
    [System.ComponentModel.TypeConverter(typeof(ZoneFaultSimulationContentTypeConverter))]
    public partial class ZoneFaultSimulationContent
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ZoneFaultSimulationContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContent"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContent DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ZoneFaultSimulationContent(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ZoneFaultSimulationContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContent"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContent DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ZoneFaultSimulationContent(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ZoneFaultSimulationContent" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ZoneFaultSimulationContent" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContent FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ZoneFaultSimulationContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ZoneFaultSimulationContent(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContentInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContentInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ConstraintExpirationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).ConstraintExpirationTime = (global::System.DateTime?) content.GetValueForProperty("ConstraintExpirationTime",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).ConstraintExpirationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Constraint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Constraint = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints) content.GetValueForProperty("Constraint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Constraint, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationConstraintsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FaultKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).FaultKind = (string) content.GetValueForProperty("FaultKind",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).FaultKind, global::System.Convert.ToString);
            }
            if (content.Contains("Force"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Force = (bool?) content.GetValueForProperty("Force",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Force, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ZoneFaultSimulationContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ZoneFaultSimulationContent(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Zone"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContentInternal)this).Zone = (System.Collections.Generic.List<string>) content.GetValueForProperty("Zone",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IZoneFaultSimulationContentInternal)this).Zone, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ConstraintExpirationTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).ConstraintExpirationTime = (global::System.DateTime?) content.GetValueForProperty("ConstraintExpirationTime",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).ConstraintExpirationTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Constraint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Constraint = (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationConstraints) content.GetValueForProperty("Constraint",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Constraint, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.FaultSimulationConstraintsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FaultKind"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).FaultKind = (string) content.GetValueForProperty("FaultKind",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).FaultKind, global::System.Convert.ToString);
            }
            if (content.Contains("Force"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Force = (bool?) content.GetValueForProperty("Force",((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IFaultSimulationContentInternal)this).Force, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Parameters for Zone Fault Simulation action.
    [System.ComponentModel.TypeConverter(typeof(ZoneFaultSimulationContentTypeConverter))]
    public partial interface IZoneFaultSimulationContent

    {

    }
}