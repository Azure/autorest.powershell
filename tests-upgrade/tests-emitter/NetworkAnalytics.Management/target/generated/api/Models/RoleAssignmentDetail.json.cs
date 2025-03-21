// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The details for role assignment response.</summary>
    public partial class RoleAssignmentDetail
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IRoleAssignmentDetail FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json ? new RoleAssignmentDetail(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject into a new instance of <see cref="RoleAssignmentDetail" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal RoleAssignmentDetail(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_roleId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("roleId"), out var __jsonRoleId) ? (string)__jsonRoleId : (string)_roleId;}
            {_principalId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("principalId"), out var __jsonPrincipalId) ? (string)__jsonPrincipalId : (string)_principalId;}
            {_userName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)_userName;}
            {_dataTypeScope = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray>("dataTypeScope"), out var __jsonDataTypeScope) ? If( __jsonDataTypeScope as Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _dataTypeScope;}
            {_principalType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("principalType"), out var __jsonPrincipalType) ? (string)__jsonPrincipalType : (string)_principalType;}
            {_role = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("role"), out var __jsonRole) ? (string)__jsonRole : (string)_role;}
            {_roleAssignmentId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString>("roleAssignmentId"), out var __jsonRoleAssignmentId) ? (string)__jsonRoleAssignmentId : (string)_roleAssignmentId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="RoleAssignmentDetail" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RoleAssignmentDetail" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._roleId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._roleId.ToString()) : null, "roleId" ,container.Add );
            AddIf( null != (((object)this._principalId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._principalId.ToString()) : null, "principalId" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            if (null != this._dataTypeScope)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.XNodeArray();
                foreach( var __x in this._dataTypeScope )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("dataTypeScope",__w);
            }
            AddIf( null != (((object)this._principalType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._principalType.ToString()) : null, "principalType" ,container.Add );
            AddIf( null != (((object)this._role)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._role.ToString()) : null, "role" ,container.Add );
            AddIf( null != (((object)this._roleAssignmentId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Json.JsonString(this._roleAssignmentId.ToString()) : null, "roleAssignmentId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}