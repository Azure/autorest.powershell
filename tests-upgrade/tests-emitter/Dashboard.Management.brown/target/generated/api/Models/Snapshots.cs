// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Grafana Snapshots settings</summary>
    public partial class Snapshots :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshotsInternal
    {

        /// <summary>Backing field for <see cref="ExternalEnabled" /> property.</summary>
        private bool? _externalEnabled;

        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? ExternalEnabled { get => this._externalEnabled; set => this._externalEnabled = value; }

        /// <summary>Creates an new <see cref="Snapshots" /> instance.</summary>
        public Snapshots()
        {

        }
    }
    /// Grafana Snapshots settings
    public partial interface ISnapshots :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to false to disable external snapshot publish endpoint",
        SerializedName = @"externalEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExternalEnabled { get; set; }

    }
    /// Grafana Snapshots settings
    internal partial interface ISnapshotsInternal

    {
        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        bool? ExternalEnabled { get; set; }

    }
}