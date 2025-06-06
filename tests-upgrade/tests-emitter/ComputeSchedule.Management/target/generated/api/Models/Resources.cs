// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>The resources needed for the user request</summary>
    public partial class Resources :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResources,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IResourcesInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private System.Collections.Generic.List<string> _id;

        /// <summary>The resource ids used for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="Resources" /> instance.</summary>
        public Resources()
        {

        }
    }
    /// The resources needed for the user request
    public partial interface IResources :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>The resource ids used for the request</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource ids used for the request",
        SerializedName = @"ids",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Id { get; set; }

    }
    /// The resources needed for the user request
    internal partial interface IResourcesInternal

    {
        /// <summary>The resource ids used for the request</summary>
        System.Collections.Generic.List<string> Id { get; set; }

    }
}