// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Data Product Information</summary>
    public partial class DataProductInformation :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformation,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformationInternal
    {

        /// <summary>Backing field for <see cref="DataProductName" /> property.</summary>
        private string _dataProductName;

        /// <summary>Name of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string DataProductName { get => this._dataProductName; set => this._dataProductName = value; }

        /// <summary>Backing field for <see cref="DataProductVersion" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersion> _dataProductVersion;

        /// <summary>Version information of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersion> DataProductVersion { get => this._dataProductVersion; set => this._dataProductVersion = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description about data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Creates an new <see cref="DataProductInformation" /> instance.</summary>
        public DataProductInformation()
        {

        }
    }
    /// Data Product Information
    public partial interface IDataProductInformation :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Name of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of data product.",
        SerializedName = @"dataProductName",
        PossibleTypes = new [] { typeof(string) })]
        string DataProductName { get; set; }
        /// <summary>Version information of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Version information of data product.",
        SerializedName = @"dataProductVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersion) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersion> DataProductVersion { get; set; }
        /// <summary>Description about data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description about data product.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

    }
    /// Data Product Information
    internal partial interface IDataProductInformationInternal

    {
        /// <summary>Name of data product.</summary>
        string DataProductName { get; set; }
        /// <summary>Version information of data product.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductVersion> DataProductVersion { get; set; }
        /// <summary>Description about data product.</summary>
        string Description { get; set; }

    }
}