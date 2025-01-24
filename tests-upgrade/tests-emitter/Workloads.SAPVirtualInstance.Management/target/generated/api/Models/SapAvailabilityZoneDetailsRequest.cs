// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP request to get list of availability zones.</summary>
    public partial class SapAvailabilityZoneDetailsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZoneDetailsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapAvailabilityZoneDetailsRequestInternal
    {

        /// <summary>Backing field for <see cref="AppLocation" /> property.</summary>
        private string _appLocation;

        /// <summary>The geo-location where the SAP resources will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string AppLocation { get => this._appLocation; set => this._appLocation = value; }

        /// <summary>Backing field for <see cref="DatabaseType" /> property.</summary>
        private string _databaseType;

        /// <summary>The database type. Eg: HANA, DB2, etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DatabaseType { get => this._databaseType; set => this._databaseType = value; }

        /// <summary>Backing field for <see cref="SapProduct" /> property.</summary>
        private string _sapProduct;

        /// <summary>Defines the SAP Product type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string SapProduct { get => this._sapProduct; set => this._sapProduct = value; }

        /// <summary>Creates an new <see cref="SapAvailabilityZoneDetailsRequest" /> instance.</summary>
        public SapAvailabilityZoneDetailsRequest()
        {

        }
    }
    /// The SAP request to get list of availability zones.
    public partial interface ISapAvailabilityZoneDetailsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The geo-location where the SAP resources will be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The geo-location where the SAP resources will be created.",
        SerializedName = @"appLocation",
        PossibleTypes = new [] { typeof(string) })]
        string AppLocation { get; set; }
        /// <summary>The database type. Eg: HANA, DB2, etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The database type. Eg: HANA, DB2, etc",
        SerializedName = @"databaseType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("HANA", "DB2")]
        string DatabaseType { get; set; }
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
    /// The SAP request to get list of availability zones.
    internal partial interface ISapAvailabilityZoneDetailsRequestInternal

    {
        /// <summary>The geo-location where the SAP resources will be created.</summary>
        string AppLocation { get; set; }
        /// <summary>The database type. Eg: HANA, DB2, etc</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("HANA", "DB2")]
        string DatabaseType { get; set; }
        /// <summary>Defines the SAP Product type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("ECC", "S4HANA", "Other")]
        string SapProduct { get; set; }

    }
}