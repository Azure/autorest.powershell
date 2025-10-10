// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>
    /// the service specific properties of a provisioning service, including keys, linked iot hubs, current state, and system
    /// generated properties such as hostname and idScope
    /// </summary>
    public partial class IotDpsPropertiesDescription
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsPropertiesDescription FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject json ? new IotDpsPropertiesDescription(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject into a new instance of <see cref="IotDpsPropertiesDescription" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal IotDpsPropertiesDescription(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_deviceRegistryNamespace = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject>("deviceRegistryNamespace"), out var __jsonDeviceRegistryNamespace) ? Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.DeviceRegistryNamespaceDescription.FromJson(__jsonDeviceRegistryNamespace) : _deviceRegistryNamespace;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)_state;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)_publicNetworkAccess;}
            {_iPFilterRule = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray>("ipFilterRules"), out var __jsonIPFilterRules) ? If( __jsonIPFilterRules as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIPFilterRule) (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPFilterRule.FromJson(__u) )) ))() : null : _iPFilterRule;}
            {_privateEndpointConnection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray>("privateEndpointConnections"), out var __jsonPrivateEndpointConnections) ? If( __jsonPrivateEndpointConnections as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IPrivateEndpointConnection) (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.PrivateEndpointConnection.FromJson(__p) )) ))() : null : _privateEndpointConnection;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_iotHub = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray>("iotHubs"), out var __jsonIotHubs) ? If( __jsonIotHubs as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotHubDefinitionDescription) (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IotHubDefinitionDescription.FromJson(__k) )) ))() : null : _iotHub;}
            {_allocationPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("allocationPolicy"), out var __jsonAllocationPolicy) ? (string)__jsonAllocationPolicy : (string)_allocationPolicy;}
            {_serviceOperationsHostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("serviceOperationsHostName"), out var __jsonServiceOperationsHostName) ? (string)__jsonServiceOperationsHostName : (string)_serviceOperationsHostName;}
            {_deviceProvisioningHostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("deviceProvisioningHostName"), out var __jsonDeviceProvisioningHostName) ? (string)__jsonDeviceProvisioningHostName : (string)_deviceProvisioningHostName;}
            {_idScope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("idScope"), out var __jsonIdScope) ? (string)__jsonIdScope : (string)_idScope;}
            {_authorizationPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray>("authorizationPolicies"), out var __jsonAuthorizationPolicies) ? If( __jsonAuthorizationPolicies as Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription) (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.SharedAccessSignatureAuthorizationRuleAccessRightsDescription.FromJson(__f) )) ))() : null : _authorizationPolicy;}
            {_enableDataResidency = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonBoolean>("enableDataResidency"), out var __jsonEnableDataResidency) ? (bool?)__jsonEnableDataResidency : _enableDataResidency;}
            {_portalOperationsHostName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString>("portalOperationsHostName"), out var __jsonPortalOperationsHostName) ? (string)__jsonPortalOperationsHostName : (string)_portalOperationsHostName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="IotDpsPropertiesDescription" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="IotDpsPropertiesDescription" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._deviceRegistryNamespace ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) this._deviceRegistryNamespace.ToJson(null,serializationMode) : null, "deviceRegistryNamespace" ,container.Add );
            AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            if (null != this._iPFilterRule)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.XNodeArray();
                foreach( var __x in this._iPFilterRule )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("ipFilterRules",__w);
            }
            if (null != this._privateEndpointConnection)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.XNodeArray();
                foreach( var __s in this._privateEndpointConnection )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("privateEndpointConnections",__r);
            }
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            if (null != this._iotHub)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.XNodeArray();
                foreach( var __n in this._iotHub )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("iotHubs",__m);
            }
            AddIf( null != (((object)this._allocationPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._allocationPolicy.ToString()) : null, "allocationPolicy" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._serviceOperationsHostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._serviceOperationsHostName.ToString()) : null, "serviceOperationsHostName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._deviceProvisioningHostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._deviceProvisioningHostName.ToString()) : null, "deviceProvisioningHostName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._idScope)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._idScope.ToString()) : null, "idScope" ,container.Add );
            }
            if (null != this._authorizationPolicy)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.XNodeArray();
                foreach( var __i in this._authorizationPolicy )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("authorizationPolicies",__h);
            }
            AddIf( null != this._enableDataResidency ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonBoolean((bool)this._enableDataResidency) : null, "enableDataResidency" ,container.Add );
            AddIf( null != (((object)this._portalOperationsHostName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Json.JsonString(this._portalOperationsHostName.ToString()) : null, "portalOperationsHostName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}