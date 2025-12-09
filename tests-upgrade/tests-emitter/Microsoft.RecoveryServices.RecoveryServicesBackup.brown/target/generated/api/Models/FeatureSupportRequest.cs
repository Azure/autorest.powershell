// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Base class for feature request</summary>
    public partial class FeatureSupportRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequestInternal
    {

        /// <summary>Backing field for <see cref="FeatureType" /> property.</summary>
        private string _featureType;

        /// <summary>backup support feature type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string FeatureType { get => this._featureType; set => this._featureType = value; }

        /// <summary>Creates an new <see cref="FeatureSupportRequest" /> instance.</summary>
        public FeatureSupportRequest()
        {

        }
    }
    /// Base class for feature request
    public partial interface IFeatureSupportRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>backup support feature type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"backup support feature type.",
        SerializedName = @"featureType",
        PossibleTypes = new [] { typeof(string) })]
        string FeatureType { get; set; }

    }
    /// Base class for feature request
    internal partial interface IFeatureSupportRequestInternal

    {
        /// <summary>backup support feature type.</summary>
        string FeatureType { get; set; }

    }
}