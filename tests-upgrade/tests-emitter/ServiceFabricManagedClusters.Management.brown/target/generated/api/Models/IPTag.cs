// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>The IP tag associated with the public IP address.</summary>
    public partial class IPTag :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTag,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IIPTagInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string _tag;

        /// <summary>IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>IP tag type. Example: FirstPartyUsage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="IPTag" /> instance.</summary>
        public IPTag()
        {

        }
    }
    /// The IP tag associated with the public IP address.
    public partial interface IIPTag :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP tag associated with the public IP. Example: SQL, Storage etc.",
        SerializedName = @"tag",
        PossibleTypes = new [] { typeof(string) })]
        string Tag { get; set; }
        /// <summary>IP tag type. Example: FirstPartyUsage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP tag type. Example: FirstPartyUsage.",
        SerializedName = @"ipTagType",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// The IP tag associated with the public IP address.
    internal partial interface IIPTagInternal

    {
        /// <summary>IP tag associated with the public IP. Example: SQL, Storage etc.</summary>
        string Tag { get; set; }
        /// <summary>IP tag type. Example: FirstPartyUsage.</summary>
        string Type { get; set; }

    }
}