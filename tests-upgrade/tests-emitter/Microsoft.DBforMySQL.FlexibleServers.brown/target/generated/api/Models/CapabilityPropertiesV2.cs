// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Location capability.</summary>
    public partial class CapabilityPropertiesV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ICapabilityPropertiesV2,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ICapabilityPropertiesV2Internal
    {

        /// <summary>Internal Acessors for SupportedFeature</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ICapabilityPropertiesV2Internal.SupportedFeature { get => this._supportedFeature; set { {_supportedFeature = value;} } }

        /// <summary>Internal Acessors for SupportedFlexibleServerEdition</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ICapabilityPropertiesV2Internal.SupportedFlexibleServerEdition { get => this._supportedFlexibleServerEdition; set { {_supportedFlexibleServerEdition = value;} } }

        /// <summary>Internal Acessors for SupportedGeoBackupRegion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ICapabilityPropertiesV2Internal.SupportedGeoBackupRegion { get => this._supportedGeoBackupRegion; set { {_supportedGeoBackupRegion = value;} } }

        /// <summary>Internal Acessors for SupportedServerVersion</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2> Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.ICapabilityPropertiesV2Internal.SupportedServerVersion { get => this._supportedServerVersion; set { {_supportedServerVersion = value;} } }

        /// <summary>Backing field for <see cref="SupportedFeature" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty> _supportedFeature;

        /// <summary>A list of supported features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty> SupportedFeature { get => this._supportedFeature; }

        /// <summary>Backing field for <see cref="SupportedFlexibleServerEdition" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2> _supportedFlexibleServerEdition;

        /// <summary>A list of supported flexible server editions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2> SupportedFlexibleServerEdition { get => this._supportedFlexibleServerEdition; }

        /// <summary>Backing field for <see cref="SupportedGeoBackupRegion" /> property.</summary>
        private System.Collections.Generic.List<string> _supportedGeoBackupRegion;

        /// <summary>supported geo backup regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SupportedGeoBackupRegion { get => this._supportedGeoBackupRegion; }

        /// <summary>Backing field for <see cref="SupportedServerVersion" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2> _supportedServerVersion;

        /// <summary>A list of supported server versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2> SupportedServerVersion { get => this._supportedServerVersion; }

        /// <summary>Creates an new <see cref="CapabilityPropertiesV2" /> instance.</summary>
        public CapabilityPropertiesV2()
        {

        }
    }
    /// Location capability.
    public partial interface ICapabilityPropertiesV2 :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>A list of supported features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of supported features.",
        SerializedName = @"supportedFeatures",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty> SupportedFeature { get;  }
        /// <summary>A list of supported flexible server editions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of supported flexible server editions.",
        SerializedName = @"supportedFlexibleServerEditions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2> SupportedFlexibleServerEdition { get;  }
        /// <summary>supported geo backup regions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"supported geo backup regions",
        SerializedName = @"supportedGeoBackupRegions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedGeoBackupRegion { get;  }
        /// <summary>A list of supported server versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of supported server versions.",
        SerializedName = @"supportedServerVersions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2> SupportedServerVersion { get;  }

    }
    /// Location capability.
    internal partial interface ICapabilityPropertiesV2Internal

    {
        /// <summary>A list of supported features.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty> SupportedFeature { get; set; }
        /// <summary>A list of supported flexible server editions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerEditionCapabilityV2> SupportedFlexibleServerEdition { get; set; }
        /// <summary>supported geo backup regions</summary>
        System.Collections.Generic.List<string> SupportedGeoBackupRegion { get; set; }
        /// <summary>A list of supported server versions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IServerVersionCapabilityV2> SupportedServerVersion { get; set; }

    }
}