// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The updatable properties of the DataType.</summary>
    public partial class DataTypeUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal
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

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="StorageOutputRetention" /> property.</summary>
        private int? _storageOutputRetention;

        /// <summary>Field for storage output retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public int? StorageOutputRetention { get => this._storageOutputRetention; set => this._storageOutputRetention = value; }

        /// <summary>Creates an new <see cref="DataTypeUpdateProperties" /> instance.</summary>
        public DataTypeUpdateProperties()
        {

        }
    }
    /// The updatable properties of the DataType.
    public partial interface IDataTypeUpdateProperties :
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

    }
    /// The updatable properties of the DataType.
    internal partial interface IDataTypeUpdatePropertiesInternal

    {
        /// <summary>Field for database cache retention in days.</summary>
        int? DatabaseCacheRetention { get; set; }
        /// <summary>Field for database data retention in days.</summary>
        int? DatabaseRetention { get; set; }
        /// <summary>State of data type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Stopped", "Running")]
        string State { get; set; }
        /// <summary>Field for storage output retention in days.</summary>
        int? StorageOutputRetention { get; set; }

    }
}