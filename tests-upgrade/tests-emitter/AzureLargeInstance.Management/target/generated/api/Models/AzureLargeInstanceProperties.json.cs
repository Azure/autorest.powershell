// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>Describes the properties of an Azure Large Instance.</summary>
    public partial class AzureLargeInstanceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject into a new instance of <see cref="AzureLargeInstanceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AzureLargeInstanceProperties(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_hardwareProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject>("hardwareProfile"), out var __jsonHardwareProfile) ? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.HardwareProfile.FromJson(__jsonHardwareProfile) : _hardwareProfile;}
            {_storageProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject>("storageProfile"), out var __jsonStorageProfile) ? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageProfile.FromJson(__jsonStorageProfile) : _storageProfile;}
            {_oSProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject>("osProfile"), out var __jsonOSProfile) ? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.OSProfile.FromJson(__jsonOSProfile) : _oSProfile;}
            {_networkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject>("networkProfile"), out var __jsonNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.NetworkProfile.FromJson(__jsonNetworkProfile) : _networkProfile;}
            {_azureLargeInstanceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("azureLargeInstanceId"), out var __jsonAzureLargeInstanceId) ? (string)__jsonAzureLargeInstanceId : (string)_azureLargeInstanceId;}
            {_powerState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("powerState"), out var __jsonPowerState) ? (string)__jsonPowerState : (string)_powerState;}
            {_proximityPlacementGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("proximityPlacementGroup"), out var __jsonProximityPlacementGroup) ? (string)__jsonProximityPlacementGroup : (string)_proximityPlacementGroup;}
            {_hwRevision = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("hwRevision"), out var __jsonHwRevision) ? (string)__jsonHwRevision : (string)_hwRevision;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject json ? new AzureLargeInstanceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AzureLargeInstanceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AzureLargeInstanceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._hardwareProfile ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) this._hardwareProfile.ToJson(null,serializationMode) : null, "hardwareProfile" ,container.Add );
            AddIf( null != this._storageProfile ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) this._storageProfile.ToJson(null,serializationMode) : null, "storageProfile" ,container.Add );
            AddIf( null != this._oSProfile ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) this._oSProfile.ToJson(null,serializationMode) : null, "osProfile" ,container.Add );
            AddIf( null != this._networkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) this._networkProfile.ToJson(null,serializationMode) : null, "networkProfile" ,container.Add );
            AddIf( null != (((object)this._azureLargeInstanceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._azureLargeInstanceId.ToString()) : null, "azureLargeInstanceId" ,container.Add );
            AddIf( null != (((object)this._powerState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._powerState.ToString()) : null, "powerState" ,container.Add );
            AddIf( null != (((object)this._proximityPlacementGroup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._proximityPlacementGroup.ToString()) : null, "proximityPlacementGroup" ,container.Add );
            AddIf( null != (((object)this._hwRevision)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._hwRevision.ToString()) : null, "hwRevision" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}