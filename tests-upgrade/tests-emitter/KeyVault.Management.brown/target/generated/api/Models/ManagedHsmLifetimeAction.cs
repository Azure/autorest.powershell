// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    public partial class ManagedHsmLifetimeAction :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeAction,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeActionInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmAction _action;

        /// <summary>The action of key rotation policy lifetimeAction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmAction Action { get => (this._action = this._action ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmAction()); set => this._action = value; }

        /// <summary>The type of action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string ActionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmActionInternal)Action).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmActionInternal)Action).Type = value ?? null; }

        /// <summary>Internal Acessors for Action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmAction Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeActionInternal.Action { get => (this._action = this._action ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmAction()); set { {_action = value;} } }

        /// <summary>Internal Acessors for Trigger</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTrigger Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmLifetimeActionInternal.Trigger { get => (this._trigger = this._trigger ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmTrigger()); set { {_trigger = value;} } }

        /// <summary>Backing field for <see cref="Trigger" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTrigger _trigger;

        /// <summary>The trigger of key rotation policy lifetimeAction.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTrigger Trigger { get => (this._trigger = this._trigger ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ManagedHsmTrigger()); set => this._trigger = value; }

        /// <summary>
        /// The time duration after key creation to rotate the key. It only applies to rotate. It will be in ISO 8601 duration format.
        /// Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string TriggerTimeAfterCreate { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTriggerInternal)Trigger).TimeAfterCreate; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTriggerInternal)Trigger).TimeAfterCreate = value ?? null; }

        /// <summary>
        /// The time duration before key expiring to rotate or notify. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inlined)]
        public string TriggerTimeBeforeExpiry { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTriggerInternal)Trigger).TimeBeforeExpiry; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTriggerInternal)Trigger).TimeBeforeExpiry = value ?? null; }

        /// <summary>Creates an new <see cref="ManagedHsmLifetimeAction" /> instance.</summary>
        public ManagedHsmLifetimeAction()
        {

        }
    }
    public partial interface IManagedHsmLifetimeAction :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable
    {
        /// <summary>The type of action.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of action.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("rotate", "notify")]
        string ActionType { get; set; }
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
        string TriggerTimeAfterCreate { get; set; }
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
        string TriggerTimeBeforeExpiry { get; set; }

    }
    internal partial interface IManagedHsmLifetimeActionInternal

    {
        /// <summary>The action of key rotation policy lifetimeAction.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmAction Action { get; set; }
        /// <summary>The type of action.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PSArgumentCompleterAttribute("rotate", "notify")]
        string ActionType { get; set; }
        /// <summary>The trigger of key rotation policy lifetimeAction.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IManagedHsmTrigger Trigger { get; set; }
        /// <summary>
        /// The time duration after key creation to rotate the key. It only applies to rotate. It will be in ISO 8601 duration format.
        /// Eg: 'P90D', 'P1Y'.
        /// </summary>
        string TriggerTimeAfterCreate { get; set; }
        /// <summary>
        /// The time duration before key expiring to rotate or notify. It will be in ISO 8601 duration format. Eg: 'P90D', 'P1Y'.
        /// </summary>
        string TriggerTimeBeforeExpiry { get; set; }

    }
}