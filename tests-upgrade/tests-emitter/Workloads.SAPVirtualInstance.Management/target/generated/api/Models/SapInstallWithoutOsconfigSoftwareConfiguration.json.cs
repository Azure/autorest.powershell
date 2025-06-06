// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The SAP Software configuration Input when the software is to be installed by service without OS Configurations
    /// </summary>
    public partial class SapInstallWithoutOsconfigSoftwareConfiguration
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapInstallWithoutOsconfigSoftwareConfiguration.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapInstallWithoutOsconfigSoftwareConfiguration.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapInstallWithoutOsconfigSoftwareConfiguration FromJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject json ? new SapInstallWithoutOsconfigSoftwareConfiguration(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject into a new instance of <see cref="SapInstallWithoutOsconfigSoftwareConfiguration"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SapInstallWithoutOsconfigSoftwareConfiguration(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __softwareConfiguration = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SoftwareConfiguration(json);
            {_highAvailabilitySoftwareConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject>("highAvailabilitySoftwareConfiguration"), out var __jsonHighAvailabilitySoftwareConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.HighAvailabilitySoftwareConfiguration.FromJson(__jsonHighAvailabilitySoftwareConfiguration) : _highAvailabilitySoftwareConfiguration;}
            {_bomUrl = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonString>("bomUrl"), out var __jsonBomUrl) ? (string)__jsonBomUrl : (string)_bomUrl;}
            {_sapBitsStorageAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonString>("sapBitsStorageAccountId"), out var __jsonSapBitsStorageAccountId) ? (string)__jsonSapBitsStorageAccountId : (string)_sapBitsStorageAccountId;}
            {_softwareVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonString>("softwareVersion"), out var __jsonSoftwareVersion) ? (string)__jsonSoftwareVersion : (string)_softwareVersion;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SapInstallWithoutOsconfigSoftwareConfiguration" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SapInstallWithoutOsconfigSoftwareConfiguration" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode"
        /// />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            __softwareConfiguration?.ToJson(container, serializationMode);
            AddIf( null != this._highAvailabilitySoftwareConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode) this._highAvailabilitySoftwareConfiguration.ToJson(null,serializationMode) : null, "highAvailabilitySoftwareConfiguration" ,container.Add );
            AddIf( null != (((object)this._bomUrl)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonString(this._bomUrl.ToString()) : null, "bomUrl" ,container.Add );
            AddIf( null != (((object)this._sapBitsStorageAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonString(this._sapBitsStorageAccountId.ToString()) : null, "sapBitsStorageAccountId" ,container.Add );
            AddIf( null != (((object)this._softwareVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Json.JsonString(this._softwareVersion.ToString()) : null, "softwareVersion" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}