// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>VMwareToAzStack disk input.</summary>
    public partial class VMwareToAzStackHcidiskInput
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcidiskInput.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcidiskInput.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcidiskInput FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject json ? new VMwareToAzStackHcidiskInput(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMwareToAzStackHcidiskInput" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMwareToAzStackHcidiskInput" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._diskController ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) this._diskController.ToJson(null,serializationMode) : null, "diskController" ,container.Add );
            AddIf( null != (((object)this._diskId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._diskId.ToString()) : null, "diskId" ,container.Add );
            AddIf( null != (((object)this._storageContainerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._storageContainerId.ToString()) : null, "storageContainerId" ,container.Add );
            AddIf( null != this._isDynamic ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonBoolean((bool)this._isDynamic) : null, "isDynamic" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber(this._diskSizeGb), "diskSizeGB" ,container.Add );
            AddIf( null != (((object)this._diskFileFormat)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._diskFileFormat.ToString()) : null, "diskFileFormat" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonBoolean(this._isOSDisk), "isOsDisk" ,container.Add );
            AddIf( null != this._diskBlockSize ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((long)this._diskBlockSize) : null, "diskBlockSize" ,container.Add );
            AddIf( null != this._diskLogicalSectorSize ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((long)this._diskLogicalSectorSize) : null, "diskLogicalSectorSize" ,container.Add );
            AddIf( null != this._diskPhysicalSectorSize ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((long)this._diskPhysicalSectorSize) : null, "diskPhysicalSectorSize" ,container.Add );
            AddIf( null != (((object)this._diskIdentifier)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._diskIdentifier.ToString()) : null, "diskIdentifier" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject into a new instance of <see cref="VMwareToAzStackHcidiskInput" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMwareToAzStackHcidiskInput(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_diskController = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject>("diskController"), out var __jsonDiskController) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.DiskControllerInputs.FromJson(__jsonDiskController) : _diskController;}
            {_diskId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("diskId"), out var __jsonDiskId) ? (string)__jsonDiskId : (string)_diskId;}
            {_storageContainerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("storageContainerId"), out var __jsonStorageContainerId) ? (string)__jsonStorageContainerId : (string)_storageContainerId;}
            {_isDynamic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonBoolean>("isDynamic"), out var __jsonIsDynamic) ? (bool?)__jsonIsDynamic : _isDynamic;}
            {_diskSizeGb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("diskSizeGB"), out var __jsonDiskSizeGb) ? (long)__jsonDiskSizeGb : _diskSizeGb;}
            {_diskFileFormat = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("diskFileFormat"), out var __jsonDiskFileFormat) ? (string)__jsonDiskFileFormat : (string)_diskFileFormat;}
            {_isOSDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonBoolean>("isOsDisk"), out var __jsonIsOSDisk) ? (bool)__jsonIsOSDisk : _isOSDisk;}
            {_diskBlockSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("diskBlockSize"), out var __jsonDiskBlockSize) ? (long?)__jsonDiskBlockSize : _diskBlockSize;}
            {_diskLogicalSectorSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("diskLogicalSectorSize"), out var __jsonDiskLogicalSectorSize) ? (long?)__jsonDiskLogicalSectorSize : _diskLogicalSectorSize;}
            {_diskPhysicalSectorSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("diskPhysicalSectorSize"), out var __jsonDiskPhysicalSectorSize) ? (long?)__jsonDiskPhysicalSectorSize : _diskPhysicalSectorSize;}
            {_diskIdentifier = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("diskIdentifier"), out var __jsonDiskIdentifier) ? (string)__jsonDiskIdentifier : (string)_diskIdentifier;}
            AfterFromJson(json);
        }
    }
}