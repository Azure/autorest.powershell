// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP Sizing Recommendation request.</summary>
    public partial class SapSizingRecommendationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationRequest,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationRequestInternal
    {

        /// <summary>Backing field for <see cref="AppLocation" /> property.</summary>
        private string _appLocation;

        /// <summary>The geo-location where the resource is to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AppLocation { get => this._appLocation; set => this._appLocation = value; }

        /// <summary>Backing field for <see cref="DatabaseType" /> property.</summary>
        private string _databaseType;

        /// <summary>The database type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DatabaseType { get => this._databaseType; set => this._databaseType = value; }

        /// <summary>Backing field for <see cref="DbMemory" /> property.</summary>
        private long _dbMemory;

        /// <summary>The database memory configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long DbMemory { get => this._dbMemory; set => this._dbMemory = value; }

        /// <summary>Backing field for <see cref="DbScaleMethod" /> property.</summary>
        private string _dbScaleMethod;

        /// <summary>The DB scale method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DbScaleMethod { get => this._dbScaleMethod; set => this._dbScaleMethod = value; }

        /// <summary>Backing field for <see cref="DeploymentType" /> property.</summary>
        private string _deploymentType;

        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DeploymentType { get => this._deploymentType; set => this._deploymentType = value; }

        /// <summary>Backing field for <see cref="Environment" /> property.</summary>
        private string _environment;

        /// <summary>Defines the environment type - Production/Non Production.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string Environment { get => this._environment; set => this._environment = value; }

        /// <summary>Backing field for <see cref="HighAvailabilityType" /> property.</summary>
        private string _highAvailabilityType;

        /// <summary>The high availability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string HighAvailabilityType { get => this._highAvailabilityType; set => this._highAvailabilityType = value; }

        /// <summary>Backing field for <see cref="Sap" /> property.</summary>
        private long _sap;

        /// <summary>The SAP Application Performance Standard measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public long Sap { get => this._sap; set => this._sap = value; }

        /// <summary>Backing field for <see cref="SapProduct" /> property.</summary>
        private string _sapProduct;

        /// <summary>Defines the SAP Product type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SapProduct { get => this._sapProduct; set => this._sapProduct = value; }

        /// <summary>Creates an new <see cref="SapSizingRecommendationRequest" /> instance.</summary>
        public SapSizingRecommendationRequest()
        {

        }
    }
    /// The SAP Sizing Recommendation request.
    public partial interface ISapSizingRecommendationRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The geo-location where the resource is to be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The geo-location where the resource is to be created.",
        SerializedName = @"appLocation",
        PossibleTypes = new [] { typeof(string) })]
        string AppLocation { get; set; }
        /// <summary>The database type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The database type.",
        SerializedName = @"databaseType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("HANA", "DB2")]
        string DatabaseType { get; set; }
        /// <summary>The database memory configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The database memory configuration.",
        SerializedName = @"dbMemory",
        PossibleTypes = new [] { typeof(long) })]
        long DbMemory { get; set; }
        /// <summary>The DB scale method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The DB scale method.",
        SerializedName = @"dbScaleMethod",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ScaleUp")]
        string DbScaleMethod { get; set; }
        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deployment type. Eg: SingleServer/ThreeTier",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string DeploymentType { get; set; }
        /// <summary>Defines the environment type - Production/Non Production.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the environment type - Production/Non Production.",
        SerializedName = @"environment",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("NonProd", "Prod")]
        string Environment { get; set; }
        /// <summary>The high availability type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The high availability type.",
        SerializedName = @"highAvailabilityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("AvailabilitySet", "AvailabilityZone")]
        string HighAvailabilityType { get; set; }
        /// <summary>The SAP Application Performance Standard measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The SAP Application Performance Standard measurement.",
        SerializedName = @"saps",
        PossibleTypes = new [] { typeof(long) })]
        long Sap { get; set; }
        /// <summary>Defines the SAP Product type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the SAP Product type.",
        SerializedName = @"sapProduct",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ECC", "S4HANA", "Other")]
        string SapProduct { get; set; }

    }
    /// The SAP Sizing Recommendation request.
    internal partial interface ISapSizingRecommendationRequestInternal

    {
        /// <summary>The geo-location where the resource is to be created.</summary>
        string AppLocation { get; set; }
        /// <summary>The database type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("HANA", "DB2")]
        string DatabaseType { get; set; }
        /// <summary>The database memory configuration.</summary>
        long DbMemory { get; set; }
        /// <summary>The DB scale method.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ScaleUp")]
        string DbScaleMethod { get; set; }
        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string DeploymentType { get; set; }
        /// <summary>Defines the environment type - Production/Non Production.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("NonProd", "Prod")]
        string Environment { get; set; }
        /// <summary>The high availability type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("AvailabilitySet", "AvailabilityZone")]
        string HighAvailabilityType { get; set; }
        /// <summary>The SAP Application Performance Standard measurement.</summary>
        long Sap { get; set; }
        /// <summary>Defines the SAP Product type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ECC", "S4HANA", "Other")]
        string SapProduct { get; set; }

    }
}