// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details for Publisher Information.</summary>
    public partial class PublisherInformation :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformation,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IPublisherInformationInternal
    {

        /// <summary>Backing field for <see cref="DataProduct" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformation> _dataProduct;

        /// <summary>Data product information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformation> DataProduct { get => this._dataProduct; set => this._dataProduct = value; }

        /// <summary>Backing field for <see cref="PublisherName" /> property.</summary>
        private string _publisherName;

        /// <summary>Name of the publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string PublisherName { get => this._publisherName; set => this._publisherName = value; }

        /// <summary>Creates an new <see cref="PublisherInformation" /> instance.</summary>
        public PublisherInformation()
        {

        }
    }
    /// Details for Publisher Information.
    public partial interface IPublisherInformation :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Data product information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Data product information.",
        SerializedName = @"dataProducts",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformation> DataProduct { get; set; }
        /// <summary>Name of the publisher.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the publisher.",
        SerializedName = @"publisherName",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherName { get; set; }

    }
    /// Details for Publisher Information.
    internal partial interface IPublisherInformationInternal

    {
        /// <summary>Data product information.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataProductInformation> DataProduct { get; set; }
        /// <summary>Name of the publisher.</summary>
        string PublisherName { get; set; }

    }
}