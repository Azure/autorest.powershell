// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The parameters for a PATCH request to a managed dashboard resource.</summary>
    public partial class ManagedDashboardUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParametersTags _tag;

        /// <summary>The new tags of the managed dashboard resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ManagedDashboardUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ManagedDashboardUpdateParameters" /> instance.</summary>
        public ManagedDashboardUpdateParameters()
        {

        }
    }
    /// The parameters for a PATCH request to a managed dashboard resource.
    public partial interface IManagedDashboardUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The new tags of the managed dashboard resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The new tags of the managed dashboard resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParametersTags Tag { get; set; }

    }
    /// The parameters for a PATCH request to a managed dashboard resource.
    internal partial interface IManagedDashboardUpdateParametersInternal

    {
        /// <summary>The new tags of the managed dashboard resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedDashboardUpdateParametersTags Tag { get; set; }

    }
}