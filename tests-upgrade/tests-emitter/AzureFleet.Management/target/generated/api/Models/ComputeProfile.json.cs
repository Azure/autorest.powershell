// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Compute Profile to use for running user's workloads.</summary>
    public partial class ComputeProfile
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject into a new instance of <see cref="ComputeProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ComputeProfile(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_additionalVirtualMachineCapability = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("additionalVirtualMachineCapabilities"), out var __jsonAdditionalVirtualMachineCapabilities) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.AdditionalCapabilities.FromJson(__jsonAdditionalVirtualMachineCapabilities) : _additionalVirtualMachineCapability;}
            {_computeApiVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("computeApiVersion"), out var __jsonComputeApiVersion) ? (string)__jsonComputeApiVersion : (string)_computeApiVersion;}
            {_platformFaultDomainCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNumber>("platformFaultDomainCount"), out var __jsonPlatformFaultDomainCount) ? (int?)__jsonPlatformFaultDomainCount : _platformFaultDomainCount;}
            {_baseVirtualMachineProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("baseVirtualMachineProfile"), out var __jsonBaseVirtualMachineProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.BaseVirtualMachineProfile.FromJson(__jsonBaseVirtualMachineProfile) : _baseVirtualMachineProfile;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IComputeProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IComputeProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IComputeProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json ? new ComputeProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ComputeProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ComputeProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._additionalVirtualMachineCapability ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._additionalVirtualMachineCapability.ToJson(null,serializationMode) : null, "additionalVirtualMachineCapabilities" ,container.Add );
            AddIf( null != (((object)this._computeApiVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._computeApiVersion.ToString()) : null, "computeApiVersion" ,container.Add );
            AddIf( null != this._platformFaultDomainCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNumber((int)this._platformFaultDomainCount) : null, "platformFaultDomainCount" ,container.Add );
            AddIf( null != this._baseVirtualMachineProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._baseVirtualMachineProfile.ToJson(null,serializationMode) : null, "baseVirtualMachineProfile" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}