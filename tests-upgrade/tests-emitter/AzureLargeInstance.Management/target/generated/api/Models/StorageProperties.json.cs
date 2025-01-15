// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>described the storage properties of the azure large storage instance</summary>
    public partial class StorageProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IStorageProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject json ? new StorageProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject into a new instance of <see cref="StorageProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal StorageProperties(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_storageBillingProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject>("storageBillingProperties"), out var __jsonStorageBillingProperties) ? Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.StorageBillingProperties.FromJson(__jsonStorageBillingProperties) : _storageBillingProperty;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_offeringType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("offeringType"), out var __jsonOfferingType) ? (string)__jsonOfferingType : (string)_offeringType;}
            {_storageType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("storageType"), out var __jsonStorageType) ? (string)__jsonStorageType : (string)_storageType;}
            {_generation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("generation"), out var __jsonGeneration) ? (string)__jsonGeneration : (string)_generation;}
            {_hardwareType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("hardwareType"), out var __jsonHardwareType) ? (string)__jsonHardwareType : (string)_hardwareType;}
            {_workloadType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString>("workloadType"), out var __jsonWorkloadType) ? (string)__jsonWorkloadType : (string)_workloadType;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="StorageProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="StorageProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._storageBillingProperty ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) this._storageBillingProperty.ToJson(null,serializationMode) : null, "storageBillingProperties" ,container.Add );
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            AddIf( null != (((object)this._offeringType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._offeringType.ToString()) : null, "offeringType" ,container.Add );
            AddIf( null != (((object)this._storageType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._storageType.ToString()) : null, "storageType" ,container.Add );
            AddIf( null != (((object)this._generation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._generation.ToString()) : null, "generation" ,container.Add );
            AddIf( null != (((object)this._hardwareType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._hardwareType.ToString()) : null, "hardwareType" ,container.Add );
            AddIf( null != (((object)this._workloadType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonString(this._workloadType.ToString()) : null, "workloadType" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}