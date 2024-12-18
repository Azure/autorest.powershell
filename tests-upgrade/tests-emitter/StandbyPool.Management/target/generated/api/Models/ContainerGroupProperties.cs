// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the ContainerGroupProperties.</summary>
    public partial class ContainerGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ContainerGroupProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile _containerGroupProfile;

        /// <summary>Specifies container group profile of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile ContainerGroupProfile { get => (this._containerGroupProfile = this._containerGroupProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProfile()); set => this._containerGroupProfile = value; }

        /// <summary>Specifies container group profile id of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ContainerGroupProfileId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfileInternal)ContainerGroupProfile).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfileInternal)ContainerGroupProfile).Id = value ; }

        /// <summary>Specifies revision of container group profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ContainerGroupProfileRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfileInternal)ContainerGroupProfile).Revision; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfileInternal)ContainerGroupProfile).Revision = value ?? default(long); }

        /// <summary>Internal Acessors for ContainerGroupProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal.ContainerGroupProfile { get => (this._containerGroupProfile = this._containerGroupProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProfile()); set { {_containerGroupProfile = value;} } }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> _subnetId;

        /// <summary>Specifies subnet Ids for container group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Creates an new <see cref="ContainerGroupProperties" /> instance.</summary>
        public ContainerGroupProperties()
        {

        }
    }
    /// Details of the ContainerGroupProperties.
    public partial interface IContainerGroupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Specifies container group profile id of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies container group profile id of standby container groups.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ContainerGroupProfileId { get; set; }
        /// <summary>Specifies revision of container group profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies revision of container group profile.",
        SerializedName = @"revision",
        PossibleTypes = new [] { typeof(long) })]
        long? ContainerGroupProfileRevision { get; set; }
        /// <summary>Specifies subnet Ids for container group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies subnet Ids for container group.",
        SerializedName = @"subnetIds",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> SubnetId { get; set; }

    }
    /// Details of the ContainerGroupProperties.
    internal partial interface IContainerGroupPropertiesInternal

    {
        /// <summary>Specifies container group profile of standby container groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile ContainerGroupProfile { get; set; }
        /// <summary>Specifies container group profile id of standby container groups.</summary>
        string ContainerGroupProfileId { get; set; }
        /// <summary>Specifies revision of container group profile.</summary>
        long? ContainerGroupProfileRevision { get; set; }
        /// <summary>Specifies subnet Ids for container group.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> SubnetId { get; set; }

    }
}