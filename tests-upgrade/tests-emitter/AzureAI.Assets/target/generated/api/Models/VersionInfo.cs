// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Next version definition.</summary>
    public partial class VersionInfo :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IVersionInfo,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IVersionInfoInternal
    {

        /// <summary>Backing field for <see cref="LatestVersion" /> property.</summary>
        private string _latestVersion;

        /// <summary>Current latest version of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string LatestVersion { get => this._latestVersion; set => this._latestVersion = value; }

        /// <summary>Backing field for <see cref="NextVersion" /> property.</summary>
        private long? _nextVersion;

        /// <summary>
        /// Next version as defined by the server. The server keeps track of all versions that are string-representations of integers.
        /// If one exists, the nextVersion will be a string representation of the highest integer value + 1. Otherwise, the nextVersion
        /// will default to '1'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public long? NextVersion { get => this._nextVersion; set => this._nextVersion = value; }

        /// <summary>Creates an new <see cref="VersionInfo" /> instance.</summary>
        public VersionInfo()
        {

        }
    }
    /// Next version definition.
    public partial interface IVersionInfo :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Current latest version of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current latest version of the resource.",
        SerializedName = @"latestVersion",
        PossibleTypes = new [] { typeof(string) })]
        string LatestVersion { get; set; }
        /// <summary>
        /// Next version as defined by the server. The server keeps track of all versions that are string-representations of integers.
        /// If one exists, the nextVersion will be a string representation of the highest integer value + 1. Otherwise, the nextVersion
        /// will default to '1'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Next version as defined by the server. The server keeps track of all versions that are string-representations of integers. If one exists, the nextVersion will be a string representation of the highest integer value + 1. Otherwise, the nextVersion will default to '1'.",
        SerializedName = @"nextVersion",
        PossibleTypes = new [] { typeof(long) })]
        long? NextVersion { get; set; }

    }
    /// Next version definition.
    internal partial interface IVersionInfoInternal

    {
        /// <summary>Current latest version of the resource.</summary>
        string LatestVersion { get; set; }
        /// <summary>
        /// Next version as defined by the server. The server keeps track of all versions that are string-representations of integers.
        /// If one exists, the nextVersion will be a string representation of the highest integer value + 1. Otherwise, the nextVersion
        /// will default to '1'.
        /// </summary>
        long? NextVersion { get; set; }

    }
}