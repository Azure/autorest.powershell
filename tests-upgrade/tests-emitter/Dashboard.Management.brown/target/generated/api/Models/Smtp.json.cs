// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// Email server settings.
    /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
    /// </summary>
    public partial class Smtp
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp FromJson(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject json ? new Smtp(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject into a new instance of <see cref="Smtp" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Smtp(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_enabled = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonBoolean>("enabled"), out var __jsonEnabled) ? (bool?)__jsonEnabled : _enabled;}
            {_host = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("host"), out var __jsonHost) ? (string)__jsonHost : (string)_host;}
            {_user = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("user"), out var __jsonUser) ? (string)__jsonUser : (string)_user;}
            {_password = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("password"), out var __jsonPassword) ? new System.Net.NetworkCredential("",(string)__jsonPassword).SecurePassword : _password;}
            {_fromAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("fromAddress"), out var __jsonFromAddress) ? (string)__jsonFromAddress : (string)_fromAddress;}
            {_fromName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("fromName"), out var __jsonFromName) ? (string)__jsonFromName : (string)_fromName;}
            {_startTlsPolicy = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString>("startTLSPolicy"), out var __jsonStartTlsPolicy) ? (string)__jsonStartTlsPolicy : (string)_startTlsPolicy;}
            {_skipVerify = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonBoolean>("skipVerify"), out var __jsonSkipVerify) ? (bool?)__jsonSkipVerify : _skipVerify;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Smtp" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Smtp" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._enabled ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonBoolean((bool)this._enabled) : null, "enabled" ,container.Add );
            AddIf( null != (((object)this._host)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._host.ToString()) : null, "host" ,container.Add );
            AddIf( null != (((object)this._user)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._user.ToString()) : null, "user" ,container.Add );
            AddIf( null != (((object)this._password)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this._password))) : null, "password" ,container.Add );
            AddIf( null != (((object)this._fromAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._fromAddress.ToString()) : null, "fromAddress" ,container.Add );
            AddIf( null != (((object)this._fromName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._fromName.ToString()) : null, "fromName" ,container.Add );
            AddIf( null != (((object)this._startTlsPolicy)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonString(this._startTlsPolicy.ToString()) : null, "startTLSPolicy" ,container.Add );
            AddIf( null != this._skipVerify ? (Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Json.JsonBoolean((bool)this._skipVerify) : null, "skipVerify" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}