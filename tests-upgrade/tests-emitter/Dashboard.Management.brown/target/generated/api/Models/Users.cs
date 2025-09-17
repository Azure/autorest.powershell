// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Grafana users settings</summary>
    public partial class Users :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsersInternal
    {

        /// <summary>Backing field for <see cref="EditorsCanAdmin" /> property.</summary>
        private bool? _editorsCanAdmin;

        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? EditorsCanAdmin { get => this._editorsCanAdmin; set => this._editorsCanAdmin = value; }

        /// <summary>Backing field for <see cref="ViewersCanEdit" /> property.</summary>
        private bool? _viewersCanEdit;

        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? ViewersCanEdit { get => this._viewersCanEdit; set => this._viewersCanEdit = value; }

        /// <summary>Creates an new <see cref="Users" /> instance.</summary>
        public Users()
        {

        }
    }
    /// Grafana users settings
    public partial interface IUsers :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true so editors can administrate dashboards, folders and teams they create.",
        SerializedName = @"editorsCanAdmin",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EditorsCanAdmin { get; set; }
        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access to. They cannot save their changes.",
        SerializedName = @"viewersCanEdit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ViewersCanEdit { get; set; }

    }
    /// Grafana users settings
    internal partial interface IUsersInternal

    {
        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        bool? EditorsCanAdmin { get; set; }
        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        bool? ViewersCanEdit { get; set; }

    }
}