// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>ManagedResourceGroup related properties</summary>
    public partial class ManagedResourceGroupConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IManagedResourceGroupConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Managed Resource Group location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of managed resource group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="ManagedResourceGroupConfiguration" /> instance.</summary>
        public ManagedResourceGroupConfiguration()
        {

        }
    }
    /// ManagedResourceGroup related properties
    public partial interface IManagedResourceGroupConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Managed Resource Group location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed Resource Group location",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Name of managed resource group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of managed resource group",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// ManagedResourceGroup related properties
    internal partial interface IManagedResourceGroupConfigurationInternal

    {
        /// <summary>Managed Resource Group location</summary>
        string Location { get; set; }
        /// <summary>Name of managed resource group</summary>
        string Name { get; set; }

    }
}