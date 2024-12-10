// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Object that includes all the possible response for the download operation.</summary>
    public partial class DownloadResponse
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject into a new instance of <see cref="DownloadResponse" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DownloadResponse(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_compliancePdfReport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject>("compliancePdfReport"), out var __jsonCompliancePdfReport) ? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseCompliancePdfReport.FromJson(__jsonCompliancePdfReport) : _compliancePdfReport;}
            {_complianceDetailedPdfReport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject>("complianceDetailedPdfReport"), out var __jsonComplianceDetailedPdfReport) ? Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.DownloadResponseComplianceDetailedPdfReport.FromJson(__jsonComplianceDetailedPdfReport) : _complianceDetailedPdfReport;}
            {_resourceList = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonArray>("resourceList"), out var __jsonResourceList) ? If( __jsonResourceList as Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem) (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ResourceItem.FromJson(__u) )) ))() : null : _resourceList;}
            {_complianceReport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonArray>("complianceReport"), out var __jsonComplianceReport) ? If( __jsonComplianceReport as Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IComplianceReportItem) (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.ComplianceReportItem.FromJson(__p) )) ))() : null : _complianceReport;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IDownloadResponse FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject json ? new DownloadResponse(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DownloadResponse" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DownloadResponse" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._compliancePdfReport ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) this._compliancePdfReport.ToJson(null,serializationMode) : null, "compliancePdfReport" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._complianceDetailedPdfReport ? (Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.JsonNode) this._complianceDetailedPdfReport.ToJson(null,serializationMode) : null, "complianceDetailedPdfReport" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._resourceList)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.XNodeArray();
                    foreach( var __x in this._resourceList )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("resourceList",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._complianceReport)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Json.XNodeArray();
                    foreach( var __s in this._complianceReport )
                    {
                        AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                    }
                    container.Add("complianceReport",__r);
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}