// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The data type properties</summary>
    public partial class DataTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DatabaseCacheRetention" /> property.</summary>
        private int? _databaseCacheRetention;

        /// <summary>Field for database cache retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int? DatabaseCacheRetention { get => this._databaseCacheRetention; set => this._databaseCacheRetention = value; }

        /// <summary>Backing field for <see cref="DatabaseRetention" /> property.</summary>
        private int? _databaseRetention;

        /// <summary>Field for database data retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int? DatabaseRetention { get => this._databaseRetention; set => this._databaseRetention = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for StateReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal.StateReason { get => this._stateReason; set { {_stateReason = value;} } }

        /// <summary>Internal Acessors for VisualizationUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypePropertiesInternal.VisualizationUrl { get => this._visualizationUrl; set { {_visualizationUrl = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StateReason" /> property.</summary>
        private string _stateReason;

        /// <summary>Reason for the state of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string StateReason { get => this._stateReason; }

        /// <summary>Backing field for <see cref="StorageOutputRetention" /> property.</summary>
        private int? _storageOutputRetention;

        /// <summary>Field for storage output retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int? StorageOutputRetention { get => this._storageOutputRetention; set => this._storageOutputRetention = value; }

        /// <summary>Backing field for <see cref="VisualizationUrl" /> property.</summary>
        private string _visualizationUrl;

        /// <summary>Url for data visualization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string VisualizationUrl { get => this._visualizationUrl; }

        /// <summary>Creates an new <see cref="DataTypeProperties" /> instance.</summary>
        public DataTypeProperties()
        {

        }
    }
    /// The data type properties
    public partial interface IDataTypeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Field for database cache retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field for database cache retention in days.",
        SerializedName = @"databaseCacheRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseCacheRetention { get; set; }
        /// <summary>Field for database data retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field for database data retention in days.",
        SerializedName = @"databaseRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? DatabaseRetention { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Latest provisioning state  of data product.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>State of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"State of data type.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Stopped", "Running")]
        string State { get; set; }
        /// <summary>Reason for the state of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Reason for the state of data type.",
        SerializedName = @"stateReason",
        PossibleTypes = new [] { typeof(string) })]
        string StateReason { get;  }
        /// <summary>Field for storage output retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Field for storage output retention in days.",
        SerializedName = @"storageOutputRetention",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageOutputRetention { get; set; }
        /// <summary>Url for data visualization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Url for data visualization.",
        SerializedName = @"visualizationUrl",
        PossibleTypes = new [] { typeof(string) })]
        string VisualizationUrl { get;  }

    }
    /// The data type properties
    internal partial interface IDataTypePropertiesInternal

    {
        /// <summary>Field for database cache retention in days.</summary>
        int? DatabaseCacheRetention { get; set; }
        /// <summary>Field for database data retention in days.</summary>
        int? DatabaseRetention { get; set; }
        /// <summary>Latest provisioning state of data product.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>State of data type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Stopped", "Running")]
        string State { get; set; }
        /// <summary>Reason for the state of data type.</summary>
        string StateReason { get; set; }
        /// <summary>Field for storage output retention in days.</summary>
        int? StorageOutputRetention { get; set; }
        /// <summary>Url for data visualization.</summary>
        string VisualizationUrl { get; set; }

    }
}