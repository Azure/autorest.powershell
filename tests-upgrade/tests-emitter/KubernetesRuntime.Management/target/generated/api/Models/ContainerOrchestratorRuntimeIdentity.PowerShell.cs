// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ContainerOrchestratorRuntimeIdentityTypeConverter))]
    public partial class ContainerOrchestratorRuntimeIdentity
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ContainerOrchestratorRuntimeIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ContainerOrchestratorRuntimeIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ResourceUri = (string) content.GetValueForProperty("ResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("StorageClassName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).StorageClassName = (string) content.GetValueForProperty("StorageClassName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).StorageClassName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).LoadBalancerName = (string) content.GetValueForProperty("LoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).LoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("BgpPeerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).BgpPeerName = (string) content.GetValueForProperty("BgpPeerName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).BgpPeerName, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ServiceName = (string) content.GetValueForProperty("ServiceName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ServiceName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ContainerOrchestratorRuntimeIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ContainerOrchestratorRuntimeIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ResourceUri = (string) content.GetValueForProperty("ResourceUri",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ResourceUri, global::System.Convert.ToString);
            }
            if (content.Contains("StorageClassName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).StorageClassName = (string) content.GetValueForProperty("StorageClassName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).StorageClassName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).LoadBalancerName = (string) content.GetValueForProperty("LoadBalancerName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).LoadBalancerName, global::System.Convert.ToString);
            }
            if (content.Contains("BgpPeerName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).BgpPeerName = (string) content.GetValueForProperty("BgpPeerName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).BgpPeerName, global::System.Convert.ToString);
            }
            if (content.Contains("ServiceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ServiceName = (string) content.GetValueForProperty("ServiceName",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).ServiceName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ContainerOrchestratorRuntimeIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ContainerOrchestratorRuntimeIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.ContainerOrchestratorRuntimeIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ContainerOrchestratorRuntimeIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ContainerOrchestratorRuntimeIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="ContainerOrchestratorRuntimeIdentity" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    [System.ComponentModel.TypeConverter(typeof(ContainerOrchestratorRuntimeIdentityTypeConverter))]
    public partial interface IContainerOrchestratorRuntimeIdentity

    {

    }
}