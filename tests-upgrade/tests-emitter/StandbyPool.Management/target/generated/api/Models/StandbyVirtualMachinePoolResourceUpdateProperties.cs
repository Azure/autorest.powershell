// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>The updatable properties of the StandbyVirtualMachinePoolResource.</summary>
    public partial class StandbyVirtualMachinePoolResourceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AttachedVirtualMachineScaleSetId" /> property.</summary>
        private string _attachedVirtualMachineScaleSetId;

        /// <summary>
        /// Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string AttachedVirtualMachineScaleSetId { get => this._attachedVirtualMachineScaleSetId; set => this._attachedVirtualMachineScaleSetId = value; }

        /// <summary>Backing field for <see cref="ElasticityProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile _elasticityProfile;

        /// <summary>Specifies the elasticity profile of the standby virtual machine pools.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile ElasticityProfile { get => (this._elasticityProfile = this._elasticityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolElasticityProfile()); set => this._elasticityProfile = value; }

        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ElasticityProfileMaxReadyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfileInternal)ElasticityProfile).MaxReadyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfileInternal)ElasticityProfile).MaxReadyCapacity = value ?? default(long); }

        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ElasticityProfileMinReadyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfileInternal)ElasticityProfile).MinReadyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfileInternal)ElasticityProfile).MinReadyCapacity = value ?? default(long); }

        /// <summary>Internal Acessors for ElasticityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal.ElasticityProfile { get => (this._elasticityProfile = this._elasticityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyVirtualMachinePoolElasticityProfile()); set { {_elasticityProfile = value;} } }

        /// <summary>Backing field for <see cref="VirtualMachineState" /> property.</summary>
        private string _virtualMachineState;

        /// <summary>Specifies the desired state of virtual machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string VirtualMachineState { get => this._virtualMachineState; set => this._virtualMachineState = value; }

        /// <summary>
        /// Creates an new <see cref="StandbyVirtualMachinePoolResourceUpdateProperties" /> instance.
        /// </summary>
        public StandbyVirtualMachinePoolResourceUpdateProperties()
        {

        }
    }
    /// The updatable properties of the StandbyVirtualMachinePoolResource.
    public partial interface IStandbyVirtualMachinePoolResourceUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.",
        SerializedName = @"attachedVirtualMachineScaleSetId",
        PossibleTypes = new [] { typeof(string) })]
        string AttachedVirtualMachineScaleSetId { get; set; }
        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the maximum number of virtual machines in the standby virtual machine pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot exceed MaxReadyCapacity.",
        SerializedName = @"minReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? ElasticityProfileMinReadyCapacity { get; set; }
        /// <summary>Specifies the desired state of virtual machines in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the desired state of virtual machines in the pool.",
        SerializedName = @"virtualMachineState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Running", "Deallocated")]
        string VirtualMachineState { get; set; }

    }
    /// The updatable properties of the StandbyVirtualMachinePoolResource.
    internal partial interface IStandbyVirtualMachinePoolResourceUpdatePropertiesInternal

    {
        /// <summary>
        /// Specifies the fully qualified resource ID of a virtual machine scale set the pool is attached to.
        /// </summary>
        string AttachedVirtualMachineScaleSetId { get; set; }
        /// <summary>Specifies the elasticity profile of the standby virtual machine pools.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile ElasticityProfile { get; set; }
        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        long? ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        long? ElasticityProfileMinReadyCapacity { get; set; }
        /// <summary>Specifies the desired state of virtual machines in the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Running", "Deallocated")]
        string VirtualMachineState { get; set; }

    }
}