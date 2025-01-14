// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The type used for update operations of the DataType.</summary>
    public partial class DataTypeUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateInternal
    {

        /// <summary>Field for database cache retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public int? DatabaseCacheRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).DatabaseCacheRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).DatabaseCacheRetention = value ?? default(int); }

        /// <summary>Field for database data retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public int? DatabaseRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).DatabaseRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).DatabaseRetention = value ?? default(int); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataTypeUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.DataTypeUpdateProperties()); set => this._property = value; }

        /// <summary>State of data type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).State = value ?? null; }

        /// <summary>Field for storage output retention in days.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Inlined)]
        public int? StorageOutputRetention { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).StorageOutputRetention; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdatePropertiesInternal)Property).StorageOutputRetention = value ?? default(int); }

        /// <summary>Creates an new <see cref="DataTypeUpdate" /> instance.</summary>
        public DataTypeUpdate()
        {

        }
    }
    /// The type used for update operations of the DataType.
    public partial interface IDataTypeUpdate :
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
    /// The type used for update operations of the DataType.
    internal partial interface IDataTypeUpdateInternal

    {
        /// <summary>Field for database cache retention in days.</summary>
        int? DatabaseCacheRetention { get; set; }
        /// <summary>Field for database data retention in days.</summary>
        int? DatabaseRetention { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IDataTypeUpdateProperties Property { get; set; }
        /// <summary>State of data type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PSArgumentCompleterAttribute("Stopped", "Running")]
        string State { get; set; }
        /// <summary>Field for storage output retention in days.</summary>
        int? StorageOutputRetention { get; set; }

    }
}