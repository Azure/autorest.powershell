// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the ContainerGroupProperties.</summary>
    public partial class ContainerGroupProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject into a new instance of <see cref="ContainerGroupProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ContainerGroupProperties(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_containerGroupProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject>("containerGroupProfile"), out var __jsonContainerGroupProfile) ? Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProfile.FromJson(__jsonContainerGroupProfile) : _containerGroupProfile;}
            {_subnetId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonArray>("subnetIds"), out var __jsonSubnetIds) ? If( __jsonSubnetIds as Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet) (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.Subnet.FromJson(__u) )) ))() : null : _subnetId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject json ? new ContainerGroupProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ContainerGroupProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ContainerGroupProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._containerGroupProfile ? (Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.JsonNode) this._containerGroupProfile.ToJson(null,serializationMode) : null, "containerGroupProfile" ,container.Add );
            if (null != this._subnetId)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Json.XNodeArray();
                foreach( var __x in this._subnetId )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("subnetIds",__w);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}