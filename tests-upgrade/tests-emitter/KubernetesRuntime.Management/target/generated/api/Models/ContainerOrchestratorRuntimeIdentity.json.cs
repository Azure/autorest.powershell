// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Extensions;

    public partial class ContainerOrchestratorRuntimeIdentity
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject into a new instance of <see cref="ContainerOrchestratorRuntimeIdentity" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ContainerOrchestratorRuntimeIdentity(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_resourceUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString>("resourceUri"), out var __jsonResourceUri) ? (string)__jsonResourceUri : (string)_resourceUri;}
            {_storageClassName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString>("storageClassName"), out var __jsonStorageClassName) ? (string)__jsonStorageClassName : (string)_storageClassName;}
            {_loadBalancerName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString>("loadBalancerName"), out var __jsonLoadBalancerName) ? (string)__jsonLoadBalancerName : (string)_loadBalancerName;}
            {_bgpPeerName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString>("bgpPeerName"), out var __jsonBgpPeerName) ? (string)__jsonBgpPeerName : (string)_bgpPeerName;}
            {_serviceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString>("serviceName"), out var __jsonServiceName) ? (string)__jsonServiceName : (string)_serviceName;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)_id;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Models.IContainerOrchestratorRuntimeIdentity FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject json ? new ContainerOrchestratorRuntimeIdentity(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ContainerOrchestratorRuntimeIdentity" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ContainerOrchestratorRuntimeIdentity" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._resourceUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString(this._resourceUri.ToString()) : null, "resourceUri" ,container.Add );
            AddIf( null != (((object)this._storageClassName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString(this._storageClassName.ToString()) : null, "storageClassName" ,container.Add );
            AddIf( null != (((object)this._loadBalancerName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString(this._loadBalancerName.ToString()) : null, "loadBalancerName" ,container.Add );
            AddIf( null != (((object)this._bgpPeerName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString(this._bgpPeerName.ToString()) : null, "bgpPeerName" ,container.Add );
            AddIf( null != (((object)this._serviceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString(this._serviceName.ToString()) : null, "serviceName" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ContainerOrchestratorRuntime.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}