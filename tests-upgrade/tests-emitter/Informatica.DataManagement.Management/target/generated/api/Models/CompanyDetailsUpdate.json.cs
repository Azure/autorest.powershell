// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Company details of Informatica Organization resource</summary>
    public partial class CompanyDetailsUpdate
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject into a new instance of <see cref="CompanyDetailsUpdate" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal CompanyDetailsUpdate(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_companyName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("companyName"), out var __jsonCompanyName) ? (string)__jsonCompanyName : (string)_companyName;}
            {_officeAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("officeAddress"), out var __jsonOfficeAddress) ? (string)__jsonOfficeAddress : (string)_officeAddress;}
            {_country = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("country"), out var __jsonCountry) ? (string)__jsonCountry : (string)_country;}
            {_domain = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("domain"), out var __jsonDomain) ? (string)__jsonDomain : (string)_domain;}
            {_business = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString>("business"), out var __jsonBusiness) ? (string)__jsonBusiness : (string)_business;}
            {_numberOfEmployee = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNumber>("numberOfEmployees"), out var __jsonNumberOfEmployees) ? (int?)__jsonNumberOfEmployees : _numberOfEmployee;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsUpdate FromJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject json ? new CompanyDetailsUpdate(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="CompanyDetailsUpdate" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CompanyDetailsUpdate" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._companyName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._companyName.ToString()) : null, "companyName" ,container.Add );
            AddIf( null != (((object)this._officeAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._officeAddress.ToString()) : null, "officeAddress" ,container.Add );
            AddIf( null != (((object)this._country)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._country.ToString()) : null, "country" ,container.Add );
            AddIf( null != (((object)this._domain)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._domain.ToString()) : null, "domain" ,container.Add );
            AddIf( null != (((object)this._business)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonString(this._business.ToString()) : null, "business" ,container.Add );
            AddIf( null != this._numberOfEmployee ? (Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Json.JsonNumber((int)this._numberOfEmployee) : null, "numberOfEmployees" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}