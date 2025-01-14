// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The updatable properties of the DataProduct.</summary>
    public partial class DataProductUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="CurrentMinorVersion" /> property.</summary>
        private string _currentMinorVersion;

        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string CurrentMinorVersion { get => this._currentMinorVersion; set => this._currentMinorVersion = value; }

        /// <summary>Backing field for <see cref="Owner" /> property.</summary>
        private System.Collections.Generic.List<string> _owner;

        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Owner { get => this._owner; set => this._owner = value; }

        /// <summary>Backing field for <see cref="PrivateLinksEnabled" /> property.</summary>
        private string _privateLinksEnabled;

        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PrivateLinksEnabled { get => this._privateLinksEnabled; set => this._privateLinksEnabled = value; }

        /// <summary>Backing field for <see cref="PurviewAccount" /> property.</summary>
        private string _purviewAccount;

        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PurviewAccount { get => this._purviewAccount; set => this._purviewAccount = value; }

        /// <summary>Backing field for <see cref="PurviewCollection" /> property.</summary>
        private string _purviewCollection;

        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PurviewCollection { get => this._purviewCollection; set => this._purviewCollection = value; }

        /// <summary>Creates an new <see cref="DataProductUpdateProperties" /> instance.</summary>
        public DataProductUpdateProperties()
        {

        }
    }
    /// The updatable properties of the DataProduct.
    public partial interface IDataProductUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Current configured minor version of the data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = false,
        Update = true,
        Description = @"Current configured minor version of the data product resource.",
        SerializedName = @"currentMinorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentMinorVersion { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of name or email associated with data product resource deployment.",
        SerializedName = @"owners",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag to enable or disable private link for data product resource.",
        SerializedName = @"privateLinksEnabled",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview account url for data product to connect to.",
        SerializedName = @"purviewAccount",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Purview collection url for data product to connect to.",
        SerializedName = @"purviewCollection",
        PossibleTypes = new [] { typeof(string) })]
        string PurviewCollection { get; set; }

    }
    /// The updatable properties of the DataProduct.
    internal partial interface IDataProductUpdatePropertiesInternal

    {
        /// <summary>Current configured minor version of the data product resource.</summary>
        string CurrentMinorVersion { get; set; }
        /// <summary>List of name or email associated with data product resource deployment.</summary>
        System.Collections.Generic.List<string> Owner { get; set; }
        /// <summary>Flag to enable or disable private link for data product resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PrivateLinksEnabled { get; set; }
        /// <summary>Purview account url for data product to connect to.</summary>
        string PurviewAccount { get; set; }
        /// <summary>Purview collection url for data product to connect to.</summary>
        string PurviewCollection { get; set; }

    }
}