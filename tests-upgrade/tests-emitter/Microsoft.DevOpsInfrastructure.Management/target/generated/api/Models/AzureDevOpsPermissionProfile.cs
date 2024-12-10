// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Defines the type of Azure DevOps pool permission.</summary>
    public partial class AzureDevOpsPermissionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAzureDevOpsPermissionProfileInternal
    {

        /// <summary>Backing field for <see cref="Group" /> property.</summary>
        private System.Collections.Generic.List<string> _group;

        /// <summary>Group email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Group { get => this._group; set => this._group = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind;

        /// <summary>Determines who has admin permissions to the Azure DevOps pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private System.Collections.Generic.List<string> _user;

        /// <summary>User email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> User { get => this._user; set => this._user = value; }

        /// <summary>Creates an new <see cref="AzureDevOpsPermissionProfile" /> instance.</summary>
        public AzureDevOpsPermissionProfile()
        {

        }
    }
    /// Defines the type of Azure DevOps pool permission.
    public partial interface IAzureDevOpsPermissionProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>Group email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Group email addresses",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Group { get; set; }
        /// <summary>Determines who has admin permissions to the Azure DevOps pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines who has admin permissions to the Azure DevOps pool.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Inherit", "CreatorOnly", "SpecificAccounts")]
        string Kind { get; set; }
        /// <summary>User email addresses</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User email addresses",
        SerializedName = @"users",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> User { get; set; }

    }
    /// Defines the type of Azure DevOps pool permission.
    internal partial interface IAzureDevOpsPermissionProfileInternal

    {
        /// <summary>Group email addresses</summary>
        System.Collections.Generic.List<string> Group { get; set; }
        /// <summary>Determines who has admin permissions to the Azure DevOps pool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Inherit", "CreatorOnly", "SpecificAccounts")]
        string Kind { get; set; }
        /// <summary>User email addresses</summary>
        System.Collections.Generic.List<string> User { get; set; }

    }
}