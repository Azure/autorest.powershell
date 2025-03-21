// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Extensions;

    public partial class EdgeZonesIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IEdgeZonesIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IEdgeZonesIdentityInternal
    {

        /// <summary>Backing field for <see cref="ExtendedZoneName" /> property.</summary>
        private string _extendedZoneName;

        /// <summary>The name of the ExtendedZone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string ExtendedZoneName { get => this._extendedZoneName; set => this._extendedZoneName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="EdgeZonesIdentity" /> instance.</summary>
        public EdgeZonesIdentity()
        {

        }
    }
    public partial interface IEdgeZonesIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.IJsonSerializable
    {
        /// <summary>The name of the ExtendedZone</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the ExtendedZone",
        SerializedName = @"extendedZoneName",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedZoneName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IEdgeZonesIdentityInternal

    {
        /// <summary>The name of the ExtendedZone</summary>
        string ExtendedZoneName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}