// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>A list of server configurations to update.</summary>
    public partial class ConfigurationListForBatchUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationListForBatchUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationListForBatchUpdateInternal
    {

        /// <summary>Backing field for <see cref="ResetAllToDefault" /> property.</summary>
        private string _resetAllToDefault;

        /// <summary>Whether to reset all server parameters to default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string ResetAllToDefault { get => this._resetAllToDefault; set => this._resetAllToDefault = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationForBatchUpdate> _value;

        /// <summary>The list of server configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationForBatchUpdate> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ConfigurationListForBatchUpdate" /> instance.</summary>
        public ConfigurationListForBatchUpdate()
        {

        }
    }
    /// A list of server configurations to update.
    public partial interface IConfigurationListForBatchUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Whether to reset all server parameters to default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to reset all server parameters to default.",
        SerializedName = @"resetAllToDefault",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("True", "False")]
        string ResetAllToDefault { get; set; }
        /// <summary>The list of server configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of server configurations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationForBatchUpdate) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationForBatchUpdate> Value { get; set; }

    }
    /// A list of server configurations to update.
    internal partial interface IConfigurationListForBatchUpdateInternal

    {
        /// <summary>Whether to reset all server parameters to default.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.MySql.PSArgumentCompleterAttribute("True", "False")]
        string ResetAllToDefault { get; set; }
        /// <summary>The list of server configurations.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IConfigurationForBatchUpdate> Value { get; set; }

    }
}