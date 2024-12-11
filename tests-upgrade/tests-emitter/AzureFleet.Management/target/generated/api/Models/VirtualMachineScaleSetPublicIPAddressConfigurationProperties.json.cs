// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's PublicIPAddress
    /// configuration
    /// </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfigurationProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetPublicIPAddressConfigurationProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json ? new VirtualMachineScaleSetPublicIPAddressConfigurationProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._dnsSetting ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._dnsSetting.ToJson(null,serializationMode) : null, "dnsSettings" ,container.Add );
            AddIf( null != this._publicIPPrefix ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._publicIPPrefix.ToJson(null,serializationMode) : null, "publicIPPrefix" ,container.Add );
            AddIf( null != this._idleTimeoutInMinute ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNumber((int)this._idleTimeoutInMinute) : null, "idleTimeoutInMinutes" ,container.Add );
            if (null != this._iPTag)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __x in this._iPTag )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("ipTags",__w);
            }
            AddIf( null != (((object)this._publicIPAddressVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._publicIPAddressVersion.ToString()) : null, "publicIPAddressVersion" ,container.Add );
            AddIf( null != (((object)this._deleteOption)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._deleteOption.ToString()) : null, "deleteOption" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineScaleSetPublicIPAddressConfigurationProperties"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineScaleSetPublicIPAddressConfigurationProperties(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_dnsSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("dnsSettings"), out var __jsonDnsSettings) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings.FromJson(__jsonDnsSettings) : _dnsSetting;}
            {_publicIPPrefix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("publicIPPrefix"), out var __jsonPublicIPPrefix) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SubResource.FromJson(__jsonPublicIPPrefix) : _publicIPPrefix;}
            {_idleTimeoutInMinute = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNumber>("idleTimeoutInMinutes"), out var __jsonIdleTimeoutInMinutes) ? (int?)__jsonIdleTimeoutInMinutes : _idleTimeoutInMinute;}
            {_iPTag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("ipTags"), out var __jsonIPTags) ? If( __jsonIPTags as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetIPTag) (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetIPTag.FromJson(__u) )) ))() : null : _iPTag;}
            {_publicIPAddressVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("publicIPAddressVersion"), out var __jsonPublicIPAddressVersion) ? (string)__jsonPublicIPAddressVersion : (string)_publicIPAddressVersion;}
            {_deleteOption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("deleteOption"), out var __jsonDeleteOption) ? (string)__jsonDeleteOption : (string)_deleteOption;}
            AfterFromJson(json);
        }
    }
}