// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Protected item model properties update.</summary>
    public partial class ProtectedItemModelPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesUpdateInternal
    {

        /// <summary>Backing field for <see cref="CustomProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate _customProperty;

        /// <summary>Protected item model custom properties update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate()); set => this._customProperty = value; }

        /// <summary>Discriminator property for ProtectedItemModelCustomPropertiesUpdate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string CustomPropertyInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)CustomProperty).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdateInternal)CustomProperty).InstanceType = value ?? null; }

        /// <summary>Internal Acessors for CustomProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelPropertiesUpdateInternal.CustomProperty { get => (this._customProperty = this._customProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ProtectedItemModelCustomPropertiesUpdate()); set { {_customProperty = value;} } }

        /// <summary>Creates an new <see cref="ProtectedItemModelPropertiesUpdate" /> instance.</summary>
        public ProtectedItemModelPropertiesUpdate()
        {

        }
    }
    /// Protected item model properties update.
    public partial interface IProtectedItemModelPropertiesUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Discriminator property for ProtectedItemModelCustomPropertiesUpdate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Discriminator property for ProtectedItemModelCustomPropertiesUpdate.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string CustomPropertyInstanceType { get; set; }

    }
    /// Protected item model properties update.
    internal partial interface IProtectedItemModelPropertiesUpdateInternal

    {
        /// <summary>Protected item model custom properties update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IProtectedItemModelCustomPropertiesUpdate CustomProperty { get; set; }
        /// <summary>Discriminator property for ProtectedItemModelCustomPropertiesUpdate.</summary>
        string CustomPropertyInstanceType { get; set; }

    }
}