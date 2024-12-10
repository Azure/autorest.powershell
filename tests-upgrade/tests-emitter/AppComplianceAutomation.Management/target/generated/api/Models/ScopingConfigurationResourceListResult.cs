// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The response of a ScopingConfigurationResource list operation.</summary>
    public partial class ScopingConfigurationResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResource> _value;

        /// <summary>The ScopingConfigurationResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResource> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ScopingConfigurationResourceListResult" /> instance.</summary>
        public ScopingConfigurationResourceListResult()
        {

        }
    }
    /// The response of a ScopingConfigurationResource list operation.
    public partial interface IScopingConfigurationResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ScopingConfigurationResource items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ScopingConfigurationResource items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResource) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResource> Value { get; set; }

    }
    /// The response of a ScopingConfigurationResource list operation.
    internal partial interface IScopingConfigurationResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ScopingConfigurationResource items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IScopingConfigurationResource> Value { get; set; }

    }
}