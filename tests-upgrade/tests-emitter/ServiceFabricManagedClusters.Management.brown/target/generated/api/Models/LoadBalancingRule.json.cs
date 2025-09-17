// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Describes a load balancing rule.</summary>
    public partial class LoadBalancingRule
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ILoadBalancingRule FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json ? new LoadBalancingRule(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject into a new instance of <see cref="LoadBalancingRule" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LoadBalancingRule(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_frontendPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("frontendPort"), out var __jsonFrontendPort) ? (int)__jsonFrontendPort : _frontendPort;}
            {_backendPort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("backendPort"), out var __jsonBackendPort) ? (int)__jsonBackendPort : _backendPort;}
            {_protocol = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("protocol"), out var __jsonProtocol) ? (string)__jsonProtocol : (string)_protocol;}
            {_probePort = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber>("probePort"), out var __jsonProbePort) ? (int?)__jsonProbePort : _probePort;}
            {_probeProtocol = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("probeProtocol"), out var __jsonProbeProtocol) ? (string)__jsonProbeProtocol : (string)_probeProtocol;}
            {_probeRequestPath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("probeRequestPath"), out var __jsonProbeRequestPath) ? (string)__jsonProbeRequestPath : (string)_probeRequestPath;}
            {_loadDistribution = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("loadDistribution"), out var __jsonLoadDistribution) ? (string)__jsonLoadDistribution : (string)_loadDistribution;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LoadBalancingRule" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LoadBalancingRule" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber(this._frontendPort), "frontendPort" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber(this._backendPort), "backendPort" ,container.Add );
            AddIf( null != (((object)this._protocol)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._protocol.ToString()) : null, "protocol" ,container.Add );
            AddIf( null != this._probePort ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNumber((int)this._probePort) : null, "probePort" ,container.Add );
            AddIf( null != (((object)this._probeProtocol)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._probeProtocol.ToString()) : null, "probeProtocol" ,container.Add );
            AddIf( null != (((object)this._probeRequestPath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._probeRequestPath.ToString()) : null, "probeRequestPath" ,container.Add );
            AddIf( null != (((object)this._loadDistribution)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._loadDistribution.ToString()) : null, "loadDistribution" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}