// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The data product properties.</summary>
    public partial class DataProductProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject into a new instance of <see cref="DataProductProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DataProductProperties(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_customerEncryptionKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject>("customerEncryptionKey"), out var __jsonCustomerEncryptionKey) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.EncryptionKeyDetails.FromJson(__jsonCustomerEncryptionKey) : _customerEncryptionKey;}
            {_networkacl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject>("networkacls"), out var __jsonNetworkacls) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataProductNetworkAcls.FromJson(__jsonNetworkacls) : _networkacl;}
            {_consumptionEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject>("consumptionEndpoints"), out var __jsonConsumptionEndpoints) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.ConsumptionEndpointsProperties.FromJson(__jsonConsumptionEndpoints) : _consumptionEndpoint;}
            {_resourceGuid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("resourceGuid"), out var __jsonResourceGuid) ? (string)__jsonResourceGuid : (string)_resourceGuid;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_publisher = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("publisher"), out var __jsonPublisher) ? (string)__jsonPublisher : (string)_publisher;}
            {_product = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("product"), out var __jsonProduct) ? (string)__jsonProduct : (string)_product;}
            {_majorVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("majorVersion"), out var __jsonMajorVersion) ? (string)__jsonMajorVersion : (string)_majorVersion;}
            {_owner = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray>("owners"), out var __jsonOwners) ? If( __jsonOwners as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _owner;}
            {_redundancy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("redundancy"), out var __jsonRedundancy) ? (string)__jsonRedundancy : (string)_redundancy;}
            {_purviewAccount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("purviewAccount"), out var __jsonPurviewAccount) ? (string)__jsonPurviewAccount : (string)_purviewAccount;}
            {_purviewCollection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("purviewCollection"), out var __jsonPurviewCollection) ? (string)__jsonPurviewCollection : (string)_purviewCollection;}
            {_privateLinksEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("privateLinksEnabled"), out var __jsonPrivateLinksEnabled) ? (string)__jsonPrivateLinksEnabled : (string)_privateLinksEnabled;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)_publicNetworkAccess;}
            {_customerManagedKeyEncryptionEnabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("customerManagedKeyEncryptionEnabled"), out var __jsonCustomerManagedKeyEncryptionEnabled) ? (string)__jsonCustomerManagedKeyEncryptionEnabled : (string)_customerManagedKeyEncryptionEnabled;}
            {_availableMinorVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray>("availableMinorVersions"), out var __jsonAvailableMinorVersions) ? If( __jsonAvailableMinorVersions as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : _availableMinorVersion;}
            {_currentMinorVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("currentMinorVersion"), out var __jsonCurrentMinorVersion) ? (string)__jsonCurrentMinorVersion : (string)_currentMinorVersion;}
            {_documentation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("documentation"), out var __jsonDocumentation) ? (string)__jsonDocumentation : (string)_documentation;}
            {_keyVaultUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("keyVaultUrl"), out var __jsonKeyVaultUrl) ? (string)__jsonKeyVaultUrl : (string)_keyVaultUrl;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json ? new DataProductProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DataProductProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DataProductProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != this._customerEncryptionKey ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) this._customerEncryptionKey.ToJson(null,serializationMode) : null, "customerEncryptionKey" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != this._networkacl ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) this._networkacl.ToJson(null,serializationMode) : null, "networkacls" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != this._managedResourceGroupConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) this._managedResourceGroupConfiguration.ToJson(null,serializationMode) : null, "managedResourceGroupConfiguration" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._consumptionEndpoint ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) this._consumptionEndpoint.ToJson(null,serializationMode) : null, "consumptionEndpoints" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._resourceGuid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._resourceGuid.ToString()) : null, "resourceGuid" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._publisher)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._publisher.ToString()) : null, "publisher" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._product)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._product.ToString()) : null, "product" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._majorVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._majorVersion.ToString()) : null, "majorVersion" ,container.Add );
            }
            if (null != this._owner)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.XNodeArray();
                foreach( var __x in this._owner )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("owners",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._redundancy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._redundancy.ToString()) : null, "redundancy" ,container.Add );
            }
            AddIf( null != (((object)this._purviewAccount)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._purviewAccount.ToString()) : null, "purviewAccount" ,container.Add );
            AddIf( null != (((object)this._purviewCollection)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._purviewCollection.ToString()) : null, "purviewCollection" ,container.Add );
            AddIf( null != (((object)this._privateLinksEnabled)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._privateLinksEnabled.ToString()) : null, "privateLinksEnabled" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._customerManagedKeyEncryptionEnabled)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._customerManagedKeyEncryptionEnabled.ToString()) : null, "customerManagedKeyEncryptionEnabled" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._availableMinorVersion)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.XNodeArray();
                    foreach( var __s in this._availableMinorVersion )
                    {
                        AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                    }
                    container.Add("availableMinorVersions",__r);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeUpdate))
            {
                AddIf( null != (((object)this._currentMinorVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._currentMinorVersion.ToString()) : null, "currentMinorVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._documentation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._documentation.ToString()) : null, "documentation" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._keyVaultUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._keyVaultUrl.ToString()) : null, "keyVaultUrl" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}