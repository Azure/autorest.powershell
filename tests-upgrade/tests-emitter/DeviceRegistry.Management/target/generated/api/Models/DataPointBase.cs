// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the data point properties.</summary>
    public partial class DataPointBase :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBase,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IDataPointBaseInternal
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private string _configuration;

        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Configuration { get => this._configuration; set => this._configuration = value; }

        /// <summary>Backing field for <see cref="DataSource" /> property.</summary>
        private string _dataSource;

        /// <summary>
        /// The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string DataSource { get => this._dataSource; set => this._dataSource = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the data point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DataPointBase" /> instance.</summary>
        public DataPointBase()
        {

        }
    }
    /// Defines the data point properties.
    public partial interface IDataPointBase :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration like, publishingInterval, samplingInterval, and queueSize.",
        SerializedName = @"dataPointConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string Configuration { get; set; }
        /// <summary>
        /// The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset.",
        SerializedName = @"dataSource",
        PossibleTypes = new [] { typeof(string) })]
        string DataSource { get; set; }
        /// <summary>The name of the data point.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the data point.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Defines the data point properties.
    internal partial interface IDataPointBaseInternal

    {
        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the data point. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        string Configuration { get; set; }
        /// <summary>
        /// The address of the source of the data in the asset (e.g. URL) so that a client can access the data source on the asset.
        /// </summary>
        string DataSource { get; set; }
        /// <summary>The name of the data point.</summary>
        string Name { get; set; }

    }
}