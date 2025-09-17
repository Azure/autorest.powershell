// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>HyperV to AzStackHCI Protected item model custom properties.</summary>
    public partial class HyperVToAzStackHciprotectedItemModelCustomProperties
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedItemModelCustomProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject json ? new HyperVToAzStackHciprotectedItemModelCustomProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject into a new instance of <see cref="HyperVToAzStackHciprotectedItemModelCustomProperties"
        /// />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal HyperVToAzStackHciprotectedItemModelCustomProperties(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            __protectedItemModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomProperties(json);
            {_dynamicMemoryConfig = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject>("dynamicMemoryConfig"), out var __jsonDynamicMemoryConfig) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig.FromJson(__jsonDynamicMemoryConfig) : _dynamicMemoryConfig;}
            {_activeLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("activeLocation"), out var __jsonActiveLocation) ? (string)__jsonActiveLocation : (string)_activeLocation;}
            {_targetHciClusterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetHciClusterId"), out var __jsonTargetHciClusterId) ? (string)__jsonTargetHciClusterId : (string)_targetHciClusterId;}
            {_targetArcClusterCustomLocationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetArcClusterCustomLocationId"), out var __jsonTargetArcClusterCustomLocationId) ? (string)__jsonTargetArcClusterCustomLocationId : (string)_targetArcClusterCustomLocationId;}
            {_targetAzStackHciClusterName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetAzStackHciClusterName"), out var __jsonTargetAzStackHciClusterName) ? (string)__jsonTargetAzStackHciClusterName : (string)_targetAzStackHciClusterName;}
            {_fabricDiscoveryMachineId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("fabricDiscoveryMachineId"), out var __jsonFabricDiscoveryMachineId) ? (string)__jsonFabricDiscoveryMachineId : (string)_fabricDiscoveryMachineId;}
            {_disksToInclude = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray>("disksToInclude"), out var __jsonDisksToInclude) ? If( __jsonDisksToInclude as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcidiskInput>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcidiskInput) (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcidiskInput.FromJson(__u) )) ))() : null : _disksToInclude;}
            {_nicsToInclude = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray>("nicsToInclude"), out var __jsonNicsToInclude) ? If( __jsonNicsToInclude as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHcinicInput) (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHcinicInput.FromJson(__p) )) ))() : null : _nicsToInclude;}
            {_sourceVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("sourceVmName"), out var __jsonSourceVMName) ? (string)__jsonSourceVMName : (string)_sourceVMName;}
            {_sourceCpuCore = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("sourceCpuCores"), out var __jsonSourceCpuCores) ? (int?)__jsonSourceCpuCores : _sourceCpuCore;}
            {_sourceMemoryInMegaByte = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("sourceMemoryInMegaBytes"), out var __jsonSourceMemoryInMegaBytes) ? (double?)__jsonSourceMemoryInMegaBytes : _sourceMemoryInMegaByte;}
            {_targetVMName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetVmName"), out var __jsonTargetVMName) ? (string)__jsonTargetVMName : (string)_targetVMName;}
            {_targetResourceGroupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetResourceGroupId"), out var __jsonTargetResourceGroupId) ? (string)__jsonTargetResourceGroupId : (string)_targetResourceGroupId;}
            {_storageContainerId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("storageContainerId"), out var __jsonStorageContainerId) ? (string)__jsonStorageContainerId : (string)_storageContainerId;}
            {_hyperVGeneration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("hyperVGeneration"), out var __jsonHyperVGeneration) ? (string)__jsonHyperVGeneration : (string)_hyperVGeneration;}
            {_targetNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetNetworkId"), out var __jsonTargetNetworkId) ? (string)__jsonTargetNetworkId : (string)_targetNetworkId;}
            {_testNetworkId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("testNetworkId"), out var __jsonTestNetworkId) ? (string)__jsonTestNetworkId : (string)_testNetworkId;}
            {_targetCpuCore = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("targetCpuCores"), out var __jsonTargetCpuCores) ? (int?)__jsonTargetCpuCores : _targetCpuCore;}
            {_isDynamicRam = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonBoolean>("isDynamicRam"), out var __jsonIsDynamicRam) ? (bool?)__jsonIsDynamicRam : _isDynamicRam;}
            {_targetMemoryInMegaByte = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("targetMemoryInMegaBytes"), out var __jsonTargetMemoryInMegaBytes) ? (int?)__jsonTargetMemoryInMegaBytes : _targetMemoryInMegaByte;}
            {_runAsAccountId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("runAsAccountId"), out var __jsonRunAsAccountId) ? (string)__jsonRunAsAccountId : (string)_runAsAccountId;}
            {_sourceFabricAgentName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("sourceFabricAgentName"), out var __jsonSourceFabricAgentName) ? (string)__jsonSourceFabricAgentName : (string)_sourceFabricAgentName;}
            {_targetFabricAgentName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetFabricAgentName"), out var __jsonTargetFabricAgentName) ? (string)__jsonTargetFabricAgentName : (string)_targetFabricAgentName;}
            {_sourceApplianceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("sourceApplianceName"), out var __jsonSourceApplianceName) ? (string)__jsonSourceApplianceName : (string)_sourceApplianceName;}
            {_targetApplianceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetApplianceName"), out var __jsonTargetApplianceName) ? (string)__jsonTargetApplianceName : (string)_targetApplianceName;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)_oSType;}
            {_oSName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("osName"), out var __jsonOSName) ? (string)__jsonOSName : (string)_oSName;}
            {_firmwareType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("firmwareType"), out var __jsonFirmwareType) ? (string)__jsonFirmwareType : (string)_firmwareType;}
            {_targetLocation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetLocation"), out var __jsonTargetLocation) ? (string)__jsonTargetLocation : (string)_targetLocation;}
            {_customLocationRegion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("customLocationRegion"), out var __jsonCustomLocationRegion) ? (string)__jsonCustomLocationRegion : (string)_customLocationRegion;}
            {_failoverRecoveryPointId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("failoverRecoveryPointId"), out var __jsonFailoverRecoveryPointId) ? (string)__jsonFailoverRecoveryPointId : (string)_failoverRecoveryPointId;}
            {_lastRecoveryPointReceived = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("lastRecoveryPointReceived"), out var __jsonLastRecoveryPointReceived) ? global::System.DateTime.TryParse((string)__jsonLastRecoveryPointReceived, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastRecoveryPointReceivedValue) ? __jsonLastRecoveryPointReceivedValue : _lastRecoveryPointReceived : _lastRecoveryPointReceived;}
            {_lastRecoveryPointId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("lastRecoveryPointId"), out var __jsonLastRecoveryPointId) ? (string)__jsonLastRecoveryPointId : (string)_lastRecoveryPointId;}
            {_initialReplicationProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("initialReplicationProgressPercentage"), out var __jsonInitialReplicationProgressPercentage) ? (int?)__jsonInitialReplicationProgressPercentage : _initialReplicationProgressPercentage;}
            {_resyncProgressPercentage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber>("resyncProgressPercentage"), out var __jsonResyncProgressPercentage) ? (int?)__jsonResyncProgressPercentage : _resyncProgressPercentage;}
            {_protectedDisk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray>("protectedDisks"), out var __jsonProtectedDisks) ? If( __jsonProtectedDisks as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedDiskProperties>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedDiskProperties) (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedDiskProperties.FromJson(__k) )) ))() : null : _protectedDisk;}
            {_protectedNic = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray>("protectedNics"), out var __jsonProtectedNics) ? If( __jsonProtectedNics as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedNicProperties>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__g, (__f)=>(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IHyperVToAzStackHciprotectedNicProperties) (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.HyperVToAzStackHciprotectedNicProperties.FromJson(__f) )) ))() : null : _protectedNic;}
            {_targetVMBiosId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("targetVmBiosId"), out var __jsonTargetVMBiosId) ? (string)__jsonTargetVMBiosId : (string)_targetVMBiosId;}
            {_lastReplicationUpdateTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString>("lastReplicationUpdateTime"), out var __jsonLastReplicationUpdateTime) ? global::System.DateTime.TryParse((string)__jsonLastReplicationUpdateTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastReplicationUpdateTimeValue) ? __jsonLastReplicationUpdateTimeValue : _lastReplicationUpdateTime : _lastReplicationUpdateTime;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="HyperVToAzStackHciprotectedItemModelCustomProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="HyperVToAzStackHciprotectedItemModelCustomProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode"
        /// />.
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
            __protectedItemModelCustomProperties?.ToJson(container, serializationMode);
            AddIf( null != this._dynamicMemoryConfig ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) this._dynamicMemoryConfig.ToJson(null,serializationMode) : null, "dynamicMemoryConfig" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._activeLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._activeLocation.ToString()) : null, "activeLocation" ,container.Add );
            }
            AddIf( null != (((object)this._targetHciClusterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetHciClusterId.ToString()) : null, "targetHciClusterId" ,container.Add );
            AddIf( null != (((object)this._targetArcClusterCustomLocationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetArcClusterCustomLocationId.ToString()) : null, "targetArcClusterCustomLocationId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._targetAzStackHciClusterName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetAzStackHciClusterName.ToString()) : null, "targetAzStackHciClusterName" ,container.Add );
            }
            AddIf( null != (((object)this._fabricDiscoveryMachineId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._fabricDiscoveryMachineId.ToString()) : null, "fabricDiscoveryMachineId" ,container.Add );
            if (null != this._disksToInclude)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.XNodeArray();
                foreach( var __x in this._disksToInclude )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("disksToInclude",__w);
            }
            if (null != this._nicsToInclude)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.XNodeArray();
                foreach( var __s in this._nicsToInclude )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("nicsToInclude",__r);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._sourceVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._sourceVMName.ToString()) : null, "sourceVmName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._sourceCpuCore ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((int)this._sourceCpuCore) : null, "sourceCpuCores" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._sourceMemoryInMegaByte ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((double)this._sourceMemoryInMegaByte) : null, "sourceMemoryInMegaBytes" ,container.Add );
            }
            AddIf( null != (((object)this._targetVMName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetVMName.ToString()) : null, "targetVmName" ,container.Add );
            AddIf( null != (((object)this._targetResourceGroupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetResourceGroupId.ToString()) : null, "targetResourceGroupId" ,container.Add );
            AddIf( null != (((object)this._storageContainerId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._storageContainerId.ToString()) : null, "storageContainerId" ,container.Add );
            AddIf( null != (((object)this._hyperVGeneration)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._hyperVGeneration.ToString()) : null, "hyperVGeneration" ,container.Add );
            AddIf( null != (((object)this._targetNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetNetworkId.ToString()) : null, "targetNetworkId" ,container.Add );
            AddIf( null != (((object)this._testNetworkId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._testNetworkId.ToString()) : null, "testNetworkId" ,container.Add );
            AddIf( null != this._targetCpuCore ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((int)this._targetCpuCore) : null, "targetCpuCores" ,container.Add );
            AddIf( null != this._isDynamicRam ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonBoolean((bool)this._isDynamicRam) : null, "isDynamicRam" ,container.Add );
            AddIf( null != this._targetMemoryInMegaByte ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((int)this._targetMemoryInMegaByte) : null, "targetMemoryInMegaBytes" ,container.Add );
            AddIf( null != (((object)this._runAsAccountId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._runAsAccountId.ToString()) : null, "runAsAccountId" ,container.Add );
            AddIf( null != (((object)this._sourceFabricAgentName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._sourceFabricAgentName.ToString()) : null, "sourceFabricAgentName" ,container.Add );
            AddIf( null != (((object)this._targetFabricAgentName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetFabricAgentName.ToString()) : null, "targetFabricAgentName" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._sourceApplianceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._sourceApplianceName.ToString()) : null, "sourceApplianceName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._targetApplianceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetApplianceName.ToString()) : null, "targetApplianceName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._oSName.ToString()) : null, "osName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._firmwareType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._firmwareType.ToString()) : null, "firmwareType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._targetLocation)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetLocation.ToString()) : null, "targetLocation" ,container.Add );
            }
            AddIf( null != (((object)this._customLocationRegion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._customLocationRegion.ToString()) : null, "customLocationRegion" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._failoverRecoveryPointId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._failoverRecoveryPointId.ToString()) : null, "failoverRecoveryPointId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastRecoveryPointReceived ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._lastRecoveryPointReceived?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastRecoveryPointReceived" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastRecoveryPointId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._lastRecoveryPointId.ToString()) : null, "lastRecoveryPointId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._initialReplicationProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((int)this._initialReplicationProgressPercentage) : null, "initialReplicationProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._resyncProgressPercentage ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNumber((int)this._resyncProgressPercentage) : null, "resyncProgressPercentage" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._protectedDisk)
                {
                    var __m = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.XNodeArray();
                    foreach( var __n in this._protectedDisk )
                    {
                        AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                    }
                    container.Add("protectedDisks",__m);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._protectedNic)
                {
                    var __h = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.XNodeArray();
                    foreach( var __i in this._protectedNic )
                    {
                        AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                    }
                    container.Add("protectedNics",__h);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._targetVMBiosId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._targetVMBiosId.ToString()) : null, "targetVmBiosId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._lastReplicationUpdateTime ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Json.JsonString(this._lastReplicationUpdateTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastReplicationUpdateTime" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}