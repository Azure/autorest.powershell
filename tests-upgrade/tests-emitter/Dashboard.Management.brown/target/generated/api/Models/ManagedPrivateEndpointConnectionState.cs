// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>The state of managed private endpoint connection.</summary>
    public partial class ManagedPrivateEndpointConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IManagedPrivateEndpointConnectionStateInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string Status { get => this._status; }

        /// <summary>Creates an new <see cref="ManagedPrivateEndpointConnectionState" /> instance.</summary>
        public ManagedPrivateEndpointConnectionState()
        {

        }
    }
    /// The state of managed private endpoint connection.
    public partial interface IManagedPrivateEndpointConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the reason for approval/rejection of the connection.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The approval/rejection status of managed private endpoint connection.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get;  }

    }
    /// The state of managed private endpoint connection.
    internal partial interface IManagedPrivateEndpointConnectionStateInternal

    {
        /// <summary>Gets or sets the reason for approval/rejection of the connection.</summary>
        string Description { get; set; }
        /// <summary>The approval/rejection status of managed private endpoint connection.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
}