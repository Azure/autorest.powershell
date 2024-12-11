// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The restrictions of the SKU.</summary>
    public partial class ResourceSkuRestrictions :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictions,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionsInternal
    {

        /// <summary>Internal Acessors for RestrictionInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfo Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionsInternal.RestrictionInfo { get => (this._restrictionInfo = this._restrictionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuRestrictionInfo()); set { {_restrictionInfo = value;} } }

        /// <summary>Backing field for <see cref="ReasonCode" /> property.</summary>
        private string _reasonCode;

        /// <summary>the reason for restriction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string ReasonCode { get => this._reasonCode; set => this._reasonCode = value; }

        /// <summary>Backing field for <see cref="RestrictionInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfo _restrictionInfo;

        /// <summary>The information about the restriction where the SKU cannot be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfo RestrictionInfo { get => (this._restrictionInfo = this._restrictionInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourceSkuRestrictionInfo()); set => this._restrictionInfo = value; }

        /// <summary>Locations where the SKU is restricted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RestrictionInfoLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Location = value ?? null /* arrayOf */; }

        /// <summary>List of availability zones where the SKU is restricted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RestrictionInfoZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Zone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfoInternal)RestrictionInfo).Zone = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>the type of restrictions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<string> _value;

        /// <summary>
        /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU
        /// is restricted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ResourceSkuRestrictions" /> instance.</summary>
        public ResourceSkuRestrictions()
        {

        }
    }
    /// The restrictions of the SKU.
    public partial interface IResourceSkuRestrictions :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>the reason for restriction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the reason for restriction.",
        SerializedName = @"reasonCode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("QuotaId", "NotAvailableForSubscription")]
        string ReasonCode { get; set; }
        /// <summary>Locations where the SKU is restricted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Locations where the SKU is restricted",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RestrictionInfoLocation { get; set; }
        /// <summary>List of availability zones where the SKU is restricted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of availability zones where the SKU is restricted.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RestrictionInfoZone { get; set; }
        /// <summary>the type of restrictions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"the type of restrictions.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Location", "Zone")]
        string Type { get; set; }
        /// <summary>
        /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU
        /// is restricted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU is restricted.",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Value { get; set; }

    }
    /// The restrictions of the SKU.
    internal partial interface IResourceSkuRestrictionsInternal

    {
        /// <summary>the reason for restriction.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("QuotaId", "NotAvailableForSubscription")]
        string ReasonCode { get; set; }
        /// <summary>The information about the restriction where the SKU cannot be used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourceSkuRestrictionInfo RestrictionInfo { get; set; }
        /// <summary>Locations where the SKU is restricted</summary>
        System.Collections.Generic.List<string> RestrictionInfoLocation { get; set; }
        /// <summary>List of availability zones where the SKU is restricted.</summary>
        System.Collections.Generic.List<string> RestrictionInfoZone { get; set; }
        /// <summary>the type of restrictions.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Location", "Zone")]
        string Type { get; set; }
        /// <summary>
        /// The value of restrictions. If the restriction type is set to location. This would be different locations where the SKU
        /// is restricted.
        /// </summary>
        System.Collections.Generic.List<string> Value { get; set; }

    }
}