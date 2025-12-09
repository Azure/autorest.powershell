// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>
    /// A list of private link resources for versions before v6.
    /// This model represents the standard `PrivateLinkResourceListResult` envelope for versions v3, v4, and v5. It has been deprecated
    /// for v6 and beyond.
    /// Note: This is only intended for use with versions before v6. Do not use this if you are already on CommonTypes.Version.v6
    /// or beyond.
    /// If you are migrating to v6 or above, use `PrivateLinkResourceListResult` directly.
    /// </summary>
    public partial class PrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResource> _value;

        /// <summary>Array of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceListResult" /> instance.</summary>
        public PrivateLinkResourceListResult()
        {

        }
    }
    /// A list of private link resources for versions before v6.
    /// This model represents the standard `PrivateLinkResourceListResult` envelope for versions v3, v4, and v5. It has been deprecated
    /// for v6 and beyond.
    /// Note: This is only intended for use with versions before v6. Do not use this if you are already on CommonTypes.Version.v6
    /// or beyond.
    /// If you are migrating to v6 or above, use `PrivateLinkResourceListResult` directly.
    public partial interface IPrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Array of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of private link resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResource> Value { get; set; }

    }
    /// A list of private link resources for versions before v6.
    /// This model represents the standard `PrivateLinkResourceListResult` envelope for versions v3, v4, and v5. It has been deprecated
    /// for v6 and beyond.
    /// Note: This is only intended for use with versions before v6. Do not use this if you are already on CommonTypes.Version.v6
    /// or beyond.
    /// If you are migrating to v6 or above, use `PrivateLinkResourceListResult` directly.
    internal partial interface IPrivateLinkResourceListResultInternal

    {
        /// <summary>Array of private link resources</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IPrivateLinkResource> Value { get; set; }

    }
}