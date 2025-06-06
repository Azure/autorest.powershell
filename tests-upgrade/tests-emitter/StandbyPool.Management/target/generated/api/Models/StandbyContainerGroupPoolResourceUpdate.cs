// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>The type used for update operations of the StandbyContainerGroupPoolResource.</summary>
    public partial class StandbyContainerGroupPoolResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal
    {

        /// <summary>Specifies container group profile id of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ContainerGroupProfileId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupProfileId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupProfileId = value ?? null; }

        /// <summary>Specifies revision of container group profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ContainerGroupProfileRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupProfileRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupProfileRevision = value ?? default(long); }

        /// <summary>Specifies subnet Ids for container group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> ContainerGroupPropertySubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupPropertySubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupPropertySubnetId = value ?? null /* arrayOf */; }

        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ElasticityProfileMaxReadyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ElasticityProfileMaxReadyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ElasticityProfileMaxReadyCapacity = value ?? default(long); }

        /// <summary>Specifies refill policy of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ElasticityProfileRefillPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ElasticityProfileRefillPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ElasticityProfileRefillPolicy = value ?? null; }

        /// <summary>Internal Acessors for ContainerGroupProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal.ContainerGroupProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupProperty = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ContainerGroupPropertyContainerGroupProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal.ContainerGroupPropertyContainerGroupProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupPropertyContainerGroupProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ContainerGroupPropertyContainerGroupProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for ElasticityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal.ElasticityProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ElasticityProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).ElasticityProfile = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolResourceUpdateProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.Tags()); set => this._tag = value; }

        /// <summary>Specifies zones of standby container group pools.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> Zone { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdatePropertiesInternal)Property).Zone = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="StandbyContainerGroupPoolResourceUpdate" /> instance.</summary>
        public StandbyContainerGroupPoolResourceUpdate()
        {

        }
    }
    /// The type used for update operations of the StandbyContainerGroupPoolResource.
    public partial interface IStandbyContainerGroupPoolResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Specifies container group profile id of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> ContainerGroupPropertySubnetId { get; set; }
        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies maximum number of standby container groups in the standby pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>Specifies refill policy of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies refill policy of the pool.",
        SerializedName = @"refillPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("always")]
        string ElasticityProfileRefillPolicy { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags Tag { get; set; }
        /// <summary>Specifies zones of standby container group pools.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies zones of standby container group pools.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Zone { get; set; }

    }
    /// The type used for update operations of the StandbyContainerGroupPoolResource.
    internal partial interface IStandbyContainerGroupPoolResourceUpdateInternal

    {
        /// <summary>Specifies container group profile id of standby container groups.</summary>
        string ContainerGroupProfileId { get; set; }
        /// <summary>Specifies revision of container group profile.</summary>
        long? ContainerGroupProfileRevision { get; set; }
        /// <summary>Specifies container group properties of standby container group pools.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties ContainerGroupProperty { get; set; }
        /// <summary>Specifies container group profile of standby container groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile ContainerGroupPropertyContainerGroupProfile { get; set; }
        /// <summary>Specifies subnet Ids for container group.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> ContainerGroupPropertySubnetId { get; set; }
        /// <summary>Specifies elasticity profile of standby container group pools.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile ElasticityProfile { get; set; }
        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        long? ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>Specifies refill policy of the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("always")]
        string ElasticityProfileRefillPolicy { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceUpdateProperties Property { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ITags Tag { get; set; }
        /// <summary>Specifies zones of standby container group pools.</summary>
        System.Collections.Generic.List<string> Zone { get; set; }

    }
}