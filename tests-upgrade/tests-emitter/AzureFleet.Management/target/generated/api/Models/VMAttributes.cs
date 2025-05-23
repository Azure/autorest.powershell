// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// VMAttributes that will be used to filter VMSizes which will be used to build Fleet.
    /// </summary>
    public partial class VMAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributes,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal
    {

        /// <summary>Backing field for <see cref="AcceleratorCount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger _acceleratorCount;

        /// <summary>
        /// The range of accelerator count specified from min to max. Optional parameter. Either Min or Max is required if specified.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger AcceleratorCount { get => (this._acceleratorCount = this._acceleratorCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set => this._acceleratorCount = value; }

        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? AcceleratorCountMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)AcceleratorCount).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)AcceleratorCount).Max = value ?? default(int); }

        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? AcceleratorCountMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)AcceleratorCount).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)AcceleratorCount).Min = value ?? default(int); }

        /// <summary>Backing field for <see cref="AcceleratorManufacturer" /> property.</summary>
        private System.Collections.Generic.List<string> _acceleratorManufacturer;

        /// <summary>
        /// The accelerator manufacturers specified as a list.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AcceleratorManufacturer { get => this._acceleratorManufacturer; set => this._acceleratorManufacturer = value; }

        /// <summary>Backing field for <see cref="AcceleratorSupport" /> property.</summary>
        private string _acceleratorSupport;

        /// <summary>
        /// Specifies whether the VMSize supporting accelerator should be used to build Fleet or not.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string AcceleratorSupport { get => this._acceleratorSupport; set => this._acceleratorSupport = value; }

        /// <summary>Backing field for <see cref="AcceleratorType" /> property.</summary>
        private System.Collections.Generic.List<string> _acceleratorType;

        /// <summary>
        /// The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AcceleratorType { get => this._acceleratorType; set => this._acceleratorType = value; }

        /// <summary>Backing field for <see cref="ArchitectureType" /> property.</summary>
        private System.Collections.Generic.List<string> _architectureType;

        /// <summary>The VM architecture types specified as a list. Optional parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ArchitectureType { get => this._architectureType; set => this._architectureType = value; }

        /// <summary>Backing field for <see cref="BurstableSupport" /> property.</summary>
        private string _burstableSupport;

        /// <summary>
        /// Specifies whether the VMSize supporting burstable capability should be used to build Fleet or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string BurstableSupport { get => this._burstableSupport; set => this._burstableSupport = value; }

        /// <summary>Backing field for <see cref="CpuManufacturer" /> property.</summary>
        private System.Collections.Generic.List<string> _cpuManufacturer;

        /// <summary>The VM CPU manufacturers specified as a list. Optional parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> CpuManufacturer { get => this._cpuManufacturer; set => this._cpuManufacturer = value; }

        /// <summary>Backing field for <see cref="DataDiskCount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger _dataDiskCount;

        /// <summary>
        /// The range of data disk count specified from Min to Max. Optional parameter. Either Min or Max is required if specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger DataDiskCount { get => (this._dataDiskCount = this._dataDiskCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set => this._dataDiskCount = value; }

        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? DataDiskCountMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)DataDiskCount).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)DataDiskCount).Max = value ?? default(int); }

        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? DataDiskCountMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)DataDiskCount).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)DataDiskCount).Min = value ?? default(int); }

        /// <summary>Backing field for <see cref="ExcludedVMSize" /> property.</summary>
        private System.Collections.Generic.List<string> _excludedVMSize;

        /// <summary>
        /// Specifies which VMSizes should be excluded while building Fleet. Optional parameter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ExcludedVMSize { get => this._excludedVMSize; set => this._excludedVMSize = value; }

        /// <summary>Backing field for <see cref="LocalStorageDiskType" /> property.</summary>
        private System.Collections.Generic.List<string> _localStorageDiskType;

        /// <summary>
        /// The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use
        /// this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> LocalStorageDiskType { get => this._localStorageDiskType; set => this._localStorageDiskType = value; }

        /// <summary>Backing field for <see cref="LocalStorageInGiB" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble _localStorageInGiB;

        /// <summary>
        /// LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble LocalStorageInGiB { get => (this._localStorageInGiB = this._localStorageInGiB ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set => this._localStorageInGiB = value; }

        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? LocalStorageInGiBMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)LocalStorageInGiB).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)LocalStorageInGiB).Max = value ?? default(double); }

        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? LocalStorageInGiBMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)LocalStorageInGiB).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)LocalStorageInGiB).Min = value ?? default(double); }

        /// <summary>Backing field for <see cref="LocalStorageSupport" /> property.</summary>
        private string _localStorageSupport;

        /// <summary>
        /// Specifies whether the VMSize supporting local storage should be used to build Fleet or not.
        /// Included - Default if not specified as most Azure VMs support local storage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string LocalStorageSupport { get => this._localStorageSupport; set => this._localStorageSupport = value; }

        /// <summary>Backing field for <see cref="MemoryInGiB" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble _memoryInGiB;

        /// <summary>
        /// The range of memory specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required
        /// if specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble MemoryInGiB { get => (this._memoryInGiB = this._memoryInGiB ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set => this._memoryInGiB = value; }

        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? MemoryInGiBMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiB).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiB).Max = value ?? default(double); }

        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? MemoryInGiBMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiB).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiB).Min = value ?? default(double); }

        /// <summary>Backing field for <see cref="MemoryInGiBPerVcpu" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble _memoryInGiBPerVcpu;

        /// <summary>
        /// The range of memory in GiB per vCPU specified from min to max. Optional parameter. Either Min or Max is required if specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble MemoryInGiBPerVcpu { get => (this._memoryInGiBPerVcpu = this._memoryInGiBPerVcpu ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set => this._memoryInGiBPerVcpu = value; }

        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? MemoryInGiBPerVcpuMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiBPerVcpu).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiBPerVcpu).Max = value ?? default(double); }

        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? MemoryInGiBPerVcpuMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiBPerVcpu).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)MemoryInGiBPerVcpu).Min = value ?? default(double); }

        /// <summary>Internal Acessors for AcceleratorCount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.AcceleratorCount { get => (this._acceleratorCount = this._acceleratorCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set { {_acceleratorCount = value;} } }

        /// <summary>Internal Acessors for DataDiskCount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.DataDiskCount { get => (this._dataDiskCount = this._dataDiskCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set { {_dataDiskCount = value;} } }

        /// <summary>Internal Acessors for LocalStorageInGiB</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.LocalStorageInGiB { get => (this._localStorageInGiB = this._localStorageInGiB ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set { {_localStorageInGiB = value;} } }

        /// <summary>Internal Acessors for MemoryInGiB</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.MemoryInGiB { get => (this._memoryInGiB = this._memoryInGiB ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set { {_memoryInGiB = value;} } }

        /// <summary>Internal Acessors for MemoryInGiBPerVcpu</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.MemoryInGiBPerVcpu { get => (this._memoryInGiBPerVcpu = this._memoryInGiBPerVcpu ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set { {_memoryInGiBPerVcpu = value;} } }

        /// <summary>Internal Acessors for NetworkBandwidthInMbps</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.NetworkBandwidthInMbps { get => (this._networkBandwidthInMbps = this._networkBandwidthInMbps ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set { {_networkBandwidthInMbps = value;} } }

        /// <summary>Internal Acessors for NetworkInterfaceCount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.NetworkInterfaceCount { get => (this._networkInterfaceCount = this._networkInterfaceCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set { {_networkInterfaceCount = value;} } }

        /// <summary>Internal Acessors for RdmaNetworkInterfaceCount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.RdmaNetworkInterfaceCount { get => (this._rdmaNetworkInterfaceCount = this._rdmaNetworkInterfaceCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set { {_rdmaNetworkInterfaceCount = value;} } }

        /// <summary>Internal Acessors for VCpuCount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributesInternal.VCpuCount { get => (this._vCpuCount = this._vCpuCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set { {_vCpuCount = value;} } }

        /// <summary>Backing field for <see cref="NetworkBandwidthInMbps" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble _networkBandwidthInMbps;

        /// <summary>
        /// The range of network bandwidth in Mbps specified from Min to Max. Optional parameter. Either Min or Max is required if
        /// specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble NetworkBandwidthInMbps { get => (this._networkBandwidthInMbps = this._networkBandwidthInMbps ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxDouble()); set => this._networkBandwidthInMbps = value; }

        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? NetworkBandwidthInMbpsMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)NetworkBandwidthInMbps).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)NetworkBandwidthInMbps).Max = value ?? default(double); }

        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public double? NetworkBandwidthInMbpsMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)NetworkBandwidthInMbps).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDoubleInternal)NetworkBandwidthInMbps).Min = value ?? default(double); }

        /// <summary>Backing field for <see cref="NetworkInterfaceCount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger _networkInterfaceCount;

        /// <summary>
        /// The range of network interface count specified from Min to Max. Optional parameter. Either Min or Max is required if specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger NetworkInterfaceCount { get => (this._networkInterfaceCount = this._networkInterfaceCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set => this._networkInterfaceCount = value; }

        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? NetworkInterfaceCountMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)NetworkInterfaceCount).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)NetworkInterfaceCount).Max = value ?? default(int); }

        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? NetworkInterfaceCountMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)NetworkInterfaceCount).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)NetworkInterfaceCount).Min = value ?? default(int); }

        /// <summary>Backing field for <see cref="RdmaNetworkInterfaceCount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger _rdmaNetworkInterfaceCount;

        /// <summary>
        /// The range of RDMA (Remote Direct Memory Access) network interface count specified from Min to Max. Optional parameter.
        /// Either Min or Max is required if specified.
        /// rdmaSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If rdmaSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger RdmaNetworkInterfaceCount { get => (this._rdmaNetworkInterfaceCount = this._rdmaNetworkInterfaceCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set => this._rdmaNetworkInterfaceCount = value; }

        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? RdmaNetworkInterfaceCountMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)RdmaNetworkInterfaceCount).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)RdmaNetworkInterfaceCount).Max = value ?? default(int); }

        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? RdmaNetworkInterfaceCountMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)RdmaNetworkInterfaceCount).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)RdmaNetworkInterfaceCount).Min = value ?? default(int); }

        /// <summary>Backing field for <see cref="RdmaSupport" /> property.</summary>
        private string _rdmaSupport;

        /// <summary>
        /// Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build Fleet or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string RdmaSupport { get => this._rdmaSupport; set => this._rdmaSupport = value; }

        /// <summary>Backing field for <see cref="VCpuCount" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger _vCpuCount;

        /// <summary>
        /// The range of vCpuCount specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is
        /// required if specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger VCpuCount { get => (this._vCpuCount = this._vCpuCount ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VMAttributeMinMaxInteger()); set => this._vCpuCount = value; }

        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? VCpuCountMax { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)VCpuCount).Max; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)VCpuCount).Max = value ?? default(int); }

        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Inlined)]
        public int? VCpuCountMin { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)VCpuCount).Min; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxIntegerInternal)VCpuCount).Min = value ?? default(int); }

        /// <summary>Backing field for <see cref="VMCategory" /> property.</summary>
        private System.Collections.Generic.List<string> _vMCategory;

        /// <summary>The VM category specified as a list. Optional parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> VMCategory { get => this._vMCategory; set => this._vMCategory = value; }

        /// <summary>Creates an new <see cref="VMAttributes" /> instance.</summary>
        public VMAttributes()
        {

        }
    }
    /// VMAttributes that will be used to filter VMSizes which will be used to build Fleet.
    public partial interface IVMAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? AcceleratorCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? AcceleratorCountMin { get; set; }
        /// <summary>
        /// The accelerator manufacturers specified as a list.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The accelerator manufacturers specified as a list.
        acceleratorSupport should be set to ""Included"" or ""Required"" to use this VMAttribute.
        If acceleratorSupport is ""Excluded"", this VMAttribute can not be used.",
        SerializedName = @"acceleratorManufacturers",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("AMD", "Nvidia", "Xilinx")]
        System.Collections.Generic.List<string> AcceleratorManufacturer { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting accelerator should be used to build Fleet or not.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the VMSize supporting accelerator should be used to build Fleet or not.
        acceleratorSupport should be set to ""Included"" or ""Required"" to use this VMAttribute.
        If acceleratorSupport is ""Excluded"", this VMAttribute can not be used.",
        SerializedName = @"acceleratorSupport",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string AcceleratorSupport { get; set; }
        /// <summary>
        /// The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The accelerator types specified as a list. acceleratorSupport should be set to ""Included"" or ""Required"" to use this VMAttribute.
        If acceleratorSupport is ""Excluded"", this VMAttribute can not be used.",
        SerializedName = @"acceleratorTypes",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("GPU", "FPGA")]
        System.Collections.Generic.List<string> AcceleratorType { get; set; }
        /// <summary>The VM architecture types specified as a list. Optional parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VM architecture types specified as a list. Optional parameter.",
        SerializedName = @"architectureTypes",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ARM64", "X64")]
        System.Collections.Generic.List<string> ArchitectureType { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting burstable capability should be used to build Fleet or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the VMSize supporting burstable capability should be used to build Fleet or not.",
        SerializedName = @"burstableSupport",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string BurstableSupport { get; set; }
        /// <summary>The VM CPU manufacturers specified as a list. Optional parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VM CPU manufacturers specified as a list. Optional parameter.",
        SerializedName = @"cpuManufacturers",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Intel", "AMD", "Microsoft", "Ampere")]
        System.Collections.Generic.List<string> CpuManufacturer { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? DataDiskCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? DataDiskCountMin { get; set; }
        /// <summary>
        /// Specifies which VMSizes should be excluded while building Fleet. Optional parameter.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies which VMSizes should be excluded while building Fleet. Optional parameter.",
        SerializedName = @"excludedVMSizes",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ExcludedVMSize { get; set; }
        /// <summary>
        /// The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use
        /// this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The local storage disk types specified as a list. LocalStorageSupport should be set to ""Included"" or ""Required"" to use this VMAttribute.
        If localStorageSupport is ""Excluded"", this VMAttribute can not be used.",
        SerializedName = @"localStorageDiskTypes",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("HDD", "SSD")]
        System.Collections.Generic.List<string> LocalStorageDiskType { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum value. Double.MaxValue(1.7976931348623157E+308)",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(double) })]
        double? LocalStorageInGiBMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum value. default 0. Double.MinValue()",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(double) })]
        double? LocalStorageInGiBMin { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting local storage should be used to build Fleet or not.
        /// Included - Default if not specified as most Azure VMs support local storage.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the VMSize supporting local storage should be used to build Fleet or not.
        Included - Default if not specified as most Azure VMs support local storage.",
        SerializedName = @"localStorageSupport",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string LocalStorageSupport { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum value. Double.MaxValue(1.7976931348623157E+308)",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(double) })]
        double? MemoryInGiBMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum value. default 0. Double.MinValue()",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(double) })]
        double? MemoryInGiBMin { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum value. Double.MaxValue(1.7976931348623157E+308)",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(double) })]
        double? MemoryInGiBPerVcpuMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum value. default 0. Double.MinValue()",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(double) })]
        double? MemoryInGiBPerVcpuMin { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum value. Double.MaxValue(1.7976931348623157E+308)",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(double) })]
        double? NetworkBandwidthInMbpsMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Minimum value. default 0. Double.MinValue()",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(double) })]
        double? NetworkBandwidthInMbpsMin { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? NetworkInterfaceCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? NetworkInterfaceCountMin { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? RdmaNetworkInterfaceCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? RdmaNetworkInterfaceCountMin { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build Fleet or not.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build Fleet or not.",
        SerializedName = @"rdmaSupport",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string RdmaSupport { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.",
        SerializedName = @"max",
        PossibleTypes = new [] { typeof(int) })]
        int? VCpuCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.",
        SerializedName = @"min",
        PossibleTypes = new [] { typeof(int) })]
        int? VCpuCountMin { get; set; }
        /// <summary>The VM category specified as a list. Optional parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VM category specified as a list. Optional parameter.",
        SerializedName = @"vmCategories",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("GeneralPurpose", "ComputeOptimized", "MemoryOptimized", "StorageOptimized", "GpuAccelerated", "FpgaAccelerated", "HighPerformanceCompute")]
        System.Collections.Generic.List<string> VMCategory { get; set; }

    }
    /// VMAttributes that will be used to filter VMSizes which will be used to build Fleet.
    internal partial interface IVMAttributesInternal

    {
        /// <summary>
        /// The range of accelerator count specified from min to max. Optional parameter. Either Min or Max is required if specified.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger AcceleratorCount { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        int? AcceleratorCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        int? AcceleratorCountMin { get; set; }
        /// <summary>
        /// The accelerator manufacturers specified as a list.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("AMD", "Nvidia", "Xilinx")]
        System.Collections.Generic.List<string> AcceleratorManufacturer { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting accelerator should be used to build Fleet or not.
        /// acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string AcceleratorSupport { get; set; }
        /// <summary>
        /// The accelerator types specified as a list. acceleratorSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If acceleratorSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("GPU", "FPGA")]
        System.Collections.Generic.List<string> AcceleratorType { get; set; }
        /// <summary>The VM architecture types specified as a list. Optional parameter.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("ARM64", "X64")]
        System.Collections.Generic.List<string> ArchitectureType { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting burstable capability should be used to build Fleet or not.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string BurstableSupport { get; set; }
        /// <summary>The VM CPU manufacturers specified as a list. Optional parameter.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Intel", "AMD", "Microsoft", "Ampere")]
        System.Collections.Generic.List<string> CpuManufacturer { get; set; }
        /// <summary>
        /// The range of data disk count specified from Min to Max. Optional parameter. Either Min or Max is required if specified.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger DataDiskCount { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        int? DataDiskCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        int? DataDiskCountMin { get; set; }
        /// <summary>
        /// Specifies which VMSizes should be excluded while building Fleet. Optional parameter.
        /// </summary>
        System.Collections.Generic.List<string> ExcludedVMSize { get; set; }
        /// <summary>
        /// The local storage disk types specified as a list. LocalStorageSupport should be set to "Included" or "Required" to use
        /// this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("HDD", "SSD")]
        System.Collections.Generic.List<string> LocalStorageDiskType { get; set; }
        /// <summary>
        /// LocalStorageSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If localStorageSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble LocalStorageInGiB { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        double? LocalStorageInGiBMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        double? LocalStorageInGiBMin { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting local storage should be used to build Fleet or not.
        /// Included - Default if not specified as most Azure VMs support local storage.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string LocalStorageSupport { get; set; }
        /// <summary>
        /// The range of memory specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is required
        /// if specified.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble MemoryInGiB { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        double? MemoryInGiBMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        double? MemoryInGiBMin { get; set; }
        /// <summary>
        /// The range of memory in GiB per vCPU specified from min to max. Optional parameter. Either Min or Max is required if specified.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble MemoryInGiBPerVcpu { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        double? MemoryInGiBPerVcpuMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        double? MemoryInGiBPerVcpuMin { get; set; }
        /// <summary>
        /// The range of network bandwidth in Mbps specified from Min to Max. Optional parameter. Either Min or Max is required if
        /// specified.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxDouble NetworkBandwidthInMbps { get; set; }
        /// <summary>Maximum value. Double.MaxValue(1.7976931348623157E+308)</summary>
        double? NetworkBandwidthInMbpsMax { get; set; }
        /// <summary>Minimum value. default 0. Double.MinValue()</summary>
        double? NetworkBandwidthInMbpsMin { get; set; }
        /// <summary>
        /// The range of network interface count specified from Min to Max. Optional parameter. Either Min or Max is required if specified.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger NetworkInterfaceCount { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        int? NetworkInterfaceCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        int? NetworkInterfaceCountMin { get; set; }
        /// <summary>
        /// The range of RDMA (Remote Direct Memory Access) network interface count specified from Min to Max. Optional parameter.
        /// Either Min or Max is required if specified.
        /// rdmaSupport should be set to "Included" or "Required" to use this VMAttribute.
        /// If rdmaSupport is "Excluded", this VMAttribute can not be used.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger RdmaNetworkInterfaceCount { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        int? RdmaNetworkInterfaceCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        int? RdmaNetworkInterfaceCountMin { get; set; }
        /// <summary>
        /// Specifies whether the VMSize supporting RDMA (Remote Direct Memory Access) should be used to build Fleet or not.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("Excluded", "Included", "Required")]
        string RdmaSupport { get; set; }
        /// <summary>
        /// The range of vCpuCount specified from Min to Max. Must be specified if VMAttributes are specified, either Min or Max is
        /// required if specified.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMAttributeMinMaxInteger VCpuCount { get; set; }
        /// <summary>Max VMSize from CRS, Max = 4294967295 (uint.MaxValue) if not specified.</summary>
        int? VCpuCountMax { get; set; }
        /// <summary>Min VMSize from CRS, Min = 0 (uint.MinValue) if not specified.</summary>
        int? VCpuCountMin { get; set; }
        /// <summary>The VM category specified as a list. Optional parameter.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PSArgumentCompleterAttribute("GeneralPurpose", "ComputeOptimized", "MemoryOptimized", "StorageOptimized", "GpuAccelerated", "FpgaAccelerated", "HighPerformanceCompute")]
        System.Collections.Generic.List<string> VMCategory { get; set; }

    }
}