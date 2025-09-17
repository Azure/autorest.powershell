// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Extensions;

    /// <summary>The API entity reference.</summary>
    public partial class ApiEntityReference :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReference,
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Models.IApiEntityReferenceInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Origin(Microsoft.Azure.PowerShell.Cmdlets.Hsm.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="ApiEntityReference" /> instance.</summary>
        public ApiEntityReference()
        {

        }
    }
    /// The API entity reference.
    public partial interface IApiEntityReference :
        Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Hsm.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    /// The API entity reference.
    internal partial interface IApiEntityReferenceInternal

    {
        /// <summary>
        /// The Azure resource id in the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        string ResourceId { get; set; }

    }
}