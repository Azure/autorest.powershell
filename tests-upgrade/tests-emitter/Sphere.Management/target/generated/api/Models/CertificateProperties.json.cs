// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>The properties of certificate</summary>
    public partial class CertificateProperties
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
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject into a new instance of <see cref="CertificateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CertificateProperties(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_certificate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("certificate"), out var __jsonCertificate) ? (string)__jsonCertificate : (string)_certificate;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_subject = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("subject"), out var __jsonSubject) ? (string)__jsonSubject : (string)_subject;}
            {_thumbprint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("thumbprint"), out var __jsonThumbprint) ? (string)__jsonThumbprint : (string)_thumbprint;}
            {_expiryUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("expiryUtc"), out var __jsonExpiryUtc) ? global::System.DateTime.TryParse((string)__jsonExpiryUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonExpiryUtcValue) ? __jsonExpiryUtcValue : _expiryUtc : _expiryUtc;}
            {_notBeforeUtc = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("notBeforeUtc"), out var __jsonNotBeforeUtc) ? global::System.DateTime.TryParse((string)__jsonNotBeforeUtc, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonNotBeforeUtcValue) ? __jsonNotBeforeUtcValue : _notBeforeUtc : _notBeforeUtc;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICertificateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject json ? new CertificateProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CertificateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CertificateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode" />.
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
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._certificate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._certificate.ToString()) : null, "certificate" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._subject)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._subject.ToString()) : null, "subject" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._thumbprint)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._thumbprint.ToString()) : null, "thumbprint" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._expiryUtc ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._expiryUtc?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "expiryUtc" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._notBeforeUtc ? (Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Json.JsonString(this._notBeforeUtc?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "notBeforeUtc" ,container.Add );
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