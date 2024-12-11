// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Informatica Serverless advanced custom properties</summary>
    public partial class AdvancedCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IAdvancedCustomPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>advanced custom properties key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Key { get => this._key; set => this._key = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>advanced custom properties value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AdvancedCustomProperties" /> instance.</summary>
        public AdvancedCustomProperties()
        {

        }
    }
    /// Informatica Serverless advanced custom properties
    public partial interface IAdvancedCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>advanced custom properties key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"advanced custom properties key",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get; set; }
        /// <summary>advanced custom properties value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"advanced custom properties value",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Informatica Serverless advanced custom properties
    internal partial interface IAdvancedCustomPropertiesInternal

    {
        /// <summary>advanced custom properties key</summary>
        string Key { get; set; }
        /// <summary>advanced custom properties value</summary>
        string Value { get; set; }

    }
}