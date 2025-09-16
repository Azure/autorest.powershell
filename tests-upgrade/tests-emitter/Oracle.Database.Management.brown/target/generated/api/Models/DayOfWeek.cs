// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>DayOfWeek resource properties</summary>
    public partial class DayOfWeek :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeek,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDayOfWeekInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DayOfWeek" /> instance.</summary>
        public DayOfWeek()
        {

        }
    }
    /// DayOfWeek resource properties
    public partial interface IDayOfWeek :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Name of the day of the week.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the day of the week.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday")]
        string Name { get; set; }

    }
    /// DayOfWeek resource properties
    internal partial interface IDayOfWeekInternal

    {
        /// <summary>Name of the day of the week.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday")]
        string Name { get; set; }

    }
}