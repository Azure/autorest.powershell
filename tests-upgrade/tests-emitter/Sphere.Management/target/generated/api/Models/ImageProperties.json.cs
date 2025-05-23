// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of image</summary>
    public partial class ImageProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IImageProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json ? new ImageProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject into a new instance of <see cref="ImageProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ImageProperties(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_image = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("image"), out var __jsonImage) ? (string)__jsonImage : (string)_image;}
            {_imageId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("imageId"), out var __jsonImageId) ? (string)__jsonImageId : (string)_imageId;}
            {_imageName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("imageName"), out var __jsonImageName) ? (string)__jsonImageName : (string)_imageName;}
            {_regionalDataBoundary = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("regionalDataBoundary"), out var __jsonRegionalDataBoundary) ? (string)__jsonRegionalDataBoundary : (string)_regionalDataBoundary;}
            {_uri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("uri"), out var __jsonUri) ? (string)__jsonUri : (string)_uri;}
            {_description = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)_description;}
            {_componentId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("componentId"), out var __jsonComponentId) ? (string)__jsonComponentId : (string)_componentId;}
            {_imageType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("imageType"), out var __jsonImageType) ? (string)__jsonImageType : (string)_imageType;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ImageProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ImageProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
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
                AddIf( null != (((object)this._image)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._image.ToString()) : null, "image" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._imageId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._imageId.ToString()) : null, "imageId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._imageName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._imageName.ToString()) : null, "imageName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._regionalDataBoundary)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._regionalDataBoundary.ToString()) : null, "regionalDataBoundary" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._uri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._uri.ToString()) : null, "uri" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._description)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._description.ToString()) : null, "description" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._componentId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._componentId.ToString()) : null, "componentId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._imageType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._imageType.ToString()) : null, "imageType" ,container.Add );
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