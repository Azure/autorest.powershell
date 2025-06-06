// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>The extended location.</summary>
    public partial class ExtendedLocation :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocation,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IExtendedLocationInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The extended location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The extended location type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ExtendedLocation" /> instance.</summary>
        public ExtendedLocation()
        {

        }
    }
    /// The extended location.
    public partial interface IExtendedLocation :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>The extended location name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The extended location name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The extended location type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The extended location type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// The extended location.
    internal partial interface IExtendedLocationInternal

    {
        /// <summary>The extended location name.</summary>
        string Name { get; set; }
        /// <summary>The extended location type.</summary>
        string Type { get; set; }

    }
}