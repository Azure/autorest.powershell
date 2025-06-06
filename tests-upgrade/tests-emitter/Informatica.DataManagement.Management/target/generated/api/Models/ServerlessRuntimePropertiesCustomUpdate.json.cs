// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Patchable Properties of the Informatica Serverless Runtime resource</summary>
    public partial class ServerlessRuntimePropertiesCustomUpdate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimePropertiesCustomUpdate FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json ? new ServerlessRuntimePropertiesCustomUpdate(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject into a new instance of <see cref="ServerlessRuntimePropertiesCustomUpdate" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ServerlessRuntimePropertiesCustomUpdate(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_serverlessRuntimeNetworkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject>("serverlessRuntimeNetworkProfile"), out var __jsonServerlessRuntimeNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeNetworkProfileUpdate.FromJson(__jsonServerlessRuntimeNetworkProfile) : _serverlessRuntimeNetworkProfile;}
            {_serverlessRuntimeConfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject>("serverlessRuntimeConfig"), out var __jsonServerlessRuntimeConfig) ? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeConfigPropertiesUpdate.FromJson(__jsonServerlessRuntimeConfig) : _serverlessRuntimeConfig;}
            {_serverlessRuntimeUserContextProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject>("serverlessRuntimeUserContextProperties"), out var __jsonServerlessRuntimeUserContextProperties) ? Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeUserContextPropertiesUpdate.FromJson(__jsonServerlessRuntimeUserContextProperties) : _serverlessRuntimeUserContextProperty;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_platform = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("platform"), out var __jsonPlatform) ? (string)__jsonPlatform : (string)_platform;}
            {_applicationType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("applicationType"), out var __jsonApplicationType) ? (string)__jsonApplicationType : (string)_applicationType;}
            {_computeUnit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("computeUnits"), out var __jsonComputeUnits) ? (string)__jsonComputeUnits : (string)_computeUnit;}
            {_executionTimeout = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("executionTimeout"), out var __jsonExecutionTimeout) ? (string)__jsonExecutionTimeout : (string)_executionTimeout;}
            {_serverlessAccountLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("serverlessAccountLocation"), out var __jsonServerlessAccountLocation) ? (string)__jsonServerlessAccountLocation : (string)_serverlessAccountLocation;}
            {_advancedCustomProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray>("advancedCustomProperties"), out var __jsonAdvancedCustomProperties) ? If( __jsonAdvancedCustomProperties as Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties) (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.AdvancedCustomProperties.FromJson(__u) )) ))() : null : _advancedCustomProperty;}
            {_supplementaryFileLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("supplementaryFileLocation"), out var __jsonSupplementaryFileLocation) ? (string)__jsonSupplementaryFileLocation : (string)_supplementaryFileLocation;}
            {_serverlessRuntimeTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray>("serverlessRuntimeTags"), out var __jsonServerlessRuntimeTags) ? If( __jsonServerlessRuntimeTags as Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag) (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ServerlessRuntimeTag.FromJson(__p) )) ))() : null : _serverlessRuntimeTag;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ServerlessRuntimePropertiesCustomUpdate" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ServerlessRuntimePropertiesCustomUpdate" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._serverlessRuntimeNetworkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) this._serverlessRuntimeNetworkProfile.ToJson(null,serializationMode) : null, "serverlessRuntimeNetworkProfile" ,container.Add );
            AddIf( null != this._serverlessRuntimeConfig ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) this._serverlessRuntimeConfig.ToJson(null,serializationMode) : null, "serverlessRuntimeConfig" ,container.Add );
            AddIf( null != this._serverlessRuntimeUserContextProperty ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) this._serverlessRuntimeUserContextProperty.ToJson(null,serializationMode) : null, "serverlessRuntimeUserContextProperties" ,container.Add );
            AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            AddIf( null != (((object)this._platform)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._platform.ToString()) : null, "platform" ,container.Add );
            AddIf( null != (((object)this._applicationType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._applicationType.ToString()) : null, "applicationType" ,container.Add );
            AddIf( null != (((object)this._computeUnit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._computeUnit.ToString()) : null, "computeUnits" ,container.Add );
            AddIf( null != (((object)this._executionTimeout)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._executionTimeout.ToString()) : null, "executionTimeout" ,container.Add );
            AddIf( null != (((object)this._serverlessAccountLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._serverlessAccountLocation.ToString()) : null, "serverlessAccountLocation" ,container.Add );
            if (null != this._advancedCustomProperty)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.XNodeArray();
                foreach( var __x in this._advancedCustomProperty )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("advancedCustomProperties",__w);
            }
            AddIf( null != (((object)this._supplementaryFileLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._supplementaryFileLocation.ToString()) : null, "supplementaryFileLocation" ,container.Add );
            if (null != this._serverlessRuntimeTag)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.XNodeArray();
                foreach( var __s in this._serverlessRuntimeTag )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("serverlessRuntimeTags",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}