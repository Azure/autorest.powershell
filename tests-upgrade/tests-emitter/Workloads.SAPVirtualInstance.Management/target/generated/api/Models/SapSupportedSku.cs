// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP supported SKU.</summary>
    public partial class SapSupportedSku :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSku,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSkuInternal
    {

        /// <summary>Backing field for <see cref="IsAppServerCertified" /> property.</summary>
        private bool? _isAppServerCertified;

        /// <summary>True if the Sku is certified for App server in the SAP system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public bool? IsAppServerCertified { get => this._isAppServerCertified; set => this._isAppServerCertified = value; }

        /// <summary>Backing field for <see cref="IsDatabaseCertified" /> property.</summary>
        private bool? _isDatabaseCertified;

        /// <summary>True if the Sku is certified for Database server in the SAP system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public bool? IsDatabaseCertified { get => this._isDatabaseCertified; set => this._isDatabaseCertified = value; }

        /// <summary>Backing field for <see cref="VMSku" /> property.</summary>
        private string _vMSku;

        /// <summary>The VM Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string VMSku { get => this._vMSku; set => this._vMSku = value; }

        /// <summary>Creates an new <see cref="SapSupportedSku" /> instance.</summary>
        public SapSupportedSku()
        {

        }
    }
    /// The SAP supported SKU.
    public partial interface ISapSupportedSku :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>True if the Sku is certified for App server in the SAP system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"True if the Sku is certified for App server in the SAP system.",
        SerializedName = @"isAppServerCertified",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAppServerCertified { get; set; }
        /// <summary>True if the Sku is certified for Database server in the SAP system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"True if the Sku is certified for Database server in the SAP system.",
        SerializedName = @"isDatabaseCertified",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDatabaseCertified { get; set; }
        /// <summary>The VM Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The VM Sku.",
        SerializedName = @"vmSku",
        PossibleTypes = new [] { typeof(string) })]
        string VMSku { get; set; }

    }
    /// The SAP supported SKU.
    internal partial interface ISapSupportedSkuInternal

    {
        /// <summary>True if the Sku is certified for App server in the SAP system.</summary>
        bool? IsAppServerCertified { get; set; }
        /// <summary>True if the Sku is certified for Database server in the SAP system.</summary>
        bool? IsDatabaseCertified { get; set; }
        /// <summary>The VM Sku.</summary>
        string VMSku { get; set; }

    }
}