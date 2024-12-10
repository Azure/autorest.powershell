// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The response of a ExtendedZone list operation.</summary>
    public partial class ExtendedZoneListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZoneListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZoneListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZone> _value;

        /// <summary>The ExtendedZone items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZone> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ExtendedZoneListResult" /> instance.</summary>
        public ExtendedZoneListResult()
        {

        }
    }
    /// The response of a ExtendedZone list operation.
    public partial interface IExtendedZoneListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The ExtendedZone items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ExtendedZone items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZone) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZone> Value { get; set; }

    }
    /// The response of a ExtendedZone list operation.
    internal partial interface IExtendedZoneListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The ExtendedZone items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedZone> Value { get; set; }

    }
}