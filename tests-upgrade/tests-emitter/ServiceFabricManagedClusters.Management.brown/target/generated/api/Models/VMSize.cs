// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>VM Sizes properties.</summary>
    public partial class VMSize :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMSize,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMSizeInternal
    {

        /// <summary>Internal Acessors for Size</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMSizeInternal.Size { get => this._size; set { {_size = value;} } }

        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private string _size;

        /// <summary>VM Size name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Size { get => this._size; }

        /// <summary>Creates an new <see cref="VMSize" /> instance.</summary>
        public VMSize()
        {

        }
    }
    /// VM Sizes properties.
    public partial interface IVMSize :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>VM Size name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"VM Size name.",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        string Size { get;  }

    }
    /// VM Sizes properties.
    internal partial interface IVMSizeInternal

    {
        /// <summary>VM Size name.</summary>
        string Size { get; set; }

    }
}