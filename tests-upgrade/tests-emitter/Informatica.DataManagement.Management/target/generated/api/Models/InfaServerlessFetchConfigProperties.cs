// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>
    /// InfaServerlessFetchConfigProperties for the fetch all serverless API as received from informatica API response
    /// </summary>
    public partial class InfaServerlessFetchConfigProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaServerlessFetchConfigPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdvancedCustomProperty" /> property.</summary>
        private string _advancedCustomProperty;

        /// <summary>Advanced custom properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string AdvancedCustomProperty { get => this._advancedCustomProperty; set => this._advancedCustomProperty = value; }

        /// <summary>Backing field for <see cref="ApplicationType" /> property.</summary>
        private string _applicationType;

        /// <summary>applicationType name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ApplicationType { get => this._applicationType; set => this._applicationType = value; }

        /// <summary>Backing field for <see cref="ComputeUnit" /> property.</summary>
        private string _computeUnit;

        /// <summary>Compute Units</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ComputeUnit { get => this._computeUnit; set => this._computeUnit = value; }

        /// <summary>Backing field for <see cref="ExecutionTimeout" /> property.</summary>
        private string _executionTimeout;

        /// <summary>Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ExecutionTimeout { get => this._executionTimeout; set => this._executionTimeout = value; }

        /// <summary>Backing field for <see cref="Platform" /> property.</summary>
        private string _platform;

        /// <summary>Serverless Account Platform</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Platform { get => this._platform; set => this._platform = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>region name for the runtime environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>Resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="ServerlessArmResourceId" /> property.</summary>
        private string _serverlessArmResourceId;

        /// <summary>Serverless Arm Resource ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string ServerlessArmResourceId { get => this._serverlessArmResourceId; set => this._serverlessArmResourceId = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private string _subnet;

        /// <summary>subnet name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Subnet { get => this._subnet; set => this._subnet = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>subscription ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="SupplementaryFileLocation" /> property.</summary>
        private string _supplementaryFileLocation;

        /// <summary>Supplementary File location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string SupplementaryFileLocation { get => this._supplementaryFileLocation; set => this._supplementaryFileLocation = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string _tag;

        /// <summary>Tags for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Tenant ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Backing field for <see cref="Vnet" /> property.</summary>
        private string _vnet;

        /// <summary>virtual network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Vnet { get => this._vnet; set => this._vnet = value; }

        /// <summary>Creates an new <see cref="InfaServerlessFetchConfigProperties" /> instance.</summary>
        public InfaServerlessFetchConfigProperties()
        {

        }
    }
    /// InfaServerlessFetchConfigProperties for the fetch all serverless API as received from informatica API response
    public partial interface IInfaServerlessFetchConfigProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Advanced custom properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Advanced custom properties",
        SerializedName = @"advancedCustomProperties",
        PossibleTypes = new [] { typeof(string) })]
        string AdvancedCustomProperty { get; set; }
        /// <summary>applicationType name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"applicationType name",
        SerializedName = @"applicationType",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationType { get; set; }
        /// <summary>Compute Units</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Compute Units",
        SerializedName = @"computeUnits",
        PossibleTypes = new [] { typeof(string) })]
        string ComputeUnit { get; set; }
        /// <summary>Execution timeout</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Execution timeout",
        SerializedName = @"executionTimeout",
        PossibleTypes = new [] { typeof(string) })]
        string ExecutionTimeout { get; set; }
        /// <summary>Serverless Account Platform</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Account Platform",
        SerializedName = @"platform",
        PossibleTypes = new [] { typeof(string) })]
        string Platform { get; set; }
        /// <summary>region name for the runtime environment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"region name for the runtime environment",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }
        /// <summary>Resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource group name",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>Serverless Arm Resource ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serverless Arm Resource ID",
        SerializedName = @"serverlessArmResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ServerlessArmResourceId { get; set; }
        /// <summary>subnet name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"subnet name",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string Subnet { get; set; }
        /// <summary>subscription ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"subscription ID",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>Supplementary File location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Supplementary File location",
        SerializedName = @"supplementaryFileLocation",
        PossibleTypes = new [] { typeof(string) })]
        string SupplementaryFileLocation { get; set; }
        /// <summary>Tags for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tags for the resource",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string Tag { get; set; }
        /// <summary>Tenant ID</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Tenant ID",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }
        /// <summary>virtual network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"virtual network",
        SerializedName = @"vnet",
        PossibleTypes = new [] { typeof(string) })]
        string Vnet { get; set; }

    }
    /// InfaServerlessFetchConfigProperties for the fetch all serverless API as received from informatica API response
    internal partial interface IInfaServerlessFetchConfigPropertiesInternal

    {
        /// <summary>Advanced custom properties</summary>
        string AdvancedCustomProperty { get; set; }
        /// <summary>applicationType name</summary>
        string ApplicationType { get; set; }
        /// <summary>Compute Units</summary>
        string ComputeUnit { get; set; }
        /// <summary>Execution timeout</summary>
        string ExecutionTimeout { get; set; }
        /// <summary>Serverless Account Platform</summary>
        string Platform { get; set; }
        /// <summary>region name for the runtime environment</summary>
        string Region { get; set; }
        /// <summary>Resource group name</summary>
        string ResourceGroupName { get; set; }
        /// <summary>Serverless Arm Resource ID</summary>
        string ServerlessArmResourceId { get; set; }
        /// <summary>subnet name</summary>
        string Subnet { get; set; }
        /// <summary>subscription ID</summary>
        string SubscriptionId { get; set; }
        /// <summary>Supplementary File location</summary>
        string SupplementaryFileLocation { get; set; }
        /// <summary>Tags for the resource</summary>
        string Tag { get; set; }
        /// <summary>Tenant ID</summary>
        string TenantId { get; set; }
        /// <summary>virtual network</summary>
        string Vnet { get; set; }

    }
}