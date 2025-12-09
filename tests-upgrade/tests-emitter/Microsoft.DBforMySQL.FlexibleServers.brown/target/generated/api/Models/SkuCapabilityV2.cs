// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Sku capability</summary>
    public partial class SkuCapabilityV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal
    {

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for SupportedHaMode</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal.SupportedHaMode { get => this._supportedHaMode; set { {_supportedHaMode = value;} } }

        /// <summary>Internal Acessors for SupportedIop</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal.SupportedIop { get => this._supportedIop; set { {_supportedIop = value;} } }

        /// <summary>Internal Acessors for SupportedMemoryPerVCoreMb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal.SupportedMemoryPerVCoreMb { get => this._supportedMemoryPerVCoreMb; set { {_supportedMemoryPerVCoreMb = value;} } }

        /// <summary>Internal Acessors for SupportedZone</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal.SupportedZone { get => this._supportedZone; set { {_supportedZone = value;} } }

        /// <summary>Internal Acessors for VCore</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2Internal.VCore { get => this._vCore; set { {_vCore = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>vCore name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="SupportedHaMode" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedHaMode;

        /// <summary>Supported high availability mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedHaMode { get => this._supportedHaMode; }

        /// <summary>Backing field for <see cref="SupportedIop" /> property.</summary>
        private long? _supportedIop;

        /// <summary>supported IOPS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? SupportedIop { get => this._supportedIop; }

        /// <summary>Backing field for <see cref="SupportedMemoryPerVCoreMb" /> property.</summary>
        private long? _supportedMemoryPerVCoreMb;

        /// <summary>supported memory per vCore in MB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? SupportedMemoryPerVCoreMb { get => this._supportedMemoryPerVCoreMb; }

        /// <summary>Backing field for <see cref="SupportedZone" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedZone;

        /// <summary>Supported zones</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedZone { get => this._supportedZone; }

        /// <summary>Backing field for <see cref="VCore" /> property.</summary>
        private long? _vCore;

        /// <summary>supported vCores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public long? VCore { get => this._vCore; }

        /// <summary>Creates an new <see cref="SkuCapabilityV2" /> instance.</summary>
        public SkuCapabilityV2()
        {

        }
    }
    /// Sku capability
    public partial interface ISkuCapabilityV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>vCore name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"vCore name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Supported high availability mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Supported high availability mode",
        SerializedName = @"supportedHAMode",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedHaMode { get;  }
        /// <summary>supported IOPS</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"supported IOPS",
        SerializedName = @"supportedIops",
        PossibleTypes = new [] { typeof(long) })]
        long? SupportedIop { get;  }
        /// <summary>supported memory per vCore in MB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"supported memory per vCore in MB",
        SerializedName = @"supportedMemoryPerVCoreMB",
        PossibleTypes = new [] { typeof(long) })]
        long? SupportedMemoryPerVCoreMb { get;  }
        /// <summary>Supported zones</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Supported zones",
        SerializedName = @"supportedZones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedZone { get;  }
        /// <summary>supported vCores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"supported vCores",
        SerializedName = @"vCores",
        PossibleTypes = new [] { typeof(long) })]
        long? VCore { get;  }

    }
    /// Sku capability
    internal partial interface ISkuCapabilityV2Internal

    {
        /// <summary>vCore name</summary>
        string Name { get; set; }
        /// <summary>Supported high availability mode</summary>
        System.Collections.Generic.List<string> SupportedHaMode { get; set; }
        /// <summary>supported IOPS</summary>
        long? SupportedIop { get; set; }
        /// <summary>supported memory per vCore in MB</summary>
        long? SupportedMemoryPerVCoreMb { get; set; }
        /// <summary>Supported zones</summary>
        System.Collections.Generic.List<string> SupportedZone { get; set; }
        /// <summary>supported vCores</summary>
        long? VCore { get; set; }

    }
}