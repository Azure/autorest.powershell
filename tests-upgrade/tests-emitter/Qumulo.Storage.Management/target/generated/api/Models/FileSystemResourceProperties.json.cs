// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>Properties specific to the Qumulo File System resource</summary>
    public partial class FileSystemResourceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject into a new instance of <see cref="FileSystemResourceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal FileSystemResourceProperties(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_marketplaceDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject>("marketplaceDetails"), out var __jsonMarketplaceDetails) ? Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.MarketplaceDetails.FromJson(__jsonMarketplaceDetails) : _marketplaceDetail;}
            {_userDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject>("userDetails"), out var __jsonUserDetails) ? Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.UserDetails.FromJson(__jsonUserDetails) : _userDetail;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_storageSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("storageSku"), out var __jsonStorageSku) ? (string)__jsonStorageSku : (string)_storageSku;}
            {_delegatedSubnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("delegatedSubnetId"), out var __jsonDelegatedSubnetId) ? (string)__jsonDelegatedSubnetId : (string)_delegatedSubnetId;}
            {_clusterLoginUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("clusterLoginUrl"), out var __jsonClusterLoginUrl) ? (string)__jsonClusterLoginUrl : (string)_clusterLoginUrl;}
            {_privateIP = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonArray>("privateIPs"), out var __jsonPrivateIPs) ? If( __jsonPrivateIPs as Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _privateIP;}
            {_adminPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("adminPassword"), out var __jsonAdminPassword) ? (string)__jsonAdminPassword : (string)_adminPassword;}
            {_availabilityZone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("availabilityZone"), out var __jsonAvailabilityZone) ? (string)__jsonAvailabilityZone : (string)_availabilityZone;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IFileSystemResourceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json ? new FileSystemResourceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="FileSystemResourceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="FileSystemResourceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._marketplaceDetail ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) this._marketplaceDetail.ToJson(null,serializationMode) : null, "marketplaceDetails" ,container.Add );
            AddIf( null != this._userDetail ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) this._userDetail.ToJson(null,serializationMode) : null, "userDetails" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._storageSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._storageSku.ToString()) : null, "storageSku" ,container.Add );
            AddIf( null != (((object)this._delegatedSubnetId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._delegatedSubnetId.ToString()) : null, "delegatedSubnetId" ,container.Add );
            AddIf( null != (((object)this._clusterLoginUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._clusterLoginUrl.ToString()) : null, "clusterLoginUrl" ,container.Add );
            if (null != this._privateIP)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.XNodeArray();
                foreach( var __x in this._privateIP )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("privateIPs",__w);
            }
            AddIf( null != (((object)this._adminPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._adminPassword.ToString()) : null, "adminPassword" ,container.Add );
            AddIf( null != (((object)this._availabilityZone)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._availabilityZone.ToString()) : null, "availabilityZone" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}