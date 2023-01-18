// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Sysctl settings for Linux agent nodes.
    /// </summary>
    public partial class SysctlConfig
    {
        /// <summary>
        /// Initializes a new instance of the SysctlConfig class.
        /// </summary>
        public SysctlConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SysctlConfig class.
        /// </summary>
        /// <param name="netCoreSomaxconn">Sysctl setting
        /// net.core.somaxconn.</param>
        /// <param name="netCoreNetdevMaxBacklog">Sysctl setting
        /// net.core.netdev_max_backlog.</param>
        /// <param name="netCoreRmemDefault">Sysctl setting
        /// net.core.rmem_default.</param>
        /// <param name="netCoreRmemMax">Sysctl setting
        /// net.core.rmem_max.</param>
        /// <param name="netCoreWmemDefault">Sysctl setting
        /// net.core.wmem_default.</param>
        /// <param name="netCoreWmemMax">Sysctl setting
        /// net.core.wmem_max.</param>
        /// <param name="netCoreOptmemMax">Sysctl setting
        /// net.core.optmem_max.</param>
        /// <param name="netIpv4TcpMaxSynBacklog">Sysctl setting
        /// net.ipv4.tcp_max_syn_backlog.</param>
        /// <param name="netIpv4TcpMaxTwBuckets">Sysctl setting
        /// net.ipv4.tcp_max_tw_buckets.</param>
        /// <param name="netIpv4TcpFinTimeout">Sysctl setting
        /// net.ipv4.tcp_fin_timeout.</param>
        /// <param name="netIpv4TcpKeepaliveTime">Sysctl setting
        /// net.ipv4.tcp_keepalive_time.</param>
        /// <param name="netIpv4TcpKeepaliveProbes">Sysctl setting
        /// net.ipv4.tcp_keepalive_probes.</param>
        /// <param name="netIpv4TcpkeepaliveIntvl">Sysctl setting
        /// net.ipv4.tcp_keepalive_intvl.</param>
        /// <param name="netIpv4TcpTwReuse">Sysctl setting
        /// net.ipv4.tcp_tw_reuse.</param>
        /// <param name="netIpv4IPLocalPortRange">Sysctl setting
        /// net.ipv4.ip_local_port_range.</param>
        /// <param name="netIpv4NeighDefaultGcThresh1">Sysctl setting
        /// net.ipv4.neigh.default.gc_thresh1.</param>
        /// <param name="netIpv4NeighDefaultGcThresh2">Sysctl setting
        /// net.ipv4.neigh.default.gc_thresh2.</param>
        /// <param name="netIpv4NeighDefaultGcThresh3">Sysctl setting
        /// net.ipv4.neigh.default.gc_thresh3.</param>
        /// <param name="netNetfilterNfConntrackMax">Sysctl setting
        /// net.netfilter.nf_conntrack_max.</param>
        /// <param name="netNetfilterNfConntrackBuckets">Sysctl setting
        /// net.netfilter.nf_conntrack_buckets.</param>
        /// <param name="fsInotifyMaxUserWatches">Sysctl setting
        /// fs.inotify.max_user_watches.</param>
        /// <param name="fsFileMax">Sysctl setting fs.file-max.</param>
        /// <param name="fsAioMaxNr">Sysctl setting fs.aio-max-nr.</param>
        /// <param name="fsNrOpen">Sysctl setting fs.nr_open.</param>
        /// <param name="kernelThreadsMax">Sysctl setting
        /// kernel.threads-max.</param>
        /// <param name="vmMaxMapCount">Sysctl setting
        /// vm.max_map_count.</param>
        /// <param name="vmSwappiness">Sysctl setting vm.swappiness.</param>
        /// <param name="vmVfsCachePressure">Sysctl setting
        /// vm.vfs_cache_pressure.</param>
        public SysctlConfig(int? netCoreSomaxconn = default(int?), int? netCoreNetdevMaxBacklog = default(int?), int? netCoreRmemDefault = default(int?), int? netCoreRmemMax = default(int?), int? netCoreWmemDefault = default(int?), int? netCoreWmemMax = default(int?), int? netCoreOptmemMax = default(int?), int? netIpv4TcpMaxSynBacklog = default(int?), int? netIpv4TcpMaxTwBuckets = default(int?), int? netIpv4TcpFinTimeout = default(int?), int? netIpv4TcpKeepaliveTime = default(int?), int? netIpv4TcpKeepaliveProbes = default(int?), int? netIpv4TcpkeepaliveIntvl = default(int?), bool? netIpv4TcpTwReuse = default(bool?), string netIpv4IPLocalPortRange = default(string), int? netIpv4NeighDefaultGcThresh1 = default(int?), int? netIpv4NeighDefaultGcThresh2 = default(int?), int? netIpv4NeighDefaultGcThresh3 = default(int?), int? netNetfilterNfConntrackMax = default(int?), int? netNetfilterNfConntrackBuckets = default(int?), int? fsInotifyMaxUserWatches = default(int?), int? fsFileMax = default(int?), int? fsAioMaxNr = default(int?), int? fsNrOpen = default(int?), int? kernelThreadsMax = default(int?), int? vmMaxMapCount = default(int?), int? vmSwappiness = default(int?), int? vmVfsCachePressure = default(int?))
        {
            this.NetCoreSomaxconn = netCoreSomaxconn;
            this.NetCoreNetdevMaxBacklog = netCoreNetdevMaxBacklog;
            this.NetCoreRmemDefault = netCoreRmemDefault;
            this.NetCoreRmemMax = netCoreRmemMax;
            this.NetCoreWmemDefault = netCoreWmemDefault;
            this.NetCoreWmemMax = netCoreWmemMax;
            this.NetCoreOptmemMax = netCoreOptmemMax;
            this.NetIpv4TcpMaxSynBacklog = netIpv4TcpMaxSynBacklog;
            this.NetIpv4TcpMaxTwBuckets = netIpv4TcpMaxTwBuckets;
            this.NetIpv4TcpFinTimeout = netIpv4TcpFinTimeout;
            this.NetIpv4TcpKeepaliveTime = netIpv4TcpKeepaliveTime;
            this.NetIpv4TcpKeepaliveProbes = netIpv4TcpKeepaliveProbes;
            this.NetIpv4TcpkeepaliveIntvl = netIpv4TcpkeepaliveIntvl;
            this.NetIpv4TcpTwReuse = netIpv4TcpTwReuse;
            this.NetIpv4IPLocalPortRange = netIpv4IPLocalPortRange;
            this.NetIpv4NeighDefaultGcThresh1 = netIpv4NeighDefaultGcThresh1;
            this.NetIpv4NeighDefaultGcThresh2 = netIpv4NeighDefaultGcThresh2;
            this.NetIpv4NeighDefaultGcThresh3 = netIpv4NeighDefaultGcThresh3;
            this.NetNetfilterNfConntrackMax = netNetfilterNfConntrackMax;
            this.NetNetfilterNfConntrackBuckets = netNetfilterNfConntrackBuckets;
            this.FsInotifyMaxUserWatches = fsInotifyMaxUserWatches;
            this.FsFileMax = fsFileMax;
            this.FsAioMaxNr = fsAioMaxNr;
            this.FsNrOpen = fsNrOpen;
            this.KernelThreadsMax = kernelThreadsMax;
            this.VMMaxMapCount = vmMaxMapCount;
            this.VMSwappiness = vmSwappiness;
            this.VMVfsCachePressure = vmVfsCachePressure;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sysctl setting net.core.somaxconn.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreSomaxconn")]
        public int? NetCoreSomaxconn { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.core.netdev_max_backlog.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreNetdevMaxBacklog")]
        public int? NetCoreNetdevMaxBacklog { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.core.rmem_default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreRmemDefault")]
        public int? NetCoreRmemDefault { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.core.rmem_max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreRmemMax")]
        public int? NetCoreRmemMax { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.core.wmem_default.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreWmemDefault")]
        public int? NetCoreWmemDefault { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.core.wmem_max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreWmemMax")]
        public int? NetCoreWmemMax { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.core.optmem_max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netCoreOptmemMax")]
        public int? NetCoreOptmemMax { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_max_syn_backlog.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpMaxSynBacklog")]
        public int? NetIpv4TcpMaxSynBacklog { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_max_tw_buckets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpMaxTwBuckets")]
        public int? NetIpv4TcpMaxTwBuckets { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_fin_timeout.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpFinTimeout")]
        public int? NetIpv4TcpFinTimeout { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_keepalive_time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpKeepaliveTime")]
        public int? NetIpv4TcpKeepaliveTime { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_keepalive_probes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpKeepaliveProbes")]
        public int? NetIpv4TcpKeepaliveProbes { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_keepalive_intvl.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpkeepaliveIntvl")]
        public int? NetIpv4TcpkeepaliveIntvl { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.tcp_tw_reuse.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4TcpTwReuse")]
        public bool? NetIpv4TcpTwReuse { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.ip_local_port_range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4IpLocalPortRange")]
        public string NetIpv4IPLocalPortRange { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.neigh.default.gc_thresh1.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4NeighDefaultGcThresh1")]
        public int? NetIpv4NeighDefaultGcThresh1 { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.neigh.default.gc_thresh2.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4NeighDefaultGcThresh2")]
        public int? NetIpv4NeighDefaultGcThresh2 { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.ipv4.neigh.default.gc_thresh3.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netIpv4NeighDefaultGcThresh3")]
        public int? NetIpv4NeighDefaultGcThresh3 { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.netfilter.nf_conntrack_max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netNetfilterNfConntrackMax")]
        public int? NetNetfilterNfConntrackMax { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting net.netfilter.nf_conntrack_buckets.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "netNetfilterNfConntrackBuckets")]
        public int? NetNetfilterNfConntrackBuckets { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting fs.inotify.max_user_watches.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fsInotifyMaxUserWatches")]
        public int? FsInotifyMaxUserWatches { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting fs.file-max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fsFileMax")]
        public int? FsFileMax { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting fs.aio-max-nr.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fsAioMaxNr")]
        public int? FsAioMaxNr { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting fs.nr_open.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fsNrOpen")]
        public int? FsNrOpen { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting kernel.threads-max.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kernelThreadsMax")]
        public int? KernelThreadsMax { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting vm.max_map_count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmMaxMapCount")]
        public int? VMMaxMapCount { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting vm.swappiness.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSwappiness")]
        public int? VMSwappiness { get; set; }

        /// <summary>
        /// Gets or sets sysctl setting vm.vfs_cache_pressure.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmVfsCachePressure")]
        public int? VMVfsCachePressure { get; set; }

    }
}
