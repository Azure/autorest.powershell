// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Subnet of container group</summary>
    public partial class Subnet :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnet,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.ISubnetInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Specifies ARM resource id of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="Subnet" /> instance.</summary>
        public Subnet()
        {

        }
    }
    /// Subnet of container group
    public partial interface ISubnet :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Specifies ARM resource id of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies ARM resource id of the subnet.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Subnet of container group
    internal partial interface ISubnetInternal

    {
        /// <summary>Specifies ARM resource id of the subnet.</summary>
        string Id { get; set; }

    }
}