// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// The allocation details of the per subscription free trial slot of the subscription.
    /// </summary>
    public partial class MarketplaceTrialQuota
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IMarketplaceTrialQuota FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject json ? new MarketplaceTrialQuota(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject into a new instance of <see cref="MarketplaceTrialQuota" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MarketplaceTrialQuota(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_availablePromotion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("availablePromotion"), out var __jsonAvailablePromotion) ? (string)__jsonAvailablePromotion : (string)_availablePromotion;}
            {_grafanaResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("grafanaResourceId"), out var __jsonGrafanaResourceId) ? (string)__jsonGrafanaResourceId : (string)_grafanaResourceId;}
            {_trialStartAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("trialStartAt"), out var __jsonTrialStartAt) ? global::System.DateTime.TryParse((string)__jsonTrialStartAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonTrialStartAtValue) ? __jsonTrialStartAtValue : _trialStartAt : _trialStartAt;}
            {_trialEndAt = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("trialEndAt"), out var __jsonTrialEndAt) ? global::System.DateTime.TryParse((string)__jsonTrialEndAt, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonTrialEndAtValue) ? __jsonTrialEndAtValue : _trialEndAt : _trialEndAt;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MarketplaceTrialQuota" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MarketplaceTrialQuota" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._availablePromotion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._availablePromotion.ToString()) : null, "availablePromotion" ,container.Add );
            AddIf( null != (((object)this._grafanaResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._grafanaResourceId.ToString()) : null, "grafanaResourceId" ,container.Add );
            AddIf( null != this._trialStartAt ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._trialStartAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "trialStartAt" ,container.Add );
            AddIf( null != this._trialEndAt ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._trialEndAt?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "trialEndAt" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}