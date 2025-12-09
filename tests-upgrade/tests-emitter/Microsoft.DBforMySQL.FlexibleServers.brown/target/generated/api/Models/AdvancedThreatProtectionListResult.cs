// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The response of a AdvancedThreatProtection list operation.</summary>
    public partial class AdvancedThreatProtectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtectionListResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtectionListResultInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtection> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtectionListResultInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtection> _value;

        /// <summary>The AdvancedThreatProtection items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtection> Value { get => this._value; }

        /// <summary>Creates an new <see cref="AdvancedThreatProtectionListResult" /> instance.</summary>
        public AdvancedThreatProtectionListResult()
        {

        }
    }
    /// The response of a AdvancedThreatProtection list operation.
    public partial interface IAdvancedThreatProtectionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The AdvancedThreatProtection items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The AdvancedThreatProtection items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtection> Value { get;  }

    }
    /// The response of a AdvancedThreatProtection list operation.
    internal partial interface IAdvancedThreatProtectionListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The AdvancedThreatProtection items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IAdvancedThreatProtection> Value { get; set; }

    }
}