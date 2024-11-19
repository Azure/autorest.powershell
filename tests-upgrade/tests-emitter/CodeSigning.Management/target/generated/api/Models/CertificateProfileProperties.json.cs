// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Properties of the certificate profile.</summary>
    public partial class CertificateProfileProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject into a new instance of <see cref="CertificateProfileProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CertificateProfileProperties(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_profileType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("profileType"), out var __jsonProfileType) ? (string)__jsonProfileType : (string)_profileType;}
            {_commonName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("commonName"), out var __jsonCommonName) ? (string)__jsonCommonName : (string)_commonName;}
            {_organization = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("organization"), out var __jsonOrganization) ? (string)__jsonOrganization : (string)_organization;}
            {_organizationUnit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("organizationUnit"), out var __jsonOrganizationUnit) ? (string)__jsonOrganizationUnit : (string)_organizationUnit;}
            {_streetAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("streetAddress"), out var __jsonStreetAddress) ? (string)__jsonStreetAddress : (string)_streetAddress;}
            {_includeStreetAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean>("includeStreetAddress"), out var __jsonIncludeStreetAddress) ? (bool?)__jsonIncludeStreetAddress : _includeStreetAddress;}
            {_city = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("city"), out var __jsonCity) ? (string)__jsonCity : (string)_city;}
            {_includeCity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean>("includeCity"), out var __jsonIncludeCity) ? (bool?)__jsonIncludeCity : _includeCity;}
            {_state = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)_state;}
            {_includeState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean>("includeState"), out var __jsonIncludeState) ? (bool?)__jsonIncludeState : _includeState;}
            {_country = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("country"), out var __jsonCountry) ? (string)__jsonCountry : (string)_country;}
            {_includeCountry = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean>("includeCountry"), out var __jsonIncludeCountry) ? (bool?)__jsonIncludeCountry : _includeCountry;}
            {_postalCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("postalCode"), out var __jsonPostalCode) ? (string)__jsonPostalCode : (string)_postalCode;}
            {_includePostalCode = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean>("includePostalCode"), out var __jsonIncludePostalCode) ? (bool?)__jsonIncludePostalCode : _includePostalCode;}
            {_enhancedKeyUsage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("enhancedKeyUsage"), out var __jsonEnhancedKeyUsage) ? (string)__jsonEnhancedKeyUsage : (string)_enhancedKeyUsage;}
            {_identityValidationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("identityValidationId"), out var __jsonIdentityValidationId) ? (string)__jsonIdentityValidationId : (string)_identityValidationId;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString>("status"), out var __jsonStatus) ? (string)__jsonStatus : (string)_status;}
            {_certificate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonArray>("certificates"), out var __jsonCertificates) ? If( __jsonCertificates as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificate) (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.Certificate.FromJson(__u) )) ))() : null : _certificate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfileProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject json ? new CertificateProfileProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CertificateProfileProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CertificateProfileProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._profileType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._profileType.ToString()) : null, "profileType" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._commonName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._commonName.ToString()) : null, "commonName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._organization)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._organization.ToString()) : null, "organization" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._organizationUnit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._organizationUnit.ToString()) : null, "organizationUnit" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._streetAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._streetAddress.ToString()) : null, "streetAddress" ,container.Add );
            }
            AddIf( null != this._includeStreetAddress ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean((bool)this._includeStreetAddress) : null, "includeStreetAddress" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._city)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._city.ToString()) : null, "city" ,container.Add );
            }
            AddIf( null != this._includeCity ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean((bool)this._includeCity) : null, "includeCity" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._state)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._state.ToString()) : null, "state" ,container.Add );
            }
            AddIf( null != this._includeState ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean((bool)this._includeState) : null, "includeState" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._country)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._country.ToString()) : null, "country" ,container.Add );
            }
            AddIf( null != this._includeCountry ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean((bool)this._includeCountry) : null, "includeCountry" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._postalCode)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._postalCode.ToString()) : null, "postalCode" ,container.Add );
            }
            AddIf( null != this._includePostalCode ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonBoolean((bool)this._includePostalCode) : null, "includePostalCode" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._enhancedKeyUsage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._enhancedKeyUsage.ToString()) : null, "enhancedKeyUsage" ,container.Add );
            }
            AddIf( null != (((object)this._identityValidationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._identityValidationId.ToString()) : null, "identityValidationId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._status)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.JsonString(this._status.ToString()) : null, "status" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._certificate)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Json.XNodeArray();
                    foreach( var __x in this._certificate )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("certificates",__w);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}