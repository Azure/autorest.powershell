// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Extensions;

    /// <summary>The properties of an Extended Zone resource.</summary>
    public partial class ExtendedZoneProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject into a new instance of <see cref="ExtendedZoneProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ExtendedZoneProperties(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_registrationState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("registrationState"), out var __jsonRegistrationState) ? (string)__jsonRegistrationState : (string)_registrationState;}
            {_displayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("displayName"), out var __jsonDisplayName) ? (string)__jsonDisplayName : (string)_displayName;}
            {_regionalDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("regionalDisplayName"), out var __jsonRegionalDisplayName) ? (string)__jsonRegionalDisplayName : (string)_regionalDisplayName;}
            {_regionType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("regionType"), out var __jsonRegionType) ? (string)__jsonRegionType : (string)_regionType;}
            {_regionCategory = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("regionCategory"), out var __jsonRegionCategory) ? (string)__jsonRegionCategory : (string)_regionCategory;}
            {_geography = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("geography"), out var __jsonGeography) ? (string)__jsonGeography : (string)_geography;}
            {_geographyGroup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("geographyGroup"), out var __jsonGeographyGroup) ? (string)__jsonGeographyGroup : (string)_geographyGroup;}
            {_longitude = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("longitude"), out var __jsonLongitude) ? (string)__jsonLongitude : (string)_longitude;}
            {_latitude = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("latitude"), out var __jsonLatitude) ? (string)__jsonLatitude : (string)_latitude;}
            {_homeLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString>("homeLocation"), out var __jsonHomeLocation) ? (string)__jsonHomeLocation : (string)_homeLocation;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject json ? new ExtendedZoneProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ExtendedZoneProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ExtendedZoneProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._registrationState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._registrationState.ToString()) : null, "registrationState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._displayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._displayName.ToString()) : null, "displayName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._regionalDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._regionalDisplayName.ToString()) : null, "regionalDisplayName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._regionType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._regionType.ToString()) : null, "regionType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._regionCategory)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._regionCategory.ToString()) : null, "regionCategory" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._geography)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._geography.ToString()) : null, "geography" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._geographyGroup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._geographyGroup.ToString()) : null, "geographyGroup" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._longitude)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._longitude.ToString()) : null, "longitude" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._latitude)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._latitude.ToString()) : null, "latitude" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._homeLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Json.JsonString(this._homeLocation.ToString()) : null, "homeLocation" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}