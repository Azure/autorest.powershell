// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>MarketplaceDetails of Qumulo FileSystem resource</summary>
    public partial class MarketplaceDetails
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IMarketplaceDetails FromJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json ? new MarketplaceDetails(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject into a new instance of <see cref="MarketplaceDetails" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MarketplaceDetails(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_marketplaceSubscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("marketplaceSubscriptionId"), out var __jsonMarketplaceSubscriptionId) ? (string)__jsonMarketplaceSubscriptionId : (string)_marketplaceSubscriptionId;}
            {_planId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("planId"), out var __jsonPlanId) ? (string)__jsonPlanId : (string)_planId;}
            {_offerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("offerId"), out var __jsonOfferId) ? (string)__jsonOfferId : (string)_offerId;}
            {_publisherId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("publisherId"), out var __jsonPublisherId) ? (string)__jsonPublisherId : (string)_publisherId;}
            {_termUnit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("termUnit"), out var __jsonTermUnit) ? (string)__jsonTermUnit : (string)_termUnit;}
            {_marketplaceSubscriptionStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString>("marketplaceSubscriptionStatus"), out var __jsonMarketplaceSubscriptionStatus) ? (string)__jsonMarketplaceSubscriptionStatus : (string)_marketplaceSubscriptionStatus;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MarketplaceDetails" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MarketplaceDetails" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._marketplaceSubscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._marketplaceSubscriptionId.ToString()) : null, "marketplaceSubscriptionId" ,container.Add );
            AddIf( null != (((object)this._planId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._planId.ToString()) : null, "planId" ,container.Add );
            AddIf( null != (((object)this._offerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._offerId.ToString()) : null, "offerId" ,container.Add );
            AddIf( null != (((object)this._publisherId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._publisherId.ToString()) : null, "publisherId" ,container.Add );
            AddIf( null != (((object)this._termUnit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._termUnit.ToString()) : null, "termUnit" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._marketplaceSubscriptionStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Json.JsonString(this._marketplaceSubscriptionStatus.ToString()) : null, "marketplaceSubscriptionStatus" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}