// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of device</summary>
    public partial class DeviceProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject into a new instance of <see cref="DeviceProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DeviceProperties(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_deviceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("deviceId"), out var __jsonDeviceId) ? (string)__jsonDeviceId : (string)_deviceId;}
            {_chipSku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("chipSku"), out var __jsonChipSku) ? (string)__jsonChipSku : (string)_chipSku;}
            {_lastAvailableOSVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("lastAvailableOsVersion"), out var __jsonLastAvailableOSVersion) ? (string)__jsonLastAvailableOSVersion : (string)_lastAvailableOSVersion;}
            {_lastInstalledOSVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("lastInstalledOsVersion"), out var __jsonLastInstalledOSVersion) ? (string)__jsonLastInstalledOSVersion : (string)_lastInstalledOSVersion;}
            {_lastOSUpdateUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("lastOsUpdateUtc"), out var __jsonLastOSUpdateUtc) ? global::System.DateTime.TryParse((string)__jsonLastOSUpdateUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastOSUpdateUtcValue) ? __jsonLastOSUpdateUtcValue : _lastOSUpdateUtc : _lastOSUpdateUtc;}
            {_lastUpdateRequestUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("lastUpdateRequestUtc"), out var __jsonLastUpdateRequestUtc) ? global::System.DateTime.TryParse((string)__jsonLastUpdateRequestUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastUpdateRequestUtcValue) ? __jsonLastUpdateRequestUtcValue : _lastUpdateRequestUtc : _lastUpdateRequestUtc;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IDeviceProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json ? new DeviceProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DeviceProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DeviceProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._deviceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._deviceId.ToString()) : null, "deviceId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._chipSku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._chipSku.ToString()) : null, "chipSku" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastAvailableOSVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._lastAvailableOSVersion.ToString()) : null, "lastAvailableOsVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastInstalledOSVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._lastInstalledOSVersion.ToString()) : null, "lastInstalledOsVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastOSUpdateUtc ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._lastOSUpdateUtc?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastOsUpdateUtc" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastUpdateRequestUtc ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._lastUpdateRequestUtc?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastUpdateRequestUtc" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}