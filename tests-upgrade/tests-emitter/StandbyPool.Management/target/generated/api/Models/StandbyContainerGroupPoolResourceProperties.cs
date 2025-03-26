// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the StandbyContainerGroupPool.</summary>
    public partial class StandbyContainerGroupPoolResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourcePropertiesInternal
    {

        /// <summary>Specifies container group profile id of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ContainerGroupProfileId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).ContainerGroupProfileId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).ContainerGroupProfileId = value ; }

        /// <summary>Specifies revision of container group profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long? ContainerGroupProfileRevision { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).ContainerGroupProfileRevision; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).ContainerGroupProfileRevision = value ?? default(long); }

        /// <summary>Backing field for <see cref="ContainerGroupProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties _containerGroupProperty;

        /// <summary>Specifies container group properties of standby container group pools.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties ContainerGroupProperty { get => (this._containerGroupProperty = this._containerGroupProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProperties()); set => this._containerGroupProperty = value; }

        /// <summary>Specifies subnet Ids for container group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> ContainerGroupPropertySubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).SubnetId = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ElasticityProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile _elasticityProfile;

        /// <summary>Specifies elasticity profile of standby container group pools.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile ElasticityProfile { get => (this._elasticityProfile = this._elasticityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolElasticityProfile()); set => this._elasticityProfile = value; }

        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public long ElasticityProfileMaxReadyCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfileInternal)ElasticityProfile).MaxReadyCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfileInternal)ElasticityProfile).MaxReadyCapacity = value ; }

        /// <summary>Specifies refill policy of the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Inlined)]
        public string ElasticityProfileRefillPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfileInternal)ElasticityProfile).RefillPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfileInternal)ElasticityProfile).RefillPolicy = value ?? null; }

        /// <summary>Internal Acessors for ContainerGroupProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProperties Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourcePropertiesInternal.ContainerGroupProperty { get => (this._containerGroupProperty = this._containerGroupProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ContainerGroupProperties()); set { {_containerGroupProperty = value;} } }

        /// <summary>Internal Acessors for ContainerGroupPropertyContainerGroupProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourcePropertiesInternal.ContainerGroupPropertyContainerGroupProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).ContainerGroupProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupPropertiesInternal)ContainerGroupProperty).ContainerGroupProfile = value; }

        /// <summary>Internal Acessors for ElasticityProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolElasticityProfile Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourcePropertiesInternal.ElasticityProfile { get => (this._elasticityProfile = this._elasticityProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.StandbyContainerGroupPoolElasticityProfile()); set { {_elasticityProfile = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IStandbyContainerGroupPoolResourcePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private System.Collections.Generic.List<string> _zone;

        /// <summary>Specifies zones of standby container group pools.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Zone { get => this._zone; set => this._zone = value; }

        /// <summary>
        /// Creates an new <see cref="StandbyContainerGroupPoolResourceProperties" /> instance.
        /// </summary>
        public StandbyContainerGroupPoolResourceProperties()
        {

        }
    }
    /// Details of the StandbyContainerGroupPool.
    public partial interface IStandbyContainerGroupPoolResourceProperties :
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
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet> ContainerGroupPropertySubnetId { get; set; }
        /// <summary>Specifies maximum number of standby container groups in the standby pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies maximum number of standby container groups in the standby pool.",
        SerializedName = @"maxReadyCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long ElasticityProfileMaxReadyCapacity { get; set; }
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
        /// <summary>The status of the last operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the last operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get;  }
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
    /// Details of the StandbyContainerGroupPool.
    internal partial interface IStandbyContainerGroupPoolResourcePropertiesInternal

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
        long ElasticityProfileMaxReadyCapacity { get; set; }
        /// <summary>Specifies refill policy of the pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("always")]
        string ElasticityProfileRefillPolicy { get; set; }
        /// <summary>The status of the last operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Deleting")]
        string ProvisioningState { get; set; }
        /// <summary>Specifies zones of standby container group pools.</summary>
        System.Collections.Generic.List<string> Zone { get; set; }

    }
}