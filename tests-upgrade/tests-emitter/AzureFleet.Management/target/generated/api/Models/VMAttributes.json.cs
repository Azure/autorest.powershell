// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// VMAttributes that will be used to filter VMSizes which will be used to build Fleet.
    /// </summary>
    public partial class VMAttributes
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json ? new VMAttributes(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VMAttributes" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VMAttributes" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._vCpuCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._vCpuCount.ToJson(null,serializationMode) : null, "vCpuCount" ,container.Add );
            AddIf( null != this._memoryInGiB ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._memoryInGiB.ToJson(null,serializationMode) : null, "memoryInGiB" ,container.Add );
            AddIf( null != this._memoryInGiBPerVcpu ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._memoryInGiBPerVcpu.ToJson(null,serializationMode) : null, "memoryInGiBPerVCpu" ,container.Add );
            AddIf( null != this._localStorageInGiB ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._localStorageInGiB.ToJson(null,serializationMode) : null, "localStorageInGiB" ,container.Add );
            AddIf( null != this._dataDiskCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._dataDiskCount.ToJson(null,serializationMode) : null, "dataDiskCount" ,container.Add );
            AddIf( null != this._networkInterfaceCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._networkInterfaceCount.ToJson(null,serializationMode) : null, "networkInterfaceCount" ,container.Add );
            AddIf( null != this._networkBandwidthInMbps ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._networkBandwidthInMbps.ToJson(null,serializationMode) : null, "networkBandwidthInMbps" ,container.Add );
            AddIf( null != this._rdmaNetworkInterfaceCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._rdmaNetworkInterfaceCount.ToJson(null,serializationMode) : null, "rdmaNetworkInterfaceCount" ,container.Add );
            AddIf( null != this._acceleratorCount ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._acceleratorCount.ToJson(null,serializationMode) : null, "acceleratorCount" ,container.Add );
            AddIf( null != (((object)this._localStorageSupport)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._localStorageSupport.ToString()) : null, "localStorageSupport" ,container.Add );
            if (null != this._localStorageDiskType)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __x in this._localStorageDiskType )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("localStorageDiskTypes",__w);
            }
            AddIf( null != (((object)this._rdmaSupport)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._rdmaSupport.ToString()) : null, "rdmaSupport" ,container.Add );
            AddIf( null != (((object)this._acceleratorSupport)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._acceleratorSupport.ToString()) : null, "acceleratorSupport" ,container.Add );
            if (null != this._acceleratorManufacturer)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __s in this._acceleratorManufacturer )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("acceleratorManufacturers",__r);
            }
            if (null != this._acceleratorType)
            {
                var __m = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __n in this._acceleratorType )
                {
                    AddIf(null != (((object)__n)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(__n.ToString()) : null ,__m.Add);
                }
                container.Add("acceleratorTypes",__m);
            }
            if (null != this._vMCategory)
            {
                var __h = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __i in this._vMCategory )
                {
                    AddIf(null != (((object)__i)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(__i.ToString()) : null ,__h.Add);
                }
                container.Add("vmCategories",__h);
            }
            if (null != this._architectureType)
            {
                var __c = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __d in this._architectureType )
                {
                    AddIf(null != (((object)__d)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(__d.ToString()) : null ,__c.Add);
                }
                container.Add("architectureTypes",__c);
            }
            if (null != this._cpuManufacturer)
            {
                var ___x = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var ___y in this._cpuManufacturer )
                {
                    AddIf(null != (((object)___y)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(___y.ToString()) : null ,___x.Add);
                }
                container.Add("cpuManufacturers",___x);
            }
            AddIf( null != (((object)this._burstableSupport)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._burstableSupport.ToString()) : null, "burstableSupport" ,container.Add );
            if (null != this._excludedVMSize)
            {
                var ___s = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var ___t in this._excludedVMSize )
                {
                    AddIf(null != (((object)___t)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(___t.ToString()) : null ,___s.Add);
                }
                container.Add("excludedVMSizes",___s);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject into a new instance of <see cref="VMAttributes" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VMAttributes(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_vCpuCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("vCpuCount"), out var __jsonVCpuCount) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger.FromJson(__jsonVCpuCount) : _vCpuCount;}
            {_memoryInGiB = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("memoryInGiB"), out var __jsonMemoryInGiB) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble.FromJson(__jsonMemoryInGiB) : _memoryInGiB;}
            {_memoryInGiBPerVcpu = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("memoryInGiBPerVCpu"), out var __jsonMemoryInGiBPerVcpu) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble.FromJson(__jsonMemoryInGiBPerVcpu) : _memoryInGiBPerVcpu;}
            {_localStorageInGiB = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("localStorageInGiB"), out var __jsonLocalStorageInGiB) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble.FromJson(__jsonLocalStorageInGiB) : _localStorageInGiB;}
            {_dataDiskCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("dataDiskCount"), out var __jsonDataDiskCount) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger.FromJson(__jsonDataDiskCount) : _dataDiskCount;}
            {_networkInterfaceCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("networkInterfaceCount"), out var __jsonNetworkInterfaceCount) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger.FromJson(__jsonNetworkInterfaceCount) : _networkInterfaceCount;}
            {_networkBandwidthInMbps = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("networkBandwidthInMbps"), out var __jsonNetworkBandwidthInMbps) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble.FromJson(__jsonNetworkBandwidthInMbps) : _networkBandwidthInMbps;}
            {_rdmaNetworkInterfaceCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("rdmaNetworkInterfaceCount"), out var __jsonRdmaNetworkInterfaceCount) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger.FromJson(__jsonRdmaNetworkInterfaceCount) : _rdmaNetworkInterfaceCount;}
            {_acceleratorCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("acceleratorCount"), out var __jsonAcceleratorCount) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger.FromJson(__jsonAcceleratorCount) : _acceleratorCount;}
            {_localStorageSupport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("localStorageSupport"), out var __jsonLocalStorageSupport) ? (string)__jsonLocalStorageSupport : (string)_localStorageSupport;}
            {_localStorageDiskType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("localStorageDiskTypes"), out var __jsonLocalStorageDiskTypes) ? If( __jsonLocalStorageDiskTypes as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _localStorageDiskType;}
            {_rdmaSupport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("rdmaSupport"), out var __jsonRdmaSupport) ? (string)__jsonRdmaSupport : (string)_rdmaSupport;}
            {_acceleratorSupport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("acceleratorSupport"), out var __jsonAcceleratorSupport) ? (string)__jsonAcceleratorSupport : (string)_acceleratorSupport;}
            {_acceleratorManufacturer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("acceleratorManufacturers"), out var __jsonAcceleratorManufacturers) ? If( __jsonAcceleratorManufacturers as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : _acceleratorManufacturer;}
            {_acceleratorType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("acceleratorTypes"), out var __jsonAcceleratorTypes) ? If( __jsonAcceleratorTypes as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(string) (__k is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString __j ? (string)(__j.ToString()) : null)) ))() : null : _acceleratorType;}
            {_vMCategory = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("vmCategories"), out var __jsonVMCategories) ? If( __jsonVMCategories as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__g, (__f)=>(string) (__f is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString __e ? (string)(__e.ToString()) : null)) ))() : null : _vMCategory;}
            {_architectureType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("architectureTypes"), out var __jsonArchitectureTypes) ? If( __jsonArchitectureTypes as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__b, (__a)=>(string) (__a is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString ___z ? (string)(___z.ToString()) : null)) ))() : null : _architectureType;}
            {_cpuManufacturer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("cpuManufacturers"), out var __jsonCpuManufacturers) ? If( __jsonCpuManufacturers as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var ___w) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___w, (___v)=>(string) (___v is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString ___u ? (string)(___u.ToString()) : null)) ))() : null : _cpuManufacturer;}
            {_burstableSupport = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("burstableSupport"), out var __jsonBurstableSupport) ? (string)__jsonBurstableSupport : (string)_burstableSupport;}
            {_excludedVMSize = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("excludedVMSizes"), out var __jsonExcludedVMSizes) ? If( __jsonExcludedVMSizes as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var ___r) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(___r, (___q)=>(string) (___q is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString ___p ? (string)(___p.ToString()) : null)) ))() : null : _excludedVMSize;}
            AfterFromJson(json);
        }
    }
}