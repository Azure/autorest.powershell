// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>User assigned identity for the application.</summary>
    public partial class ApplicationUserAssignedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IApplicationUserAssignedIdentityInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The friendly name of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; set => this._principalId = value; }

        /// <summary>Creates an new <see cref="ApplicationUserAssignedIdentity" /> instance.</summary>
        public ApplicationUserAssignedIdentity()
        {

        }
    }
    /// User assigned identity for the application.
    public partial interface IApplicationUserAssignedIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>The friendly name of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The friendly name of user assigned identity.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The principal id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The principal id of user assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get; set; }

    }
    /// User assigned identity for the application.
    internal partial interface IApplicationUserAssignedIdentityInternal

    {
        /// <summary>The friendly name of user assigned identity.</summary>
        string Name { get; set; }
        /// <summary>The principal id of user assigned identity.</summary>
        string PrincipalId { get; set; }

    }
}