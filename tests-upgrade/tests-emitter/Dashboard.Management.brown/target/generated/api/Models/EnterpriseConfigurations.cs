// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Enterprise settings of a Grafana instance</summary>
    public partial class EnterpriseConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurations,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IEnterpriseConfigurationsInternal
    {

        /// <summary>Backing field for <see cref="MarketplaceAutoRenew" /> property.</summary>
        private string _marketplaceAutoRenew;

        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string MarketplaceAutoRenew { get => this._marketplaceAutoRenew; set => this._marketplaceAutoRenew = value; }

        /// <summary>Backing field for <see cref="MarketplacePlanId" /> property.</summary>
        private string _marketplacePlanId;

        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string MarketplacePlanId { get => this._marketplacePlanId; set => this._marketplacePlanId = value; }

        /// <summary>Creates an new <see cref="EnterpriseConfigurations" /> instance.</summary>
        public EnterpriseConfigurations()
        {

        }
    }
    /// Enterprise settings of a Grafana instance
    public partial interface IEnterpriseConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The AutoRenew setting of the Enterprise subscription",
        SerializedName = @"marketplaceAutoRenew",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string MarketplaceAutoRenew { get; set; }
        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Plan Id of the Azure Marketplace subscription for the Enterprise plugins",
        SerializedName = @"marketplacePlanId",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplacePlanId { get; set; }

    }
    /// Enterprise settings of a Grafana instance
    internal partial interface IEnterpriseConfigurationsInternal

    {
        /// <summary>The AutoRenew setting of the Enterprise subscription</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Disabled", "Enabled")]
        string MarketplaceAutoRenew { get; set; }
        /// <summary>The Plan Id of the Azure Marketplace subscription for the Enterprise plugins</summary>
        string MarketplacePlanId { get; set; }

    }
}