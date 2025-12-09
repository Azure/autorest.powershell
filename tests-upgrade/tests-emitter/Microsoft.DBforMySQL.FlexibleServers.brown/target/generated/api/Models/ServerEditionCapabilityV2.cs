// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Server edition capabilities.</summary>
    public partial class ServerEditionCapabilityV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2Internal
    {

        /// <summary>Backing field for <see cref="DefaultSku" /> property.</summary>
        private string _defaultSku;

        /// <summary>Default Sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string DefaultSku { get => this._defaultSku; }

        /// <summary>Backing field for <see cref="DefaultStorageSize" /> property.</summary>
        private int? _defaultStorageSize;

        /// <summary>Default storage size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public int? DefaultStorageSize { get => this._defaultStorageSize; }

        /// <summary>Internal Acessors for DefaultSku</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2Internal.DefaultSku { get => this._defaultSku; set { {_defaultSku = value;} } }

        /// <summary>Internal Acessors for DefaultStorageSize</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2Internal.DefaultStorageSize { get => this._defaultStorageSize; set { {_defaultStorageSize = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2Internal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for SupportedSku</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2Internal.SupportedSku { get => this._supportedSku; set { {_supportedSku = value;} } }

        /// <summary>Internal Acessors for SupportedStorageEdition</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2Internal.SupportedStorageEdition { get => this._supportedStorageEdition; set { {_supportedStorageEdition = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Server edition name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="SupportedSku" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2> _supportedSku;

        /// <summary>A list of supported Skus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2> SupportedSku { get => this._supportedSku; }

        /// <summary>Backing field for <see cref="SupportedStorageEdition" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability> _supportedStorageEdition;

        /// <summary>A list of supported storage editions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability> SupportedStorageEdition { get => this._supportedStorageEdition; }

        /// <summary>Creates an new <see cref="ServerEditionCapabilityV2" /> instance.</summary>
        public ServerEditionCapabilityV2()
        {

        }
    }
    /// Server edition capabilities.
    public partial interface IServerEditionCapabilityV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Default Sku name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Default Sku name",
        SerializedName = @"defaultSku",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultSku { get;  }
        /// <summary>Default storage size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Default storage size",
        SerializedName = @"defaultStorageSize",
        PossibleTypes = new [] { typeof(int) })]
        int? DefaultStorageSize { get;  }
        /// <summary>Server edition name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Server edition name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>A list of supported Skus</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of supported Skus",
        SerializedName = @"supportedSkus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2> SupportedSku { get;  }
        /// <summary>A list of supported storage editions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of supported storage editions",
        SerializedName = @"supportedStorageEditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability> SupportedStorageEdition { get;  }

    }
    /// Server edition capabilities.
    internal partial interface IServerEditionCapabilityV2Internal

    {
        /// <summary>Default Sku name</summary>
        string DefaultSku { get; set; }
        /// <summary>Default storage size</summary>
        int? DefaultStorageSize { get; set; }
        /// <summary>Server edition name</summary>
        string Name { get; set; }
        /// <summary>A list of supported Skus</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ISkuCapabilityV2> SupportedSku { get; set; }
        /// <summary>A list of supported storage editions</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IStorageEditionCapability> SupportedStorageEdition { get; set; }

    }
}