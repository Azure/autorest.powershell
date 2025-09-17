// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>VMware to AzStackHCI Protected item model custom properties.</summary>
    public partial class VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate __protectedItemModelCustomPropertiesUpdate = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate();

        /// <summary>Backing field for <see cref="DynamicMemoryConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig _dynamicMemoryConfig;

        /// <summary>Protected item dynamic memory config.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get => (this._dynamicMemoryConfig = this._dynamicMemoryConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig()); set => this._dynamicMemoryConfig = value; }

        /// <summary>Gets or sets maximum memory in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public long? DynamicMemoryConfigMaximumMemoryInMegaByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfigInternal)DynamicMemoryConfig).MaximumMemoryInMegaByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfigInternal)DynamicMemoryConfig).MaximumMemoryInMegaByte = value ?? default(long); }

        /// <summary>Gets or sets minimum memory in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public long? DynamicMemoryConfigMinimumMemoryInMegaByte { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfigInternal)DynamicMemoryConfig).MinimumMemoryInMegaByte; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfigInternal)DynamicMemoryConfig).MinimumMemoryInMegaByte = value ?? default(long); }

        /// <summary>Gets or sets target memory buffer in %.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public int? DynamicMemoryConfigTargetMemoryBufferPercentage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfigInternal)DynamicMemoryConfig).TargetMemoryBufferPercentage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfigInternal)DynamicMemoryConfig).TargetMemoryBufferPercentage = value ?? default(int); }

        /// <summary>Discriminator property for ProtectedItemModelCustomPropertiesUpdate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string InstanceType { get => "VMwareToAzStackHCI"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)__protectedItemModelCustomPropertiesUpdate).InstanceType = "VMwareToAzStackHCI"; }

        /// <summary>Backing field for <see cref="IsDynamicRam" /> property.</summary>
        private bool? _isDynamicRam;

        /// <summary>Gets or sets a value indicating whether memory is dynamical.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public bool? IsDynamicRam { get => this._isDynamicRam; set => this._isDynamicRam = value; }

        /// <summary>Internal Acessors for DynamicMemoryConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal.DynamicMemoryConfig { get => (this._dynamicMemoryConfig = this._dynamicMemoryConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemDynamicMemoryConfig()); set { {_dynamicMemoryConfig = value;} } }

        /// <summary>Backing field for <see cref="NicsToInclude" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInput> _nicsToInclude;

        /// <summary>Gets or sets the list of VM NIC to replicate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInput> NicsToInclude { get => this._nicsToInclude; set => this._nicsToInclude = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>Gets or sets the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="TargetCpuCore" /> property.</summary>
        private int? _targetCpuCore;

        /// <summary>Gets or sets the target CPU cores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public int? TargetCpuCore { get => this._targetCpuCore; set => this._targetCpuCore = value; }

        /// <summary>Backing field for <see cref="TargetMemoryInMegaByte" /> property.</summary>
        private int? _targetMemoryInMegaByte;

        /// <summary>Gets or sets the target memory in mega-bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public int? TargetMemoryInMegaByte { get => this._targetMemoryInMegaByte; set => this._targetMemoryInMegaByte = value; }

        /// <summary>
        /// Creates an new <see cref="VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate" /> instance.
        /// </summary>
        public VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate()
        {
            this.__protectedItemModelCustomPropertiesUpdate.InstanceType = "VMwareToAzStackHCI";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__protectedItemModelCustomPropertiesUpdate), __protectedItemModelCustomPropertiesUpdate);
            await eventListener.AssertObjectIsValid(nameof(__protectedItemModelCustomPropertiesUpdate), __protectedItemModelCustomPropertiesUpdate);
        }
    }
    /// VMware to AzStackHCI Protected item model custom properties.
    public partial interface IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate
    {
        /// <summary>Gets or sets maximum memory in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets maximum memory in MB.",
        SerializedName = @"maximumMemoryInMegaBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? DynamicMemoryConfigMaximumMemoryInMegaByte { get; set; }
        /// <summary>Gets or sets minimum memory in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets minimum memory in MB.",
        SerializedName = @"minimumMemoryInMegaBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? DynamicMemoryConfigMinimumMemoryInMegaByte { get; set; }
        /// <summary>Gets or sets target memory buffer in %.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets target memory buffer in %.",
        SerializedName = @"targetMemoryBufferPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? DynamicMemoryConfigTargetMemoryBufferPercentage { get; set; }
        /// <summary>Gets or sets a value indicating whether memory is dynamical.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets a value indicating whether memory is dynamical.",
        SerializedName = @"isDynamicRam",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDynamicRam { get; set; }
        /// <summary>Gets or sets the list of VM NIC to replicate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of VM NIC to replicate.",
        SerializedName = @"nicsToInclude",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInput) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInput> NicsToInclude { get; set; }
        /// <summary>Gets or sets the type of the OS.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the type of the OS.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>Gets or sets the target CPU cores.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the target CPU cores.",
        SerializedName = @"targetCpuCores",
        PossibleTypes = new [] { typeof(int) })]
        int? TargetCpuCore { get; set; }
        /// <summary>Gets or sets the target memory in mega-bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the target memory in mega-bytes.",
        SerializedName = @"targetMemoryInMegaBytes",
        PossibleTypes = new [] { typeof(int) })]
        int? TargetMemoryInMegaByte { get; set; }

    }
    /// VMware to AzStackHCI Protected item model custom properties.
    internal partial interface IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal
    {
        /// <summary>Protected item dynamic memory config.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemDynamicMemoryConfig DynamicMemoryConfig { get; set; }
        /// <summary>Gets or sets maximum memory in MB.</summary>
        long? DynamicMemoryConfigMaximumMemoryInMegaByte { get; set; }
        /// <summary>Gets or sets minimum memory in MB.</summary>
        long? DynamicMemoryConfigMinimumMemoryInMegaByte { get; set; }
        /// <summary>Gets or sets target memory buffer in %.</summary>
        int? DynamicMemoryConfigTargetMemoryBufferPercentage { get; set; }
        /// <summary>Gets or sets a value indicating whether memory is dynamical.</summary>
        bool? IsDynamicRam { get; set; }
        /// <summary>Gets or sets the list of VM NIC to replicate.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareToAzStackHcinicInput> NicsToInclude { get; set; }
        /// <summary>Gets or sets the type of the OS.</summary>
        string OSType { get; set; }
        /// <summary>Gets or sets the target CPU cores.</summary>
        int? TargetCpuCore { get; set; }
        /// <summary>Gets or sets the target memory in mega-bytes.</summary>
        int? TargetMemoryInMegaByte { get; set; }

    }
}