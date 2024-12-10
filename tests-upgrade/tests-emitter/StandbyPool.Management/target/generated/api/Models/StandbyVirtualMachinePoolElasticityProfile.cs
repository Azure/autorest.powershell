// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the elasticity profile.</summary>
    public partial class StandbyVirtualMachinePoolElasticityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyVirtualMachinePoolElasticityProfileInternal
    {

        /// <summary>Backing field for <see cref="MaxReadyCapacity" /> property.</summary>
        private long _maxReadyCapacity;

        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long MaxReadyCapacity { get => this._maxReadyCapacity; set => this._maxReadyCapacity = value; }

        /// <summary>Backing field for <see cref="MinReadyCapacity" /> property.</summary>
        private long? _minReadyCapacity;

        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long? MinReadyCapacity { get => this._minReadyCapacity; set => this._minReadyCapacity = value; }

        /// <summary>
        /// Creates an new <see cref="StandbyVirtualMachinePoolElasticityProfile" /> instance.
        /// </summary>
        public StandbyVirtualMachinePoolElasticityProfile()
        {

        }
    }
    /// Details of the elasticity profile.
    public partial interface IStandbyVirtualMachinePoolElasticityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the maximum number of virtual machines in the standby virtual machine pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long MaxReadyCapacity { get; set; }
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
        long? MinReadyCapacity { get; set; }

    }
    /// Details of the elasticity profile.
    internal partial interface IStandbyVirtualMachinePoolElasticityProfileInternal

    {
        /// <summary>
        /// Specifies the maximum number of virtual machines in the standby virtual machine pool.
        /// </summary>
        long MaxReadyCapacity { get; set; }
        /// <summary>
        /// Specifies the desired minimum number of virtual machines in the standby virtual machine pool. MinReadyCapacity cannot
        /// exceed MaxReadyCapacity.
        /// </summary>
        long? MinReadyCapacity { get; set; }

    }
}