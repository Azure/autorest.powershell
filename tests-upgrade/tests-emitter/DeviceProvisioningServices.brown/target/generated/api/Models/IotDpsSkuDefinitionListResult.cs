// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>List of available SKUs.</summary>
    public partial class IotDpsSkuDefinitionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinitionListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinitionListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinition> _value;

        /// <summary>The IotDpsSkuDefinition items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinition> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="IotDpsSkuDefinitionListResult" /> instance.</summary>
        public IotDpsSkuDefinitionListResult()
        {

        }
    }
    /// List of available SKUs.
    public partial interface IIotDpsSkuDefinitionListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The IotDpsSkuDefinition items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The IotDpsSkuDefinition items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinition) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinition> Value { get; set; }

    }
    /// List of available SKUs.
    internal partial interface IIotDpsSkuDefinitionListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The IotDpsSkuDefinition items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IIotDpsSkuDefinition> Value { get; set; }

    }
}