// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>Details of Consumption Properties</summary>
    public partial class ConsumptionEndpointsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="FileAccessResourceId" /> property.</summary>
        private string _fileAccessResourceId;

        /// <summary>Resource Id of file access endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string FileAccessResourceId { get => this._fileAccessResourceId; }

        /// <summary>Backing field for <see cref="FileAccessUrl" /> property.</summary>
        private string _fileAccessUrl;

        /// <summary>Url to consume file type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string FileAccessUrl { get => this._fileAccessUrl; }

        /// <summary>Backing field for <see cref="IngestionResourceId" /> property.</summary>
        private string _ingestionResourceId;

        /// <summary>Resource Id of ingestion endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string IngestionResourceId { get => this._ingestionResourceId; }

        /// <summary>Backing field for <see cref="IngestionUrl" /> property.</summary>
        private string _ingestionUrl;

        /// <summary>Ingestion url to upload the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string IngestionUrl { get => this._ingestionUrl; }

        /// <summary>Internal Acessors for FileAccessResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal.FileAccessResourceId { get => this._fileAccessResourceId; set { {_fileAccessResourceId = value;} } }

        /// <summary>Internal Acessors for FileAccessUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal.FileAccessUrl { get => this._fileAccessUrl; set { {_fileAccessUrl = value;} } }

        /// <summary>Internal Acessors for IngestionResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal.IngestionResourceId { get => this._ingestionResourceId; set { {_ingestionResourceId = value;} } }

        /// <summary>Internal Acessors for IngestionUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal.IngestionUrl { get => this._ingestionUrl; set { {_ingestionUrl = value;} } }

        /// <summary>Internal Acessors for QueryResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal.QueryResourceId { get => this._queryResourceId; set { {_queryResourceId = value;} } }

        /// <summary>Internal Acessors for QueryUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IConsumptionEndpointsPropertiesInternal.QueryUrl { get => this._queryUrl; set { {_queryUrl = value;} } }

        /// <summary>Backing field for <see cref="QueryResourceId" /> property.</summary>
        private string _queryResourceId;

        /// <summary>Resource Id of query endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string QueryResourceId { get => this._queryResourceId; }

        /// <summary>Backing field for <see cref="QueryUrl" /> property.</summary>
        private string _queryUrl;

        /// <summary>Url to consume the processed data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string QueryUrl { get => this._queryUrl; }

        /// <summary>Creates an new <see cref="ConsumptionEndpointsProperties" /> instance.</summary>
        public ConsumptionEndpointsProperties()
        {

        }
    }
    /// Details of Consumption Properties
    public partial interface IConsumptionEndpointsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Resource Id of file access endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of file access endpoint.",
        SerializedName = @"fileAccessResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string FileAccessResourceId { get;  }
        /// <summary>Url to consume file type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to consume file type.",
        SerializedName = @"fileAccessUrl",
        PossibleTypes = new [] { typeof(string) })]
        string FileAccessUrl { get;  }
        /// <summary>Resource Id of ingestion endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of ingestion endpoint.",
        SerializedName = @"ingestionResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string IngestionResourceId { get;  }
        /// <summary>Ingestion url to upload the data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Ingestion url to upload the data.",
        SerializedName = @"ingestionUrl",
        PossibleTypes = new [] { typeof(string) })]
        string IngestionUrl { get;  }
        /// <summary>Resource Id of query endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Id of query endpoint.",
        SerializedName = @"queryResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string QueryResourceId { get;  }
        /// <summary>Url to consume the processed data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url to consume the processed data.",
        SerializedName = @"queryUrl",
        PossibleTypes = new [] { typeof(string) })]
        string QueryUrl { get;  }

    }
    /// Details of Consumption Properties
    internal partial interface IConsumptionEndpointsPropertiesInternal

    {
        /// <summary>Resource Id of file access endpoint.</summary>
        string FileAccessResourceId { get; set; }
        /// <summary>Url to consume file type.</summary>
        string FileAccessUrl { get; set; }
        /// <summary>Resource Id of ingestion endpoint.</summary>
        string IngestionResourceId { get; set; }
        /// <summary>Ingestion url to upload the data.</summary>
        string IngestionUrl { get; set; }
        /// <summary>Resource Id of query endpoint.</summary>
        string QueryResourceId { get; set; }
        /// <summary>Url to consume the processed data.</summary>
        string QueryUrl { get; set; }

    }
}