// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The trigger of key rotation policy lifetimeAction.</summary>
    public partial class Trigger :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ITrigger,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ITriggerInternal
    {

        /// <summary>Backing field for <see cref="TimeAfterCreate" /> property.</summary>
        private string _timeAfterCreate;

        /// <summary>
        /// The time duration after key creation to rotate the key. It only applies to rotate. It will be in ISO 8601 duration format.
        /// Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string TimeAfterCreate { get => this._timeAfterCreate; set => this._timeAfterCreate = value; }

        /// <summary>Backing field for <see cref="TimeBeforeExpiry" /> property.</summary>
        private string _timeBeforeExpiry;

        /// <summary>
        /// The time duration before key expiring to rotate or notify. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        public string TimeBeforeExpiry { get => this._timeBeforeExpiry; set => this._timeBeforeExpiry = value; }

        /// <summary>Creates an new <see cref="Trigger" /> instance.</summary>
        public Trigger()
        {

        }
    }
    /// The trigger of key rotation policy lifetimeAction.
    public partial interface ITrigger :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The time duration after key creation to rotate the key. It only applies to rotate. It will be in ISO 8601 duration format.
        /// Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The time duration after key creation to rotate the key. It only applies to rotate. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.",
        SerializedName = @"timeAfterCreate",
        PossibleTypes = new [] { typeof(string) })]
        string TimeAfterCreate { get; set; }
        /// <summary>
        /// The time duration before key expiring to rotate or notify. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The time duration before key expiring to rotate or notify. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.",
        SerializedName = @"timeBeforeExpiry",
        PossibleTypes = new [] { typeof(string) })]
        string TimeBeforeExpiry { get; set; }

    }
    /// The trigger of key rotation policy lifetimeAction.
    internal partial interface ITriggerInternal

    {
        /// <summary>
        /// The time duration after key creation to rotate the key. It only applies to rotate. It will be in ISO 8601 duration format.
        /// Eg: 'P90D', 'P1Y'.
        /// </summary>
        string TimeAfterCreate { get; set; }
        /// <summary>
        /// The time duration before key expiring to rotate or notify. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        string TimeBeforeExpiry { get; set; }

    }
}