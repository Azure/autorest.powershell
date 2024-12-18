// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Extensions;

    /// <summary>Partner's specific Properties</summary>
    public partial class PartnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IPartnerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Models.IPartnerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Pinecone Organization Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Origin(Microsoft.Azure.PowerShell.Cmdlets.Pinecone.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Creates an new <see cref="PartnerProperties" /> instance.</summary>
        public PartnerProperties()
        {

        }
    }
    /// Partner's specific Properties
    public partial interface IPartnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.IJsonSerializable
    {
        /// <summary>Pinecone Organization Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Pinecone.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Pinecone Organization Name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }

    }
    /// Partner's specific Properties
    internal partial interface IPartnerPropertiesInternal

    {
        /// <summary>Pinecone Organization Name</summary>
        string DisplayName { get; set; }

    }
}