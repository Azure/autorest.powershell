// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>The type used for updating tags in AzureLargeInstance resources.</summary>
    public partial class AzureLargeInstanceTagsUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceTagsUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceTagsUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags _tag;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="AzureLargeInstanceTagsUpdate" /> instance.</summary>
        public AzureLargeInstanceTagsUpdate()
        {

        }
    }
    /// The type used for updating tags in AzureLargeInstance resources.
    public partial interface IAzureLargeInstanceTagsUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags Tag { get; set; }

    }
    /// The type used for updating tags in AzureLargeInstance resources.
    internal partial interface IAzureLargeInstanceTagsUpdateInternal

    {
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.ITags Tag { get; set; }

    }
}