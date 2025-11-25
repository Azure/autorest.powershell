// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Properties of the sku.</summary>
    public partial class SkuProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private System.Collections.Generic.List<string> _apiVersion;

        /// <summary>Api versions that support this Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ApiVersion { get => this._apiVersion; }

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity _capacity;

        /// <summary>Capacity of the Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCapacity()); }

        /// <summary>Maximum capacity per device in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CapacityIndividualSkuUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).IndividualSkuUsable; }

        /// <summary>Maximum capacity in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).Maximum; }

        /// <summary>Usable capacity in TB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string CapacityUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).Usable; }

        /// <summary>Backing field for <see cref="Cost" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> _cost;

        /// <summary>Cost of the Sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> Cost { get => this._cost; }

        /// <summary>Backing field for <see cref="CountriesWithinCommerceBoundary" /> property.</summary>
        private System.Collections.Generic.List<string> _countriesWithinCommerceBoundary;

        /// <summary>List of all the Countries in the SKU specific commerce boundary</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> CountriesWithinCommerceBoundary { get => this._countriesWithinCommerceBoundary; }

        /// <summary>Backing field for <see cref="DataLocationToServiceLocationMap" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> _dataLocationToServiceLocationMap;

        /// <summary>The map of data location to service location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> DataLocationToServiceLocationMap { get => this._dataLocationToServiceLocationMap; }

        /// <summary>Backing field for <see cref="DisabledReason" /> property.</summary>
        private string _disabledReason;

        /// <summary>Reason why the Sku is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DisabledReason { get => this._disabledReason; }

        /// <summary>Backing field for <see cref="DisabledReasonMessage" /> property.</summary>
        private string _disabledReasonMessage;

        /// <summary>Message for why the Sku is disabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string DisabledReasonMessage { get => this._disabledReasonMessage; }

        /// <summary>Internal Acessors for ApiVersion</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.ApiVersion { get => this._apiVersion; set { {_apiVersion = value;} } }

        /// <summary>Internal Acessors for Capacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacity Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.Capacity { get => (this._capacity = this._capacity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.SkuCapacity()); set { {_capacity = value;} } }

        /// <summary>Internal Acessors for CapacityIndividualSkuUsable</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.CapacityIndividualSkuUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).IndividualSkuUsable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).IndividualSkuUsable = value ?? null; }

        /// <summary>Internal Acessors for CapacityMaximum</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.CapacityMaximum { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).Maximum; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).Maximum = value ?? null; }

        /// <summary>Internal Acessors for CapacityUsable</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.CapacityUsable { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).Usable; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCapacityInternal)Capacity).Usable = value ?? null; }

        /// <summary>Internal Acessors for Cost</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuCost> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.Cost { get => this._cost; set { {_cost = value;} } }

        /// <summary>Internal Acessors for CountriesWithinCommerceBoundary</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.CountriesWithinCommerceBoundary { get => this._countriesWithinCommerceBoundary; set { {_countriesWithinCommerceBoundary = value;} } }

        /// <summary>Internal Acessors for DataLocationToServiceLocationMap</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDataLocationToServiceLocationMap> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.DataLocationToServiceLocationMap { get => this._dataLocationToServiceLocationMap; set { {_dataLocationToServiceLocationMap = value;} } }

        /// <summary>Internal Acessors for DisabledReason</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.DisabledReason { get => this._disabledReason; set { {_disabledReason = value;} } }

        /// <summary>Internal Acessors for DisabledReasonMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.DisabledReasonMessage { get => this._disabledReasonMessage; set { {_disabledReasonMessage = value;} } }

        /// <summary>Internal Acessors for RequiredFeature</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ISkuPropertiesInternal.RequiredFeature { get => this._requiredFeature; set { {_requiredFeature = value;} } }

        /// <summary>Backing field for <see cref="RequiredFeature" /> property.</summary>
        private string _requiredFeature;

        /// <summary>Required feature to access the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string RequiredFeature { get => this._requiredFeature; }

        /// <summary>Creates an new <see cref="SkuProperties" /> instance.</summary>
        public SkuProperties()
        {

        }
    }
    /// Properties of the sku.
    public partial interface ISkuProperties :
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

    }
    /// Properties of the sku.
    internal partial interface ISkuPropertiesInternal

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
        /// <summary>Required feature to access the sku.</summary>
        string RequiredFeature { get; set; }

    }
}