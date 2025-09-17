// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Specifies an IP configuration of the network interface.</summary>
    public partial class IPConfiguration
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPConfiguration FromJson(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json ? new IPConfiguration(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject into a new instance of <see cref="IPConfiguration" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal IPConfiguration(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_subnet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("subnet"), out var __jsonSubnet) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource.FromJson(__jsonSubnet) : _subnet;}
            {_publicIPAddressConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject>("publicIPAddressConfiguration"), out var __jsonPublicIPAddressConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.PublicIPAddressConfiguration.FromJson(__jsonPublicIPAddressConfiguration) : _publicIPAddressConfiguration;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)_name;}
            {_applicationGatewayBackendAddressPool = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("applicationGatewayBackendAddressPools"), out var __jsonApplicationGatewayBackendAddressPools) ? If( __jsonApplicationGatewayBackendAddressPools as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource.FromJson(__u) )) ))() : null : _applicationGatewayBackendAddressPool;}
            {_loadBalancerBackendAddressPool = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("loadBalancerBackendAddressPools"), out var __jsonLoadBalancerBackendAddressPools) ? If( __jsonLoadBalancerBackendAddressPools as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource.FromJson(__p) )) ))() : null : _loadBalancerBackendAddressPool;}
            {_loadBalancerInboundNatPool = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray>("loadBalancerInboundNatPools"), out var __jsonLoadBalancerInboundNatPools) ? If( __jsonLoadBalancerInboundNatPools as Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.ISubResource) (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.SubResource.FromJson(__k) )) ))() : null : _loadBalancerInboundNatPool;}
            {_privateIPAddressVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString>("privateIPAddressVersion"), out var __jsonPrivateIPAddressVersion) ? (string)__jsonPrivateIPAddressVersion : (string)_privateIPAddressVersion;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="IPConfiguration" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="IPConfiguration" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._subnet ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._subnet.ToJson(null,serializationMode) : null, "subnet" ,container.Add );
            AddIf( null != this._publicIPAddressConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) this._publicIPAddressConfiguration.ToJson(null,serializationMode) : null, "publicIPAddressConfiguration" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            if (null != this._applicationGatewayBackendAddressPool)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __x in this._applicationGatewayBackendAddressPool )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("applicationGatewayBackendAddressPools",__w);
            }
            if (null != this._loadBalancerBackendAddressPool)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __s in this._loadBalancerBackendAddressPool )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("loadBalancerBackendAddressPools",__r);
            }
            if (null != this._loadBalancerInboundNatPool)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.XNodeArray();
                foreach( var __n in this._loadBalancerInboundNatPool )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("loadBalancerInboundNatPools",__m);
            }
            AddIf( null != (((object)this._privateIPAddressVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Json.JsonString(this._privateIPAddressVersion.ToString()) : null, "privateIPAddressVersion" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}