// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Data Organization resource</summary>
    public partial class OrganizationProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IOrganizationProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json ? new OrganizationProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject into a new instance of <see cref="OrganizationProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OrganizationProperties(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_marketplaceDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject>("marketplaceDetails"), out var __jsonMarketplaceDetails) ? Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.MarketplaceDetails.FromJson(__jsonMarketplaceDetails) : _marketplaceDetail;}
            {_userDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject>("userDetails"), out var __jsonUserDetails) ? Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.UserDetails.FromJson(__jsonUserDetails) : _userDetail;}
            {_companyDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject>("companyDetails"), out var __jsonCompanyDetails) ? Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.CompanyDetails.FromJson(__jsonCompanyDetails) : _companyDetail;}
            {_partnerOrganizationProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject>("partnerOrganizationProperties"), out var __jsonPartnerOrganizationProperties) ? Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.PartnerOrganizationProperties.FromJson(__jsonPartnerOrganizationProperties) : _partnerOrganizationProperty;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OrganizationProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OrganizationProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeRead)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != this._marketplaceDetail ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) this._marketplaceDetail.ToJson(null,serializationMode) : null, "marketplaceDetails" ,container.Add );
            }
            AddIf( null != this._userDetail ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) this._userDetail.ToJson(null,serializationMode) : null, "userDetails" ,container.Add );
            AddIf( null != this._companyDetail ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) this._companyDetail.ToJson(null,serializationMode) : null, "companyDetails" ,container.Add );
            AddIf( null != this._partnerOrganizationProperty ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) this._partnerOrganizationProperty.ToJson(null,serializationMode) : null, "partnerOrganizationProperties" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}