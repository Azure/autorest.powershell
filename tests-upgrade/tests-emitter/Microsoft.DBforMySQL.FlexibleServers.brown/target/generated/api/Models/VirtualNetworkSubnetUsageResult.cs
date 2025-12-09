// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Virtual network subnet usage data.</summary>
    public partial class VirtualNetworkSubnetUsageResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IVirtualNetworkSubnetUsageResult,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IVirtualNetworkSubnetUsageResultInternal
    {

        /// <summary>Backing field for <see cref="DelegatedSubnetsUsage" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDelegatedSubnetUsage> _delegatedSubnetsUsage;

        /// <summary>A list of delegated subnet usage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDelegatedSubnetUsage> DelegatedSubnetsUsage { get => this._delegatedSubnetsUsage; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for DelegatedSubnetsUsage</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDelegatedSubnetUsage> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IVirtualNetworkSubnetUsageResultInternal.DelegatedSubnetsUsage { get => this._delegatedSubnetsUsage; set { {_delegatedSubnetsUsage = value;} } }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IVirtualNetworkSubnetUsageResultInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IVirtualNetworkSubnetUsageResultInternal.SubscriptionId { get => this._subscriptionId; set { {_subscriptionId = value;} } }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; }

        /// <summary>Creates an new <see cref="VirtualNetworkSubnetUsageResult" /> instance.</summary>
        public VirtualNetworkSubnetUsageResult()
        {

        }
    }
    /// Virtual network subnet usage data.
    public partial interface IVirtualNetworkSubnetUsageResult :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>A list of delegated subnet usage</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of delegated subnet usage",
        SerializedName = @"delegatedSubnetsUsage",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDelegatedSubnetUsage) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDelegatedSubnetUsage> DelegatedSubnetsUsage { get;  }
        /// <summary>The location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The location name.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>The subscription id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The subscription id.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get;  }

    }
    /// Virtual network subnet usage data.
    internal partial interface IVirtualNetworkSubnetUsageResultInternal

    {
        /// <summary>A list of delegated subnet usage</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IDelegatedSubnetUsage> DelegatedSubnetsUsage { get; set; }
        /// <summary>The location name.</summary>
        string Location { get; set; }
        /// <summary>The subscription id.</summary>
        string SubscriptionId { get; set; }

    }
}