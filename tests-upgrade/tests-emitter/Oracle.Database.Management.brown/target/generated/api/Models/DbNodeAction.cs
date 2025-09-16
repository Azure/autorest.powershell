// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>DbNode action object</summary>
    public partial class DbNodeAction :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeAction,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbNodeActionInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>Db action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string Action { get => this._action; set => this._action = value; }

        /// <summary>Creates an new <see cref="DbNodeAction" /> instance.</summary>
        public DbNodeAction()
        {

        }
    }
    /// DbNode action object
    public partial interface IDbNodeAction :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>Db action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Db action",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Start", "Stop", "SoftReset", "Reset")]
        string Action { get; set; }

    }
    /// DbNode action object
    internal partial interface IDbNodeActionInternal

    {
        /// <summary>Db action</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Start", "Stop", "SoftReset", "Reset")]
        string Action { get; set; }

    }
}