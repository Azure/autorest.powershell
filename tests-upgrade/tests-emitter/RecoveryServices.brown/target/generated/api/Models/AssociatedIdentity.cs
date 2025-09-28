// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Identity details to be used for an operation</summary>
    public partial class AssociatedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IAssociatedIdentityInternal
    {

        /// <summary>Backing field for <see cref="OperationIdentityType" /> property.</summary>
        private string _operationIdentityType;

        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string OperationIdentityType { get => this._operationIdentityType; set => this._operationIdentityType = value; }

        /// <summary>Backing field for <see cref="UserAssignedIdentity" /> property.</summary>
        private string _userAssignedIdentity;

        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string UserAssignedIdentity { get => this._userAssignedIdentity; set => this._userAssignedIdentity = value; }

        /// <summary>Creates an new <see cref="AssociatedIdentity" /> instance.</summary>
        public AssociatedIdentity()
        {

        }
    }
    /// Identity details to be used for an operation
    public partial interface IAssociatedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Identity type that should be used for an operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Identity type that should be used for an operation.",
        SerializedName = @"operationIdentityType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string OperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User assigned identity to be used for an operation if operationIdentityType is UserAssigned.",
        SerializedName = @"userAssignedIdentity",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedIdentity { get; set; }

    }
    /// Identity details to be used for an operation
    internal partial interface IAssociatedIdentityInternal

    {
        /// <summary>Identity type that should be used for an operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PSArgumentCompleterAttribute("SystemAssigned", "UserAssigned")]
        string OperationIdentityType { get; set; }
        /// <summary>
        /// User assigned identity to be used for an operation if operationIdentityType is UserAssigned.
        /// </summary>
        string UserAssignedIdentity { get; set; }

    }
}