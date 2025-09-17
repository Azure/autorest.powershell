// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Fabric agent model custom properties.</summary>
    public partial class FabricAgentModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomPropertiesInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Discriminator property for FabricAgentModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="FabricAgentModelCustomProperties" /> instance.</summary>
        public FabricAgentModelCustomProperties()
        {

        }
    }
    /// Fabric agent model custom properties.
    public partial interface IFabricAgentModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Discriminator property for FabricAgentModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for FabricAgentModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Fabric agent model custom properties.
    internal partial interface IFabricAgentModelCustomPropertiesInternal

    {
        /// <summary>Discriminator property for FabricAgentModelCustomProperties.</summary>
        string InstanceType { get; set; }

    }
}