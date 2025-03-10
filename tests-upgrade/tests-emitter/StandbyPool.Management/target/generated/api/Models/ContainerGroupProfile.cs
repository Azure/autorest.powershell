// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Details of the ContainerGroupProfile.</summary>
    public partial class ContainerGroupProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfile,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IContainerGroupProfileInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Specifies container group profile id of standby container groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Revision" /> property.</summary>
        private long? _revision;

        /// <summary>Specifies revision of container group profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public long? Revision { get => this._revision; set => this._revision = value; }

        /// <summary>Creates an new <see cref="ContainerGroupProfile" /> instance.</summary>
        public ContainerGroupProfile()
        {

        }
    }
    /// Details of the ContainerGroupProfile.
    public partial interface IContainerGroupProfile :
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
        string Id { get; set; }
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
        long? Revision { get; set; }

    }
    /// Details of the ContainerGroupProfile.
    internal partial interface IContainerGroupProfileInternal

    {
        /// <summary>Specifies container group profile id of standby container groups.</summary>
        string Id { get; set; }
        /// <summary>Specifies revision of container group profile.</summary>
        long? Revision { get; set; }

    }
}