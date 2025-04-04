// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Describes the parameter of customer managed disk encryption set resource id
    /// that can be specified for disk. **Note:** The disk encryption set resource id
    /// can only be specified for managed disk. Please refer
    /// https://aka.ms/mdssewithcmkoverview for more details.
    /// </summary>
    public partial class DiskEncryptionSetParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IDiskEncryptionSetParametersInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="DiskEncryptionSetParameters" /> instance.</summary>
        public DiskEncryptionSetParameters()
        {

        }
    }
    /// Describes the parameter of customer managed disk encryption set resource id
    /// that can be specified for disk. **Note:** The disk encryption set resource id
    /// can only be specified for managed disk. Please refer
    /// https://aka.ms/mdssewithcmkoverview for more details.
    public partial interface IDiskEncryptionSetParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Describes the parameter of customer managed disk encryption set resource id
    /// that can be specified for disk. **Note:** The disk encryption set resource id
    /// can only be specified for managed disk. Please refer
    /// https://aka.ms/mdssewithcmkoverview for more details.
    internal partial interface IDiskEncryptionSetParametersInternal

    {
        /// <summary>Resource Id</summary>
        string Id { get; set; }

    }
}