// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Extensions;

    /// <summary>The properties of an Extended Zone resource.</summary>
    public partial class ExtendedZoneProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZoneProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="Geography" /> property.</summary>
        private string _geography;

        /// <summary>Geography of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string Geography { get => this._geography; }

        /// <summary>Backing field for <see cref="GeographyGroup" /> property.</summary>
        private string _geographyGroup;

        /// <summary>The Geography Group of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string GeographyGroup { get => this._geographyGroup; }

        /// <summary>Backing field for <see cref="HomeLocation" /> property.</summary>
        private string _homeLocation;

        /// <summary>The Home Location of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string HomeLocation { get => this._homeLocation; }

        /// <summary>Backing field for <see cref="Latitude" /> property.</summary>
        private string _latitude;

        /// <summary>The Latitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string Latitude { get => this._latitude; }

        /// <summary>Backing field for <see cref="Longitude" /> property.</summary>
        private string _longitude;

        /// <summary>The Longitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string Longitude { get => this._longitude; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for Geography</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.Geography { get => this._geography; set { {_geography = value;} } }

        /// <summary>Internal Acessors for GeographyGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.GeographyGroup { get => this._geographyGroup; set { {_geographyGroup = value;} } }

        /// <summary>Internal Acessors for HomeLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.HomeLocation { get => this._homeLocation; set { {_homeLocation = value;} } }

        /// <summary>Internal Acessors for Latitude</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.Latitude { get => this._latitude; set { {_latitude = value;} } }

        /// <summary>Internal Acessors for Longitude</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.Longitude { get => this._longitude; set { {_longitude = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for RegionCategory</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.RegionCategory { get => this._regionCategory; set { {_regionCategory = value;} } }

        /// <summary>Internal Acessors for RegionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.RegionType { get => this._regionType; set { {_regionType = value;} } }

        /// <summary>Internal Acessors for RegionalDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.RegionalDisplayName { get => this._regionalDisplayName; set { {_regionalDisplayName = value;} } }

        /// <summary>Internal Acessors for RegistrationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Models.IExtendedZonePropertiesInternal.RegistrationState { get => this._registrationState; set { {_registrationState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Status of the last operation performed by the subscription on the Edge Zone resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="RegionCategory" /> property.</summary>
        private string _regionCategory;

        /// <summary>Category of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string RegionCategory { get => this._regionCategory; }

        /// <summary>Backing field for <see cref="RegionType" /> property.</summary>
        private string _regionType;

        /// <summary>Type of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string RegionType { get => this._regionType; }

        /// <summary>Backing field for <see cref="RegionalDisplayName" /> property.</summary>
        private string _regionalDisplayName;

        /// <summary>Regional display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string RegionalDisplayName { get => this._regionalDisplayName; }

        /// <summary>Backing field for <see cref="RegistrationState" /> property.</summary>
        private string _registrationState;

        /// <summary>Indicates the Azure Extended Zone registration’s approval status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PropertyOrigin.Owned)]
        public string RegistrationState { get => this._registrationState; }

        /// <summary>Creates an new <see cref="ExtendedZoneProperties" /> instance.</summary>
        public ExtendedZoneProperties()
        {

        }
    }
    /// The properties of an Extended Zone resource.
    public partial interface IExtendedZoneProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Display name of the Azure Extended Zone.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Geography of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Geography of the Azure Extended Zone.",
        SerializedName = @"geography",
        PossibleTypes = new [] { typeof(string) })]
        string Geography { get;  }
        /// <summary>The Geography Group of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Geography Group of the Azure Extended Zone.",
        SerializedName = @"geographyGroup",
        PossibleTypes = new [] { typeof(string) })]
        string GeographyGroup { get;  }
        /// <summary>The Home Location of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Home Location of the Azure Extended Zone.",
        SerializedName = @"homeLocation",
        PossibleTypes = new [] { typeof(string) })]
        string HomeLocation { get;  }
        /// <summary>The Latitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Latitude of the Azure Extended Zone.",
        SerializedName = @"latitude",
        PossibleTypes = new [] { typeof(string) })]
        string Latitude { get;  }
        /// <summary>The Longitude of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The Longitude of the Azure Extended Zone.",
        SerializedName = @"longitude",
        PossibleTypes = new [] { typeof(string) })]
        string Longitude { get;  }
        /// <summary>
        /// Status of the last operation performed by the subscription on the Edge Zone resource
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of the last operation performed by the subscription on the Edge Zone resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>Category of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Category of region for the Azure Extended Zone.",
        SerializedName = @"regionCategory",
        PossibleTypes = new [] { typeof(string) })]
        string RegionCategory { get;  }
        /// <summary>Type of region for the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Type of region for the Azure Extended Zone.",
        SerializedName = @"regionType",
        PossibleTypes = new [] { typeof(string) })]
        string RegionType { get;  }
        /// <summary>Regional display name of the Azure Extended Zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Regional display name of the Azure Extended Zone.",
        SerializedName = @"regionalDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string RegionalDisplayName { get;  }
        /// <summary>Indicates the Azure Extended Zone registration’s approval status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Indicates the Azure Extended Zone registration’s approval status.",
        SerializedName = @"registrationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("NotRegistered", "PendingRegister", "Registered", "PendingUnregister")]
        string RegistrationState { get;  }

    }
    /// The properties of an Extended Zone resource.
    internal partial interface IExtendedZonePropertiesInternal

    {
        /// <summary>Display name of the Azure Extended Zone.</summary>
        string DisplayName { get; set; }
        /// <summary>Geography of the Azure Extended Zone.</summary>
        string Geography { get; set; }
        /// <summary>The Geography Group of the Azure Extended Zone.</summary>
        string GeographyGroup { get; set; }
        /// <summary>The Home Location of the Azure Extended Zone.</summary>
        string HomeLocation { get; set; }
        /// <summary>The Latitude of the Azure Extended Zone.</summary>
        string Latitude { get; set; }
        /// <summary>The Longitude of the Azure Extended Zone.</summary>
        string Longitude { get; set; }
        /// <summary>
        /// Status of the last operation performed by the subscription on the Edge Zone resource
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Category of region for the Azure Extended Zone.</summary>
        string RegionCategory { get; set; }
        /// <summary>Type of region for the Azure Extended Zone.</summary>
        string RegionType { get; set; }
        /// <summary>Regional display name of the Azure Extended Zone.</summary>
        string RegionalDisplayName { get; set; }
        /// <summary>Indicates the Azure Extended Zone registration’s approval status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeZones.PSArgumentCompleterAttribute("NotRegistered", "PendingRegister", "Registered", "PendingUnregister")]
        string RegistrationState { get; set; }

    }
}