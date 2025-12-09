// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Storage Profile properties of a server</summary>
    public partial class Storage :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorage,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal
    {

        /// <summary>Backing field for <see cref="AutoGrow" /> property.</summary>
        private string _autoGrow;

        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string AutoGrow { get => this._autoGrow; set => this._autoGrow = value; }

        /// <summary>Backing field for <see cref="AutoIoScaling" /> property.</summary>
        private string _autoIoScaling;

        /// <summary>Enable IO Auto Scaling or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string AutoIoScaling { get => this._autoIoScaling; set => this._autoIoScaling = value; }

        /// <summary>Backing field for <see cref="Iop" /> property.</summary>
        private int? _iop;

        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? Iop { get => this._iop; set => this._iop = value; }

        /// <summary>Backing field for <see cref="LogOnDisk" /> property.</summary>
        private string _logOnDisk;

        /// <summary>Enable Log On Disk or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string LogOnDisk { get => this._logOnDisk; set => this._logOnDisk = value; }

        /// <summary>Internal Acessors for Sku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageInternal.Sku { get => this._sku; set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="Redundancy" /> property.</summary>
        private string _redundancy;

        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Redundancy { get => this._redundancy; set => this._redundancy = value; }

        /// <summary>Backing field for <see cref="SizeGb" /> property.</summary>
        private int? _sizeGb;

        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? SizeGb { get => this._sizeGb; set => this._sizeGb = value; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private string _sku;

        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Sku { get => this._sku; }

        /// <summary>Creates an new <see cref="Storage" /> instance.</summary>
        public Storage()
        {

        }
    }
    /// Storage Profile properties of a server
    public partial interface IStorage :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Enable Storage Auto Grow or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable Storage Auto Grow or not.",
        SerializedName = @"autoGrow",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AutoGrow { get; set; }
        /// <summary>Enable IO Auto Scaling or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable IO Auto Scaling or not.",
        SerializedName = @"autoIoScaling",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AutoIoScaling { get; set; }
        /// <summary>Storage IOPS for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Storage IOPS for a server.",
        SerializedName = @"iops",
        PossibleTypes = new [] { typeof(int) })]
        int? Iop { get; set; }
        /// <summary>Enable Log On Disk or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable Log On Disk or not.",
        SerializedName = @"logOnDisk",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogOnDisk { get; set; }
        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The redundant type of the server storage. The parameter is used for server creation.",
        SerializedName = @"storageRedundancy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("LocalRedundancy", "ZoneRedundancy")]
        string Redundancy { get; set; }
        /// <summary>Max storage size allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Max storage size allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? SizeGb { get; set; }
        /// <summary>The sku name of the server storage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The sku name of the server storage.",
        SerializedName = @"storageSku",
        PossibleTypes = new [] { typeof(string) })]
        string Sku { get;  }

    }
    /// Storage Profile properties of a server
    internal partial interface IStorageInternal

    {
        /// <summary>Enable Storage Auto Grow or not.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AutoGrow { get; set; }
        /// <summary>Enable IO Auto Scaling or not.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string AutoIoScaling { get; set; }
        /// <summary>Storage IOPS for a server.</summary>
        int? Iop { get; set; }
        /// <summary>Enable Log On Disk or not.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string LogOnDisk { get; set; }
        /// <summary>
        /// The redundant type of the server storage. The parameter is used for server creation.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("LocalRedundancy", "ZoneRedundancy")]
        string Redundancy { get; set; }
        /// <summary>Max storage size allowed for a server.</summary>
        int? SizeGb { get; set; }
        /// <summary>The sku name of the server storage.</summary>
        string Sku { get; set; }

    }
}