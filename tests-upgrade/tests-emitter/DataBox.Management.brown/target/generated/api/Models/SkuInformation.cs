// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Information of the sku.</summary>
    public partial class SkuInformation :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformation,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal
    {

        /// <summary>Api versions that support this Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ApiVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).ApiVersion; }

        /// <summary>Maximum capacity per device in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CapacityIndividualSkuUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityIndividualSkuUsable; }

        /// <summary>Maximum capacity in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityMaximum; }

        /// <summary>Usable capacity in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CapacityUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityUsable; }

        /// <summary>Cost of the Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> Cost { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).Cost; }

        /// <summary>List of all the Countries in the SKU specific commerce boundary</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> CountriesWithinCommerceBoundary { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CountriesWithinCommerceBoundary; }

        /// <summary>The map of data location to service location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> DataLocationToServiceLocationMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DataLocationToServiceLocationMap; }

        /// <summary>Reason why the Sku is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DisabledReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DisabledReason; }

        /// <summary>Message for why the Sku is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string DisabledReasonMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DisabledReasonMessage; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>The sku is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; }

        /// <summary>Internal Acessors for ApiVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.ApiVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).ApiVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).ApiVersion = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Capacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.Capacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).Capacity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for CapacityIndividualSkuUsable</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.CapacityIndividualSkuUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityIndividualSkuUsable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityIndividualSkuUsable = value ?? null; }

        /// <summary>Internal Acessors for CapacityMaximum</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.CapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityMaximum; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityMaximum = value ?? null; }

        /// <summary>Internal Acessors for CapacityUsable</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.CapacityUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityUsable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CapacityUsable = value ?? null; }

        /// <summary>Internal Acessors for Cost</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.Cost { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).Cost; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).Cost = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for CountriesWithinCommerceBoundary</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.CountriesWithinCommerceBoundary { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CountriesWithinCommerceBoundary; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).CountriesWithinCommerceBoundary = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DataLocationToServiceLocationMap</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.DataLocationToServiceLocationMap { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DataLocationToServiceLocationMap; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DataLocationToServiceLocationMap = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for DisabledReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.DisabledReason { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DisabledReason; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DisabledReason = value ?? null; }

        /// <summary>Internal Acessors for DisabledReasonMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.DisabledReasonMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DisabledReasonMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).DisabledReasonMessage = value ?? null; }

        /// <summary>Internal Acessors for Enabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.Enabled { get => this._enabled; set { {_enabled = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for RequiredFeature</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.RequiredFeature { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).RequiredFeature; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).RequiredFeature = value ?? null; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Sku()); set { {_sku = value;} } }

        /// <summary>Internal Acessors for SkuDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.SkuDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for SkuFamily</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Family = value ?? null; }

        /// <summary>Internal Acessors for SkuModel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.SkuModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Model = value ?? null; }

        /// <summary>Internal Acessors for SkuName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInformationInternal.SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties _property;

        /// <summary>Properties of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuProperties()); }

        /// <summary>Required feature to access the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string RequiredFeature { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal)Property).RequiredFeature; }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku _sku;

        /// <summary>The Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Sku()); }

        /// <summary>The display name of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).DisplayName; }

        /// <summary>The sku family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Family; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Model; }

        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuInternal)Sku).Name; }

        /// <summary>Creates an new <see cref="SkuInformation" /> instance.</summary>
        public SkuInformation()
        {

        }
    }
    /// Information of the sku.
    public partial interface ISkuInformation :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Api versions that support this Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Api versions that support this Sku.",
        SerializedName = @"apiVersions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ApiVersion { get;  }
        /// <summary>Maximum capacity per device in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Maximum capacity per device in TB.",
        SerializedName = @"individualSkuUsable",
        PossibleTypes = new [] { typeof(string) })]
        string CapacityIndividualSkuUsable { get;  }
        /// <summary>Maximum capacity in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Maximum capacity in TB.",
        SerializedName = @"maximum",
        PossibleTypes = new [] { typeof(string) })]
        string CapacityMaximum { get;  }
        /// <summary>Usable capacity in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Usable capacity in TB.",
        SerializedName = @"usable",
        PossibleTypes = new [] { typeof(string) })]
        string CapacityUsable { get;  }
        /// <summary>Cost of the Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Cost of the Sku.",
        SerializedName = @"costs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> Cost { get;  }
        /// <summary>List of all the Countries in the SKU specific commerce boundary</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of all the Countries in the SKU specific commerce boundary",
        SerializedName = @"countriesWithinCommerceBoundary",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> CountriesWithinCommerceBoundary { get;  }
        /// <summary>The map of data location to service location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The map of data location to service location.",
        SerializedName = @"dataLocationToServiceLocationMap",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> DataLocationToServiceLocationMap { get;  }
        /// <summary>Reason why the Sku is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Reason why the Sku is disabled.",
        SerializedName = @"disabledReason",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Country", "Region", "Feature", "OfferType", "NoSubscriptionInfo")]
        string DisabledReason { get;  }
        /// <summary>Message for why the Sku is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Message for why the Sku is disabled.",
        SerializedName = @"disabledReasonMessage",
        PossibleTypes = new [] { typeof(string) })]
        string DisabledReasonMessage { get;  }
        /// <summary>The sku is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The sku is enabled or not.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get;  }
        /// <summary>Required feature to access the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Required feature to access the sku.",
        SerializedName = @"requiredFeature",
        PossibleTypes = new [] { typeof(string) })]
        string RequiredFeature { get;  }
        /// <summary>The display name of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The display name of the sku.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string SkuDisplayName { get;  }
        /// <summary>The sku family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The sku family.",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string SkuFamily { get;  }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string SkuModel { get;  }
        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get;  }

    }
    /// Information of the sku.
    internal partial interface ISkuInformationInternal

    {
        /// <summary>Api versions that support this Sku.</summary>
        System.Collections.Generic.List<string> ApiVersion { get; set; }
        /// <summary>Capacity of the Sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity Capacity { get; set; }
        /// <summary>Maximum capacity per device in TB.</summary>
        string CapacityIndividualSkuUsable { get; set; }
        /// <summary>Maximum capacity in TB.</summary>
        string CapacityMaximum { get; set; }
        /// <summary>Usable capacity in TB.</summary>
        string CapacityUsable { get; set; }
        /// <summary>Cost of the Sku.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> Cost { get; set; }
        /// <summary>List of all the Countries in the SKU specific commerce boundary</summary>
        System.Collections.Generic.List<string> CountriesWithinCommerceBoundary { get; set; }
        /// <summary>The map of data location to service location.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> DataLocationToServiceLocationMap { get; set; }
        /// <summary>Reason why the Sku is disabled.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("None", "Country", "Region", "Feature", "OfferType", "NoSubscriptionInfo")]
        string DisabledReason { get; set; }
        /// <summary>Message for why the Sku is disabled.</summary>
        string DisabledReasonMessage { get; set; }
        /// <summary>The sku is enabled or not.</summary>
        bool? Enabled { get; set; }
        /// <summary>Properties of the sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties Property { get; set; }
        /// <summary>Required feature to access the sku.</summary>
        string RequiredFeature { get; set; }
        /// <summary>The Sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISku Sku { get; set; }
        /// <summary>The display name of the sku.</summary>
        string SkuDisplayName { get; set; }
        /// <summary>The sku family.</summary>
        string SkuFamily { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk", "AzureDataBox120", "AzureDataBox525")]
        string SkuModel { get; set; }
        /// <summary>The sku name.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("DataBox", "DataBoxDisk", "DataBoxHeavy", "DataBoxCustomerDisk")]
        string SkuName { get; set; }

    }
}