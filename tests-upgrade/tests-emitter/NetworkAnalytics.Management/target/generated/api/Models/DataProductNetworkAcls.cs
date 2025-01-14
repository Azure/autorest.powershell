// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Data Product Network rule set</summary>
    public partial class DataProductNetworkAcls :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAcls,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductNetworkAclsInternal
    {

        /// <summary>Backing field for <see cref="AllowedQueryIPRangeList" /> property.</summary>
        private System.Collections.Generic.List<string> _allowedQueryIPRangeList;

        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AllowedQueryIPRangeList { get => this._allowedQueryIPRangeList; set => this._allowedQueryIPRangeList = value; }

        /// <summary>Backing field for <see cref="DefaultAction" /> property.</summary>
        private string _defaultAction;

        /// <summary>Default Action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string DefaultAction { get => this._defaultAction; set => this._defaultAction = value; }

        /// <summary>Backing field for <see cref="IPRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> _iPRule;

        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> IPRule { get => this._iPRule; set => this._iPRule = value; }

        /// <summary>Backing field for <see cref="VirtualNetworkRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> _virtualNetworkRule;

        /// <summary>Virtual Network Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> VirtualNetworkRule { get => this._virtualNetworkRule; set => this._virtualNetworkRule = value; }

        /// <summary>Creates an new <see cref="DataProductNetworkAcls" /> instance.</summary>
        public DataProductNetworkAcls()
        {

        }
    }
    /// Data Product Network rule set
    public partial interface IDataProductNetworkAcls :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.",
        SerializedName = @"allowedQueryIpRangeList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AllowedQueryIPRangeList { get; set; }
        /// <summary>Default Action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Default Action",
        SerializedName = @"defaultAction",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Allow", "Deny")]
        string DefaultAction { get; set; }
        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP rule with specific IP or IP range in CIDR format.",
        SerializedName = @"ipRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> IPRule { get; set; }
        /// <summary>Virtual Network Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual Network Rule",
        SerializedName = @"virtualNetworkRule",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> VirtualNetworkRule { get; set; }

    }
    /// Data Product Network rule set
    internal partial interface IDataProductNetworkAclsInternal

    {
        /// <summary>
        /// The list of query ips in the format of CIDR allowed to connect to query/visualization endpoint.
        /// </summary>
        System.Collections.Generic.List<string> AllowedQueryIPRangeList { get; set; }
        /// <summary>Default Action</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Allow", "Deny")]
        string DefaultAction { get; set; }
        /// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IIPRules> IPRule { get; set; }
        /// <summary>Virtual Network Rule</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IVirtualNetworkRule> VirtualNetworkRule { get; set; }

    }
}