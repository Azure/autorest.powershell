// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Extensions;

    /// <summary>
    /// GateConfiguration is used to define where Gates should be placed within the Update Run.
    /// </summary>
    public partial class GateConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfigurationInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The human-readable display name of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Models.IGateConfigurationInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Approval";

        /// <summary>The type of the Gate determines how it is completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="GateConfiguration" /> instance.</summary>
        public GateConfiguration()
        {

        }
    }
    /// GateConfiguration is used to define where Gates should be placed within the Update Run.
    public partial interface IGateConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.IJsonSerializable
    {
        /// <summary>The human-readable display name of the Gate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The human-readable display name of the Gate.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The type of the Gate determines how it is completed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerServiceFleet.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the Gate determines how it is completed.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// GateConfiguration is used to define where Gates should be placed within the Update Run.
    internal partial interface IGateConfigurationInternal

    {
        /// <summary>The human-readable display name of the Gate.</summary>
        string DisplayName { get; set; }
        /// <summary>The type of the Gate determines how it is completed.</summary>
        string Type { get; set; }

    }
}