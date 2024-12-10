// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the service artifact reference id used to set same image version for
    /// all virtual machines in the scale set when using 'latest' image version.
    /// Minimum api-version: 2022-11-01
    /// </summary>
    public partial class ServiceArtifactReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IServiceArtifactReference,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IServiceArtifactReferenceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>
        /// The service artifact reference id in the form of
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="ServiceArtifactReference" /> instance.</summary>
        public ServiceArtifactReference()
        {

        }
    }
    /// Specifies the service artifact reference id used to set same image version for
    /// all virtual machines in the scale set when using 'latest' image version.
    /// Minimum api-version: 2022-11-01
    public partial interface IServiceArtifactReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The service artifact reference id in the form of
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The service artifact reference id in the form of
        /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Specifies the service artifact reference id used to set same image version for
    /// all virtual machines in the scale set when using 'latest' image version.
    /// Minimum api-version: 2022-11-01
    internal partial interface IServiceArtifactReferenceInternal

    {
        /// <summary>
        /// The service artifact reference id in the form of
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Compute/galleries/{galleryName}/serviceArtifacts/{serviceArtifactName}/vmArtifactsProfiles/{vmArtifactsProfilesName}
        /// </summary>
        string Id { get; set; }

    }
}