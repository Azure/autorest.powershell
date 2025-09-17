// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Grafana security settings</summary>
    public partial class Security :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurityInternal
    {

        /// <summary>Backing field for <see cref="CsrfAlwaysCheck" /> property.</summary>
        private bool? _csrfAlwaysCheck;

        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? CsrfAlwaysCheck { get => this._csrfAlwaysCheck; set => this._csrfAlwaysCheck = value; }

        /// <summary>Creates an new <see cref="Security" /> instance.</summary>
        public Security()
        {

        }
    }
    /// Grafana security settings
    public partial interface ISecurity :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true to execute the CSRF check even if the login cookie is not in a request (default false).",
        SerializedName = @"csrfAlwaysCheck",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CsrfAlwaysCheck { get; set; }

    }
    /// Grafana security settings
    internal partial interface ISecurityInternal

    {
        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        bool? CsrfAlwaysCheck { get; set; }

    }
}