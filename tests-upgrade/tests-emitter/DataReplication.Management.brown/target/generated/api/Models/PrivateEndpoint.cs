// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>
    /// Represent private Endpoint network resource that is linked to the Private Endpoint connection.
    /// </summary>
    public partial class PrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IPrivateEndpointInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Gets or sets the id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="PrivateEndpoint" /> instance.</summary>
        public PrivateEndpoint()
        {

        }
    }
    /// Represent private Endpoint network resource that is linked to the Private Endpoint connection.
    public partial interface IPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Represent private Endpoint network resource that is linked to the Private Endpoint connection.
    internal partial interface IPrivateEndpointInternal

    {
        /// <summary>Gets or sets the id.</summary>
        string Id { get; set; }

    }
}